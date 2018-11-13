using System.IO;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Models.ERF
{
    public class ErfObject
    {
        public byte[] GetErfResource(string erfFilePath, KotorTreeNode ktn)
        {
            return new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(ktn.RiMorErFindex);
        }

        public byte[] GetErfResource(string erfFilePath, string resRef, int resType)
        {
            return new ClsErf(new FileStream(erfFilePath, FileMode.Open, FileAccess.Read)).GetErfResource(resRef, resType);
        }
    }
}