using System;
using System.Collections;

namespace KotorTool_2._0.Models
{
  [Serializable]
  public class MapInfo
  {
    public ArrayList MapList;
    public string Version;

   
    public class Map
    {
      public bool L;
      public bool S;
      public bool AltS;
      public string Name;
      public string MapName;
      public string ModuleName;
      public string MapAssembler;
      public string MapCalibrator;
      public Decimal LxMul;
      public Decimal LyMul;
      public Decimal SxMul;
      public Decimal SyMul;
      public int LxOff;
      public int LyOff;
      public int SxOff;
      public int SyOff;
      public Decimal AltSxMul;
      public Decimal AltSyMul;
      public int AltSxOff;
      public int AltSyOff;
    }
  }
}
