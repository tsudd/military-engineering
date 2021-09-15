using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEngineering
{
    public class TextAutoAdjuster
    {
        public int BlindZoneLength {  get; set; }
        public Label Label;
        string text;
        string adjustedText = "";
        public TextAutoAdjuster(Label label, int blindZoneLength)
        {
            BlindZoneLength = blindZoneLength;
            Label = label;
            label.SizeChanged += (sender, e) =>
            {
                AdjustLabelText(sender, e);
            };
            label.TextChanged += (sender, e) =>
            {
                if(label.Text == adjustedText)
                {
                    return;
                }
                text = label.Text;
                AdjustLabelText(sender, e);
            };
            text = label.Text;
        }

        private void AdjustLabelText(object sender, EventArgs e)
        {
            if(sender is Label label)
            {
                Size size = TextRenderer.MeasureText(text, label.Font);
                int maxSize = label.Width - BlindZoneLength;
                if(size.Width > maxSize)
                {
                    double proportion = (double)(maxSize) / size.Width;
                    int stringSize = (int)Math.Floor(text.Length * proportion) - 3;
                    string newText;
                    if(stringSize <= 0)
                    {
                        newText = "...";
                    }
                    else
                    {
                        newText = text.Substring(0, stringSize) + "...";
                    }
                    adjustedText = newText;
                    label.Text = newText;
                }
                else
                {
                    adjustedText = text;
                    label.Text = text;
                }
            }
            else
            {
                throw new ArgumentException("Sender object is not label");
            }
            
        }
    }
}
