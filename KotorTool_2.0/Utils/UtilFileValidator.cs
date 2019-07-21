using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Utils
{
    public class UtilFileValidator
    {


        /// <summary>
        /// 
        /// </summary>
        private byte[] _key;




        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public void Init(string key)
        {
            _key = Convert.FromBase64String(key);
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="clearTextKey"></param>
        /// <returns></returns>
        public string GenerateBase64Key(string clearTextKey)
        {
            return Convert.ToBase64String(new ASCIIEncoding().GetBytes(clearTextKey));
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="signature"></param>
        /// <returns></returns>
        public bool Validate(string filePath, string signature)
        {
           using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                byte[] secondKey = Convert.FromBase64String(signature);
                KeyedHashAlgorithm keyedHashAlgorithm = KeyedHashAlgorithm.Create();
                keyedHashAlgorithm.Key = _key;
                byte[] hash = keyedHashAlgorithm.ComputeHash(fileStream);
                return CompareKeys(hash, secondKey);
            }
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        [DebuggerDisplay("SigningKey with filePath = {filePath}, key = {key}")]
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstKey"></param>
        /// <param name="secondKey"></param>
        /// <returns></returns>
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
