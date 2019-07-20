using System;
using System.Collections;
using System.IO;
using System.Text;

using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Services;
using KotorTool_2._0.Services.Abstractions;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Models.CLS
{
 

  public class ClsChitinKeyProvider : IChitinKeyProvider
  {



      public ChitinKeyData data;

    public ClsChitinKeyProvider(string keyPath)
    {
      FileStream keyfs;
      _htBif = new Hashtable();
      BiffListInfo = new Hashtable();
      _keyfs = new FileStream(keyPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 570000);
      byte[] numArray = new byte[(int) (_keyfs.Length - 1L) + 1];
      Llength = _keyfs.Length;
      _rdr = new BinaryReader(_keyfs, Encoding.ASCII);
      byte[] buffer = _rdr.ReadBytes((int) _keyfs.Length);
      _rdr.Close();
      _gMs = new MemoryStream(buffer);
      _rdr = new BinaryReader(_gMs, Encoding.ASCII);
      _gMs.Seek(0L, SeekOrigin.Begin);
      long num1 = 0;
      long num2 = checked (_gMs.Length - 1L);
      long num3 = num1;
      while (num3 <= num2)
      {
        Lsum = checked (Lsum + _gMs.ReadByte());
        checked { ++num3; }
      }
      Console.WriteLine("chitin.key sum = " + StringType.FromLong(Lsum));
      _gMs.Seek(8L, SeekOrigin.Begin);
      _bifCount = _rdr.ReadInt32();
      _keyCount = _rdr.ReadInt32();
      _fileTableOff = _rdr.ReadInt32();
      _keyTableOff = _rdr.ReadInt32();
      BiffList = new BiffEntry[_bifCount];
      int num4 = 0;
      int num5 = checked (_bifCount - 1);
      int index = num4;
      while (index <= num5)
      {
        BiffList[index] = new BiffEntry(index, _gMs, checked (_fileTableOff + 12 * index));
        BiffListInfo.Add(BiffList[index].BiFname, BiffList[index]);
        if (_htBif.ContainsKey(BiffList[index].Filename))
        {
         Interaction.MsgBox("Your chitin.key file appears to contain multiple entries of the same BIF archive.\nYou may want to reinstall KotOR to fix this.", MsgBoxStyle.Exclamation, "Questionable chitin.key file");
        }
        else
          _htBif.Add(BiffList[index].Filename, BiffList[index].Filelength);
        checked { ++index; }
      }
    }

    public Hashtable GetBiffFileHash(string bifName)
    {
      if (_htResRefPlusId == null || StringType.StrCmp(_lastRequestedBifNameHash, bifName, false) != 0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        _htResRefPlusId = new Hashtable();
        int num1 = 0;
        int upperBound = BiffList.GetUpperBound(0);
        int index1 = num1;
          int num2 = 0;
        bool flag = true;
        while (index1 <= upperBound)
        {
          if (StringType.StrCmp(BiffList[index1].BiFname.ToLower(), bifName.ToLower(), false) == 0)
          {
            num2 = index1;
            flag = true;
            break;
          }
          checked { ++index1; }
        }
        if (!flag)
          return null;
        _lastRequestedBifNameHash = bifName;
        int num3 = 0;
        int num4 = checked (_keyCount - 1);
        int num5 = num3;
        while (num5 <= num4)
        {
          _gMs.Seek(checked (_keyTableOff + 22 * num5), SeekOrigin.Begin);
          stringBuilder.Length = 0;
          stringBuilder.Append(_rdr.ReadChars(16));
          int index2 = 15;
          while (Strings.Asc(stringBuilder[index2]) == 0)
          {
            checked { index2 += -1; }
            if (index2 < 0)
              break;
          }
          stringBuilder.Length = checked (index2 + 1);
          string str = stringBuilder.ToString();
          int int32 = Convert.ToInt32(_rdr.ReadUInt16());
          int num6 = _rdr.ReadInt32();
          if (num6 >> 20 == num2)
            _htResRefPlusId.Add(str + "." + ResourceIdentification.GetRsrcTypeForId(int32), num6 & 1048575);
          ++num5; 
        }
      }
      return _htResRefPlusId;
    }

    public int FindResourceIdForResourceRef(string resRef, int resType)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = 0;
      int num2 =_keyCount - 1;
      int num3 = num1;
      while (num3 <= num2)
      {
        _gMs.Seek(_keyTableOff + 22 * num3, SeekOrigin.Begin);
        stringBuilder.Length = 0;
        stringBuilder.Append(_rdr.ReadChars(16));
        int index = 15;
        while (Strings.Asc(stringBuilder[index]) == 0)
        {
          index += -1; 
          if (index < 0)
            break;
        }
        stringBuilder.Length = checked (index + 1);
        if (StringType.StrCmp(Strings.LCase(resRef), Strings.LCase(stringBuilder.ToString()), false) == 0 && Convert.ToInt32(_rdr.ReadUInt16()) == resType)
          return _rdr.ReadInt32();
         ++num3; 
      }
      return -1;
    }

    public ArrayList GetKeysForResourceType(short resType)
    {
      ArrayList arrayList = new ArrayList();
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = 0;
      int num2 = _keyCount - 1;
      int num3 = num1;
      while (num3 <= num2)
      {
        _gMs.Seek(_keyTableOff + 22 * num3, SeekOrigin.Begin);
        stringBuilder.Length = 0;
        stringBuilder.Append(_rdr.ReadChars(16));
        int index = 15;
        while (Strings.Asc(stringBuilder[index]) == 0)
        {
           index += -1; 
          if (index < 0)
            break;
        }
        stringBuilder.Length = checked (index + 1);
        if (_rdr.ReadInt16() == resType)
          arrayList.Add(new KeyEntry(stringBuilder.ToString(), resType, _rdr.ReadInt32()));
         ++num3; 
      }
      return arrayList;
    }

    public bool IsValid(int index)
    {
      if (index == 0)
        return _htBif.ContainsKey("data\\2da.bif") && ObjectType.ObjTst(_htBif["data\\2da.bif"], 431840, false) == 0 && (_htBif.ContainsKey("data\\gui.bif") && ObjectType.ObjTst(_htBif["data\\gui.bif"], 1621224, false) == 0) && (_htBif.ContainsKey("data\\items.bif") && ObjectType.ObjTst(_htBif["data\\items.bif"], 16362316, false) == 0 && (_htBif.ContainsKey("data\\layouts.bif") && ObjectType.ObjTst(_htBif["data\\layouts.bif"], 141915, false) == 0)) && (_htBif.ContainsKey("data\\legacy.bif") && ObjectType.ObjTst(_htBif["data\\legacy.bif"], 196688, false) == 0 && (_htBif.ContainsKey("data\\lightmaps.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps.bif"], 3811348, false) == 0) && (_htBif.ContainsKey("data\\lightmaps10.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps10.bif"], 4945347, false) == 0 && (_htBif.ContainsKey("data\\lightmaps11.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps11.bif"], 6972364, false) == 0))) && (_htBif.ContainsKey("data\\lightmaps12.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps12.bif"], 5192454, false) == 0 && (_htBif.ContainsKey("data\\lightmaps13.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps13.bif"], 23308504, false) == 0) && (_htBif.ContainsKey("data\\lightmaps2.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps2.bif"], 2177180, false) == 0 && (_htBif.ContainsKey("data\\lightmaps3.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps3.bif"], 3630567, false) == 0)) && (_htBif.ContainsKey("data\\lightmaps4.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps4.bif"], 19326133, false) == 0 && (_htBif.ContainsKey("data\\lightmaps5.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps5.bif"], 9694141, false) == 0) && (_htBif.ContainsKey("data\\lightmaps6.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps6.bif"], 12061343, false) == 0 && (_htBif.ContainsKey("data\\lightmaps7.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps7.bif"], 7490884, false) == 0)))) && (_htBif.ContainsKey("data\\lightmaps8.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps8.bif"], 11259740, false) == 0 && (_htBif.ContainsKey("data\\lightmaps9.bif") && ObjectType.ObjTst(_htBif["data\\lightmaps9.bif"], 4121097, false) == 0) && (_htBif.ContainsKey("data\\models.bif") && ObjectType.ObjTst(_htBif["data\\models.bif"], 954052730, false) == 0 && (_htBif.ContainsKey("data\\party.bif") && ObjectType.ObjTst(_htBif["data\\party.bif"], 6862196, false) == 0)) && (_htBif.ContainsKey("data\\player.bif") && ObjectType.ObjTst(_htBif["data\\player.bif"], 15791965, false) == 0 && (_htBif.ContainsKey("data\\scripts.bif") && ObjectType.ObjTst(_htBif["data\\scripts.bif"], 4723499, false) == 0) && (_htBif.ContainsKey("data\\sounds.bif") && ObjectType.ObjTst(_htBif["data\\sounds.bif"], 194679056, false) == 0 && (_htBif.ContainsKey("data\\templates.bif") && ObjectType.ObjTst(_htBif["data\\templates.bif"], 6259440, false) == 0))) && (_htBif.ContainsKey("data\\_newbif.bif") && ObjectType.ObjTst(_htBif["data\\_newbif.bif"], 77337, false) == 0 && (_htBif.ContainsKey("data\\textures.bif") && ObjectType.ObjTst(_htBif["data\\textures.bif"], 920772, false) == 0)));
      return index == 1 && _htBif.ContainsKey("data\\2da.bif") && ObjectType.ObjTst(_htBif["data\\2da.bif"], 908682, false) == 0 && (!BooleanType.FromObject(BooleanType.FromObject(!_htBif.ContainsKey("data\\dialogs.bif")) || BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(_htBif["data\\dialogs.bif"], 12059157, false) != 0, ObjectType.ObjTst(_htBif["data\\dialogs.bif"], 12061533, false) != 0)) ? true : (object) false) && _htBif.ContainsKey("data\\templates.bif") && (ObjectType.ObjTst(_htBif["data\\templates.bif"], 4255689, false) == 0 && _htBif.ContainsKey("data\\lightmaps.bif")) && (ObjectType.ObjTst(_htBif["data\\lightmaps.bif"], 91195876, false) == 0 && _htBif.ContainsKey("data\\models.bif") && (ObjectType.ObjTst(_htBif["data\\models.bif"], 866238402, false) == 0 && _htBif.ContainsKey("data\\textures.bif"))) && (ObjectType.ObjTst(_htBif["data\\textures.bif"], 592529, false) == 0 && _htBif.ContainsKey("data\\gui.bif") && (ObjectType.ObjTst(_htBif["data\\gui.bif"], 3163669, false) == 0 && _htBif.ContainsKey("data\\layouts.bif")) && (ObjectType.ObjTst(_htBif["data\\layouts.bif"], 153782, false) == 0 && _htBif.ContainsKey("data\\legacy.bif") && ObjectType.ObjTst(_htBif["data\\legacy.bif"], 196688, false) == 0))) && (!BooleanType.FromObject(BooleanType.FromObject(!_htBif.ContainsKey("data\\scripts.bif")) || BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(_htBif["data\\scripts.bif"], 5412777, false) != 0, ObjectType.ObjTst(_htBif["data\\scripts.bif"], 5415098, false) != 0)) ? true : (object) false) && _htBif.ContainsKey("data\\sounds.bif") && ObjectType.ObjTst(_htBif["data\\sounds.bif"], 259696688, false) == 0);
    }
  }
}
