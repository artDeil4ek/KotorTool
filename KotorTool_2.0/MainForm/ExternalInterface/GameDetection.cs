using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KotorTool_2._0.Properties;
using Microsoft.Win32;

namespace KotorTool_2._0.MainForm.ExternalInterface
{
    public class GameDetection
    {


        public static bool HasKotor1()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Resources.software_Bioware_SW_KOTOR);
            bool flag = true;
            if (registryKey != null) flag = registryKey.GetValue(Resources.path) != null;
            return flag;
        }



        public static bool HasKotor1(Func<String> registryFunc)
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(registryFunc.Invoke());
            bool flag = true;
            if (registryKey != null) flag = registryKey.GetValue(Resources.path) != null;
            return flag;
        }



        public static bool HasKotor2()
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Resources.software_LucasArts_KotOR2);
            bool flag = true;
            if (registryKey != null) flag = registryKey.GetValue(Resources.path) != null;
            return flag;
        }



        public static bool HasKotor2(Func<String> registryFunc)
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(registryFunc.Invoke());
            bool flag = true;
            if (registryKey != null) flag = registryKey.GetValue(Resources.path) != null;
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
