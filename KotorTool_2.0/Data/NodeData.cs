using System;

namespace KotorTool_2._0.Data
{


    /// <summary>
    /// This will be our handle on all data stored
    /// in association with the tree nodes
    /// </summary>
    
    [Serializable]
    public class NodeData
    {
        public Guid Guid { get; set; }
        public Guid NextNodeId { get; set; }
        public Guid PreviousNodeId { get; set; }
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
