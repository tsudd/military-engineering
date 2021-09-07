using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding;

namespace Military_Engineering.Fortification.BuildingElementSelector
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
            DefaultColor = FirstTurnTextBox.BackColor;
        }

        public BuildingElementCreatorForm(BuildingElementSelectorForm sender, BuildingElement edit) : this(sender)
        {
            BuildingElement = edit;
            NameTextBox.Text = edit.Name;
            FirstTurnTextBox.Text = edit.FirstTurn.ToString("0.###"); 
            SecondTurnTextBox.Text = edit.SecondTurn.ToString("0.###");
            FutureTurnsTextBox.Text = edit.FutureTurn.ToString("0.###");
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
                checkBox1.Checked);

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
            List<float> parsed;
            if (!Validate(out parsed, textBox.Text))
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
    }
}
