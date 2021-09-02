using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public BuildingElementCreatorForm(BuildingElementSelectorForm sender)
        {
            this.sender = sender;
            InitializeComponent();
        }

        public BuildingElementCreatorForm(BuildingElementSelectorForm sender, BuildingElement edit) : this(sender)
        {
            BuildingElement = edit;
            NameTextBox.Text = edit.Name;
            FirstTurnTextBox.Text = edit.FirstTurn.ToString();
            SecondTurnTextBox.Text = edit.SecondTurn.ToString();
            FutureTurnsTextBox.Text = edit.FutureTurn.ToString();
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            BuildingElement buildingElement = new BuildingElement(
                NameTextBox.Text, 
                double.Parse(FirstTurnTextBox.Text),
                double.Parse(SecondTurnTextBox.Text),
                double.Parse(FutureTurnsTextBox.Text),
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
    }
}
