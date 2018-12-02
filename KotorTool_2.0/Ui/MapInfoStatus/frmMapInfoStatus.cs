// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmMapInfoStatus
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Models;
using KotorTool_2._0.Ui.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace KotorTool_2._0.Ui.MapInfoStatus
{
    public class FrmMapInfoStatus : Form
    {
        [AccessedThroughProperty("dgMapInfoStatus")]
        private DataGrid _dgMapInfoStatus;

        private IContainer components;
        private DataTable _dt;
        private DataView _dView;
        private MapInfo _mapInfo;
        private string _gMapsPath;
        private int _gTotalColWidth;

        internal virtual DataGrid DgMapInfoStatus
        {
            get => _dgMapInfoStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgMapInfoStatus == null)
                    ;
                _dgMapInfoStatus = value;
                if (_dgMapInfoStatus != null)
                    ;
            }
        }

        public FrmMapInfoStatus()
        {
            _dt = new DataTable();
            _gMapsPath = Path.Combine(StringType.FromObject(Registry.LocalMachine.OpenSubKey("software\\SCM\\Kotor Tool").GetValue("path")), "maps\\");
            InitializeComponent();
            BuildDataGrid();
            _mapInfo = ReadMapInfoFile();
            ShowStatus();
            AutoSizeColumns();
            Width = checked(_gTotalColWidth + 80);
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
            ResourceManager resourceManager = new ResourceManager(typeof(FrmMapInfoStatus));
            DgMapInfoStatus = new DataGrid();
            DgMapInfoStatus.BeginInit();
            SuspendLayout();
            DgMapInfoStatus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgMapInfoStatus.CaptionVisible = false;
            DgMapInfoStatus.DataMember = "";
            DgMapInfoStatus.HeaderForeColor = SystemColors.ControlText;
            DgMapInfoStatus.Location = new Point(8, 8);
            DgMapInfoStatus.Name = "dgMapInfoStatus";
            DataGrid dgMapInfoStatus = DgMapInfoStatus;
            Size size1 = new Size(536, 280);
            Size size2 = size1;
            dgMapInfoStatus.Size = size2;
            DgMapInfoStatus.TabIndex = 0;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(552, 309);
            ClientSize = size1;
            Controls.Add(DgMapInfoStatus);
            //Icon = (Icon) resourceManager.GetObject("$this.Icon");
            Name = "FrmMapInfoStatus";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MapInfo Status";
            DgMapInfoStatus.EndInit();
            ResumeLayout(false);
        }

        public static MapInfo ReadMapInfoFile()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Stream serializationStream1 = File.OpenRead(MainFormState.GRootPath + "MapInfo.bfd");
            MapInfo mapInfo;
            try
            {
                mapInfo = (MapInfo) binaryFormatter.Deserialize(serializationStream1);
                serializationStream1.Close();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                serializationStream1.Seek(0L, SeekOrigin.Begin);
                mapInfo = (MapInfo) CreateMapInfoFormatter(Type.GetType("KotorTool_2.MapInfo")).Deserialize(serializationStream1);
                serializationStream1.Close();
                if (mapInfo.GetType() == Type.GetType("KotorTool_2.MapInfo"))
                {
                    Stream serializationStream2 = File.OpenWrite(MainFormState.GRootPath + "MapInfo.bfd");
                    new BinaryFormatter().Serialize(serializationStream2, mapInfo);
                    serializationStream2.Close();
                }
                else
                {
                   Interaction.MsgBox("Unable to load MapInfo.bfd file.\n\nPlease download a fresh copy.", MsgBoxStyle.Critical, "MapInfo error");
                }

                ProjectData.ClearProjectError();
            }

            return mapInfo;
        }

        public static BinaryFormatter CreateMapInfoFormatter(Type type)
        {
            return new BinaryFormatter(new MyMapInfoSurrogate(type.Assembly), new StreamingContext(StreamingContextStates.All));
        }

        public void ShowStatus()
        {
            foreach (MapInfo.Map map in _mapInfo.MapList)
            {
                DataRow row = _dt.NewRow();
                row[0] = map.MapName;
                row[1] = !map.S ? "Unsupported" : (!File.Exists(_gMapsPath + "map" + map.MapName + ".map") ? "File Missing" : "Available");
                row[2] = !map.L ? "Unsupported" : (!File.Exists(_gMapsPath + "map" + map.MapName + "_lg.map") ? "File Missing" : "Available");
                row[3] = map.ModuleName;
                row[4] = map.MapAssembler;
                row[5] = map.MapCalibrator;
                _dt.Rows.Add(row);
            }
        }

        public void BuildDataTable()
        {
            _dt.Columns.Add(new DataColumn("Map Name", typeof(string)) {DefaultValue = ""});
            _dt.Columns.Add(new DataColumn("Small map", typeof(string)) {DefaultValue = ""});
            _dt.Columns.Add(new DataColumn("Large map", typeof(string)) {DefaultValue = ""});
            _dt.Columns.Add(new DataColumn("Module Description", typeof(string)) {DefaultValue = ""});
            _dt.Columns.Add(new DataColumn("Map Assembler", typeof(string)) {DefaultValue = ""});
            _dt.Columns.Add(new DataColumn("Map Calibrator", typeof(string)) {DefaultValue = ""});
        }

        
        public void BuildDataGrid()
        {
            BuildDataTable();
            _dView = _dt.DefaultView;
            _dView.AllowDelete = false;
            _dView.AllowNew = false;
            _dView.AllowEdit = false;
            _dView.Sort = "Map Name ASC";
            DataGridTableStyle table = new DataGridTableStyle();
            DgMapInfoStatus.TableStyles.Clear();
            table.MappingName = _dt.TableName;
            table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
            DataGridEnableTextBoxColumn enableTextBoxColumn1 = new DataGridEnableTextBoxColumn();
            enableTextBoxColumn1.MappingName = "Map Name";
            enableTextBoxColumn1.HeaderText = "Map Name";
            enableTextBoxColumn1.NullText = "";
            enableTextBoxColumn1.ReadOnly = true;
            table.GridColumnStyles.Add(enableTextBoxColumn1);
            DataGridEnableTextBoxColumn enableTextBoxColumn2 = new DataGridEnableTextBoxColumn();
            enableTextBoxColumn2.MappingName = "Small map";
            enableTextBoxColumn2.HeaderText = "Small map";
            enableTextBoxColumn2.NullText = "";
            enableTextBoxColumn2.ReadOnly = true;
            table.GridColumnStyles.Add(enableTextBoxColumn2);
            DataGridEnableTextBoxColumn enableTextBoxColumn3 = new DataGridEnableTextBoxColumn();
            enableTextBoxColumn3.MappingName = "Large map";
            enableTextBoxColumn3.HeaderText = "Large map";
            enableTextBoxColumn3.NullText = "";
            enableTextBoxColumn3.ReadOnly = true;
            table.GridColumnStyles.Add(enableTextBoxColumn3);
            DataGridEnableTextBoxColumn enableTextBoxColumn4 = new DataGridEnableTextBoxColumn();
            enableTextBoxColumn4.MappingName = "Module Description";
            enableTextBoxColumn4.HeaderText = "Module Description";
            enableTextBoxColumn4.NullText = "";
            table.GridColumnStyles.Add(enableTextBoxColumn4);
            DataGridEnableTextBoxColumn enableTextBoxColumn5 = new DataGridEnableTextBoxColumn();
            enableTextBoxColumn5.MappingName = "Map Assembler";
            enableTextBoxColumn5.HeaderText = "Map Assembler";
            enableTextBoxColumn5.NullText = "";
            table.GridColumnStyles.Add(enableTextBoxColumn5);
            DataGridEnableTextBoxColumn enableTextBoxColumn6 = new DataGridEnableTextBoxColumn();
            enableTextBoxColumn6.MappingName = "Map Calibrator";
            enableTextBoxColumn6.HeaderText = "Map Calibrator";
            enableTextBoxColumn6.NullText = "";
            table.GridColumnStyles.Add(enableTextBoxColumn6);
            DgMapInfoStatus.TableStyles.Add(table);
            DgMapInfoStatus.SetDataBinding(_dView, null);
            DgMapInfoStatus.CaptionText = "Map Status";
            DgMapInfoStatus.CaptionFont = new Font("Microsoft Sans Serif", 9f);
        }

        public void AutoSizeColumns()
        {
            _gTotalColWidth = 0;
            int num1 = 0;
            int num2 = _dt.Columns.Count - 1;
            int col = num1;
            while (col <= num2)
            {
                int colWidth = GetColWidth(col, _dt.Columns[col].Caption);
                DgMapInfoStatus.TableStyles[0].GridColumnStyles[col].Width = colWidth;
                _gTotalColWidth = _gTotalColWidth + colWidth;
                ++col;
                
            }
        }

        protected int GetColWidth(int col, string displayName)
        {
            int count = ((DataView) DgMapInfoStatus.DataSource).Count;
            Graphics graphics = Graphics.FromHwnd(Handle);
            StringFormat format = new StringFormat(StringFormat.GenericTypographic);
            float num1 = graphics.MeasureString(displayName, Font, 500, format).Width;
            try
            {
                int num2 = 0;
                int num3 = count - 1;
                int index = num2;
                while (index <= num3)
                {
                    SizeF sizeF = graphics.MeasureString(DgMapInfoStatus[index, col].ToString(), Font, 500, format);
                    if (sizeF.Width > (double) num1) num1 = sizeF.Width;
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

            return (int) Math.Round(num1 + 10f);
        }
    }
}