using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using KotorTool_2._0.ViewModels;
using Microsoft.Win32;

namespace KotorTool_2._0.MainForm
{
    public class MainFormState
    {
        public IContainer components;
        public static string GRootPath;
        public ArrayList[,] _biffEntryListArray;
        public ArrayList[] _biffEntries;
        public KotorTreeNode _lastClickedTvNode;
        public KotorTreeNode _secondToLastClickedTvNode;
        public byte[] _buffer;
        public string[] _cmdArgs;
        public bool _hasK1;
        public bool _hasK2;
        public Form _gCmdLineOpenedForm;
        public MenuStrip menuStrip1;
      
             

        public static bool HasKotor1()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\Bioware\\SW\\KOTOR");
            bool flag = true;
            if (registryKey != null) flag = registryKey.GetValue("path") != null;
            return flag;
        }

        public static bool HasKotor2()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("software\\LucasArts\\KotOR2");
            bool flag = true;
            if (registryKey != null) flag = registryKey.GetValue("path") != null;
            return flag;
        }

        public static bool IsOnly1KotOrInstalled()
        {
            return HasKotor1() ^ HasKotor2();
        }

        public static int GetUniqueKotorInstalledVersion()
        {
            if (!IsOnly1KotOrInstalled()) return -1;
            if (HasKotor1()) return 0;
            if (HasKotor2()) return 1;
            int num = 0;
            return num;

        }

    }
}