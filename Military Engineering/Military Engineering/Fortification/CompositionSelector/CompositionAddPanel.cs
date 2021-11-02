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
        Color defaultColor;
        Color hoverColor;
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
            AddButton.Visible = false;
            SubstractButton.Visible = false;
            defaultColor = BackPanel.BackColor;
        }

        public void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            selectedTheme = themeManager.ColorTheme;

            hoverColor = selectedTheme.HoverColor;
            BackColor = selectedTheme.MainSecondaryColor;
            InfoLabel.BackColor = selectedTheme.SecondaryMainColor;
            InfoLabel.ForeColor = selectedTheme.SecondaryForeColor;
            BackPanel.BackColor = selectedTheme.SecondaryMainColor;
            CounterLabel.BackColor = selectedTheme.SecondaryMainColor;
            CounterLabel.ForeColor = selectedTheme.SecondaryForeColor;

            if(selectedTheme.IconType == ColorTheme.IconTypes.Alternative)
            {
                SubstractButton.Image = Properties.Resources.SubstractAlternative;
                AddButton.Image = Properties.Resources.AddAlternative;
            }
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

        private void InfoLabel_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.BackColor = hoverColor;
            BackPanel.BackColor = hoverColor;
            CounterLabel.BackColor = hoverColor;

            AddButton.Visible = true;
            SubstractButton.Visible = true;
        }

        private void InfoLabel_MouseLeave(object sender, EventArgs e)
        {
            Unfocus();
        }

        private void Unfocus()
        {
            Point cursorPos = Cursor.Position;
            Point location = BackPanel.PointToScreen(Point.Empty);
            if (cursorPos.X > location.X && cursorPos.X < location.X + BackPanel.Width
                && cursorPos.Y > location.Y && cursorPos.Y < location.Y + BackPanel.Height)
            {
                return;
            }

            InfoLabel.BackColor = defaultColor;
            BackPanel.BackColor = defaultColor;
            CounterLabel.BackColor = defaultColor;

            AddButton.Visible = false;
            SubstractButton.Visible = false;
        }

        private void CounterLabel_MouseLeave(object sender, EventArgs e)
        {
            Unfocus();
        }
    }
}
