using System;
using System.Collections.Generic;
using System.Windows.Forms;
using KotorTool_2._0.MainForm.Data;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.MainForm.Adapters
{


    /// <summary>
    /// This class represents the pipelina and adaptation of ui functions to data equivalents
    ///  ----- Should technically never be needed if the program is structured correctly but the is a different story
    ///  ----- This class should eventually never be needed after data is decoupled from views
    /// </summary>
    public class TreeViewDataAdapter
    {
        
        
        
        
        /// <summary>
        /// Data Separated parameters for the NodeTreeRootIndex Function
        /// </summary>
        /// <param name="treeViewDataRepository"></param>
        /// <param name="nodeData"></param>
        /// <param name="PathSeparator"></param>
        /// <returns></returns>
        public static int NodeTreeRootIndex(IEnumerable<NodeData> treeViewDataRepository, NodeData nodeData, String PathSeparator)
        {
            int rootIndex = 0;

            try
            {
                string lower1 = nodeData.FilePath.ToLower();
                string sLeft = lower1;


                if (StringType.StrCmp(sLeft, "kotor i", false) == 0) rootIndex = 0;

                else if (StringType.StrCmp(sLeft, "kotor ii", false) == 0)
                {
                    rootIndex = 1;
                }
                else
                {
                    string lower2 = lower1.Substring(0, lower1.IndexOf(PathSeparator, StringComparison.Ordinal)).ToLower();
                    if (StringType.StrCmp(lower2, "kotor i", false) == 0) rootIndex = 0;
                    else if (StringType.StrCmp(lower2, "kotor ii", false) == 0) rootIndex = 1;
                }

            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                if (nodeData == null)
                {
                    rootIndex = -1;
                    ProjectData.ClearProjectError();
                }
                else
                {
                    rootIndex = nodeData.KotorVersionIndex;
                    ProjectData.ClearProjectError();
                }
            }

            return rootIndex;
        }



        public IEnumerable<NodeData> MapToDataCollection(TreeView treeView)
        {








            return null;
        }









        /// <summary>
        /// Legacy function for mapping data from treeview
        /// </summary>
        /// <param name="treeView"></param>
        /// <param name="node"></param>
        /// <returns></returns>
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
                    num = node.NodeVm.KotorVersionIndex;
                    ProjectData.ClearProjectError();
                }
            }

            return num;
        }

    }
}
