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

namespace MilitaryEngineering.Fortification.CompositionSelector
{
    public partial class CompositionViewPanel : UserControl
    {
        TextAutoAdjuster textAutoAdjuster;
        ColorTheme selectedTheme;
        public BuildingElement BuildingElement { get; set; }
        public event EventHandler Clicked;
        public event EventHandler Removed;
        public CompositionViewPanel(BuildingElement buildingElement)
        {
            InitializeComponent();
            
            textAutoAdjuster = 
                new TextAutoAdjuster(InfoLabel, InfoLabel.Size.Width - RemoveButton.Location.X);

            BuildingElement = buildingElement;
            InfoLabel.Text = buildingElement.Name;
            SetColorTheme();
            ConfigureToolTip();
        }

        public void ConfigureToolTip()
        {
            Dictionary<string, string> description = new Dictionary<string, string>()
            {
                {"InfoLabel", BuildingElement.Description }
            };
            ToolTipAutoMapper autoMapper = new ToolTipAutoMapper(this, DescriptionToolTip, description);

            autoMapper.Map();
            autoMapper.Configure(selectedTheme);
        }

        public void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            selectedTheme = themeManager.ColorTheme;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, e);
        }
    }
}
