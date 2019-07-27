

namespace KotorTool_2._0.ViewModels
{


  
  public class ColumnVoEntry : ColumnEntry
  {
    public int DisplayIndex;
    public readonly bool Visible;

    public ColumnVoEntry()
    {
    }

    public ColumnVoEntry(string nativeColumnName, string displayColumnName, bool isVisible) : base(nativeColumnName, displayColumnName)
    {
      Visible = isVisible;
    }
  }
}
