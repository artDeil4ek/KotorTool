

using System.IO;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsUtm : ClsGff
  {
    public ClsUtm(int kotorVerIndex) : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsUtm(FileStream fs, int kotorVerIndex) : base(fs, kotorVerIndex)
    {
    }

    public ClsUtm(byte[] bytes, int kotorVerIndex) : base(bytes, kotorVerIndex)
    {
    }
  }
}
