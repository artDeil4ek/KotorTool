using System.IO;

namespace CoreData.Biff
{
    public class BiffEntry
    {
        public int Index;
        public int FileLength;
        public int Location;
        public string Filename;
        public string BiffName;

        public BiffEntry(int index, FileStream fs, int offset)
        {
            BinaryReader binaryReader = new BinaryReader(fs);
            Index = index;
            fs.Seek(offset, 0);
            FileLength = binaryReader.ReadInt32();
            var stringoffset = binaryReader.ReadInt32();
            int stringlength = binaryReader.ReadInt16();
            Location = binaryReader.ReadInt16();
            fs.Seek(stringoffset, 0);
            Filename = new string(binaryReader.ReadChars(stringlength - 1));
            if (Filename.StartsWith("\\\\"))
            {
                Filename = Filename.Substring(1);
            }

            Filename = Filename.Replace("\\\\", "\\").Replace(":", "\\");
            BiffName = Filename.Replace("data\\", "").Replace(".bif", "");
        }

        public BiffEntry(int index, MemoryStream ms, int offset)
        {
            BinaryReader binaryReader = new BinaryReader(ms);
            Index = index;
            ms.Seek(offset, 0);
            FileLength = binaryReader.ReadInt32();
            var stringoffset = binaryReader.ReadInt32();
            int stringlength = binaryReader.ReadInt16();
            Location = binaryReader.ReadInt16();
            ms.Seek(stringoffset, 0);
            Filename = new string(binaryReader.ReadChars(checked(stringlength - 1)));
            if (Filename.StartsWith("\\\\"))
            {
                Filename = Filename.Substring(1);
            }

            Filename = Filename.Replace("\\\\", "\\").Replace(":", "\\");
            BiffName = Filename.Replace("data\\", "").Replace(".bif", "");
        }
    }
}