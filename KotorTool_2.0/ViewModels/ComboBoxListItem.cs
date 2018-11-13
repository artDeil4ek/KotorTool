
namespace KotorTool_2._0.ViewModels
{
  public class ComboBoxListItem
  {
    private string Text { get; }

    private int TwoDaIndex { get; }

    private string ListBoxName { get; }

    public ComboBoxListItem()
    {
    }

    public ComboBoxListItem(int twoDaIndex, string text, string listBoxName = "")
    {
      TwoDaIndex = twoDaIndex;
      Text = text;
      ListBoxName = listBoxName;
    }
  }
}
