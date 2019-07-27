using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KotorTool_2._0.Data;
using KotorTool_2._0.MainForm.Abstractions;
using KotorTool_2._0.MainForm.Adapters;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Ui.ImageViewer;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.MainForm
{
    public class MdlHandler
    {


        /// <summary>
        /// Refactored Method for handling Mdl Files
        /// </summary>
        /// <param name="resTypeStr"></param>
        /// <param name="treeView"></param>
        private void HandleMdlFiles(IState state, String resTypeStr, NodeData nodeData, TreeView treeView)
        {

            MdlHandlerBehavior mdlHandlerBehavior = new MdlHandlerBehavior();

            if (StringType.StrCmp(resTypeStr, "mdl", false) == 0)
            {
                if (ConfigOptions.Paths.ModelExportLocation == null || !Directory.Exists(ConfigOptions.Paths.ModelExportLocation))
                {
                    
                        Interaction.MsgBox("The Model Export Location is not set.\n\nA default path has been set in the Path Manager; you may accept it or choose your own.",
                            MsgBoxStyle.Critical, "Path not set");

                        mdlHandlerBehavior.OpenPathManager(state);
                        Constants.CurrentSettings = UserSettings.GetSettings();
                    
                }


                /*
                 *
                 * This needs to be refactored to be more generic, remove the ui models from the parameters
                 * Make the parameters for this the Node Data Object
                 *
                 */
                int mdlRoomCount = Mdl.GetMdlRoomCount(treeView, node);
                int mdlCount = 
                //int mdlRoomCount = Mdl.GetMdlRoomCount(treeView, nodeData);


                /*
                 *
                 *  Init the form for OpsSwitches
                 * 
                 *
                 */

                
                var mdlOpenMdlOpsSwitches = mdlHandlerBehavior.OpenMdlOpsSwitches();


                if (mdlOpenMdlOpsSwitches.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                while (mdlOpenMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith("\\")) frmMdlOpsSwitches.tbModelExtractionPath.Text = frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0, frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1);

                if (StringType.StrCmp(mdlOpenMdlOpsSwitches.tbModelExtractionPath.Text.Replace("\\" + Mdl.GetMdlRoomBaseName(treeView, node), ""), ConfigOptions.Paths.ModelExportLocation, false) != 0)
                {
                    ConfigOptions.Paths.ModelExportLocation = frmMdlOpsSwitches.tbModelExtractionPath.Text;
                    UserSettings.SaveSettings(Constants.CurrentSettings);
                }

                if (!Directory.Exists(mdlOpenMdlOpsSwitches.tbModelExtractionPath.Text))
                {
                    Directory.CreateDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text);
                }

                bool flag1 = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked;
                bool flag2 = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked;

                frmProgressMeter frmProgressMeter = new frmProgressMeter { stepAmount = 1, maxvalue = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value), message = "Extracting models" };
                frmProgressMeter.Show();

                DirectoryUtils.EnsureWorkingDirectoryExists();
                ConfigOptions.Toggles.ModelExtractionExtractAnimations = frmMdlOpsSwitches.ExtractAnimations;
                ConfigOptions.Toggles.ModelExtractionConvertSkinToTrimesh = frmMdlOpsSwitches.ConvertSkin;
                ConfigOptions.Toggles.ModelExtractionEachModelInOwnDirectory = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked;
                ConfigOptions.Toggles.ModelExtractionCleanWorkingDirectoryBeforeExport = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked;

                UserSettings.SaveSettings(Constants.CurrentSettings);

                if (flag2)
                {
                    DirectoryUtils.CleanDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text);
                }

                if (frmMdlOpsSwitches.chkbExportMdlAlignData.Checked | frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
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
                            streamWriter.WriteLine(frmMdlOpsSwitches.tbModelExtractionPath.Text + "\\" + strArray[0] + "-ascii.mdl," + strArray[0] + "," + strArray[1] + "," + strArray[2] + "," + strArray[3]);
                        }
                    });

                    streamWriter.Close();
                    streamReader.Close();
                }

                if (!frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
                {
                    int num1 = 1;
                    int int32 = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value);
                    int num2 = num1;
                    while (num2 <= int32)
                    {
                        frmProgressMeter.status = "Getting data for " + nodeData.ResourceRef;
                        byte[] data = BiffFunctions.GetBiffResource(nodeData.FilePath, nodeData.LocalResourceId).Data;
                        string path = frmMdlOpsSwitches.tbModelExtractionPath.Text + "\\" + nodeData.ResourceRef;
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
                            Process process = new Process {StartInfo = {FileName = str1, CreateNoWindow = true}};


                            if (!frmMdlOpsSwitches.ExtractAnimations)
                            {
                                ProcessStartInfo startInfo = process.StartInfo;
                                startInfo.Arguments = startInfo.Arguments + "-a ";
                            }

                            if (frmMdlOpsSwitches.ConvertSkin)
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

                frmProgressMeter.Close();
                Interaction.MsgBox("Extraction Complete", MsgBoxStyle.Information, "Model Extraction");
            }
        }
    







    private void HandleMdlFiles(KotorTreeNode node, TreeView treeView)
        {
            string resTypeStr = node.NodeVm.ResourceTypeStr;

            if (StringType.StrCmp(resTypeStr, "mdl", false) == 0)
            {
                if (ConfigOptions.Paths.ModelExportLocation == null || !Directory.Exists(ConfigOptions.Paths.ModelExportLocation))
                {
                    Interaction.MsgBox(
                        "The Model Export Location is not set.\n\nA default path has been set in the Path Manager; you may accept it or choose your own.",
                        MsgBoxStyle.Critical, "Path not set");
                    using (frmPathManager frmPathManager = new frmPathManager())
                    {
                        if (!Directory.Exists(MainFormState.GameRootPath + "working\\Exported Models"))
                        {
                            Directory.CreateDirectory(MainFormState.GameRootPath + "working\\Exported Models");
                        }

                        frmPathManager.tbModuleExportPath.Text = MainFormState.GameRootPath + "working\\Exported Models";
                        frmPathManager.StartPosition = FormStartPosition.CenterScreen;
                        frmPathManager.TabControl1.SelectedIndex = 2;
                        frmPathManager.tbModuleExportPath.BackColor = Color.MistyRose;
                        frmPathManager.ShowDialog();
                    }

                    Constants.CurrentSettings = UserSettings.GetSettings();
                }

                int mdlRoomCount = Mdl.GetMdlRoomCount(treeView, node);
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
                if (frmMdlOpsSwitches.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                while (frmMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith("\\")) frmMdlOpsSwitches.tbModelExtractionPath.Text = frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0, frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1);

                if (StringType.StrCmp(frmMdlOpsSwitches.tbModelExtractionPath.Text.Replace("\\" + Mdl.GetMdlRoomBaseName(treeView, node), ""), ConfigOptions.Paths.ModelExportLocation, false) != 0)
                {
                    ConfigOptions.Paths.ModelExportLocation = frmMdlOpsSwitches.tbModelExtractionPath.Text;
                    UserSettings.SaveSettings(Constants.CurrentSettings);
                }

                if (!Directory.Exists(frmMdlOpsSwitches.tbModelExtractionPath.Text))
                {
                    Directory.CreateDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text);
                }

                bool flag1 = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked;
                bool flag2 = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked;

                frmProgressMeter frmProgressMeter = new frmProgressMeter { stepAmount = 1, maxvalue = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value), message = "Extracting models" };
                frmProgressMeter.Show();

                DirectoryUtils.EnsureWorkingDirectoryExists();
                ConfigOptions.Toggles.ModelExtractionExtractAnimations = frmMdlOpsSwitches.ExtractAnimations;
                ConfigOptions.Toggles.ModelExtractionConvertSkinToTrimesh = frmMdlOpsSwitches.ConvertSkin;
                ConfigOptions.Toggles.ModelExtractionEachModelInOwnDirectory = frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked;
                ConfigOptions.Toggles.ModelExtractionCleanWorkingDirectoryBeforeExport = frmMdlOpsSwitches.chkbCleanWorkingDir.Checked;

                UserSettings.SaveSettings(Constants.CurrentSettings);
                if (flag2)
                {
                    DirectoryUtils.CleanDirectory(frmMdlOpsSwitches.tbModelExtractionPath.Text);
                }

                if (frmMdlOpsSwitches.chkbExportMdlAlignData.Checked | frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
                {
                    string fileName = "";
                    if (KotorTreeNode.NodeTreeRootIndex(treeView, node) == 1)
                    {
                        fileName = node.ResRef.Substring(0, 6);
                    }

                    StreamWriter streamWriter = new StreamWriter(new FileStream("C:\\3dsmax7\\scripts\\NWmax\\plugins\\test.txt", FileMode.Create));
                    StreamReader streamReader = new StreamReader(new MemoryStream(BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView, node), fileName, 3000)));
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamWriter.WriteLine(mdlRoomCount);

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
                            streamWriter.WriteLine(frmMdlOpsSwitches.tbModelExtractionPath.Text + "\\" + strArray[0] + "-ascii.mdl," + strArray[0] + "," + strArray[1] + "," + strArray[2] + "," + strArray[3]);
                        }
                    });

                    streamWriter.Close();
                    streamReader.Close();
                }

                if (!frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
                {
                    int num1 = 1;
                    int int32 = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value);
                    int num2 = num1;
                    while (num2 <= int32)
                    {
                        frmProgressMeter.status = "Getting data for " + node.ResRef;
                        byte[] data = BiffFunctions.GetBiffResource(node.FilePath, node.LocalResId).Data;
                        string path = frmMdlOpsSwitches.tbModelExtractionPath.Text + "\\" + node.ResRef;
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
                            Process process = new Process();
                            process.StartInfo.FileName = str1;
                            process.StartInfo.CreateNoWindow = true;
                            if (!frmMdlOpsSwitches.ExtractAnimations)
                            {
                                ProcessStartInfo startInfo = process.StartInfo;
                                startInfo.Arguments = startInfo.Arguments + "-a ";
                            }

                            if (frmMdlOpsSwitches.ConvertSkin)
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

                        node = (KotorTreeNode)node.NextNode;
                        frmProgressMeter.stepUp();

                        ++num2;
                    }
                }

                frmProgressMeter.Close();
                Interaction.MsgBox("Extraction Complete", MsgBoxStyle.Information, "Model Extraction");
            }
        }
    }
}
