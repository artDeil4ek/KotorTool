using System;

namespace CoreData.Biff
{
    [Serializable]
    public class BiffVariableResourceEntryInfo
    {
        public int ResourceId;
        public int Offset;
        public int FileSize;
        public int ResourceType;
    }
}