using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Forms;
using KotorTool_2._0.ImageViewer;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Options;
using KotorTool_2._0.TextEditor;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.MainForm
{
    public class TreeViewCommand
    {
        
        public Form OpenFileFromCmdLine(MainFormState mainState)
        {
            /*
            int num1 = 0;
            int num2 = mainState._cmdArgs.Length - 1;
            int index = num1;
            while (index <= num2)
            {
                if (StringType.StrCmp(mainState._cmdArgs[index], "-mapinfo", false) == 0)
                {
                    //CreateMapInfoBFD_Click(null, null);
                    new ClsMapInfoCreator().Write(MainFormState.GRootPath);
                    Environment.Exit(0);
                }
                ++index;
            }

            //if (StringType.StrCmp(Path.GetExtension(mainState._cmdArgs[0])?.ToLower(), ".2da", false) != 0 & StringType.StrCmp(Path.GetExtension(mainState._cmdArgs[0])?.ToLower(), ".tlk", false) != 0) return OpenGffFileInEditor(mainState._cmdArgs[0]);
            if (StringType.StrCmp(Path.GetExtension(mainState._cmdArgs[0])?.ToLower(), ".2da", false) == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                FileStream fileStream = new FileStream(mainState._cmdArgs[0], FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
                byte[] a2Da = binaryReader.ReadBytes((int) fileStream.Length);
                binaryReader.Close();
                Frm2DaEditor frm2DaEditor = new Frm2DaEditor(Path.GetFileName(mainState._cmdArgs[0]), a2Da);
                frm2DaEditor.Show();
                return frm2DaEditor;
            }
            if (StringType.StrCmp(Path.GetExtension(mainState._cmdArgs[0])?.ToLower(), ".tlk", false) != 0)
            {
                using (Form form = new Form())
                {
                    return form;
                }
            }
            using (frmDialogTlk frmDialogTlk = new frmDialogTlk(mainState._cmdArgs[0]))
            {
                frmDialogTlk.Show();
                return frmDialogTlk;
            }
        }
        
           public void PerformStringSearch(MainFormState mainState, TreeViewPresenter presenter)
        {
            frmRefSearchResults resultsForm = new frmRefSearchResults();
            frmRefSearchCriteria refSearchCriteria = new frmRefSearchCriteria();
            if (mainState._hasK1 ^ mainState._hasK2)
            {
                refSearchCriteria.rbSearchKotor1.Checked = mainState._hasK1;
                refSearchCriteria.rbSearchKotor1.Enabled = mainState._hasK1;
                refSearchCriteria.rbSearchKotor2.Checked = mainState._hasK2;
                refSearchCriteria.rbSearchKotor2.Enabled = mainState._hasK2;
                refSearchCriteria.tbSearchString.Focus();
            }

            //refSearchCriteria.ShowDialog(this);
            if (refSearchCriteria.DialogResult != DialogResult.OK) return;
            Cursor current = Cursor.Current;
            int kotorVerIndex = !refSearchCriteria.rbSearchKotor1.Checked ? 1 : 0;
            if (refSearchCriteria.chkbAllBifs.Checked | refSearchCriteria.chkbScripts.Checked | refSearchCriteria.chkbTemplates.Checked && ObjectType.ObjTst(_treeView.Nodes[kotorVerIndex].Nodes[0].Nodes[0].Tag, "dummy", false) == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                BuildTreeView((KotorTreeNode) _treeView.Nodes[kotorVerIndex], true);
            }

            if (refSearchCriteria.chkbAllBifs.Checked)
            {
                int num2 = 0;
                int num3 = _treeView.Nodes[kotorVerIndex].Nodes[0].Nodes.Count - 1;
                int bifToSearchId = num2;
                while (bifToSearchId <= num3)
                {
                    presenter.SearchBifsForText(kotorVerIndex, refSearchCriteria.tbSearchString.Text, refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, resultsForm, bifToSearchId);
                    ++bifToSearchId;
                }
            }
            else
            {
                if (refSearchCriteria.chkbScripts.Checked)
                {
                    int num2 = 0;
                    int num3 = _treeView.Nodes[kotorVerIndex].Nodes[0].Nodes.Count - 1;
                    int bifToSearchId = num2;
                    while (bifToSearchId <= num3 && !_treeView.Nodes[kotorVerIndex].Nodes[0].Nodes[bifToSearchId].Text.ToLower().EndsWith("scripts.bif")) ++bifToSearchId;
                    presenter.SearchBifsForText(kotorVerIndex, refSearchCriteria.tbSearchString.Text, refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, resultsForm, bifToSearchId);
                }

                if (refSearchCriteria.chkbTemplates.Checked)
                {
                    int num2 = 0;
                    int num3 = _treeView.Nodes[kotorVerIndex].Nodes[0].Nodes.Count - 1;
                    int bifToSearchId = num2;
                    while (bifToSearchId <= num3 && !_treeView.Nodes[kotorVerIndex].Nodes[0].Nodes[bifToSearchId].Text.ToLower().EndsWith("templates.bif")) ++bifToSearchId;
                    SearchBifsForText(kotorVerIndex, refSearchCriteria.tbSearchString.Text, refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, resultsForm, bifToSearchId);
                }
            }

            if (refSearchCriteria.chkbRIMs.Checked) presenter.SearchAllModuleRimsForText(kotorVerIndex, refSearchCriteria.tbSearchString.Text, refSearchCriteria.rbtnSensitive.Checked, refSearchCriteria.htFileTypes, resultsForm);
            if (resultsForm.lbMatches.Items.Count == 0)
            {
                resultsForm.lblNoMatchesFound.Visible = true;
                resultsForm.lbMatches.Visible = false;
                resultsForm.lblDesc.Visible = false;
                resultsForm.Size = resultsForm.MinimumSize;
                resultsForm.lbMatches.Enabled = false;
            }

            Cursor.Current = current;
           // UtilWindowRelativePositioner relativePositioner = new UtilWindowRelativePositioner(this,resultsForm);
           // ((Control) resultsForm).Location = relativePositioner.GetConcentric();
          //  resultsForm.Show();
          */
            return new Form();
        }
        
        
         public void HandleDataByNodeType(TreeView treeView, KotorTreeNode node, object sender)
        {
            Cursor current = Cursor.Current;
            Constants.CurrentSettings = UserSettings.GetSettings();
            object tag = node.Tag;
            byte[] numArray1 = null;
            if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0)
            {
                numArray1 = new RimObject().GetRimResource(node.FilePath, node);
            }

            else if (ObjectType.ObjTst(tag, "BIFF_Res", false) == 0)
            {
                if (StringType.StrCmp(node.ResTypeStr, "mdl", false) != 0)
                {
                    numArray1 = BiffFunctions.GetBiffResource(node.FilePath, node.LocalResId).Data;
                }
            }
            else if (ObjectType.ObjTst(tag, "ERF_Res", false) == 0)
            {
                numArray1 = new ErfObject().GetErfResource(node.FilePath, node);
            }
            else
            {
                if (ObjectType.ObjTst(tag, "globalvar", false) != 0)
                {
                    return;
                }

                new FrmGlobalVarEditor(new ClsGlobalVars(ByteFunctions.ReadByteArray(node.FilePath + "\\" + node.Filename), KotorTreeNode.NodeTreeRootIndex(treeView, node)), node.FilePath, KotorTreeNode.NodeTreeRootIndex(treeView,node)).Show();
                return;
            }

            string resTypeStr = node.ResTypeStr;
            if (StringType.StrCmp(resTypeStr, "mdl", false) == 0)
            {
                if (ConfigOptions.Paths.ModelExportLocation == null || !Directory.Exists(ConfigOptions.Paths.ModelExportLocation))
                {
                    Interaction.MsgBox("The Model Export Location is not set.\n\nA default path has been set in the Path Manager; you may accept it or choose your own.", MsgBoxStyle.Critical, "Path not set");
                    using (frmPathManager frmPathManager = new frmPathManager())
                    {
                        if (!Directory.Exists(MainFormState.GRootPath + "working\\Exported Models"))
                        {
                            Directory.CreateDirectory(MainFormState.GRootPath + "working\\Exported Models");
                        }

                        frmPathManager.tbModuleExportPath.Text = MainFormState.GRootPath + "working\\Exported Models";
                        frmPathManager.StartPosition = FormStartPosition.CenterScreen;
                        frmPathManager.TabControl1.SelectedIndex = 2;
                        frmPathManager.tbModuleExportPath.BackColor = Color.MistyRose;
                        frmPathManager.ShowDialog();
                    }

                    Constants.CurrentSettings = UserSettings.GetSettings();
                }

                int mdlRoomCount = Mdl.GetMdlRoomCount(treeView,node);
                frmMdlOpsSwitches frmMdlOpsSwitches = new frmMdlOpsSwitches();
                frmMdlOpsSwitches.chkbExtractAnimations.Checked = ConfigOptions.Toggles.ModelExtractionExtractAnimations;
                frmMdlOpsSwitches.chkbConvertSkin.Checked = ConfigOptions.Toggles.ModelExtractionConvertSkinToTrimesh;
                frmMdlOpsSwitches.chkbEachModelInOwnDir.Checked = ConfigOptions.Toggles.ModelExtractionEachModelInOwnDirectory;
                frmMdlOpsSwitches.chkbCleanWorkingDir.Checked = ConfigOptions.Toggles.ModelExtractionCleanWorkingDirectoryBeforeExport;
                frmMdlOpsSwitches.tbModelExtractionPath.Text = ConfigOptions.Paths.ModelExportLocation;
                if (frmMdlOpsSwitches.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                while (frmMdlOpsSwitches.tbModelExtractionPath.Text.EndsWith("\\")) frmMdlOpsSwitches.tbModelExtractionPath.Text = frmMdlOpsSwitches.tbModelExtractionPath.Text.Substring(0, frmMdlOpsSwitches.tbModelExtractionPath.Text.Length - 1);
              
                if (StringType.StrCmp(frmMdlOpsSwitches.tbModelExtractionPath.Text.Replace("\\" + Mdl.GetMdlRoomBaseName(treeView,node), ""), ConfigOptions.Paths.ModelExportLocation, false) != 0)
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
              
                frmProgressMeter frmProgressMeter = new frmProgressMeter();
                frmProgressMeter.stepAmount = 1;
                frmProgressMeter.maxvalue = Convert.ToInt32(frmMdlOpsSwitches.nudNumberToExtract.Value);
                frmProgressMeter.message = "Extracting models";
               // ((Control) frmProgressMeter).Location = new UtilWindowRelativePositioner(this, frmProgressMeter).GetConcentric();
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
                    if (KotorTreeNode.NodeTreeRootIndex(treeView,node) == 1)
                    {
                        fileName = node.ResRef.Substring(0, 6);
                    }

                    StreamWriter streamWriter = new StreamWriter(new FileStream("C:\\3dsmax7\\scripts\\NWmax\\plugins\\test.txt", FileMode.Create));
                    StreamReader streamReader = new StreamReader(new MemoryStream(BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView,node), fileName, 3000)));
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamWriter.WriteLine(mdlRoomCount);
                    int num1 = 1;
                    int num2 = mdlRoomCount;
                    int num3 = num1;
                    while (num3 <= num2)
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

                        ++num3;
                    }

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
                        BiffFunctions.ExportBiffResource(KotorTreeNode.NodeTreeRootIndex(treeView,node), node.ResRef, 3008, path + ".mdx");
                        frmProgressMeter.status = "Exporting model " + node.ResRef;
                        string str1 = MainFormState.GRootPath + "mdlops.exe";
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
                                    byte[] erfResource = new ErfObject().GetErfResource(ConfigOptions.Paths.KotorLocation(KotorTreeNode.NodeTreeRootIndex(treeView,node)) + "\\TexturePacks\\swpc_tex_tpa.erf", str3, 3007);
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

                        node = (KotorTreeNode) node.NextNode;
                        frmProgressMeter.stepUp();

                        ++num2;
                    }
                }

                frmProgressMeter.Close();
                Interaction.MsgBox("Extraction Complete", MsgBoxStyle.Information, "Model Extraction");
            }
            else if (StringType.StrCmp(resTypeStr, "2da", false) == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                new Frm2DaEditor(node.Filename, numArray1, KotorTreeNode.NodeTreeRootIndex(treeView,node)).Show();
            }
            else if (StringType.StrCmp(resTypeStr, "pwk", false) == 0 || StringType.StrCmp(resTypeStr, "dwk", false) == 0 || StringType.StrCmp(resTypeStr, "wok", false) == 0)
            {
                using (FrmBwmEditor bwmEditor = new FrmBwmEditor(numArray1, node.Filename))
                {
                    bwmEditor.Show();
                }
            }

            else if (StringType.StrCmp(resTypeStr, "nss", false) == 0 || StringType.StrCmp(resTypeStr, "vis", false) == 0 || StringType.StrCmp(resTypeStr, "txi", false) == 0 || StringType.StrCmp(resTypeStr, "lyt", false) == 0)
            {
                using (frmTextEditor frmTextEditor = new frmTextEditor(node.Filename))
                {
                    ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                    frmTextEditor.tbGeneric.Text = asciiEncoding.GetString(numArray1);
                    frmTextEditor.tbGeneric.SelectionLength = 0;
                    frmTextEditor.KotorVersionIndex = KotorTreeNode.NodeTreeRootIndex(treeView,node);
                    if (StringType.StrCmp(node.ResTypeStr, "nss", false) == 0) frmTextEditor.PrepareForScriptEditing();
                    frmTextEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "ncs", false) == 0)
            {
                //DirectoryUtils.EnsureWorkingDirectoryExists();
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
            }
            else if (StringType.StrCmp(resTypeStr, "are", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "fac", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "jrl", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "git", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "gui", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "ifo", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "itp", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "pth", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "ptm", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "ptt", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "res", false) == 0 ||
                     StringType.StrCmp(resTypeStr, "ute", false) == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                if ((uint) (Control.ModifierKeys & Keys.Shift) > 0U)
                {
                    ClsGff clsGff = new ClsGff(KotorTreeNode.NodeTreeRootIndex(treeView,node));
                    clsGff.RtfMode = false;
                    clsGff.Parse(numArray1);
                    using (frmTextEditor frmTextEditor = new frmTextEditor())
                    {
                        frmTextEditor.Filename = node.Filename;
                        frmTextEditor.Text = "Text Editor - " + node.Filename;
                        frmTextEditor.RTFMode = false;
                        frmTextEditor.tbGeneric.Text = clsGff.ToString();
                        frmTextEditor.tbGeneric.SelectionLength = 0;
                        frmTextEditor.Show();
                    }
                }
                else if ((uint) (Control.ModifierKeys & Keys.Control | (Keys) (-(ConfigOptions.Toggles.AlwaysUnknownGfFasText ? 1 : 0))) > 0U)
                {
                    ClsGff clsGff = new ClsGff(KotorTreeNode.NodeTreeRootIndex(treeView,node));
                    clsGff.RtfMode = true;
                    clsGff.Parse(numArray1);
                    using (frmTextEditor frmTextEditor = new frmTextEditor())
                    {
                        frmTextEditor.Filename = node.Filename;
                        frmTextEditor.Text = "Text Editor - " + node.Filename;
                        frmTextEditor.RTFMode = true;
                        frmTextEditor.tbGeneric.Rtf = clsGff.ToString();
                        frmTextEditor.tbGeneric.SelectionLength = 0;
                        frmTextEditor.Show();
                    }
                }
                else
                {
                    new GffObject().EditGffResource(node.Filename, numArray1);
                }
            }
            else if (StringType.StrCmp(resTypeStr, "utc", false) == 0)
            {
                using (frmUTC_Editor frmUtcEditor = new frmUTC_Editor(new ClsUtc(numArray1, KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtcEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtcEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "utd", false) == 0)
            {
                using (frmUTD_Editor frmUtdEditor = new frmUTD_Editor(new ClsUtd(numArray1,KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtdEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtdEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "uti", false) == 0)
            {
                using (frmUTI_Editor frmUtiEditor = new frmUTI_Editor(new ClsUti(numArray1, KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtiEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtiEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "utm", false) == 0)
            {
                using (frmUTM_Editor frmUtmEditor = new frmUTM_Editor(new ClsUtm(numArray1, KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtmEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtmEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "utp", false) == 0)
            {
                using (FrmUtpEditor frmUtpEditor = new FrmUtpEditor(new ClsUtp(numArray1, KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtpEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtpEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "uts", false) == 0)
            {
                using (frmUTS_Editor frmUtsEditor = new frmUTS_Editor(new ClsUts(numArray1,KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtsEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtsEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "utt", false) == 0)
            {
                using (frmUTT_Editor frmUttEditor = new frmUTT_Editor(new ClsUtt(numArray1, KotorTreeNode.NodeTreeRootIndex(treeView,node)), KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUttEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUttEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "utw", false) == 0)
            {
                using (frmUTW_Editor frmUtwEditor = new frmUTW_Editor(new ClsUtw(numArray1,KotorTreeNode.NodeTreeRootIndex(treeView,node)),KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    frmUtwEditor.EditingFilePath = ConfigOptions.Paths.DefaultSaveLocation + "\\" + node.Text;
                    frmUtwEditor.Show();
                }
            }
            else if (StringType.StrCmp(resTypeStr, "tpc", false) == 0 || StringType.StrCmp(resTypeStr, "txb", false) == 0)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    Tpc.EditTpcResource(node.Filename, numArray1);
                }
                else
                {
                    FrmImageViewer.Factory.ShowTgaImage(node);
                }
            }
            else if (StringType.StrCmp(resTypeStr, "tga", false) == 0)
            {
               // FrmImageViewer.Factory.OpenTgaInExternalViewer(node.Filename, numArray1);
            }

            else if (StringType.StrCmp(resTypeStr, "dlg", false) == 0)
            {
                using (FrmDialogEditor dialogEditor = new FrmDialogEditor(numArray1, node.ResRef, KotorTreeNode.NodeTreeRootIndex(treeView,node)))
                {
                    dialogEditor.Show();
                }
            }

            else if (StringType.StrCmp(resTypeStr, "ssf", false) == 0)
            {
                ClsSsf ssf = new ClsSsf(numArray1,KotorTreeNode.NodeTreeRootIndex(treeView,node));
                FrmSsfEditor frmSsfEditor = new FrmSsfEditor(ssf);
                int num1 = 0;
                do
                {
                    Console.WriteLine("Index: " + StringType.FromInteger(num1) + "  StringRef: " + StringType.FromInteger(ssf.GetRefArray(num1)) + "  SoundResRef: '" + ssf.GetRefArraySoundResRef(num1) + "'  String: '" + ssf.GetRefArrayString(num1) + "'");
                    ++num1;
                } while (num1 <= 39);

                frmSsfEditor.ShowDialog();
            }

            Cursor.Current = current;
        }
   
        
         public object ExtractSelectedKotorFile(KotorTreeNode node, string outputpath = "", string saveMsg = "", Hashtable resTypes = null)
        {
            object tag = node.Tag;
            if (ObjectType.ObjTst(tag, "RIM", false) == 0)
            {
                if (StringType.StrCmp(saveMsg, "", false) == 0) saveMsg = "Select Folder to extract RIM to...";
                if (StringType.StrCmp(outputpath, "", false) == 0) outputpath = StringType.FromObject(ObjectType.StrCatObj(FileUtils.GetFilePath("", ConfigOptions.Paths.DefaultSaveLocation, "", saveMsg, ""), "\\"));
                if (StringType.StrCmp(outputpath, "\\", false) != 0)
                {
                    Cursor current = Cursor.Current;
                    Cursor.Current = Cursors.WaitCursor;
                    FileStream fileStream = new FileStream(node.FilePath + "\\" + node.Filename, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
                    byte[] indata = binaryReader.ReadBytes((int) fileStream.Length);
                    binaryReader.Close();
                    ClsRim clsRim = new ClsRim(indata);
                    if (resTypes == null)
                    {
                        int num1 = 0;
                        int num2 = clsRim.EntryCount - 1;
                        int index = num1;
                        while (index <= num2)
                        {
                            ByteFunctions.WriteByteArray(outputpath + ((RimKeyEntry) clsRim.KeyEntryList[index]).ResourceName + "." + ((RimKeyEntry) clsRim.KeyEntryList[index]).ResTypeStr, clsRim.GetRimResource(index));
                            ++index;
                        }
                    }
                    else
                    {
                        int num1 = 0;
                        int num2 = clsRim.EntryCount - 1;
                        int index = num1;
                        while (index <= num2)
                        {
                            if (resTypes.Contains(((RimKeyEntry) clsRim.KeyEntryList[index]).ResType)) ByteFunctions.WriteByteArray(outputpath + ((RimKeyEntry) clsRim.KeyEntryList[index]).ResourceName + "." + ((RimKeyEntry) clsRim.KeyEntryList[index]).ResTypeStr, clsRim.GetRimResource(index));
                              ++index;
                        }
                    }
                      Cursor.Current = current;
                }
                else
                    goto label_78;
            }
            else if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0) // CHECKS FOR RIM TAG
            {
                outputpath = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, node.Filename, "Save " + node.Filename + " file...", node.ResTypeStr));
                if (StringType.StrCmp(outputpath, "", false) != 0)
                {
                    byte[] rimResource = new RimObject().GetRimResource(node.FilePath, node);
                    ByteFunctions.WriteByteArray(outputpath, rimResource);
                }
                else
                    goto label_78;
            }
            else if (ObjectType.ObjTst(tag, "BIFF", false) == 0) // CHECKS FOR BIFF TAG
            {
                if (StringType.StrCmp(outputpath, string.Empty, false) == 0) outputpath = StringType.FromObject(ObjectType.StrCatObj(FileUtils.GetFilePath("", ConfigOptions.Paths.DefaultSaveLocation, "", "Select Folder to extract BIF to...", ""), "\\"));
                if (StringType.StrCmp(outputpath, "\\", false) != 0)
                {
                    Cursor current = Cursor.Current;
                    Cursor.Current = Cursors.WaitCursor;
                    foreach (KotorTreeNode node1 in node.Nodes)
                    {
                        int num1 = 0;
                        int num2 = node1.GetNodeCount(false) - 1;
                        int index = num1;
                        while (index <= num2)
                        {
                            BiffFunctions.ExportBiffResource(node.FilePath + "\\" + node.Filename, outputpath + ((KotorTreeNode) node1.Nodes[index]).ResRef + "." + ((KotorTreeNode) node1.Nodes[index]).ResTypeStr, ((KotorTreeNode) node1.Nodes[index]).LocalResId);
                            ++index;
                        }
                    }
                 
                    Cursor.Current = current;
                }
                else
                    goto label_78;
            }
            else if (ObjectType.ObjTst(tag, "BIFF_Res", false) == 0) //CHECKS FOR BIFF RES
            {
                outputpath = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, node.Filename, "Save " + node.Filename + " file...", node.ResTypeStr));
                if (StringType.StrCmp(outputpath, string.Empty, false) != 0) BiffFunctions.ExportBiffResource(node.FilePath, outputpath, node.LocalResId);
                else goto label_78;
            }
            else if (ObjectType.ObjTst(tag, "ERF", false) == 0) //CHECKS FOR ERF TAG
            {
                outputpath = StringType.FromObject(ObjectType.StrCatObj(FileUtils.GetFilePath(string.Empty, ConfigOptions.Paths.DefaultSaveLocation, "", "Select Folder to extract ERF to...", ""), "\\"));
                if (StringType.StrCmp(outputpath, "\\", false) != 0)
                {
                    FileStream fs = new FileStream(node.FilePath + "\\" + node.Filename, FileMode.Open, FileAccess.Read);
                    ClsErf clsErf = new ClsErf(fs);
                    frmProgressMeter frmProgressMeter = new frmProgressMeter();
                    frmProgressMeter.stepAmount = 1;
                    frmProgressMeter.maxvalue = clsErf.EntryCount;
                    frmProgressMeter.message = "Extracting files from " + node.Filename;
                    //((Control) frmProgressMeter).Location = new UtilWindowRelativePositioner(this, frmProgressMeter).GetConcentric();
                    frmProgressMeter.Show();
                    int num1 = 0;
                    int num2 = clsErf.EntryCount - 1;
                    int index = num1;
                    while (index <= num2)
                    {
                        byte[] erfResource = clsErf.GetErfResource(index);
                        ErfKeyEntry keyEntry = (ErfKeyEntry) clsErf.KeyEntryList[index];
                        frmProgressMeter.status = "Writing " + keyEntry.ResourceName + "." + keyEntry.ResTypeStr;
                        FileStream fileStream = new FileStream(outputpath + keyEntry.ResourceName + "." + keyEntry.ResTypeStr, FileMode.Create);
                        fileStream.Write(erfResource, 0, erfResource.Length);
                        fileStream.Close();
                        frmProgressMeter.stepUp();
                        ++index;
                        
                    }

                    fs.Close();
                    frmProgressMeter.Close();
                }
                else
                    goto label_78;
            }
            else if (ObjectType.ObjTst(tag, "ERF_Res", false) == 0)
            {
                string sLeft = "";
                if (StringType.StrCmp(node.ResTypeStr, "tpc", false) == 0)
                {
                    if (!ConfigOptions.Toggles.AlwaysConvertTpc2Tga)
                    {
                        frmTPCFileSaveType frmTpcFileSaveType = new frmTPCFileSaveType();
                        if (frmTpcFileSaveType.ShowDialog() != DialogResult.Cancel) sLeft = frmTpcFileSaveType.saveType;
                        else
                            goto label_78;
                    }
                    else
                        sLeft = "tga";

                    outputpath = StringType.StrCmp(sLeft, "tga", false) != 0 ? StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, node.Filename, "Save " + node.Filename + " file...", "tpc")) : StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, node.ResRef + ".tga", "Save " + node.ResRef + ".tga file...", "tga"));
                }
                else outputpath = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, node.Filename + string.Empty, "Save " + node.Filename + " file...", ""));

                if (StringType.StrCmp(outputpath, "", false) != 0)
                {
                    byte[] erfResource = new ErfObject().GetErfResource(node.FilePath, node);
                    if (StringType.StrCmp(sLeft, "tga", false) == 0)
                    {
                        using (FrmImageViewer frmImageViewer = new FrmImageViewer())
                        {
                            frmImageViewer.SetupTpcData(erfResource, "foo");
                            frmImageViewer.DecodeImage();
                            frmImageViewer.WriteTgaFile(outputpath);
                        }
                    }
                    else
                        ByteFunctions.WriteByteArray(outputpath, erfResource);
                }
                else
                    goto label_78;
            }
            else if (ObjectType.ObjTst(tag, "NodeCategory", false) == 0)
            {
                string containingFileType = ((KotorTreeNode) node.Parent).ContainingFileType;
                KotorTreeNode parent = (KotorTreeNode) node.Parent;
                if (StringType.StrCmp(containingFileType, "BIF", false) == 0 || StringType.StrCmp(containingFileType, "rim", false) == 0)
                {
                    if (StringType.StrCmp(saveMsg, string.Empty, false) == 0) saveMsg = "Select Folder to extract entire subtype to...";
                    if (StringType.StrCmp(outputpath, string.Empty, false) == 0) outputpath = StringType.FromObject(ObjectType.StrCatObj(FileUtils.GetFilePath(string.Empty, ConfigOptions.Paths.DefaultSaveLocation, string.Empty, saveMsg, string.Empty), "\\"));
                    if (StringType.StrCmp(outputpath, "\\", false) == 0) goto label_78;
                }

                string sLeft = containingFileType;
                if (StringType.StrCmp(sLeft, "BIF", false) == 0)
                {
                    Cursor current = Cursor.Current;
                    Cursor.Current = Cursors.WaitCursor;
                    foreach (KotorTreeNode node1 in node.Nodes) BiffFunctions.ExportBiffResource(parent.FilePath + "\\" + parent.Filename, outputpath + node1.ResRef + "." + node1.ResTypeStr, node1.LocalResId);
                    Cursor.Current = current;
                }
                else if (StringType.StrCmp(sLeft, "rim", false) == 0)
                {
                    Cursor current = Cursor.Current;
                    Cursor.Current = Cursors.WaitCursor;
                    FileStream fileStream = new FileStream(parent.FilePath + "\\" + parent.Filename, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
                    byte[] indata = binaryReader.ReadBytes((int) fileStream.Length);
                    binaryReader.Close();
                    ClsRim clsRim = new ClsRim(indata);
                    int num1 = 0;
                    int num2 = clsRim.EntryCount - 1;
                    int index = num1;
                    while (index <= num2)
                    {
                        if (((RimKeyEntry) clsRim.KeyEntryList[index]).ResType == node.ResType) ByteFunctions.WriteByteArray(outputpath + ((RimKeyEntry) clsRim.KeyEntryList[index]).ResourceName + "." + ((RimKeyEntry) clsRim.KeyEntryList[index]).ResTypeStr, clsRim.GetRimResource(index));
                        ++index;
                    }

                    Cursor.Current = current;
                }
            }

            return outputpath;
            label_78:
            object obj = new object();
            return obj;
        }
        
        
        
    }
}