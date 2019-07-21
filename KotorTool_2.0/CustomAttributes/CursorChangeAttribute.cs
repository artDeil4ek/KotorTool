using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.Data;

namespace KotorTool_2._0.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct)]
    public class CursorChangeAttribute : Attribute
    {

        public CursorChangeAttribute(CursorTypes type)
        {
        
        }
         
    }

}
