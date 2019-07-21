using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.ByteViewer;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Ui.MapInfoStatus;
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel KotorTslTreeViewPanel;
        private TreeViewPresenter _treeViewPresenter;

        public FrmMain()
        {
            InitializeComponent();
            Load += OnLoad;
            Activated += OnActivated;
           
        }

        #region Init
        private void InitializeComponent()
        {
            this.containerPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.KotorTslTreeViewPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.DimGray;
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Location = new System.Drawing.Point(-5, -1);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(616, 787);
            this.containerPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 29);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.optionsToolStripMenuItem.Text = "ConfigOptions";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(99, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(616, 834);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.containerPanel);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 791);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kotor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.KotorTslTreeViewPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 1176);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KotorTslTreeViewPanel
            // 
            this.KotorTslTreeViewPanel.Location = new System.Drawing.Point(-3, 0);
            this.KotorTslTreeViewPanel.Name = "KotorTslTreeViewPanel";
            this.KotorTslTreeViewPanel.Size = new System.Drawing.Size(611, 788);
            this.KotorTslTreeViewPanel.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::KotorTool_2._0.Properties.Resources.Dark_with_carbon_fiber_texture_background_vector_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 864);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(8, 19);
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Kotor Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        /// <summary>
        /// ---------------  OnLoad  ----------------------------
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {

            mainState = new MainFormState {BiffEntryListArray = new ArrayList[2, 31], BiffEntries = new ArrayList[3], HasKotor1 = true, HasKotor2 = true};

            Console.WriteLine(mainState.BiffEntries.Length);
         
            Constants.CurrentSettings = new ConfigOptions();
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

            MainFormState.GameRootPath = StringType.FromObject(registryKey.GetValue("path"));
            if (!MainFormState.GameRootPath.EndsWith("\\")){ MainFormState.GameRootPath += "\\"; }

            treeView.HideSelection = false;
            Text = "Kotor Tool v" + Application.ProductVersion + "/2018";

            treeView.Height = containerPanel.Height;
            treeView.Width = containerPanel.Width;

            if (!mainState.HasKotor1 & !mainState.HasKotor2){ Interaction.MsgBox("No installation of Kotor I or II was detected.\n\nMost features will not work.", MsgBoxStyle.Critical, "No games detected"); }

            if (StringType.StrCmp(ConfigOptions.Paths.DefaultKotorLocation, string.Empty, false) == 0 & mainState.HasKotor1 | StringType.StrCmp(ConfigOptions.Paths.DefaultKotorTslLocation, string.Empty, false) == 0 & mainState.HasKotor2)
            {
                using (frmPathManager frmPathManager = new frmPathManager())
                {
                    
                    Interaction.MsgBox("We've attempted to detect your KotOR installation,\rbut please verify the directories are correct.", MsgBoxStyle.Information, "First run configuration");
                   
                    if (StringType.StrCmp(ConfigOptions.Paths.DefaultKotorLocation, string.Empty, false) == 0 & mainState.HasKotor1) frmPathManager.btnAutoDetectKotor1_Click(null, null);
                    if (StringType.StrCmp(ConfigOptions.Paths.DefaultKotorTslLocation, string.Empty, false) == 0 & mainState.HasKotor2) frmPathManager.btnAutoDetectKotor2_Click(null, null);
                   
                    frmPathManager.StartPosition = FormStartPosition.CenterScreen;
                    frmPathManager.ShowDialog(this);
                }

                Constants.CurrentSettings = UserSettings.GetSettings();
                ConfigOptions.Toggles.BuildModelsBifNode = true;
            }
            if (mainState.HasKotor1)
            {
                Constants.Gk1ChitinKey = new ClsChitinKeyProvider(ConfigOptions.Paths.KeyFileLocation(0));
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
            if (mainState.HasKotor2)
            {
                Constants.Gk2ChitinKey = new ClsChitinKeyProvider(ConfigOptions.Paths.KeyFileLocation(1));
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

            if (!mainState.HasKotor1) treeView.Nodes[0].ForeColor = Color.Gray;
            if (!mainState.HasKotor2) treeView.Nodes[1].ForeColor = Color.Gray;
            if (mainState.HasKotor1) _treeViewPresenter.SetupRootChildren((KotorTreeNode)treeView.Nodes[0]);
            if (mainState.HasKotor2) _treeViewPresenter.SetupRootChildren((KotorTreeNode)treeView.Nodes[1]);

            if (ConfigOptions.Toggles.BuildBiffTreeOnStartup)
            {
                if (mainState.HasKotor1) _treeViewPresenter.BuildTreeView((KotorTreeNode)treeView.Nodes[0]);
                if (mainState.HasKotor2) _treeViewPresenter.BuildTreeView((KotorTreeNode)treeView.Nodes[1]);
            }

            if (MainFormState.IsOnly1KotOrInstalled())
            {
                if (mainState.HasKotor1) treeView.SelectedNode = treeView.Nodes[0];
                if (mainState.HasKotor2) treeView.SelectedNode = treeView.Nodes[1];
            }

            _treeViewPresenter.CreateTemplateTagsHashFiles();

            NwScript.ExtractNwScripts(mainState);
           
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
        

        }

        #region MenuItems
        private void CreateMapInfoBFD_Click(object sender, EventArgs e)
        {
            new ClsMapInfoCreator().Write(MainFormState.GameRootPath);
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
            DirectoryUtils.CleanDirectory(MainFormState.GameRootPath + "working");
        }
        
        
        private void OpenWorkingDirectoryOnClick(object sender, EventArgs e)
        {
            new Process { StartInfo = { FileName = "explorer.exe ", Arguments = MainFormState.GameRootPath + "working" } }.Start();
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
        

        
        
    }
}