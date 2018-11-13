

namespace KotorTool_2._0.ViewModels
{
  public class ColumnSortEntry : ColumnEntry
  {
    public string SortDirection;

    public ColumnSortEntry(string nativeColumnName, string displayColumnName, string dir) : base(nativeColumnName, displayColumnName)
    {
      SortDirection = dir;
    }
  }
}
