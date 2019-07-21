using System.IO;
using KotorTool_2._0.Models.CLS;

namespace KotorTool_2._0.Services.Abstractions
{
    public interface IBwm
    {
        void ReadFromStream(MemoryStream ms);
        void WriteBinary(string filepath);
        void ParseAsciiWalkMesh(string filepath);
        void WriteAscii(string filepath, string parentname = "walk_parent");
        void SetAabbNode(ref ClsBwm.AabbNode node, ClsBwm.AabbNode[] aabbArray);
        string RemoveExcessWhitespace(string src);
    }
}