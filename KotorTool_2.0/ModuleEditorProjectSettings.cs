using System;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0
{
  public class ModuleEditorProjectSettings
  {
    public static ModuleEditorProjectOptions GetSettings(string loadPath)
    {
      ModuleEditorProjectOptions editorProjectOptions1;
      try
      {
        loadPath = Path.Combine(loadPath, "project settings.xml");
        ModuleEditorProjectOptions editorProjectOptions2;
        if (File.Exists(loadPath))
        {
          XmlSerializer xmlSerializer = new XmlSerializer(typeof (ModuleEditorProjectOptions));
          FileStream fileStream = new FileStream(loadPath, FileMode.Open, FileAccess.Read);
          editorProjectOptions2 = (ModuleEditorProjectOptions) xmlSerializer.Deserialize(fileStream);
          fileStream.Close();
        }
        else
          editorProjectOptions2 = new ModuleEditorProjectOptions();
        editorProjectOptions1 = editorProjectOptions2;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Interaction.MsgBox(ex.ToString(), MsgBoxStyle.Critical, string.Empty);
        editorProjectOptions1 = null;
        ProjectData.ClearProjectError();
      }
      return editorProjectOptions1;
    }

    public static void SaveSettings(ModuleEditorProjectOptions currentSettings, string savePath)
    {
      try
      {
        savePath = Path.Combine(savePath, "project settings.xml");
        XmlSerializer xmlSerializer = new XmlSerializer(typeof (ModuleEditorProjectOptions));
        FileStream fileStream = new FileStream(savePath, FileMode.Create, FileAccess.ReadWrite);
        xmlSerializer.Serialize(fileStream, currentSettings);
        fileStream.Close();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Interaction.MsgBox(ex.ToString());
        ProjectData.ClearProjectError();
      }
    }
  }
}
