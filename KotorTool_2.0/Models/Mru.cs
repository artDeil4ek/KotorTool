using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.Models
{
    public class Mru
    {
        public void ManageMruMainFileList(string filepath, bool delete = false)
        {
            int index = ConfigOptions.MruMainFiles.IndexOf(filepath);
            if (!delete)
            {
                if (index == -1)
                {
                    ConfigOptions.MruMainFiles.Insert(0, filepath);
                    if (ConfigOptions.MruMainFiles.Count > 10)
                    {
                        while (ConfigOptions.MruMainFiles.Count > 10) ConfigOptions.MruMainFiles.RemoveAt(ConfigOptions.MruMainFiles.Count - 1);
                    }
                }
                else
                {
                    ConfigOptions.MruMainFiles.RemoveAt(index);
                    ConfigOptions.MruMainFiles.Insert(0, filepath);
                }
            }
            else if (index != -1) ConfigOptions.MruMainFiles.RemoveAt(index);

            UserSettings.SaveSettings(Constants.CurrentSettings);
        }
    }
}