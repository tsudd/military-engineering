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
using ColorThemeManager;

namespace MilitaryEngineering.Fortification.CompositionSelector
{
    public partial class CompositionAddPanel : UserControl
    {
        public int Count { get; set; }
        public BuildingElement BuildingElement { get; set; }
        ColorTheme selectedTheme;
        public CompositionAddPanel(BuildingElement buildingElement)
        {
            InitializeComponent();
            TextAutoAdjuster autoAdjuster = new TextAutoAdjuster(InfoLabel, InfoLabel.Size.Width - SubstractButton.Location.X);
            BuildingElement = buildingElement;
            AddButton.Click += (sender, e) =>
            {
                Count++;
                CounterLabel.Text = Count.ToString();
            };

            SubstractButton.Click += (sender, e) =>
            {
                if (Count > 0)
                {
                    Count--;
                    CounterLabel.Text = Count.ToString();
                }
            };

            InfoLabel.Text = buildingElement.Name;

            SetColorTheme();
            ConfigureToolTip();
        }

        public void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            selectedTheme = themeManager.ColorTheme;

        }

        public void ConfigureToolTip()
        {
            Dictionary<string, string> description = new Dictionary<string, string>()
            {
                { "InfoLabel", BuildingElement.Description }
            };

            ToolTipAutoMapper autoMapper = new ToolTipAutoMapper(this, DescriptionToolTip, description);
            autoMapper.Map();
            autoMapper.Configure(selectedTheme);
        }
    }
}
