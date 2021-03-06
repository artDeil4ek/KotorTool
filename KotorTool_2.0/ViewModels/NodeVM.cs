using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.ViewModels
{
    public class NodeVm
    {
        public Guid Guid { get; set; }
        public Guid NextNodeId { get; set; }
        public Guid PreviousNodeId { get; set; }
        public string FileName { get; set; }
        public string ContainingFileType { get; set; }
        public string ResourceTypeStr => ResourceIdentification.GetRsrcTypeForId(ResourceType);
        public int ResourceType { get; set; }
        public string ResourceRef { get; set; }
        public int LocalResourceId => ResourceId & 1048575;
        public int ResourceId { get; set; }
        public string FilePath { get; set; }
        public int RimOrErfIndex { get; set; }
        public int KotorVersionIndex { get; set; }
    }
}
