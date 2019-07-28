using System;
using System.IO;
using System.Text;
using KotorTool_2._0.Services;

namespace KotorTool_2._0.Models
{
    [Serializable]
    public class KeyEntry : IKeyEntry
    {


        public int Index;
        public readonly string ResourceRef;
        public readonly short ResourceType;
        public readonly int ResourceId;



        public KeyEntry(string resourceRef, short resourceType, int resourceId)
        {
            ResourceRef = resourceRef;
            ResourceType = resourceType;
            ResourceId = resourceId;
        }



        public KeyEntry(int index, FileStream fileStream, int offset)
        {
            using (BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII))
            {
                Index = index;
                fileStream.Seek(offset, SeekOrigin.Begin);
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

                ResourceRef = new StringBuilder(new string(chArray2)) {Length = index1}.ToString();

                ResourceType = binaryReader.ReadInt16();
                ResourceId = binaryReader.ReadInt32();
            }
        }



        public KeyEntry(int index, byte[] dataArray, int offset)
        {
            Index = index;

            StringBuilder stringBuilder = new StringBuilder(new ASCIIEncoding().GetString(dataArray, offset, 16));

            int startingIndex = 0;

            while (stringBuilder[startingIndex] != 0)
            {
                ++startingIndex;
                if (startingIndex > 15) break;
            }

            stringBuilder.Length = startingIndex;
            ResourceRef = stringBuilder.ToString();
            ResourceType = GetInt16FromArray(dataArray, checked(offset + 16));
            ResourceId = GetInt32FromArray(dataArray, checked(offset + 18));
        }


        public short GetInt16FromArray(byte[] dataArray, int offset)
        {
            return (short) Math.Round(dataArray[offset] + dataArray[offset + 1] * 256.0);
        }


        public int GetInt32FromArray(byte[] dataArray, int offset)
        {
            return (int) Math.Round(dataArray[offset] + dataArray[offset + 1] * 256.0 + dataArray[offset + 2] * 65536.0 + dataArray[offset + 3] * 16777216.0);
        }
    }
}