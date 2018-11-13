using System;
using System.Collections;
using System.Runtime.CompilerServices;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
  public class ClsBaseItems2Da : Cls2Da
  {
    public ClsBaseItems2Da(byte[] raw2DaData)
      : base(raw2DaData)
    {
    }

    public void PrintItemNamesAndTypes(ClsDialogTlk dialogtlk)
    {
      int num = 0;
      int rowsUpperBound = RowsUpperBound;
      int rowNumber = num;
      while (rowNumber <= rowsUpperBound)
      {
        object indiceData = GetIndiceData(rowNumber, "name");
        object vRight = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) ? "****" : dialogtlk.GetString(IntegerType.FromObject(indiceData));
        Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(GetIndiceData(rowNumber, "itemtype") + "," + GetIndiceData(rowNumber, "label") + ",", vRight), ","), GetIndiceData(rowNumber, "equipableslots")));
         ++rowNumber; 
      }
    }

    public ArrayList GetItemNamesAndTypesList(ClsDialogTlk dialogtlk)
    {
      ArrayList arrayList = new ArrayList();
      int num1 = 0;
      int rowsUpperBound = RowsUpperBound;
      int num2 = num1;
      while (num2 <= rowsUpperBound)
      {
        object indiceData = GetIndiceData(num2, "name");
        object obj = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)) ? "(" + GetIndiceData(num2, "label") + ")" : dialogtlk.GetString(IntegerType.FromObject(indiceData));
        arrayList.Add(new TreeBaseItem(num2, GetIndiceData(num2, "itemtype"), GetIndiceData(num2, "label"), StringType.FromObject(obj), GetIndiceData(num2, "equipableslots")));
        ++num2; 
      }
      return arrayList;
    }
  }
}
