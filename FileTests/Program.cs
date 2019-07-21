using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.Utils;

namespace FileTests
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSettings.Build()
                .ConfigurePaths(p =>
                {
                    p.CurrentDataLocation = "adfasdf";
                    p.CurrentDataLocation = "asdfaf";
                    p.DefaultTexturePackLocation = "adfafafa";
                })
                .WriteToFile();
        }
    }
}
