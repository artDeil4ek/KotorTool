using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KotorTool_2._0.MainForm.Abstractions;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Ui.ImageViewer;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.MainForm
{
    public class MdlHandlerBehavior
    {

        public const String ExportedModelPathAddition = "working\\Exported Models";


        /// <summary>
        /// Factory Method for calling the PathManager
        /// Takes in a state and populates according to the state data present
        /// </summary>
        /// <param name="state"></param>
        public void OpenPathManager(IState state)
        {
            if (state is MainFormState mainFormState)
            {
                using (frmPathManager frmPathManager = new frmPathManager())
                {
                    if (!Directory.Exists(mainFormState.GameRootPath + ExportedModelPathAddition))
                    {
                        Directory.CreateDirectory(mainFormState.GameRootPath + ExportedModelPathAddition);
                    }

                    frmPathManager.tbModuleExportPath.Text = mainFormState.GameRootPath + ExportedModelPathAddition;
                    frmPathManager.StartPosition = FormStartPosition.CenterScreen;
                    frmPathManager.TabControl1.SelectedIndex = 2;
                    frmPathManager.tbModuleExportPath.BackColor = Color.MistyRose;
                    frmPathManager.ShowDialog();
                }
            }
        }

        
        
        /// <summary>
        /// Method for Populating and Initialising the MdlOpsSwitchForm
        /// </summary>
        /// <returns></returns>
        public frmMdlOpsSwitches OpenMdlOpsSwitches()
        {
            frmMdlOpsSwitches frmMdlOpsSwitches = new frmMdlOpsSwitches
            {
                chkbExtractAnimations = { Checked = ConfigOptions.Toggles.ModelExtractionExtractAnimations },
                chkbConvertSkin = { Checked = ConfigOptions.Toggles.ModelExtractionConvertSkinToTrimesh },
                chkbEachModelInOwnDir = { Checked = ConfigOptions.Toggles.ModelExtractionEachModelInOwnDirectory },
                chkbCleanWorkingDir =
                {
                    Checked = ConfigOptions.Toggles.ModelExtractionCleanWorkingDirectoryBeforeExport
                },
                tbModelExtractionPath = { Text = ConfigOptions.Paths.ModelExportLocation }
            };
            return frmMdlOpsSwitches;
        }


        /// <summary>
        /// WIP -------------
        /// ----Needs
        /// ----Node and TreeView need to be replaced with specific collections
        /// </summary>
        /// <param name="form"></param>
        /// <param name="mdlRoomCount"></param>
        public void PopulateFormWithData(ref frmMdlOpsSwitches form, int mdlRoomCount)
        {
            while (form.tbModelExtractionPath.Text.EndsWith("\\"))
                form.tbModelExtractionPath.Text =
                    form.tbModelExtractionPath.Text.Substring(0,
                        form.tbModelExtractionPath.Text.Length - 1);

            if (StringType.StrCmp(form.tbModelExtractionPath.Text.Replace("\\" + Mdl.GetMdlRoomBaseName(treeView, node), ""), ConfigOptions.Paths.ModelExportLocation, false) != 0)
            {
                ConfigOptions.Paths.ModelExportLocation = form.tbModelExtractionPath.Text;
                UserSettings.SaveSettings(Constants.CurrentSettings);
            }

            if (!Directory.Exists(form.tbModelExtractionPath.Text))
            {
                Directory.CreateDirectory(form.tbModelExtractionPath.Text);
            }

            bool flag1 = form.chkbEachModelInOwnDir.Checked;
            bool flag2 = form.chkbCleanWorkingDir.Checked;

            frmProgressMeter frmProgressMeter = new frmProgressMeter { stepAmount = 1, maxvalue = Convert.ToInt32(form.nudNumberToExtract.Value), message = "Extracting models" };
            frmProgressMeter.Show();

            DirectoryUtils.EnsureWorkingDirectoryExists();
            ConfigOptions.Toggles.ModelExtractionExtractAnimations = form.ExtractAnimations;
            ConfigOptions.Toggles.ModelExtractionConvertSkinToTrimesh = form.ConvertSkin;
            ConfigOptions.Toggles.ModelExtractionEachModelInOwnDirectory = form.chkbEachModelInOwnDir.Checked;
            ConfigOptions.Toggles.ModelExtractionCleanWorkingDirectoryBeforeExport = form.chkbCleanWorkingDir.Checked;

            UserSettings.SaveSettings(Constants.CurrentSettings);

            if (flag2)
            {
                DirectoryUtils.CleanDirectory(form.tbModelExtractionPath.Text);
            }

            if (form.chkbExportMdlAlignData.Checked | form.chkbMdlAlignDataOnly.Checked)
            {

                string fileName = String.Empty;
                if (KotorTreeNode.NodeTreeRootIndex(treeView, node) == 1)
                {
                    fileName = nodeData.ResourceRef.Substring(0, 6);
                }

                StreamWriter streamWriter = new StreamWriter(new FileStream("C:\\3dsmax7\\scripts\\NWmax\\plugins\\test.txt", FileMode.Create));
                StreamReader streamReader = new StreamReader(new MemoryStream(BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView, node), fileName, 3000)));
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamReader.ReadLine();
                streamWriter.WriteLine(mdlRoomCount);


                String path = form.tbModelExtractionPath.Text;
                FlowUtils.BasicIterator(mdlRoomCount, 1, i =>
                {
                    string[] strArray = streamReader.ReadLine()?.Trim().Split(' ');
                    int index = 1;
                    do
                    {
                        if (strArray != null)
                        {
                            strArray[index] = (Convert.ToSingle(strArray[index]) * 100f).ToString(CultureInfo.InvariantCulture);
                        }

                        ++index;
                    } while (index <= 3);

                    if (strArray != null)
                    {
                        
                        streamWriter.WriteLine(path + "\\" + strArray[0] + "-ascii.mdl," + strArray[0] + "," + strArray[1] + "," + strArray[2] + "," + strArray[3]);
                    }
                });

                streamWriter.Close();
                streamReader.Close();
            }

            if (!form.chkbMdlAlignDataOnly.Checked)
            {
                int num1 = 1;
                int int32 = Convert.ToInt32(form.nudNumberToExtract.Value);
                int num2 = num1;
                while (num2 <= int32)
                {
                    frmProgressMeter.status = "Getting data for " + nodeData.ResourceRef;
                    byte[] data = BiffFunctions.GetBiffResource(nodeData.FilePath, nodeData.LocalResourceId).Data;
                    string path = form.tbModelExtractionPath.Text + "\\" + nodeData.ResourceRef;
                    if (flag1)
                    {
                        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                        path = path + "\\" + node.ResRef;
                    }

                    ByteFunctions.WriteByteArray(path + ".mdl", data);
                    BiffFunctions.ExportBiffResource(KotorTreeNode.NodeTreeRootIndex(treeView, node), node.ResRef,
                        3008, path + ".mdx");
                    frmProgressMeter.status = "Exporting model " + node.ResRef;
                    string str1 = MainFormState.GameRootPath + "mdlops.exe";
                    try
                    {
                        Process process = new Process { StartInfo = { FileName = str1, CreateNoWindow = true } };


                        if (!form.ExtractAnimations)
                        {
                            ProcessStartInfo startInfo = process.StartInfo;
                            startInfo.Arguments = startInfo.Arguments + "-a ";
                        }

                        if (form.ConvertSkin)
                        {
                            ProcessStartInfo startInfo = process.StartInfo;
                            startInfo.Arguments = startInfo.Arguments + "-s ";
                        }

                        ProcessStartInfo startInfo1 = process.StartInfo;
                        startInfo1.Arguments = startInfo1.Arguments + "\"" + path + ".mdl" + "\"";
                        process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.Start();
                        process.StandardOutput.ReadToEnd();
                        process.WaitForExit(15000);
                        frmProgressMeter.status = "Extracting textures for " + node.ResRef;
                        FileStream fileStream = new FileStream(path + "-textures.txt", FileMode.Open);
                        StreamReader streamReader = new StreamReader(fileStream);
                        FrmImageViewer frmImageViewer = new FrmImageViewer();
                        for (string str2 = streamReader.ReadLine(); str2 != null; str2 = streamReader.ReadLine())
                        {
                            string str3 = str2.Trim();
                            if (str3.Length > 0 & StringType.StrCmp(str3, "null", false) != 0)
                            {
                                byte[] erfResource = new ErfObject().GetErfResource(ConfigOptions.Paths.KotorLocation(KotorTreeNode.NodeTreeRootIndex(treeView, node)) + "\\TexturePacks\\swpc_tex_tpa.erf", str3, 3007);
                                frmImageViewer.SetupTpcData(erfResource, "foo");
                                frmImageViewer.DecodeImage();
                                frmImageViewer.WriteTgaFile(path.Substring(0, path.LastIndexOf("\\", StringComparison.Ordinal) + 1) + str3 + ".tga");
                            }
                        }

                        streamReader.Close();
                        fileStream.Close();
                        File.Delete(path + ".mdl");
                        File.Delete(path + ".mdx");
                        File.Delete(path + "-textures.txt");
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        if (StringType.StrCmp(ex.Message, "", false) == 0)
                        {
                        }

                        ProjectData.ClearProjectError();
                    }

                    nodeData = (KotorTreeNode)node.NextNode;
                    frmProgressMeter.stepUp();

                    ++num2;
                }
            }

        }
    }
}
