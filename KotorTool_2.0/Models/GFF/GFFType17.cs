

namespace KotorTool_2._0.Models.GFF
{
  public class GffType17
  {
    public float F1;
    public float F2;
    public float F3;

    public float X
    {
      get => F1;
      set => F1 = value;
    }

    public float Y
    {
      get => F2;
      set => F2 = value;
    }

    public float Z
    {
      get => F3;
      set => F3 = value;
    }

    public GffType17()
    {
    }

    public GffType17(float field1, float field2, float field3)
    {
      F1 = field1;
      F2 = field2;
      F3 = field3;
    }
  }
}
