

using System.Runtime.CompilerServices;

namespace KotorTool_2._0.Models.GFF
{
  public class GffField
  {
    public GffFieldTypes Type;
    public int LabelIndex;
    public string Label;
    public object Value;
    public int DataOffset;

    public GffField(GffFieldTypes fieldType, string fieldLabel, object fieldValue)
    {
      Type = fieldType;
      Label = fieldLabel;
      Value = RuntimeHelpers.GetObjectValue(fieldValue);
    }

    public GffField()
    {
      
    }
  }
}
