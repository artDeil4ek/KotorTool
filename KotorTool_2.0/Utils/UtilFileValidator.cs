using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Utils
{
    public class UtilFileValidator
    {
        private byte[] _key;

        public void Init(string key)
        {
            _key = Convert.FromBase64String(key);
        }

        public string GenerateBase64Key(string clearTextKey)
        {
            return Convert.ToBase64String(new ASCIIEncoding().GetBytes(clearTextKey));
        }

        public bool Validate(string filePath, string signature)
        {
            byte[] secondKey = Convert.FromBase64String(signature);
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            KeyedHashAlgorithm keyedHashAlgorithm = KeyedHashAlgorithm.Create();
            keyedHashAlgorithm.Key = _key;
            byte[] hash = keyedHashAlgorithm.ComputeHash(fileStream);
            fileStream.Close();
            return CompareKeys(hash, secondKey);
        }

        public string Sign(string filepath, string key)
        {
            FileStream fileStream = null;
            byte[] hash = null;
            try
            {
                fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read);
                KeyedHashAlgorithm keyedHashAlgorithm = KeyedHashAlgorithm.Create();
                keyedHashAlgorithm.Key = Convert.FromBase64String(key);
                hash = keyedHashAlgorithm.ComputeHash(fileStream);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Console.WriteLine(ex.ToString());
                ProjectData.ClearProjectError();
            }
            finally
            {
                fileStream?.Close();
            }
            return Convert.ToBase64String(hash);
        }

        private bool CompareKeys(byte[] firstKey, byte[] secondKey)
        {
            if (firstKey.Length != secondKey.Length) return false;
            int num1 = 0;
            int num2 = firstKey.Length - 1;
            int index = num1;
            while (index <= num2)
            {
                if (firstKey[index] != secondKey[index]) return false;
                ++index;
            }
            return true;
        }
    }
}
