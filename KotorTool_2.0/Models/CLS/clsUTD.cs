

using System.IO;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsUtd : ClsGff
  {
    public ClsUtd(int kotorVerIndex)
      : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsUtd(FileStream fs, int kotorVerIndex)
      : base(fs, kotorVerIndex)
    {
    }

    public ClsUtd(byte[] bytes, int kotorVerIndex)
      : base(bytes, kotorVerIndex)
    {
    }
  }
}
