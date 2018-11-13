using System;
using System.IO;
using System.Xml.Serialization;
using KotorTool_2._0.Options;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace KotorTool_2._0.Utils
{
    public class UserSettings
    {
        public static ConfigOptions GetSettings()
        {
            ConfigOptions options1;
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

                options1 = options2;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, "");
                options1 = null;
                ProjectData.ClearProjectError();
            }

            return options1;
        }

        public static void SaveSettings(ConfigOptions currentSettings)
        {
            try
            {
                string path = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool").GetValue("path")), "settings.xml");
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