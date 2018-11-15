using System.IO;

namespace KotorTool_2._0.Models.BIFF
{
    public class BiffEntry
    {
        private int _index;

        public readonly int Filelength;

        private int _location;

        public readonly string Filename;

        public readonly string BiFname;

        public BiffEntry(int index, FileStream fs, int offset)
        {
            BinaryReader binaryReader = new BinaryReader(fs);
            _index = index;
            fs.Seek(offset, 0);
            Filelength = binaryReader.ReadInt32();
            var stringoffset = binaryReader.ReadInt32();
            int stringlength = binaryReader.ReadInt16();
            _location = binaryReader.ReadInt16();
            fs.Seek(stringoffset, 0);
            Filename = new string(binaryReader.ReadChars(stringlength - 1));
            if (Filename.StartsWith("\\\\"))
            {
                Filename = Filename.Substring(1);
            }

            Filename = Filename.Replace("\\\\", "\\").Replace(":", "\\");
            BiFname = Filename.Replace("data\\", "").Replace(".bif", "");
        }

        public BiffEntry(int index, MemoryStream ms, int offset)
        {
            BinaryReader binaryReader = new BinaryReader(ms);
            _index = index;
            ms.Seek(offset, 0);
            Filelength = binaryReader.ReadInt32();
            var stringoffset = binaryReader.ReadInt32();
            int stringlength = binaryReader.ReadInt16();
            _location = binaryReader.ReadInt16();
            ms.Seek(stringoffset, 0);
            Filename = new string(binaryReader.ReadChars(checked(stringlength - 1)));
            if (Filename.StartsWith("\\\\"))
            {
                Filename = Filename.Substring(1);
            }

            Filename = Filename.Replace("\\\\", "\\").Replace(":", "\\");
            BiFname = Filename.Replace("data\\", "").Replace(".bif", "");
        }
    }
}