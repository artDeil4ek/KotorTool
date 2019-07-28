using System;
using System.Collections;
using System.IO;
using System.Text;

using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Services;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MoreLinq;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsErf : IErf, IDisposable
    {
        public int EntryCount;
        private readonly int _offKeyList;
        private int _offsetResList;
        public readonly ArrayList KeyEntryList;
        private readonly byte[] _keyData;
        private readonly byte[] _resInfoData;
        private readonly FileStream _fstream;

        public ClsErf(string outputFilePath, string fileType, uint descriptionStrRef,ErfLocalizedString[] erfLocalizedStringList, string[] inputFileList)
        {
            FileStream fileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.ASCII);
            char[] chars1 = new char[16];
            binaryWriter.Write((Strings.UCase(Strings.Trim(fileType)) + " V1.0").ToCharArray());
            int num1 = 0;

            if (erfLocalizedStringList != null && erfLocalizedStringList.Length > 0)
            {
                int num2 = !(StringType.StrCmp(Strings.LCase(fileType), "erf", false) == 0 | StringType.StrCmp(Strings.LCase(fileType), "hak", false) == 0) ? 0 : 1;
                int num3 = 0;
                int num4 = erfLocalizedStringList.Length - 1;
                int index = num3;
                while (index <= num4)
                {
                    num1 += 8 + erfLocalizedStringList[index].StringSize + num2;
                    ++index;
                }

                binaryWriter.Write(erfLocalizedStringList.Length);
            }
            else binaryWriter.Write(0);

            binaryWriter.Write(num1);
            binaryWriter.Write(inputFileList.Length);
            binaryWriter.Write(160);
            binaryWriter.Write(num1 + 160);
            binaryWriter.Write(num1 + inputFileList.Length * 24 + 160);
            binaryWriter.Write(DateAndTime.Year(DateAndTime.Now) - 1900);
            binaryWriter.Write((int) DateAndTime.DateDiff(DateInterval.DayOfYear, DateType.FromString("1/1/" + StringType.FromInteger(DateAndTime.Year(DateAndTime.Now))), DateAndTime.Now));
            binaryWriter.Write(descriptionStrRef);
            
            
            
            int num5 = 1;
            do
            {
                binaryWriter.Write(0);
                ++num5;
            } while (num5 <= 29);

            fileStream.Seek(160L, SeekOrigin.Begin);
            if (erfLocalizedStringList != null && erfLocalizedStringList.Length > 0)
            {
                int num2 = !(StringType.StrCmp(Strings.LCase(fileType), "erf", false) == 0 | StringType.StrCmp(Strings.LCase(fileType), "hak", false) == 0) ? 0 : 1;

                FlowUtils.BasicIterator(erfLocalizedStringList.Length - 1, 0, i =>
                {
                    binaryWriter.Write(erfLocalizedStringList[i].LanguageId);
                    binaryWriter.Write(erfLocalizedStringList[i].StringSize);
                    char[] chars2 = new char[erfLocalizedStringList[i].StringSize + num2 - 1 + 1];
                    Array.Clear(chars2, 0, chars2.Length);
                    FlowUtils.BasicIterator(erfLocalizedStringList[i].StringSize - 1, 0, index => { chars2[index] = erfLocalizedStringList[i].StringText[index]; });
                    binaryWriter.Write(chars2);
                });
            }

            fileStream.Seek(num1 + 160, SeekOrigin.Begin);

            FlowUtils.BasicIterator(inputFileList.Length - 1, 0, index =>
            {
                int index1 = 0;
                do
                {
                    chars1[index1] = char.MinValue;
                    ++index1;
                } while (index1 <= 15);

                string withoutExtension = Path.GetFileNameWithoutExtension(inputFileList[index]);

                if (withoutExtension != null)
                {
                    FlowUtils.BasicIterator(withoutExtension.Length - 1, 0, i => { chars1[i] = withoutExtension[i]; });
                }

                binaryWriter.Write(chars1);
                binaryWriter.Write(index);
                binaryWriter.Write(ResourceIdentification.GetIdForResourceType(Strings.Mid(Path.GetExtension(inputFileList[index]), 2)));
                binaryWriter.Write((byte) 0);
                binaryWriter.Write((byte) 0);
            });

            uint uint321 = Convert.ToUInt32(fileStream.Position + inputFileList.Length * 8);

            FlowUtils.BasicIterator(inputFileList.Length - 1, 0, i =>
            {
                binaryWriter.Write(uint321);
                uint uint322 = Convert.ToUInt32(new FileInfo(inputFileList[i]).Length);
                binaryWriter.Write(uint322);
                uint321 = Convert.ToUInt32(Convert.ToInt64(uint321) + Convert.ToInt64(uint322));
            });

            FlowUtils.BasicIterator(inputFileList.Length - 1, 0, i =>
            {
                BinaryReader binaryReader = new BinaryReader(new FileStream(inputFileList[i], FileMode.Open, FileAccess.Read));
                fileStream.Write(binaryReader.ReadBytes((int) new FileInfo(inputFileList[i]).Length), 0, (int) new FileInfo(inputFileList[i]).Length);
                binaryReader.Close();
            });

            binaryWriter.Close();
        }

        public ClsErf(FileStream fs)
        {
            BinaryReader binaryReader = new BinaryReader(fs, Encoding.ASCII);
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            StringBuilder stringBuilder = new StringBuilder();
            _fstream = fs;
            fs.Seek(16L, SeekOrigin.Begin);
            EntryCount = binaryReader.ReadInt32();
            fs.Seek(4L, SeekOrigin.Current);
            _offKeyList = binaryReader.ReadInt32();
            _offsetResList = binaryReader.ReadInt32();
            KeyEntryList = new ArrayList(EntryCount);
            fs.Seek(_offKeyList, SeekOrigin.Begin);
            _keyData = binaryReader.ReadBytes(checked(24 * EntryCount));
            _resInfoData = binaryReader.ReadBytes(checked(16 * EntryCount));
            
            
            int num1 = 0;
            int num2 = checked(EntryCount - 1);
            int index = num1;
            while (index <= num2)
            {
                stringBuilder.Append(asciiEncoding.GetString(_keyData, index * 24, 16));

                int num3 = 0;

                while (_keyData[num3 + index * 24] != 0)
                {
                    ++num3;
                    if (num3 > 15) break;
                }

                stringBuilder.Length = num3;
                string resourceName = stringBuilder.ToString();
                stringBuilder.Length = 0;
                int resourceId = (int) Math.Round(_keyData[index * 24 + 16] + _keyData[index * 24 + 17] * 256.0 + _keyData[index * 24 + 18] * 65536.0 + _keyData[index * 24 + 19] * 16777216.0);
                short resType = (short) Math.Round(_keyData[index * 24 + 20] + _keyData[index * 24 + 21] * 256.0);
                int offset = (int) Math.Round(_resInfoData[index * 8] + _resInfoData[index * 8 + 1] * 256.0 + _resInfoData[index * 8 + 2] * 65536.0 + _resInfoData[index * 8 + 3] * 16777216.0);
                int length = (int) Math.Round(_resInfoData[index * 8 + 4] + _resInfoData[index * 8 + 5] * 256.0 + _resInfoData[index * 8 + 6] * 65536.0 + _resInfoData[index * 8 + 7] * 16777216.0);
                KeyEntryList.Add(new ErfKeyEntry(resourceName, resType, resourceId, offset, length, index));

                ++index;
            }
        }

        public byte[] GetErfResource(int index)
        {
            BinaryReader binaryReader = new BinaryReader(_fstream, Encoding.ASCII);
            ErfKeyEntry keyEntry = (ErfKeyEntry) KeyEntryList[index];
            _fstream.Seek(keyEntry.Offset, SeekOrigin.Begin);
            return binaryReader.ReadBytes(keyEntry.Length);
        }

        public byte[] GetErfResource(string resRef, int resType)
        {
            return GetErfResource(FindIndexForResRef(resRef, resType));
        }

        public int FindIndexForResRef(string resRef, int resType)
        {
            int index = 0;
            foreach (ErfKeyEntry keyEntry in KeyEntryList)
            {
                if (StringType.StrCmp(Strings.LCase(keyEntry.ResourceName), Strings.LCase(resRef), false) == 0 &&
                    keyEntry.ResType == resType)
                {
                    index = keyEntry.Index;
                    break;
                }
            }
            return index;
        }

        public byte[] GetErfTpcResourceHeader(int index)
        {
            using (BinaryReader binaryReader = new BinaryReader(_fstream, Encoding.ASCII))
            {
                ErfKeyEntry keyEntry = (ErfKeyEntry) KeyEntryList[index];
                _fstream.Seek(keyEntry.Offset, SeekOrigin.Begin);
                return binaryReader.ReadBytes(16);
            }
        }
        
        public void Dispose()
        {
            _fstream?.Dispose();
        }

    }
}