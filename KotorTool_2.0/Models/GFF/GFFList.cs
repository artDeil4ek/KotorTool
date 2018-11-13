

using System.Collections;

namespace KotorTool_2._0.Models.GFF
{
  public class GffList
  {
    public int Size;
    public readonly ArrayList StructIndices;

    public GffList(int count)
    {
      Size = count;
      StructIndices = new ArrayList(count);
      if (count <= 0) return;
      int num1 = 0;
      int num2 = count - 1;
      int num3 = num1;
      while (num3 <= num2)
      {
        StructIndices.Add(-1);
        ++num3; 
      }
    }
  }
}
