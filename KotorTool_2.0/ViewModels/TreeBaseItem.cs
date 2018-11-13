

namespace KotorTool_2._0.ViewModels
{
  public class TreeBaseItem
  {
    public string Itemtype;
    public string Label;
    public string Name;
    public string Slots;
    public int Index;

    public TreeBaseItem(int index, string itemtype, string label, string name, string slots)
    {
      Index = index;
      Itemtype = itemtype;
      Label = label;
      Name = name;
      Slots = slots;
    }
  }
}
