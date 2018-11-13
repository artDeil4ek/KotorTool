using System;
using System.Collections;

namespace KotorTool_2._0.ViewModels
{
  public class ColumnSortEntryList : ColumnEntryList
  {
    public void Copy(ColumnSortEntryList theCopy)
    {
      foreach (ColumnSortEntry columnSortEntry in this) theCopy.Add(new ColumnSortEntry(columnSortEntry.ColName, columnSortEntry.DisplayName, columnSortEntry.SortDirection));
    }
  }
}
