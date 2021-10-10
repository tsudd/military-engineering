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
        public List<Gain> Gains { get; private set; } = new List<Gain>();
        public Dictionary<int, GainAbility> Amounts { get; private set; } = new Dictionary<int, GainAbility>();
        public List<int> GainsToRemove { get; private set; } = new List<int>();
        public Dictionary<int, Gain> GainsToUpdate { get; private set; } = new Dictionary<int, Gain>();
        public int GainsAmount { get; private set; } = 0;
        public GainSelectorForm(BuildingElementPanel sender)
        {
            InitializeComponent();
            Sender = sender;
            foreach(var gain in Sender.FortForm.Config.Gains)
            {
                var g = new Gain(gain);
                Gains.Add(g);
                Amounts.Add(g.Id, new GainAbility(0, 0));
            }
            foreach(var gain in Sender.FortForm
                .Board
                .GetElement(Sender.ElementIndex)
                .Ability
                .BuildingGains) // really hate this code
            {
                Amounts[gain.Key.Id] = gain.Value;
                GainsAmount += gain.Value.Amount;
            }
            AddEntries();
            UpdateAmountLabel();
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
            RemoveGain(gain);
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
            MainTable.Controls.Clear();
            foreach (var gain in Gains)
            {
                AddEntry(gain);
            }
        }

        public void AddEntry(Gain gain)
        {
            var panel = new GainPanel(gain, Amounts[gain.Id]);
            panel.Incremented += IncrementGainAmount;
            panel.Decremented += DecrementGainAmount;
            panel.ChangedTime += ChangeGainWorkTime;
            MainTable.RowCount++;
            MainTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            MainTable.Controls.Add(panel, 0, MainTable.RowCount - 1);
            panel.Dock = DockStyle.Top;
            panel.Removed += Remove;
            panel.Removed += (sender, e) => UpdateAmountLabel();
            panel.Edited += Edit;
        }

        private void ChangeGainWorkTime(int gainId, double workTime)
        {
            GainAbility gainAbility = Amounts[gainId];
            gainAbility.WorkTime = workTime;
            Amounts[gainId] = gainAbility;
        }

        private void IncrementGainAmount(int gainId, out int amount)
        {
            try
            {
                GainAbility gainAbility = Amounts[gainId];
                gainAbility.Amount++;
                Amounts[gainId] = gainAbility;
                amount = gainAbility.Amount;
                GainsAmount++;
                UpdateAmountLabel();
            }
            catch
            {
                amount = 0;
                //damn son...
            }            
        }

        private void DecrementGainAmount(int gainId, out int amount)
        {
            if (Amounts[gainId].Amount == 0)
            {
                amount = 0;
                return;
            }
            GainAbility gainAbility = Amounts[gainId];
            gainAbility.Amount--;
            Amounts[gainId] = gainAbility;
            amount = Amounts[gainId].Amount;
            GainsAmount--;
            UpdateAmountLabel();  
        }

        public void EditElement(Gain prevGain, Gain newGain)
        {
            if (prevGain == null)
            {
                prevGain = newGain;
            }
            foreach (GainPanel panel in MainTable.Controls)
            {
                if (panel.GainEntry == prevGain)
                {
                    var index = Gains.IndexOf(prevGain);

                    AddGainToUpdateList(newGain);
                    panel.GainEntry = newGain;
                    panel.ConfigureToolTip();
                    panel.InfoLabel.Text = newGain.Name;
                    panel.Unfocus();
                    break;
                }
            }
        }

        private void UpdateGain(Gain gain)
        {
            foreach(var ga in Gains)
            {
                if (ga.Id == gain.Id)
                {
                    Gains[Gains.IndexOf(ga)] = gain;
                    break;
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Sender.UpdateAndRemoveGains(GainsToUpdate.Values.ToList(), GainsToRemove);
            Sender.UpdateGainsAmountsList(Amounts);
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
            MainTable.Controls.Clear();
            Gains.Clear();
            Amounts.Clear();
            GainsToRemove.Clear();
            GainsToUpdate.Clear();
        }

        public void AddGainToUpdateList(Gain gain)
        {
            if (GainsToUpdate.ContainsKey(gain.Id))
            {
                GainsToUpdate[gain.Id] = gain;
            }
            else
            {
                GainsToUpdate.Add(gain.Id, gain);
            }
        }

        public void CreateEntry(Gain gain)
        {
            Gains.Add(gain);
            GainsToUpdate.Add(gain.Id, gain);
            Amounts.Add(gain.Id, new GainAbility(0, 0));
            AddEntry(gain);
        }

        private void RemoveGain(Gain gain)
        {
            if (GainsToUpdate.ContainsKey(gain.Id))
            {
                GainsToUpdate.Remove(gain.Id);
            }
            GainsToRemove.Add(gain.Id);
            GainsAmount -= Amounts[gain.Id].Amount;
            Amounts.Remove(gain.Id);
            Gains.Remove(gain);
            UpdateAmountLabel();
        }
    }
}
