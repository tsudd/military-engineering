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
        public Color MainColor { get; set; }
        public Color SecondaryColor { get; set; }
        public Color ForeColor { get; set; }
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
