namespace CoreData.Biff
{
    public class BiffVarRsrcEntryInfo
    {
        private int _resId;
        public readonly int Offset;
        public readonly int FileSize;
        private int _resourceType;

        public BiffVarRsrcEntryInfo(int resId, int offset, int fileSize, int resourceType)
        {
            _resId = resId;
            Offset = offset;
            FileSize = fileSize;
            _resourceType = resourceType;
        }


        //CAN Be reduced to this
        /* public struct _VResourceHeader
         {
             public UInt32 ID;
             public UInt32 Offset;
             public UInt32 FileSize;
             public UInt32 ResourceType;
         }
         */
    }
}