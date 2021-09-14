using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CalculationsCore.FortificationBuilding.BuildingAbilities;

namespace MilitaryEngineering.Fortification.GainSelector
{
    public partial class GainSelectorForm : Form
    {
        public BuildingElementPanel Sender {  get; private set; }
        public Dictionary<int, Gain> Gains { get; private set; } = new Dictionary<int, Gain>();
        public int GainsAmount { get; private set; } = 0;
        public GainSelectorForm(BuildingElementPanel sender)
        {
            InitializeComponent();
            Sender = sender;
            foreach(var gain in Sender.FortForm.Config.Gains)
            {
                Gains.Add(gain.Id, gain);
            }
            foreach(var gain in Sender.FortForm
                .Board
                .GetElement(Sender.ElementIndex)
                .Ability
                .BuildingGains) // really hate this code
            {
                Gains[gain.Id].Amount = gain.Amount;
                GainsAmount += gain.Amount;
            }
            AddEntries();
        }

        private void GainSelectorForm_Load(object sender, EventArgs e)
        {
            MainPanel.AutoScrollPosition = new Point(MainPanel.AutoScrollPosition.X, 0);
            MainPanel.VerticalScroll.Value = 0;
            UpdateAmountLabel();
        }

        private void CreateGainButton_Click(object sender, EventArgs e)
        {
            var form = new GainCreatorForm(this);
            form.FormClosed += (obj, args) =>
            {
                Enabled = true;
            };
            form.Show();
            Enabled = false;
        }

        public void Remove(object sender, EventArgs e)
        {
            var panel = sender as GainPanel;
            var gain = panel.GainEntry;
            Gains.Remove(gain.Id);
            MainTable.Controls.Remove(panel);
        }

        public void Edit(object sender, EventArgs e)
        {
            var gain = ((GainPanel)sender).GainEntry;
            var form = new GainCreatorForm(this, gain);

            form.FormClosed += (obj, args) =>
            {
                ((GainPanel)sender).Unfocus();
                Enabled = true;
            };
            form.Show();
            Enabled = false;
        }

        public void AddEntries()
        {
            foreach (var gain in Gains.Values)
            {
                AddEntry(gain);
            }
        }

        public void AddEntry(Gain gain)
        {
            var panel = new GainPanel(gain);
            panel.Incremented += IncrementGainAmount;
            panel.Decremented += DecrementGainAmount;
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            MainTable.Controls.Add(panel, 0, MainTable.RowCount - 1);
            panel.Dock = DockStyle.Top;
            panel.Removed += Remove;
            panel.Removed += (sender, e) => UpdateAmountLabel();
            panel.Edited += Edit;
        }

        private void IncrementGainAmount(int gainId)
        {
            try
            {
                Gains[gainId].Amount++;
                GainsAmount++;
                UpdateAmountLabel();
            }
            catch
            {
                //damn son...
            }            
        }

        private void DecrementGainAmount(int gainId)
        {
            if (Gains[gainId].Amount == 0)
            {
                return;
            }
            Gains[gainId].Amount--;
            GainsAmount--;
            UpdateAmountLabel();  
        }

        public void EditElement(Gain prevElement, Gain newElement)
        {
            Gains[prevElement.Id] = newElement;
            foreach (GainPanel panel in MainTable.Controls)
            {
                if (panel.GainEntry == prevElement)
                {
                    panel.GainEntry = newElement;
                    panel.InfoLabel.Text = newElement.Name;
                    panel.Unfocus();
                    break;
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Sender.UpdateGains(Gains.Values.ToList());
            Close();
        }

        public void UpdateAmountLabel()
        {
            AmountLabel.Text = $"Всего {GainsAmount}";
        }

        private void NoChangesButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GainSelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(var gain in Gains.Values)
            {
                gain.Amount = 0;
            }
        }
    }
}
