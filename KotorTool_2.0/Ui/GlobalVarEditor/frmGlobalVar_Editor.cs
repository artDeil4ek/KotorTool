// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmGlobalVar_Editor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.GlobalVarEditor
{
  public class FrmGlobalVarEditor : frmParent
  {
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _mainMenu1;
    [AccessedThroughProperty("sbpString")]
    private StatusBarPanel _sbpString;
    [AccessedThroughProperty("Label1")]
    private Label _label1;
    [AccessedThroughProperty("MenuItem2")]
    private MenuItem _menuItem2;
    [AccessedThroughProperty("sbpLabel")]
    private StatusBarPanel _sbpLabel;
    [AccessedThroughProperty("dgBoolGlobals")]
    private DataGrid _dgBoolGlobals;
    [AccessedThroughProperty("dgNumericGlobals")]
    private DataGrid _dgNumericGlobals;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _tabControl1;
    [AccessedThroughProperty("sbpNumeric")]
    private StatusBarPanel _sbpNumeric;
    [AccessedThroughProperty("TabPage4")]
    private TabPage _tabPage4;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _tabPage1;
    [AccessedThroughProperty("dgStringGlobals")]
    private DataGrid _dgStringGlobals;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _tabPage2;
    [AccessedThroughProperty("miOpenFirst")]
    private MenuItem _miOpenFirst;
    [AccessedThroughProperty("miOpenCompare")]
    private MenuItem _miOpenCompare;
    [AccessedThroughProperty("sbpBool")]
    private StatusBarPanel _sbpBool;
    [AccessedThroughProperty("miShowOnlyDiffs")]
    private MenuItem _miShowOnlyDiffs;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _menuItem1;
    [AccessedThroughProperty("lblFile1")]
    private Label _lblFile1;
    [AccessedThroughProperty("lblFile2")]
    private Label _lblFile2;
    [AccessedThroughProperty("StatusBar")]
    private StatusBar _statusBar;
    [AccessedThroughProperty("Label2")]
    private Label _label2;
    [AccessedThroughProperty("miSave")]
    private MenuItem _miSave;
    [AccessedThroughProperty("MenuItem6")]
    private MenuItem _menuItem6;
    [AccessedThroughProperty("miQuit")]
    private MenuItem _miQuit;
    private IContainer components;
    public ClsGlobalVars Globals;
    public ClsGlobalVars GlobalsCompare;
    public ClsDialogTlk GClsDialogTlk;
    public ChitinKeyProvider GClsChitinKey;
    private DataTable _dtBool;
    private DataTable _dtNumeric;
    private DataTable _dtString;
    private string _gSavePath;
    private bool _bTablesAndGridsBuilt;
    private bool _bShowOnlyDiffs;
    private byte[] _boolArray;
    private byte[] _numericArray;

    internal virtual DataGrid DgBoolGlobals
    {
      get => _dgBoolGlobals;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_dgBoolGlobals == null)
          ;
        _dgBoolGlobals = value;
        if (_dgBoolGlobals != null)
          ;
      }
    }

    internal virtual TabControl TabControl1
    {
      get => _tabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabControl1 == null)
          ;
        _tabControl1 = value;
        if (_tabControl1 != null)
          ;
      }
    }

    internal virtual TabPage TabPage1
    {
      get => _tabPage1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPage1 == null)
          ;
        _tabPage1 = value;
        if (_tabPage1 != null)
          ;
      }
    }

    internal virtual TabPage TabPage2
    {
      get => _tabPage2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPage2 == null)
          ;
        _tabPage2 = value;
        if (_tabPage2 != null)
          ;
      }
    }

    internal virtual DataGrid DgNumericGlobals
    {
      get => _dgNumericGlobals;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_dgNumericGlobals != null)
          _dgNumericGlobals.CurrentCellChanged -= dgNumericGlobals_CurrentCellChanged;
        _dgNumericGlobals = value;
        if (_dgNumericGlobals == null)
          return;
        _dgNumericGlobals.CurrentCellChanged += dgNumericGlobals_CurrentCellChanged;
      }
    }

    internal virtual TabPage TabPage4
    {
      get => _tabPage4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPage4 == null)
          ;
        _tabPage4 = value;
        if (_tabPage4 != null)
          ;
      }
    }

    internal virtual DataGrid DgStringGlobals
    {
      get => _dgStringGlobals;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_dgStringGlobals == null)
          ;
        _dgStringGlobals = value;
        if (_dgStringGlobals != null)
          ;
      }
    }

    internal virtual MainMenu MainMenu1
    {
      get => _mainMenu1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
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
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_menuItem1 == null)
          ;
        _menuItem1 = value;
        if (_menuItem1 != null)
          ;
      }
    }

    internal virtual MenuItem MiOpenFirst
    {
      get => _miOpenFirst;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenFirst != null)
          _miOpenFirst.Click -= miOpenFirst_Click;
        _miOpenFirst = value;
        if (_miOpenFirst == null)
          return;
        _miOpenFirst.Click += miOpenFirst_Click;
      }
    }

    internal virtual MenuItem MiOpenCompare
    {
      get => _miOpenCompare;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenCompare != null)
          _miOpenCompare.Click -= miOpenCompare_Click;
        _miOpenCompare = value;
        if (_miOpenCompare == null)
          return;
        _miOpenCompare.Click += miOpenCompare_Click;
      }
    }

    internal virtual MenuItem MiSave
    {
      get => _miSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miSave != null)
          _miSave.Click -= miSave_Click;
        _miSave = value;
        if (_miSave == null)
          return;
        _miSave.Click += miSave_Click;
      }
    }

    internal virtual MenuItem MiQuit
    {
      get => _miQuit;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miQuit != null)
          _miQuit.Click -= miQuit_Click;
        _miQuit = value;
        if (_miQuit == null)
          return;
        _miQuit.Click += miQuit_Click;
      }
    }

    internal virtual MenuItem MenuItem6
    {
      get => _menuItem6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_menuItem6 == null)
          ;
        _menuItem6 = value;
        if (_menuItem6 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem2
    {
      get => _menuItem2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_menuItem2 == null)
          ;
        _menuItem2 = value;
        if (_menuItem2 != null)
          ;
      }
    }

    internal virtual MenuItem MiShowOnlyDiffs
    {
      get => _miShowOnlyDiffs;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miShowOnlyDiffs != null)
          _miShowOnlyDiffs.Click -= miShowOnlyDiffs_Click;
        _miShowOnlyDiffs = value;
        if (_miShowOnlyDiffs == null)
          return;
        _miShowOnlyDiffs.Click += miShowOnlyDiffs_Click;
      }
    }

    internal virtual Label LblFile1
    {
      get => _lblFile1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblFile1 == null)
          ;
        _lblFile1 = value;
        if (_lblFile1 != null)
          ;
      }
    }

    internal virtual Label LblFile2
    {
      get => _lblFile2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblFile2 == null)
          ;
        _lblFile2 = value;
        if (_lblFile2 != null)
          ;
      }
    }

    internal virtual Label Label1
    {
      get => _label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label1 == null)
          ;
        _label1 = value;
        if (_label1 != null)
          ;
      }
    }

    internal virtual Label Label2
    {
      get => _label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label2 == null)
          ;
        _label2 = value;
        if (_label2 != null)
          ;
      }
    }

    internal virtual StatusBar StatusBar
    {
      get => _statusBar;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_statusBar == null)
          ;
        _statusBar = value;
        if (_statusBar != null)
          ;
      }
    }

    internal virtual StatusBarPanel SbpBool
    {
      get => _sbpBool;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_sbpBool == null)
          ;
        _sbpBool = value;
        if (_sbpBool != null)
          ;
      }
    }

    internal virtual StatusBarPanel SbpNumeric
    {
      get => _sbpNumeric;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_sbpNumeric == null)
          ;
        _sbpNumeric = value;
        if (_sbpNumeric != null)
          ;
      }
    }

    internal virtual StatusBarPanel SbpString
    {
      get => _sbpString;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_sbpString == null)
          ;
        _sbpString = value;
        if (_sbpString != null)
          ;
      }
    }

    internal virtual StatusBarPanel SbpLabel
    {
      get => _sbpLabel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_sbpLabel == null)
          ;
        _sbpLabel = value;
        if (_sbpLabel != null)
          ;
      }
    }

    public FrmGlobalVarEditor()
    {
      Load += frmGlobalVar_Editor_Load;
      Closing += frmGlobalVar_Editor_Closing;
      _dtBool = new DataTable();
      _dtNumeric = new DataTable();
      _dtString = new DataTable();
      _bTablesAndGridsBuilt = false;
      _boolArray = new byte[103];
      _numericArray = new byte[369];
      InitializeComponent();
    }

    public FrmGlobalVarEditor(ClsGlobalVars globalsClass, int kotorVerIndex)
      : this()
    {
      Globals = globalsClass;
      KotorVersionIndex = kotorVerIndex;
      BuildTablesAndGrids();
      FillGrids();
    }

    public FrmGlobalVarEditor(ClsGlobalVars globalsClass, string filepath, int kotorVerIndex)
      : this(globalsClass, kotorVerIndex)
    {
      _gSavePath = filepath;
      Text = "Global Variable Editor  -  " + Strings.Mid(filepath, checked (Strings.InStrRev(filepath, "\\") + 1));
      LblFile1.Text = filepath + "\\GLOBALVARS.res";
      TabControl1.Location = new Point(8, 32);
      TabControl1.Size = new Size(432, 488);
      MiOpenCompare.Enabled = true;
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
      DgBoolGlobals = new DataGrid();
      TabControl1 = new TabControl();
      TabPage1 = new TabPage();
      TabPage2 = new TabPage();
      DgNumericGlobals = new DataGrid();
      TabPage4 = new TabPage();
      DgStringGlobals = new DataGrid();
      MainMenu1 = new MainMenu();
      MenuItem1 = new MenuItem();
      MiOpenFirst = new MenuItem();
      MiOpenCompare = new MenuItem();
      MiSave = new MenuItem();
      MenuItem6 = new MenuItem();
      MiQuit = new MenuItem();
      MenuItem2 = new MenuItem();
      MiShowOnlyDiffs = new MenuItem();
      LblFile1 = new Label();
      LblFile2 = new Label();
      Label1 = new Label();
      Label2 = new Label();
      StatusBar = new StatusBar();
      SbpLabel = new StatusBarPanel();
      SbpBool = new StatusBarPanel();
      SbpNumeric = new StatusBarPanel();
      SbpString = new StatusBarPanel();
      DgBoolGlobals.BeginInit();
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      DgNumericGlobals.BeginInit();
      TabPage4.SuspendLayout();
      DgStringGlobals.BeginInit();
      SbpLabel.BeginInit();
      SbpBool.BeginInit();
      SbpNumeric.BeginInit();
      SbpString.BeginInit();
      SuspendLayout();
      DgBoolGlobals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      DgBoolGlobals.DataMember = "";
      DgBoolGlobals.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgBoolGlobals1 = DgBoolGlobals;
      Point point1 = new Point(8, 8);
      Point point2 = point1;
      dgBoolGlobals1.Location = point2;
      DgBoolGlobals.Name = "dgBoolGlobals";
      DataGrid dgBoolGlobals2 = DgBoolGlobals;
      Size size1 = new Size(408, 448);
      Size size2 = size1;
      dgBoolGlobals2.Size = size2;
      DgBoolGlobals.TabIndex = 0;
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(TabPage1);
      TabControl1.Controls.Add(TabPage2);
      TabControl1.Controls.Add(TabPage4);
      TabControl tabControl11 = TabControl1;
      point1 = new Point(8, 8);
      Point point3 = point1;
      tabControl11.Location = point3;
      TabControl1.Name = "TabControl1";
      TabControl1.SelectedIndex = 0;
      TabControl tabControl12 = TabControl1;
      size1 = new Size(432, 488);
      Size size3 = size1;
      tabControl12.Size = size3;
      TabControl1.TabIndex = 1;
      TabPage1.Controls.Add(DgBoolGlobals);
      TabPage tabPage11 = TabPage1;
      point1 = new Point(4, 22);
      Point point4 = point1;
      ((Control) tabPage11).Location = point4;
      TabPage1.Name = "TabPage1";
      TabPage tabPage12 = TabPage1;
      size1 = new Size(424, 462);
      Size size4 = size1;
      tabPage12.Size = size4;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "Boolean Globals";
      TabPage2.Controls.Add(DgNumericGlobals);
      TabPage tabPage21 = TabPage2;
      point1 = new Point(4, 22);
      Point point5 = point1;
      ((Control) tabPage21).Location = point5;
      TabPage2.Name = "TabPage2";
      TabPage tabPage22 = TabPage2;
      size1 = new Size(424, 462);
      Size size5 = size1;
      tabPage22.Size = size5;
      TabPage2.TabIndex = 1;
      TabPage2.Text = "Numeric Globals";
      DgNumericGlobals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      DgNumericGlobals.DataMember = "";
      DgNumericGlobals.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgNumericGlobals1 = DgNumericGlobals;
      point1 = new Point(8, 8);
      Point point6 = point1;
      dgNumericGlobals1.Location = point6;
      DgNumericGlobals.Name = "dgNumericGlobals";
      DataGrid dgNumericGlobals2 = DgNumericGlobals;
      size1 = new Size(408, 448);
      Size size6 = size1;
      dgNumericGlobals2.Size = size6;
      DgNumericGlobals.TabIndex = 0;
      TabPage4.Controls.Add(DgStringGlobals);
      TabPage tabPage41 = TabPage4;
      point1 = new Point(4, 22);
      Point point7 = point1;
      ((Control) tabPage41).Location = point7;
      TabPage4.Name = "TabPage4";
      TabPage tabPage42 = TabPage4;
      size1 = new Size(424, 462);
      Size size7 = size1;
      tabPage42.Size = size7;
      TabPage4.TabIndex = 3;
      TabPage4.Text = "String Globals";
      DgStringGlobals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      DgStringGlobals.DataMember = "";
      DgStringGlobals.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgStringGlobals1 = DgStringGlobals;
      point1 = new Point(8, 8);
      Point point8 = point1;
      dgStringGlobals1.Location = point8;
      DgStringGlobals.Name = "dgStringGlobals";
      DataGrid dgStringGlobals2 = DgStringGlobals;
      size1 = new Size(408, 448);
      Size size8 = size1;
      dgStringGlobals2.Size = size8;
      DgStringGlobals.TabIndex = 1;
      MainMenu1.MenuItems.AddRange(new MenuItem[2]
      {
        MenuItem1,
        MenuItem2
      });
      MenuItem1.Index = 0;
      MenuItem1.MenuItems.AddRange(new MenuItem[5]
      {
        MiOpenFirst,
        MiOpenCompare,
        MiSave,
        MenuItem6,
        MiQuit
      });
      MenuItem1.Text = "&File";
      MiOpenFirst.Index = 0;
      MiOpenFirst.Shortcut = Shortcut.CtrlO;
      MiOpenFirst.Text = "&Open...";
      MiOpenCompare.Enabled = false;
      MiOpenCompare.Index = 1;
      MiOpenCompare.Text = "Open File to &Compare...";
      MiSave.Index = 2;
      MiSave.Shortcut = Shortcut.CtrlS;
      MiSave.Text = "&Save";
      MenuItem6.Index = 3;
      MenuItem6.Text = "-";
      MiQuit.Index = 4;
      MiQuit.Shortcut = Shortcut.CtrlQ;
      MiQuit.Text = "&Quit";
      MenuItem2.Index = 1;
      MenuItem2.MenuItems.AddRange(new MenuItem[1]
      {
        MiShowOnlyDiffs
      });
      MenuItem2.Text = "&View";
      MiShowOnlyDiffs.Enabled = false;
      MiShowOnlyDiffs.Index = 0;
      MiShowOnlyDiffs.Text = "&Show only differences";
      LblFile1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      LblFile1.BackColor = SystemColors.ActiveCaptionText;
      LblFile1.BorderStyle = BorderStyle.Fixed3D;
      Label lblFile11 = LblFile1;
      point1 = new Point(72, 8);
      Point point9 = point1;
      lblFile11.Location = point9;
      LblFile1.Name = "lblFile1";
      Label lblFile12 = LblFile1;
      size1 = new Size(352, 16);
      Size size9 = size1;
      lblFile12.Size = size9;
      LblFile1.TabIndex = 2;
      LblFile2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      LblFile2.BackColor = SystemColors.ActiveCaptionText;
      LblFile2.BorderStyle = BorderStyle.Fixed3D;
      Label lblFile21 = LblFile2;
      point1 = new Point(72, 32);
      Point point10 = point1;
      lblFile21.Location = point10;
      LblFile2.Name = "lblFile2";
      Label lblFile22 = LblFile2;
      size1 = new Size(352, 16);
      Size size10 = size1;
      lblFile22.Size = size10;
      LblFile2.TabIndex = 2;
      Label label11 = Label1;
      point1 = new Point(25, 8);
      Point point11 = point1;
      label11.Location = point11;
      Label1.Name = "Label1";
      Label label12 = Label1;
      size1 = new Size(48, 16);
      Size size11 = size1;
      label12.Size = size11;
      Label1.TabIndex = 3;
      Label1.Text = "Viewing:";
      Label label21 = Label2;
      point1 = new Point(12, 32);
      Point point12 = point1;
      label21.Location = point12;
      Label2.Name = "Label2";
      Label label22 = Label2;
      size1 = new Size(64, 16);
      Size size12 = size1;
      label22.Size = size12;
      Label2.TabIndex = 3;
      Label2.Text = "Comparing:";
      StatusBar statusBar1 = StatusBar;
      point1 = new Point(0, 507);
      Point point13 = point1;
      statusBar1.Location = point13;
      StatusBar.Name = "StatusBar";
      StatusBar.Panels.AddRange(new StatusBarPanel[4]
      {
        SbpLabel,
        SbpBool,
        SbpNumeric,
        SbpString
      });
      StatusBar.ShowPanels = true;
      StatusBar statusBar2 = StatusBar;
      size1 = new Size(448, 22);
      Size size13 = size1;
      statusBar2.Size = size13;
      StatusBar.SizingGrip = false;
      StatusBar.TabIndex = 4;
      StatusBar.Text = "StatusBar";
      StatusBar.Visible = false;
      SbpLabel.AutoSize = StatusBarPanelAutoSize.Contents;
      SbpLabel.BorderStyle = StatusBarPanelBorderStyle.None;
      SbpLabel.Text = "Differences";
      SbpLabel.Width = 72;
      SbpBool.Alignment = HorizontalAlignment.Right;
      SbpBool.ToolTipText = "Number of differences in Boolean Globals";
      SbpBool.Width = 50;
      SbpNumeric.Alignment = HorizontalAlignment.Right;
      SbpNumeric.ToolTipText = "Number of differences in Numeric Globals";
      SbpNumeric.Width = 50;
      SbpString.Alignment = HorizontalAlignment.Right;
      SbpString.ToolTipText = "Number of differences in String Globals";
      SbpString.Width = 50;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(448, 529);
      ClientSize = size1;
      Controls.Add(StatusBar);
      Controls.Add(TabControl1);
      Controls.Add(LblFile1);
      Controls.Add(Label1);
      Controls.Add(LblFile2);
      Controls.Add(Label2);
      Menu = MainMenu1;
      Name = "FrmGlobalVarEditor";
      SizeGripStyle = SizeGripStyle.Show;
      StartPosition = FormStartPosition.Manual;
      Text = "Global Variable Editor";
      DgBoolGlobals.EndInit();
      TabControl1.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      TabPage2.ResumeLayout(false);
      DgNumericGlobals.EndInit();
      TabPage4.ResumeLayout(false);
      DgStringGlobals.EndInit();
      SbpLabel.EndInit();
      SbpBool.EndInit();
      SbpNumeric.EndInit();
      SbpString.EndInit();
      ResumeLayout(false);
    }

    public void FillGlobalVarArrays()
    {
      _boolArray = (byte[]) LateBinding.LateGet(Globals.GetNodeValue("ValBoolean"), null, "bytes", new object[0], null, null);
      _numericArray = (byte[]) LateBinding.LateGet(Globals.GetNodeValue("ValNumber"), null, "bytes", new object[0], null, null);
    }

    private void BuildTablesAndGrids()
    {
      BuildBoolDataTable();
      BuildBoolDataGrid();
      BuildNumericDataTable();
      BuildNumericDataGrid();
      BuildStringDataTable();
      BuildStringDataGrid();
      _bTablesAndGridsBuilt = true;
    }

    private void ClearTables()
    {
      _dtBool.Rows.Clear();
      _dtNumeric.Rows.Clear();
      _dtString.Rows.Clear();
    }

    public void FillGrids()
    {
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      TabPage4.SuspendLayout();
      DgBoolGlobals.SuspendLayout();
      DgNumericGlobals.SuspendLayout();
      DgStringGlobals.SuspendLayout();
      FillGlobalVarArrays();
      int num1 = 0;
      int num2 = checked (Globals.GetListItemCount("CatBoolean") - 1);
      int bitnum = num1;
      while (bitnum <= num2)
      {
        DataRow row = _dtBool.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("CatBoolean(" + StringType.FromInteger(bitnum) + ").Name"));
        row[1] = GetBit(bitnum, _boolArray);
        _dtBool.Rows.Add(row);
        checked { ++bitnum; }
      }
      AutoSizeColumns(DgBoolGlobals, _dtBool);
      int num3 = 0;
      int num4 = checked (Globals.GetListItemCount("CatNumber") - 1);
      int index = num3;
      while (index <= num4)
      {
        DataRow row = _dtNumeric.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("CatNumber(" + StringType.FromInteger(index) + ").Name"));
        row[1] = _numericArray[index];
        _dtNumeric.Rows.Add(row);
        checked { ++index; }
      }
      AutoSizeColumns(DgNumericGlobals, _dtNumeric);
      int num5 = 0;
      int num6 = checked (Globals.GetListItemCount("CatString") - 1);
      int num7 = num5;
      while (num7 <= num6)
      {
        DataRow row = _dtString.NewRow();
        row[0] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("CatString(" + StringType.FromInteger(num7) + ").Name"));
        row[1] = RuntimeHelpers.GetObjectValue(Globals.GetNodeValue("ValString(" + StringType.FromInteger(num7) + ").String"));
        _dtString.Rows.Add(row);
        checked { ++num7; }
      }
      AutoSizeColumns(DgStringGlobals, _dtString);
      DgBoolGlobals.ResumeLayout();
      DgNumericGlobals.ResumeLayout();
      DgStringGlobals.ResumeLayout();
      TabPage1.ResumeLayout();
      TabPage2.ResumeLayout();
      TabPage4.ResumeLayout();
      TabControl1.ResumeLayout();
    }

    private bool GetBit(int bitnum, byte[] booleanArray)
    {
      int index = checked ((int) Math.Round(Conversion.Int(Math.Floor(bitnum / 8.0))));
      return (booleanArray[index] & (ulong) checked ((long) Math.Round(Math.Pow(2.0, checked (bitnum - index * 8))))) > 0UL;
    }

    private void SetBit(int bitnum, bool state, byte[] booleanArray)
    {
      int index = checked ((int) Math.Round(Conversion.Int(Math.Floor(bitnum / 8.0))));
      byte boolean = booleanArray[index];
      byte num1;
      if (state)
      {
        num1 = checked ((byte) (boolean | (long) Math.Round(Math.Pow(2.0, checked (bitnum - index * 8)))));
      }
      else
      {
        byte num2 = checked ((byte) Math.Round(byte.MaxValue - Math.Pow(2.0, checked (bitnum - index * 8))));
        num1 = (byte) (boolean & num2);
      }
      booleanArray[index] = num1;
    }

    private void SetFilterState(bool active)
    {
      if (active)
      {
        StatusBar.Visible = true;
        _dtBool.AcceptChanges();
        _dtNumeric.AcceptChanges();
        _dtString.AcceptChanges();
        ((DataView) DgBoolGlobals.DataSource).RowFilter = "Active <> Active_Compare";
        SbpBool.Text = StringType.FromInteger(((DataView) DgBoolGlobals.DataSource).Count);
        int num1 = 0;
        int num2 = checked (num1 + ((DataView) DgBoolGlobals.DataSource).Count);
        ((DataView) DgNumericGlobals.DataSource).RowFilter = "Value <> Value_Compare";
        SbpNumeric.Text = StringType.FromInteger(((DataView) DgNumericGlobals.DataSource).Count);
        int num3 = checked (num2 + ((DataView) DgNumericGlobals.DataSource).Count);
        ((DataView) DgStringGlobals.DataSource).RowFilter = "Value <> Value_Compare";
        SbpString.Text = StringType.FromInteger(((DataView) DgStringGlobals.DataSource).Count);
        if (checked (num3 + ((DataView) DgStringGlobals.DataSource).Count) != 0)
          return;
        int num4 = (int) Interaction.MsgBox("Files are identical", MsgBoxStyle.Information, "Note");
      }
      else
      {
        StatusBar.Visible = false;
        ((DataView) DgBoolGlobals.DataSource).RowFilter = "";
        ((DataView) DgNumericGlobals.DataSource).RowFilter = "";
        ((DataView) DgStringGlobals.DataSource).RowFilter = "";
      }
    }

    private void SaveFormData()
    {
      int num1 = 0;
      int num2 = checked (Globals.GetListItemCount("CatBoolean") - 1);
      int bitnum = num1;
      while (bitnum <= num2)
      {
        SetBit(bitnum, BooleanType.FromObject(DgBoolGlobals[bitnum, 1]), _boolArray);
        checked { ++bitnum; }
      }
      LateBinding.LateSetComplex(Globals.GetNodeValue("ValBoolean"), null, "bytes", new object[1]
      {
        _boolArray
      }, null, 0 != 0, 1 != 0);
      int num3 = 0;
      int num4 = Globals.GetListItemCount("CatNumber") - 1;
      int index1 = num3;
      while (index1 <= num4)
      {
        _numericArray[index1] = ByteType.FromObject(DgNumericGlobals[index1, 1]);
        ++index1; 
      }
      LateBinding.LateSetComplex(Globals.GetNodeValue("ValNumber"), null, "bytes", new object[1]
      {
        _numericArray
      }, null, 0 != 0, 1 != 0);
      int num5 = 0;
      int num6 = Globals.GetListItemCount("CatString") - 1;
      int index2 = num5;
      while (index2 <= num6)
      {
        Globals.SetNodeValue("CatString(" + StringType.FromInteger(index2) + ").Name", RuntimeHelpers.GetObjectValue(DgStringGlobals[index2, 0]));
        Globals.SetNodeValue("ValString(" + StringType.FromInteger(index2) + ").String", RuntimeHelpers.GetObjectValue(DgStringGlobals[index2, 1]));
         ++index2; 
      }
      if (StringType.StrCmp(_gSavePath, "", false) == 0)
        _gSavePath = ConfigOptions.Paths.DefaultSaveLocation;
      string str = StringType.FromObject(FileUtils.GetFilePath("save", _gSavePath, "GLOBALVARS.res", "Save Global Variables Table file...", "res"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      Globals.WriteFile(str, "GVT");
    }

    public void BuildBoolDataTable()
    {
      _dtBool.Columns.Add(new DataColumn("Variable", typeof(string)));
      _dtBool.Columns.Add(new DataColumn("Active", typeof(bool)) {DefaultValue = false});
      _dtBool.Columns.Add(new DataColumn("Active_Compare", typeof(bool)) {DefaultValue = false});
    }

    public void BuildBoolDataGrid()
    {
      _dtBool.DefaultView.AllowDelete = false;
      _dtBool.DefaultView.AllowNew = false;
      _dtBool.DefaultView.AllowEdit = true;
     
      DataGridTableStyle table = new DataGridTableStyle();
     
      DgBoolGlobals.TableStyles.Clear();
      table.MappingName = _dtBool.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
     
      DataGridTextBoxColumn gridTextBoxColumn = new DataGridTextBoxColumn {MappingName = "Variable", HeaderText = "Variable", ReadOnly = true};
      table.GridColumnStyles.Add(gridTextBoxColumn);
    
      DataGridBoolColumn dataGridBoolColumn1 = new DataGridBoolColumn {MappingName = "Active", HeaderText = "Active", AllowNull = false};
      table.GridColumnStyles.Add(dataGridBoolColumn1);
     
      DataGridBoolColumn dataGridBoolColumn2 = new DataGridBoolColumn {MappingName = "Active_Compare_off", HeaderText = "Active (Compare)", AllowNull = false};
      table.GridColumnStyles.Add(dataGridBoolColumn2);
   
      DgBoolGlobals.TableStyles.Add(table);
      DgBoolGlobals.SetDataBinding(_dtBool.DefaultView, null);
      DgBoolGlobals.CaptionVisible = false;
    }

    public void BuildNumericDataTable()
    {
      _dtNumeric.Columns.Add(new DataColumn("Variable", typeof (string)));
      _dtNumeric.Columns.Add(new DataColumn("Value", typeof (byte)));
      _dtNumeric.Columns.Add(new DataColumn("Value_Compare", typeof (byte)));
    }

    public void BuildNumericDataGrid()
    {
      _dtNumeric.DefaultView.AllowDelete = false;
      _dtNumeric.DefaultView.AllowNew = false;
      _dtNumeric.DefaultView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      DgNumericGlobals.TableStyles.Clear();
      table.MappingName = _dtNumeric.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn gridTextBoxColumn1 = new DataGridTextBoxColumn();
      gridTextBoxColumn1.MappingName = "Variable";
      gridTextBoxColumn1.HeaderText = "Variable";
      gridTextBoxColumn1.ReadOnly = true;
      table.GridColumnStyles.Add(gridTextBoxColumn1);
      DataGridTextBoxColumn gridTextBoxColumn2 = new DataGridTextBoxColumn();
      gridTextBoxColumn2.MappingName = "Value";
      gridTextBoxColumn2.HeaderText = "Value";
      table.GridColumnStyles.Add(gridTextBoxColumn2);
      DataGridTextBoxColumn gridTextBoxColumn3 = new DataGridTextBoxColumn();
      gridTextBoxColumn3.MappingName = "Value_Compare_off";
      gridTextBoxColumn3.HeaderText = "Value (Compare)";
      table.GridColumnStyles.Add(gridTextBoxColumn3);
      DgNumericGlobals.TableStyles.Add(table);
      DgNumericGlobals.SetDataBinding(_dtNumeric.DefaultView, null);
      DgNumericGlobals.CaptionVisible = false;
    }

    public void BuildStringDataTable()
    {
      _dtString.Columns.Add(new DataColumn("Variable", typeof (string)));
      _dtString.Columns.Add(new DataColumn("Value", typeof (string)));
      _dtString.Columns.Add(new DataColumn("Value_Compare", typeof (string)));
    }

    public void BuildStringDataGrid()
    {
      _dtString.DefaultView.AllowDelete = false;
      _dtString.DefaultView.AllowNew = false;
      _dtString.DefaultView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      DgStringGlobals.TableStyles.Clear();
      table.MappingName = _dtString.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridTextBoxColumn gridTextBoxColumn1 = new DataGridTextBoxColumn();
      gridTextBoxColumn1.MappingName = "Variable";
      gridTextBoxColumn1.HeaderText = "Variable";
      gridTextBoxColumn1.ReadOnly = true;
      table.GridColumnStyles.Add(gridTextBoxColumn1);
      DataGridTextBoxColumn gridTextBoxColumn2 = new DataGridTextBoxColumn();
      gridTextBoxColumn2.MappingName = "Value";
      gridTextBoxColumn2.HeaderText = "Value";
      table.GridColumnStyles.Add(gridTextBoxColumn2);
      DataGridTextBoxColumn gridTextBoxColumn3 = new DataGridTextBoxColumn();
      gridTextBoxColumn3.MappingName = "Value_Compare_off";
      gridTextBoxColumn3.HeaderText = "Value (Compare)";
      table.GridColumnStyles.Add(gridTextBoxColumn3);
      DgStringGlobals.TableStyles.Add(table);
      DgStringGlobals.SetDataBinding(_dtString.DefaultView, null);
      DgStringGlobals.CaptionVisible = false;
    }

    public void AutoSizeColumns(DataGrid dg, DataTable dt)
    {
      int num1 = 0;
      int num2 = checked (dt.Columns.Count - 1);
      int col = num1;
      while (col <= num2)
      {
        dg.TableStyles[0].GridColumnStyles[col].Width = GetColWidth(dg, col, dt.Columns[col].Caption);
        checked { ++col; }
      }
    }

    protected int GetColWidth(DataGrid dg, int col, string displayName)
    {
      int count = ((DataView) dg.DataSource).Count;
      Graphics graphics = Graphics.FromHwnd(Handle);
      StringFormat format = new StringFormat(StringFormat.GenericTypographic);
      float num1 = graphics.MeasureString(displayName, Font, 500, format).Width;
      try
      {
        int num2 = 0;
        int num3 = checked (count - 1);
        int index = num2;
        while (index <= num3)
        {
          SizeF sizeF = graphics.MeasureString(dg[index, col].ToString(), Font, 500, format);
          if (sizeF.Width > (double) num1)
            num1 = sizeF.Width;
          checked { ++index; }
        }
        graphics.Dispose();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        num1 = 75f;
        ProjectData.ClearProjectError();
      }
      return checked ((int) Math.Round(num1 + 15f));
    }

    private void frmGlobalVar_Editor_Load(object sender, EventArgs e)
    {
      PositionWindow(Name);
    }

    private void frmGlobalVar_Editor_Closing(object sender, CancelEventArgs e)
    {
     // SaveSettings(Name);
    }

    private void dgNumericGlobals_CurrentCellChanged(object sender, EventArgs e)
    {
      
        foreach (DataRow row in (InternalDataCollectionBase) _dtNumeric.Rows)
        {
          row.EndEdit();
          bool flag1 = false;
          bool flag2 = false;
          if (row[1] == DBNull.Value) flag1 = true;
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(row[1], 0, false) < 0, ObjectType.ObjTst(row[1], (int) byte.MaxValue, false) > 0))) flag2 = true;
          row.ClearErrors();
          if (flag1) row.SetColumnError(1, "You must enter a numeric value for this item");
          if (flag2) row.SetColumnError(2, "You must enter a numeric value from 0-255 for this item");
        }
     
    }

    private void miOpenFirst_Click(object sender, EventArgs e)
    {
      string str = StringType.FromObject(FileUtils.GetFilePath("load", "", "GLOBALVARS.res", "", ""));
      if (StringType.StrCmp(str, "", false) == 0) return;
      _gSavePath = str;
      LblFile1.Text = str;
      if (!_bTablesAndGridsBuilt) BuildTablesAndGrids();
      else ClearTables();
      FileStream fs = new FileStream(str, FileMode.Open);
      Globals = new ClsGlobalVars(fs, KotorVersionIndex);
      fs.Close();
      FillGrids();
      if (GlobalsCompare != null) SetFilterState(true);
      if (GlobalsCompare == null)
      {
        TabControl1.Location = new Point(8, 32);
        TabControl1.Size = new Size(432, 488);
      }
      MiOpenCompare.Enabled = true;
    }

    private void miOpenCompare_Click(object sender, EventArgs e)
    {
      string str = StringType.FromObject(FileUtils.GetFilePath("load", "", "GLOBALVARS.res", "", ""));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      LblFile2.Text = str;
      TabControl1.Location = new Point(8, 56);
      TabControl1.Size = new Size(432, 464);
      DgBoolGlobals.TableStyles[0].GridColumnStyles[2].MappingName = "Active_Compare";
      AutoSizeColumns(DgBoolGlobals, _dtBool);
      DgNumericGlobals.TableStyles[0].GridColumnStyles[2].MappingName = "Value_Compare";
      AutoSizeColumns(DgNumericGlobals, _dtNumeric);
      DgStringGlobals.TableStyles[0].GridColumnStyles[2].MappingName = "Value_Compare";
      AutoSizeColumns(DgStringGlobals, _dtString);
      GlobalsCompare = new ClsGlobalVars(new FileStream(str, FileMode.Open), KotorVersionIndex);
      byte[] booleanArray = (byte[]) LateBinding.LateGet(GlobalsCompare.GetNodeValue("ValBoolean"), null, "bytes", new object[0], null, null);
      byte[] numArray = (byte[]) LateBinding.LateGet(GlobalsCompare.GetNodeValue("ValNumber"), null, "bytes", new object[0], null, null);
      DataView dataSource1 = (DataView) DgBoolGlobals.DataSource;
      string sort1 = dataSource1.Sort;
      dataSource1.Sort = "";
      dataSource1.RowFilter = "";
      int num1 = 0;
      int num2 = GlobalsCompare.GetListItemCount("CatBoolean") - 1;
      int bitnum = num1;
      while (bitnum <= num2)
      {
        _dtBool.DefaultView[bitnum].Row[2] = GetBit(bitnum, booleanArray);
        ++bitnum; 
      }
      AutoSizeColumns(DgBoolGlobals, _dtBool);
      dataSource1.Sort = sort1;
      DataView dataSource2 = (DataView) DgNumericGlobals.DataSource;
      string sort2 = dataSource2.Sort;
      dataSource2.Sort = "";
      dataSource2.RowFilter = "";
      int num3 = 0;
      int num4 = GlobalsCompare.GetListItemCount("CatNumber") - 1;
      int index1 = num3;
      while (index1 <= num4)
      {
        _dtNumeric.DefaultView[index1].Row[2] = numArray[index1];
        ++index1; 
      }
      AutoSizeColumns(DgNumericGlobals, _dtNumeric);
      dataSource2.Sort = sort2;
      DataView dataSource3 = (DataView) DgStringGlobals.DataSource;
      string sort3 = dataSource3.Sort;
      dataSource3.Sort = string.Empty;
      dataSource3.RowFilter = string.Empty;
     
      int num5 = 0;
      int num6 = GlobalsCompare.GetListItemCount("CatString") - 1;
      int index2 = num5;
      while (index2 <= num6)
      {
        _dtString.DefaultView[index2].Row[2] = RuntimeHelpers.GetObjectValue(GlobalsCompare.GetNodeValue("ValString(" + StringType.FromInteger(index2) + ").String"));
        checked { ++index2; }
      }
      AutoSizeColumns(DgStringGlobals, _dtString);
      dataSource3.Sort = sort3;
      MiShowOnlyDiffs.Enabled = true;
      MiShowOnlyDiffs.Checked = true;
      _bShowOnlyDiffs = true;
      SetFilterState(true);
    }

    private void miShowOnlyDiffs_Click(object sender, EventArgs e)
    {
      _bShowOnlyDiffs = !_bShowOnlyDiffs;
      MiShowOnlyDiffs.Checked = _bShowOnlyDiffs;
      SetFilterState(_bShowOnlyDiffs);
    }

    private void miSave_Click(object sender, EventArgs e)
    {
      SaveFormData();
    }

    private void miQuit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
