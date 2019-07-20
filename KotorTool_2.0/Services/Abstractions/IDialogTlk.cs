using KotorTool_2._0.ViewModels;

namespace KotorTool_2._0.Services
{
    public interface IDialogTlk
    {
        void Close();
        string GetString(int stringRef);
        string GetSoundResRef(int stringRef);
        float GetSoundLength(int stringRef);
        DialogTlkStrDataElement GetStringDataElement(int stringRef);
        void BuildTalkEntryList();
        void AddTalkEntry(DialogTlkStrDataElement talkEntry);
        void AddTalkEntry(int flags, string text, string soundResRef, float soundLength = 0.0f);
        void ClearTalkEntryList();
        void WriteListToFile(string path);
    }
}