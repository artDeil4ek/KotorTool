using System.Collections;
using System.IO;
using CoreData.Biff;

namespace CoreData.ChitinKey
{
    class ChitinKeyData
    {
        public FileStream KeyFileStream;
        public MemoryStream GmMemoryStream;
        public BinaryReader RbBinaryReader;
        public int BiffCount;
        public int KeyCount;
        public int FileTableOff;
        public int KeyTableOff;
        public long Lsum;
        public long Llength;
        public BiffEntry[] BiffList;
        public Hashtable HashtableBiff;
        public Hashtable HashTableResourceRefPlusId;
        public string LastRequestedBiffNameHash;
        public Hashtable BiffListInfo;
    }
}
