using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0
{
    public class Crypt
    {



        private readonly byte[] _theKey;
        private readonly byte[] _vector;



        public Crypt()
        {
            _theKey = new byte[] { 136, 21, 221, 65, 1, 37, byte.MaxValue, 171 };
            _vector = new byte[] { 23, 100, 38, 174, 24, 37, 61, 65, 26, 37, byte.MaxValue, 171, 224 };
        }




        public string Encrypt(string inName)
        {
            string str = string.Empty;
            try
            {
                byte[] numArray = new byte[4097];
                ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                MemoryStream memoryStream = new MemoryStream(1024);
                byte[] bytes = asciiEncoding.GetBytes(inName);
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateEncryptor(_theKey, _vector), CryptoStreamMode.Write);
                int length = inName.Length;
                cryptoStream.Write(bytes, 0, length);
                cryptoStream.FlushFinalBlock();
                string base64String = Convert.ToBase64String(memoryStream.ToArray());
                cryptoStream.Close();
                str = base64String;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }

            return str;
        }



        
        public string Decrypt(string inStr)
        {
            string str = string.Empty;
            try
            {
                byte[] buffer1 = Convert.FromBase64String(inStr);
                byte[] buffer2 = new byte[1025];
                MemoryStream memoryStream = new MemoryStream();
                DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
                memoryStream.Write(buffer1, 0, buffer1.Length);
                memoryStream.Seek(0L, SeekOrigin.Begin);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateDecryptor(_theKey, _vector), CryptoStreamMode.Read);
                StringBuilder stringBuilder = new StringBuilder();
                int num1;
                do
                {
                    num1 = cryptoStream.Read(buffer2, 0, 64);
                    int num2 = 0;
                    int num3 = num1 - 1;
                    int index = num2;
                    while (index <= num3)
                    {
                        stringBuilder.Append(Convert.ToChar(buffer2[index]));
                        ++index;
                    }
                } while (num1 != 0);

                cryptoStream.Close();
                str = stringBuilder.ToString();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }

            return str;
        }
    }
}
