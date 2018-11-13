
using System.IO;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsUts : ClsGff
  {
    public ClsUts(int kotorVerIndex)
      : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsUts(FileStream fs, int kotorVerIndex)
      : base(fs, kotorVerIndex)
    {
    }

    public ClsUts(byte[] bytes, int kotorVerIndex)
      : base(bytes, kotorVerIndex)
    {
    }
  }
}
