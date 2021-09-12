using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MilitaryEngineering.Fortification
{
    public partial class BuildingElementPanel : UserControl
    {
        public const string ERROR_TEXT = "Ошибка";
        Dictionary<string, string> coeffInfo = new Dictionary<string, string>()
        {
            { "CoeffNpersonnelLabel", "Количество личного состава в соединении (воинской части) по штату, чел" },
            { "CoeffKstaffingLabel", "Коэффициент, учитывающий укомплектованность соединения (воинской части) \nк моменту начала выполнения задач" },
            { "CoeffKorganizationLabel", "Коэффициент, учитывающий время на организационно-технологические мероприятия" },
            { "CoeffKcallingLabel", "Коэффициент, учитывающий привлечение личного состава для фортификационного оборудования \n(для мотострелковых, танковых, артиллерийских воинских частей (подразделений) Кпр = 0,6…0,7; \nдля ракетных, зенитных ракетно-артиллерийских воинских частей (подразделений) Кпр = 0,3…0,4; \nдля воинских частей (подразделений) обеспечения и обслуживания Кпр = 0,5)" },
            { "CoeffThoursLabel", "Время работы в течение одних суток, ч" },
        };

        public bool Checked { get; set; } = false;
        public FortificationBoard Board {  get; private set; }
        public int ElementIndex { get; private set; }
        Color hoverColor { get; set; } = Color.FromArgb(107, 126, 152);
        Color defaultColor { get; set; }
        Image prevImage {  get; set; }
        public BuildingElementPanel(FortificationBoard fortificationBoard, int key)
        {
            Board = fortificationBoard;
            ElementIndex = key;
            InitializeComponent();
            checkBox1.CheckBox_Checked += (sender, e) =>
            {
                Checked = ((CheckBox)sender).Checked;
            };
            ConfigureToolTip();
            defaultColor = tableLayoutPanel1.BackColor;
            var element = Board.GetElement(ElementIndex);
            ElementNameLabel.Text = element.Element.Name;
            FirstTurnLabel.Text = element.Element.FirstTurn.ToString("0.###");
            SecondTurnLabel.Text = element.Element.SecondTurn.ToString("0.###");
            FutureTurnLabel.Text = element.Element.FutureTurn.ToString("0.###");
            AllTurnsLabel.Text = element.Element.AllTurns.ToString("0.###");

            SoilTypeBox.DataSource = Board.SoilTypes;
            SoilTypeBox.DisplayMember = "Name";
            SoilTypeBox.ValueMember = "Value";

            DayTimeBox.DataSource = Board.DayTimes;
            DayTimeBox.DisplayMember = "Name";
            DayTimeBox.ValueMember = "Value";

            PollutionsBox.DataSource = Board.Pollutions;
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

            foreach(var gain in Board.gainFacilities)
            {
                GainBox.Items.Add(gain.Name);
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
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DayTimeBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Board.UpdateElementCondition(ElementIndex, (DayTime)DayTimeBox.SelectedItem);
        }

        private void PollutionsBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Board.UpdateElementCondition(ElementIndex, (FieldPollution)PollutionsBox.SelectedItem);
        }

        private void SoilTypeBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Board.UpdateElementCondition(ElementIndex, (SoilType)SoilTypeBox.SelectedItem);
        }

        private void PeopleAmountInput_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                var value = int.Parse(PeopleAmountInput.Text);
                if (value <= 0)
                {
                    PeopleAmountInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                Board.UpdateElementAbility(ElementIndex, value, AbilityType.PeopleAmount);
                PeopleAmountInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                PeopleAmountInput.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void Evaluate(object sender, System.EventArgs e)
        {
            try
            {
                var calc = Board.GetElement(ElementIndex);
                FirstTurnEvaluationLabel.Text = calc.EvaluateFirstTurn().ToString();
                SecondTurnEvaluationLabel.Text = calc.EvaluateSecondTurn().ToString();
                FutureTurnEvaluationLabel.Text = calc.EvaluateFutureTurn().ToString();
                AllTurnEvaluationLabel.Text = calc.EvaluateAllTurns().ToString();
            }
            catch
            {
                FillEvaluationLabelsWithError();
            }
        }

        private void FillEvaluationLabelsWithError()
        {
            FirstTurnEvaluationLabel.Text = ERROR_TEXT;
            SecondTurnEvaluationLabel.Text = ERROR_TEXT;
            FutureTurnEvaluationLabel.Text = ERROR_TEXT;
            AllTurnEvaluationLabel.Text = ERROR_TEXT;
        }

        private void ManPowerInput_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                var value = double.Parse(ManPowerInput.Text);
                if (value <= 0)
                {
                    ManPowerInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                Board.UpdateElementAbility(ElementIndex, value, AbilityType.ManPower);
                ManPowerInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                ManPowerInput.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void OrganizationInput_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                var value = double.Parse(OrganizationInput.Text);
                if (value <= 0)
                {
                    OrganizationInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                Board.UpdateElementAbility(ElementIndex, value, AbilityType.Organization);
                OrganizationInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                OrganizationInput.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void AttritionRateInput_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                var value = double.Parse(AttritionRateInput.Text);
                if (value <= 0)
                {
                    AttritionRateInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                Board.UpdateElementAbility(ElementIndex, value, AbilityType.AttritionRate);
                AttritionRateInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                AttritionRateInput.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void WorkTimeInput_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                var value = double.Parse(WorkTimeInput.Text);
                if (value <= 0)
                {
                    WorkTimeInput.BackColor = Color.FromArgb(255, 128, 128);
                    return;
                }
                Board.UpdateElementAbility(ElementIndex, value, AbilityType.WorkTime);
                WorkTimeInput.BackColor = Color.FromArgb(119, 141, 169);
            }
            catch
            {
                WorkTimeInput.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void GainBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
          
        }

        public void UpdateGainBox()
        {
            GainBox.Items.Clear();
            foreach (var gain in Board.gainFacilities)
            {
                GainBox.Items.Add(gain.Name);
            }
        }
    }
}
