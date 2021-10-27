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
        public Dictionary<string, string> GainInfo = new Dictionary<string, string>();
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
        Color hoverColor { get; set; } = Color.FromArgb(107, 126, 152);
        Color defaultColor {  get; set; }
        Color DefaultBoxColor;
        TextAutoAdjuster textAutoAdjuster;
        public GainPanel(Gain gain, GainAbility gainAbility)
        {
            GainEntry = gain;
            InitializeComponent();
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
            GainInfo.Clear();
            GainInfo.Add(InfoLabel.Name, FormDescribtion());
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
            //DecrementGain?.Invoke(GainIndex);
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
            //IncrementGain?.Invoke(GainIndex);
            int amount = 0;
            Incremented?.Invoke(GainIndex, out amount);
            WorkTimeBox.ReadOnly = false;
            CounterLabel.Text = amount.ToString();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
        }

        private string FormDescribtion()
        {
            return $"{GainEntry.Description} Производительность: " +
                $"для траншей - {GainEntry.TrenchPerformance}, " +
                $"для котлованов - {GainEntry.PitPerformance}.";
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
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
