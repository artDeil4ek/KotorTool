using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Services;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public partial class ClsGff : IGff
    {
        public override string ToString()
        {
            return _gStringbuilder.ToString();
        }

        public int KotorVersIndex()
        {
            // if (VerifyNodeExists("KTGameVerIndex")) return IntegerType.FromObject(GetNodeValue("KTGameVerIndex"));
            return -1;
        }

        public string GetFieldTypeStr(int type)
        {
            switch (type)
            {
                case 0:
                    return "byte";
                case 1:
                    return "char";
                case 2:
                    return "word";
                case 3:
                    return "short";
                case 4:
                    return "dword";
                case 5:
                    return "int";
                case 6:
                    return "dword64";
                case 7:
                    return "int64";
                case 8:
                    return "float";
                case 9:
                    return "double";
                case 10:
                    return "CExoString";
                case 11:
                    return "CResRef";
                case 12:
                    return "CExoLocString";
                case 13:
                    return "void";
                case 14:
                    return "Struct";
                case 15:
                    return "List";
                case 16:
                    return "GFF Type 16";
                case 17:
                    return "GFF Type 17";
                default:
                    return "Unknown type: " + type;
            }
        }

        public void Parse(FileStream fs)
        {
            byte[] numArray = new byte[checked((int) (fs.Length - 1L) + 1)];
            _gRdr = new BinaryReader(fs, Encoding.ASCII);
            byte[] bytes = _gRdr.ReadBytes(checked((int) fs.Length));
            _gRdr.Close();
            Parse(bytes);
        }

        public void Parse(byte[] bytes)
        {
            GffStructEntry structEntry = new GffStructEntry();
            _gMs = new MemoryStream(bytes);
            _gRdr = new BinaryReader(_gMs, Encoding.ASCII);
            _gMs.Seek(8L, SeekOrigin.Begin);
            _gStructOffset = _gRdr.ReadInt32();
            _gStructCount = _gRdr.ReadInt32();
            GStructArr = new object[_gStructCount];
            _gFieldOffset = _gRdr.ReadInt32();
            _gFieldCount = _gRdr.ReadInt32();
            _gLabelOffset = _gRdr.ReadInt32();
            _gLabelCount = _gRdr.ReadInt32();
            _gFieldDataOffset = _gRdr.ReadInt32();
            _gFieldDataCount = _gRdr.ReadInt32();
            _gFieldIndicesOffset = _gRdr.ReadInt32();
            _gFieldIndicesCount = _gRdr.ReadInt32();
            _gListIndicesOffset = _gRdr.ReadInt32();
            _gListIndicesCount = _gRdr.ReadInt32();
            _gMs.Seek(_gStructOffset, SeekOrigin.Begin);
            if (_gBRtfMode)
            {
                //   PrintMsg(
                //    "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fmodern\\fprq1\\fcharset0 Lucida Console;}{\\f1\\fnil\\fcharset0 Lucida Console;}}",
                //       false);
                //   PrintMsg(
                //       "{\\colortbl ;\\red0\\green0\\blue255;\\red0\\green120\\blue0;\\red255\\green0\\blue0;\\red255\\green0\\blue255;}",
                //      false);
                //   PrintMsg("\\viewkind4\\uc1\\pard\\f0\\fs16", false);
            }

            structEntry.Type = _gRdr.ReadInt32();
            structEntry.DataOrDataOffset = _gRdr.ReadInt32();
            structEntry.FieldCount = _gRdr.ReadInt32();
            //  _rootGffStruct = GffReadStruct(ref structEntry);
            LateBinding.LateIndexSet(GStructArr, new object[2]
            {
                0,
                _rootGffStruct
            }, null);
            SortStructNames();
            if (!_gBRtfMode)
                return;
            // PrintMsg("\\f1\\fs17\\par", false);
        }

        public ArrayList SortStructNames()
        {
            ArrayList arrayList = new ArrayList();
            int num1 = 0;
            int num2 =
                checked(((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {0}, null)).Fields.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                arrayList.Add(((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1]
                {
                    0
                }, null)).Fields[index].Label);
                checked
                {
                    ++index;
                }
            }

            arrayList.Sort();
            return arrayList;
        }

        public GffStruct GffReadStruct(ref GffStructEntry structEntry)
        {
            GffFieldEntry fieldEntry = new GffFieldEntry();
            GffStruct gffStruct = new GffStruct();
            gffStruct.Fields = new GffField[checked(structEntry.FieldCount - 1 + 1)];
            gffStruct.FieldCount = structEntry.FieldCount;
            gffStruct.Type = structEntry.Type;
            gffStruct.DataOrDataOffset = structEntry.DataOrDataOffset;
            if (_gBRtfMode) PrintMsg("\\cf1 Struct\\cf0 - \\cf2 Type:\\cf0 " + StringType.FromInteger(structEntry.Type) + " \\cf2  Field count:\\cf0  " + StringType.FromInteger(structEntry.FieldCount) + "\n" + "\\par", true);
            else PrintMsg("Struct - Type: " + StringType.FromInteger(structEntry.Type) + "  Field count:  " + StringType.FromInteger(structEntry.FieldCount) + "\n", true);
            _gTabLevel = _gTabLevel + 1;
            if (structEntry.FieldCount == 1)
            {
                _gMs.Seek(_gFieldOffset + structEntry.DataOrDataOffset * 12, SeekOrigin.Begin);
                fieldEntry.Type = (GffFieldTypes) _gRdr.ReadInt32();
                fieldEntry.LabelIndex = _gRdr.ReadInt32();
                gffStruct.Fields[0] = (GffField) GffReadField(fieldEntry);
            }
            else
            {
                int num1 = 0;
                int num2 = checked(structEntry.FieldCount - 1);
                int index = num1;
                while (index <= num2)
                {
                    _gMs.Seek(_gFieldIndicesOffset + structEntry.DataOrDataOffset + index * 4,
                        SeekOrigin.Begin);
                    _gMs.Seek(_gFieldOffset + _gRdr.ReadInt32() * 12, SeekOrigin.Begin);
                    fieldEntry.Type = (GffFieldTypes) _gRdr.ReadInt32();
                    fieldEntry.LabelIndex = _gRdr.ReadInt32();
                    gffStruct.Fields[index] = (GffField) GffReadField(fieldEntry);
                    ++index;
                }
            }

            _gTabLevel = checked(_gTabLevel - 1);
            PrintMsg(_gBRtfMode ? "\\cf1 End of struct\\cf0\n\\par" : " End of struct\n", true);
            return gffStruct;
        }

        public object GffReadField(GffFieldEntry fieldEntry)
        {
            StringBuilder stringBuilder = new StringBuilder();
            GffField field = new GffField();
            long position = _gRdr.BaseStream.Position;
            _gMs.Seek(_gLabelOffset + fieldEntry.LabelIndex * 16, SeekOrigin.Begin);
            stringBuilder.Length = 0;
            stringBuilder.Append(_gRdr.ReadChars(16));
            int index1 = 0;
            while (Strings.Asc(stringBuilder[index1]) != 0)
            {
                ++index1;
                if (index1 > 15)
                    break;
            }

            stringBuilder.Length = index1;
            field.Label = stringBuilder.ToString();
            if (_gBRtfMode)
                PrintMsg("\\cf2 Label:\\cf0  " + field.Label.PadRight(16), true);
            else
                PrintMsg("Label:  " + field.Label.PadRight(16), true);
            _gMs.Seek(position, SeekOrigin.Begin);
            if (fieldEntry.Type == GffFieldTypes.GffDword64 || fieldEntry.Type == GffFieldTypes.GffInt64 ||
                fieldEntry.Type >= GffFieldTypes.GffDouble)
            {
                fieldEntry.DataOrDataOffset = _gRdr.ReadInt32();
                _gMs.Seek(LongType.FromObject(ObjectType.AddObj(_gFieldDataOffset, fieldEntry.DataOrDataOffset)),
                    SeekOrigin.Begin);
            }

            field.Type = fieldEntry.Type;
            switch (fieldEntry.Type)
            {
                case GffFieldTypes.GffByte:
                    field.Value = _gRdr.ReadByte();
                    break;
                case GffFieldTypes.GffChar:
                    field.Value = _gRdr.ReadChar();
                    break;
                case GffFieldTypes.GffWord:
                    field.Value = _gRdr.ReadUInt16();
                    break;
                case GffFieldTypes.GffShort:
                    field.Value = _gRdr.ReadInt16();
                    break;
                case GffFieldTypes.GffDword:
                    field.Value = _gRdr.ReadUInt32();
                    break;
                case GffFieldTypes.GffInt:
                    field.Value = _gRdr.ReadInt32();
                    break;
                case GffFieldTypes.GffDword64:
                    field.Value = _gRdr.ReadUInt64();
                    break;
                case GffFieldTypes.GffInt64:
                    field.Value = _gRdr.ReadInt64();
                    break;
                case GffFieldTypes.GffFloat:
                    field.Value = _gRdr.ReadSingle();
                    break;
                case GffFieldTypes.GffDouble:
                    field.Value = _gRdr.ReadDouble();
                    break;
                case GffFieldTypes.GffCExoString:
                    int count = _gRdr.ReadInt32();
                    byte[] numArray1 = new byte[count - 1 + 1];
                    Encoding encoding1 = Encoding.GetEncoding(1252);
                    byte[] bytes1 = _gRdr.ReadBytes(count);
                    field.Value = encoding1.GetString(bytes1);
                    break;
                case GffFieldTypes.GffCResRef:
                    field.Value = _gRdr.ReadString();
                    break;
                case GffFieldTypes.GffCExoLocString:
                    GffExoLocString gffExoLocString = new GffExoLocString();
                    gffExoLocString.Size = _gRdr.ReadInt32();
                    gffExoLocString.StringRef = _gRdr.ReadInt32();
                    gffExoLocString.StringCount = _gRdr.ReadInt32();
                    gffExoLocString.SubStringArr = new Object[gffExoLocString.StringCount];
                    _gTabLevel = _gTabLevel + 1;
                    if (_gBRtfMode)
                    {
                        PrintMsg("\\par", false);
                        PrintMsg("\\cf4CExoLocString\\cf0 - \\cf2 Substring count:\\cf0  " + StringType.FromInteger(gffExoLocString.StringCount) + "\n" + "\\par", true);
                    }
                    else
                    {
                        PrintMsg("\n", false);
                        PrintMsg("CExoLocString - Substring count:" + StringType.FromInteger(gffExoLocString.StringCount) + "\n", true);
                    }

                    _gTabLevel = checked(_gTabLevel + 1);
                    if (gffExoLocString.StringCount > 0)
                    {
                        int num1 = 0;
                        int num2 = gffExoLocString.StringCount - 1;
                        int index2 = num1;
                        while (index2 <= num2)
                        {
                            GffExoLocSubString gffExoLocSubString = new GffExoLocSubString();
                            gffExoLocSubString.StringId = _gRdr.ReadInt32();
                            gffExoLocSubString.StringLength = _gRdr.ReadInt32();
                            byte[] numArray2 = new byte[gffExoLocSubString.StringLength - 1 + 1];
                            Encoding encoding2 = Encoding.GetEncoding(1252);
                            byte[] bytes2 = _gRdr.ReadBytes(gffExoLocSubString.StringLength);
                            gffExoLocSubString.Value = encoding2.GetString(bytes2);
                            gffExoLocString.SubStringArr[index2] = gffExoLocSubString;
                            if (_gBRtfMode) PrintMsg("\\cf3Substring:\\cf0  " + StringType.FromInteger(index2) + "  \\cf2 ID:\\cf0  " + StringType.FromInteger(gffExoLocSubString.StringId) + " \\cf2 Value:\\cf0  " + gffExoLocSubString.Value + "\n" + "\\par", true);
                            else PrintMsg("Substring: " + StringType.FromInteger(index2) + " ID: " + StringType.FromInteger(gffExoLocSubString.StringId) + "  Value: " + gffExoLocSubString.Value, true);
                            ++index2;
                        }
                    }

                    _gTabLevel = _gTabLevel - 1;
                    if (_gBRtfMode) PrintMsg("\\cf4End of CExoLocString\\cf0 - ", true);
                    else PrintMsg(" End of CExoLocString - ", true);
                    _gTabLevel = _gTabLevel - 1;
                    field.Value = gffExoLocString;
                    break;
                case GffFieldTypes.GffVoid:
                    GffVoid gffVoid = new GffVoid();
                    gffVoid.Size = _gRdr.ReadInt32();
                    gffVoid.Bytes = _gRdr.ReadBytes(gffVoid.Size);
                    field.Value = gffVoid;
                    break;
                case GffFieldTypes.GffStruct:
                    if (LateBinding.LateIndexGet(GStructArr, new[] {RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset)}, null) == null)
                    {
                        _gMs.Seek(LongType.FromObject(ObjectType.AddObj(_gStructOffset, ObjectType.MulObj(fieldEntry.DataOrDataOffset, 12))), SeekOrigin.Begin);
                        GffStructEntry myStructEntry = new GffStructEntry {Type = _gRdr.ReadInt32(), DataOrDataOffset = _gRdr.ReadInt32(), FieldCount = _gRdr.ReadInt32()};
                        LateBinding.LateIndexSet(GStructArr, new[] {RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset), GffReadStruct(ref myStructEntry)}, null);
                    }

                    field.Value = RuntimeHelpers.GetObjectValue(fieldEntry.DataOrDataOffset);
                    break;
                case GffFieldTypes.GffList:
                    _gMs.Seek(LongType.FromObject(ObjectType.AddObj(_gListIndicesOffset, fieldEntry.DataOrDataOffset)), SeekOrigin.Begin);
                    GffList gffList = new GffList(_gRdr.ReadInt32());
                    if (_gBRtfMode)
                    {
                        PrintMsg("\n\\par", false);
                        PrintMsg("\\cf4List Contents\\cf0 - \\cf2 Struct Count:\\cf0  " + StringType.FromInteger(gffList.StructIndices.Count) + "\n" + "\\par", true);
                    }
                    else PrintMsg("List Contents - Struct Count: " + StringType.FromInteger(gffList.StructIndices.Count) + "\n", true);

                    _gTabLevel = _gTabLevel + 1;
                    if (gffList.StructIndices.Count > 0)
                    {
                        FlowUtils.BasicIterator(gffList.StructIndices.Count - 1, 0, i => { gffList.StructIndices[i] = _gRdr.ReadInt32(); });

                        FlowUtils.BasicIterator(gffList.StructIndices.Count - 1, 0, i =>
                        {
                            if (LateBinding.LateIndexGet(GStructArr, new[] {RuntimeHelpers.GetObjectValue(gffList.StructIndices[i])}, null) == null)
                            {
                                _gMs.Seek(0L, SeekOrigin.Begin);
                                _gMs.Seek(LongType.FromObject(ObjectType.AddObj(_gStructOffset, ObjectType.MulObj(gffList.StructIndices[i], 12))), SeekOrigin.Begin);
                                GffStructEntry myStructEntry = new GffStructEntry {Type = _gRdr.ReadInt32(), DataOrDataOffset = _gRdr.ReadInt32(), FieldCount = _gRdr.ReadInt32()};
                                LateBinding.LateIndexSet(GStructArr, new object[2] {RuntimeHelpers.GetObjectValue(gffList.StructIndices[i]), GffReadStruct(ref myStructEntry)}, null);
                            }
                        });
                    }

                    _gTabLevel = checked(_gTabLevel - 1);
                    if (_gBRtfMode)
                        PrintMsg("\\cf4End of List Contents\\cf0 - ", true);
                    else
                        PrintMsg("End of List Contents - ", true);
                    field.Value = gffList;
                    _gGffListArr.Add(gffList);
                    break;
                case GffFieldTypes.GffType16:
                    GffType16 gffType16 = new GffType16();
                    gffType16.F1 = _gRdr.ReadSingle();
                    gffType16.F2 = _gRdr.ReadSingle();
                    gffType16.F3 = _gRdr.ReadSingle();
                    gffType16.F4 = _gRdr.ReadSingle();
                    if (_gBRtfMode)
                        PrintMsg("\\cf4 GFF Type16\\cf0 - \n\\par", true);
                    else
                        PrintMsg(" GFF Type16 - \n", true);
                    _gTabLevel = checked(_gTabLevel + 1);
                    PrintMsg(
                        "f1: " + StringType.FromSingle(gffType16.F1) + "  f2: " + StringType.FromSingle(gffType16.F2) + "  f3: " + StringType.FromSingle(gffType16.F3) + "  f4: " + StringType.FromSingle(gffType16.F4), true);
                    if (_gBRtfMode) PrintMsg("\\par", true);
                    else PrintMsg("\n", true);
                    _gTabLevel = checked(_gTabLevel - 1);
                    if (_gBRtfMode) PrintMsg("\\cf4 End of GFF Type16\\cf0 - ", true);
                    else PrintMsg(" End of GFF Type16 - ", true);
                    field.Value = gffType16;
                    break;
                case GffFieldTypes.GffType17:
                    GffType17 gffType17 = new GffType17();
                    gffType17.F1 = _gRdr.ReadSingle();
                    gffType17.F2 = _gRdr.ReadSingle();
                    gffType17.F3 = _gRdr.ReadSingle();
                    if (_gBRtfMode) PrintMsg("\\cf4 GFF Type17\\cf0 - \n\\par", true);
                    else PrintMsg(" GFF Type17 - \n", true);
                    _gTabLevel = checked(_gTabLevel + 1);
                    PrintMsg("f1: " + StringType.FromSingle(gffType17.F1) + "  f2: " + StringType.FromSingle(gffType17.F2) + "  f3: " + StringType.FromSingle(gffType17.F3), true);
                    if (_gBRtfMode) PrintMsg("\\par", true);
                    else PrintMsg("\n", true);
                    _gTabLevel = checked(_gTabLevel - 1);
                    if (_gBRtfMode) PrintMsg("\\cf4 End of GFF Type17\\cf0 - ", true);
                    else PrintMsg(" End of GFF Type17 - ", true);
                    field.Value = gffType17;
                    break;
                default:
                    Console.WriteLine(
                        "Unknown Field type during read: " + StringType.FromInteger((int) fieldEntry.Type));
                    break;
            }

            if (_gBRtfMode)
                PrintMsg("\\cf3Field\\cf0 - \\cf2 Type:\\cf0  " + GetFieldTypeStr((int) fieldEntry.Type).PadRight(14),
                    true);
            else
                PrintMsg("Field -  Type:  " + GetFieldTypeStr((int) fieldEntry.Type).PadRight(14), true);
            // PrintViewableFieldValue(field);
            return field;
        }

/*
        private void PrintViewableFieldValue(GffFieldTypes field)
        {
            switch (field.Type)
            {
                case GffFieldTypes.GffByte:
                case GffFieldTypes.GffWord:
                case GffFieldTypes.GffShort:
                case GffFieldTypes.GffDword:
                case GffFieldTypes.GffInt:
                case GffFieldTypes.GffDword64:
                case GffFieldTypes.GffInt64:
                case GffFieldTypes.GffFloat:
                case GffFieldTypes.GffDouble:
                case GffFieldTypes.GffCExoLocString:
                case GffFieldTypes.GffCResRef:
                    if (_gBRtfMode)
                        PrintMsg("\\cf2 Value:\\cf0  ", false);
                    else
                        PrintMsg("Value:  ", false);
                    if (field.Value != null)
                    {
                        if (_gBRtfMode)
                        {
                            PrintMsg(field.Value + "\n" + "\\par", false);
                            break;
                        }

                        PrintMsg(field.Value + "\n", false);
                        break;
                    }

                    if (_gBRtfMode)
                    {
                        PrintMsg("(Nothing)\n\\par", false);
                        break;
                    }

                    PrintMsg("(Nothing)\n", false);
                    break;
                case GffFieldTypes.GffChar:
                    char ch = CharType.FromObject(field.Value);
                    string str1 = "";
                    string str2 = !_gBRtfMode ? str1 + "Value:  " : str1 + "\\cf2Value:\\cf0  ";
                    PrintMsg(
                        (!char.IsLetterOrDigit(ch)
                            ? str2 + "chr(" + StringType.FromInteger(Strings.Asc(ch)) + ")"
                            : str2 + ch) + "\n", false);
                    if (!_gBRtfMode)
                        break;
                    PrintMsg("\\par", false);
                    break;
                case GffFieldTypes.GffCExoLocString:
                    string str3 = "";
                    if (((GffExoLocString) field.Value).StringRef != -1)
                        str3 = _dialogTlk == null
                            ? "No DialogTlk"
                            : _dialogTlk.GetString(((GffExoLocString) field.Value).StringRef);
                    if (_gBRtfMode)
                    {
                        PrintMsg("\\cf2Value:\\cf0  " + str3 + "\n" + "\\par", false);
                        break;
                    }

                    PrintMsg("Value:  " + str3 + "\n", false);
                    break;
                case GffFieldTypes.GffVoid:
                    PrintMsg(
                        StringType.FromObject(ObjectType.StrCatObj(
                            ObjectType.StrCatObj(
                                ObjectType.StrCatObj("(Data: Size = ",
                                    LateBinding.LateGet(
                                        LateBinding.LateGet(field.Value, null, "bytes", new object[0], null, null),
                                        null, "length", new object[0], null, null)), ")"), '\n')), false);
                    if (!_gBRtfMode)
                        break;
                    PrintMsg("\\par", false);
                    break;
                default:
                    PrintMsg("(Complex)\n", false);
                    if (!_gBRtfMode)
                        break;
                    PrintMsg("\\par", false);
                    break;
            }
        }
*/
        public object FindNode(GffStruct aNode)
        {
            if (aNode.Fields != null)
            {
                GffField[] fields = aNode.Fields;
                int index = 0;
                while (index < fields.Length)
                {
                    GffField GffField = fields[index];
                    if (StringType.StrCmp(GffField.Label, _nodeSearchPath[_nodeSearchLevel], false) == 0)
                    {
                        if (_nodeSearchLevel == checked(_nodeSearchPath.Length - 1)) return GffField;
                        _nodeSearchLevel = checked(_nodeSearchLevel + 1);
                        if (GffField.Type == GffFieldTypes.GffStruct) return FindNode((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {RuntimeHelpers.GetObjectValue(GffField.Value)}, null));
                        if (GffField.Type == GffFieldTypes.GffList)
                        {
                            if (_nodeSearchLevel == checked(_nodeSearchPath.Length - 1)) return GffField;
                            return FindNode(FindListElement((GffList) GffField.Value));
                        }
                    }

                    ++index;
                }
            }

            return null;
        }

        public GffStruct FindListElement(GffList list)
        {
            GffStruct gffStruct = (GffStruct) LateBinding.LateIndexGet(GStructArr,
                new object[1]
                {
                    RuntimeHelpers.GetObjectValue(
                        list.StructIndices[IntegerType.FromString(_nodeSearchPath[_nodeSearchLevel])])
                }, null);
            _nodeSearchLevel = checked(_nodeSearchLevel + 1);
            return gffStruct;
        }

        public object GetNodeValue(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            object objectValue = RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct));
            if (objectValue == null) return objectValue;
            return ((GffField) objectValue).Value;
        }

        public void SetNodeValue(string path, object value)
        {
            if (!VerifyNodeExists(path)) return;
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            GffField node = (GffField) FindNode(_rootGffStruct);
            if (node.Type != GffFieldTypes.GffList) node.Value = RuntimeHelpers.GetObjectValue(value);
            else ((GffList) node.Value).StructIndices[IntegerType.FromString(_nodeSearchPath[_nodeSearchPath.Length - 1])] = RuntimeHelpers.GetObjectValue(value);
        }

        public GffList GetListNode(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            object objectValue = RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct));
            if (objectValue == null)
                return new GffList(0);
            return (GffList) ((GffField) objectValue).Value;
        }

        public bool VerifyNodeExists(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            return RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct)) != null;
        }

        public void AddListElement(string pathToList, GffStruct @struct)
        {
            ArrayList structIndices = GetListNode(pathToList).StructIndices;
            int num1 = 0;
            int num2 = GStructArr.Length - 1;
            int num3 = num1;
            while (num3 <= num2)
            {
                if (LateBinding.LateIndexGet(GStructArr, new object[] {num3}, null) != null) ++num3;
                else break;
            }

            if (num3 < GStructArr.Length)
            {
                structIndices.Add(num3);
                LateBinding.LateIndexSet(GStructArr, new object[] {num3, @struct}, null);
            }
            else
            {
                Array instance = new GffStruct[checked(GStructArr.Length + 1)];
                Array.Copy(GStructArr, instance, GStructArr.Length);
                GStructArr = instance;
                structIndices.Add(checked(GStructArr.Length - 1));
                LateBinding.LateIndexSet(GStructArr, new object[] {GStructArr.Length - 1, @struct}, null);
            }
        }

        public void DeleteListElement(string pathToList, int index)
        {
            int num = IntegerType.FromObject(GetListNode(pathToList).StructIndices[index]);
            GetListNode(pathToList).StructIndices.RemoveAt(index);
            LateBinding.LateIndexSet(GStructArr, new object[2] {num, null}, null);
            FixGffListRefs();
        }

        public void ClearListElements(string pathToList)
        {
            GffList listNode = GetListNode(pathToList);
            ArrayList structIndices = listNode.StructIndices;
            if (structIndices.Count == 0)
                return;
            int index = structIndices.Count - 1;
            while (index >= 0)
            {
                int num = IntegerType.FromObject(structIndices[index]);
                structIndices.RemoveAt(index);
                ScanStructForLists((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[]
                {
                    num
                }, null));
                LateBinding.LateIndexSet(GStructArr, new object[2]
                {
                    num,
                    null
                }, null);
                FixGffListRefs();
                index += -1;
            }

            listNode.Size = 0;
        }

        public void ClearListElements(GffList list)
        {
            ArrayList structIndices = list.StructIndices;
            if (structIndices.Count == 0) return;
            int index = structIndices.Count - 1;
            while (index >= 0)
            {
                int num = IntegerType.FromObject(structIndices[index]);
                structIndices.RemoveAt(index);
                LateBinding.LateIndexSet(GStructArr, new object[2]
                {
                    num,
                    null
                }, null);
                FixGffListRefs();
                index += -1;
            }

            list.Size = 0;
        }

        public void FixGffListRefs(int removedStructIndex = -1)
        {
            int num1;
            if (removedStructIndex == -1)
            {
                int num2 = 0;
                int num3 = checked(GStructArr.Length - 1);
                num1 = num2;
                while (num1 <= num3)
                {
                    if (LateBinding.LateIndexGet(GStructArr, new object[1] {num1}, null) != null)
                        ++num1;
                    else
                        break;
                }
            }
            else
                num1 = removedStructIndex;

            if (num1 == GStructArr.Length)
                return;

            foreach (GffList gffList in _gGffListArr)
            {
                if (gffList != null)
                {
                    int index1 = checked(gffList.StructIndices.Count - 1);
                    while (index1 >= 0)
                    {
                        if (ObjectType.ObjTst(gffList.StructIndices[index1], num1, false) > 0)
                        {
                            ArrayList structIndices = gffList.StructIndices;
                            ArrayList arrayList = structIndices;
                            int index2 = index1;
                            int index3 = index2;
                            object obj = ObjectType.SubObj(structIndices[index2], 1);
                            arrayList[index3] = obj;
                        }


                        index1 += -1;
                    }
                }
            }


            CleanupStructArrayAfterDelete();
            int num4 = 0;
            int num5 = checked(GStructArr.Length - 1);
            int num6 = num4;
            while (num6 <= num5)
            {
                GffField[] fields = ((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {num6}, null))
                    .Fields;
                int index = 0;
                while (index < fields.Length)
                {
                    GffField GffFieldTypes1 = fields[index];
                    if (GffFieldTypes1.Type == GffFieldTypes.GffStruct &&
                        ObjectType.ObjTst(GffFieldTypes1.Value, num1, false) > 0)
                    {
                        GffField GffFieldTypes2 = GffFieldTypes1;
                        GffFieldTypes2.Value = ObjectType.SubObj(GffFieldTypes2.Value, 1);
                    }


                    ++index;
                }


                ++num6;
            }
        }

        private void CleanupStructArrayAfterDelete()
        {
            bool flag = false;
            int num1 = 0;
            int num2 = GStructArr.Length - 2;
            int num3 = num1;
            while (num3 <= num2)
            {
                if (LateBinding.LateIndexGet(GStructArr, new object[1] {num3}, null) == null || flag)
                {
                    LateBinding.LateIndexSet(GStructArr, new object[2]
                    {
                        num3,
                        RuntimeHelpers.GetObjectValue(LateBinding.LateIndexGet(GStructArr, new object[1]
                        {
                            num3 + 1
                        }, null))
                    }, null);
                    flag = true;
                }


                ++num3;
            }

            Array instance = new GffStruct[GStructArr.Length - 1];
            Array.Copy(GStructArr, instance, GStructArr.Length - 1);
            GStructArr = instance;
        }

        private void ScanStructForLists(GffStruct @struct)
        {
            GffField[] fields = @struct.Fields;
            int index1 = 0;
            while (index1 < fields.Length)
            {
                GffField gffFieldTypes = fields[index1];
                if (gffFieldTypes.Type == GffFieldTypes.GffStruct)
                    ScanStructForLists((GffStruct) gffFieldTypes.Value);
                else if (gffFieldTypes.Type == GffFieldTypes.GffList)
                {
                    int num1 = 0;
                    int num2 = ((GffList) gffFieldTypes.Value).StructIndices.Count - 1;
                    int index2 = num1;
                    while (index2 <= num2)
                    {
                        ScanStructForLists((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1]
                        {
                            RuntimeHelpers.GetObjectValue(((GffList) gffFieldTypes.Value).StructIndices[index2])
                        }, null));


                        ++index2;
                    }

                    ClearListElements((GffList) gffFieldTypes.Value);
                }


                ++index1;
            }
        }

        public int GetListItemCount(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            object listNode = GetListNode(path);
            if (listNode == null) return -1;
            return ((GffList) listNode).StructIndices.Count;
        }

        public int GetStructFieldCount(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            return IntegerType.FromObject(LateBinding.LateGet(
                LateBinding.LateIndexGet(GStructArr,
                    new object[1] {RuntimeHelpers.GetObjectValue(FindNode(_rootGffStruct))}, null), null, "fieldCount",
                new object[0], null, null));
        }

        public int GetStructFieldType(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            return FindListElement(GetListNode(path)).Type;
        }

        public GffStruct GetStruct(string path)
        {
            path = Strings.Replace(path, "(", ".");
            path = Strings.Replace(path, ")", "");
            _nodeSearchPath = Strings.Split(path, ".");
            _nodeSearchLevel = 0;
            return FindListElement(GetListNode(path));
        }

        public void AddFieldToStruct(string path, string label, int type, object value)
        {
            GffStruct gffStruct1 = StringType.StrCmp(path, "", false) != 0 ? GetStruct(path) : _rootGffStruct;
            gffStruct1.Fields =
                (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields,
                    new GffFieldTypes[checked(gffStruct1.FieldCount + 1)]);
            GffStruct gffStruct2 = gffStruct1;
            gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            gffStruct1.Fields[gffStruct1.FieldCount - 1] = new GffField
            {
                Label = label,
                Type = (GffFieldTypes) type,
                Value = RuntimeHelpers.GetObjectValue(value)
            };
        }

        public void AddKtInfoToGff()
        {
            if (!VerifyNodeExists("KTInfoVersion"))
                AddKtcesFieldToRootGffStruct("KTInfoVersion", Application.ProductVersion);
            else
                SetNodeValue("KTInfoVersion", Application.ProductVersion);
            if (!VerifyNodeExists("KTInfoDate"))
                AddKtcesFieldToRootGffStruct("KTInfoDate",
                    DateAndTime.Now.ToLongDateString() + " " + DateAndTime.Now.ToLongTimeString());
            else
                SetNodeValue("KTInfoDate",
                    DateAndTime.Now.ToLongDateString() + " " + DateAndTime.Now.ToLongTimeString());
            if (!VerifyNodeExists("KTGameVerIndex"))
                AddKtIntegerFieldToRootGffStruct("KTGameVerIndex", KotorVersionIndex);
            else
                SetNodeValue("KTGameVerIndex", KotorVersionIndex);
        }

        public void AddKtcesFieldToRootGffStruct(string label, string value)
        {
            _rootGffStruct.Fields =
                (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_rootGffStruct.Fields,
                    new GffFieldTypes[_rootGffStruct.FieldCount + 1]);
            GffStruct rootGffStruct = _rootGffStruct;
            rootGffStruct.FieldCount = rootGffStruct.FieldCount + 1;
            _rootGffStruct.Fields[_rootGffStruct.FieldCount - 1] = new GffField()
            {
                Label = label,
                Type = GffFieldTypes.GffCExoString,
                Value = value
            };
        }

        public void AddKtIntegerFieldToRootGffStruct(string label, int value)
        {
            _rootGffStruct.Fields =
                (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_rootGffStruct.Fields,
                    new GffFieldTypes[_rootGffStruct.FieldCount + 1]);
            GffStruct rootGffStruct = _rootGffStruct;
            rootGffStruct.FieldCount = rootGffStruct.FieldCount + 1;
            _rootGffStruct.Fields[_rootGffStruct.FieldCount - 1] = new GffField()
            {
                Label = label,
                Type = GffFieldTypes.GffInt,
                Value = value
            };
        }

        public void AddSimpleField(string label, GffFieldTypes fieldType, object value)
        {
            _rootGffStruct.Fields =
                (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_rootGffStruct.Fields,
                    new GffFieldTypes[_rootGffStruct.FieldCount + 1]);
            GffStruct rootGffStruct = _rootGffStruct;
            rootGffStruct.FieldCount = rootGffStruct.FieldCount + 1;
            _rootGffStruct.Fields[_rootGffStruct.FieldCount - 1] = new GffField()
            {
                Label = label,
                Type = fieldType,
                Value = RuntimeHelpers.GetObjectValue(value)
            };
        }

        public void CreateList(string path, string label)
        {
            int num;
            if (StringType.StrCmp(path, "", false) == 0)
            {
                num = 0;
            }
            else
            {
                path = Strings.Replace(path, "(", ".");
                path = Strings.Replace(path, ")", "");
                string[] strArray = Strings.Split(path, ".");
                _nodeSearchPath = Strings.Split(path, ".");
                _nodeSearchPath = (string[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(_nodeSearchPath,
                    new string[checked(strArray.Length - 2 + 1)]);
                _nodeSearchLevel = 0;
                num = IntegerType.FromObject(
                    ((GffList) ((GffField) FindNode(_rootGffStruct)).Value).StructIndices[
                        IntegerType.FromString(strArray[checked(strArray.Length - 1)])]);
            }

            GffStruct gffStruct1 = (GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {num}, null);
            gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(
                gffStruct1.Fields,
                new GffFieldTypes[checked(gffStruct1.Fields.Length + 1)]);
            GffStruct gffStruct2 = gffStruct1;
            gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            GffList gffList = new GffList(0);
            gffStruct1.Fields[checked(gffStruct1.Fields.Length - 1)] =
                new GffField(GffFieldTypes.GffList, label, gffList);
            _gGffListArr.Add(gffList);
        }

        public void AddKtNode()
        {
            GffField gffField = new GffField(GffFieldTypes.GffCResRef, "KTInfoMaj", Application.ProductVersion);
            GffField[] fields = ((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {0}, null)).Fields;
            GffFieldTypes[] gffFieldTypesArray =
                (GffFieldTypes[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(fields,
                    new GffFieldTypes[fields.Length + 1]);
            //gffFieldTypesArray[gffFieldTypesArray.Length - 1] = gffField;
            // ((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1]
            //  {    0   }, null)).Fields = gffFieldTypesArray;
        }

        public void CreateEnglishCExoLocSubStringEntry(string path, string value)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(path);
            nodeValue.StringCount = 1;
            nodeValue.StringRef = -1;
            nodeValue.SubStringArr = new object[1];
            nodeValue.SubStringArr[0] = new GffExoLocSubString
            {
                StringId = 0,
                StringLength = value.Length,
                Value = value
            };
            nodeValue.Size = checked(16 + value.Length);
        }

        public void SetEnglishCExoLocSubStringEntry(string path, string value)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(path);
            nodeValue.SubStringArr[0] = new GffExoLocSubString
            {
                StringId = 0,
                StringLength = value.Length,
                Value = value
            };
            nodeValue.Size = checked(16 + value.Length);
        }

        public void CreateCExoLocSubStringEntry(string path, string value, int languageId = 0)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(path);
            nodeValue.StringCount = 1;
            nodeValue.StringRef = -1;
            nodeValue.SubStringArr = new object[1];
            nodeValue.SubStringArr[0] = new GffExoLocSubString
            {
                StringId = languageId,
                StringLength = value.Length,
                Value = value
            };
            nodeValue.Size = checked(16 + value.Length);
        }

        public void SetCExoLocSubStringEntry(string path, string value, int languageId = 0)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(path);
            nodeValue.SubStringArr[0] = new GffExoLocSubString
            {
                StringId = languageId,
                StringLength = value.Length,
                Value = value
            };
            nodeValue.Size = checked(16 + value.Length);
        }

        public void CreateRootStruct()
        {
            GStructArr = new object[1];
            _rootGffStruct.Fields = new GffField[0];
            LateBinding.LateIndexSet(GStructArr, new object[2]
            {
                0,
                _rootGffStruct
            }, null);
        }

        public void WriteFile(string path, string filetype)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            BinaryWriter binaryWriter1 = new BinaryWriter(fileStream);
            Hashtable hashtable = new Hashtable();
            int num1 = 0;
            AddKtInfoToGff();
            int num2 = checked(GStructArr.Length * 12);
            binaryWriter1.Write((Strings.UCase(Strings.Trim(filetype)) + " V3.2").ToCharArray());
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = GStructArr.Length - 1;
            int num7 = num5;
            while (num7 <= num6)
            {
                GffField[] fields = ((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {num7}, null))
                    .Fields;
                int index = 0;
                while (index < fields.Length)
                {
                    GffField GffFieldTypes = fields[index];
                    ++num3;
                    if (hashtable.ContainsKey(GffFieldTypes.Label))
                    {
                        GffFieldTypes.LabelIndex = IntegerType.FromObject(hashtable[GffFieldTypes.Label]);
                    }
                    else
                    {
                        hashtable.Add(GffFieldTypes.Label, num4);
                        GffFieldTypes.LabelIndex = num4;
                        ++num4;
                    }

                    ++index;
                }

                ++num7;
            }

            int num8 = checked(num3 * 12);
            int num9 = checked(hashtable.Count * 16);
            int num10 = 0;
            int num11 = 0;
            int num12 = checked(GStructArr.Length - 1);
            int num13 = num11;
            int num14 = 0;
            while (num13 <= num12)
            {
                GffField[] fields = ((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {num13}, null))
                    .Fields;
                int index = 0;
                while (index < fields.Length)
                {
                    GffField gffField = fields[index];
                    if (gffField.Type >= GffFieldTypes.GffDword64)
                    {
                        int num15 = 0;

                        ++num15;


                        switch (gffField.Type)
                        {
                            case GffFieldTypes.GffDword64:
                            case GffFieldTypes.GffInt64:
                            case GffFieldTypes.GffDouble:
                                num10 += 8;
                                break;
                            case GffFieldTypes.GffFloat:
                                num10 += 4;
                                break;
                            case GffFieldTypes.GffCExoString:

                                num10 += 4 + StringType.FromObject(gffField.Value).Length;
                                break;
                            case GffFieldTypes.GffCResRef:
                                num10 += 1 + StringType.FromObject(gffField.Value).Length;
                                break;
                            case GffFieldTypes.GffCExoLocString:
                                num10 += ((GffExoLocString) gffField.Value).Size + 4;
                                break;
                            case GffFieldTypes.GffVoid:
                                num10 += 4 + ((GffVoid) gffField.Value).Size;
                                break;
                            case GffFieldTypes.GffStruct:
                                break;
                            case GffFieldTypes.GffList:
                                num14 += ((GffList) gffField.Value).StructIndices.Count * 4 + 4;
                                break;
                            case GffFieldTypes.GffType16:
                                num10 += 16;
                                break;
                            case GffFieldTypes.GffType17:
                                num10 += 12;
                                break;
                            default:
                                Console.WriteLine("Unknown Field type: " +
                                                  StringType.FromInteger((int) gffField.Type));
                                break;
                        }
                    }

                    ++index;
                }

                ++num13;
            }

            int num16 = 0;
            int num17 = checked(GStructArr.Length - 1);
            int num18 = num16;
            int num19 = 0;
            while (num18 <= num17)
            {
                if (((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {num18}, null)).FieldCount > 1)

                    num19 += ((GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1]
                    {
                        num18
                    }, null)).FieldCount;


                ++num18;
            }

            int offset1 = 56;
            int num20 = checked(56 + num2);
            int offset2 = num20;
            int num21 = checked(num20 + num8);
            int offset3 = num21;
            int num22 = checked(num21 + num9);
            int offset4 = num22;
            int num23 = checked(num22 + num10);
            int offset5 = num23;
            int num24 = checked(num23 + num19 * 4);
            int offset6 = num24;
            binaryWriter1.Seek(8, SeekOrigin.Begin);
            binaryWriter1.Write(56);
            binaryWriter1.Write(GStructArr.Length);
            binaryWriter1.Write(num20);
            binaryWriter1.Write(checked((int) Math.Round(num8 / 12.0)));
            binaryWriter1.Write(num21);
            binaryWriter1.Write(checked((int) Math.Round(num9 / 16.0)));
            binaryWriter1.Write(num22);
            binaryWriter1.Write(num10);
            binaryWriter1.Write(num23);
            binaryWriter1.Write(checked(num19 * 4));
            binaryWriter1.Write(num24);
            binaryWriter1.Write(num14);
            int num25 = 0;
            int num26 = checked(GStructArr.Length - 1);
            int num27 = num25;
            while (num27 <= num26)
            {
                GffStruct gffStruct = (GffStruct) LateBinding.LateIndexGet(GStructArr, new object[1] {num27}, null);
                gffStruct.DataOrDataOffset = gffStruct.FieldCount != 1 ? checked(offset5 - num23) : num1;
                binaryWriter1.Seek(offset1, SeekOrigin.Begin);
                binaryWriter1.Write(gffStruct.Type);
                binaryWriter1.Write(gffStruct.DataOrDataOffset);
                binaryWriter1.Write(gffStruct.FieldCount);
                offset1 = checked((int) fileStream.Position);
                GffField[] fields = gffStruct.Fields;
                int index1 = 0;
                while (index1 < fields.Length)
                {
                    GffField gffField = fields[index1];
                    if (gffStruct.FieldCount > 1)
                    {
                        binaryWriter1.Seek(offset5, SeekOrigin.Begin);
                        binaryWriter1.Write(num1);
                        offset5 = checked((int) fileStream.Position);
                    }

                    switch (gffField.Type)
                    {
                        case GffFieldTypes.GffByte:
                        case GffFieldTypes.GffChar:
                        case GffFieldTypes.GffWord:
                        case GffFieldTypes.GffShort:
                        case GffFieldTypes.GffDword:
                        case GffFieldTypes.GffInt:
                        case GffFieldTypes.GffFloat:
                        case GffFieldTypes.GffStruct:
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            if (gffField.Type < GffFieldTypes.GffInt)
                                binaryWriter1.Write(
                                    Convert.ToUInt32(RuntimeHelpers.GetObjectValue(gffField.Value)));
                            else if (gffField.Type == GffFieldTypes.GffInt)
                                binaryWriter1.Write(
                                    Convert.ToInt32(RuntimeHelpers.GetObjectValue(gffField.Value)));
                            else if (gffField.Type == GffFieldTypes.GffFloat)
                            {
                                binaryWriter1.Write(
                                    Convert.ToSingle(RuntimeHelpers.GetObjectValue(gffField.Value)));
                            }
                            else
                            {
                                BinaryWriter binaryWriter2 = binaryWriter1;
                                // ISSUE: variable of the null type
                                Type local1 = null;
                                string name = "Write";
                                object[] objArray1 = new object[1];
                                object[] objArray2 = objArray1;
                                int index2 = 0;
                                GffField gffField2 = gffField;
                                object objectValue = RuntimeHelpers.GetObjectValue(gffField2.Value);
                                objArray2[index2] = objectValue;
                                object[] objArray3 = objArray1;
                                object[] args = objArray3;
                                // ISSUE: variable of the null type
                                String[] local2 = null;
                                bool[] flagArray = new bool[1] {true};
                                bool[] copyBack = flagArray;
                                LateBinding.LateCall(binaryWriter2, local1, name, args, local2, copyBack);
                                if (flagArray[0]) gffField2.Value = RuntimeHelpers.GetObjectValue(objArray3[0]);
                            }

                            offset2 = (int) fileStream.Position;
                            ++num1;


                            break;
                        case GffFieldTypes.GffDword64:
                        case GffFieldTypes.GffInt64:
                        case GffFieldTypes.GffDouble:
                        case GffFieldTypes.GffCResRef:
                            gffField.DataOffset = checked(offset4 - num22);
                            binaryWriter1.Seek(offset4, SeekOrigin.Begin);
                            BinaryWriter binaryWriter3 = binaryWriter1;
                            // ISSUE: variable of the null type
                            Type local3 = null;
                            string name1 = "Write";
                            object[] objArray4 = new object[1];
                            object[] objArray5 = objArray4;
                            int index3 = 0;
                            GffField gffField3 = gffField;
                            object objectValue1 = RuntimeHelpers.GetObjectValue(gffField3.Value);
                            objArray5[index3] = objectValue1;
                            object[] objArray6 = objArray4;
                            object[] args1 = objArray6;
                            // ISSUE: variable of the null type
                            String[] local4 = null;
                            bool[] flagArray1 = new bool[1] {true};
                            bool[] copyBack1 = flagArray1;
                            LateBinding.LateCall(binaryWriter3, local3, name1, args1, local4, copyBack1);
                            if (flagArray1[0])
                                gffField3.Value = RuntimeHelpers.GetObjectValue(objArray6[0]);
                            offset4 = checked((int) fileStream.Position);
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = checked((int) fileStream.Position);
                            ++num1;
                            break;
                        case GffFieldTypes.GffCExoString:
                            gffField.DataOffset = checked(offset4 - num22);
                            binaryWriter1.Seek(offset4, SeekOrigin.Begin);
                            binaryWriter1.Write(StringType.FromObject(gffField.Value).Length);
                            Encoding encoding = Encoding.GetEncoding(1252);
                            // ISSUE: variable of the null type
                            Type local5 = null;
                            string name2 = "GetBytes";
                            object[] objArray7 = new object[1];
                            object[] objArray8 = objArray7;
                            int index4 = 0;
                            GffField gffField4 = gffField;
                            object objectValue2 = RuntimeHelpers.GetObjectValue(gffField4.Value);
                            objArray8[index4] = objectValue2;
                            object[] objArray9 = objArray7;
                            object[] args2 = objArray9;
                            // ISSUE: variable of the null type
                            String[] local6 = null;
                            bool[] flagArray2 = new bool[1] {true};
                            bool[] copyBack2 = flagArray2;
                            object obj = LateBinding.LateGet(encoding, local5, name2, args2, local6, copyBack2);
                            if (flagArray2[0])
                                gffField4.Value = RuntimeHelpers.GetObjectValue(objArray9[0]);
                            byte[] buffer = (byte[]) obj;
                            binaryWriter1.Write(buffer);
                            offset4 = checked((int) fileStream.Position);
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = checked((int) fileStream.Position);
                            ++num1;
                            break;
                        case GffFieldTypes.GffCExoLocString:
                            gffField.DataOffset = checked(offset4 - num22);
                            binaryWriter1.Seek(offset4, SeekOrigin.Begin);
                            GffExoLocString gffExoLocString = (GffExoLocString) gffField.Value;
                            binaryWriter1.Write(gffExoLocString.Size);
                            binaryWriter1.Write(gffExoLocString.StringRef);
                            binaryWriter1.Write(gffExoLocString.StringCount);
                            object[] subStringArr = gffExoLocString.SubStringArr;
                            int index5 = 0;
                            while (index5 < subStringArr.Length)
                            {
                                GffExoLocSubString gffExoLocSubString = (GffExoLocSubString) subStringArr[index5];
                                binaryWriter1.Write(gffExoLocSubString.StringId);
                                binaryWriter1.Write(gffExoLocSubString.StringLength);
                                byte[] bytes = Encoding.GetEncoding(1252).GetBytes(gffExoLocSubString.Value);
                                binaryWriter1.Write(bytes);

                                ++index5;
                            }

                            offset4 = checked((int) fileStream.Position);
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = checked((int) fileStream.Position);
                            ++num1;
                            break;
                        case GffFieldTypes.GffVoid:
                            gffField.DataOffset = checked(offset4 - num22);
                            binaryWriter1.Seek(offset4, SeekOrigin.Begin);
                            binaryWriter1.Write(((GffVoid) gffField.Value).Size);
                            binaryWriter1.Write(((GffVoid) gffField.Value).Bytes);
                            offset4 = checked((int) fileStream.Position);
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = checked((int) fileStream.Position);
                            ++num1;
                            break;
                        case GffFieldTypes.GffList:
                            gffField.DataOffset = checked(offset6 - num24);
                            binaryWriter1.Seek(offset6, SeekOrigin.Begin);
                            binaryWriter1.Write(((GffList) gffField.Value).StructIndices.Count);

                            foreach (object structIndex in ((GffList) gffField.Value).StructIndices)
                            {
                                int num15 = IntegerType.FromObject(structIndex);
                                binaryWriter1.Write(num15);
                            }


                            offset6 = (int) fileStream.Position;
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = (int) fileStream.Position;

                            ++num1;


                            break;
                        case GffFieldTypes.GffType16:
                            gffField.DataOffset = offset4 - num22;
                            binaryWriter1.Seek(offset4, SeekOrigin.Begin);
                            binaryWriter1.Write(((GffType16) gffField.Value).F1);
                            binaryWriter1.Write(((GffType16) gffField.Value).F2);
                            binaryWriter1.Write(((GffType16) gffField.Value).F3);
                            binaryWriter1.Write(((GffType16) gffField.Value).F4);
                            offset4 = (int) fileStream.Position;
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = (int) fileStream.Position;

                            ++num1;


                            break;
                        case GffFieldTypes.GffType17:
                            gffField.DataOffset = offset4 - num22;
                            binaryWriter1.Seek(offset4, SeekOrigin.Begin);
                            binaryWriter1.Write(((GffType17) gffField.Value).F1);
                            binaryWriter1.Write(((GffType17) gffField.Value).F2);
                            binaryWriter1.Write(((GffType17) gffField.Value).F3);
                            offset4 = (int) fileStream.Position;
                            binaryWriter1.Seek(offset2, SeekOrigin.Begin);
                            binaryWriter1.Write((int) gffField.Type);
                            binaryWriter1.Write(gffField.LabelIndex);
                            binaryWriter1.Write(gffField.DataOffset);
                            offset2 = (int) fileStream.Position;
                            ++num1;
                            break;
                    }

                    ++index1;
                }

                ++num27;
            }

            char[] chars = new char[16];
            binaryWriter1.Seek(offset3, SeekOrigin.Begin);
            int num28 = 0;
            int num29 = checked(hashtable.Count - 1);
            int num30 = num28;
            while (num30 <= num29)
            {
                string str = "";

                foreach (object key in hashtable.Keys)
                {
                    str = StringType.FromObject(key);
                    if (ObjectType.ObjTst(hashtable[str], num30, false) == 0)
                        break;
                }


                Array.Clear(chars, 0, 16);
                Array.Copy(str.ToCharArray(), chars, str.Length);
                binaryWriter1.Write(chars);

                ++num30;
            }

            binaryWriter1.Close();
        }

        public void SetTextBoxToNodeValue(TextBox tb, string nodePath)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(nodePath));
            if (objectValue == null)
                return;
            tb.Text = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue));
        }

        public string GetCExoLocStringNodeValue(string nodePath)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(nodePath);
            if (nodeValue == null)
                return "(GFF Path not found: " + nodePath + ")";
            if (nodeValue.StringRef != -1)
                return _dialogTlk.GetString(nodeValue.StringRef);
            if (nodeValue.StringCount > 0)
                return ((GffExoLocSubString) nodeValue.SubStringArr[0]).Value;
            string str = "";
            return str;
        }

        public void SetNumericUpDownToNodeValue(NumericUpDown nud, string nodePath, float scaleFactor = 0.0f)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(nodePath));
            if (objectValue != null)
                nud.Value = DecimalType.FromObject(objectValue);
            if (objectValue == null)
                return;
            if (scaleFactor == 0.0)
                nud.Value = DecimalType.FromObject(objectValue);
            else
                nud.Value = DecimalType.FromObject(ObjectType.MulObj(objectValue, scaleFactor));
        }

        public void SetNumericUpDownToUIntNodeValue(NumericUpDown nud, string nodePath, float scaleFactor = 0.0f)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(nodePath));
            if (objectValue == null)
                return;
            if (scaleFactor == 0.0)
                nud.Value = new Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)));
            else
                nud.Value = new Decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) * scaleFactor);
        }

        public void FillComboBoxFrom2Da(ComboBox cmbx, string colName, string twoDaName, ClsChitinKey chitinKey,
            ClsDialogTlk dialogTlk, string kotOrPath)
        {
            int resIdForResRef = chitinKey.FindResIdForResRef(twoDaName, 2017);
            Cls2Da cls2Da =
                new Cls2Da(GetBiffResource(kotOrPath + "\\" + chitinKey.BiffList[resIdForResRef >> 20].Filename,
                    resIdForResRef).Data);
            if (dialogTlk != null)
            {
                int num = 0;
                int rowsUpperBound = cls2Da.RowsUpperBound;
                int rowNumber = num;
                while (rowNumber <= rowsUpperBound)
                {
                    object indiceData = cls2Da.GetIndiceData(rowNumber, colName);
                    if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData)))
                        cmbx.Items.Add(dialogTlk.GetString(IntegerType.FromObject(indiceData)));
                    else
                        cmbx.Items.Add(RuntimeHelpers.GetObjectValue(indiceData));
                    checked
                    {
                        ++rowNumber;
                    }
                }
            }
            else
            {
                int num = 0;
                int rowsUpperBound = cls2Da.RowsUpperBound;
                int rowNumber = num;
                while (rowNumber <= rowsUpperBound)
                {
                    cmbx.Items.Add(cls2Da.GetIndiceData(rowNumber, colName));

                    ++rowNumber;
                }
            }
        }

        public bool SyncComboBox(ComboBox cmbx, string nodePath)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(GetNodeValue(nodePath));
            bool flag = true;
            if (objectValue != null)
            {
                if (Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue)) > checked(cmbx.Items.Count - 1))
                {
                    cmbx.BackColor = Color.Tomato;
                    cmbx.SelectedIndex = -1;
                    flag = false;
                }
                else
                {
                    cmbx.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(objectValue));
                }
            }

            return flag;
        }

        public void SetTextBoxFrom2Da(TextBox textBox, int rowNumber, string colName, string twoDaName,
            ClsChitinKey chitinKey, ClsDialogTlk dialogTlk, string kotOrPath)
        {
            int resIdForResRef = chitinKey.FindResIdForResRef(twoDaName, 2017);
            Cls2Da cls2Da =
                new Cls2Da(GetBiffResource(kotOrPath + "\\" + chitinKey.BiffList[resIdForResRef >> 20].Filename,
                    resIdForResRef).Data);
            if (dialogTlk != null)
            {
                object indiceData = cls2Da.GetIndiceData(rowNumber, colName);
                textBox.Text = !Information.IsNumeric(RuntimeHelpers.GetObjectValue(indiceData))
                    ? StringType.FromInteger(0)
                    : dialogTlk.GetString(IntegerType.FromObject(indiceData));
            }
            else
                textBox.Text = cls2Da.GetIndiceData(rowNumber, colName);
        }

        public void SetTextBoxFromCExoLocStringNodeValue(TextBox tb, string nodePath, ClsDialogTlk dialogTlk)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(nodePath);
            if (nodeValue == null)
                tb.Text = "(GFF Path not found: " + nodePath + ")";
            else if (nodeValue.StringRef != -1)
            {
                tb.Text = dialogTlk.GetString(nodeValue.StringRef);
            }
            else
            {
                if (nodeValue.StringCount <= 0)
                    return;
                tb.Text = ((GffExoLocSubString) nodeValue.SubStringArr[0]).Value;
            }
        }

        public void SetTextBoxFromCExoLocStringNodeValue(TextBox tb, string nodePath)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(nodePath);
            if (nodeValue.StringRef != -1)
            {
                tb.Text = _dialogTlk.GetString(nodeValue.StringRef);
            }
            else
            {
                if (nodeValue.StringCount <= 0)
                    return;
                tb.Text = ((GffExoLocSubString) nodeValue.SubStringArr[0]).Value;
            }
        }

        public object GetCExoLocStringLanguage(string nodePath)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(nodePath);
            if (nodeValue.StringRef != -1)
                return -1;
            if (nodeValue.StringCount > 0)
                return ((GffExoLocSubString) nodeValue.SubStringArr[0]).StringId;
            object obj = new object();
            return obj;
        }

        public void SetCExoLocStringNodeValueFromTextBox(TextBox tb, string nodePath, int languageId = 0)
        {
            GffExoLocString nodeValue = (GffExoLocString) GetNodeValue(nodePath);
            if (nodeValue.StringRef == -1)
            {
                if (nodeValue.StringCount == 0)
                    CreateCExoLocSubStringEntry(nodePath, tb.Text, languageId);
                else
                    SetCExoLocSubStringEntry(nodePath, tb.Text, languageId);
            }
            else
                CreateCExoLocSubStringEntry(nodePath, tb.Text, languageId);
        }

        public void SetNodeValueFromTextBox(TextBox tb, string nodePath)
        {
            SetNodeValue(nodePath, tb.Text);
        }

        public void SetUInt16NodeValueFromTextBox(TextBox tb, string nodePath)
        {
            SetNodeValue(nodePath, Convert.ToUInt16(tb.Text));
        }

        public void SetUInt32NodeValueFromTextBox(TextBox tb, string nodePath)
        {
            SetNodeValue(nodePath, Convert.ToUInt32(tb.Text));
        }

        public void SetNodeValueFromComboBox(ComboBox cmbx, string nodePath)
        {
            SetNodeValue(nodePath, cmbx.SelectedIndex);
        }

        public void SetNodeValueFromNumericUpDown(NumericUpDown nud, string nodePath, float scaleFactor = 0.0f)
        {
            if (scaleFactor == 0.0)
                SetNodeValue(nodePath, nud.Value);
            else
                SetNodeValue(nodePath, (float) (Convert.ToSingle(nud.Value) / (double) scaleFactor));
        }

        public void SetUInt16NodeValueFromNumericUpDown(NumericUpDown nud, string nodePath, float scaleFactor = 0.0f)
        {
            SetNodeValue(nodePath,
                scaleFactor == 0.0
                    ? Convert.ToUInt16(nud.Value)
                    : Convert.ToUInt16(Convert.ToSingle(nud.Value) / scaleFactor));
        }

        public void SetUInt32NodeValueFromNumericUpDown(NumericUpDown nud, string nodePath, float scaleFactor = 0.0f)
        {
            SetNodeValue(nodePath,
                scaleFactor == 0.0
                    ? Convert.ToUInt32(nud.Value)
                    : Convert.ToUInt32(Convert.ToSingle(nud.Value) / scaleFactor));
        }

        private BiffVarRsrcEntry GetBiffResource(string biffPath, int resourceId)
        {
            return new BiffArchive(
                    new FileStream(biffPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 200000))
                .GetBiffResource(resourceId);
        }

        private void PrintMsg(string msg, bool indented)
        {
            if (indented)
                _gStringbuilder.Append(Strings.Space(checked(_gTabLevel * 3)));
            _gStringbuilder.Append(msg);
        }
    }
}