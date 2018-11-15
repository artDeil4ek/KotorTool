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
        public ArrayList[,] BiffEntryListArray;
        public ArrayList[] BiffEntries;
        public KotorTreeNode LastClickedTvNode;
        public KotorTreeNode SecondToLastClickedTvNode;
        public byte[] Buffer;
        public string[] CmdArgs;
        public bool HasK1;
        public bool HasK2;
      //  public Form GCmdLineOpenedForm;
     //   public MenuStrip MenuStrip1;
      
             

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