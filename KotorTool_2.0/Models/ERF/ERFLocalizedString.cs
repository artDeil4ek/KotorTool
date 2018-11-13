// Decompiled with JetBrains decompiler
// Type: KotorTool_2.ERFLocalizedString
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

namespace KotorTool_2._0.Models.ERF
{
    public class ErfLocalizedString
    {
        public int LanguageId;
        public int StringSize;
        public char[] StringText;

        public ErfLocalizedString(int languageId, string stringText)
        {
            LanguageId = LanguageId;
            StringSize = stringText.Length;
            StringText = stringText.ToCharArray();
        }
    }
}