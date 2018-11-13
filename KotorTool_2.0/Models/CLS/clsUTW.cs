
using System.IO;

namespace KotorTool_2._0.Models.CLS
{ 
  public class ClsUtw : ClsGff
  {
    public ClsUtw(int kotorVerIndex)
      : base(kotorVerIndex)
    {
      KotorVersionIndex = kotorVerIndex;
    }

    public ClsUtw(FileStream fs, int kotorVerIndex)
      : base(fs, kotorVerIndex)
    {
    }

    public ClsUtw(byte[] bytes, int kotorVerIndex)
      : base(bytes, kotorVerIndex)
    {
    }
  }
}
