

using System;

namespace KotorTool_2._0.ViewModels
{
  public class ColumnEntry
  {
    public string ColName;
    public string DisplayName;
    public Type DataType;

    public string NativeColName => ColName;

    public string DisplayColName => DisplayName;

    public ColumnEntry()
    {
    }

    public ColumnEntry(string nativeColumnName, string displayColumnName)
    {
      ColName = nativeColumnName;
      DisplayName = displayColumnName;
    }

    public ColumnEntry(string nativeColumnName, string displayColumnName, Type dataType)
      : this(nativeColumnName, displayColumnName)
    {
      DataType = dataType;
    }
  }
}
