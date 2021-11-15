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
        Color hoverColor;
        Color defaultColor;
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

            defaultColor = BackPanel.BackColor;
            RemoveButton.Visible = false;
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

            hoverColor = selectedTheme.HoverColor;
            BackColor = selectedTheme.MainSecondaryColor;
            InfoLabel.BackColor = selectedTheme.SecondaryMainColor;
            InfoLabel.ForeColor = selectedTheme.SecondaryForeColor;
            BackPanel.BackColor = selectedTheme.SecondaryMainColor;

            if(selectedTheme.IconType == ColorTheme.IconTypes.Alternative)
            {
                RemoveButton.Image = Properties.Resources.CrossAlternative;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, e);
        }

        private void BackPanel_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.BackColor = hoverColor;
            BackPanel.BackColor = hoverColor;

            if (!BuildingElement.IsDefault)
            {
                RemoveButton.Visible = true;
            }
        }

        private void BackPanel_MouseLeave(object sender, EventArgs e)
        {
            Unfocus();
        }

        public void Unfocus()
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

            RemoveButton.Visible = false;
        }

        private void BackPanel_Click(object sender, EventArgs e)
        {
            Clicked.Invoke(this, e);
        }
    }
}
