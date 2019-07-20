using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.Models
{
    public class ChitinKey
    {
        private static ClsChitinKeyProvider K1ChitinKey()
        {
            return Constants.Gk1ChitinKey ?? (Constants.Gk1ChitinKey = new ClsChitinKeyProvider(ConfigOptions.Paths.KeyFileLocation(0)));
        }

        private static ClsChitinKeyProvider K2ChitinKey()
        {
            return Constants.Gk2ChitinKey ?? (Constants.Gk2ChitinKey = new ClsChitinKeyProvider(ConfigOptions.Paths.KeyFileLocation(1)));
        }

        public static ClsChitinKeyProvider KxChitinKey(int kotorVerIndex)
        {
            return kotorVerIndex == 0 ? K1ChitinKey() : K2ChitinKey();
        }
    }
}