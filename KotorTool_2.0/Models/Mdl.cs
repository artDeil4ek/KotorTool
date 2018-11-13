using System;
using System.IO;
using System.Windows.Forms;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models
{
    public class Mdl
    {
        public static string GetMdlRoomBaseName(TreeView treeView, KotorTreeNode node)
        {
            switch (KotorTreeNode.NodeTreeRootIndex(treeView,node))
            {
                case 0: return node.ResRef.Substring(0, 5);
                case 1: return node.ResRef.Substring(0, 6);
                default:
                    string str = "";
                    return str;
            }
        }

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

    }
}