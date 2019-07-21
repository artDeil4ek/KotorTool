using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Ui.TextEditor;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models
{
    public class NwnnsscompExe
    {
               // DirectoryUtils.EnsureWorkingDirectoryExists();

        private readonly string NwnnssCompExePath;
        private readonly string ExeArguments;

        public NwnnsscompExe()
        {
             NwnnssCompExePath = MainFormState.GameRootPath + "working\\temp.ncs";
             ExeArguments = "-d -o \"" + MainFormState.GameRootPath + "working\\temp.nss" + "\"" + " " + "\"" + MainFormState.GameRootPath + "working\\temp.ncs" + "\"";
        }
        public NwnnsscompExe ExecuteCompilerNwnCompiler(string fileName, byte[] arrayData)
        {


            ByteFunctions.WriteByteArray(NwnnssCompExePath, arrayData);
            string str = MainFormState.GameRootPath + "nwnnsscomp.exe";
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = NwnnssCompExePath;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = ExeArguments;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.StandardOutput.ReadToEnd();
                process.WaitForExit(4000);

                using (FileStream fileStream = new FileStream(NwnnssCompExePath, FileMode.Open))
                {
                    using (frmTextEditor frmTxtEditor = new frmTextEditor(fileName))
                    {
                        ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                        byte[] numArray2 = new byte[(int) (fileStream.Length - 1L) + 1];
                        fileStream.Read(numArray2, 0, (int) fileStream.Length);
                        frmTxtEditor.tbGeneric.Text = asciiEncoding.GetString(numArray2);
                        frmTxtEditor.tbGeneric.SelectionLength = 0;
                        frmTxtEditor.Show();
                        return this;
                    }
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (StringType.StrCmp(ex.Message, "", false) != 0)
                {
                    Interaction.MsgBox("Error launching nwnnsscomp\r\rIs it installed in the same directory as this program?");
                }

                ProjectData.ClearProjectError();
            }

            return null;
        }
        
        /*
         *
         *Original Code
         *
         *  //DirectoryUtils.EnsureWorkingDirectoryExists();
                ByteFunctions.WriteByteArray(MainFormState.GRootPath + "working\\temp.ncs", numArray1);
                string str = MainFormState.GRootPath + "nwnnsscomp.exe";
                try
                {
                    Process process = new Process();
                    process.StartInfo.FileName = str;
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.Arguments = "-d -o \"" + MainFormState.GRootPath + "working\\temp.nss" + "\"" + " " + "\"" + MainFormState.GRootPath + "working\\temp.ncs" + "\"";
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();
                    process.StandardOutput.ReadToEnd();
                    process.WaitForExit(4000);

                    using (FileStream fileStream = new FileStream(MainFormState.GRootPath + "working\\temp.nss", FileMode.Open))
                    {
                        using (frmTextEditor frmTxtEditor = new frmTextEditor(node.Filename))
                        {
                            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                            byte[] numArray2 = new byte[(int) (fileStream.Length - 1L) + 1];
                            fileStream.Read(numArray2, 0, (int) fileStream.Length);
                            frmTxtEditor.tbGeneric.Text = asciiEncoding.GetString(numArray2);
                            frmTxtEditor.tbGeneric.SelectionLength = 0;
                            frmTxtEditor.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    if (StringType.StrCmp(ex.Message, "", false) != 0)
                    {
                        Interaction.MsgBox("Error launching nwnnsscomp\r\rIs it installed in the same directory as this program?");
                    }

                    ProjectData.ClearProjectError();
                }
         *
         *
         * 
         */
    }
}