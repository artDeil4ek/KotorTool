using System;
using System.Collections;
using System.Text;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Services;

namespace KotorTool_2._0.Models.CLS
{
  public class RimParser : IRim
  {
    public int EntryCount;
    public int OffKeyList;
    public ArrayList KeyEntryList;
    private readonly byte[] _data;

    public RimParser(byte[] indata)
    {
      StringBuilder stringBuilder = new StringBuilder();
      _data = indata;
      EntryCount = (int) Math.Round(_data[12] + _data[13] * 256.0 + _data[14] * 65536.0 + _data[15] * 16777216.0);
      OffKeyList = (int) Math.Round(_data[16] + _data[17] * 256.0 + _data[18] * 65536.0 + _data[19] * 16777216.0);
      KeyEntryList = new ArrayList(EntryCount);
      int num1 = 0;
      int num2 = EntryCount - 1;
      int index = num1;
      while (index <= num2)
      {
        
        stringBuilder.Append(new ASCIIEncoding().GetString(_data, OffKeyList + index * 32, 16));
       
        int num3 = 0;
        
        while (_data[OffKeyList + num3 + index * 32] != 0)
        {
          ++num3;
          if (num3 > 15) break;
        }

        stringBuilder.Length = num3;
        string resourceName = stringBuilder.ToString();
        stringBuilder.Length = 0;
        short resType = (short) Math.Round(_data[OffKeyList + index * 32 + 16] + _data[OffKeyList + index * 32 + 17] * 256.0);
        short resourceId = (short) Math.Round(_data[OffKeyList + index * 32 + 18] + _data[OffKeyList + index * 32 + 19] * 256.0);
        int offset = (int) Math.Round(_data[OffKeyList + index * 32 + 24] + _data[OffKeyList + index * 32 + 25] * 256.0 + _data[OffKeyList + index * 32 + 26] * 65536.0 + _data[OffKeyList + index * 32 + 27] * 16777216.0);
        int length = (int) Math.Round(_data[OffKeyList + index * 32 + 28] + _data[OffKeyList + index * 32 + 29] * 256.0 + _data[OffKeyList + index * 32 + 30] * 65536.0 + _data[OffKeyList + index * 32 + 31] * 16777216.0);
        KeyEntryList.Add(new RimKeyEntry(resourceName, resType, resourceId, offset, length, index));
        ++index; 
      }
    }

    public byte[] GetRimResource(int index)
    {
      RimKeyEntry keyEntry = (RimKeyEntry) KeyEntryList[index];
      byte[] numArray = new byte[keyEntry.Length - 1 + 1];
      Array.Copy(_data, keyEntry.Offset, numArray, 0, keyEntry.Length);
      return numArray;
    }
  }
}
