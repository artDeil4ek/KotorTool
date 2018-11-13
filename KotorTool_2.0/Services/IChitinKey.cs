using System.Collections;

namespace KotorTool_2._0.Services
{
    public interface IChitinKey
    {
        Hashtable GetBifFileHash(string bifName);
        int FindResIdForResRef(string resRef, int resType);
        ArrayList GetKeysforResourceType(short resType);
        bool IsValid(int index);
    }
}