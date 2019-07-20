namespace KotorTool_2._0.Services
{
    public interface IKeyEntry
    {
        short GetInt16FromArray(byte[] arr, int offset);
        int GetInt32FromArray(byte[] arr, int offset);
    }
}