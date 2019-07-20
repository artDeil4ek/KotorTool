using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.MainForm.Data
{


    /// <summary>
    /// This will be our handle on all data stored
    /// in association with the tree nodes
    /// </summary>
    
    [Serializable]
    public class NodeData
    {
        public Guid guid { get; set; }
        public string FileName { get; set; }
        public string ContainingFileType { get; set; }
        public string ResourceTypeStr { get; set; }
        public int ResourceType { get; set; }
        public string ResourceRef { get; set; }
        public int LocalResourceId { get; set; }
        public int ResourceId { get; set; }
        public string FilePath { get; set; }
        public int RimOrErfIndex { get; set; }
        public int KotorVersionIndex { get; set; }
    }
}
