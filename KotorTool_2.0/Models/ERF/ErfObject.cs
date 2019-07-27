using System.IO;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.ERF
{
    public class ErfObject
    {
        public byte[] GetErfResource(string erfFilePath, KotorTreeNode kotorTreeNode)
        {
            return new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(kotorTreeNode.NodeVm.RimOrErfIndex);
        }

        public byte[] GetErfResource(string erfFilePath, string resourceRef, int resourceType  )
        {
            return new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(resourceRef, resourceType);
        }
    }
}