using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColorThemeManager
{
    public class ColorTheme
    {
        public string Name { get; set; }
        public Color MainMainColor { get; set; }
        public Color MainSecondaryColor { get; set; }
        public Color MainForeColor { get; set; }
        public Color SecondaryMainColor { get; set; }
        public Color SecondarySecondaryColor { get; set; }
        public Color SecondaryForeColor { get; set; }
        public Color SecondaryForeColorAlternative { get; set; }
        public Color HoverColor { get; set; }
        public IconTypes IconType { get; set; }
        public enum IconTypes
        {
            Default,
            Alternative
        }

        public ColorTheme()
        {
        }
    }
}
