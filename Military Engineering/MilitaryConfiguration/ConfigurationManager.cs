using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace MilitaryConfiguration
{
    public class ConfigurationManager
    {
        
        public ConfigurationManager() { }
        public T LoadConfiguration<T>(string filename)
        {
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    var config = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                    if (config == null)
                    {
                        return GetDefaultConfiguration<T>(typeof(T).Name);
                    }
                    return config;
                }
            } 
            catch
            {
                return GetDefaultConfiguration<T>(typeof(T).Name);
            }
        }

        public void SaveConfiguration<T>(string fileName, T configuration) 
        {
            using(var sw = new StreamWriter(fileName))
            {
                sw.Write(JsonConvert.SerializeObject(configuration));
            }
        }

        public T GetDefaultConfiguration<T>(string configName)
        {
            var configuration = GetConfigurationValue(configName);
            return JsonConvert.DeserializeObject<T>(configuration); 
        }

        private string GetConfigurationValue(string configName)
        {
            return typeof(Properties.Resources)
                .GetTypeInfo()
                .GetDeclaredProperty(configName)
                .GetValue(null) as string;
        }

        public void SaveDefaultConfiguration<T>(string fileName)
        {
            SaveConfiguration<T>(fileName, GetDefaultConfiguration<T>(typeof(T).Name));
        }
    }
}
