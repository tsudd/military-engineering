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
        bool isAdjusted;
        public TextAutoAdjuster(Label label, int blindZoneLength)
        {
            isAdjusted = false;
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
                if(adjustedText == label.Text)
                {
                    return;
                }
                Size size = TextRenderer.MeasureText(text, label.Font);
                int maxSize = label.Width - BlindZoneLength;
                if(size.Width > maxSize)
                {
                    //int extraSize = size.Width - (maxSize);
                    double proportion = (double)(maxSize) / size.Width;
                    int stringSize = (int)Math.Floor(text.Length * proportion) - 3;
                    string newText = text.Substring(0, stringSize) + "...";
                    adjustedText = newText;
                    label.Text = newText;
                }
            }
            else
            {
                throw new ArgumentException("Sender object is not label");
            }
            
        }
    }
}
