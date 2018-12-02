using System.IO;
using System.Text;
using KotorTool_2._0.Attributes;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.RIM
{
    public class RimObject
    {
        public byte[] GetRimResource(string rimFilePath, KotorTreeNode ktn)
        {
            using (BinaryEngine engine = new BinaryEngine(rimFilePath))
            {
                byte[] inData = engine.Br.ReadBytes((int) engine.Fs.Length);
                return new RimParser(inData).GetRimResource(ktn.RimOrErfIndex);
            }
        }
    }
}