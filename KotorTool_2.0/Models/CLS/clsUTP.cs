

using System.IO;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsUtp : ClsGff
  {
    public ClsUtp(int kotorVerIndex) : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsUtp(FileStream fs, int kotorVerIndex) : base(fs, kotorVerIndex)
    {
    }

    public ClsUtp(byte[] bytes, int kotorVerIndex) : base(bytes, kotorVerIndex)
    {
    }
  }
}
