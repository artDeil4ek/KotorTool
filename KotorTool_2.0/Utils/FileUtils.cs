using System.Windows.Forms;
using KotorTool_2._0.Options;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Utils
{
    public class FileUtils
    {
        
        private bool ValidateFile(string filePath, string signature)
        {
            UtilFileValidator utilFileValidator = new UtilFileValidator();
            utilFileValidator.Init(utilFileValidator.GenerateBase64Key("Test String"));
            return utilFileValidator.Validate(filePath, signature);
        }
        
         public static object GetFilePath(string action, string startPath, string suggFilename, string msg, string filtertype, bool multiselect = false, bool updateSavePath = true)
        {
            if (StringType.StrCmp(action, "load", false) == 0)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                string sLeft = filtertype;
                if (StringType.StrCmp(sLeft, "key", false) == 0)
                {
                    openFileDialog1.Title = "Select Chitin.key file...";
                    openFileDialog1.Filter = "Chitin files (*.key)|*.key";
                }
                else if (StringType.StrCmp(sLeft, "2da", false) == 0)
                {
                    openFileDialog1.Title = "Select 2DA file...";
                    openFileDialog1.Filter = "2D Array files (*.2da)|*.2da";
                }
                else if (StringType.StrCmp(sLeft, "tpc", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "TPC Files (*.tpc)|*.tpc";
                }
                else if (StringType.StrCmp(sLeft, "tga", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "TGA files (*.tga)|*.tga";
                }
                else if (StringType.StrCmp(sLeft, "xml", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "XML files (*.xml)|*.xml";
                }
                else if (StringType.StrCmp(sLeft, "dlg", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "DLG (Conversation) files (*.dlg)|*.dlg";
                }
                else if (StringType.StrCmp(sLeft, "tlk", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "Talk files (*.tlk)|*.tlk";
                }
                else if (StringType.StrCmp(sLeft, "pwk", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "All Walkmesh files (*.pwk,*.dwk,*.wok)|*.pwk;*.dwk;*.wok|PWK files (*.pwk)|*.pwk|DWK files (*.dwk)|*.dwk|WOK files (*.wok)|*.wok";
                }
                else if (StringType.StrCmp(sLeft, "ssf", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "SSF files (*.ssf)|*.ssf";
                }
                else if (StringType.StrCmp(sLeft, "gffsupported", false) == 0)
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "Supported GFF format files (*.dlg;*.utc;*.utd;*.uti;*.utm;*.utp;*.uts;*.utt;*.utw)|*.dlg;*.utc;*.utd;*.uti;*.utm;*.utp;*.uts;*.utt;*.utw";
                    OpenFileDialog openFileDialog2 = openFileDialog1;
                    openFileDialog2.Filter = openFileDialog2.Filter + "|Dialog files (*.dlg)|*.dlg";
                    OpenFileDialog openFileDialog3 = openFileDialog1;
                    openFileDialog3.Filter = openFileDialog3.Filter + "|Creature files (*.utc)|*.utc";
                    OpenFileDialog openFileDialog4 = openFileDialog1;
                    openFileDialog4.Filter = openFileDialog4.Filter + "|Door files (*.utd)|*.utd";
                    OpenFileDialog openFileDialog5 = openFileDialog1;
                    openFileDialog5.Filter = openFileDialog5.Filter + "|Item files (*.uti)|*.uti";
                    OpenFileDialog openFileDialog6 = openFileDialog1;
                    openFileDialog6.Filter = openFileDialog6.Filter + "|Merchant files (*.utm)|*.utm";
                    OpenFileDialog openFileDialog7 = openFileDialog1;
                    openFileDialog7.Filter = openFileDialog7.Filter + "|Placeable files (*.utp)|*.utp";
                    OpenFileDialog openFileDialog8 = openFileDialog1;
                    openFileDialog8.Filter = openFileDialog8.Filter + "|Sound files (*.uts)|*.uts";
                    OpenFileDialog openFileDialog9 = openFileDialog1;
                    openFileDialog9.Filter = openFileDialog9.Filter + "|Trigger files (*.utt)|*.utt";
                    OpenFileDialog openFileDialog10 = openFileDialog1;
                    openFileDialog10.Filter = openFileDialog10.Filter + "|Waypoint files (*.utw)|*.utw";
                }
                else
                {
                    openFileDialog1.Title = msg;
                    openFileDialog1.Filter = "All files (*.*)|*.*";
                }

                openFileDialog1.InitialDirectory = startPath;
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Multiselect = multiselect;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.FileName = suggFilename;
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return "";
                if (StringType.StrCmp(startPath, "", false) != 0)
                {
                    Constants.CurrentSettings = UserSettings.GetSettings();
                    ConfigOptions.Paths.DefaultImportLocation = Strings.Mid(openFileDialog1.FileName, 1, openFileDialog1.FileName.LastIndexOf("\\"));
                    UserSettings.SaveSettings(Constants.CurrentSettings);
                }

                if (!multiselect) return openFileDialog1.FileName;
                return openFileDialog1.FileNames;
            }

            if (StringType.StrCmp(action, "save", false) == 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                string sLeft = filtertype;
                if (StringType.StrCmp(sLeft, "2da", false) == 0)
                {
                    saveFileDialog.Title = "Select 2DA file...";
                    saveFileDialog.Filter = "2D Array files (*.2da)|*.2da";
                }
                else if (StringType.StrCmp(sLeft, "tpc", false) == 0)
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter = "TPC Files (*.tpc)|*.tpc";
                }
                else if (StringType.StrCmp(sLeft, "tga", false) == 0)
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter = "TGA files (*.tga)|*.tga";
                }
                else if (StringType.StrCmp(sLeft, "xml", false) == 0)
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                }
                else if (StringType.StrCmp(sLeft, "pwk", false) == 0)
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter =
                        "All Walkmesh files (*.pwk,*.dwk,*.wok)|*.pwk;*.dwk;*.wok|PWK files (*.pwk)|*.pwk|DWK files (*.dwk)|*.dwk|WOK files (*.wok)|*.wok";
                }
                else if (StringType.StrCmp(sLeft, "mod", false) == 0)
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter = "MOD files (*.mod)|*.mod";
                }
                else if (StringType.StrCmp(sLeft, "mod", false) == 0)
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter = "SSF files (*.ssf)|*.ssf";
                }
                else
                {
                    saveFileDialog.Title = msg;
                    saveFileDialog.Filter = "All files (*.*)|*.*";
                }

                saveFileDialog.InitialDirectory = startPath;
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = suggFilename;
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return "";
                if (updateSavePath)
                {
                    Constants.CurrentSettings = UserSettings.GetSettings();
                    ConfigOptions.Paths.DefaultSaveLocation = Strings.Mid(saveFileDialog.FileName, 1, saveFileDialog.FileName.LastIndexOf("\\"));
                    UserSettings.SaveSettings(Constants.CurrentSettings);
                }

                return saveFileDialog.FileName;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = msg;
            folderBrowserDialog.SelectedPath = startPath;
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return "";
            if (updateSavePath)
            {
                Constants.CurrentSettings = UserSettings.GetSettings();
                ConfigOptions.Paths.DefaultSaveLocation = folderBrowserDialog.SelectedPath;
                UserSettings.SaveSettings(Constants.CurrentSettings);
            }

            return folderBrowserDialog.SelectedPath;
        }

    }
}