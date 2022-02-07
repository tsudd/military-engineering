using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace MilitaryConfiguration
{
    public class ConfigurationManager
    {
        string path;
        public ConfigurationManager() 
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, "Kisel", "Military Engineering");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public T LoadConfiguration<T>(string fileName)
        {
            try
            {
                using (var reader = new StreamReader(Path.Combine(path, fileName)))
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
            using(var sw = new StreamWriter(Path.Combine(path, fileName)))
            {
                sw.Write(JsonConvert.SerializeObject(configuration, Formatting.Indented));
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
