using System;
using System.Collections;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class ColumnEntryList : ArrayList
  {
    public const int NativeColumnName = 1;
    public const int DisplayColumnName = 2;

    public void Copy(ColumnEntryList theCopy)
    {
      foreach (ColumnEntry columnEntry in this) theCopy.Add(new ColumnEntry(columnEntry.ColName, columnEntry.DisplayName));
    }

    public int IndexOf(string searchStr, int column = 1)
    {
      int num1 = 0;
      int num2 = checked(Count - 1);
      int index = num1;
      while (index <= num2)
      {
        ColumnEntry columnEntry = (ColumnEntry) this[index];
        if (column == 1)
        {
          if (StringType.StrCmp(Strings.LCase(columnEntry.ColName), Strings.LCase(searchStr), false) == 0) return index;
        }
        else if (column == 2 && StringType.StrCmp(Strings.LCase(columnEntry.DisplayName), Strings.LCase(searchStr), false) == 0) return index;

        checked
        {
          ++index;
        }
      }

      return -1;
    }

    public bool get_ColumnVisible(string columnName)
    {
      return BooleanType.FromObject(LateBinding.LateGet(this[IndexOf(columnName, 1)], null, "visible", new object[0], null, null));
    }

    public void set_ColumnVisible(string columnName, bool value)
    {
      LateBinding.LateSetComplex(this[IndexOf(columnName, 1)], (Type) null, "visible", new object[1] {value}, null, 0 != 0, 1 != 0);
    }
  }
}
