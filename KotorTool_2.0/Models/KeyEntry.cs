using System;
using System.IO;
using System.Text;
using KotorTool_2._0.Services;

namespace KotorTool_2._0.Models
{
    [Serializable]
    public class KeyEntry : IKeyEntry
    {
        //private int _index;
        public readonly string ResRef;
        public readonly short ResourceType;
        public readonly int ResId;

        public KeyEntry(string sResRef, short iResourceType, int iResId)
        {
            ResRef = sResRef;
            ResourceType = iResourceType;
            ResId = iResId;
        }

        public KeyEntry(int index, FileStream fs, int offset)
        {
            using (BinaryReader binaryReader = new BinaryReader(fs, Encoding.ASCII))
            {
                //_index = index;
                fs.Seek(offset, SeekOrigin.Begin);
                char[] chArray2 = binaryReader.ReadChars(16);
                int index1 = 0;

                while (chArray2[index1] != 0)
                {
                    ++index1;
                    if (index1 > 15)
                    {
                        break;
                    }
                }

                ResRef = new StringBuilder(new string(chArray2)) {Length = index1}.ToString();

                ResourceType = binaryReader.ReadInt16();
                ResId = binaryReader.ReadInt32();
            }
        }

        public KeyEntry(int index, byte[] data, int offset)
        {
            //_index = index;
            StringBuilder stringBuilder = new StringBuilder(new ASCIIEncoding().GetString(data, offset, 16));
            int index1 = 0;
            while (stringBuilder[index1] != 0)
            {
                ++index1;
                if (index1 > 15) break;
            }

            stringBuilder.Length = index1;
            ResRef = stringBuilder.ToString();
            ResourceType = GetInt16FromArray(data, checked(offset + 16));
            ResId = GetInt32FromArray(data, checked(offset + 18));
        }

        public short GetInt16FromArray(byte[] arr, int offset)
        {
            return (short) Math.Round(arr[offset] + arr[offset + 1] * 256.0);
        }

        public int GetInt32FromArray(byte[] arr, int offset)
        {
            return (int) Math.Round(arr[offset] + arr[offset + 1] * 256.0 + arr[offset + 2] * 65536.0 + arr[offset + 3] * 16777216.0);
        }
    }
}