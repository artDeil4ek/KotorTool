using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using KotorTool_2._0.Data;
using KotorTool_2._0.MainForm.Collections;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models
{
    public class Mdl
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static string GetMdlRoomBaseName(TreeView treeView, KotorTreeNode node)
        {
            switch (KotorTreeNode.NodeTreeRootIndex(treeView,node))
            {
                case 0: return node.NodeVm.ResourceRef.Substring(0, 5);
                case 1: return node.NodeVm.ResourceRef.Substring(0, 6);
                default:
                    string str = String.Empty;
                    return str;
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        public static int GetMdlRoomCount(TreeView treeView, KotorTreeNode node)
        {
            int num = -1;
            byte[] biffResourceData = BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView, node), GetMdlRoomBaseName(treeView, node), 3000);
            if (biffResourceData != null)
            {
                using (StreamReader streamReader = new StreamReader(new MemoryStream(biffResourceData)))
                {
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    num = Convert.ToInt32(streamReader.ReadLine()?.Replace(" ", string.Empty).Replace("roomcount", string.Empty));
                }
            }

            return num;
        }

        public static int GetMdlRoomCount(TreeViewDataRepository treeViewDataRepository, NodeData nodeData)
        {


            /*
             *
             * Create Replacement for get root index function
             * Possibly Create a RootIndex Variable and map function to it
             *
             */
            int num = -1;
            byte[] biffResourceData = BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView, node), GetMdlRoomBaseName(treeView, node), 3000);
            if (biffResourceData != null)
            {
                using (StreamReader streamReader = new StreamReader(new MemoryStream(biffResourceData)))
                {
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    num = Convert.ToInt32(streamReader.ReadLine()?.Replace(" ", string.Empty).Replace("roomcount", string.Empty));
                }
            }

            return num;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeViewData"></param>
        /// <param name="nodeData"></param>
        /// <returns></returns>
        public static int GetMdlRoomCount(IEnumerable<NodeData> treeViewData, NodeData nodeData)
        {
            int roomCount = -1;

            byte[] biffResourceData = BiffFunctions.GetBiffResourceData(KotorTreeNode.NodeTreeRootIndex(treeView, node),
                GetMdlRoomBaseName(treeView, node), 3000);

            if (biffResourceData != null)
            {
                using (StreamReader streamReader = new StreamReader(new MemoryStream(biffResourceData)))
                {
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    streamReader.ReadLine();
                    roomCount = Convert.ToInt32(streamReader.ReadLine()?.Replace(" ", string.Empty)
                        .Replace("roomcount", string.Empty));
                }
            }

            return roomCount;
        }

    }
}