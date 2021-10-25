using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryConfiguration;

namespace ColorThemeManager
{
    public class ThemeManager
    {
        private static ThemeManager instance;
        Themes themes;

        private ThemeManager()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            themes = configurationManager.LoadConfiguration<Themes>("themes.json");
        }

        public static ThemeManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ThemeManager();
            }
            
            return instance;
        }

        public ColorTheme GetColorTheme()
        {
            return themes.ColorThemes[themes.Selected];
        }

    }
}
