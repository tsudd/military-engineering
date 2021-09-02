using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MilitaryConfiguration
{
    public class ConfigurationManager
    {
        public string FileName { get; set; } = "appsetting.json";
        
        public ConfigurationManager() { }

        public ConfigurationManager(string fileName)
        {
            FileName = fileName;
        }

        public Configuration LoadConfiguration()
        {
            using (StreamReader reader = new StreamReader(FileName))
            {
                return JsonConvert.DeserializeObject<Configuration>(reader.ReadToEnd());  
            }
        }

        public void SaveConfiguration(Configuration configuration) 
        {
            using(StreamWriter sw = new StreamWriter(FileName))
            {
                sw.Write(JsonConvert.SerializeObject(configuration));
            }
        }

        public Configuration GetDefaultConfiguration()
        {
            string configuration = Properties.Resources.DefaultConfiguration;
            return JsonConvert.DeserializeObject<Configuration>(configuration); 
        }

        public void SaveDefaultConfiguration()
        {
            SaveConfiguration(GetDefaultConfiguration());
        }
    }
}
