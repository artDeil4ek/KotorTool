using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.Models
{
    public class Mru
    {
        public void ManageMruMainFileList(string filepath, bool delete = false)
        {
            int index = ConfigOptions.ConfigData.MruMainFiles.IndexOf(filepath);
            if (!delete)
            {
                if (index == -1)
                {
                    ConfigOptions.ConfigData.MruMainFiles.Insert(0, filepath);
                    if (ConfigOptions.ConfigData.MruMainFiles.Count > 10)
                    {
                        while (ConfigOptions.ConfigData.MruMainFiles.Count > 10) ConfigOptions.ConfigData.MruMainFiles.RemoveAt(ConfigOptions.ConfigData.MruMainFiles.Count - 1);
                    }
                }
                else
                {
                    ConfigOptions.ConfigData.MruMainFiles.RemoveAt(index);
                    ConfigOptions.ConfigData.MruMainFiles.Insert(0, filepath);
                }
            }
            else if (index != -1) ConfigOptions.ConfigData.MruMainFiles.RemoveAt(index);

            UserSettings.SaveSettings(Constants.CurrentSettings);
        }
    }
}