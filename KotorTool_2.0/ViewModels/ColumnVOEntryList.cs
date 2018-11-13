using System;
using System.Collections;

namespace KotorTool_2._0.ViewModels
{
  public class ColumnVoEntryList : ColumnEntryList
  {
    public void Copy(ColumnVoEntryList theCopy)
    {
      foreach (ColumnVoEntry columnVoEntry in this) theCopy.Add(new ColumnVoEntry(columnVoEntry.ColName, columnVoEntry.DisplayName, columnVoEntry.Visible));
    }
  }
}
