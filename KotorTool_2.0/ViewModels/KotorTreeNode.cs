using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using KotorTool_2._0.MainForm.Collections;
using KotorTool_2._0.Models;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Models.RIM;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.ViewModels
{


    /// <summary>
    /// TODO: Seperate this class out into seperate files, (Declutter)
    /// TODO: Figure out why this has so many constructors
    /// todo: Set up next node and previous node information in the guids
    /// </summary>
    public class KotorTreeNode : TreeNode
    {

        public NodeVm NodeVm;


        public KotorTreeNode()
        {
            InitialiseDecorations();
            NodeVm.KotorVersionIndex = -1;
        }



        public KotorTreeNode(string text) : base(text)
        {
            InitialiseDecorations();
            NodeVm.KotorVersionIndex = -1;
        }



        public KotorTreeNode(RimKeyEntry rke, string sourcePath) : this(rke)
        {
            InitialiseDecorations();
            NodeVm.FilePath = sourcePath;
        }



        public KotorTreeNode(KeyEntry ke)
        {
            InitialiseDecorations();
            NodeVm.KotorVersionIndex = -1;
            NodeVm.ResourceId = ke.ResId;
            NodeVm.ResourceRef = ke.ResRef;
            NodeVm.ResourceType = ke.ResourceType;
            Text = ke.ResRef + "." + NodeVm.ResourceTypeStr;
        }

        public KotorTreeNode(KeyEntry ke, string sourcePath) : this(ke)
        {
            InitialiseDecorations();
            NodeVm.FilePath = sourcePath;
        }




        public KotorTreeNode(RimKeyEntry rke)
        {
            InitialiseDecorations();
            NodeVm.KotorVersionIndex = -1;
            NodeVm.ResourceId = rke.ResourceId;
            NodeVm.ResourceRef = rke.ResourceName;
            NodeVm.ResourceType = rke.ResType;
            Text = NodeVm.ResourceRef + "." + NodeVm + " (" + StringType.FromInteger(rke.Length) + ")";
            Tag = "RIM_Res";
        }



        public KotorTreeNode(ErfKeyEntry eke)
        {
            InitialiseDecorations();
            NodeVm.KotorVersionIndex = -1;
            NodeVm.ResourceId = eke.ResourceId;
            NodeVm.ResourceRef = eke.ResourceName;
            NodeVm.ResourceType = eke.ResType;
            Text = NodeVm.ResourceRef + "." + NodeVm;
            Tag = "ERF_Res";
        }



        public KotorTreeNode(ErfKeyEntry erfKeyEntry, string sourcePath) : this(erfKeyEntry)
        {
            InitialiseDecorations();
            NodeVm.FilePath = sourcePath;
        }
     
        
        /// <summary>
        /// 
        /// </summary>
        public string Filename
        {
            get
            {
                if (StringType.StrCmp(NodeVm.FileName, String.Empty, false) != 0) return NodeVm.FileName;
                return NodeVm.ResourceRef + "." + ResourceIdentification.GetRsrcTypeForId(NodeVm.ResourceType);
            }
            set => NodeVm.FileName = value;
        }



        public void InitialiseDecorations()
        {
            
            /*
             * ForeColor = Color.Aqua;
             * NodeFont = new Font("Arial",Int32.Parse("10"));
             */

        }


        /// <summary>
        /// Ui function for setting the style of the node
        /// </summary>
        /// <param name="fontColor"></param>
        /// <param name="font"></param>
        public void SetStyle(Color fontColor, Font font)
        {
            ForeColor = fontColor;
            NodeFont = font;
        }



        /// <summary>
        /// ----Needs to be refactored to return a 
        /// </summary>
        /// <returns></returns>
        public List<TreeNode> GetNodes()
        {
            List<TreeNode> list = new List<TreeNode>();
            foreach (TreeNode node in Nodes)
            {
                list.Add(node);
            }
            return list;
        }
        

      
        
       

        

        public override string ToString()
        {
            return Text;
        }

        
    }
}