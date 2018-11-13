using System;
using System.Collections;
using System.IO;
using System.Text;
using KotorTool_2._0.Services;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsDialogTlk : IDialogTlk
    {
        private readonly FileStream _fs;
        private readonly BinaryReader _rdr;
        private StreamReader _sr;
        public int StringCount;
        private readonly int _stringEntriesOffset;
        private readonly MemoryStream _gMs;
        private readonly byte[] _bytes;
        private ArrayList _talkEntryList;

        public ClsDialogTlk()
        {
        }

        public ClsDialogTlk(string path, bool memoryResident = false)
        {
            _fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _rdr = new BinaryReader(_fs, Encoding.ASCII);
            _fs.Seek(12L, SeekOrigin.Begin);
            StringCount = _rdr.ReadInt32();
            _stringEntriesOffset = _rdr.ReadInt32();
            if (!memoryResident)
                return;
            _fs.Seek(0L, SeekOrigin.Begin);
            _bytes = new byte[checked((int) (_fs.Length - 1L) + 1)];
            _bytes = _rdr.ReadBytes(checked((int) _fs.Length));
            _rdr.Close();
            _gMs = new MemoryStream(_bytes, false);
            _rdr = new BinaryReader(_gMs, Encoding.ASCII);
        }

        public void Close()
        {
            _fs.Close();
        }

        public string GetString(int stringRef)
        {
            if (stringRef > checked(StringCount - 1))
                return "";
            _rdr.BaseStream.Seek(checked(20 + stringRef * 40), SeekOrigin.Begin);
            if ((uint) (_rdr.ReadInt32() & 1) <= 0U)
                return "";
            StringBuilder stringBuilder = new StringBuilder();
            _rdr.BaseStream.Seek(24L, SeekOrigin.Current);
            int num = _rdr.ReadInt32();
            int count = _rdr.ReadInt32();
            _rdr.BaseStream.Seek(checked(_stringEntriesOffset + num), SeekOrigin.Begin);
            stringBuilder.Append(_rdr.ReadChars(count));
            return stringBuilder.ToString();
        }

        public string GetSoundResRef(int stringRef)
        {
            if (stringRef > checked(StringCount - 1))
                return "";
            _rdr.BaseStream.Seek(0L, SeekOrigin.Begin);
            _rdr.BaseStream.Seek(checked(20 + stringRef * 40), SeekOrigin.Begin);
            if ((uint) (_rdr.ReadInt32() & 2) <= 0U)
                return "";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(_rdr.ReadChars(16));
            int index = 0;
            while (Strings.Asc(stringBuilder[index]) != 0)
            {
                checked
                {
                    ++index;
                }

                if (index > 15)
                    break;
            }

            stringBuilder.Length = index;
            return stringBuilder.ToString();
        }

        public float GetSoundLength(int stringRef)
        {
            if (stringRef > checked(StringCount - 1))
                return 0.0f;
            _fs.Seek(0L, SeekOrigin.Begin);
            _fs.Seek(checked(20 + stringRef * 40), SeekOrigin.Begin);
            if ((uint) (_rdr.ReadInt32() & 4) <= 0U)
                return 0.0f;
            _fs.Seek(28L, SeekOrigin.Current);
            return _rdr.ReadSingle();
        }

        public DialogTlkStrDataElement GetStringDataElement(int stringRef)
        {
            if (stringRef > checked(StringCount - 1))
                return null;
            int num1 = checked(20 + stringRef * 40);
            _rdr.BaseStream.Seek(num1, SeekOrigin.Begin);
            DialogTlkStrDataElement tlkStrDataElement = new DialogTlkStrDataElement();
            tlkStrDataElement.Flags = _rdr.ReadInt32();
            if (stringRef == 31483)
                ;
            if ((uint) (tlkStrDataElement.Flags & 2) > 0U)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(_rdr.ReadChars(16));
                int index = 0;
                while (Strings.Asc(stringBuilder[index]) != 0)
                {
                    checked
                    {
                        ++index;
                    }

                    if (index > 15)
                        break;
                }

                stringBuilder.Length = index;
                tlkStrDataElement.SoundResRef = stringBuilder.ToString();
            }

            if ((uint) (tlkStrDataElement.Flags & 4) > 0U)
            {
                _rdr.BaseStream.Seek(checked(num1 + 36), SeekOrigin.Begin);
                tlkStrDataElement.SoundLength = _rdr.ReadSingle();
            }

            if ((uint) (tlkStrDataElement.Flags & 1) > 0U)
            {
                StringBuilder stringBuilder = new StringBuilder();
                _rdr.BaseStream.Seek(checked(num1 + 28), SeekOrigin.Begin);
                int num2 = _rdr.ReadInt32();
                int count = _rdr.ReadInt32();
                _rdr.BaseStream.Seek(checked(_stringEntriesOffset + num2), SeekOrigin.Begin);
                stringBuilder.Append(_rdr.ReadChars(count));
                tlkStrDataElement.Text = stringBuilder.ToString();
            }

            return tlkStrDataElement;
        }

        public void BuildTalkEntryList()
        {
        }

        public void AddTalkEntry(DialogTlkStrDataElement talkEntry)
        {
            if (_talkEntryList == null)
                _talkEntryList = new ArrayList();
            _talkEntryList.Add(talkEntry);
        }

        public void AddTalkEntry(int flags, string text, string soundResRef, float soundLength = 0.0f)
        {
            if (_talkEntryList == null)
                _talkEntryList = new ArrayList();
            _talkEntryList.Add(new DialogTlkStrDataElement(flags, text, soundResRef, soundLength));
        }

        public void ClearTalkEntryList()
        {
            if (_talkEntryList == null)
                return;
            _talkEntryList.Clear();
        }

        public void WriteListToFile(string path)
        {
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Create));
            int num1 = checked(20 + _talkEntryList.Count * 40);
            int offset = num1;
            binaryWriter.Write("TLK V3.0".ToCharArray());
            binaryWriter.Write(Convert.ToInt32(0));
            binaryWriter.Write(Convert.ToInt32(_talkEntryList.Count));
            binaryWriter.Write(Convert.ToInt32(offset));
            int num2 = 0;
            int num3 = checked(_talkEntryList.Count - 1);
            int index = num2;
            while (index <= num3)
            {
                binaryWriter.Seek(checked(20 + index * 40), SeekOrigin.Begin);
                DialogTlkStrDataElement talkEntry = (DialogTlkStrDataElement) _talkEntryList[index];
                binaryWriter.Write(talkEntry.Flags);
                binaryWriter.Write(talkEntry.SoundResRef.PadRight(16, char.MinValue).ToCharArray());
                binaryWriter.Write(Convert.ToInt32(0));
                binaryWriter.Write(Convert.ToInt32(0));
                if ((uint) (talkEntry.Flags & 1) > 0U)
                    binaryWriter.Write(checked(offset - num1));
                else
                    binaryWriter.Write(Convert.ToInt32(0));
                binaryWriter.Write(Convert.ToInt32(talkEntry.Text.Length));
                binaryWriter.Write(talkEntry.SoundLength);
                binaryWriter.Seek(offset, SeekOrigin.Begin);
                binaryWriter.Write(talkEntry.Text.ToCharArray());

                offset += talkEntry.Text.Length;

                ++index;
                
            }

            binaryWriter.Close();
        }
    }
}