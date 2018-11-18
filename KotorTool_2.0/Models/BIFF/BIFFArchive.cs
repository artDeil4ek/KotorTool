using System;
using System.IO;

namespace KotorTool_2._0.Models.BIFF
{
    public class BiffArchive : IDisposable
    {
        private int _varResCnt;
        private int _fixedResCnt;
        private int _varResEntryOff;
        private int _fixedResEntryOff;
        private readonly FileStream _fs;
        private string _signature;
        private string _version;
        public int ResCount => _varResCnt;

        public void Dispose()
        {
            _fs?.Dispose();
        }

        public BiffArchive()
        {
        }
        
        public BiffArchive(FileStream fixedResEntryOff)
        {
            _fs = fixedResEntryOff;
            ReadBiffHeader(_fs);
            
        }


        public BiffArchive(FileStream fsin, int fixedResEntryOff)
        {
            _fs = fsin;
            _fixedResEntryOff = fixedResEntryOff;
            ReadBiffHeader(_fs);
        }

       


        private void ReadBiffHeader(FileStream fs)
        {
            BinaryReader binaryReader = new BinaryReader(fs);

            _signature = new string(binaryReader.ReadChars(4));
            _version = new string(binaryReader.ReadChars(4));
            _varResCnt = binaryReader.ReadInt32();
            _fixedResCnt = binaryReader.ReadInt32();
            _varResEntryOff = binaryReader.ReadInt32();
        }


        public BiffVarRsrcEntryInfo GetBiffResourceInfo(int offset)
        {
            BinaryReader binaryReader = new BinaryReader(_fs);
            _fs.Seek(_varResEntryOff + 16 * offset, 0);
            return new BiffVarRsrcEntryInfo(binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32(), binaryReader.ReadInt32());
        }


        public BiffVarRsrcEntry GetBiffResource(int offset)
        {
            BinaryReader binaryReader = new BinaryReader(_fs);

            BiffVarRsrcEntry bIffVarRsrcEntry = new BiffVarRsrcEntry();
            BiffVarRsrcEntryInfo bIffResourceInfo = GetBiffResourceInfo(offset);
            _fs.Seek(bIffResourceInfo.Offset, 0);
            bIffVarRsrcEntry.Data = binaryReader.ReadBytes(bIffResourceInfo.FileSize);
            return bIffVarRsrcEntry;
        }
    }
}