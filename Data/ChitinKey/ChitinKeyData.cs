using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.Models.BIFF;

namespace Data.ChitinKey
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
