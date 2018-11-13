using System.IO;

namespace KotorTool_2._0.Utils
{
    class ByteFunctions
    {
        public static void WriteByteArray(string outputPath, byte[] byteArray)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create)))
            {
                binaryWriter.Write(byteArray);
            }
        }

        public static byte[] ReadByteArray(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
            {
                byte[] array = new byte[(int)(fileStream.Length - 1L) + 1];
                fileStream.Read(array, 0, (int)fileStream.Length);
                return array;
            }
        }

    }
}
