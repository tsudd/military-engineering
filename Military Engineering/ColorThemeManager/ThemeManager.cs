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

        public List<ColorTheme> AllThemes
        {
            get
            {
                return themes.ColorThemes;
            }
        }

        public ColorTheme ColorTheme
        {
            get
            {
                return themes.ColorThemes[themes.Selected];
            }
        }

        public int SelectedIndex
        {
            get
            {
                return themes.Selected;
            }
            set
            {
                themes.Selected = value;
                UpdateConfiguration();
            }
        }
        private ThemeManager()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            themes = configurationManager.LoadConfiguration<Themes>("themes.json");
            configurationManager.SaveConfiguration<Themes>("themes.json", themes);
        }


        public static ThemeManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ThemeManager();
            }
            
            return instance;
        }

        public void UpdateConfiguration()
        {
            ConfigurationManager configurationManager = new ConfigurationManager();
            configurationManager.SaveConfiguration<Themes>("themes.json", themes);
        }
    }
}
