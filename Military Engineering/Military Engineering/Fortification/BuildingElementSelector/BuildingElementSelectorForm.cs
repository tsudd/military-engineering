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
using MilitaryConfiguration;

namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    public partial class BuildingElementSelectorForm : Form
    {
        FortificationForm Sender {  get; set; }
        List<BuildingElement> buildingElements { get; set; } = new List<BuildingElement>();
        public BuildingElementSelectorForm(FortificationForm sender, List<BuildingElement> buildingElements)
        {
            InitializeComponent();
            Sender = sender;
            foreach(BuildingElement buildingElement in buildingElements)
            {
                AddNewElement(buildingElement);
            }
        }

        private void BuildingElementSelectorForm_Load(object sender, EventArgs e)
        {
            MainPanel.AutoScrollPosition = new Point(MainPanel.AutoScrollPosition.X, 0);
            MainPanel.VerticalScroll.Value = 0;
        }

        private void CreateElementButton_Click(object sender, EventArgs e)
        {
            var form = new BuildingElementCreatorForm(this);
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show();
            Enabled = false;
        }

        public void Remove(object sender, EventArgs e)
        {
            BuildingElementPanel panel = sender as BuildingElementPanel;
            BuildingElement buildingElement = panel.BuildingElement;
            buildingElements.Remove(buildingElement);
            MainTable.Controls.Remove(panel);
        }

        public void Edit(object sender, EventArgs e)
        {
            BuildingElement buildingElement = ((BuildingElementPanel)sender).BuildingElement;
            BuildingElementCreatorForm form = new BuildingElementCreatorForm(this, buildingElement);
            
            form.FormClosed += (obj, args) =>
            {
                ((BuildingElementPanel)sender).Unfocus();
                Enabled = true;
            };
            form.Show();
            Enabled = false;
        }

        public void AddNewElement(BuildingElement buildingElement)
        {
            buildingElements.Add(buildingElement);
            var panel = new BuildingElementPanel(buildingElement);
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            MainTable.Controls.Add(panel, 0, MainTable.RowCount - 1);
            panel.Dock = DockStyle.Top;
            panel.CloseButton.Visible = false;
            panel.EditButton.Visible = false;
            panel.Clicked += (sender, e) =>
            {
                this.Sender.AddNewElement(((BuildingElementPanel)sender).BuildingElement);
                Close();
            };
            panel.Removed += Remove;
            panel.Edited += Edit;
        }

        public void EditElement(BuildingElement prevElement, BuildingElement newElement)
        {
            int index = buildingElements.IndexOf(prevElement);
            buildingElements[index] = newElement;
            foreach(BuildingElementPanel panel in MainTable.Controls)
            {
                if (panel.BuildingElement == prevElement)
                {
                    panel.BuildingElement = newElement;
                    panel.InfoLabel.Text = newElement.Name;
                    panel.Unfocus();
                    break;
                }
            }
        }

        private void BuildingElementSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sender.Config.BuildingElements = buildingElements;
        }
    }
}
