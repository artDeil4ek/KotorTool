using System;
using System.Collections;
using System.IO;
using System.Text;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Services;
using KotorTool_2._0.Utils;

namespace KotorTool_2._0.Models.CLS
{
    public partial class ClsGff : IGff, IDisposable
    {
        private int _gStructOffset;
        private int _gStructCount;
        private int _gFieldOffset;
        private int _gFieldCount;
        private int _gLabelOffset;
        private int _gLabelCount;
        private int _gFieldDataOffset;
        private int _gFieldDataCount;
        private int _gFieldIndicesOffset;
        private int _gFieldIndicesCount;
        private int _gListIndicesOffset;
        private int _gListIndicesCount;
        private MemoryStream _gMs;
        private BinaryReader _gRdr;
        protected Array GStructArray;
        private readonly ArrayList _gGffListArr;
        private int _gTabLevel;
        private readonly StringBuilder _gStringbuilder;
        private bool _gBRtfMode;
        private string[] _nodeSearchPath;
        private int _nodeSearchLevel;
        private GffStruct _rootGffStruct;
        private readonly ClsDialogTlk _dialogTlk;
        protected int KotorVersionIndex;
        private int _gFieldCountforCoding;
        private int _maxOffset;
        private int _offsetCnt;
        private const int SizeofGffStruct = 12;
        private const int SizeofGffField = 12;

        public void Dispose()
        {
            _gMs?.Dispose();
            _gRdr?.Dispose();
        }

        public bool RtfMode
        {
            get => _gBRtfMode;
            set => _gBRtfMode = value;
        }

        public ClsGff(int kotorVerIndex)
        {
            _gGffListArr = new ArrayList();
            _gTabLevel = 0;
            _gStringbuilder = new StringBuilder();
            _gBRtfMode = true;
            _nodeSearchLevel = 0;
            _rootGffStruct = new GffStruct();
            _gFieldCountforCoding = 0;
            _maxOffset = 0;
            _offsetCnt = 0;
            KotorVersionIndex = kotorVerIndex;
            if (kotorVerIndex > -1)
                _dialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
            //CreateRootStruct();
        }

        public ClsGff(byte[] bytes, int kotorVerIndex, bool rtfMode = true)
        {
            _gGffListArr = new ArrayList();
            _gTabLevel = 0;
            _gStringbuilder = new StringBuilder();
            _gBRtfMode = true;
            _nodeSearchLevel = 0;
            _rootGffStruct = new GffStruct();
            _gFieldCountforCoding = 0;
            _maxOffset = 0;
            _offsetCnt = 0;
            KotorVersionIndex = kotorVerIndex;
            if (kotorVerIndex > -1) _dialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
            _gBRtfMode = rtfMode;
            Parse(bytes);
        }

        public ClsGff(FileStream fs, int kotorVerIndex, bool rtfMode = true)
        {
            _gGffListArr = new ArrayList();
            _gTabLevel = 0;
            _gStringbuilder = new StringBuilder();
            _gBRtfMode = true;
            _nodeSearchLevel = 0;
            _rootGffStruct = new GffStruct();
            _gFieldCountforCoding = 0;
            _maxOffset = 0;
            _offsetCnt = 0;
            KotorVersionIndex = kotorVerIndex;
            _gRdr = new BinaryReader(fs, Encoding.ASCII);
            byte[] bytes = _gRdr.ReadBytes(checked((int) fs.Length));
            _gRdr.Close();
            if (kotorVerIndex > -1) _dialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
            _gBRtfMode = rtfMode;
            Parse(bytes);
        }

        public ClsGff(string filepath, int kotorVerIndex, bool rtfMode = true) : this(new FileStream(filepath, FileMode.Open, FileAccess.Read), kotorVerIndex, rtfMode)
        {
        }

    }
}