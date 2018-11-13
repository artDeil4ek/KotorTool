using System.IO;
using System.Text;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.RIM
{
    public class RimObject
    {
        public byte[] GetRimResource(string rimFilePath, KotorTreeNode ktn)
        {
            FileStream fileStream = new FileStream(rimFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
            byte[] indata = binaryReader.ReadBytes((int) fileStream.Length);
            binaryReader.Close();
            return new ClsRim(indata).GetRimResource(ktn.RiMorErFindex);
        }
    }
}