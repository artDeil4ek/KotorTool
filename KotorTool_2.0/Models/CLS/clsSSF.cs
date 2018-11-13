using System.IO;
using System.Threading.Tasks;
using KotorTool_2._0.Options;
using KotorTool_2._0.Services;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsSsf : ISsf
    {
        private readonly int[] _mRefArray;
        private readonly ClsDialogTlk _gClsDialogTlk;

        public ClsSsf()
        {
            _mRefArray = new int[41];
        }

        public ClsSsf(int kotorVerIndex) : this()
        {
            _gClsDialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
        }

        public ClsSsf(ClsDialogTlk dialogTlk) : this()
        {
            _gClsDialogTlk = dialogTlk;
        }

        public ClsSsf(FileStream fs, int kotorVerIndex) : this(kotorVerIndex)
        {
            BinaryReader binaryReader = new BinaryReader(fs);
            binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
            int index = 0;
            do
            {
                _mRefArray[index] = binaryReader.ReadInt32();
                ++index;
            } while (index <= 39);

            binaryReader.Close();
        }

        public ClsSsf(FileStream fs, ClsDialogTlk dialogTlk) : this(dialogTlk)
        {
            BinaryReader binaryReader = new BinaryReader(fs);
            binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
            int index = 0;
            do
            {
                _mRefArray[index] = binaryReader.ReadInt32();
                ++index;
            } while (index <= 39);

            binaryReader.Close();
        }

        public ClsSsf(byte[] data, int kotorVerIndex) : this(kotorVerIndex)
        {
            BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
            binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
            int index = 0;
            do
            {
                _mRefArray[index] = binaryReader.ReadInt32();
                ++index;
            } while (index <= 39);
        }

        public ClsSsf(byte[] data, ClsDialogTlk dialogTlk) : this(dialogTlk)
        {
            BinaryReader binaryReader = new BinaryReader(new MemoryStream(data));
            binaryReader.BaseStream.Seek(12L, SeekOrigin.Begin);
            int index = 0;
            do
            {
                _mRefArray[index] = binaryReader.ReadInt32();
                ++index;
            } while (index <= 39);
        }

        public int GetRefArray(object index)
        {
            if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, false) >= 0, ObjectType.ObjTst(index, 39, false) <= 0))) return _mRefArray[IntegerType.FromObject(index)];
            return -999;
        }

        public void SetRefArray(object index, int value)
        {
            if (!BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, false) >= 0, ObjectType.ObjTst(index, 39, false) <= 0))) return;
            _mRefArray[IntegerType.FromObject(index)] = value;
        }

        public string GetRefArrayString(object index)
        {
            if (!BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(index, 0, false) >= 0, ObjectType.ObjTst(index, 39, false) <= 0))) return "Invalid clsSSF array index!";
            if (_mRefArray[IntegerType.FromObject(index)] != -1) return _gClsDialogTlk.GetString(_mRefArray[IntegerType.FromObject(index)]);
            return "";
        }

        public string GetRefArraySoundResRef(object index)
        {
            if (_mRefArray[IntegerType.FromObject(index)] != -1)
                return _gClsDialogTlk.GetSoundResRef(_mRefArray[IntegerType.FromObject(index)]);
            return "";
        }

        public async void WriteFile(string filepath)
        {
            await Task.Factory.StartNew(() =>
            {
                using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filepath, FileMode.Create)))
                {
                    binaryWriter.Write("SSF V1.1".ToCharArray());
                    binaryWriter.Write(12);
                    int index = 0;
                    do
                    {
                        binaryWriter.Write(_mRefArray[index]);
                        ++index;
                    } while (index <= 39);
                }
            });
        }
    }
}