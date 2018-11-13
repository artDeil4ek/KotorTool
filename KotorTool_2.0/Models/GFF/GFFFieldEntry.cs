

namespace KotorTool_2._0.Models.GFF
{
  public class GffFieldEntry
  {
    public GffFieldTypes Type;
    public int LabelIndex;
    public object DataOrDataOffset;
    private int _fieldDataIndex;

    public GffFieldEntry()
    {
      _fieldDataIndex = -1;
    }
  }
}
