using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using MilitaryEngineering.Fortification.GainSelector;
using System.Windows.Forms.DataVisualization.Charting;
using ColorThemeManager;

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
        public FortificationForm FortForm {  get; private set; }
        public int ElementIndex { get; private set; }
        Color defaultColor { get; set; }
        Color chartForeColor;
        public BuildingElementPanel(FortificationForm fortificationForm, int key)
        {
            FortForm = fortificationForm;
            ElementIndex = key;
            InitializeComponent();
            SetColorTheme();
            CheckBox.CheckBox_Checked += (sender, e) =>
            {
                Checked = ((Controls.CheckBox)sender).Checked;
                ElementChanged?.Invoke(sender, e);
            };
            ConfigureToolTip();
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
        }

        private void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            ColorTheme selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainMainColor;
            tableLayoutPanel1.BackColor = selectedTheme.MainSecondaryColor;

            defaultColor = selectedTheme.SecondarySecondaryColor;

            ChangeMainTableLabels(selectedTheme, tableLayoutPanel1);

            FirstTurnEvaluationLabel.ForeColor = selectedTheme.MainForeColor;
            SecondTurnEvaluationLabel.ForeColor = selectedTheme.MainForeColor;
            FutureTurnEvaluationLabel.ForeColor = selectedTheme.MainForeColor;
            AllTurnEvaluationLabel.ForeColor = selectedTheme.MainForeColor;

            chart1.BackColor = selectedTheme.MainSecondaryColor;
            chart1.BorderlineColor = selectedTheme.MainMainColor;
            chart1.ChartAreas["ChartArea1"].BackColor = selectedTheme.SecondarySecondaryColor;
            chartForeColor = selectedTheme.SecondarySecondaryColor;

            AddGainButton.BackColor = selectedTheme.SecondaryMainColor;
            AddGainButton.ForeColor = selectedTheme.MainMainColor;

            if(selectedTheme.IconType == ColorTheme.IconTypes.Alternative)
            {
                CheckBox.ImgDefault = Properties.Resources.CheckBoxUncheckedAlternative;
                CheckBox.ImgDefaultHower = Properties.Resources.CheckBoxUncheckedHoverAlternative;
            }
        }

        private void ChangeMainTableLabels(ColorTheme colorTheme, object obj)
        {
            if (obj is TableLayoutPanel panel)
            {
                foreach (object obj1 in panel.Controls)
                {
                    ChangeMainTableLabels(colorTheme, obj1);
                }
            }
            else if (obj is Label label)
            {
                label.ForeColor = colorTheme.SecondarySecondaryColor;
            }
            else if(obj is ComboBox comboBox)
            {
                comboBox.BackColor = colorTheme.SecondarySecondaryColor;
                comboBox.ForeColor = colorTheme.MainForeColor;
            }
            else if(obj is TextBox textBox)
            {
                textBox.BackColor = colorTheme.SecondarySecondaryColor;
                textBox.ForeColor = colorTheme.SecondaryForeColorAlternative;
            }
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
                PeopleAmountInput.BackColor = defaultColor;
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
                AddGainButton.Text = calc.GetGainsAmount().ToString();
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
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = chartForeColor;

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
                ManPowerInput.BackColor = defaultColor;
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
                OrganizationInput.BackColor = defaultColor;
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
                AttritionRateInput.BackColor = defaultColor;
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
                WorkTimeInput.BackColor = defaultColor;
            }
            catch
            {
                WorkTimeInput.BackColor = Color.FromArgb(255, 128, 128);
            }
            ElementChanged?.Invoke(sender, e);
        }

        public void UpdateGainsAmountsList(Dictionary<int, GainAbility> gainsAbilities, List<Gain> createdGains = null)
        {
            if (gainsAbilities == null)
                return;
            var ans = new List<KeyValuePair<Gain, GainAbility>>();
            foreach (var gainAbility in gainsAbilities)
            {
                if (gainAbility.Value.Amount > 0)
                {
                    if (gainAbility.Value.WorkTime <= 0 || gainAbility.Value.WorkTime  > 24)
                    {
                        throw new ArgumentException("Введите положительные часы работы");
                    }
                    var gain = FortForm.GetGainById(gainAbility.Key);
                    if (gain == null && createdGains != null) // really hate this code
                    {
                        foreach(var g in createdGains)
                        {
                            if (g.Id == gainAbility.Key)
                            {
                                gain = g;
                                break;
                            }
                        }
                    }
                    else if (gain == null)
                    {
                        continue;
                    }
                    ans.Add(new KeyValuePair<Gain, GainAbility>(gain, gainAbility.Value));
                }
            }
            FortForm.Board.UpdateElementAbility(ElementIndex, ans, AbilityType.BuildingGain);
            //FortForm.EvaluateElements();
        }

        public void UpdateAndRemoveGains(List<Gain> gainsToUpdate, List<int> gainsToRemove)
        {
            FortForm.UpdateAndRemoveGains(gainsToUpdate, gainsToRemove);
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
