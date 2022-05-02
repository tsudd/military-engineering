using CalculationsCore.FortificationBuilding;
using ColorThemeManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    public partial class TrenchCreatorForm : Form
    {
        BuildingElementSelectorForm sender { get; set; }
        Color DefaultColor { get; set; }

        public TrenchCreatorForm(BuildingElementSelectorForm sender)
        {
            this.sender = sender;
            InitializeComponent();
            SetColorTheme();
            DefaultColor = NameTextBox.BackColor;
        }

        private void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            ColorTheme selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainMainColor;
            InfoLabel.ForeColor = selectedTheme.MainForeColor;
            MainPanel.BackColor = selectedTheme.MainSecondaryColor;

            NameLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            CurvFactorLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            LengthLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            FirstTurnRadioBotton.ForeColor = selectedTheme.SecondarySecondaryColor;
            SecondTurnRadioBotton.ForeColor = selectedTheme.SecondarySecondaryColor;
            FutureTurnsRadioBotton.ForeColor = selectedTheme.SecondarySecondaryColor;
            TrenchTypeRadioButton1.ForeColor = selectedTheme.SecondarySecondaryColor;
            TrenchTypeRadioButton2.ForeColor = selectedTheme.SecondarySecondaryColor;
            DescriptionLabel.ForeColor = selectedTheme.SecondarySecondaryColor;


            NameTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            LengthTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            CurvFactorTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            DescriptionBox.BackColor = selectedTheme.SecondarySecondaryColor;

            AddElementButton.BackColor = selectedTheme.SecondaryMainColor;
            AddElementButton.ForeColor = selectedTheme.SecondaryForeColor;

            DefaultDescriptionCheckBox.ForeColor = selectedTheme.SecondarySecondaryColor;
        }

        private void ValuesTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Validate(out _, textBox.Text))
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                textBox.BackColor = DefaultColor;
            }
        }

        private bool Validate(out List<float> parsed, params string[] args)
        {
            parsed = new List<float>();
            foreach (string s in args)
            { 
                if (!s.Contains(',') && float.TryParse(s, out float num))
                {
                    if (num < 0)
                    {
                        parsed = null;
                        return false;
                    }
                    else
                    {
                        parsed.Add(num);
                    }
                }
                else
                {
                    parsed = null;
                    return false;
                }
            }
            return true;
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            List<float> parsed;
            if(Validate(out parsed, LengthTextBox.Text, CurvFactorTextBox.Text))
            {
                BuildingElement trench = BuildingElement.TrenchFactory(
                    NameTextBox.Text,
                    TrenchTypeRadioButton2.Checked,
                    parsed[0],
                    parsed[1]);

                if (SecondTurnRadioBotton.Checked)
                {
                    trench.SecondTurn = trench.FirstTurn;
                    trench.FirstTurn = 0;
                }
                else if(FutureTurnsRadioBotton.Checked)
                {
                    trench.FutureTurn = trench.FirstTurn;
                    trench.FirstTurn = 0;
                }

                if (DefaultDescriptionCheckBox.Checked)
                {
                    trench.Description = BuildingElement.CreateDefaultDescriptionForTrench(trench, parsed[0], parsed[1], TrenchTypeRadioButton2.Checked, 2);
                }
                else
                {
                    trench.Description = DescriptionBox.Text;
                }

                this.sender.AddNewElement(trench);
                Close();
            }
        }

        private void DefaultDescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DescriptionBox.Enabled = !DefaultDescriptionCheckBox.Checked;
        }
    }
}
