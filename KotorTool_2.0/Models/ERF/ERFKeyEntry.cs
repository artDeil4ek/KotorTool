
using KotorTool_2._0.Utils;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Models.ERF
{
    public class ErfKeyEntry
    {
        public readonly string ResourceName;
        public readonly short ResType;
        public readonly string ResTypeStr;
        public readonly int ResourceId;
        public readonly int Offset;
        public readonly int Length;
        public readonly int Index;

        public ErfKeyEntry(string resourceName, short resType, int resourceId, int offset, int length, int index)
        {
            ResourceName = resourceName;
            ResType = resType;
            ResTypeStr = ResourceIdentification.GetRsrcTypeForId(resType);
            ResourceId = resourceId;
            Offset = offset;
            Length = length;
            Index = index;
        }
    }
}