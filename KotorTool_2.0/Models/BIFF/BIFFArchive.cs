using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using CoreData.Biff;

namespace KotorTool_2._0.Models.BIFF
{


    [Serializable]
    public class BiffArchive : IDisposable
    {




        /// <summary>
        /// Needs to be put in its on data structure file/class
        /// </summary>
        public int VariableResourceCount;
        public int FixedResourceCount;
        public int VariableResourceEntryOff;
        public int FixedResourceEntryOff;
        public string Signature;
        public string Version;
        public FileStream FileStream;


        
        /// <summary>
        /// 
        /// </summary>
        public BiffArchive()
        {
        }
        
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fixedResEntryOff"></param>
        public BiffArchive(FileStream fixedResEntryOff)
        {
            FileStream = fixedResEntryOff;
            ReadBiffHeader(FileStream);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fsin"></param>
        /// <param name="fixedResourceEntryOff"></param>
        public BiffArchive(FileStream fsin, int fixedResourceEntryOff)
        {
            FileStream = fsin;
            FixedResourceEntryOff = fixedResourceEntryOff;
            ReadBiffHeader(FileStream);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="fs"></param>
        private void ReadBiffHeader(FileStream fs)
        {
            BinaryReader binaryReader = new BinaryReader(fs);

            Signature = new string(binaryReader.ReadChars(4));
            Version = new string(binaryReader.ReadChars(4));
            VariableResourceCount = binaryReader.ReadInt32();
            FixedResourceCount = binaryReader.ReadInt32();
            VariableResourceEntryOff = binaryReader.ReadInt32();
        }
       
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public BiffVariableResourceEntryInfo GetBiffResourceInfo(int offset)
        {

            BinaryReader binaryReader = new BinaryReader(FileStream);
            FileStream.Seek(VariableResourceEntryOff + 16 * offset, 0);

            return new BiffVariableResourceEntryInfo
            {
                ResourceId = binaryReader.ReadInt32(),
                Offset = binaryReader.ReadInt32(),
                FileSize = binaryReader.ReadInt32(),
                ResourceType = binaryReader.ReadInt32()
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public BiffVariableResourceEntry GetBiffResource(int offset)
        {
            BinaryReader binaryReader = new BinaryReader(FileStream);

            BiffVariableResourceEntry biffVariableResourceEntry = new BiffVariableResourceEntry();
            BiffVariableResourceEntryInfo biffResourceInfo = GetBiffResourceInfo(offset);
            FileStream.Seek(biffResourceInfo.Offset, 0);

            biffVariableResourceEntry.Data = binaryReader.ReadBytes(biffResourceInfo.FileSize);
            return biffVariableResourceEntry;
        }


        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            FileStream?.Dispose();
        }
    }
}