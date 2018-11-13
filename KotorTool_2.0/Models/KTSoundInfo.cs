

using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models
{
  public class KtSoundInfo
  {
    public int DataSize;
    public int DataOffset;
    public string Format;
    
      public static KtSoundInfo GetKotorSoundInfo(object filepath)
        {
            Stream input = File.Open(StringType.FromObject(filepath), FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(input);
            string sLeft1 = new string(binaryReader.ReadChars(4));
            while (StringType.StrCmp(sLeft1, "RIFF", false) != 0)
            {
                sLeft1 = new string(binaryReader.ReadChars(4));
            }

            int num1 = (int) (binaryReader.BaseStream.Position - 4L);
            binaryReader.ReadBytes(8);
            string sLeft2;
            int num2;
            for (sLeft2 = new string(binaryReader.ReadChars(4));
                StringType.StrCmp(sLeft2, "data", false) != 0;
                sLeft2 = new string(binaryReader.ReadChars(4)))
            {
                string sLeft3 = sLeft2;
                if (StringType.StrCmp(sLeft3, "fmt ", false) == 0)
                {
                    int num3 = binaryReader.ReadInt32();
                    binaryReader.ReadInt16();
                    binaryReader.ReadInt16();
                    binaryReader.ReadInt32();
                    binaryReader.ReadInt32();
                    binaryReader.ReadInt16();
                    binaryReader.ReadInt16();
                    if (num3 > 16)
                    {
                        binaryReader.ReadBytes(num3 - 16);
                    }
                }
                else if (StringType.StrCmp(sLeft3, "fact", false) == 0)
                {
                    int count = binaryReader.ReadInt32();
                    binaryReader.ReadBytes(count);
                }
            }

            int num8 = 0;
            int num9 = 0;
            string str = "";
            if (StringType.StrCmp(sLeft2, "data", false) == 0)
            {
                if (binaryReader.ReadInt32() == 0)
                {
                    num8 = (int) binaryReader.BaseStream.Position;
                    num9 = (int) (binaryReader.BaseStream.Length - num8);
                    binaryReader.ReadBytes(1);
                    byte num3 = binaryReader.ReadByte();
                    byte num4 = binaryReader.ReadByte();
                    int num5 = (num3 & 24) >> 3;
                    int num6 = (num3 & 6) >> 1;
                    int num7 = (num4 & 240) >> 4;
/*
                    num2 = (num4 & 12) >> 2;
*/
                    str = "MPEG " + StringType.FromInteger(num5) + "-" + StringType.FromInteger(num6);
                }
                else
                {
                    num8 = num1;
                    num9 = (int) (binaryReader.BaseStream.Length - num8);
                    str = "WAVE";
                }
            }

            input.Close();
            return new KtSoundInfo {DataOffset = num8, DataSize = num9, Format = str};
        }
    
  }
}
