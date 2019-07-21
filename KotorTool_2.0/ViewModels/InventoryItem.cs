
using System;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{


    [Serializable]
    public class InventoryItem
    {
        public string Name;
        public string ResourceRef;
        public string EquipableSlots;
        public int Quantity;
        public bool Droppable;


        public InventoryItem(string name, string resRef, string equipableSlots = "", int quantity = 1, bool dropable = true)
        {
            Name = name;
            ResourceRef = resRef;
            EquipableSlots = equipableSlots;
            Quantity = quantity;
            Droppable = dropable;
        }



        public string Text
        {
            get
            {
                string str = Name + " (" + ResourceRef + ")";
                if (Quantity > 1) str = str + "\tQty: " + StringType.FromInteger(Quantity);
                return str;
            }
        }


    }
}
