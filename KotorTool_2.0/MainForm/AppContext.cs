using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.MainForm.Abstractions;

namespace KotorTool_2._0.MainForm
{
    public class AppContext : IContext
    {

        public MainFormState State;

        public AppContext()
        {
            State = new MainFormState();
        }





    }
}
