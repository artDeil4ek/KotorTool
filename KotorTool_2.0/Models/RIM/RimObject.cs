using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.RIM
{
    public class RimObject
    {
        public byte[] GetRimResource(string rimFilePath, KotorTreeNode ktn)
        {
            return new RimParser(BinaryEngine.GetBytes(rimFilePath)).GetRimResource(ktn.RimOrErfIndex);
        }
    }
}