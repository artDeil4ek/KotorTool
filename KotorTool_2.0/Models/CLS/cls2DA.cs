using System;

namespace KotorTool_2._0.Models.CLS
{
  public partial class Cls2Da
  {
    private readonly byte[] _ary2Da;
    private Array _ary2DaStrings;
    private string[] _rowLabels;
    public string[] ColNames;
    private int _numRows;
    private int _numColumns;
/*
    public int RowCount => _numRows;
*/
    public int RowsUpperBound => checked (_numRows - 1);
/*
    public int ColumnCount => _numColumns;
*/
    public int ColumnUpperBound => checked (_numColumns - 1);

    public Cls2Da(byte[] raw2DaData)
    {
      _ary2Da = raw2DaData;
      CreateDataTable();
    }
  }
}
