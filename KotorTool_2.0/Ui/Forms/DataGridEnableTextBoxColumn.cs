using System.Drawing;
using System.Windows.Forms;

namespace KotorTool_2._0.Ui.Forms
{
  public class DataGridEnableTextBoxColumn : DataGridTextBoxColumn
  {
    private int _col;

    public DataGridEnableTextBoxColumn()
    {
    }

    public DataGridEnableTextBoxColumn(int column)
    {
      _col = column;
    }

    protected override void Edit(CurrencyManager source, int rowNum, Rectangle bounds, bool readOnly, string instantText, bool cellIsVisible)
    {
    }
  }
}
