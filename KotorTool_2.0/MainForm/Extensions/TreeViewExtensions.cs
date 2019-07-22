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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="treeView"></param>
        /// <returns></returns>
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

        
        
        /// <summary>
        /// --- This method should initialise all of the nodes of the treeview by using a recursive inner function
        /// --- previous node guid, current node guid, next node guid should be initialised each call
        /// </summary>
        /// <param name="treeView"></param>
        public static void InitialiseAllNodeIds(this TreeView treeView)
        {

            // TreeNode mainNode = treeView.Nodes[0];
            KotorTreeNode mainNode = (KotorTreeNode)treeView.Nodes[0];
            mainNode.NodeVm.Guid = Guid.NewGuid();

            InitNodeDataRecursive(mainNode);


            void InitNodeDataRecursive(TreeNode parentNode)
            {
                foreach (TreeNode subNode in parentNode.Nodes)
                {
                    KotorTreeNode node = (KotorTreeNode)subNode;
                    node.NodeVm.Guid = Guid.NewGuid();

                    InitNodeDataRecursive(subNode);
                }
            }

           

        }


    }
}
