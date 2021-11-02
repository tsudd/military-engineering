using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding;
using ColorThemeManager;

namespace MilitaryEngineering.Fortification.BuildingElementSelector
{
    public partial class BuildingElementPanel : UserControl
    {
        public BuildingElement BuildingElement { get; set; }
        public event EventHandler Clicked;
        public event EventHandler Edited;
        public event EventHandler Removed;
        TextAutoAdjuster textAutoAdjuster;
        Color hoverColor { get; set; }
        Color defaultColor {  get; set; }
        ColorTheme selectedTheme;

        public BuildingElementPanel(BuildingElement buildingElement)
        {
            BuildingElement = buildingElement;
            InitializeComponent();
            SetColorTheme();
            ConfigureToolTip();
            textAutoAdjuster = new TextAutoAdjuster(InfoLabel, Width - EditButton.Location.X);
            defaultColor = panel1.BackColor;
            InfoLabel.Text = buildingElement.Name;
            RemoveButton.Visible = false;
            EditButton.Visible = false;
            
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
        private void SetColorTheme()
        {
            ThemeManager themeManager = ThemeManager.GetInstance();
            selectedTheme = themeManager.ColorTheme;

            BackColor = selectedTheme.MainSecondaryColor;
            InfoLabel.BackColor = selectedTheme.SecondaryMainColor;
            InfoLabel.ForeColor = selectedTheme.SecondaryForeColor;
            panel1.BackColor = selectedTheme.SecondaryMainColor;
            hoverColor = selectedTheme.HoverColor;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.BackColor = hoverColor;
            panel1.BackColor = hoverColor;

            if(!BuildingElement.IsDefault)
            {
                RemoveButton.Visible = true;
                EditButton.Visible = true; 
            }
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Unfocus();
        }

        public void Unfocus()
        {
            Point cursorPos = Cursor.Position;
            Point location = panel1.PointToScreen(Point.Empty);
            if (cursorPos.X > location.X && cursorPos.X < location.X + panel1.Width
                && cursorPos.Y > location.Y && cursorPos.Y < location.Y + panel1.Height)
            {
                return;
            }
            InfoLabel.BackColor = defaultColor;
            panel1.BackColor = defaultColor;
            if (!BuildingElement.IsDefault)
            {
                RemoveButton.Visible = false;
                EditButton.Visible = false;
            }
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edited?.Invoke(this, EventArgs.Empty);
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Removed?.Invoke(this, EventArgs.Empty);
        }

        private void EditButton_Load(object sender, EventArgs e)
        {

        }
    }
}
