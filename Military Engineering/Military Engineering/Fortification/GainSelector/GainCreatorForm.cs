using CalculationsCore.FortificationBuilding.BuildingAbilities;
using MilitaryEngineering.Fortification.GainSelector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MilitaryEngineering.Fortification
{
    public partial class GainCreatorForm : Form
    {
        Color DefaultColor { get; set; }
        GainSelectorForm Sender { get; set; }
        public Gain PrevGain { get; private set; }
        public GainCreatorForm(GainSelectorForm sender)
        {
            InitializeComponent();
            DefaultColor = TrenchPerfomanceBox.BackColor;
            Sender = sender;
        }

        public GainCreatorForm(GainSelectorForm sender, Gain edit) : this(sender)
        {
            PrevGain = edit;
            NameTextBox.Text = edit.Name;
            DescriptionBox.Text = edit.Description;
            TrenchPerfomanceBox.Text = edit.TrenchPerformance.ToString("0.###");
            PitPerfomanceBox.Text = edit.PitPerformance.ToString("0.###");
        }

        private void AddGainButton_Click(object sender, EventArgs e)
        {
            List<float> parsed;
            if (!Validate(out parsed, TrenchPerfomanceBox.Text, PitPerfomanceBox.Text))
            {
                return;
            }

            Gain gain = new Gain(
                DescriptionBox.Text,
                parsed[0],
                parsed[1],
                NameTextBox.Text);
            if (PrevGain is null)
            {
                Sender.CreateEntry(gain);
            }
            else
            {
                gain.Id = PrevGain.Id;
                Sender.EditElement(PrevGain, gain);
            }
            Close();
        }

        private bool Validate(out List<float> parsed, params string[] args)
        {
            parsed = new List<float>();
            foreach (string s in args)
            {
                if (float.TryParse(s, out float num))
                {
                    if (num < 0)
                    {
                        parsed = null;
                        return false;
                    }
                    else
                    {
                        parsed.Add(num);
                    }
                }
                else
                {
                    parsed = null;
                    return false;
                }
            }
            return true;
        }

        private void PerfomanceBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            List<float> parsed;
            if (!Validate(out parsed, textBox.Text))
            {
                textBox.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                textBox.BackColor = DefaultColor;
            }
        }
    }
}
