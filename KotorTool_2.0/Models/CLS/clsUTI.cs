

using System.IO;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsUti : ClsGff
  {
    public ClsUti(int kotorVerIndex)
      : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsUti(FileStream fs, int kotorVerIndex)
      : base(fs, kotorVerIndex)
    {
    }

    public ClsUti(byte[] bytes, int kotorVerIndex)
      : base(bytes, kotorVerIndex)
    {
    }
  }
}
