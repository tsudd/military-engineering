using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryConfiguration;
using Military_Engineering.Fortification.BuildingElementSelector;
using CalculationsCore.FortificationBuilding;

namespace Military_Engineering.Fortification
{
    public partial class FortificationForm : Form
    {
        public FortificationForm()
        {
            InitializeComponent();
        }

        private void AddElementButton_Click(object sender, EventArgs e)
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            Configuration configuration = configurationManager.LoadConfiguration();
            List<BuildingElement> buildingElements = configuration.BuildingElements;
            
            BuildingElementSelectorForm form = new BuildingElementSelectorForm(this, buildingElements);
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show(this);
            Enabled = false;
        }

        public void AddNewElement(BuildingElement buildingElement)
        {
            //Someone please implement this method
            MessageBox.Show(buildingElement.Name);
        }
    }
}
