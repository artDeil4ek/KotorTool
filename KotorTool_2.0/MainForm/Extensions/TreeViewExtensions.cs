using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KotorTool_2._0.AppConfiguration;
using KotorTool_2._0.Data;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.MainForm.Extensions
{
    public static class TreeViewExtensions
    {


        public static IEnumerable<NodeData> MapTreeNodesToData(this TreeView treeView)
        {

            var collection = new List<NodeData>();

            TreeNode mainNode = treeView.Nodes[0];
            AddNodeDataRecursive(mainNode);


            void AddNodeDataRecursive(TreeNode parentNode)
            {
                foreach (TreeNode subNode in parentNode.Nodes)
                {
                    KotorTreeNode node = (KotorTreeNode)subNode;
                    collection.Add(MappingService.IMapper.Map<NodeVm, NodeData>(node.NodeVm));

                    AddNodeDataRecursive(subNode);
                }
            }

            return collection;
        }



        public static async Task<IEnumerable<NodeData>> MapTreeNodesToDataAsync(this TreeView treeView)
        {

            var collection = new List<NodeData>();

            TreeNode mainNode = treeView.Nodes[0];
            AddNodeDataRecursive(mainNode);

           
             void AddNodeDataRecursive(TreeNode parentNode)
            {
                foreach (TreeNode subNode in parentNode.Nodes)
                {
                    KotorTreeNode node = (KotorTreeNode) subNode;
                    collection.Add(MappingService.IMapper.Map<NodeVm,NodeData>(node.NodeVm));

                    AddNodeDataRecursive(subNode);
                }
            }

            return collection;
        }



    }
}
