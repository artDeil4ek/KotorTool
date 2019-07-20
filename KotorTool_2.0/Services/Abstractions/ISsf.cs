namespace KotorTool_2._0.Services
{
    public interface ISsf
    {
        int GetRefArray(object index);
        void SetRefArray(object index, int value);
        string GetRefArrayString(object index);
        string GetRefArraySoundResRef(object index);
        void WriteFile(string filepath);
    }
}