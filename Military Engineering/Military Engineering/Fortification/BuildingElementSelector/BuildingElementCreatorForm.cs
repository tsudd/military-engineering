using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding;
using ColorThemeManager;

namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    public partial class BuildingElementCreatorForm : Form
    {
        BuildingElementSelectorForm sender {  get; set; }
        BuildingElement BuildingElement {  get; set; }
        Color DefaultColor {  get; set; }
        public BuildingElementCreatorForm(BuildingElementSelectorForm sender)
        {
            this.sender = sender;
            InitializeComponent();
            SetColorTheme();
            DefaultColor = FirstTurnTextBox.BackColor;
            InfoLabel.Text = "СОЗДАТЬ ЭЛЕМЕНТ";
        }

        private void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            ColorTheme selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainMainColor;
            InfoLabel.ForeColor = selectedTheme.MainForeColor;
            HeaderPanel.BackColor = selectedTheme.MainSecondaryColor;

            NameLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            FirstTurnLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            SecondTurnLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            FutureTurnsLabel.ForeColor = selectedTheme.SecondarySecondaryColor;
            DescriptionLabel.ForeColor = selectedTheme.SecondarySecondaryColor;


            NameTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            FirstTurnTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            SecondTurnTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            FutureTurnsTextBox.BackColor = selectedTheme.SecondarySecondaryColor;
            DescriptionBox.BackColor = selectedTheme.SecondarySecondaryColor;

            AddElementButton.BackColor = selectedTheme.SecondaryMainColor;
            AddElementButton.ForeColor = selectedTheme.SecondaryForeColor;

            DefaultDescriptionCheckBox.ForeColor = selectedTheme.SecondarySecondaryColor;
        }

        public BuildingElementCreatorForm(BuildingElementSelectorForm sender, BuildingElement edit) : this(sender)
        {
            BuildingElement = edit;
            NameTextBox.Text = edit.Name;
            FirstTurnTextBox.Text = edit.FirstTurn.ToString("0.###"); 
            SecondTurnTextBox.Text = edit.SecondTurn.ToString("0.###");
            FutureTurnsTextBox.Text = edit.FutureTurn.ToString("0.###");
            DescriptionBox.Text = edit.Description;
            InfoLabel.Text = "РЕДАКТИРОВАТЬ ЭЛЕМЕНТ";
            DefaultDescriptionCheckBox.Checked = false;
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            List<float> parsed;
            if (!Validate(out parsed, FirstTurnTextBox.Text, SecondTurnTextBox.Text, FutureTurnsTextBox.Text))
            {
                return;
            }

            BuildingElement buildingElement = new BuildingElement(
                NameTextBox.Text, 
                parsed[0],
                parsed[1],
                parsed[2],
                checkBox1.Checked,
                ElementTypes.Pit);

            if (DefaultDescriptionCheckBox.Checked)
            {
                buildingElement.Description = BuildingElement.CreateDefaultDescription(buildingElement, 2);
            }
            else
            {
                buildingElement.Description = DescriptionBox.Text;
            }
            

            if(BuildingElement == null)
            {
                this.sender.AddNewElement(buildingElement);
            }
            else
            {
                this.sender.EditElement(BuildingElement, buildingElement);
            }
            Close();
        }

        private void TurnTextBox_TextChanged(object sender, EventArgs e)
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
            foreach(string s in args)
            {
                if (float.TryParse(s, out float num))
                {
                    if(num < 0)
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

        private void DefaultDescriptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DescriptionBox.Enabled = !DefaultDescriptionCheckBox.Checked;
        }
    }
}
