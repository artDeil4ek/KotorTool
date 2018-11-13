
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class InventoryItem
  {
    public string Name;
    public string ResRef;
    public string EquipableSlots;
    public int Quantity;
    public bool Dropable;

    public string Text
    {
      get
      {
        string str = Name + " (" + ResRef + ")";
        if (Quantity > 1) str = str + "\tQty: " + StringType.FromInteger(Quantity);
        return str;
      }
    }

    public InventoryItem(string name, string resRef, string equipableSlots = "", int quantity = 1, bool dropable = true)
    {
      Name = name;
      ResRef = resRef;
      EquipableSlots = equipableSlots;
      Quantity = quantity;
      Dropable = dropable;
    }
  }
}
