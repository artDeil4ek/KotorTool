using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotorTool_2._0.Attributes
{

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method)]
    public class CursorAttribute : Attribute
    {

        public Cursor Cursor;

        public CursorAttribute(Cursor cursorType)
        {
            Cursor.Current = cursorType;
        }
           
    }

}
