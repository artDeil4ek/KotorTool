using System;
using System.IO;
using System.Xml.Serialization;
using KotorTool_2._0.AppConfiguration.Settings;
using KotorTool_2._0.Options;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace KotorTool_2._0.Utils
{
    public class UserSettings : IConfigProvider
    {
        private ConfigOptions options;


        public UserSettings()
        {
             
        }

        public static UserSettings Build()
        {
            return new UserSettings();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UserSettings InitialiseSettings()
        {
            options = new ConfigOptions();
            return this;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathsAction"></param>
        /// <returns></returns>
        public UserSettings ConfigurePaths(Action<ConfigOptions.Paths> pathsAction)
        {
            pathsAction.Invoke(options.paths);
            return this;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathsAction"></param>
        /// <returns></returns>
        public UserSettings ConfigureToggles(Action<ConfigOptions.Toggles> pathsAction)
        {
             pathsAction.Invoke(options.toggles);
            return this;
        }

        public UserSettings WriteToFile()
        {
            var content = JsonConvert.SerializeObject(options.paths);
            File.WriteAllText(@"C:\TestFolder\PathsText.txt", content);
            return this;
        }
      

        public static ConfigOptions GetSettings()
        {



            ConfigOptions options;

            

            try
            {
                string path = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool")?.GetValue("path")), "settings.xml");
                ConfigOptions options2;
                if (File.Exists(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigOptions));
                    FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    options2 = (ConfigOptions) xmlSerializer.Deserialize(fileStream);
                    fileStream.Close();
                }
                else
                {
                    options2 = new ConfigOptions();
                    ConfigOptions.Paths.DefaultSaveLocation = StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool")?.GetValue("path"));
                    if (!ConfigOptions.Paths.DefaultSaveLocation.EndsWith("\\"))
                    {
                        ConfigOptions.Paths.DefaultSaveLocation = ConfigOptions.Paths.DefaultSaveLocation + "\\";
                    }
                }

                options = options2;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, String.Empty);
                options = null;
                ProjectData.ClearProjectError();
            }

            return options;
        }

        public static void SaveSettings(ConfigOptions currentSettings)
        {
            try
            {
                string path = Path.Combine(StringType.FromObject(Registry.LocalMachine?.OpenSubKey("software\\SCM\\Kotor Tool")?.GetValue("path")), "settings.xml");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ConfigOptions));
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                xmlSerializer.Serialize(fileStream, currentSettings);
                fileStream.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString());
                ProjectData.ClearProjectError();
            }
        }
    }
}