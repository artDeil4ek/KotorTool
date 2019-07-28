using System;
using System.Collections;
using System.IO;
using System.Text;
using CoreData.Biff;
using CoreData.ChitinKey;

using KotorTool_2._0.Services;
using KotorTool_2._0.Services.Abstractions;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace KotorTool_2._0.Models.CLS
{
 

  public class ChitinKeyProvider : IChitinKeyProvider
  {



      public ChitinKeyData Data;


      public ChitinKeyProvider()
      {

      }

    public ChitinKeyProvider(string keyPath)
    {
      FileStream keyFileStream;
      Data.HashtableBiff = new Hashtable();
      BiffListInfo = new Hashtable();
      Data.KeyFileStream = new FileStream(keyPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 570000);
      byte[] numArray = new byte[(int) (Data.KeyFileStream.Length - 1L) + 1];
      Data.Llength = Data.KeyFileStream.Length;
      Data.RbBinaryReader = new BinaryReader(Data.KeyFileStream, Encoding.ASCII);
      byte[] buffer = Data.RbBinaryReader.ReadBytes((int) Data.KeyFileStream.Length);
      Data.RbBinaryReader.Close();
      Data.GmMemoryStream = new MemoryStream(buffer);
      Data.RbBinaryReader = new BinaryReader(Data.GmMemoryStream, Encoding.ASCII);
      Data.GmMemoryStream.Seek(0L, SeekOrigin.Begin);
      long num1 = 0;
      long num2 = checked (Data.GmMemoryStream.Length - 1L);
      long num3 = num1;
      while (num3 <= num2)
      {
        Data.Lsum = checked (Data.Lsum + Data.GmMemoryStream.ReadByte());
        checked { ++num3; }
      }


        Console.WriteLine("chitin.key sum = " + StringType.FromLong(Data.Lsum));


        Data.GmMemoryStream.Seek(8L, SeekOrigin.Begin);
      _bifCount = Data.RbBinaryReader.ReadInt32();
      Data.KeyCount = Data.RbBinaryReader.ReadInt32();
      _fileTableOff = Data.RbBinaryReader.ReadInt32();
      Data.KeyTableOff = Data.RbBinaryReader.ReadInt32();
      Data.BiffList = new BiffEntry[_bifCount];
      int num4 = 0;
      int num5 = checked (_bifCount - 1);
      int index = num4;
      while (index <= num5)
      {
        Data.BiffList[index] = new BiffEntry(index, Data.KeyFileStream, checked (Data.FileTableOff + 12 * index));
        BiffListInfo.Add(Data.BiffList[index].BiffName, Data.BiffList[index]);
        if (Data.HashtableBiff.ContainsKey(Data.BiffList[index].Filename))
        {
         Interaction.MsgBox("Your chitin.key file appears to contain multiple entries of the same BIF archive.\nYou may want to reinstall KotOR to fix this.", MsgBoxStyle.Exclamation, "Questionable chitin.key file");
        }
        else
          Data.HashtableBiff.Add(Data.BiffList[index].Filename, Data.BiffList[index].FileLength);
        checked { ++index; }
      }
    }

    public Hashtable GetBiffFileHash(string bifName)
    {
      if (Data.HashTableResourceReferencePlusId == null || StringType.StrCmp(Data.LastRequestedBiffNameHash, bifName, false) != 0)
      {
        StringBuilder stringBuilder = new StringBuilder();
        Data.HashTableResourceReferencePlusId = new Hashtable();
        int num1 = 0;
        int upperBound = Data.BiffList.GetUpperBound(0);
        int index1 = num1;
          int num2 = 0;
        bool flag = true;
        while (index1 <= upperBound)
        {
          if (StringType.StrCmp(Data.BiffList[index1].BiffName.ToLower(), bifName.ToLower(), false) == 0)
          {
            num2 = index1;
            flag = true;
            break;
          }
          checked { ++index1; }
        }

          if (!flag)
          {
              return null;
          }
          
        Data.LastRequestedBiffNameHash = bifName;
        int num3 = 0;
        int num4 = checked (Data.KeyCount - 1);
        int num5 = num3;
        while (num5 <= num4)
        {
          Data.GmMemoryStream.Seek(checked (Data.KeyTableOff + 22 * num5), SeekOrigin.Begin);
          stringBuilder.Length = 0;
          stringBuilder.Append(Data.RbBinaryReader.ReadChars(16));
          int index2 = 15;
          while (Strings.Asc(stringBuilder[index2]) == 0)
          {
            checked { index2 += -1; }
            if (index2 < 0)
              break;
          }
          stringBuilder.Length = checked (index2 + 1);
          string str = stringBuilder.ToString();
          int int32 = Convert.ToInt32(Data.RbBinaryReader.ReadUInt16());
          int num6 = Data.RbBinaryReader.ReadInt32();
          if (num6 >> 20 == num2)
            Data.HashTableResourceReferencePlusId.Add(str + "." + ResourceIdentification.GetResourceTypeForId(int32), num6 & 1048575);
          ++num5; 
        }
      }
      return Data.HashTableResourceReferencePlusId;
    }

    public int FindResourceIdForResourceRef(string resRef, int resType)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = 0;
      int num2 =Data.KeyCount - 1;
      int num3 = num1;
      while (num3 <= num2)
      {
        Data.GmMemoryStream.Seek(Data.KeyTableOff + 22 * num3, SeekOrigin.Begin);
        stringBuilder.Length = 0;
        stringBuilder.Append(Data.RbBinaryReader.ReadChars(16));
        int index = 15;
        while (Strings.Asc(stringBuilder[index]) == 0)
        {
          index += -1; 
          if (index < 0)
            break;
        }
        stringBuilder.Length = checked (index + 1);
        if (StringType.StrCmp(Strings.LCase(resRef), Strings.LCase(stringBuilder.ToString()), false) == 0 && Convert.ToInt32(Data.RbBinaryReader.ReadUInt16()) == resType)
          return Data.RbBinaryReader.ReadInt32();
         ++num3; 
      }
      return -1;
    }

    public ArrayList GetKeysForResourceType(short resourceType)
    {
      ArrayList arrayList = new ArrayList();
      StringBuilder stringBuilder = new StringBuilder();
      int num1 = 0;
      int num2 = Data.KeyCount - 1;
      int num3 = num1;
      while (num3 <= num2)
      {
        Data.GmMemoryStream.Seek(Data.KeyTableOff + 22 * num3, SeekOrigin.Begin);
        stringBuilder.Length = 0;
        stringBuilder.Append(Data.RbBinaryReader.ReadChars(16));
        int index = 15;
        while (Strings.Asc(stringBuilder[index]) == 0)
        {
           index += -1; 
          if (index < 0)
            break;
        }
        stringBuilder.Length = checked (index + 1);
        if (Data.RbBinaryReader.ReadInt16() == resourceType)
          arrayList.Add(new KeyEntry(stringBuilder.ToString(), resourceType, Data.RbBinaryReader.ReadInt32()));
         ++num3; 
      }
      return arrayList;
    }

    public bool IsValid(int index)
    {
        if (index == 0)
        {
                return Data.HashtableBiff.ContainsKey("data\\2da.bif") 
                       && ObjectType.ObjTst(Data.HashtableBiff["data\\2da.bif"], 431840, false) == 0 
                       && (Data.HashtableBiff.ContainsKey("data\\gui.bif") 
                           && ObjectType.ObjTst(Data.HashtableBiff["data\\gui.bif"], 1621224, false) == 0) 
                       && (Data.HashtableBiff.ContainsKey("data\\items.bif") 
                           && ObjectType.ObjTst(Data.HashtableBiff["data\\items.bif"], 16362316, false) == 0 
                           && (Data.HashtableBiff.ContainsKey("data\\layouts.bif") 
                               && ObjectType.ObjTst(Data.HashtableBiff["data\\layouts.bif"], 141915, false) == 0)) 
                       && (Data.HashtableBiff.ContainsKey("data\\legacy.bif") 
                           && ObjectType.ObjTst(Data.HashtableBiff["data\\legacy.bif"], 196688, false) == 0
                          && (Data.HashtableBiff.ContainsKey("data\\lightmaps.bif") 
                              && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps.bif"], 3811348, false) == 0) 
                           && (Data.HashtableBiff.ContainsKey("data\\lightmaps10.bif") 
                               && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps10.bif"], 4945347, false) == 0 
                               && (Data.HashtableBiff.ContainsKey("data\\lightmaps11.bif") 
                                   && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps11.bif"], 6972364, false) == 0))) 
                       && (Data.HashtableBiff.ContainsKey("data\\lightmaps12.bif") 
                           && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps12.bif"], 5192454, false) == 0 
                           && (Data.HashtableBiff.ContainsKey("data\\lightmaps13.bif") 
                               && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps13.bif"], 23308504, false) == 0) 
                           && (Data.HashtableBiff.ContainsKey("data\\lightmaps2.bif") 
                               && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps2.bif"], 2177180, false) == 0 
                               && (Data.HashtableBiff.ContainsKey("data\\lightmaps3.bif") 
                                   && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps3.bif"], 3630567, false) == 0)) 
                           && (Data.HashtableBiff.ContainsKey("data\\lightmaps4.bif") 
                               && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps4.bif"], 19326133, false) == 0 
                               && (Data.HashtableBiff.ContainsKey("data\\lightmaps5.bif") 
                                   && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps5.bif"], 9694141, false) == 0) 
                               && (Data.HashtableBiff.ContainsKey("data\\lightmaps6.bif") 
                                   && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps6.bif"], 12061343, false) == 0 
                                   && (Data.HashtableBiff.ContainsKey("data\\lightmaps7.bif") 
                                       && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps7.bif"], 7490884, false) == 0)))) 
                       && (Data.HashtableBiff.ContainsKey("data\\lightmaps8.bif") 
                           && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps8.bif"], 11259740, false) == 0 
                              && (Data.HashtableBiff.ContainsKey("data\\lightmaps9.bif") 
                                && ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps9.bif"], 4121097, false) == 0) 
                                && (Data.HashtableBiff.ContainsKey("data\\models.bif") 
                                && ObjectType.ObjTst(Data.HashtableBiff["data\\models.bif"], 954052730, false) == 0 
                                  && (Data.HashtableBiff.ContainsKey("data\\party.bif") 
                                   && ObjectType.ObjTst(Data.HashtableBiff["data\\party.bif"], 6862196, false) == 0)) 
                                  && (Data.HashtableBiff.ContainsKey("data\\player.bif") 
                                  && ObjectType.ObjTst(Data.HashtableBiff["data\\player.bif"], 15791965, false) == 0 
                                   && (Data.HashtableBiff.ContainsKey("data\\scripts.bif") 
                                  && ObjectType.ObjTst(Data.HashtableBiff["data\\scripts.bif"], 4723499, false) == 0) 
                                   && (Data.HashtableBiff.ContainsKey("data\\sounds.bif") 
                                    && ObjectType.ObjTst(Data.HashtableBiff["data\\sounds.bif"], 194679056, false) == 0 
                                    && (Data.HashtableBiff.ContainsKey("data\\templates.bif") 
                                     && ObjectType.ObjTst(Data.HashtableBiff["data\\templates.bif"], 6259440, false) == 0))) 
                                    && (Data.HashtableBiff.ContainsKey("data\\_newbif.bif") 
                                     && ObjectType.ObjTst(Data.HashtableBiff["data\\_newbif.bif"], 77337, false) == 0 
                                   && (Data.HashtableBiff.ContainsKey("data\\textures.bif") 
                                 && ObjectType.ObjTst(Data.HashtableBiff["data\\textures.bif"], 920772, false) == 0)));
            }
       
      return index == 1 && Data.HashtableBiff.ContainsKey("data\\2da.bif") && ObjectType.ObjTst(Data.HashtableBiff["data\\2da.bif"], 908682, false) == 0 && (!BooleanType.FromObject(BooleanType.FromObject(!Data.HashtableBiff.ContainsKey("data\\dialogs.bif")) || BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(Data.HashtableBiff["data\\dialogs.bif"], 12059157, false) != 0, ObjectType.ObjTst(Data.HashtableBiff["data\\dialogs.bif"], 12061533, false) != 0)) ? true : (object) false) && Data.HashtableBiff.ContainsKey("data\\templates.bif") && (ObjectType.ObjTst(Data.HashtableBiff["data\\templates.bif"], 4255689, false) == 0 && Data.HashtableBiff.ContainsKey("data\\lightmaps.bif")) && (ObjectType.ObjTst(Data.HashtableBiff["data\\lightmaps.bif"], 91195876, false) == 0 && Data.HashtableBiff.ContainsKey("data\\models.bif") && (ObjectType.ObjTst(Data.HashtableBiff["data\\models.bif"], 866238402, false) == 0 && Data.HashtableBiff.ContainsKey("data\\textures.bif"))) && (ObjectType.ObjTst(Data.HashtableBiff["data\\textures.bif"], 592529, false) == 0 && Data.HashtableBiff.ContainsKey("data\\gui.bif") && (ObjectType.ObjTst(Data.HashtableBiff["data\\gui.bif"], 3163669, false) == 0 && Data.HashtableBiff.ContainsKey("data\\layouts.bif")) && (ObjectType.ObjTst(Data.HashtableBiff["data\\layouts.bif"], 153782, false) == 0 && Data.HashtableBiff.ContainsKey("data\\legacy.bif") && ObjectType.ObjTst(Data.HashtableBiff["data\\legacy.bif"], 196688, false) == 0))) && (!BooleanType.FromObject(BooleanType.FromObject(!Data.HashtableBiff.ContainsKey("data\\scripts.bif")) || BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(Data.HashtableBiff["data\\scripts.bif"], 5412777, false) != 0, ObjectType.ObjTst(Data.HashtableBiff["data\\scripts.bif"], 5415098, false) != 0)) ? true : (object) false) && Data.HashtableBiff.ContainsKey("data\\sounds.bif") && ObjectType.ObjTst(Data.HashtableBiff["data\\sounds.bif"], 259696688, false) == 0);
    }
  }
}
