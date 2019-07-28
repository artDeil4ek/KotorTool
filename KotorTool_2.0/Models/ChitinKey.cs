using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.Models
{
    public class ChitinKey
    {
        private static ChitinKeyProvider K1ChitinKey()
        {
            return Constants.Gk1ChitinKey ?? (Constants.Gk1ChitinKey = new ChitinKeyProvider(ConfigOptions.Paths.KeyFileLocation(0)));
        }

        private static ChitinKeyProvider K2ChitinKey()
        {
            return Constants.Gk2ChitinKey ?? (Constants.Gk2ChitinKey = new ChitinKeyProvider(ConfigOptions.Paths.KeyFileLocation(1)));
        }

        public static ChitinKeyProvider KxChitinKey(int kotorVersionIndex)
        {
            return kotorVersionIndex == 0 ? K1ChitinKey() : K2ChitinKey();
        }
    }
}