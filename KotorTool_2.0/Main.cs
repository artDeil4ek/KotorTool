using System;
using System.Windows.Forms;
using AutoMapper;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Options;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace KotorTool_2._0
{

    [StandardModule]
    internal sealed class MainKotor
    {
        [STAThread]
        public static void Main(string[] cmdArgs)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter( AppDomain.CurrentDomain.BaseDirectory.Replace(@"\", @"/") + "config.txt", true))
            {
                file.WriteLine(JsonConvert.SerializeObject(ConfigOptions.GetInstance()));
            }
            
            
            Mapper.Initialize(cfg => {
                //cfg.CreateMap<Foo, FooDto>();
               // cfg.CreateMap<Bar, BarDto>();
            });
            
            
            using (FrmMain frmMain = new FrmMain())
            {
                Application.Run(frmMain);
            }
        }
    }
    

}
