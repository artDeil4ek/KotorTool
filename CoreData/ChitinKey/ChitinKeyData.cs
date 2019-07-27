using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using CoreData.Biff;

namespace CoreData.ChitinKey
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ChitinKeyData
    {
        public FileStream KeyFileStream { get; set; }
        public MemoryStream GmMemoryStream { get; set; }
        public BinaryReader RbBinaryReader { get; set; }
        public int BiffCount { get; set; }
        public int KeyCount { get; set; }
        public int FileTableOff { get; set; }
        public int KeyTableOff { get; set; }
        public long Lsum { get; set; }
        public long Llength { get; set; }
        public BiffEntry[] BiffList { get; set; }
        public Hashtable HashtableBiff { get; set; }
        public Hashtable HashTableResourceRefPlusId { get; set; }
        public string LastRequestedBiffNameHash { get; set; }
        public Hashtable BiffListInfo { get; set; }
    }
}
