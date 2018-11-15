using System.IO;
using System.Text;

namespace KotorTool_2._0.Utils
{
    public class FStream
    {
        public static FileStream Generate(string filePath)
        {
            FileStream fsin = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000);
            return fsin;
        }

        public static BinaryReader GenerateBinaryReader(FileStream stream)
        {
            BinaryReader binaryReader = new BinaryReader(stream);
            return binaryReader;
        }

        public static BinaryReader GenerateBinReaderWithAscii(FileStream stream)
        {
            BinaryReader binaryReader = new BinaryReader(stream, Encoding.ASCII);
            return binaryReader;
        }
    }
}