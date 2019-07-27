

namespace KotorTool_2._0.ViewModels
{
  public class TreeBaseItem
  {
    public string ItemType;
    public string Label;
    public string Name;
    public string Slots;
    public int Index;

    public TreeBaseItem(int index, string itemType, string label, string name, string slots)
    {
      Index = index;
      ItemType = itemType;
      Label = label;
      Name = name;
      Slots = slots;
    }
  }
}
