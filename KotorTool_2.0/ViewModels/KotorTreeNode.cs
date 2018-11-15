using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

using KotorTool_2._0.Models;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.ViewModels
{
    public class KotorTreeNode : TreeNode
    {
        private string _mFileName;
        public string ContainingFileType;
        public string ResTypeStr => ResourceIdentification.GetRsrcTypeForId(ResType);
        public int ResType { get; set; }
        public string ResRef { get; }
        public int LocalResId => ResId & 1048575;
        public int ResId { get; }
        public string FilePath { get; set; }
        public int RimOrErfIndex { get; set; }
        public int KotorVerIndex { get; set; }

  
        public string Filename
        {
            get
            {
                if (StringType.StrCmp(_mFileName, "", false) != 0) return _mFileName;
                return ResRef + "." + ResourceIdentification.GetRsrcTypeForId(ResType);
            }
            set => _mFileName = value;
        }

        public void InitialiseDecorations()
        {
           //  ForeColor = Color.Aqua;
             int myNodeFontSize = Int32.Parse("10");
             NodeFont = new Font("Arial",myNodeFontSize);
        }
        
        public List<TreeNode> GetNodes()
        {
            List<TreeNode> list = new List<TreeNode>();
            foreach (TreeNode node in Nodes)
            {
                list.Add(node);
            }
            return list;
        }
        

        public KotorTreeNode()
        {
            InitialiseDecorations();
            KotorVerIndex = -1;
        }

        public KotorTreeNode(string text) : base(text)
        {
            InitialiseDecorations();
            KotorVerIndex = -1;
        }

        public KotorTreeNode(KeyEntry ke)
        {
            InitialiseDecorations();
            KotorVerIndex = -1;
            ResId = ke.ResId;
            ResRef = ke.ResRef;
            ResType = ke.ResourceType;
            Text = ke.ResRef + "." + ResTypeStr;
        }

        public KotorTreeNode(KeyEntry ke, string sourcePath) : this(ke)
        {
            InitialiseDecorations();
            FilePath = sourcePath;
        }

        public KotorTreeNode(RimKeyEntry rke)
        {
            InitialiseDecorations();
            KotorVerIndex = -1;
            ResId = rke.ResourceId;
            ResRef = rke.ResourceName;
            ResType = rke.ResType;
            Text = ResRef + "." + ResTypeStr + " (" + StringType.FromInteger(rke.Length) + ")";
            Tag = "RIM_Res";
        }

        public KotorTreeNode(RimKeyEntry rke, string sourcePath) : this(rke)
        {
            InitialiseDecorations();
            FilePath = sourcePath;
        }

        public KotorTreeNode(ErfKeyEntry eke)
        {
            InitialiseDecorations();
            KotorVerIndex = -1;
            ResId = eke.ResourceId;
            ResRef = eke.ResourceName;
            ResType = eke.ResType;
            Text = ResRef + "." + ResTypeStr;
            Tag = "ERF_Res";
        }

        public KotorTreeNode(ErfKeyEntry eke, string sourcePath) : this(eke)
        {
            InitialiseDecorations();
            FilePath = sourcePath;
        }

        public override string ToString()
        {
            return Text;
        }
        
        public static int NodeTreeRootIndex(TreeView treeView, KotorTreeNode node)
        {
            int num = 0;
            try
            {
                string lower1 = node.FullPath.ToLower();
                string sLeft = lower1;
                if (StringType.StrCmp(sLeft, "kotor i", false) == 0) num = 0;
                else if (StringType.StrCmp(sLeft, "kotor ii", false) == 0)
                {
                    num = 1;
                }
                else
                {
                    string lower2 = lower1.Substring(0, lower1.IndexOf(treeView.PathSeparator, StringComparison.Ordinal)).ToLower();
                    if (StringType.StrCmp(lower2, "kotor i", false) == 0) num = 0;
                    else if (StringType.StrCmp(lower2, "kotor ii", false) == 0) num = 1;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (node == null)
                {
                    num = -1;
                    ProjectData.ClearProjectError();
                }
                else
                {
                    num = node.KotorVerIndex;
                    ProjectData.ClearProjectError();
                }
            }

            return num;
        }
    }
}