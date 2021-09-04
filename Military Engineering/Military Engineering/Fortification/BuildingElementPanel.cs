using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using System.Drawing;
using System.Windows.Forms;

namespace Military_Engineering.Fortification
{
    public partial class BuildingElementPanel : UserControl
    {
        public const string ERROR_TEXT = "Ошибка";
        public FortificationBoard Board {  get; private set; }
        public int ElementIndex { get; private set; }
        Color hoverColor { get; set; } = Color.FromArgb(107, 126, 152);
        Color defaultColor { get; set; }
        public BuildingElementPanel(FortificationBoard fortificationBoard, int key)
        {
            Board = fortificationBoard;
            ElementIndex = key;
            InitializeComponent();
            defaultColor = tableLayoutPanel1.BackColor;
            var element = Board.GetElement(ElementIndex);
            ElementNameLabel.Text = element.Element.Name;
            FirstTurnLabel.Text = element.Element.FirstTurn.ToString();
            SecondTurnLabel.Text = element.Element.SecondTurn.ToString();
            FutureTurnLabel.Text = element.Element.FutureTurn.ToString();
            AllTurnsLabel.Text = element.Element.AllTurns.ToString();

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
    }
}
