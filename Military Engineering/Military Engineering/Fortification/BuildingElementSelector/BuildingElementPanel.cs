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
    public partial class BuildingElementPanel : UserControl
    {
        public BuildingElement BuildingElement { get; set; }
        Color hoverColor { get; set; } = Color.FromArgb(107, 126, 152);
        Color defaultColor {  get; set; }
        public BuildingElementPanel(BuildingElement buildingElement)
        {
            BuildingElement = buildingElement;
            InitializeComponent();
            defaultColor = panel1.BackColor;
            InfoLabel.Text = buildingElement.Name;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.BackColor = hoverColor;
            panel1.BackColor = hoverColor;

            if(!BuildingElement.IsDefault)
            {
                CloseButton.Visible = true;
                EditButton.Visible = true; 
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Point cursorPos = Cursor.Position;
            Point location = panel1.PointToScreen(Point.Empty);
            if(cursorPos.X > location.X && cursorPos.X < location.X + panel1.Width
                && cursorPos.Y > location.Y && cursorPos.Y < location.Y + panel1.Height)
            {
                return;
            }
            InfoLabel.BackColor = defaultColor;
            panel1.BackColor = defaultColor;
            if (!BuildingElement.IsDefault)
            {
                CloseButton.Visible = false;
                EditButton.Visible = false;
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if(sender == CloseButton)
            {
                CloseButton.BackgroundImage = Properties.Resources.CrossHover;
            }
            else
            {
                EditButton.BackgroundImage = Properties.Resources.EditHover;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if(sender == CloseButton)
            {
                CloseButton.BackgroundImage = Properties.Resources.Cross;
            }
            else
            {
                EditButton.BackgroundImage = Properties.Resources.Edit;
            }
        }
    }
}
