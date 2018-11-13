

namespace KotorTool_2._0.ViewModels
{
  public class DialogTlkStrDataElement
  {
    public int Flags;
    public string Text;
    public string SoundResRef;
    public float SoundLength;

    public DialogTlkStrDataElement()
    {
      Text = "";
      SoundResRef = "";
      SoundLength = 0.0f;
    }

    public DialogTlkStrDataElement(int entryFlags, string entryText, string entrySoundResRef, float entrySoundLength = 0.0f)
    {
      Text = "";
      SoundResRef = "";
      SoundLength = 0.0f;
      Flags = entryFlags;
      Text = entryText;
      SoundResRef = entrySoundResRef;
      SoundLength = entrySoundLength;
    }
  }
}
