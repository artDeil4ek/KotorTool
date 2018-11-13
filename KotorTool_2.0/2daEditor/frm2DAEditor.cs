using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Forms
{
    public class Frm2DaEditor : Form
    {
        [AccessedThroughProperty("MenuItem3")] private MenuItem _menuItem3;

        [AccessedThroughProperty("miTestFunction")]
        private MenuItem _miTestFunction;

        [AccessedThroughProperty("dt")] private DataTable _dt;

        [AccessedThroughProperty("cmiInsertRow")]
        private MenuItem _cmiInsertRow;

        [AccessedThroughProperty("miSave2daV2b")]
        private MenuItem _miSave2DaV2B;

        [AccessedThroughProperty("cmiPasteRow")]
        private MenuItem _cmiPasteRow;

        [AccessedThroughProperty("cmiInsertCopiedRow")]
        private MenuItem _cmiInsertCopiedRow;

        [AccessedThroughProperty("miResetSort")]
        private MenuItem _miResetSort;

        [AccessedThroughProperty("miLoad2da")] private MenuItem _miLoad2Da;

        [AccessedThroughProperty("cmiRenumberRowLabelColumn")]
        private MenuItem _cmiRenumberRowLabelColumn;

        [AccessedThroughProperty("cmiShowStrings")]
        private MenuItem _cmiShowStrings;

        [AccessedThroughProperty("cm")] private ContextMenu _cm;
        [AccessedThroughProperty("dg2DA")] private TwoDaDataGrid _dg2Da;

        [AccessedThroughProperty("cmiCopyRow")]
        private MenuItem _cmiCopyRow;

        [AccessedThroughProperty("miSetKotORversion")]
        private MenuItem _miSetKotORversion;

        [AccessedThroughProperty("miSave2daV2bXML")]
        private MenuItem _miSave2DaV2bXml;

        [AccessedThroughProperty("MenuItem2")] private MenuItem _menuItem2;
        [AccessedThroughProperty("miQuit")] private MenuItem _miQuit;

        [AccessedThroughProperty("miLoad2daXml")]
        private MenuItem _miLoad2DaXml;

        [AccessedThroughProperty("MenuItem1")] private MenuItem _menuItem1;
        [AccessedThroughProperty("MenuItem6")] private MenuItem _menuItem6;
        [AccessedThroughProperty("miUndoAll")] private MenuItem _miUndoAll;
        [AccessedThroughProperty("MenuItem4")] private MenuItem _menuItem4;
        [AccessedThroughProperty("MainMenu1")] private MainMenu _mainMenu1;
        [AccessedThroughProperty("MenuItem5")] private MenuItem _menuItem5;
        private IContainer components;
        private DataView _dView;
        private DataGridCell _lastGDcell;
        private byte[] _ary2Da;
        private string _fname;
        private int _numRows;
        private int _numColumns;
        private string[] _colNames;
        private string[] _rowLabels;
        private int _gClickedRow;
        private int _gClickedColumn;
        private string _xmLfilepath;
        private string _filetype;
        private DataRow _clipboardDataRow;
        private int _kotorVersionIndex;
        private int _lastKotorVersionIndex;
        private ClsDialogTlk _gDialogTlk;

        internal virtual TwoDaDataGrid Dg2Da
        {
            get => _dg2Da;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dg2Da != null)
                    _dg2Da.MouseUp -= dg_MouseUp;
                _dg2Da = value;
                if (_dg2Da == null)
                    return;
                _dg2Da.MouseUp += dg_MouseUp;
            }
        }

        internal virtual MainMenu MainMenu1
        {
            get => _mainMenu1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_mainMenu1 == null)
                    ;
                _mainMenu1 = value;
                if (_mainMenu1 != null)
                    ;
            }
        }

        internal virtual MenuItem MenuItem1
        {
            get => _menuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem1 == null)
                    ;
                _menuItem1 = value;
                if (_menuItem1 != null)
                    ;
            }
        }

        internal virtual MenuItem MiLoad2Da
        {
            get => _miLoad2Da;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miLoad2Da != null)
                    _miLoad2Da.Click -= miLoad2da_Click;
                _miLoad2Da = value;
                if (_miLoad2Da == null)
                    return;
                _miLoad2Da.Click += miLoad2da_Click;
            }
        }

        internal virtual MenuItem MiSave2DaV2B
        {
            get => _miSave2DaV2B;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSave2DaV2B != null)
                    _miSave2DaV2B.Click -= miSave2daV2b_Click;
                _miSave2DaV2B = value;
                if (_miSave2DaV2B == null)
                    return;
                _miSave2DaV2B.Click += miSave2daV2b_Click;
            }
        }

        internal virtual MenuItem MiSave2DaV2bXml
        {
            get => _miSave2DaV2bXml;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSave2DaV2bXml != null)
                    _miSave2DaV2bXml.Click -= miSave2daV2bXML_Click;
                _miSave2DaV2bXml = value;
                if (_miSave2DaV2bXml == null)
                    return;
                _miSave2DaV2bXml.Click += miSave2daV2bXML_Click;
            }
        }

        internal virtual MenuItem MenuItem5
        {
            get => _menuItem5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem5 == null)
                    ;
                _menuItem5 = value;
                if (_menuItem5 != null)
                    ;
            }
        }

        internal virtual MenuItem MiQuit
        {
            get => _miQuit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miQuit != null)
                    _miQuit.Click -= QuitOnClick;
                _miQuit = value;
                if (_miQuit == null)
                    return;
                _miQuit.Click += QuitOnClick;
            }
        }

        internal virtual MenuItem MenuItem2
        {
            get => _menuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem2 == null)
                    ;
                _menuItem2 = value;
                if (_menuItem2 != null)
                    ;
            }
        }

        internal virtual MenuItem MiResetSort
        {
            get => _miResetSort;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miResetSort != null)
                    _miResetSort.Click -= miResetSort_Click;
                _miResetSort = value;
                if (_miResetSort == null)
                    return;
                _miResetSort.Click += miResetSort_Click;
            }
        }

        internal virtual MenuItem MenuItem4
        {
            get => _menuItem4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem4 == null)
                    ;
                _menuItem4 = value;
                if (_menuItem4 != null)
                    ;
            }
        }

        internal virtual MenuItem MiUndoAll
        {
            get => _miUndoAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miUndoAll != null)
                    _miUndoAll.Click -= miUndoAll_Click;
                _miUndoAll = value;
                if (_miUndoAll == null)
                    return;
                _miUndoAll.Click += miUndoAll_Click;
            }
        }

        internal virtual MenuItem MenuItem6
        {
            get => _menuItem6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem6 == null)
                    ;
                _menuItem6 = value;
                if (_menuItem6 != null)
                    ;
            }
        }

        internal virtual MenuItem MiLoad2DaXml
        {
            get => _miLoad2DaXml;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miLoad2DaXml != null)
                    _miLoad2DaXml.Click -= miLoad2daXml_Click;
                _miLoad2DaXml = value;
                if (_miLoad2DaXml == null)
                    return;
                _miLoad2DaXml.Click += miLoad2daXml_Click;
            }
        }

        internal virtual MenuItem MenuItem3
        {
            get => _menuItem3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_menuItem3 == null)
                    ;
                _menuItem3 = value;
                if (_menuItem3 != null)
                    ;
            }
        }

        internal virtual MenuItem MiSetKotORversion
        {
            get => _miSetKotORversion;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSetKotORversion != null)
                    _miSetKotORversion.Click -= miSetKotORversion_Click;
                _miSetKotORversion = value;
                if (_miSetKotORversion == null)
                    return;
                _miSetKotORversion.Click += miSetKotORversion_Click;
            }
        }

        internal virtual MenuItem MiTestFunction
        {
            get => _miTestFunction;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miTestFunction != null)
                    _miTestFunction.Click -= miTestFunction_Click;
                _miTestFunction = value;
                if (_miTestFunction == null)
                    return;
                _miTestFunction.Click += miTestFunction_Click;
            }
        }

        public virtual DataTable Dt
        {
            get => _dt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dt == null)
                    ;
                _dt = value;
                if (_dt != null)
                    ;
            }
        }

        protected virtual ContextMenu Cm
        {
            get => _cm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cm == null)
                    ;
                _cm = value;
                if (_cm != null)
                    ;
            }
        }

        public virtual MenuItem CmiInsertRow
        {
            get => _cmiInsertRow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiInsertRow != null)
                    _cmiInsertRow.Click -= cmiInsertRow_Click;
                _cmiInsertRow = value;
                if (_cmiInsertRow == null)
                    return;
                _cmiInsertRow.Click += cmiInsertRow_Click;
            }
        }

        public virtual MenuItem CmiCopyRow
        {
            get => _cmiCopyRow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiCopyRow != null)
                    _cmiCopyRow.Click -= cmiCopyRow_Click;
                _cmiCopyRow = value;
                if (_cmiCopyRow == null)
                    return;
                _cmiCopyRow.Click += cmiCopyRow_Click;
            }
        }

        public virtual MenuItem CmiPasteRow
        {
            get => _cmiPasteRow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiPasteRow != null)
                    _cmiPasteRow.Click -= cmiPasteRow_Click;
                _cmiPasteRow = value;
                if (_cmiPasteRow == null)
                    return;
                _cmiPasteRow.Click += cmiPasteRow_Click;
            }
        }

        public virtual MenuItem CmiInsertCopiedRow
        {
            get => _cmiInsertCopiedRow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiInsertCopiedRow != null)
                    _cmiInsertCopiedRow.Click -= cmiInsertCopiedRow_Click;
                _cmiInsertCopiedRow = value;
                if (_cmiInsertCopiedRow == null)
                    return;
                _cmiInsertCopiedRow.Click += cmiInsertCopiedRow_Click;
            }
        }

        public virtual MenuItem CmiRenumberRowLabelColumn
        {
            get => _cmiRenumberRowLabelColumn;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiRenumberRowLabelColumn != null)
                    _cmiRenumberRowLabelColumn.Click -= cmiRenumberRowLabelColumn_Click;
                _cmiRenumberRowLabelColumn = value;
                if (_cmiRenumberRowLabelColumn == null)
                    return;
                _cmiRenumberRowLabelColumn.Click += cmiRenumberRowLabelColumn_Click;
            }
        }

        public virtual MenuItem CmiShowStrings
        {
            get => _cmiShowStrings;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiShowStrings != null)
                    _cmiShowStrings.Click -= cmiShowStrings_Click;
                _cmiShowStrings = value;
                if (_cmiShowStrings == null)
                    return;
                _cmiShowStrings.Click += cmiShowStrings_Click;
            }
        }

        public Frm2DaEditor()
        {
            Load += frm2DAEditor_Load;
            Closing += frm2DAEditor_Closing;
            Move += frm2DAEditor_Move;
            Dt = new DataTable();
            _lastGDcell = new DataGridCell();
            Cm = new ContextMenu();
            CmiInsertRow = new MenuItem("Insert Row");
            CmiCopyRow = new MenuItem("Copy Row");
            CmiPasteRow = new MenuItem("Paste Row");
            CmiInsertCopiedRow = new MenuItem("Insert Copied Row");
            CmiRenumberRowLabelColumn = new MenuItem("Renumber Row Labels");
            CmiShowStrings = new MenuItem("Show Strings for Refs");
            InitializeComponent();
        }

        public Frm2DaEditor(byte[] a2Da)
            : this()
        {
            _ary2Da = a2Da;
        }

        public Frm2DaEditor(string filename, byte[] a2Da, int kotorVersIndex = -1)
            : this()
        {
            _fname = filename;
            _ary2Da = a2Da;
            Dt.TableName = filename;
            _kotorVersionIndex = kotorVersIndex;
            _lastKotorVersionIndex = kotorVersIndex;
            if (kotorVersIndex == 0)
            {
                Text = Text + " - Kotor I";
            }
            else
            {
                if (kotorVersIndex != 1)
                    return;
                Text = Text + " - Kotor II";
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();
            base.Dispose(disposing);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            //new ResourceManager(typeof(Frm2DaEditor));
            Dg2Da = new TwoDaDataGrid();
            MainMenu1 = new MainMenu();
            MenuItem1 = new MenuItem();
            MiLoad2Da = new MenuItem();
            MiLoad2DaXml = new MenuItem();
            MenuItem6 = new MenuItem();
            MiSave2DaV2B = new MenuItem();
            MiSave2DaV2bXml = new MenuItem();
            MenuItem5 = new MenuItem();
            MiQuit = new MenuItem();
            MenuItem2 = new MenuItem();
            MiResetSort = new MenuItem();
            MenuItem4 = new MenuItem();
            MiUndoAll = new MenuItem();
            MenuItem3 = new MenuItem();
            MiSetKotORversion = new MenuItem();
            MiTestFunction = new MenuItem();
            Dg2Da.BeginInit();
            SuspendLayout();
            Dg2Da.DataMember = "";
            Dg2Da.Dock = DockStyle.Fill;
            Dg2Da.HeaderForeColor = SystemColors.ControlText;
            Dg2Da.Location = new Point(0, 0);
            Dg2Da.Name = "dg2DA";
            TwoDaDataGrid dg2Da = Dg2Da;
            Size size1 = new Size(560, 409);
            Size size2 = size1;
            dg2Da.Size = size2;
            Dg2Da.TabIndex = 0;
            MainMenu1.MenuItems.AddRange(new MenuItem[2]
            {
                MenuItem1,
                MenuItem2
            });
            MenuItem1.Index = 0;
            MenuItem1.MenuItems.AddRange(new MenuItem[7]
            {
                MiLoad2Da,
                MiLoad2DaXml,
                MenuItem6,
                MiSave2DaV2B,
                MiSave2DaV2bXml,
                MenuItem5,
                MiQuit
            });
            MenuItem1.Text = "File";
            MiLoad2Da.Index = 0;
            MiLoad2Da.Shortcut = Shortcut.CtrlO;
            MiLoad2Da.Text = "Load 2DA v2.b file...";
            MiLoad2DaXml.Index = 1;
            MiLoad2DaXml.Shortcut = Shortcut.CtrlShiftO;
            MiLoad2DaXml.Text = "Load 2DA v2.b (XML) file...";
            MenuItem6.Index = 2;
            MenuItem6.Text = "-";
            MiSave2DaV2B.Index = 3;
            MiSave2DaV2B.Shortcut = Shortcut.CtrlS;
            MiSave2DaV2B.Text = "Save as 2DA v2.b...";
            MiSave2DaV2bXml.Index = 4;
            MiSave2DaV2bXml.Shortcut = Shortcut.CtrlShiftS;
            MiSave2DaV2bXml.Text = "Save as 2DA v2.b (XML) ...";
            MenuItem5.Index = 5;
            MenuItem5.Text = "-";
            MiQuit.Index = 6;
            MiQuit.Shortcut = Shortcut.CtrlQ;
            MiQuit.Text = "Quit";
            MenuItem2.Index = 1;
            MenuItem2.MenuItems.AddRange(new MenuItem[6]
            {
                MiResetSort,
                MenuItem4,
                MiUndoAll,
                MenuItem3,
                MiSetKotORversion,
                MiTestFunction
            });
            MenuItem2.Text = "Tools";
            MiResetSort.Index = 0;
            MiResetSort.Shortcut = Shortcut.F5;
            MiResetSort.Text = "Reset Sort";
            MenuItem4.Index = 1;
            MenuItem4.Text = "-";
            MiUndoAll.Index = 2;
            MiUndoAll.Text = "Undo All Changes";
            MenuItem3.Index = 3;
            MenuItem3.Text = "-";
            MiSetKotORversion.Index = 4;
            MiSetKotORversion.Text = "Set KotOR version...";
            MiTestFunction.Index = 5;
            MiTestFunction.Text = "Test function";
            MiTestFunction.Visible = false;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(560, 409);
            ClientSize = size1;
            Controls.Add(Dg2Da);
            //this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
            Menu = MainMenu1;
            size1 = new Size(248, 184);
            MinimumSize = size1;
            Name = "Frm2DaEditor";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.Manual;
            Text = "2DA Editor";
            Dg2Da.EndInit();
            ResumeLayout(false);
        }

        public void CreateDataTable()
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            int num1 = 9;
            int num2 = checked(_ary2Da.Length - 1);
            int index1 = num1;
            while (index1 <= num2 && _ary2Da[index1] != 0)
                checked
                {
                    ++index1;
                }

            int index2 = checked(index1 + 1);
            _numRows = checked((int) Math.Round(_ary2Da[index2] + _ary2Da[checked(index2 + 1)] * 256.0 +
                                                _ary2Da[checked(index2 + 2)] * 65536.0 +
                                                _ary2Da[checked(index2 + 3)] * 16777216.0));
            _colNames = Strings.Split(asciiEncoding.GetString(_ary2Da, 9, checked(index1 - 10)), "\t");
            _numColumns = _colNames.Length;
            int num3 = 0;
            int num4 = checked(index2 + 4);
            int num5 = checked(_ary2Da.Length - 1);
            int index3 = num4;
            while (index3 <= num5)
            {
                if (_ary2Da[index3] == 9)
                {
                    checked
                    {
                        ++num3;
                    }

                    if (num3 == _numRows)
                        break;
                }

                checked
                {
                    ++index3;
                }
            }

            int num6 = checked(index3 + 1);
            int num7 = num6;
            _rowLabels =
                Strings.Split(asciiEncoding.GetString(_ary2Da, checked(index2 + 4), checked(num6 - index2 - 5)), "\t");
            int num8 = checked(num6 + (_numRows * _numColumns + 1) * 2);
            Dt.Columns.Add(new DataColumn("(Row Label)", typeof(string)));
            int num9 = 0;
            int num10 = checked(_numColumns - 1);
            int index4 = num9;
            while (index4 <= num10)
            {
                Dt.Columns.Add(new DataColumn(_colNames[index4])
                {
                    DefaultValue = ""
                });
                checked
                {
                    ++index4;
                }
            }

            int num11 = 0;
            int num12 = checked(_numRows - 1);
            int index5 = num11;
            while (index5 <= num12)
            {
                DataRow row = Dt.NewRow();
                row[0] = _rowLabels[index5];
                int num13 = 0;
                int num14 = checked(_colNames.Length - 1);
                int num15 = num13;
                while (num15 <= num14)
                {
                    int index6 = checked((num15 + index5 * _numColumns) * 2 + num7);
                    int byteIndex = checked(num8 + _ary2Da[index6] + 256 * _ary2Da[index6 + 1]);
                    int num16 = byteIndex;
                    int num17 = checked(_ary2Da.Length - 1);
                    int index7 = num16;
                    while (index7 <= num17 && _ary2Da[index7] != 0)
                        checked
                        {
                            ++index7;
                        }

                    string str = index7 <= byteIndex
                        ? "****"
                        : asciiEncoding.GetString(_ary2Da, byteIndex, checked(index7 - byteIndex));
                    row[checked(num15 + 1)] = str;
                    checked
                    {
                        ++num15;
                    }
                }

                Dt.Rows.Add(row);
                checked
                {
                    ++index5;
                }
            }
        }

        private void frm2DAEditor_Load(object sender, EventArgs e)
        {
            if (_ary2Da != null)
                BuildEditor();
            PositionWindow();
        }

        private void frm2DAEditor_Closing(object sender, CancelEventArgs e)
        {
            SaveSettings();
        }

        public void BuildEditor()
        {
            CreateDataTable();
            _dView = Dt.DefaultView;
            _dView.AllowDelete = true;
            _dView.AllowNew = true;
            _dView.AllowEdit = true;
            Dg2Da.TableStyles.Clear();
            Dg2Da.SetDataBinding(_dView, null);
            Dg2Da.CaptionText = _fname;
            Dg2Da.CaptionFont = new Font("Microsoft Sans Serif", 9f);
            CreateTableStyle();
            AutoSizeColumns();
            Dt.ColumnChanged += dt_ColumnChanged;
        }

        private object WriteStringBytes(BinaryWriter wr, string str)
        {
            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            byte[] numArray = new byte[256];
            asciiEncoding.GetBytes(str, 0, Strings.Len(str), numArray, 0);
            wr.Write(numArray, 0, Strings.Len(str));
            object obj = new object();
            return obj;
        }

        public void Write2DaV2BFile()
        {
            string str1 = StringType.FromObject(FileUtils.GetFilePath("save",
                ConfigOptions.Paths.DefaultSaveLocation, _fname, "Save 2DA v2.b file...", "2da"));
            if (StringType.StrCmp(str1, "", false) == 0)
                return;
            Hashtable hashtable = new Hashtable();
            FileStream fileStream = new FileStream(str1, FileMode.Create);
            BinaryWriter wr = new BinaryWriter(fileStream, Encoding.ASCII);
            if (checked(_numColumns + 1) < Dt.Columns.Count)
            {
                Interaction.MsgBox(
                    "The columns added via the Show Strings function will be removed so that the file can be saved properly.",
                    MsgBoxStyle.Information, "");
                int num2 = checked(Dt.Columns.Count - 1);
                int num3 = checked(_numColumns + 1);
                int index = num2;
                while (index >= num3)
                {
                    Dt.Columns.RemoveAt(index);
                    checked
                    {
                        index += -1;
                    }
                }
            }

            try
            {
                int num1 = 0;
                int num2 = 0;
                int num3 = checked(Dt.Rows.Count - 1);
                int index1 = num2;
                while (index1 <= num3)
                {
                    int num4 = 1;
                    int num5 = checked(Dt.Columns.Count - 1);
                    int index2 = num4;
                    while (index2 <= num5)
                    {
                        object objectValue = RuntimeHelpers.GetObjectValue(Dg2Da[index1, index2]);
                        if (!hashtable.Contains(RuntimeHelpers.GetObjectValue(objectValue)))
                        {
                            hashtable.Add(RuntimeHelpers.GetObjectValue(objectValue), num1);
                            checked
                            {
                                ++num1;
                            }
                        }
  ++index2;
                        
                    }

                        ++index1;
                    
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ProjectData.SetProjectError(ex);
                Interaction.MsgBox(
                    "Error reading data from grid. dtc= " + StringType.FromInteger(Dt.Rows.Count) + " dvc= " +
                    StringType.FromInteger(_dView.Count), MsgBoxStyle.Critical);
                ProjectData.ClearProjectError();
                return;
            }

            object[] objArray = new object[checked(hashtable.Count + 1)];
            short[] numArray = new short[checked(hashtable.Count + 1)];
            hashtable.CopyTo(objArray, 0);
            int num6 = 0;
            int num7 = checked(hashtable.Count - 1);
            int index3 = num6;
            while (index3 <= num7)
            {
                hashtable[
                    RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objArray[index3], null, "key", new object[0],
                        null, null))] = index3;
               ++index3;
                
            }

            WriteStringBytes(wr, "2DA V2.b\n");
            int num8 = 1;
            int num9 = checked(Dt.Columns.Count - 1);
            int index4 = num8;
            while (index4 <= num9)
            {
                WriteStringBytes(wr, Dt.Columns[index4].ColumnName + "\t");
                ++index4;
                
            }

            wr.Write(char.MinValue);
            wr.Write(Dt.Rows.Count);
            int num10 = 0;
            int num11 = checked(Dt.Rows.Count - 1);
            int index5 = num10;
            while (index5 <= num11)
            {
                WriteStringBytes(wr, StringType.FromObject(ObjectType.StrCatObj(Dg2Da[index5, 0], '\t')));
                  ++index5;
                
            }

            int position = checked((int) fileStream.Position);
            fileStream.Seek(checked((Dt.Columns.Count - 1) * Dt.Rows.Count + 1 * 2), SeekOrigin.Current);
            int num12 = 0;
            int num13 = 0;
            int num14 = checked(hashtable.Count - 1);
            int index6 = num13;
            while (index6 <= num14)
            {
                string str2 =
                    StringType.FromObject(
                        ((DictionaryEntry) (objArray[index6] ?? Activator.CreateInstance(typeof(DictionaryEntry))))
                        .Key);
                if (StringType.StrCmp(str2, "****", false) == 0)
                    str2 = "";
                WriteStringBytes(wr, str2 + "\0");
                numArray[index6] = checked((short) num12);
                
                    num12 += Strings.Len(str2) + 1;
               
                    ++index6;
                
            }

            numArray[index6] = checked((short) num12);
            fileStream.Seek(position, SeekOrigin.Begin);
            int num15 = 0;
            int num16 = checked(Dt.Rows.Count - 1);
            int index7 = num15;
            while (index7 <= num16)
            {
                int num1 = 1;
                int num2 = checked(Dt.Columns.Count - 1);
                int index1 = num1;
                while (index1 <= num2)
                {
                    object objectValue = RuntimeHelpers.GetObjectValue(Dg2Da[index7, index1]);
                    int index2 = IntegerType.FromObject(hashtable[RuntimeHelpers.GetObjectValue(objectValue)]);
                    wr.Write(numArray[index2]);
                    
                        ++index1;
                    
                }
  ++index7;
                
            }

            wr.Close();
            _fname = Path.GetFileName(str1);
            Dg2Da.CaptionText = _fname;
        }

        private void LoadFromXmlFile(string path)
        {
            _filetype = "xml";
            _xmLfilepath = path;
            DataSet dataSet = new DataSet();
            int num = (int) dataSet.ReadXml(path);
            Dt = dataSet.Tables[0];
            _dView = Dt.DefaultView;
            _dView.AllowDelete = true;
            _dView.AllowNew = true;
            _dView.AllowEdit = true;
            Dg2Da.TableStyles.Clear();
            Dg2Da.SetDataBinding(_dView, null);
            Dg2Da.CaptionText = Dt.TableName;
            Dg2Da.CaptionFont = new Font("Microsoft Sans Serif", 9f);
            CreateTableStyle();
            AutoSizeColumns();
            dataSet.Tables.Remove(Dt);
        }

        private void CreateTableStyle()
        {
            DataGridTableStyle table = new DataGridTableStyle();
            Dg2Da.TableStyles.Clear();
            table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
            table.MappingName = _fname;
            int num1 = 0;
            int num2 = checked(Dt.Columns.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                DataGridTextBoxColumn gridTextBoxColumn = new DataGridTextBoxColumn();
                gridTextBoxColumn.MappingName = Dt.Columns[index].Caption;
                gridTextBoxColumn.HeaderText = Dt.Columns[index].Caption;
                gridTextBoxColumn.NullText = "";
                table.GridColumnStyles.Add(gridTextBoxColumn);
                 ++index;
                
            }

            Dg2Da.TableStyles.Add(table);
        }

        public void AutoSizeColumns()
        {
            int num1 = 0;
            int num2 = checked(Dt.Columns.Count - 1);
            int col = num1;
            while (col <= num2)
            {
                Dg2Da.TableStyles[0].GridColumnStyles[col].Width = GetColWidth(col, Dt.Columns[col].Caption);
                ++col;
                
            }
        }

        protected int GetColWidth(int col, string displayName)
        {
            int count = ((DataView) Dg2Da.DataSource).Count;
            Graphics graphics = Graphics.FromHwnd(Handle);
            StringFormat format = new StringFormat(StringFormat.GenericTypographic);
            float num1 = graphics.MeasureString(displayName, Font, 500, format).Width;
            try
            {
                int num2 = 0;
                int num3 = checked(count - 1);
                int index = num2;
                while (index <= num3)
                {
                    SizeF sizeF = graphics.MeasureString(Dg2Da[index, col].ToString(), Font, 500, format);
                    if (sizeF.Width > (double) num1)
                        num1 = sizeF.Width;
                      ++index;
                    
                }

                graphics.Dispose();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                num1 = 75f;
                ProjectData.ClearProjectError();
            }

            return checked((int) Math.Round(num1 + 10f));
        }

        private void dg_MouseUp(object sender, MouseEventArgs e)
        {
            DataGrid.HitTestInfo hitTestInfo = Dg2Da.HitTest(Dg2Da.PointToClient(MousePosition));
            if (hitTestInfo.Type == DataGrid.HitTestType.RowHeader)
            {
                if (!IsLastRow(hitTestInfo.Row))
                {
                    if (!(e.Button == MouseButtons.Right & e.Clicks == 1))
                        return;
                    _gClickedRow = hitTestInfo.Row;
                    Cm.MenuItems.Clear();
                    Cm.MenuItems.Add(CmiInsertRow);
                    Cm.MenuItems.Add(CmiCopyRow);
                    if (_clipboardDataRow != null ||
                        Clipboard.GetDataObject().GetDataPresent(DataFormats.CommaSeparatedValue))
                    {
                        Cm.MenuItems.Add(CmiPasteRow);
                        Cm.MenuItems.Add(CmiInsertCopiedRow);
                    }

                    if (IsCol0AllNumbers())
                        Cm.MenuItems.Add(CmiRenumberRowLabelColumn);
                    Cm.Show(this, new Point(e.X, e.Y));
                }
                else
                {
                    if (!(e.Button == MouseButtons.Right & e.Clicks == 1 & _clipboardDataRow != null))
                        return;
                    _gClickedRow = hitTestInfo.Row;
                    Cm.MenuItems.Clear();
                    Cm.MenuItems.Add(CmiPasteRow);
                    Cm.Show(this, new Point(e.X, e.Y));
                }
            }
            else
            {
                if (hitTestInfo.Type != DataGrid.HitTestType.ColumnHeader ||
                    !(e.Button == MouseButtons.Right & e.Clicks == 1))
                    return;
                _gClickedColumn = hitTestInfo.Column;
                Cm.MenuItems.Clear();
                Cm.MenuItems.Add(CmiShowStrings);
                Cm.Show(this, new Point(e.X, e.Y));
            }
        }

        protected bool IsLastRow(int row)
        {
            bool flag;
            try
            {
                Dg2Da.Select(checked(row + 1));
                Dg2Da.UnSelect(checked(row + 1));
            }
            catch (IndexOutOfRangeException ex)
            {
                ProjectData.SetProjectError(ex);
                flag = true;
                ProjectData.ClearProjectError();
                goto label_3;
            }

            return false;
            label_3:
            return flag;
        }

        private void btnWrite2daV2bFile_Click(object sender, EventArgs e)
        {
            Write2DaV2BFile();
        }

        private void GetClipboardDataRow(ref DataRow destRow)
        {
            DataObject dataObject = (DataObject) Clipboard.GetDataObject();
            string str = "";
            if (dataObject != null && dataObject.GetDataPresent(DataFormats.CommaSeparatedValue))
            {
                object objectValue = RuntimeHelpers.GetObjectValue(dataObject.GetData(DataFormats.CommaSeparatedValue));
                if (StringType.StrCmp(objectValue.GetType().Name, "MemoryStream", false) == 0)
                {
                    StreamReader streamReader = new StreamReader((Stream) objectValue);
                    str = streamReader.ReadLine();
                    streamReader.Close();
                }
                else if (StringType.StrCmp(objectValue.GetType().Name, "String", false) == 0)
                    str = (string) objectValue;
            }

            string[] strArray = str.Split(',');
            if (strArray.GetLength(0) > Dt.Columns.Count)
            {
                if (Interaction.MsgBox(
                        "The clipboard contains more columns of data than are present in the table.\nDo you want to paste just the columns that will fit?",
                        MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "") == MsgBoxResult.No)
                    return;
                int num1 = 0;
                int num2 = checked(Dt.Columns.Count - 1);
                int index = num1;
                while (index <= num2)
                {
                    destRow[index] = strArray[index];
                   ++index;
                    
                }
            }
            else if (strArray.GetLength(0) < Dt.Columns.Count)
            {
                if (Interaction.MsgBox(
                        "The clipboard contains fewer columns of data than are present in the table.\nDo you want to continue?",
                        MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "") == MsgBoxResult.No)
                    return;
                int num1 = 0;
                int num2 = checked(strArray.GetLength(0) - 1);
                int index = num1;
                while (index <= num2)
                {
                    destRow[index] = strArray[index];
                    ++index;
                    
                }
            }
            else
            {
                int num1 = 0;
                int num2 = checked(Dt.Columns.Count - 1);
                int index = num1;
                while (index <= num2)
                {
                    destRow[index] = strArray[index];
                    ++index;
                    
                }
            }
        }

        private void cmiInsertRow_Click(object sender, EventArgs e)
        {
            if (StringType.StrCmp(Dt.DefaultView.Sort, "", false) != 0)
            {
                switch (ShowPasteInsertWhileSortedMsg())
                {
                    case DialogResult.Yes:
                        Dt.DefaultView.Sort = "";
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            InsertRow(null);
        }

        private void cmiCopyRow_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = checked(Dt.Columns.Count - 2);
            int index = num1;
            string str1 = "";
            while (index <= num2)
            {
                str1 = StringType.FromObject(ObjectType.StrCatObj(str1,
                    ObjectType.StrCatObj(_dView[_gClickedRow].Row[index], ",")));
                checked
                {
                    ++index;
                }
            }

            string str2 = StringType.FromObject(ObjectType.StrCatObj(str1, _dView[_gClickedRow].Row[index]));
            DataObject dataObject = new DataObject();
            dataObject.SetData(DataFormats.CommaSeparatedValue, false, str2);
            Clipboard.SetDataObject(dataObject, true);
        }

        private void cmiPasteRow_Click(object sender, EventArgs e)
        {
            if (StringType.StrCmp(Dt.DefaultView.Sort, "", false) != 0)
            {
                switch (ShowPasteInsertWhileSortedMsg())
                {
                    case DialogResult.Yes:
                        Dt.DefaultView.Sort = "";
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            DataRow destRow = !IsLastRow(_gClickedRow) ? _dView[_gClickedRow].Row : Dt.NewRow();
            GetClipboardDataRow(ref destRow);
            if (IsLastRow(_gClickedRow))
                Dt.Rows.Add(destRow);
            Dg2Da.ScrollToRow(_gClickedRow);
        }

        private void cmiInsertCopiedRow_Click(object sender, EventArgs e)
        {
            if (StringType.StrCmp(Dt.DefaultView.Sort, "", false) != 0)
            {
                switch (ShowPasteInsertWhileSortedMsg())
                {
                    case DialogResult.Yes:
                        Dt.DefaultView.Sort = "";
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }

            DataRow destRow = Dt.NewRow();
            GetClipboardDataRow(ref destRow);
            InsertRow(destRow);
        }

        private void cmiRenumberRowLabelColumn_Click(object sender, EventArgs e)
        {
            RenumberRowLabelColumn();
        }

        private void miLoad2da_Click(object sender, EventArgs e)
        {
            //FIX THIS , GETTING NULL REFERENCE ERROR
            string str = StringType.FromObject(FileUtils.GetFilePath("load", ConfigOptions.Paths.DefaultImportLocation, "", "Load 2DA v2.b file...", "2da"));
            if (StringType.StrCmp(str, "", false) == 0) return;
            _filetype = "binary";
            FileStream fileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream, Encoding.ASCII);
            _ary2Da = binaryReader.ReadBytes((int) fileStream.Length);
            binaryReader.Close();
            _fname = Strings.Mid(str, str.LastIndexOf("\\") + 2);
            Dt = new DataTable(_fname);
            Dg2Da.SetDataBinding(null, null);
            BuildEditor();
        }

        private void miLoad2daXml_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("load",
                ConfigOptions.Paths.DefaultImportLocation, "", "Load 2DA v2.b (XML) file...", "xml"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            LoadFromXmlFile(str);
        }

        private void miSave2daV2b_Click(object sender, EventArgs e)
        {
            string sort = Dt.DefaultView.Sort;
            Dt.DefaultView.Sort = "";
            Write2DaV2BFile();
            Dt.DefaultView.Sort = sort;
        }

        private void miSave2daV2bXML_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("save",
                ConfigOptions.Paths.DefaultSaveLocation, Strings.Replace(_fname, "2da", "xml"),
                "Save 2DA v2.b (XML) file...", "xml"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            string sort = Dt.DefaultView.Sort;
            Dt.DefaultView.Sort = "";
            if (checked(_numColumns + 1) < Dt.Columns.Count)
            {
                Interaction.MsgBox("The columns added via the Show Strings function will be removed so that the file can be saved properly.", MsgBoxStyle.Information, "");
                int num2 = checked(Dt.Columns.Count - 1);
                int num3 = checked(_numColumns + 1);
                int index = num2;
                while (index >= num3)
                {
                    Dt.Columns.RemoveAt(index);
                    checked
                    {
                        index += -1;
                    }
                }
            }

            DataSet dataSet = new DataSet("Kotor_2DA_File");
            dataSet.Tables.Add(Dt);
            dataSet.WriteXml(str);
            dataSet.Tables.Remove(Dt);
            dataSet.Dispose();
            Dt.DefaultView.Sort = sort;
        }

        private void QuitOnClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void miResetSort_Click(object sender, EventArgs e)
        {
            _dView.Sort = "";
        }

        private void miUndoAll_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to lose all changes and reload?", MsgBoxStyle.OkCancel, "") !=
                MsgBoxResult.Ok)
                return;
            if (StringType.StrCmp(_filetype, "xml", false) == 0)
            {
                LoadFromXmlFile(_xmLfilepath);
            }
            else
            {
                Dg2Da.SetDataBinding(null, null);
                Dt = new DataTable(_fname);
                BuildEditor();
            }
        }

        private void RenumberRowLabelColumn()
        {
            if (IsCol0AllNumbers())
            {
                int num1 = 0;
                if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(Dg2Da[0, 0])))
                    num1 = IntegerType.FromObject(Dg2Da[0, 0]);
                frmPromptForString frmPromptForString = new frmPromptForString("Renumber Row Labels",
                    "Enter the starting value:", StringType.FromInteger(num1));
                if (frmPromptForString.ShowDialog(this) != DialogResult.OK)
                    return;
                int int32 = Convert.ToInt32(frmPromptForString.tbValue.Text);
                int num2 = 0;
                int num3 = checked(_dView.Count - 1);
                int index = num2;
                while (index <= num3)
                {
                    Dg2Da[index, 0] = checked(index + int32);
                    checked
                    {
                        ++index;
                    }
                }
            }
            else
            {
                int num = (int) Interaction.MsgBox("One or more Row Labels is not a number or empty; aborting");
            }
        }

        private bool IsCol0AllNumbers()
        {
            bool flag = true;
            int num1 = 0;
            int num2 = checked(_dView.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(Dg2Da[index, 0])) && StringType.StrCmp(Dg2Da[index, 0].ToString().Trim(), "", false) != 0)
                {
                    flag = false;
                    break;
                }

                ++index;
            }

            return flag;
        }

        private void InsertRow(DataRow dr)
        {
            string sort = Dt.DefaultView.Sort;
            DataTable dataTable = new DataTable("temp");
            Dt.DefaultView.Sort = "";
            int num1 = 0;
            int num2 = checked(Dt.Columns.Count - 1);
            int index1 = num1;
            while (index1 <= num2)
            {
                dataTable.Columns.Add(new DataColumn(Dt.Columns[index1].ColumnName, typeof(string)) {DefaultValue = ""});
                ++index1;
                
            }

            int num3 = 0;
            int num4 = checked(_gClickedRow - 1);
            int index2 = num3;
            while (index2 <= num4)
            {
                DataRow row = _dView[index2].Row;
                dataTable.ImportRow(row);
                ++index2;
                
            }

            DataRow row1 = dataTable.NewRow();
            if (dr == null)
            {
                row1[0] = "new";
            }
            else
            {
                int num5 = 0;
                int num6 = checked(Dt.Columns.Count - 1);
                int index3 = num5;
                while (index3 <= num6)
                {
                    row1[index3] = RuntimeHelpers.GetObjectValue(dr[index3]);
                  ++index3;
                }
            }

            dataTable.Rows.Add(row1);
            int gClickedRow = _gClickedRow;
            int num7 = checked(Dt.Rows.Count - 1);
            int index4 = gClickedRow;
            while (index4 <= num7)
            {
                DataRow row2 = _dView[index4].Row;
                dataTable.ImportRow(row2);
               ++index4;
                
            }

            Dt = dataTable;
            Dt.TableName = _fname;
            Dt.DefaultView.Sort = sort;
            Dg2Da.SetDataBinding(null, null);
            _dView = null;
            _dView = Dt.DefaultView;
            Dg2Da.SetDataBinding(_dView, null);
            CreateTableStyle();
            AutoSizeColumns();
            Dg2Da.ScrollToRow(_gClickedRow);
        }

        private int InsertColumn(string columnName)
        {
            DataColumn column = new DataColumn(columnName);
            Dt.Columns.Add(column);
            CreateTableStyle();
            AutoSizeColumns();
            return Dt.Columns.IndexOf(column);
        }

        private DialogResult ShowPasteInsertWhileSortedMsg()
        {
            return (DialogResult) Interaction.MsgBox(
                "Pasting or Inserting rows while the grid is sorted may produce unexpected results.\nDo you wish to reset the sort before continuing?",
                MsgBoxStyle.YesNoCancel);
        }

        public void PositionWindow()
        {
            /*
            Point point1 = new Point(10, 10);
            Point point2 = new Point(10, 10);
            if (!ConfigOptions.WindowSettings.TwoDaEditorWindowLoc.IsEmpty)
            {
                point1 = settings.TwoDaEditorWindowLoc;
                if (point1.X < 0)
                {
                    Options.ConfigOptions configOptions = settings;
                    point2 = new Point(10, 10);
                    Point point3 = point2;
                    configOptions.TwoDaEditorWindowLoc = point3;
                }

                point2 = settings.TwoDaEditorWindowLoc;
                if (point2.Y < 0)
                {
                    Options.ConfigOptions configOptions = settings;
                    point1 = new Point(10, 10);
                    Point point3 = point1;
                    configOptions.TwoDaEditorWindowLoc = point3;
                }

                ((Control) this).Location = settings.TwoDaEditorWindowLoc;
            }

            if (settings.TwoDaEditorWindowSize.IsEmpty)
                return;
            Size size1 = settings.TwoDaEditorWindowSize;
            Rectangle workingArea;
            int height1 = 1;
            if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                Point local1 = point1;
                point2 = ((Control) this).Location;
                int x = point2.X;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                int top = workingArea.Top;
                // ISSUE: explicit reference operation
                local1 = new Point(x, top);
                ((Control) this).Location = point1;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                height1 = workingArea.Height;
                Size size2 = new Size(10, 10);
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                Size local2 = size2;
                size1 = Size;
                int width = size1.Width;
                int height2 = height1;
                // ISSUE: explicit reference operation
                local2 = new Size(width, height2);
                Size = size2;
            }

            int width1 = settings.TwoDaEditorWindowSize.Width;
            workingArea = Screen.PrimaryScreen.WorkingArea;
            int width2 = workingArea.Width;
            int width3 = 0;
            if (width1 > width2)
            {
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                Point local = point1;
                int left = Screen.PrimaryScreen.WorkingArea.Left;
                point2 = ((Control) this).Location;
                int y = point2.Y;
                // ISSUE: explicit reference operation
                local = new Point(left, y);
                ((Control) this).Location = point1;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                width3 = workingArea.Width;
                size1 = new Size(width3, Size.Height);
                Size = size1;
            }

            if (!(width3 == 0 & height1 == 0))
                return;
            Size = settings.TwoDaEditorWindowSize;*/
        }

        public void SaveSettings()
        {
            
           // ConfigOptions.WindowSettings.TwoDaEditorWindowLoc = ((Control) this).Location;
          //  settings.TwoDaEditorWindowSize = Size;
          //  UserSettings.SaveSettings(settings);
        }

        private void cmiShowStrings_Click(object sender, EventArgs e)
        {
            if (_kotorVersionIndex == -1)
            {
                FrmSpecifyKotorVersion specifyKotorVersion = new FrmSpecifyKotorVersion();
                if (specifyKotorVersion.ShowDialog() != DialogResult.OK)
                    return;
                _kotorVersionIndex = specifyKotorVersion.KotorVerIndexSelected;
            }

            GetDialogTlk();
            string str = Dt.Columns[_gClickedColumn].ColumnName + " (Strs)";
            int num1 = 0;
            int num2 = checked(Dt.Columns.Count - 1);
            int index1 = num1;
            while (index1 <= num2 && StringType.StrCmp(Dt.Columns[index1].ColumnName, str, false) != 0)
                checked
                {
                    ++index1;
                }

            int index2 = index1 != Dt.Columns.Count ? index1 : InsertColumn(str);
            int num3 = 0;
            int num4 = checked(Dt.Rows.Count - 1);
            int index3 = num3;
            while (index3 <= num4)
            {
                object objectValue = RuntimeHelpers.GetObjectValue(Dg2Da[index3, _gClickedColumn]);
                if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)))
                {
                    if (ObjectType.ObjTst(objectValue, -1, false) > 0)
                        Dg2Da[index3, index2] = _gDialogTlk.GetString(IntegerType.FromObject(objectValue));
                    else
                        Dg2Da[index3, index2] = "";
                }
  ++index3;
                
            }
        }

        private void dt_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName.EndsWith("(Strs)"))
                return;
            object objectValue = RuntimeHelpers.GetObjectValue(e.ProposedValue);
            if (!Information.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) ||
                ObjectType.ObjTst(IndexOfColumnName(e.Column.ColumnName + " (Strs)"), -1, false) <= 0)
                return;
            Dg2Da[Dg2Da.CurrentCell.RowNumber,
                    IntegerType.FromObject(IndexOfColumnName(e.Column.ColumnName + " (Strs)"))] =
                _gDialogTlk.GetString(IntegerType.FromObject(objectValue));
        }

        private object IndexOfColumnName(string name)
        {
            int num1 = -1;
            int num2 = 0;
            int num3 = checked(Dt.Columns.Count - 1);
            int index = num2;
            while (index <= num3)
            {
                if (StringType.StrCmp(Dt.Columns[index].ColumnName.ToLower(), name.ToLower(), false) == 0)
                {
                    num1 = index;
                    break;
                }
   ++index;
                
            }

            return num1;
        }

        private void frm2DAEditor_Move(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void miSetKotORversion_Click(object sender, EventArgs e)
        {
            FrmSpecifyKotorVersion specifyKotorVersion = new FrmSpecifyKotorVersion();
            switch (_kotorVersionIndex)
            {
                case 0:
                    specifyKotorVersion.rbKotor1.Checked = true;
                    break;
                case 1:
                    specifyKotorVersion.rbKotor2.Checked = true;
                    break;
            }

            if (specifyKotorVersion.ShowDialog() != DialogResult.OK) return;
            _kotorVersionIndex = specifyKotorVersion.KotorVerIndexSelected;
            if (_kotorVersionIndex == 0) Text = "2DA Editor - Kotor I";
            else if (_kotorVersionIndex == 1) Text = "2DA Editor - Kotor II";
            if (_lastKotorVersionIndex != _kotorVersionIndex & _gDialogTlk != null)
            {
                _gDialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(_kotorVersionIndex) + "\\dialog.tlk");
                if (checked(_numColumns + 1) < Dt.Columns.Count)
                {
                    int num1 = (int) Interaction.MsgBox("The columns added via the Show Strings function are being removed as the strings may not match between game versions.", MsgBoxStyle.Information, "");
                    int num2 = Dt.Columns.Count - 1;
                    int num3 = _numColumns + 1;
                    int index = num2;
                    while (index >= num3)
                    {
                        Dt.Columns.RemoveAt(index);
                        index += -1;
                    }
                }
            }

            _lastKotorVersionIndex = _kotorVersionIndex;
        }

        private ClsDialogTlk GetDialogTlk()
        {
            if (_gDialogTlk == null) _gDialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(_kotorVersionIndex) + "\\dialog.tlk");
            return _gDialogTlk;
        }

        private void miTestFunction_Click(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(new object());
            objectValue = RuntimeHelpers.GetObjectValue(GetPrivateField(Dg2Da, "DataGridRows"));
        }

        public static object GetPrivateField(object passedObject, string fieldName)
        {
            RuntimeHelpers.GetObjectValue(new object());
            if (passedObject == null) throw new ArgumentNullException("passedObject", "PassedObject must be an instantiated object.");
            if (fieldName == null || StringType.StrCmp(fieldName.Trim(), "", false) == 0) throw new ArgumentOutOfRangeException("fieldName", "Fieldname must be a non empty string.");
            Type type = passedObject.GetType();
            FieldInfo field = type.GetField(fieldName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (field == null) throw new ArgumentOutOfRangeException("fieldName", type.FullName + " does not have a field : " + fieldName + ".");
            return RuntimeHelpers.GetObjectValue(field.GetValue(RuntimeHelpers.GetObjectValue(passedObject)));
        }

        private void SetPrivateProperty(object passedObject, string propertyName, object value)
        {
            PropertyInfo property = passedObject.GetType().BaseType.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.NonPublic);
            if (property == null) return;
            property.SetValue(RuntimeHelpers.GetObjectValue(passedObject), RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(value), property.PropertyType)), null);
        }

        public class TwoDaDataGrid : DataGrid
        {
            public void ScrollToRow(int row)
            {
                if (DataSource == null)
                    return;
                GridVScrolled(this, new ScrollEventArgs(ScrollEventType.LargeIncrement, row));
            }
        }
    }
}