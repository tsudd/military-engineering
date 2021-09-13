using CalculationsCore.FortificationBuilding.BuildingAbilities;
using MilitaryEngineering.Fortification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering.Fortification
{
    public partial class GainCreatorForm : Form
    {
        Color DefaultColor { get; set; }
        FortificationForm sender { get; set; }
        public GainCreatorForm(FortificationForm sender)
        {
            InitializeComponent();
            DefaultColor = TrenchPerfomanceBox.BackColor;
            this.sender = sender;
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

            this.sender.Board.AddGainFacility(gain);
            this.sender.UpdateAllElementsGain();
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
