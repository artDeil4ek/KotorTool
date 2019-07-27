using System;
using System.Windows.Forms;
using AutoMapper;
using KotorTool_2._0.AppConfiguration;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
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


            MappingService service = new MappingService();
            Injection injection = new Injection();



            UserSettings.Build()
                .InitialiseSettings()
                .ConfigureToggles(x =>
                {
                    x.ModelExtractionConvertSkinToTrimesh = false;
                    x.AlwaysConvertTpc2Tga = true;
                    x.CheckForUpdatesAtStartup = false;
                })
                .ConfigurePaths(p =>
                {
                    p.CurrentDataLocation = "asdafasf";
                    p.CurrentKeyFileLocation = "sadfasfasf";
                })
                .WriteToFile();




            using (FrmMain frmMain = new FrmMain())
            {
                Application.Run(frmMain);
            }
        }
    }
    

}
