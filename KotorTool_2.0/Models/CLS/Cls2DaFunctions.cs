using System;
using System.Runtime.CompilerServices;
using System.Text;
using KotorTool_2._0.Services;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public partial class Cls2Da : I2Da
    {
        public void CreateDataTable()
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            int num1 = 9;
            int num2 = checked(_ary2Da.Length - 1);
            int index1 = num1;
            while (index1 <= num2 && _ary2Da[index1] != 0)

                ++index1;


            int index2 = checked(index1 + 1);
            _numRows = checked((int) Math.Round(_ary2Da[index2]
                                                + _ary2Da[checked(index2 + 1)]
                                                * 256.0
                                                + _ary2Da[checked(index2 + 2)] * 65536.0
                                                + _ary2Da[checked(index2 + 3)] * 16777216.0));
            ColNames = Strings.Split(asciiEncoding.GetString(_ary2Da, 9, checked(index1 - 10)), "\t");
            _numColumns = ColNames.Length;
            _ary2DaStrings = new string[_numRows, checked(_numColumns + 1)];
            int num3 = 0;
            int num4 = checked(index2 + 4);
            int num5 = checked(_ary2Da.Length - 1);
            int index3 = num4;
            while (index3 <= num5)
            {
                if (_ary2Da[index3] == 9)
                {
                    ++num3;
                    if (num3 == _numRows) break;
                }
                ++index3;
            }

            int num6 = checked(index3 + 1);
            int num7 = num6;
            _rowLabels =
                Strings.Split(asciiEncoding.GetString(_ary2Da, checked(index2 + 4), checked(num6 - index2 - 5)), "\t");
            int num8 = checked(num6 + (_numRows * _numColumns + 1) * 2);
            int num9 = 0;
            int num10 = checked(_numRows - 1);
            int index4 = num9;
            while (index4 <= num10)
            {
                LateBinding.LateIndexSet(_ary2DaStrings, new object[3]
                {
                    index4,0,_rowLabels[index4]
                }, null);
                int num11 = 0;
                int num12 = checked(ColNames.Length - 1);
                int num13 = num11;
                while (num13 <= num12)
                {
                    int index5 = checked((num13 + index4 * _numColumns) * 2 + num7);
                    int byteIndex = checked(num8 + _ary2Da[index5] + 256 * _ary2Da[index5 + 1]);
                    int num14 = byteIndex;
                    int num15 = checked(_ary2Da.Length - 1);
                    int index6 = num14;
                    while (index6 <= num15 && _ary2Da[index6] != 0)
                        checked
                        {
                            ++index6;
                        }

                    string str = index6 <= byteIndex
                        ? "****"
                        : asciiEncoding.GetString(_ary2Da, byteIndex, checked(index6 - byteIndex));
                    LateBinding.LateIndexSet(_ary2DaStrings, new object[3]
                    {
                        index4,
                        checked(num13 + 1),
                        str
                    }, null);

                    ++num13;
                }


                ++index4;
            }
        }

        public Array GetRow(object rowNumber)
        {
            if (_ary2DaStrings == null)
            {
                Array array = null;
                return array;
            }

            string[] strArray = new string[checked(_numColumns + 1)];
            int num1 = 0;
            int num2 = checked(_numColumns - 1);
            int index = num1;
            while (index <= num2)
            {
                strArray[index] = StringType.FromObject(LateBinding.LateIndexGet(_ary2DaStrings, new object[2]
                {
                    RuntimeHelpers.GetObjectValue(rowNumber),
                    index
                }, null));

                ++index;
            }

            return strArray;
        }

        public string GetIndiceData(int rowNumber, int colNumber)
        {
            if (_ary2DaStrings == null)
            {
                string str = "";
                return str;
            }

            return StringType.FromObject(LateBinding.LateIndexGet(_ary2DaStrings, new object[2] {rowNumber, colNumber},
                null));
        }

        public string GetIndiceData(int rowNumber, string colName)
        {
            int num = Array.IndexOf((Array) ColNames, colName);
            string str = "";
            try
            {
                if (_ary2DaStrings != null)
                {
                    if (num != -1)
                        str = StringType.FromObject(LateBinding.LateIndexGet(_ary2DaStrings, new object[2]
                        {
                            rowNumber,
                            checked(num + 1)
                        }, null));
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                str = "ERROR";
                ProjectData.ClearProjectError();
            }

            return str;
        }

        public string GetIndiceData(string rowName, int colNumber)
        {
            int num = Array.IndexOf((Array) _rowLabels, rowName);
            if (_ary2DaStrings == null || num == -1)
            {
                string str = "";
                return str;
            }

            return StringType.FromObject(LateBinding.LateIndexGet(_ary2DaStrings,
                new object[2] {checked(num + 1), colNumber}, null));
        }

        public string GetIndiceData(string rowName, string colName)
        {
            int num1 = Array.IndexOf((Array) ColNames, colName);
            int num2 = Array.IndexOf((Array) _rowLabels, rowName);
            if (_ary2DaStrings == null || num1 == -1 || num2 == -1)
            {
                string str = "";
                return str;
            }

            return StringType.FromObject(LateBinding.LateIndexGet(_ary2DaStrings,
                new object[2] {checked(num2 + 1), checked(num1 + 1)}, null));
        }
    }
}