using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using KotorTool_2._0.ByteViewer;
using KotorTool_2._0.Forms;
using KotorTool_2._0.ImageViewer;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace KotorTool_2._0.MainForm
{
    public class FrmMain : Form
    {
     
        private TreeView treeView;
        private Panel containerPanel;
        private MainFormState mainState;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TreeViewPresenter _treeViewPresenter;

        public FrmMain()
        {
            InitializeComponent();
            Load += OnLoad;
            Activated += OnActivated;
           
        }

        private void InitializeComponent()
        {
            containerPanel = new Panel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // containerPanel
            // 
            containerPanel.BackColor = Color.White;
            containerPanel.Location = new Point(1, 48);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(438, 470);
            containerPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
            fileToolStripMenuItem,
            optionsToolStripMenuItem,
            aboutToolStripMenuItem});
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(888, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(88, 29);
            optionsToolStripMenuItem.Text = "ConfigOptions";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(74, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // FrmMain
            // 
            AutoScaleBaseSize = new Size(8, 19);
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(888, 520);
            Controls.Add(containerPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(8, 19);
            Name = "FrmMain";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Kotor Tool_2.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void OnLoad(object sender, EventArgs e)
        {

            mainState = new MainFormState {_biffEntryListArray = new ArrayList[2, 31], _biffEntries = new ArrayList[3], _hasK1 = true, _hasK2 = true};

            Console.WriteLine(mainState._biffEntries.Length);
         
            Constants.CurrentSettings = new Options.ConfigOptions();
            ConfigOptions.Toggles.BuildBiffTreeOnStartup = true;
            ConfigOptions.Toggles.ShowModuleDescriptions = true;
            ConfigOptions.Toggles.ShowModuleLocations = true;
            ConfigOptions.Paths.DefaultKotorLocation = @"E:\Steam\steamapps\common\swkotor";
            ConfigOptions.Paths.DefaultKotorTslLocation = @"E:\Steam\steamapps\common\Knights of the Old Republic II";

            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool");
            
            if (registryKey == null)
            {
                Interaction.MsgBox("Kotor Tool cannot find its key in the registry at HKLM\\software\\SCM\\Kotor Tool.\n\nPlease reinstall Kotor Tool.", MsgBoxStyle.Critical);
                Environment.Exit(0);
            }
          

            treeView = new TreeView();
            _treeViewPresenter = new TreeViewPresenter(mainState, treeView);
            containerPanel.Controls.Add(treeView);

            MainFormState.GRootPath = StringType.FromObject(registryKey.GetValue("path"));
            if (!MainFormState.GRootPath.EndsWith("\\")){ MainFormState.GRootPath += "\\"; }

            treeView.HideSelection = false;
            Text = "Kotor Tool v" + Application.ProductVersion + "/2018";

            treeView.Height = containerPanel.Height;
            treeView.Width = containerPanel.Width;

            if (!mainState._hasK1 & !mainState._hasK2){ Interaction.MsgBox("No installation of Kotor I or II was detected.\n\nMost features will not work.", MsgBoxStyle.Critical, "No games detected"); }

            if (StringType.StrCmp(ConfigOptions.Paths.DefaultKotorLocation, string.Empty, false) == 0 & mainState._hasK1 | StringType.StrCmp(ConfigOptions.Paths.DefaultKotorTslLocation, string.Empty, false) == 0 & mainState._hasK2)
            {
                using (frmPathManager frmPathManager = new frmPathManager())
                {
                    
                    Interaction.MsgBox("We've attempted to detect your KotOR installation,\rbut please verify the directories are correct.", MsgBoxStyle.Information, "First run configuration");
                   
                    if (StringType.StrCmp(ConfigOptions.Paths.DefaultKotorLocation, string.Empty, false) == 0 & mainState._hasK1) frmPathManager.btnAutoDetectKotor1_Click(null, null);
                    if (StringType.StrCmp(ConfigOptions.Paths.DefaultKotorTslLocation, string.Empty, false) == 0 & mainState._hasK2) frmPathManager.btnAutoDetectKotor2_Click(null, null);
                   
                    frmPathManager.StartPosition = FormStartPosition.CenterScreen;
                    frmPathManager.ShowDialog(this);
                }

                Constants.CurrentSettings = UserSettings.GetSettings();
                ConfigOptions.Toggles.BuildModelsBifNode = true;
            }
            if (mainState._hasK1)
            {
                Constants.Gk1ChitinKey = new ClsChitinKey(ConfigOptions.Paths.KeyFileLocation(0));
                Console.WriteLine("gK1ChitinKey: Lsum = " + StringType.FromLong(Constants.Gk1ChitinKey.Lsum) + ", Llength = " + StringType.FromLong(Constants.Gk1ChitinKey.Llength));
                
                if (!Constants.Gk1ChitinKey.IsValid(0))
                {
                    Interaction.MsgBox("Your Kotor I chitin.key file appears to be corrupt.\nYou may want to reinstall KotOR II to fix this.", MsgBoxStyle.Information, "Chitin.key file not valid");
                }

                if (Constants.Gk1ChitinKey.BiffList.Length != 26)
                {
                    Interaction.MsgBox("Your Kotor I chitin.key file appears to have been altered from the official version.\n\nIf you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.", MsgBoxStyle.Critical, "Chitin.key file altered");
                }
            }
            if (mainState._hasK2)
            {
                Constants.Gk2ChitinKey = new ClsChitinKey(ConfigOptions.Paths.KeyFileLocation(1));
                Console.WriteLine("gK2ChitinKey: Lsum = " + StringType.FromLong(Constants.Gk2ChitinKey.Lsum) + ", Llength = " + StringType.FromLong(Constants.Gk2ChitinKey.Llength));
                if (!Constants.Gk2ChitinKey.IsValid(1))
                {
                    Interaction.MsgBox("Your Kotor II chitin.key file appears to be corrupt or is a non-US version.", MsgBoxStyle.Information, "Chitin.key file not valid");
                }

                if (Constants.Gk2ChitinKey.BiffList.Length != 11)
                {
                    Interaction.MsgBox("Your Kotor II chitin.key file appears to have been altered from the official version.\n\nIf you have not altered it by installing custom packages, you may want to reinstall KotOR to fix this.", MsgBoxStyle.Critical, "Chitin.key file altered");
                }
            }
            _treeViewPresenter.SetupTreeRoots();
            if (!mainState._hasK1) treeView.Nodes[0].ForeColor = Color.Gray;
            if (!mainState._hasK2) treeView.Nodes[1].ForeColor = Color.Gray;
            if (mainState._hasK1) _treeViewPresenter.SetupRootChildren((KotorTreeNode)treeView.Nodes[0]);
            if (mainState._hasK2) _treeViewPresenter.SetupRootChildren((KotorTreeNode)treeView.Nodes[1]);
            if (ConfigOptions.Toggles.BuildBiffTreeOnStartup)
            {
                if (mainState._hasK1) _treeViewPresenter.BuildTreeView((KotorTreeNode)treeView.Nodes[0]);
                if (mainState._hasK2) _treeViewPresenter.BuildTreeView((KotorTreeNode)treeView.Nodes[1]);
            }
            if (MainFormState.IsOnly1KotOrInstalled())
            {
                if (mainState._hasK1) treeView.SelectedNode = treeView.Nodes[0];
                if (mainState._hasK2) treeView.SelectedNode = treeView.Nodes[1];
            }
            _treeViewPresenter.CreateTemplateTagsHashFiles();
            NwScript.ExtractNwScripts(mainState);
            // if (mainState._cmdArgs != null) mainState._gCmdLineOpenedForm = _treeViewPresenter.OpenFileFromCmdLine();
            if (ConfigOptions.Toggles.RememberLastTreeNode && ConfigOptions.Paths.LastClickedTvNodePath != null && StringType.StrCmp(ConfigOptions.Paths.LastClickedTvNodePath, string.Empty, false) != 0) _treeViewPresenter.OpenTreeViewToPath(ConfigOptions.Paths.LastClickedTvNodePath, treeView.Nodes[0], 0);
            if (ConfigOptions.Toggles.RememberTreeViewState)
            {
                foreach (object treeOpenPath in ConfigOptions.Paths.TreeOpenPaths) _treeViewPresenter.OpenTreeViewToPath(StringType.FromObject(treeOpenPath), treeView.Nodes[0], 0);
            }
            UserSettings.SaveSettings(Constants.CurrentSettings);
        }

        protected void OnClosing(CancelEventArgs e)
        {
            _treeViewPresenter = null;
            base.OnClosing(e);
        }

        private void OnActivated(object sender, EventArgs e)
        {
          //  if (!(mainState._cmdArgs != null & mainState._gCmdLineOpenedForm != null)) return;
          //  mainState._gCmdLineOpenedForm.BringToFront();
          //  mainState._gCmdLineOpenedForm = null;
        }

        #region MenuItems
        private void CreateMapInfoBFD_Click(object sender, EventArgs e)
        {
            new ClsMapInfoCreator().Write(MainFormState.GRootPath);
        }
      
        
        
        private void cmiExtractForModuleEditing_Click(object sender, EventArgs e)
        {
            MapInfo mapInfo = FrmMapInfoStatus.ReadMapInfoFile();
            string lower = Path.GetFileNameWithoutExtension(((KotorTreeNode) treeView.SelectedNode).Filename)?.ToLower();
            string sLeft1 = "Unsupported";
            string sLeft2 = "Unsupported";
            string sLeft3 = "Unsupported";
            if (mapInfo != null)
            {
                string str = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool")?.GetValue("path")), "maps\\");

                foreach (MapInfo.Map map in mapInfo.MapList)
                {
                    if (StringType.StrCmp(lower, map.MapName, false) != 0) continue;
                    if (map.S)
                    {
                        sLeft1 = !File.Exists(str + "map" + map.MapName + ".map") ? "Missing" : "Available";
                    }

                    if (map.L)
                    {
                        sLeft2 = !File.Exists(str + "map" + map.MapName + "_lg.map") ? "Missing" : "Available";
                    }
                }
                if (StringType.StrCmp(sLeft1, "Unsupported", false) == 0 && StringType.StrCmp(sLeft2, "Unsupported", false) == 0)
                {
                    sLeft3 = "A map is not yet supported for this module.\n\nDo you want to proceed with the extraction?";
                }
                else if (StringType.StrCmp(sLeft1, "Unsupported", false) == 0 && StringType.StrCmp(sLeft2, "Missing", false) == 0 || StringType.StrCmp(sLeft1, "Missing", false) == 0 && StringType.StrCmp(sLeft2, "Unsupported", false) == 0)
                {
                    sLeft3 = "At least one map size is supported for this module, but none was found in your Kotor Tool 'maps' folder.\n\nDo you want to proceed with the extraction?";
                }
            }

            if (StringType.StrCmp(sLeft3, "", false) != 0 && Interaction.MsgBox(sLeft3, MsgBoxStyle.YesNo | MsgBoxStyle.Question, "Map support") == MsgBoxResult.No)
            {
                return;
            }

            KotorTreeNode nextNode = (KotorTreeNode) treeView.SelectedNode.NextNode;
            string str1;
            using (frmResourceTypeSelector resourceTypeSelector = new frmResourceTypeSelector())
            {
                if (resourceTypeSelector.ShowDialog(this) == DialogResult.Cancel)
                {
                    return;
                }

                str1 = StringType.FromObject(FileUtils.GetFilePath("", ConfigOptions.Paths.ModuleExtractPath, "", "Select or create the folder to extract the module to...", "", false, false));
                if (str1 == null || StringType.StrCmp(str1, "", false) == 0)
                {
                    return;
                }

                if (!str1.EndsWith("\\"))
                {
                    str1 += "\\";
                }

                _treeViewPresenter.command.ExtractSelectedKotorFile((KotorTreeNode) treeView.SelectedNode, str1, "", resourceTypeSelector.SelectedResTypes);
                if (StringType.StrCmp(ConfigOptions.Paths.ModuleExtractPath, str1, false) != 0)
                {
                    ConfigOptions.Paths.ModuleExtractPath = str1;
                    UserSettings.SaveSettings(Constants.CurrentSettings);
                }

                _treeViewPresenter.command.ExtractSelectedKotorFile(nextNode, str1, "", resourceTypeSelector.SelectedResTypes);
            }

            string[] files = Directory.GetFiles(str1, "*.git");
            string str2 = "";
            if (files.Length > 0)
            {
                str2 = files[0];
            }

            if (StringType.StrCmp(str2, "", false) != 0)
            {
                ClsGff clsGff = new ClsGff(new FileStream(str2, FileMode.Open),KotorTreeNode.NodeTreeRootIndex(treeView,nextNode));
                if (Interaction.MsgBox("Would you like the .GIT file cleaned of all non-extracted entities?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    /* if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("utc")))
                          clsGff.ClearListElements("Creature List");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("utd")))
                          clsGff.ClearListElements("Door List");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("ute")))
                          clsGff.ClearListElements("Encounter List");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("uti")))
                          clsGff.ClearListElements("Item List");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("utm")))
                          clsGff.ClearListElements("StoreList");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("utp")))
                          clsGff.ClearListElements("Placeable List");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("uts")))
                          clsGff.ClearListElements("SoundList");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("utt")))
                          clsGff.ClearListElements("TriggerList");
                      if (!resourceTypeSelector.SelectedResTypes.Contains(GetIdForRsrcType("utw")))
                          clsGff.ClearListElements("WaypointList");*/
                }

                // clsGff.WriteFile(str2, "GIT");
            }

            if (Interaction.MsgBox("Extraction complete.\nWould you like the Module Editor to be set to open your extract location the next time you use it?", MsgBoxStyle.YesNo) != MsgBoxResult.Yes)
            {
                return;
            }

            Constants.CurrentSettings = UserSettings.GetSettings();
            ConfigOptions.Paths.LastModuleEditedPath = str1;
            UserSettings.SaveSettings(Constants.CurrentSettings);
        }
       
        
        private void miManagePaths_Click(object sender, EventArgs e)
        {
            using (frmPathManager pathManager = new frmPathManager())
            {
                pathManager.ShowDialog(this);
            }
        }
        
        
        private void miRecentFiles_Click(object sender, EventArgs e)
        {
            string filepath = StringType.FromObject(ConfigOptions.MruMainFiles[((MenuItem)sender).Index]);
            Console.WriteLine(filepath);
           // OpenGffFileInEditor(filepath);
        }
        
        
        private void miRefSearch_Click(object sender, EventArgs e)
        {
            //_treeViewPresenter.query.PerformStringSearch();
        }
        
        
        private void CleanWorkingDirectoryOnClick(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to delete all of the files in your working directory?", MsgBoxStyle.OkCancel | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Clean working directory") != MsgBoxResult.Ok) return;
            DirectoryUtils.CleanDirectory(MainFormState.GRootPath + "working");
        }
        
        
        private void OpenWorkingDirectoryOnClick(object sender, EventArgs e)
        {
            new Process { StartInfo = { FileName = "explorer.exe ", Arguments = MainFormState.GRootPath + "working" } }.Start();
        }
        
        
        private void ExtractOnClick(object sender, EventArgs e)
        {
            _treeViewPresenter.command.ExtractSelectedKotorFile((KotorTreeNode)treeView.SelectedNode);
        }
        
        private void HexViewerOnClick(object sender, EventArgs e)
        {
            KotorTreeNode selectedNode = (KotorTreeNode)treeView.SelectedNode;
            if (selectedNode == null || ObjectType.ObjTst(selectedNode.Tag, "BIFF_Root", false) == 0 || ObjectType.ObjTst(selectedNode.Tag, "RIM_Root", false) == 0) return;
            object tag = selectedNode.Tag;
            FrmByteViewer frmByteViewer;
            if (ObjectType.ObjTst(tag, "BIFF", false) == 0 || ObjectType.ObjTst(tag, "RIM", false) == 0) frmByteViewer = new FrmByteViewer(selectedNode.FilePath + "\\" + selectedNode.Filename);
            else if (ObjectType.ObjTst(tag, "RIM_Res", false) == 0) frmByteViewer = new FrmByteViewer(new RimObject().GetRimResource(selectedNode.FilePath, selectedNode));
            else if (ObjectType.ObjTst(tag, "BIFF_Res", false) == 0)
            {
                frmByteViewer = new FrmByteViewer(BiffFunctions.GetBiffResource(selectedNode.FilePath, selectedNode.LocalResId).Data);
            }
            else
            {
                if (ObjectType.ObjTst(tag, "ERF_Res", false) != 0) return;
                frmByteViewer = new FrmByteViewer(new ErfObject().GetErfResource(selectedNode.FilePath, selectedNode));
            }

            frmByteViewer.Show();
        }
        private void ExtractForModuleEditingOnClick(object sender, EventArgs e)
        {
            cmiExtractForModuleEditing_Click(null, null);
        }
      
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _treeViewPresenter = null;
                mainState.components?.Dispose();
            base.Dispose(disposing);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        

        #endregion
        
    }
}