using System.Collections;

namespace KotorTool_2._0.Services.Abstractions
{
    public interface IChitinKeyProvider
    {
        Hashtable GetBiffFileHash(string bifName);
        int FindResourceIdForResourceRef(string resRef, int resType);
        ArrayList GetKeysForResourceType(short resType);
        bool IsValid(int index);
    }
}