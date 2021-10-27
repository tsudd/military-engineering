using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using MilitaryEngineering.Fortification.GainSelector;
using System.Windows.Forms.DataVisualization.Charting;

namespace MilitaryEngineering.Fortification
{
    public partial class BuildingElementPanel : UserControl
    {
        public const string ERROR_TEXT = "Ошибка";
        public static readonly Dictionary<string, string> coeffInfo = new Dictionary<string, string>()
        {
            { "CoeffNpersonnelLabel", "Количество личного состава в соединении (воинской части) по штату, чел" },
            { "CoeffKstaffingLabel", "Коэффициент, учитывающий укомплектованность соединения (воинской части) \nк моменту начала выполнения задач" },
            { "CoeffKorganizationLabel", "Коэффициент, учитывающий время на организационно-технологические мероприятия" },
            { "CoeffKcallingLabel", "Коэффициент, учитывающий привлечение личного состава для фортификационного оборудования \n(для мотострелковых, танковых, артиллерийских воинских частей (подразделений) Кпр = 0,6…0,7; \nдля ракетных, зенитных ракетно-артиллерийских воинских частей (подразделений) Кпр = 0,3…0,4; \nдля воинских частей (подразделений) обеспечения и обслуживания Кпр = 0,5)" },
            { "CoeffThoursLabel", "Время работы в течение одних суток, ч" },
        };
        public event EventHandler ElementChanged; 
        public bool Checked { get; set; } = false;
        public int GainsAmount { get; private set; } = 0;
        public FortificationForm FortForm {  get; private set; }
        public int ElementIndex { get; private set; }
        Color hoverColor { get; set; } = Color.FromArgb(107, 126, 152);
        Color defaultColor { get; set; }
        Image prevImage {  get; set; }
        public BuildingElementPanel(FortificationForm fortificationForm, int key)
        {
            FortForm = fortificationForm;
            ElementIndex = key;
            InitializeComponent();
            CheckBox.CheckBox_Checked += (sender, e) =>
            {
                Checked = ((Controls.CheckBox)sender).Checked;
                ElementChanged?.Invoke(sender, e);
            };
            ConfigureToolTip();
            defaultColor = tableLayoutPanel1.BackColor;
            var element = FortForm.Board.GetElement(ElementIndex);
            ElementNameLabel.Text = element.Building.Name;
            FirstTurnLabel.Text = element.Building.GetFirstTurn().ToString("0.###");
            SecondTurnLabel.Text = element.Building.GetSecondTurn().ToString("0.###");
            FutureTurnLabel.Text = element.Building.GetFutureTurn().ToString("0.###");
            AllTurnsLabel.Text = element.Building.GetAllTurns().ToString("0.###");
            AddGainButton.Text = element.Ability.BuildingGains.Count.ToString();

            SoilTypeBox.DataSource = FortificationBoard.SoilTypes;
            SoilTypeBox.DisplayMember = "Name";
            SoilTypeBox.ValueMember = "Value";

            DayTimeBox.DataSource = FortificationBoard.DayTimes;
            DayTimeBox.DisplayMember = "Name";
            DayTimeBox.ValueMember = "Value";

            PollutionsBox.DataSource = FortificationBoard.Pollutions;
            PollutionsBox.DisplayMember = "Name";
            PollutionsBox.DisplayMember = "Name";

            PeopleAmountInput.TextChanged += Evaluate;
            ManPowerInput.TextChanged += Evaluate;
            OrganizationInput.TextChanged += Evaluate;
            AttritionRateInput.TextChanged += Evaluate;
            WorkTimeInput.TextChanged += Evaluate;
            DayTimeBox.SelectedIndexChanged += Evaluate;
            SoilTypeBox.SelectedIndexChanged += Evaluate;
            PollutionsBox.SelectedIndexChanged += Evaluate;
            AddGainButton.Click += Evaluate;
        }

        void ConfigureToolTip()
        {
            ToolTipAutoMapper autoMapper = new ToolTipAutoMapper(this, CoeffInfoToolTip, coeffInfo);
            autoMapper.Map();
            CoeffInfoToolTip.OwnerDraw = true;
            CoeffInfoToolTip.Draw += (sender, e) =>
            {
                Font f = new Font("Arial", 9f);
                e.DrawBackground();
                e.DrawBorder();
                e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(1, 2));
            };
        }

        private void DayTimeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FortForm.Board.UpdateElementCondition(ElementIndex, (DayTime)DayTimeBox.SelectedItem);
            ElementChanged?.Invoke(sender, e);
        }

        private void PollutionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FortForm.Board.UpdateElementCondition(ElementIndex, (FieldPollution)PollutionsBox.SelectedItem);
            ElementChanged?.Invoke(sender, e);
        }

        private void SoilTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FortForm.Board.UpdateElementCondition(ElementIndex, (SoilType)SoilTypeBox.SelectedItem);
            ElementChanged?.Invoke(sender, e);
        }

        private void PeopleAmountInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var value = int.Parse(PeopleAmountInput.Text);
                if (value <= 0)
                {
                    PeopleAmountInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                FortForm.Board.UpdateElementAbility(ElementIndex, value, AbilityType.PeopleAmount);
                PeopleAmountInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                PeopleAmountInput.BackColor = Color.FromArgb(255, 128, 128);
            }
            ElementChanged?.Invoke(sender, e);
        }

        public void Evaluate(object sender, EventArgs e)
        {
            try
            {
                var calc = FortForm.Board.GetElement(ElementIndex);
                AddGainButton.Text = $"Всего {GainsAmount}";
                FirstTurnEvaluationLabel.Text = calc.EvaluateFirstTurn().ToString();
                SecondTurnEvaluationLabel.Text = calc.EvaluateSecondTurn().ToString();
                FutureTurnEvaluationLabel.Text = calc.EvaluateFutureTurn().ToString();
                AllTurnEvaluationLabel.Text = calc.EvaluateAllTurns().ToString();

                DrawTurnsChart();
            }
            catch
            {
                FillEvaluationLabelsWithError();
            }
            ElementChanged?.Invoke(sender, e);
        }
        public void ChangeChartInterval(double interval) => chart1.ChartAreas[0].AxisY.Maximum = interval;
        private void DrawTurnsChart()
        {
            Evaluations buildingTerms = FortForm.Board.GetElement(ElementIndex).GetBuildingTerms();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();

            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MinorGrid.LineWidth = 0;

            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Bahnschrift", 6, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(166, 180, 199);

            FortForm.UpdateChartsInterval();

            chart1.Series[0].Points.AddXY(1, buildingTerms.DaysToSettle);
            chart1.Series[1].Points.AddXY(1, buildingTerms.FirstTurn);
            chart1.Series[2].Points.AddXY(1, buildingTerms.SecondTurn);
            chart1.Series[3].Points.AddXY(1, buildingTerms.FutureTurn);
        }

        private void FillEvaluationLabelsWithError()
        {
            FirstTurnEvaluationLabel.Text = ERROR_TEXT;
            SecondTurnEvaluationLabel.Text = ERROR_TEXT;
            FutureTurnEvaluationLabel.Text = ERROR_TEXT;
            AllTurnEvaluationLabel.Text = ERROR_TEXT;
        }

        private void ManPowerInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var value = double.Parse(ManPowerInput.Text);
                if (value <= 0)
                {
                    ManPowerInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                FortForm.Board.UpdateElementAbility(ElementIndex, value, AbilityType.ManPower);
                ManPowerInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                ManPowerInput.BackColor = Color.FromArgb(255, 128, 128);
            }
            ElementChanged?.Invoke(sender, e);
        }

        private void OrganizationInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var value = double.Parse(OrganizationInput.Text);
                if (value <= 0)
                {
                    OrganizationInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                FortForm.Board.UpdateElementAbility(ElementIndex, value, AbilityType.Organization);
                OrganizationInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                OrganizationInput.BackColor = Color.FromArgb(255, 128, 128);
            }
            ElementChanged?.Invoke(sender, e);
        }

        private void AttritionRateInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var value = double.Parse(AttritionRateInput.Text);
                if (value <= 0)
                {
                    AttritionRateInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                FortForm.Board.UpdateElementAbility(ElementIndex, value, AbilityType.AttritionRate);
                AttritionRateInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                AttritionRateInput.BackColor = Color.FromArgb(255, 128, 128);
            }
            ElementChanged?.Invoke(sender, e);
        }

        private void WorkTimeInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var value = double.Parse(WorkTimeInput.Text);
                if (value <= 0)
                {
                    WorkTimeInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                FortForm.Board.UpdateElementAbility(ElementIndex, value, AbilityType.WorkTime);
                WorkTimeInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                WorkTimeInput.BackColor = Color.FromArgb(255, 128, 128);
            }
            ElementChanged?.Invoke(sender, e);
        }

        public void UpdateGainsAmountsList(Dictionary<int, GainAbility> gainsAmounts)
        {
            if (gainsAmounts == null)
                return;
            GainsAmount = 0;
            var ans = new List<KeyValuePair<Gain, GainAbility>>();
            foreach (var gainAmount in gainsAmounts)
            {
                if (gainAmount.Value.Amount > 0)
                {
                    if (gainAmount.Value.WorkTime <= 0 || gainAmount.Value.WorkTime  > 24)
                    {
                        throw new ArgumentException("Введите положительные часы работы");
                    }

                    GainsAmount += gainAmount.Value.Amount;
                    ans.Add(new KeyValuePair<Gain, GainAbility>(FortForm.GetGainById(gainAmount.Key), gainAmount.Value));
                }
            }
            FortForm.Board.UpdateElementAbility(ElementIndex, ans, AbilityType.BuildingGain);
        }

        public void UpdateAndRemoveGains(List<Gain> gainsToUpdate, List<int> gainToRemove)
        {
            FortForm.UpdateAndRemoveGains(gainsToUpdate, gainToRemove);
        }

        private void AddGainButton_Click(object sender, System.EventArgs e)
        {
            var form = new GainSelectorForm(this);
            form.FormClosed += (obj, args) =>
            {
                FortForm.Enabled = true;
            };
            form.Show(this);
            FortForm.Enabled = false; 
        }

    }
}
