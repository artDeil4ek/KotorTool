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
using KotorTool_2._0.Properties;
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
        /// <param name="state"></param>
        /// <param name="resTypeStr"></param>
        /// <param name="nodeData"></param>
        /// <param name="treeView"></param>
        private void HandleMdlFiles(IState state, String resTypeStr, NodeData nodeData, TreeView treeView)
        {

            MdlHandlerBehavior mdlHandlerBehavior = new MdlHandlerBehavior();

            if (StringType.StrCmp(resTypeStr, Resources._mdl, false) == 0)
            {
                if (ConfigOptions.Paths.ModelExportLocation == null || !Directory.Exists(ConfigOptions.Paths.ModelExportLocation))
                {
                    
                        Interaction.MsgBox(Resources.MdlLocationNotSet,
                            MsgBoxStyle.Critical, Resources.Path_Not_Set);

                        mdlHandlerBehavior.OpenPathManager(state);
                        Constants.CurrentSettings = UserSettings.GetSettings();
                    
                }


               
                int mdlRoomCount = Mdl.GetMdlRoomCount(treeView, node);
                
                //int mdlRoomCount = Mdl.GetMdlRoomCount(treeView, nodeData);

                var mdlOpenMdlOpsSwitches = mdlHandlerBehavior.OpenMdlOpsSwitches();


                if (mdlOpenMdlOpsSwitches.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                FineMdlPaths(mdlOpenMdlOpsSwitches);

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

                var frmProgressMeter = ShowProgressMeter();

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

                    var streamWriter = ExtractBiffData(treeView, fileName, mdlRoomCount, out var streamReader);

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

                Iterate(nodeData, treeView, frmProgressMeter, flag1);

                frmProgressMeter.Close();
                Interaction.MsgBox(Resources.Extraction_Complete, MsgBoxStyle.Information, Resources.Model_Extraction);
            }
        }

        private static void Iterate(NodeData nodeData, TreeView treeView, frmProgressMeter frmProgressMeter, bool flag1)
        {
            if (!frmMdlOpsSwitches.chkbMdlAlignDataOnly.Checked)
            {
                int num1 = 1;
                int int32 = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value);
                int num2 = num1;
                while (num2 <= int32)
                {
                    frmProgressMeter.status = "Getting data for " + nodeData.ResourceRef;
                    byte[] data = BiffFunctions.GetBiffResource(nodeData.FilePath, nodeData.LocalResourceId).Data;
                    string path = frmMdlOpsSwitches.tbModelExtractionPath.Text + Resources.DoubleBackSlash +
                                  nodeData.ResourceRef;
                    if (flag1)
                    {
                        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                        path = path + "\\" + node.ResRef;
                    }

                    ByteFunctions.WriteByteArray(path + Resources._mdl, data);
                    BiffFunctions.ExportBiffResource(KotorTreeNode.NodeTreeRootIndex(treeView, node), node.ResRef,
                        3008, path + Resources._mdx);
                    frmProgressMeter.status = "Exporting model " + node.ResRef;
                    string str1 = MainFormState.GameRootPath + Resources.mdlops_exe;
                    try
                    {
                        Process process = new Process {StartInfo = {FileName = str1, CreateNoWindow = true}};


                        DecideSwitches(process);

                        StartProcess(process, path);
                        frmProgressMeter.status = "Extracting textures for " + node.ResRef;
                        FileStream fileStream = new FileStream(path + Resources._textures_txt, FileMode.Open);
                        StreamReader streamReader = new StreamReader(fileStream);


                        FrmImageViewer frmImageViewer = new FrmImageViewer();
                        for (string str2 = streamReader.ReadLine(); str2 != null; str2 = streamReader.ReadLine())
                        {
                            string str3 = str2.Trim();
                            if (str3.Length > 0 & StringType.StrCmp(str3, "null", false) != 0)
                            {
                                byte[] erfResource = new ErfObject().GetErfResource(
                                    ConfigOptions.Paths.KotorLocation(KotorTreeNode.NodeTreeRootIndex(treeView, node)) +
                                    "\\TexturePacks\\swpc_tex_tpa.erf", str3, 3007);
                                frmImageViewer.SetupTpcData(erfResource, "foo");
                                frmImageViewer.DecodeImage();
                                frmImageViewer.WriteTgaFile(
                                    path.Substring(0, path.LastIndexOf("\\", StringComparison.Ordinal) + 1) + str3 + ".tga");
                            }
                        }

                        streamReader.Close();
                        fileStream.Close();
                        CleanUpFiles(path);
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        if (StringType.StrCmp(ex.Message, "", false) == 0)
                        {
                        }

                        ProjectData.ClearProjectError();
                    }

                    nodeData = (KotorTreeNode) node.NextNode;
                    frmProgressMeter.stepUp();

                    ++num2;
                }
            }
        }

        private static void FineMdlPaths(frmMdlOpsSwitches mdlOpenMdlOpsSwitches)
        {
            while (mdlOpenMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith("\\"))
                frmMdlOpsSwitches.tbModelExtractionPath.Text =
  frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0,
                        frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1);
        }

        private static frmProgressMeter ShowProgressMeter()
        {
            frmProgressMeter frmProgressMeter = new frmProgressMeter
            {
                stepAmount = 1, maxvalue = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value),
                message = "Extracting models"
            };
            frmProgressMeter.Show();
            return frmProgressMeter;
        }


        private static void DecideSwitches(Process process)
        {
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
        }



        private static void CleanUpFiles(string path)
        {
            File.Delete(path + Resources._mdl);
            File.Delete(path + Resources._mdx);
            File.Delete(path + Resources._textures_txt);
        }




        private static void StartProcess(Process process, string path)
        {
            ProcessStartInfo startInfo1 = process.StartInfo;
            startInfo1.Arguments = startInfo1.Arguments + "\"" + path + Resources._mdl + "\"";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            process.StandardOutput.ReadToEnd();
            process.WaitForExit(15000);
        }




        private static StreamWriter ExtractBiffData(TreeView treeView, string fileName, int mdlRoomCount, out StreamReader streamReader)
        {
            StreamWriter streamWriter = new StreamWriter(new FileStream(Resources._3dsMaxScriptPath, FileMode.Create));
            streamReader = new StreamReader(new MemoryStream( BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView, node), fileName, 3000)));
            streamReader.ReadLine();
            streamReader.ReadLine();
            streamReader.ReadLine();
            streamReader.ReadLine();
            streamWriter.WriteLine(mdlRoomCount);
            return streamWriter;
        }




        public void StartAndInitProcess(Process startInfo)
        {

        }






    private void HandleMdlFiles(KotorTreeNode node, TreeView treeView)
        {
            string resTypeStr = node.NodeVm.ResourceTypeStr;

            if (StringType.StrCmp(resTypeStr, "mdl", false) == 0)
            {
                if (ConfigOptions.Paths.ModelExportLocation == null || !Directory.Exists(ConfigOptions.Paths.ModelExportLocation))
                {
                    Interaction.MsgBox(Resources.MdlLocationNotSet,MsgBoxStyle.Critical, Resources.Path_Not_Set);

                    using (frmPathManager frmPathManager = new frmPathManager())
                    {
                        if (!Directory.Exists(MainFormState.GameRootPath + Resources.working_Exported_Models))
                        {
                            Directory.CreateDirectory(MainFormState.GameRootPath + Resources.working_Exported_Models);
                        }

                        frmPathManager.tbModuleExportPath.Text = MainFormState.GameRootPath + Resources.working_Exported_Models;
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

                while (frmMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith(Resources.DoubleBackSlash)) frmMdlOpsSwitches.tbModelExtractionPath.Text = frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0, frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1);

                if (StringType.StrCmp(frmMdlOpsSwitches.tbModelExtractionPath.Text.Replace(Resources.DoubleBackSlash + Mdl.GetMdlRoomBaseName(treeView, node), String.Empty), ConfigOptions.Paths.ModelExportLocation, false) != 0)
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
                        fileName = node.NodeVm.ResourceRef.Substring(0, 6);
                    }

                    StreamWriter streamWriter = new StreamWriter(new FileStream(Resources._3dsMaxScriptPath, FileMode.Create));
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
                        string path = frmMdlOpsSwitches.tbModelExtractionPath.Text + Resources.DoubleBackSlash + node.ResRef;
                        if (flag1)
                        {
                            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                            path = path + "\\" + node.ResRef;
                        }

                        ByteFunctions.WriteByteArray(path + Resources._mdl, data);
                        BiffFunctions.ExportBiffResource(KotorTreeNode.NodeTreeRootIndex(treeView, node), node.ResRef,
                            3008, path + Resources._mdx);
                        frmProgressMeter.status = "Exporting model " + node.ResRef;
                        string str1 = MainFormState.GameRootPath + Resources.mdlops_exe;

                        String path = PathBuilder.Build()
                                                 .Append("asdfaf")
                                                 .Append(Resources.mdlops_exe)
                                                 .Make();
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
                            startInfo1.Arguments = startInfo1.Arguments + "\"" + path + Resources._mdl + "\"";
                            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                            process.StartInfo.UseShellExecute = false;
                            process.StartInfo.RedirectStandardOutput = true;
                            process.Start();
                            process.StandardOutput.ReadToEnd();
                            process.WaitForExit(15000);
                            frmProgressMeter.status = "Extracting textures for " + node.ResRef;
                            FileStream fileStream = new FileStream(path + Resources._textures_txt, FileMode.Open);
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
                            File.Delete(path + Resources._mdl);
                            File.Delete(path + Resources._mdx);
                            File.Delete(path + Resources._textures_txt);
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
                Interaction.MsgBox(Resources.Extraction_Complete, MsgBoxStyle.Information, Resources.Model_Extraction);
            }
        }
    }
}
