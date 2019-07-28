
namespace KotorTool_2._0.Models.ERF
{
    public class ErfLocalizedString
    {
        public int LanguageId;
        public int StringSize;
        public char[] StringText;

        public ErfLocalizedString(int languageId, string stringText)
        {
            LanguageId = languageId;
            StringSize = stringText.Length;
            StringText = stringText.ToCharArray();
        }
    }
}