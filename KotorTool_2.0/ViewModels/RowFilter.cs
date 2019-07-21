using System;
using System.Collections;
using System.Xml.Serialization;

namespace KotorTool_2._0.ViewModels
{
    [Serializable]
    public class RowFilter
    {

        public string GdType;
        public bool Active;
        private ArrayList _mFilterParts;



        [XmlArray]
        [XmlArrayItem(typeof(RowFilterPart))]
        public ArrayList FilterParts
        {
            get => _mFilterParts;
            set => _mFilterParts = value;
        }



        public RowFilter()
        {
            Active = false;
            _mFilterParts = new ArrayList();
        }



        public object FilterString()
        {
            string str = String.Empty;
            foreach (RowFilterPart filterPart in _mFilterParts) str = str + filterPart.FilterString + " ";
            return str;
        }
    }
}
