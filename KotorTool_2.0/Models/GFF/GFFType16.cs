

namespace KotorTool_2._0.Models.GFF
{
  public class GffType16
  {
    public float F1;
    public float F2;
    public float F3;
    public float F4;

    public float W
    {
      get => F1;
      set => F1 = value;
    }

    public float X
    {
      get => F2;
      set => F2 = value;
    }

    public float Y
    {
      get => F3;
      set => F3 = value;
    }

    public float Z
    {
      get => F4;
      set => F4 = value;
    }

    public GffType16()
    {
    }

    public GffType16(float field1, float field2, float field3, float field4)
    {
      F1 = field1;
      F2 = field2;
      F3 = field3;
      F4 = field4;
    }
  }
}
