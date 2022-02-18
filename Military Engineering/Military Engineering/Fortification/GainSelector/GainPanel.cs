using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using ColorThemeManager;
using MilitaryEngineering.Fortification.Interfaces;

namespace MilitaryEngineering.Fortification.GainSelector
{
    public partial class GainPanel : UserControl, IVisible
    {
        Gain gainEntry;
        public Gain GainEntry
        {
            get
            {
                return gainEntry;
            }
            set
            {
                gainEntry = value;
                GainIndex = value.Id;
            }
        }
        public int GainAmount { get; private set; } = 0;
        public int GainIndex {  get; private set; }
        public event EventHandler Clicked;
        public event EventHandler Edited;
        public event EventHandler Removed;
        public delegate void IncrementGainAmount(int gainId, out int amount);
        public delegate void DecrementGainAmount(int gainId, out int amount);
        public event IncrementGainAmount Incremented;
        public event DecrementGainAmount Decremented;
        public delegate void ChangeGainTime(int gainId, double workTime);
        public event ChangeGainTime ChangedTime;
        public IncrementGainAmount IncrementGain { get; set; }
        public DecrementGainAmount DecrementGain { get; set;  }
        ColorTheme selectedTheme;
        Color hoverColor { get; set; }
        Color defaultColor {  get; set; }
        Color DefaultBoxColor;
        TextAutoAdjuster textAutoAdjuster;
        public GainPanel(Gain gain, GainAbility gainAbility)
        {
            GainEntry = gain;
            InitializeComponent();
            SetColorTheme();
            textAutoAdjuster = new TextAutoAdjuster(InfoLabel, Width - SubstractButton.Location.X);
            EditButton.Click += (sender, e) => Edited?.Invoke(this, e);
            RemoveButton.Click += (sender, e) => Removed?.Invoke(this, e);
            HideAll();
            defaultColor = panel1.BackColor;
            InfoLabel.Text = gain.Name;
            CounterLabel.Text = gainAbility.Amount.ToString();
            if (gainAbility.Amount > 0)
            {
                WorkTimeBox.ReadOnly = false;
            }
            WorkTimeBox.Text = gainAbility.WorkTime > 0 ? gainAbility.WorkTime.ToString(): "";
            DefaultBoxColor = WorkTimeBox.BackColor;
            ConfigureToolTip();
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

            WorkTimeBox.BackColor = selectedTheme.SecondarySecondaryColor;

            CounterLabel.BackColor = selectedTheme.SecondaryMainColor;
            CounterLabel.ForeColor = selectedTheme.SecondaryForeColor;

            if (selectedTheme.IconType == ColorTheme.IconTypes.Alternative)
            {
                SubstractButton.Image = Properties.Resources.SubstractAlternative;
                AddButton.Image = Properties.Resources.AddAlternative;
                EditButton.Image = Properties.Resources.EditAlternative;
                RemoveButton.Image = Properties.Resources.CrossAlternative;
            }
        }

        private void HideAll()
        {
            EditButton.Visible = false;
            RemoveButton.Visible = false;
            AddButton.Visible = false;
            SubstractButton.Visible = false;
        }

        private void ShowAll()
        {
            AddButton.Visible = true;
            SubstractButton.Visible = true;
            if (!GainEntry.IsDefault)
            {
                EditButton.Visible = true;
                RemoveButton.Visible = true;
            }
        }

        public void ConfigureToolTip()
        {
            if (string.IsNullOrEmpty(gainEntry.Description))
            {
                gainEntry.Description = Gain.CreateDefaultDescription(gainEntry.TrenchPerformance.ToString(), gainEntry.PitPerformance.ToString());
            }
            Dictionary<string, string> description = new Dictionary<string, string>()
            {
                { "InfoLabel", gainEntry.Description }
            };

            ToolTipAutoMapper autoMapper = new ToolTipAutoMapper(this, DescriptionToolTip, description);
            autoMapper.Map();
            autoMapper.Configure(selectedTheme);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.BackColor = hoverColor;
            CounterLabel.BackColor = hoverColor;
            panel1.BackColor = hoverColor;
            ShowAll();
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
            CounterLabel.BackColor = defaultColor;
            panel1.BackColor = defaultColor;
            HideAll();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            int amount = 0;
            Decremented?.Invoke(GainIndex, out amount);
            if (amount == 0)
            {
                WorkTimeBox.Text = "";
                WorkTimeBox.BackColor = DefaultBoxColor;
                WorkTimeBox.ReadOnly = true;
            }

            CounterLabel.Text = amount.ToString();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            int amount = 0;
            Incremented?.Invoke(GainIndex, out amount);
            WorkTimeBox.ReadOnly = false;
            WorkTimeBox.Text = "0";
            CounterLabel.Text = amount.ToString();
        }

        private void WorkTimeBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (double.TryParse(textBox.Text, out double num))
            {
                if (num <= 0 || num > 24)
                {
                    textBox.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    textBox.BackColor = DefaultBoxColor;              
                }
                ChangedTime?.Invoke(GainIndex, Convert.ToDouble(textBox.Text));
            }
            else
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }
        }
    }
}
