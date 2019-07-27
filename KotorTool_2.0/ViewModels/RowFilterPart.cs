using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
    public class RowFilterPart
    {


        /// <summary>
        /// 
        /// </summary>
        public string NativeColumnName { get; set; }
        public string DisplayColumnName { get; set; }
        public string MatchOperator { get; set; }
        public string FilterText { get; set; }
        public string ConcatOperator { get; set; }
        public string DataType { get; set; }


        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore] public string QuotedFilterText => QuoteFilterText();


        /// <summary>
        /// 
        /// </summary>
        [XmlIgnore]
        public string FilterString => NativeColumnName + " " + MatchOperator + " " + QuoteFilterText() + " " + ConcatOperator;



        public RowFilterPart()
        {
        }


        /// <summary>
        /// Constructor
        /// TODO : Is this constructor even necessary???? Maybe take it out and replace with object initialiser
        /// </summary>
        /// <param name="nativeColName"></param>
        /// <param name="displayColName"></param>
        /// <param name="matchOperator"></param>
        /// <param name="filterText"></param>
        /// <param name="concatOpererator"></param>
        /// <param name="dataType"></param>
        public RowFilterPart(string nativeColName, string displayColName, string matchOperator, string filterText,
            string concatOpererator, string dataType)
        {
            NativeColumnName = nativeColName;
            DisplayColumnName = displayColName;
            MatchOperator = matchOperator;
            FilterText = filterText;
            ConcatOperator = concatOpererator;
            DataType = dataType;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string QuoteFilterText()
        {
            string str = "";
            if (StringType.StrCmp(MatchOperator, "IN", false) == 0 ||
                StringType.StrCmp(MatchOperator, "NOT IN", false) == 0 ||
                StringType.StrCmp(DataType, "Int32", false) == 0)
                str = FilterText;
            else if (StringType.StrCmp(DataType, "Date", false) == 0)
                str = "#" + FilterText + "#";
            else if (StringType.StrCmp(DataType, "String", false) == 0) str = "'" + FilterText + "'";
            return str;
        }
    }
}
