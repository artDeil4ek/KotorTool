using System.IO;

namespace KotorTool_2._0.Utils
{
    public class FStream
    {
        public static FileStream Generate(string filePath)
        {
            FileStream fsin = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            return fsin;
        }
    }
}