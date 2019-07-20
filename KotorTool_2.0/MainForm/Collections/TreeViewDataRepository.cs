using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.MainForm.Data;

namespace KotorTool_2._0.MainForm.Collections
{
    public class TreeViewDataRepository : IEnumerable<NodeData>
    {

        public IList<NodeData> Collection { get; set; }


        public TreeViewDataRepository()
        {



        }



        IEnumerator<NodeData> IEnumerable<NodeData>.GetEnumerator()
        {
            throw new NotImplementedException();
        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
