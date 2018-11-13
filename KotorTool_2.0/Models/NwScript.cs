using System;
using System.IO;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Options;

namespace KotorTool_2._0.Models
{
    public class NwScript
    {
        public static void ExtractNwScripts(MainFormState mainState)
        {
            if (mainState._hasK1 && !Directory.Exists(Path.Combine(ConfigOptions.Paths.KotorLocation(0), "override")))
            {
                Directory.CreateDirectory(Path.Combine(ConfigOptions.Paths.KotorLocation(0), "override"));
            }

            if (mainState._hasK2 && !Directory.Exists(Path.Combine(ConfigOptions.Paths.KotorLocation(1), "override")))
            {
                Directory.CreateDirectory(Path.Combine(ConfigOptions.Paths.KotorLocation(1), "override"));
            }

            string str = Path.Combine(ConfigOptions.Paths.KotorLocation(0), "override\\nwscript.nss");
            string outputPath = Path.Combine(ConfigOptions.Paths.KotorLocation(1), "override\\nwscript.nss");
            if (mainState._hasK1 && !File.Exists(str))
            {
                BiffFunctions.ExportBiffResource(Path.Combine(ConfigOptions.Paths.KotorLocation(0), "data\\scripts.bif"), str, 3533);
            }

            if (!mainState._hasK2 || File.Exists(str))
            {
                return;
            }

            BiffFunctions.ExportBiffResource(Path.Combine(ConfigOptions.Paths.KotorLocation(1), "data\\scripts.bif"), outputPath, 1245);
        }

        public static void ReadNwFile()
        {
            FileStream fileStream = new FileStream("C:\\SharpDevelop_1.1.0.2081\\src\\Libraries\\ICSharpCode.TextEditor\\src\\ICSharpCode.TextEditor.prjx", FileMode.Open);
            StreamWriter text = File.CreateText("c:\\TextEditor.csproj");
            StreamReader streamReader = new StreamReader(fileStream);
            int num = 1;
            do
            {
                string str1 = streamReader.ReadLine();
                if (str1 != null && (str1.ToLower().IndexOf("<file", StringComparison.Ordinal) > -1 && str1.IndexOf("Exclude", StringComparison.Ordinal) == -1))
                {
                    string str2 = str1.Replace("name=", "RelPath =").Replace(".\\", "");
                    text.WriteLine(str2);
                }

                ++num;
            } while (num <= 647);

            streamReader.Close();
            text.Close();
        }
    }
}