using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class RowFilterPart
  {
    private string _mNativeColName;
    private string _mDisplayColName;
    private string _mFilterText;
    private string _mMatchOper;
    private string _mConcatOper;
    private string _mDatatype;

    public string NativeColumnName
    {
      get => _mNativeColName;
      set => _mNativeColName = value;
    }

    public string DisplayColumnName
    {
      get => _mDisplayColName;
      set => _mDisplayColName = value;
    }

    public string MatchOperator
    {
      get => _mMatchOper;
      set => _mMatchOper = value;
    }

    public string FilterText
    {
      get => _mFilterText;
      set => _mFilterText = value;
    }

    public string ConcatOperator
    {
      get => _mConcatOper;
      set => _mConcatOper = value;
    }

    public string Datatype
    {
      get => _mDatatype;
      set => _mDatatype = value;
    }

    [XmlIgnore]
    public string QuotedFilterText => QuoteFilterText();

    [XmlIgnore]
    public string FilterString => _mNativeColName + " " + _mMatchOper + " " + QuoteFilterText() + " " + _mConcatOper;

    public RowFilterPart()
    {
    }

    public RowFilterPart(string nativeColName, string displayColName, string matchOper, string filterText, string concatOper, string dataType)
    {
      _mNativeColName = nativeColName;
      _mDisplayColName = displayColName;
      _mMatchOper = matchOper;
      _mFilterText = filterText;
      _mConcatOper = concatOper;
      _mDatatype = dataType;
    }

    private string QuoteFilterText()
    {
      string str = "";
      if (StringType.StrCmp(_mMatchOper, "IN", false) == 0 || StringType.StrCmp(_mMatchOper, "NOT IN", false) == 0 || StringType.StrCmp(_mDatatype, "Int32", false) == 0)
        str = _mFilterText;
      else if (StringType.StrCmp(Datatype, "Date", false) == 0)
        str = "#" + _mFilterText + "#";
      else if (StringType.StrCmp(Datatype, "String", false) == 0)
        str = "'" + _mFilterText + "'";
      return str;
    }
  }
}
