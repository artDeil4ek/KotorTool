

namespace KotorTool_2._0.Models.GFF
{
  public class GffExoLocString
  {
    public int Size;
    public int StringRef;
    public int StringCount;
    public object[] SubStringArr;

    public GffExoLocString()
    {
    }

    public GffExoLocString(string text, int languageId = 0)
    {
      if (string.IsNullOrEmpty(text))
      {
        StringCount = 0;
        StringRef = -1;
      }
      else
      {
        StringCount = 1;
        StringRef = -1;
        SubStringArr = new object[1];
        SubStringArr[0] = new GffExoLocSubString()
        {
          StringId = languageId,
          StringLength = text.Length,
          Value = text
        };
        Size = checked (16 + text.Length);
      }
    }
  }
}
