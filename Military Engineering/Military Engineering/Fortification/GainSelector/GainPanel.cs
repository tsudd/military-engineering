using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingAbilities;

namespace MilitaryEngineering.Fortification.GainSelector
{
    public partial class GainPanel : UserControl
    {
        Gain gainEntry;
        public readonly Dictionary<string, string> GainInfo = new Dictionary<string, string>();
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
        public int GainIndex {  get; private set; }
        public event EventHandler Clicked;
        public event EventHandler Edited;
        public event EventHandler Removed;
        public delegate void IncrementGainAmount(int gainId);
        public delegate void DecrementGainAmount(int gainId);
        public IncrementGainAmount IncrementGain { get; set; }
        public DecrementGainAmount DecrementGain { get; set;  }
        Color hoverColor { get; set; } = Color.FromArgb(107, 126, 152);
        Color defaultColor {  get; set; }

        public GainPanel(Gain gain)
        {
            GainEntry = gain;
            InitializeComponent();
            defaultColor = panel1.BackColor;
            InfoLabel.Text = gain.Name;
            CounterLabel.Text = gain.Amount.ToString();
            EditButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            GainInfo.Add(InfoLabel.Name,
                $"{gain.Description} Производительность: для траншей - {gain.TrenchPerformance}, для котлованов - {gain.PitPerformance}.");
            ConfigureToolTip();
        }

        void ConfigureToolTip()
        {
            ToolTipAutoMapper autoMapper = new ToolTipAutoMapper(this, CoeffInfoToolTip, GainInfo);
            autoMapper.Map();
            CoeffInfoToolTip.OwnerDraw = true;
            CoeffInfoToolTip.Draw += (sender, e) =>
            {
                Font f = new Font("Arial", 9f);
                e.DrawBackground();
                e.DrawBorder();
                e.Graphics.DrawString(e.ToolTipText, f, Brushes.Black, new PointF(1, 2));
            };
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            InfoLabel.BackColor = hoverColor;
            panel1.BackColor = hoverColor;

            if(!GainEntry.IsDefault)
            {
                CloseButton.Visible = true;
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
            if (!GainEntry.IsDefault)
            {
                CloseButton.Visible = false;
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

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            DecrementGain?.Invoke(GainIndex);
            CounterLabel.Text = GainEntry.Amount.ToString();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            IncrementGain?.Invoke(GainIndex);
            CounterLabel.Text = GainEntry.Amount.ToString();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender == CloseButton)
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
            if (sender == CloseButton)
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
