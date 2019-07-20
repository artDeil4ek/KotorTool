using System.Collections;
using System.IO;
using KotorTool_2._0.Models.GFF;

namespace KotorTool_2._0.Services
{
    public interface IGff
    {
        string GetFieldTypeStr(int type);
        void  Parse(FileStream fs);
        void Parse(byte[] bytes);
        ArrayList SortStructNames();
        GffStruct GffReadStruct(ref GffStructEntry structEntry);
        object GffReadField(GffFieldEntry fieldEntry);
    }
}