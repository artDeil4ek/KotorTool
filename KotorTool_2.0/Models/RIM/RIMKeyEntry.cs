


using KotorTool_2._0.Utils;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Models.RIM
{
  public class RimKeyEntry
  {
    public string ResourceName;
    public short ResType;
    public string ResTypeStr;
    public short ResourceId;
    public int Offset;
    public int Length;
    public int Index;

    public RimKeyEntry()
    {
    }

    public RimKeyEntry(string resourceName, short resType, short resourceId, int offset, int length, int index)
    {
      ResourceName = resourceName;
      ResType = resType;
      ResTypeStr = ResourceIdentification.GetRsrcTypeForId(resType);
      ResourceId = resourceId;
      Offset = offset;
      Length = length;
      Index = index;
    }
  }
}
