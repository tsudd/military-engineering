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
    public partial class BuildingElementSelectorForm : Form
    {
        FortificationForm sender {  get; set; }
        List<BuildingElement> buildingElements { get; set; } = new List<BuildingElement>();
        public BuildingElementSelectorForm(FortificationForm sender, List<BuildingElement> buildingElements)
        {
            InitializeComponent();
            this.sender = sender;
            for(int i = buildingElements.Count - 1; i >= 0; i--)
            {
                BuildingElement element = buildingElements[i];
                AddNewElement(element);
            }
        }

        private void BuildingElementSelectorForm_Load(object sender, EventArgs e)
        {
            MainPanel.AutoScrollPosition = new Point(MainPanel.AutoScrollPosition.X, 0);
            MainPanel.VerticalScroll.Value = 0;
        }

        private void CreateElementButton_Click(object sender, EventArgs e)
        {
            BuildingElementCreatorForm form = new BuildingElementCreatorForm(this);
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show();
            Enabled = false;
        }

        public void Panel_Click(object sender, EventArgs e)
        {
            if(sender is Label)
            {
                sender = ((Label)sender).Parent.Parent;
            }
            else
            {
                sender = ((Panel)sender).Parent;
            }
            this.sender.AddNewElement(((BuildingElementPanel)sender).BuildingElement);
            Close();
        }

        public void RemoveClick(object sender, EventArgs e)
        {
            Panel panelParent = (Panel)((Button)sender).Parent;
            BuildingElementPanel parent = (BuildingElementPanel)(panelParent.Parent);
            BuildingElement buildingElement = parent.BuildingElement;
            buildingElements.Remove(buildingElement);
            parent.Dispose();
        }

        public void EditClick(object sender, EventArgs e)
        {
            Panel panelParent = (Panel)((Button)sender).Parent;
            BuildingElementPanel parent = (BuildingElementPanel)(panelParent.Parent);
            BuildingElement buildingElement = parent.BuildingElement;
            BuildingElementCreatorForm form = new BuildingElementCreatorForm(this, buildingElement);
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show();
            Enabled = false;
        }

        public void AddNewElement(BuildingElement buildingElement)
        {
            buildingElements.Add(buildingElement);
            BuildingElementPanel panel = new BuildingElementPanel(buildingElement);
            panel.Parent = MainPanel;
            panel.Dock = DockStyle.Top;
            panel.CloseButton.Visible = false;
            panel.EditButton.Visible = false;
            panel.MouseClick += Panel_Click;
            panel.InfoLabel.MouseClick += Panel_Click;
            panel.CloseButton.Click += RemoveClick;
            panel.EditButton.Click += EditClick;
        }

        public void EditElement(BuildingElement prevElement, BuildingElement newElement)
        {
            int index = buildingElements.IndexOf(prevElement);
            buildingElements[index] = newElement;
            foreach(BuildingElementPanel child in MainPanel.Controls.OfType<BuildingElementPanel>())
            {
                if(child.BuildingElement == prevElement)
                {
                    child.BuildingElement = newElement;
                    child.InfoLabel.Text = newElement.Name;
                    break;
                }
            }

        }
    }
}
