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


        /// <summary>
        /// 
        /// </summary>
        private readonly byte[] _key;
        private readonly byte[] _vector;


        /// <summary>
        ///  --------------Default Constructor
        /// </summary>
        public Crypt()
        {
            _key = new byte[] { 136, 21, 221, 65, 1, 37, byte.MaxValue, 171 };
            _vector = new byte[] { 23, 100, 38, 174, 24, 37, 61, 65, 26, 37, byte.MaxValue, 171, 224 };
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="inName"></param>
        /// <returns></returns>
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
                CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoServiceProvider.CreateEncryptor(_key, _vector), CryptoStreamMode.Write);
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="inStringBlock"></param>
        /// <returns></returns>
        public string Decrypt(string inStringBlock)
        {
            string str = string.Empty;
            try
            {
                var buffer = CreateBuffers(inStringBlock, out var cryptoStream, out var stringBuilder);
                IterateAndDecrypt(cryptoStream, buffer, stringBuilder);

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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="inStringBlock"></param>
        /// <param name="cryptoStream"></param>
        /// <param name="stringBuilder"></param>
        /// <returns></returns>
        private byte[] CreateBuffers(string inStringBlock, out CryptoStream cryptoStream, out StringBuilder stringBuilder)
        {
            byte[] buffer1 = Convert.FromBase64String(inStringBlock);
            byte[] buffer2 = new byte[1025];

            MemoryStream memoryStream = new MemoryStream();
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();

            memoryStream.Write(buffer1, 0, buffer1.Length);
            memoryStream.Seek(0L, SeekOrigin.Begin);

            cryptoStream = new CryptoStream(
                memoryStream, 
                cryptoServiceProvider.CreateDecryptor(_key, _vector),
                CryptoStreamMode.Read);

            stringBuilder = new StringBuilder();
            return buffer2;
        }



        /// <summary>
        /// See about the indexer and the way its updated
        /// </summary>
        /// <param name="cryptoStream"></param>
        /// <param name="buffer"></param>
        /// <param name="stringBuilder"></param>
        private void IterateAndDecrypt(CryptoStream cryptoStream, byte[] buffer, StringBuilder stringBuilder)
        {
            int indexer;
            do
            {
                indexer = cryptoStream.Read(buffer, 0, 64);
                int num2 = 0;
                int num3 = indexer - 1;
                int index = num2;
                while (index <= num3)
                {
                    stringBuilder.Append(Convert.ToChar(buffer[index]));
                    ++index;
                }
            } while (indexer != 0);
        }
    }
}
