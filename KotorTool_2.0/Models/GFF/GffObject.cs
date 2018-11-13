using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Forms;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.GFF
{
    public class GffObject
    {
        public void EditGffResource(string filename, byte[] data)
        {
            DirectoryUtils.EnsureWorkingDirectoryExists();
            if (File.Exists(MainFormState.GRootPath + "working\\" + filename))File.Delete(MainFormState.GRootPath + "working\\" + filename);
            ByteFunctions.WriteByteArray(MainFormState.GRootPath + "working\\" + filename, data);
            LaunchGffEditor(MainFormState.GRootPath + "working\\" + filename);
        }

        private void LaunchGffEditor(string filename)
        {
            string fileName = MainFormState.GRootPath + "gffeditor.exe";
            try{Process.Start(fileName, filename);}
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (StringType.StrCmp(ex.Message, "", false) != 0)
                {
                    Interaction.MsgBox("Error launching GFFEditor\r\rIs it installed in the same directory as this program?");
                }

                ProjectData.ClearProjectError();
            }
        }

        public static int GetGffFileKotorVersionIndex(string filepath)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException ex)
            {
                ProjectData.SetProjectError(ex);
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException ex)
            {
                ProjectData.SetProjectError(ex);
                throw new DirectoryNotFoundException();
            }

            int num = new ClsGff(fs, -1).KotorVersIndex();
            if (num > -1) return num;
            if (num == -1 && MainFormState.IsOnly1KotOrInstalled())
            {
                string str = MainFormState.GetUniqueKotorInstalledVersion() != 0 ? "KotOR II:TSL" : "KotOR I";
                if (Interaction.MsgBox("The file '" + Path.GetFileName(filepath) + "' has no embedded version info. Do you want to open in using " + str + "'s data?", MsgBoxStyle.YesNo, "") == MsgBoxResult.Yes) return MainFormState.GetUniqueKotorInstalledVersion();
                return -1;
            }

            FrmSpecifyKotorVersion specifyKotorVersion = new FrmSpecifyKotorVersion();
            specifyKotorVersion.FileName = Path.GetFileName(filepath);
            //if (specifyKotorVersion.ShowDialog(this) == DialogResult.OK) return specifyKotorVersion.KotorVerIndexSelected;
            if (specifyKotorVersion.ShowDialog() == DialogResult.OK) return specifyKotorVersion.KotorVerIndexSelected;
            return -1;
        }

        public Form OpenGffFileInEditor(string filepath, int formLocationOffset = -1)
        {
            int kotorVersionIndex;
            try
            {
                kotorVersionIndex = GetGffFileKotorVersionIndex(filepath);
            }
            catch (FileNotFoundException ex)
            {
                ProjectData.SetProjectError(ex);
                new Mru().ManageMruMainFileList(filepath, true);
                Interaction.MsgBox("Could not find file: " + filepath, MsgBoxStyle.Critical,"");
                ProjectData.ClearProjectError();
                goto label_26;
            }
            catch (DirectoryNotFoundException ex)
            {
                ProjectData.SetProjectError(ex);
                new Mru().ManageMruMainFileList(filepath, true);
                Interaction.MsgBox("Could not directory in path to: " + filepath,MsgBoxStyle.Critical, "");
                ProjectData.ClearProjectError();
                goto label_26;
            }

            if (kotorVersionIndex != -1)
            {
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                string sLeft = Strings.LCase(Path.GetExtension(filepath));
                object o;
                if (StringType.StrCmp(sLeft, ".utc", false) == 0) o = new frmUTC_Editor(new ClsUtc(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".uti", false) == 0) o = new frmUTI_Editor(new ClsUti(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".utd", false) == 0) o = new frmUTD_Editor(new ClsUtd(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".utm", false) == 0) o = new frmUTM_Editor(new ClsUtm(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".utp", false) == 0) o = new FrmUtpEditor(new ClsUtp(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".uts", false) == 0) o = new frmUTS_Editor(new ClsUts(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".utt", false) == 0) o = new frmUTT_Editor(new ClsUtt(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".utw", false) == 0) o = new frmUTW_Editor(new ClsUtw(fs, kotorVersionIndex), kotorVersionIndex);
                else if (StringType.StrCmp(sLeft, ".dlg", false) == 0)
                {
                    o = new FrmDialogEditor(fs, kotorVersionIndex);
                }
                else
                {
                    Interaction.MsgBox("There is no editor available for that file type", MsgBoxStyle.Exclamation, "Unsupported File Type");
                    goto label_26;
                }

                new Mru().ManageMruMainFileList(filepath);
                ((frmParent) o).EditingFilePath = filepath;
                LateBinding.LateCall(o, null, "Show", new object[0], null, null);
                if (formLocationOffset != -1) ((Control) o).Location = new Point(((Control) o).Location.X + formLocationOffset, ((Control) o).Location.Y + formLocationOffset);
                return (Form) o;
            }

            label_26:
            Form form = new Form();
            return form;
        }

        public static string GetGffTag(byte[] data)
        {
            return GetGffRootStringField(data, "Tag");
        }

        public static string GetGffRootStringField(byte[] data, string fieldName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            MemoryStream memoryStream = new MemoryStream(data);
            BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.ASCII);
            memoryStream.Seek(8L, SeekOrigin.Begin);
            int num1 = binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            int num2 = binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            int num3 = binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            int num4 = binaryReader.ReadInt32();
            memoryStream.Seek(checked(num1 + 8), SeekOrigin.Begin);
            int num5 = binaryReader.ReadInt32();
            int num6 = 0;
            int num7 = checked(num5 - 1);
            int num8 = num6;
            while (num8 <= num7)
            {
                memoryStream.Seek(checked(num2 + num8 * 12), SeekOrigin.Begin);
                if (binaryReader.ReadInt32() == 10)
                {
                    int num9 = binaryReader.ReadInt32();
                    long position = binaryReader.BaseStream.Position;
                    memoryStream.Seek(num3 + num9 * 16, SeekOrigin.Begin);
                    stringBuilder.Length = 0;
                    stringBuilder.Append(binaryReader.ReadChars(16));
                    int index = 0;
                    while (Strings.Asc(stringBuilder[index]) != 0)
                    {
                        ++index;
                        if (index > 15) break;
                    }

                    stringBuilder.Length = index;
                    if (StringType.StrCmp(stringBuilder.ToString().ToLower(), fieldName.ToLower(), false) == 0)
                    {
                        memoryStream.Seek(position, SeekOrigin.Begin);
                        int num10 = binaryReader.ReadInt32();
                        memoryStream.Seek(num4 + num10, SeekOrigin.Begin);
                        int count = binaryReader.ReadInt32();
                        return Encoding.GetEncoding(1252).GetString(binaryReader.ReadBytes(count));
                    }
                }

                ++num8;
                
            }

            String str = "";
            return str;
        }
    }
}