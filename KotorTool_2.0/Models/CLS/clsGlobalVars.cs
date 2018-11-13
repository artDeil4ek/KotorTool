

using System.IO;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsGlobalVars : ClsGff
  {
    public ClsGlobalVars(int kotorVerIndex)
      : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsGlobalVars(FileStream fs, int kotorVerIndex)
      : base(fs, kotorVerIndex)
    {
    }

    public ClsGlobalVars(byte[] bytes, int kotorVerIndex)
      : base(bytes, kotorVerIndex)
    {
    }
  }
}
