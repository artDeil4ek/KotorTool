using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
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
using KotorTool_2._0.OptionsEditor;
using KotorTool_2._0.TextEditor;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MoreLinq;

namespace KotorTool_2._0.MainForm
{
    public class TreeViewPresenter
    {
        private MainFormState _mainState;
        private TreeView _treeView;
        private Aabb aabb;
        public TreeViewCommand command;
        public TreeViewQuery query;
        public KotorNodeRepo nodeRepo;

        public TreeViewPresenter(MainFormState mainState, TreeView treeView)
        {
            _mainState = mainState;
            _treeView = treeView;
            nodeRepo = new KotorNodeRepo();
            command = new TreeViewCommand();
            query = new TreeViewQuery(mainState, treeView);
            aabb = new Aabb();
           

            if (_treeView == null) return;
            _treeView.KeyPress -= TreeView_KeyPress;
            _treeView.MouseDown -= TreeView_MouseDown;
            _treeView.KeyUp -= TreeView_KeyUp;
            _treeView.BeforeCollapse -= TreeView_BeforeCollapse;
            _treeView.BeforeExpand -= TreeView_BeforeExpand;
            _treeView.AfterSelect -= TreeView_AfterSelect;
            _treeView.DoubleClick -= TreeView_DoubleClick;
        }


        public void SetupTreeRoots()
        {
            _treeView.Nodes.Add(nodeRepo.RootKotorNode);
            _treeView.Nodes.Add(nodeRepo.RootKotorTslNode);
        }

        public void SetupRootChildren(KotorTreeNode root)
        {
            KotorTreeNode kotorTreeNode1 = new KotorTreeNode("BIFs") {Tag = "BIFF_Root", FilePath = ConfigOptions.Paths.KotorLocation(_treeView.Nodes.IndexOf(root)) + "\\data"};
            KotorTreeNode kotorTreeNode2 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode1.Nodes.Add(kotorTreeNode2);
            root.Nodes.Add(kotorTreeNode1);
            KotorTreeNode kotorTreeNode3 = new KotorTreeNode("RIMs") {Tag = "RIM_Root", FilePath = ConfigOptions.Paths.KotorLocation(_treeView.Nodes.IndexOf(root)) + "\\Modules"};
            KotorTreeNode kotorTreeNode4 = new KotorTreeNode("Modules") {Tag = "RIM_Modules"};
            KotorTreeNode kotorTreeNode5 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode4.Nodes.Add(kotorTreeNode5);
            kotorTreeNode3.Nodes.Add(kotorTreeNode4);
            KotorTreeNode kotorTreeNode6 = new KotorTreeNode("Rims") {Tag = "RIM_Rims"};
            KotorTreeNode kotorTreeNode7 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode6.Nodes.Add(kotorTreeNode7);
            kotorTreeNode3.Nodes.Add(kotorTreeNode6);
            root.Nodes.Add(kotorTreeNode3);
            KotorTreeNode kotorTreeNode8 = new KotorTreeNode("ERFs") {Tag = "ERF_Root", FilePath = ConfigOptions.Paths.KotorLocation(_treeView.Nodes.IndexOf(root)) + "\\texturePacks"};
            KotorTreeNode kotorTreeNode9 = new KotorTreeNode("TexturePacks") {Tag = "ERF_TexturePacks"};
            KotorTreeNode kotorTreeNode10 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode9.Nodes.Add(kotorTreeNode10);
            kotorTreeNode8.Nodes.Add(kotorTreeNode9);
            root.Nodes.Add(kotorTreeNode8);
            KotorTreeNode kotorTreeNode11 = new KotorTreeNode("Modules") {Tag = "ERF_Modules"};
            KotorTreeNode kotorTreeNode12 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode11.Nodes.Add(kotorTreeNode12);
            kotorTreeNode8.Nodes.Add(kotorTreeNode11);
            KotorTreeNode kotorTreeNode13 = new KotorTreeNode("Saves") {Tag = "Saves_Root", FilePath = ConfigOptions.Paths.KotorLocation(_treeView.Nodes.IndexOf(root)) + "\\Saves"};
            KotorTreeNode kotorTreeNode14 = new KotorTreeNode("") {Tag = "dummy"};
            kotorTreeNode13.Nodes.Add(kotorTreeNode14);
            root.Nodes.Add(kotorTreeNode13);
        }

        public void BuildTreeView(KotorTreeNode root, bool noProgressIndication = false)
        {
            frmProgressMeter frmProgressMeter = new frmProgressMeter();
            string filePath = root.FilePath;
            int index1 = KotorTreeNode.NodeTreeRootIndex(_treeView, root);
            int capacity;
            int num1;
            int num3;
            byte[] numArray;
            FileStream fs = new FileStream(ConfigOptions.Paths.KeyFileLocation(0), FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 600000);
            int num2;
            BinaryReader binaryReader = new BinaryReader(fs);
            frmProgressMeter.message = "Preparing Resource List";
            frmProgressMeter.status = "Reading key file";
            //((Control) frmProgressMeter).Location = relativePositioner.GetConcentric();
            frmProgressMeter.stepAmount = 5;
            root.Nodes[0].Nodes.Clear();
            _treeView.BeginUpdate();
            fs.Seek(8L, SeekOrigin.Begin);
            capacity = binaryReader.ReadInt32();
            num1 = binaryReader.ReadInt32();
            num2 = binaryReader.ReadInt32();
            num3 = binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            binaryReader.ReadInt32();
            _mainState._biffEntries[index1] = new ArrayList(capacity);
            int num4 = 0;
            int num5 = capacity - 1;
            int index2 = num4;
            while (index2 <= num5)
            {
                _mainState._biffEntries[index1].Add(new BiffEntry(index2, fs, num2 + 12 * index2));
                _mainState._biffEntryListArray[index1, index2] = new ArrayList();
                ++index2;
            }

            foreach (BiffEntry biffEntry in _mainState._biffEntries[index1])
            {
                KotorTreeNode kotorTreeNode = new KotorTreeNode(Strings.Mid(biffEntry.Filename, biffEntry.Filename.LastIndexOf("\\", StringComparison.Ordinal) + 2)) {Tag = "BIFF", Filename = Strings.Mid(biffEntry.Filename, biffEntry.Filename.LastIndexOf("\\", StringComparison.Ordinal) + 2), FilePath = filePath + "\\" + Strings.Mid(biffEntry.Filename, 1, biffEntry.Filename.LastIndexOf("\\", StringComparison.Ordinal)), ContainingFileType = "BIF"};
                root.Nodes[0].Nodes.Add(kotorTreeNode);
                Console.WriteLine("Bif name: " + biffEntry.Filename + "  Length: " + StringType.FromInteger(biffEntry.Filelength));
            }

            fs.Seek(num3, SeekOrigin.Begin);
            numArray = new byte[(int) fs.Length + 1];
            fs.Position = 0L;
            fs.Read(numArray, 0, (int) (fs.Length - 1L));
            if (!noProgressIndication) frmProgressMeter.Show();
            int num6 = num1 / 20;
            int num7 = 0;
            int num8 = num1 - 1;
            int index3 = num7;
            while (index3 <= num8)
            {
                KeyEntry keyEntry = new KeyEntry(index3, numArray, num3 + 22 * index3);
                _mainState._biffEntryListArray[index1, keyEntry.ResId >> 20].Add(keyEntry);
                if (index3 / num6 == index3 / (double) num6) frmProgressMeter.stepUp();
                ++index3;
            }

            frmProgressMeter.progress = 0;
            bool buildModelsBifNode = ConfigOptions.Toggles.BuildModelsBifNode;
            int num9 = 0;
            int num10 = 0;
            int num11 = capacity - 1;
            int index4 = num10;
            while (index4 <= num11)
            {
                frmProgressMeter.status = "Building tree for " + ((BiffEntry) _mainState._biffEntries[index1][index4]).Filename;
                if (index4 != 18 || buildModelsBifNode)
                {
                    TreeNode treeNode = new KotorTreeNode();
                    int num12 = 0;
                    int num13 = _mainState._biffEntryListArray[index1, index4].Count - 1;
                    int index5 = num12;
                    while (index5 <= num13)
                    {
                        KotorTreeNode node = new KotorTreeNode((KeyEntry) _mainState._biffEntryListArray[index1, index4][index5]);
                        node.Tag = "BIFF_Res";
                        node.ContainingFileType = "BIF";
                        node.FilePath = filePath + "\\" + ((BiffEntry) _mainState._biffEntries[index1][index4]).Filename;
                        OrganizeNodesByResType((KotorTreeNode) treeNode, node);
                        if (num9 / num6 == num9 / (double) num6) frmProgressMeter.stepUp();
                        ++num9;
                        ++index5;
                    }

                    AttachNodeParentsSortedByDesc((KotorTreeNode) root.Nodes[0].Nodes[index4], (KotorTreeNode) treeNode);
                }

                ++index4;
            }

            _treeView.EndUpdate();
            frmProgressMeter.Hide();
        }

        public void OrganizeNodesByResType(KotorTreeNode collection, KotorTreeNode node)
        {
            foreach (KotorTreeNode node1 in collection.Nodes)
            {
                if (node.ResType == node1.ResType)
                {
                    node1.Nodes.Add(node);
                    return;
                }
            }

            KotorTreeNode kotorTreeNode = new KotorTreeNode(ResourceIdentification.ParentDescForResType(node.ResType)) {ResType = node.ResType, Tag = "NodeCategory"};
            kotorTreeNode.Nodes.Add(node);
            collection.Nodes.Add(kotorTreeNode);
        }

        public void AttachNodeParentsSortedByDesc(KotorTreeNode containerNode, KotorTreeNode unsortedNodeCollection)
        {
            int index1 = 0;
            string[] strArray1 = new string[unsortedNodeCollection.Nodes.Count - 1 + 1];
            KotorTreeNode kotorTreeNode = null;

            foreach (KotorTreeNode node in unsortedNodeCollection.Nodes)
            {
                kotorTreeNode = node;
                strArray1[index1] = kotorTreeNode.Text;
                ++index1;
            }

            Array.Sort((Array) strArray1);
            string[] strArray2 = strArray1;
            int index2 = 0;
            while (index2 < strArray2.Length)
            {
                string sLeft = strArray2[index2];
                foreach (KotorTreeNode node in unsortedNodeCollection.Nodes)
                {
                    kotorTreeNode = node;
                    if (StringType.StrCmp(sLeft, kotorTreeNode.Text, false) == 0) break;
                }

                containerNode.Nodes.Add(kotorTreeNode);
                ++index2;
            }
        }

        public void ScanForRimsAndBuildTree(KotorTreeNode ktn, string directory)
        {
            bool moduleDescriptions = ConfigOptions.Toggles.ShowModuleDescriptions;
            bool showModuleLocations = ConfigOptions.Toggles.ShowModuleLocations;
            FileInfo[] files = new DirectoryInfo(((KotorTreeNode) ktn.Parent.Parent).FilePath + "\\" + directory).GetFiles();
            int index = 0;
            while (index < files.Length)
            {
                FileInfo fileInfo = files[index];
                if (StringType.StrCmp(Strings.LCase(fileInfo.Extension), ".rim", false) == 0)
                {
                    string name = fileInfo.Name;
                    if (moduleDescriptions | showModuleLocations) name += " - ";
                    if (moduleDescriptions) name += ResourceIdentification.GetModuleDescForRimName(fileInfo.Name);
                    if (showModuleLocations) name += ResourceIdentification.GetLocNameForRimName(fileInfo.Name);
                    KotorTreeNode kotorTreeNode1 = new KotorTreeNode(name) {Tag = "RIM", FilePath = fileInfo.DirectoryName, Filename = fileInfo.Name, ContainingFileType = "rim"};
                    KotorTreeNode kotorTreeNode2 = new KotorTreeNode("") {Tag = "dummy"};
                    kotorTreeNode1.Nodes.Add(kotorTreeNode2);
                    ktn.Nodes.Add(kotorTreeNode1);
                }

                ++index;
            }
        }

        public void OpenTreeViewToPath(string treepath, TreeNode currNode, int currLevel, bool selectAfterExpand = true)
        {
            string[] strArray = treepath.Split('\\');
            if (currLevel == strArray.Length) return;
            if (currLevel == 0)
            {
                foreach (TreeNode node in currNode.TreeView.Nodes)
                {
                    if (StringType.StrCmp(node.Text, strArray[currLevel], false) == 0)
                    {
                        node.Expand();
                        if (selectAfterExpand) node.TreeView.SelectedNode = node;
                        OpenTreeViewToPath(treepath, node, checked(currLevel + 1), selectAfterExpand);
                    }
                }
            }
            else
            {
                foreach (TreeNode node in currNode.Nodes)
                {
                    if (StringType.StrCmp(StringFunctions.TrimAfterDash(node.Text), StringFunctions.TrimAfterDash(strArray[currLevel]), false) == 0)
                    {
                        node.Expand();
                        node.TreeView.SelectedNode = node;
                        OpenTreeViewToPath(treepath, node, checked(currLevel + 1), selectAfterExpand);
                    }
                }
            }
        }

        private void TreeView_DoubleClick(object sender, EventArgs e)
        {
            command.HandleDataByNodeType(_treeView, (KotorTreeNode) _treeView.SelectedNode, RuntimeHelpers.GetObjectValue(sender));
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.GetType() == (Type) (object) "System.Windows.Form.TreeNode") return;
            KotorTreeNode node = (KotorTreeNode) e.Node;
            if (!(KotorTreeNode.NodeTreeRootIndex(_treeView, node) == 0 & _mainState._hasK1) && !(KotorTreeNode.NodeTreeRootIndex(_treeView, node) == 1 & _mainState._hasK2)) return;
            if (node.Parent == null || node.Tag == null)
            {
                //this.miExtract.Enabled = false;
                //this.btnExtract.Enabled = false;
                //this.btnHexViewer.Enabled = false;
            }
            else
            {
                //this.btnExtractForModuleEditing.Enabled = false;
                object tag1 = node.Tag;
                if (ObjectType.ObjTst(tag1, "RIM_Modules", false) == 0 || ObjectType.ObjTst(tag1, "RIM_Rims", false) == 0 || ObjectType.ObjTst(tag1, "ERF_Root", false) == 0 || ObjectType.ObjTst(tag1, "ERF_TexturePacks", false) == 0 || ObjectType.ObjTst(tag1, "ERF_Modules", false) == 0 || ObjectType.ObjTst(tag1, "globalvar", false) == 0)
                {
                    // this.miExtract.Enabled = false;
                    // this.btnExtract.Enabled = false;
                    //  this.btnHexViewer.Enabled = false;
                }
                else
                {
                    // this.miExtract.Enabled = true;
                    // this.btnExtract.Enabled = true;
                    // this.btnHexViewer.Enabled = true;
                    object tag2 = node.Tag;
                    if (ObjectType.ObjTst(tag2, "BIFF", false) == 0)
                    {
                    }
                    //  this.btnExtract.Text = "Extract entire BIFF file";
                    else if (ObjectType.ObjTst(tag2, "RIM", false) == 0)
                    {
                        // this.btnExtract.Text = "Extract entire RIM file";
                        if (ObjectType.ObjTst(node.Tag, "RIM", false) != 0 || ObjectType.ObjTst(node.Parent.Tag, "RIM_Modules", false) != 0 || node.Filename.Replace(".rim", "").EndsWith("_s")) ;

                        //this.btnExtractForModuleEditing.Enabled = true;
                    }
                    else if (ObjectType.ObjTst(tag2, "ERF", false) == 0)
                    {
                    }
                    //   this.btnExtract.Text = "Extract entire ERF file";
                    else if (ObjectType.ObjTst(tag2, "BIFF_Res", false) == 0 || ObjectType.ObjTst(tag2, "RIM_Res", false) == 0 || ObjectType.ObjTst(tag2, "ERF_Res", false) == 0)
                    {
                        //   this.btnExtract.Text = "Extract file";
                    }
                    else
                    {
                        if (ObjectType.ObjTst(tag2, "NodeCategory", false) != 0) return;
                        string containingFileType = ((KotorTreeNode) node.Parent).ContainingFileType;
                        if (StringType.StrCmp(containingFileType, "BIF", false) == 0)
                        {
                            //   this.btnExtract.Text = "Extract entire BIFF subtype";
                        }
                        else
                        {
                            if (StringType.StrCmp(containingFileType, "rim", false) != 0) ;

                            //  this.btnExtract.Text = "Extract entire RIM subtype";
                        }
                    }
                }
            }
        }

        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            KotorTreeNode node = (KotorTreeNode) e.Node;
            Constants.CurrentSettings = UserSettings.GetSettings();

            if (!ConfigOptions.Paths.TreeOpenPaths.Contains(node.FullPath)) ConfigOptions.Paths.TreeOpenPaths.Add(node.FullPath);

            AddNodeChildrenToTreePaths(node, ConfigOptions.Paths.TreeOpenPaths);
            UserSettings.SaveSettings(Constants.CurrentSettings);
            object tag = node.Tag;


            if (ObjectType.ObjTst(tag, "BIFF_Root", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0) return;
                BuildTreeView((KotorTreeNode) node.Parent);
            }
            else if (ObjectType.ObjTst(tag, "RIM_Modules", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0) return;
                ScanForRimsAndBuildTree(node, "modules");
                node.Nodes[0].Remove();
            }
            else if (ObjectType.ObjTst(tag, "RIM_Rims", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0) return;
                ScanForRimsAndBuildTree(node, "rims");
                node.Nodes[0].Remove();
            }
            else if (ObjectType.ObjTst(tag, "RIM", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0) return;
                query.ReadRIMentries(this, node.FilePath + "\\" + node.Filename, node);
                node.Nodes[0].Remove();
            }
            else if (ObjectType.ObjTst(tag, "ERF_TexturePacks", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0) return;
                query.ScanForErFsAndBuildTree(node, "texturePacks");
                node.Nodes[0].Remove();
            }
            else if (ObjectType.ObjTst(tag, "ERF_Modules", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) == 0)
                {
                    query.ScanForErFsAndBuildTree(node, "modules");
                    node.Nodes[0].Remove();
                }
                else
                {
                    node.Nodes.Clear();
                    query.ScanForErFsAndBuildTree(node, "modules");
                }
            }
            else if (ObjectType.ObjTst(tag, "ERF", false) == 0)
            {
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) != 0) return;
                query.ReadErfEntries(node.FilePath + "\\" + node.Filename, node);
                node.Nodes[0].Remove();
            }
            else
            {
                // if (ObjectType.ObjTst(tag, "Saves_Root", false) != 0) return;
                if (tag.ToString().Contains("Saves_Root")) return;
                if (ObjectType.ObjTst(node.Nodes[0].Tag, "dummy", false) == 0)
                {
                    query.ScanForSavesAndBuildTree(node.FilePath, node);
                    node.Nodes[0].Remove();
                }
                else
                {
                    node.Nodes.Clear();
                    query.ScanForSavesAndBuildTree(node.FilePath, node);
                }
            }
        }

        private void TreeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            KotorTreeNode node = (KotorTreeNode) e.Node;
            Constants.CurrentSettings = UserSettings.GetSettings();
            int index = ConfigOptions.Paths.TreeOpenPaths.Count - 1;
            while (index >= 0)
            {
                if (BooleanType.FromObject(BooleanType.FromObject(LateBinding.LateGet(ConfigOptions.Paths.TreeOpenPaths[index], null, "StartsWith", new object[1] {node.FullPath + "\\"}, null, null)) || BooleanType.FromObject(ObjectType.ObjTst(ConfigOptions.Paths.TreeOpenPaths[index], node.FullPath, false) == 0) ? true : (object) false)) ConfigOptions.Paths.TreeOpenPaths.RemoveAt(index);
                index += -1;
            }

            UserSettings.SaveSettings(Constants.CurrentSettings);
        }

        private void TreeView_KeyUp(object sender, KeyEventArgs e)
        {
            string resTypeStr = ((KotorTreeNode) _treeView.SelectedNode).ResTypeStr;
            if (!(StringType.StrCmp(resTypeStr, "tpc", false) == 0 | StringType.StrCmp(resTypeStr, "txb", false) == 0)) return;
            if (Constants.GImageViewer != null && Constants.GImageViewer.Created && Constants.GImageViewer.Visible)
            {
                if (!(e.KeyCode == Keys.Up | e.KeyCode == Keys.Down)) return;
                FrmImageViewer.Factory.ShowTgaImage((KotorTreeNode) _treeView.SelectedNode);
            }
            else
            {
                if (e.KeyCode != Keys.Space) return;
                FrmImageViewer.Factory.ShowTgaImage((KotorTreeNode) _treeView.SelectedNode);
            }
        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            _mainState._secondToLastClickedTvNode = _mainState._lastClickedTvNode;
            _mainState._lastClickedTvNode = (KotorTreeNode) _treeView.GetNodeAt(pt);
            if (_mainState._lastClickedTvNode != null)
            {
                _treeView.SelectedNode = _mainState._lastClickedTvNode;
                Constants.CurrentSettings = UserSettings.GetSettings();
                ConfigOptions.Paths.LastClickedTvNodePath = _mainState._lastClickedTvNode.FullPath;
                UserSettings.SaveSettings(Constants.CurrentSettings);
            }

            if (e.Button != MouseButtons.Right || _mainState._lastClickedTvNode == null || ObjectType.ObjTst(_mainState._lastClickedTvNode.Tag, "RIM", false) != 0 || ObjectType.ObjTst(_mainState._lastClickedTvNode.Parent.Tag, "RIM_Modules", false) != 0 || _mainState._lastClickedTvNode.Filename.Replace(".rim", "").EndsWith("_s"))
            {
            }

            // this.tvCMenu.Show((Control) sender, this.TreeView.PointToClient(Control.MousePosition));
        }

        private void TreeView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13 || _treeView.SelectedNode == null) return;
            e.Handled = true;
            command.HandleDataByNodeType(_treeView, (KotorTreeNode) _treeView.SelectedNode, RuntimeHelpers.GetObjectValue(sender));
        }

        private int CurrentTreeRootIndex()
        {
            string lower1 = _mainState._lastClickedTvNode.FullPath.ToLower();
            string sLeft = lower1;
           
            if (StringType.StrCmp(sLeft, "kotor i", false) == 0) return 0;
            
            if (StringType.StrCmp(sLeft, "kotor ii", false) == 0) return 1;
           
            string lower2 = lower1.Substring(0, lower1.IndexOf(_treeView.PathSeparator, StringComparison.Ordinal)).ToLower();
           
            if (StringType.StrCmp(lower2, "kotor i", false) == 0) return 0;
          
            if (StringType.StrCmp(lower2, "kotor ii", false) == 0) return 1;

            int num = 0;
            return num;
        }

        private KotorTreeNode CurrentTreeRoot()
        {
            return (KotorTreeNode) _treeView.Nodes[CurrentTreeRootIndex()];
        }

        public void AddNodeChildrenToTreePaths(KotorTreeNode node, ArrayList arTreeOpenPaths)
        {
            foreach (KotorTreeNode node1 in node.Nodes)
            {
                if (node1.IsExpanded)
                {
                    if (!arTreeOpenPaths.Contains(node1.FullPath)) arTreeOpenPaths.Add(node1.FullPath);
                    AddNodeChildrenToTreePaths(node1, arTreeOpenPaths);
                }
            }
        }

        private KotorTreeNode NodeTreeRoot(KotorTreeNode node)
        {
            return (KotorTreeNode) _treeView.Nodes[KotorTreeNode.NodeTreeRootIndex(_treeView, node)];
        }

        public void ReadTreeBFD_Click(object sender, EventArgs e)
        {
            Version version = Assembly.LoadFrom("G:\\My Documents\\Visual Studio Projects\\KotorTool_2\\MapInfo Generator\\bin\\MapInfo Generator.exe").GetName().Version;
            Console.WriteLine(StringType.FromInteger(version.Major) + "." + StringType.FromInteger(version.Minor) + "." + StringType.FromInteger(version.Build) + "." + StringType.FromInteger(version.Revision));
        }

        public void CreateTemplateTagsHashFiles()
        {
            Hashtable hashtable1 = new Hashtable();
            Hashtable hashtable2 = new Hashtable();
            Hashtable hashtable3 = new Hashtable();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            hashtable1.Add(2040, 0);
            hashtable1.Add(2027, 0);
            hashtable1.Add(2042, 0);
            hashtable1.Add(2025, 0);
            hashtable1.Add(2051, 0);
            hashtable1.Add(2044, 0);
            hashtable1.Add(2035, 0);
            hashtable1.Add(2032, 0);
            hashtable1.Add(2058, 0);
            if (_mainState._hasK1 && !File.Exists("K1TemplateTags.bfd"))
            {
                if (ObjectType.ObjTst(_treeView.Nodes[0].Nodes[0].Nodes[0].Tag, "dummy", false) == 0)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    BuildTreeView((KotorTreeNode) _treeView.Nodes[0], true);
                }


                foreach (KeyEntry keyEntry in _mainState._biffEntryListArray[0, 23])
                {
                    if (!hashtable1.ContainsKey(Convert.ToInt32(keyEntry.ResourceType))) continue;

                    string gffTag = GffObject.GetGffTag(BiffFunctions.K1TemplatesBif().GetBiffResource(keyEntry.ResId - keyEntry.ResId >> 20 << 20).Data);
                    hashtable2.Add(keyEntry.ResRef + "." + ResourceIdentification.GetRsrcTypeForId(keyEntry.ResourceType), gffTag);
                    if (StringType.StrCmp(gffTag, "", false) == 0)
                    {
                        Console.WriteLine("-----------------------------");
                    }
                }

                Stream serializationStream = File.Create("K1TemplateTags.bfd");
                binaryFormatter.Serialize(serializationStream, hashtable2);
                serializationStream.Close();
            }

            if (!_mainState._hasK2 || File.Exists("K2TemplateTags.bfd")) return;
            if (ObjectType.ObjTst(_treeView.Nodes[1].Nodes[0].Nodes[0].Tag, "dummy", false) == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                BuildTreeView((KotorTreeNode) _treeView.Nodes[1], true);
            }

            foreach (KeyEntry keyEntry in _mainState._biffEntryListArray[1, 2])
            {
                if (hashtable1.ContainsKey(Convert.ToInt32(keyEntry.ResourceType)))
                {
                    string gffTag = GffObject.GetGffTag(BiffFunctions.K2TemplatesBif().GetBiffResource(keyEntry.ResId - keyEntry.ResId >> 20 << 20).Data);
                    hashtable3.Add(keyEntry.ResRef + "." + ResourceIdentification.GetRsrcTypeForId(keyEntry.ResourceType), gffTag);
                    if (StringType.StrCmp(gffTag, "", false) == 0)
                    {
                        Console.WriteLine("-----------------------------");
                    }
                }
            }

            Stream serializationStream1 = File.Create("K2TemplateTags.bfd");
            binaryFormatter.Serialize(serializationStream1, hashtable3);
            serializationStream1.Close();
        }

        private void miOptions_Click(object sender, EventArgs e)
        {
            bool buildModelsBifNode;
            bool moduleDescriptions;
            bool showModuleLocations;
            using (frmOptions frmOptions = new frmOptions())
            {
                buildModelsBifNode = ConfigOptions.Toggles.BuildModelsBifNode;
                moduleDescriptions = ConfigOptions.Toggles.ShowModuleDescriptions;
                showModuleLocations = ConfigOptions.Toggles.ShowModuleLocations;
                frmOptions.ShowDialog();
            }

            Constants.CurrentSettings = UserSettings.GetSettings();
            if (!buildModelsBifNode & ConfigOptions.Toggles.BuildModelsBifNode != buildModelsBifNode)
            {
                _treeView.Nodes.Clear();
                SetupTreeRoots();
                MessageBox.Show("Models node added; Treeview rebuilt", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            int index = 0;
            do
            {
                if (_treeView.Nodes[index].Nodes.Count > 0 && ObjectType.ObjTst(_treeView.Nodes[index].Nodes[1].Nodes[0].Nodes[0].Tag, "dummy", false) != 0 && ConfigOptions.Toggles.ShowModuleDescriptions != moduleDescriptions | ConfigOptions.Toggles.ShowModuleLocations != showModuleLocations)
                {
                    bool isExpanded = _treeView.Nodes[index].Nodes[1].Nodes[0].IsExpanded;
                    _treeView.Nodes[index].Nodes[1].Nodes[0].Collapse();
                    _treeView.Nodes[index].Nodes[1].Nodes[0].Nodes.Clear();
                    KotorTreeNode kotorTreeNode = new KotorTreeNode {Tag = "dummy"};
                    _treeView.Nodes[index].Nodes[1].Nodes[0].Nodes.Add(kotorTreeNode);
                    if (isExpanded)
                    {
                        _treeView.Nodes[index].Nodes[1].Nodes[0].Expand();
                    }
                }

                ++index;
            } while (index <= 1);
        }

        private void MiBasicHelpClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(MainFormState.GRootPath + "KT_Help.chm");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (StringType.StrCmp(ex.Message, "", false) != 0)
                {
                    Interaction.MsgBox("Error launching Help File\r\rIs it installed in the same directory as this program?");
                }

                ProjectData.ClearProjectError();
            }
        }

        private void miOpenGFFFile_Click(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", ConfigOptions.Paths.DefaultImportLocation, string.Empty, "Open GFF files...", "gffsupported", true));
            if (objectValue is string) return;
            string[] strArray = (string[]) objectValue;
            int num1 = 0;
            int num2 = checked(strArray.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                new GffObject().OpenGffFileInEditor(strArray[index], index * 20);
                ++index;
            }
        }

        private void MiViewGffFileOnClick(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", ConfigOptions.Paths.DefaultImportLocation, "", "Open GFF files...", "", true));
            if (objectValue is string) return;
            string[] strArray = (string[]) objectValue;
            int num1 = 0;
            int num2 = strArray.Length - 1;
            int index = num1;
            while (index <= num2)
            {
                int kotorVersionIndex = GffObject.GetGffFileKotorVersionIndex(strArray[index]);
                FileStream fs = new FileStream(strArray[index], FileMode.Open, FileAccess.Read);
                ClsGff clsGff = new ClsGff(kotorVersionIndex) {RtfMode = false};
                clsGff.Parse(fs);
                using (frmTextEditor frmTextEditor = new frmTextEditor {Filename = Path.GetFileName(strArray[index])})
                {
                    frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
                    frmTextEditor.RTFMode = true;
                    frmTextEditor.tbGeneric.Text = clsGff.ToString();
                    frmTextEditor.tbGeneric.SelectionLength = 0;
                    frmTextEditor.Show();
                }
                  ++index;
            }
        }
    }
}