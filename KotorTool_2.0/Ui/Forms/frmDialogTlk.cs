// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmDialogTlk
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.FilterDesigner;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.Forms
{
  public class frmDialogTlk : frmParent
  {
    [AccessedThroughProperty("MenuItem3")]
    private MenuItem _MenuItem3;
    [AccessedThroughProperty("miOpenExternal")]
    private MenuItem _miOpenExternal;
    [AccessedThroughProperty("MenuItem5")]
    private MenuItem _MenuItem5;
    [AccessedThroughProperty("miOpenK1")]
    private MenuItem _miOpenK1;
    [AccessedThroughProperty("miQuit")]
    private MenuItem _miQuit;
    [AccessedThroughProperty("btnApplyChanges")]
    private Button _btnApplyChanges;
    [AccessedThroughProperty("tbSoundResRef")]
    private TextBox _tbSoundResRef;
    [AccessedThroughProperty("miSaveAsXML")]
    private MenuItem _miSaveAsXML;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("dgDialogTlk")]
    private DataGrid _dgDialogTlk;
    [AccessedThroughProperty("MainMenu1")]
    private MainMenu _MainMenu1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("tbString")]
    private TextBox _tbString;
    [AccessedThroughProperty("MenuItem1")]
    private MenuItem _MenuItem1;
    [AccessedThroughProperty("miSave")]
    private MenuItem _miSave;
    [AccessedThroughProperty("miOpenK2")]
    private MenuItem _miOpenK2;
    [AccessedThroughProperty("btnFilter")]
    private Button _btnFilter;
    [AccessedThroughProperty("nudEntryNumber")]
    private NumericUpDown _nudEntryNumber;
    [AccessedThroughProperty("btnGoToEntry")]
    private Button _btnGoToEntry;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    private IContainer components;
    private DataTable dt;
    private DataView DView;
    private RowFilter RF;
    private ClsDialogTlk g_dialogtlk;
    private string g_currentFilePath;
    private int g_currentRow;
    private bool g_useApplyBtn;

    internal virtual Panel Panel1
    {
      get => _Panel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Panel1 == null)
          ;
        _Panel1 = value;
        if (_Panel1 != null)
          ;
      }
    }

    internal virtual DataGrid dgDialogTlk
    {
      get => _dgDialogTlk;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_dgDialogTlk != null)
        {
          _dgDialogTlk.CurrentCellChanged -= dgDialogTlk_CurrentCellChanged;
          _dgDialogTlk.Click -= dgDialogTlk_Click;
        }
        _dgDialogTlk = value;
        if (_dgDialogTlk == null)
          return;
        _dgDialogTlk.CurrentCellChanged += dgDialogTlk_CurrentCellChanged;
        _dgDialogTlk.Click += dgDialogTlk_Click;
      }
    }

    internal virtual TextBox tbString
    {
      get => _tbString;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbString == null)
          ;
        _tbString = value;
        if (_tbString != null)
          ;
      }
    }

    internal virtual NumericUpDown nudEntryNumber
    {
      get => _nudEntryNumber;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudEntryNumber != null)
          _nudEntryNumber.KeyUp -= nudEntryNumber_KeyUp;
        _nudEntryNumber = value;
        if (_nudEntryNumber == null)
          return;
        _nudEntryNumber.KeyUp += nudEntryNumber_KeyUp;
      }
    }

    internal virtual Button btnGoToEntry
    {
      get => _btnGoToEntry;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnGoToEntry != null)
          _btnGoToEntry.Click -= btnGoToEntry_Click;
        _btnGoToEntry = value;
        if (_btnGoToEntry == null)
          return;
        _btnGoToEntry.Click += btnGoToEntry_Click;
      }
    }

    internal virtual Button btnFilter
    {
      get => _btnFilter;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnFilter != null)
          _btnFilter.Click -= btnFilter_Click;
        _btnFilter = value;
        if (_btnFilter == null)
          return;
        _btnFilter.Click += btnFilter_Click;
      }
    }

    internal virtual MainMenu MainMenu1
    {
      get => _MainMenu1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_MainMenu1 == null)
          ;
        _MainMenu1 = value;
        if (_MainMenu1 != null)
          ;
      }
    }

    internal virtual MenuItem MenuItem1
    {
      get => _MenuItem1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_MenuItem1 == null)
          ;
        _MenuItem1 = value;
        if (_MenuItem1 != null)
          ;
      }
    }

    internal virtual MenuItem miOpenExternal
    {
      get => _miOpenExternal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenExternal != null)
          _miOpenExternal.Click -= miOpenExternal_Click;
        _miOpenExternal = value;
        if (_miOpenExternal == null)
          return;
        _miOpenExternal.Click += miOpenExternal_Click;
      }
    }

    internal virtual MenuItem miOpenK1
    {
      get => _miOpenK1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenK1 != null)
          _miOpenK1.Click -= miOpenK1_Click;
        _miOpenK1 = value;
        if (_miOpenK1 == null)
          return;
        _miOpenK1.Click += miOpenK1_Click;
      }
    }

    internal virtual MenuItem miOpenK2
    {
      get => _miOpenK2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miOpenK2 != null)
          _miOpenK2.Click -= miOpenK2_Click;
        _miOpenK2 = value;
        if (_miOpenK2 == null)
          return;
        _miOpenK2.Click += miOpenK2_Click;
      }
    }

    internal virtual MenuItem MenuItem5
    {
      get => _MenuItem5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_MenuItem5 == null)
          ;
        _MenuItem5 = value;
        if (_MenuItem5 != null)
          ;
      }
    }

    internal virtual MenuItem miQuit
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

    internal virtual MenuItem miSaveAsXML
    {
      get => _miSaveAsXML;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_miSaveAsXML != null)
          _miSaveAsXML.Click -= miSaveAsXML_Click;
        _miSaveAsXML = value;
        if (_miSaveAsXML == null)
          return;
        _miSaveAsXML.Click += miSaveAsXML_Click;
      }
    }

    internal virtual MenuItem MenuItem3
    {
      get => _MenuItem3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_MenuItem3 == null)
          ;
        _MenuItem3 = value;
        if (_MenuItem3 != null)
          ;
      }
    }

    internal virtual TextBox tbSoundResRef
    {
      get => _tbSoundResRef;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbSoundResRef == null)
          ;
        _tbSoundResRef = value;
        if (_tbSoundResRef != null)
          ;
      }
    }

    internal virtual Label Label1
    {
      get => _Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label1 == null)
          ;
        _Label1 = value;
        if (_Label1 != null)
          ;
      }
    }

    internal virtual Label Label3
    {
      get => _Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_Label3 == null)
          ;
        _Label3 = value;
        if (_Label3 != null)
          ;
      }
    }

    internal virtual MenuItem miSave
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

    internal virtual Button btnApplyChanges
    {
      get => _btnApplyChanges;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnApplyChanges != null)
          _btnApplyChanges.Click -= btnApplyChanges_Click;
        _btnApplyChanges = value;
        if (_btnApplyChanges == null)
          return;
        _btnApplyChanges.Click += btnApplyChanges_Click;
      }
    }

    public frmDialogTlk()
    {
      Load += frmDialogTlk_Load;
      dt = new DataTable();
      g_currentRow = -1;
      g_useApplyBtn = true;
      InitializeComponent();
    }

    public frmDialogTlk(string inputpath)
      : this()
    {
      g_currentFilePath = inputpath;
      g_dialogtlk = new ClsDialogTlk(g_currentFilePath, true);
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
      Panel1 = new Panel();
      dgDialogTlk = new DataGrid();
      tbString = new TextBox();
      nudEntryNumber = new NumericUpDown();
      btnGoToEntry = new Button();
      btnFilter = new Button();
      MainMenu1 = new MainMenu();
      MenuItem1 = new MenuItem();
      miOpenExternal = new MenuItem();
      miOpenK1 = new MenuItem();
      miOpenK2 = new MenuItem();
      MenuItem3 = new MenuItem();
      miSave = new MenuItem();
      miSaveAsXML = new MenuItem();
      MenuItem5 = new MenuItem();
      miQuit = new MenuItem();
      this.tbSoundResRef = new TextBox();
      Label1 = new Label();
      Label3 = new Label();
      btnApplyChanges = new Button();
      Panel1.SuspendLayout();
      dgDialogTlk.BeginInit();
      nudEntryNumber.BeginInit();
      SuspendLayout();
      Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      Panel1.Controls.Add(dgDialogTlk);
      Panel panel1_1 = Panel1;
      Point point1 = new Point(16, 24);
      Point point2 = point1;
      panel1_1.Location = point2;
      Panel1.Name = "Panel1";
      Panel panel1_2 = Panel1;
      Size size1 = new Size(608, 200);
      Size size2 = size1;
      panel1_2.Size = size2;
      Panel1.TabIndex = 0;
      dgDialogTlk.CaptionFont = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      dgDialogTlk.DataMember = "";
      dgDialogTlk.Dock = DockStyle.Fill;
      dgDialogTlk.HeaderForeColor = SystemColors.ControlText;
      DataGrid dgDialogTlk1 = dgDialogTlk;
      point1 = new Point(0, 0);
      Point point3 = point1;
      dgDialogTlk1.Location = point3;
      dgDialogTlk.Name = "dgDialogTlk";
      DataGrid dgDialogTlk2 = dgDialogTlk;
      size1 = new Size(608, 200);
      Size size3 = size1;
      dgDialogTlk2.Size = size3;
      dgDialogTlk.TabIndex = 0;
      tbString.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      tbString.Enabled = false;
      TextBox tbString1 = tbString;
      point1 = new Point(144, 248);
      Point point4 = point1;
      tbString1.Location = point4;
      tbString.Multiline = true;
      tbString.Name = "tbString";
      tbString.ScrollBars = ScrollBars.Vertical;
      TextBox tbString2 = tbString;
      size1 = new Size(480, 112);
      Size size4 = size1;
      tbString2.Size = size4;
      tbString.TabIndex = 3;
      tbString.Text = "";
      nudEntryNumber.Enabled = false;
      NumericUpDown nudEntryNumber1 = nudEntryNumber;
      point1 = new Point(160, 0);
      Point point5 = point1;
      nudEntryNumber1.Location = point5;
      nudEntryNumber.Name = "nudEntryNumber";
      NumericUpDown nudEntryNumber2 = nudEntryNumber;
      size1 = new Size(80, 20);
      Size size5 = size1;
      nudEntryNumber2.Size = size5;
      nudEntryNumber.TabIndex = 0;
      nudEntryNumber.TextAlign = HorizontalAlignment.Right;
      btnGoToEntry.Enabled = false;
      Button btnGoToEntry1 = btnGoToEntry;
      point1 = new Point(248, 0);
      Point point6 = point1;
      btnGoToEntry1.Location = point6;
      btnGoToEntry.Name = "btnGoToEntry";
      Button btnGoToEntry2 = btnGoToEntry;
      size1 = new Size(56, 23);
      Size size6 = size1;
      btnGoToEntry2.Size = size6;
      btnGoToEntry.TabIndex = 1;
      btnGoToEntry.Text = "Go";
      btnFilter.Enabled = false;
      Button btnFilter1 = btnFilter;
      point1 = new Point(360, 0);
      Point point7 = point1;
      btnFilter1.Location = point7;
      btnFilter.Name = "btnFilter";
      Button btnFilter2 = btnFilter;
      size1 = new Size(80, 23);
      Size size7 = size1;
      btnFilter2.Size = size7;
      btnFilter.TabIndex = 2;
      btnFilter.Text = "Filter Entries";
      MainMenu1.MenuItems.AddRange(new MenuItem[1]
      {
        MenuItem1
      });
      MenuItem1.Index = 0;
      MenuItem1.MenuItems.AddRange(new MenuItem[8]
      {
        miOpenExternal,
        miOpenK1,
        miOpenK2,
        MenuItem3,
        miSave,
        miSaveAsXML,
        MenuItem5,
        miQuit
      });
      MenuItem1.Text = "&File";
      miOpenExternal.Index = 0;
      miOpenExternal.Shortcut = Shortcut.CtrlO;
      miOpenExternal.Text = "&Open External Dialog.tlk";
      miOpenK1.Index = 1;
      miOpenK1.Shortcut = Shortcut.Ctrl1;
      miOpenK1.Text = "Open KotOR Dialog.tlk";
      miOpenK2.Index = 2;
      miOpenK2.Shortcut = Shortcut.Ctrl2;
      miOpenK2.Text = "Open KotOR II Dialog.tlk";
      MenuItem3.Index = 3;
      MenuItem3.Text = "-";
      miSave.Enabled = false;
      miSave.Index = 4;
      miSave.Shortcut = Shortcut.CtrlS;
      miSave.Text = "Save...";
      miSaveAsXML.Enabled = false;
      miSaveAsXML.Index = 5;
      miSaveAsXML.Text = "Save as XML...";
      MenuItem5.Index = 6;
      MenuItem5.Text = "-";
      miQuit.Index = 7;
      miQuit.Shortcut = Shortcut.CtrlQ;
      miQuit.Text = "&Quit";
      this.tbSoundResRef.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      this.tbSoundResRef.CharacterCasing = CharacterCasing.Lower;
      this.tbSoundResRef.Enabled = false;
      TextBox tbSoundResRef = this.tbSoundResRef;
      point1 = new Point(144, 368);
      Point point8 = point1;
      tbSoundResRef.Location = point8;
      this.tbSoundResRef.MaxLength = 16;
      this.tbSoundResRef.Name = "tbSoundResRef";
      this.tbSoundResRef.TabIndex = 4;
      this.tbSoundResRef.Text = "";
      Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label1_1 = Label1;
      point1 = new Point(32, 256);
      Point point9 = point1;
      label1_1.Location = point9;
      Label1.Name = "Label1";
      Label label1_2 = Label1;
      size1 = new Size(88, 16);
      Size size8 = size1;
      label1_2.Size = size8;
      Label1.TabIndex = 6;
      Label1.Text = "Dialog Text";
      Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Label label3_1 = Label3;
      point1 = new Point(32, 370);
      Point point10 = point1;
      label3_1.Location = point10;
      Label3.Name = "Label3";
      Label label3_2 = Label3;
      size1 = new Size(96, 16);
      Size size9 = size1;
      label3_2.Size = size9;
      Label3.TabIndex = 6;
      Label3.Text = "SoundResRef";
      btnApplyChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      btnApplyChanges.Enabled = false;
      Button btnApplyChanges1 = btnApplyChanges;
      point1 = new Point(488, 368);
      Point point11 = point1;
      btnApplyChanges1.Location = point11;
      btnApplyChanges.Name = "btnApplyChanges";
      Button btnApplyChanges2 = btnApplyChanges;
      size1 = new Size(96, 23);
      Size size10 = size1;
      btnApplyChanges2.Size = size10;
      btnApplyChanges.TabIndex = 5;
      btnApplyChanges.Text = "Apply Changes";
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(640, 401);
      ClientSize = size1;
      Controls.Add(Label1);
      Controls.Add(this.tbSoundResRef);
      Controls.Add(btnFilter);
      Controls.Add(btnGoToEntry);
      Controls.Add(nudEntryNumber);
      Controls.Add(tbString);
      Controls.Add(Panel1);
      Controls.Add(Label3);
      Controls.Add(btnApplyChanges);
      Menu = MainMenu1;
      Name = "frmDialogTlk";
      Text = "Dialog.Tlk Editor";
      Panel1.ResumeLayout(false);
      dgDialogTlk.EndInit();
      nudEntryNumber.EndInit();
      ResumeLayout(false);
    }

    private void BuildDataTable()
    {
      dt.Columns.Add(new DataColumn("index", typeof (int)));
      dt.Columns.Add(new DataColumn("Text", typeof (string))
      {
        DefaultValue = ""
      });
      dt.Columns.Add(new DataColumn("SoundRef", typeof (string))
      {
        DefaultValue = ""
      });
    }

    private void BuildDataGrid()
    {
      Panel1.SuspendLayout();
      if (Panel1.Controls.Contains(dgDialogTlk))
        Panel1.Controls.Remove(dgDialogTlk);
      dgDialogTlk = new DataGrid();
      dgDialogTlk.CaptionFont = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      dgDialogTlk.DataMember = "";
      dgDialogTlk.Dock = DockStyle.Fill;
      dgDialogTlk.HeaderForeColor = SystemColors.ControlText;
      dgDialogTlk.Location = new Point(0, 0);
      dgDialogTlk.Name = "dgDialogTlk";
      dgDialogTlk.Size = Panel1.Size;
      dgDialogTlk.TabIndex = 0;
      Panel1.Controls.Add(dgDialogTlk);
      Panel1.ResumeLayout(false);
      DView = dt.DefaultView;
      DView.AllowDelete = true;
      DView.AllowNew = true;
      DView.AllowEdit = true;
      DataGridTableStyle table = new DataGridTableStyle();
      dgDialogTlk.TableStyles.Clear();
      table.MappingName = dt.TableName;
      table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
      DataGridEnableTextBoxColumn enableTextBoxColumn1 = new DataGridEnableTextBoxColumn();
      enableTextBoxColumn1.MappingName = "index";
      enableTextBoxColumn1.HeaderText = "(index)";
      enableTextBoxColumn1.NullText = "";
      enableTextBoxColumn1.ReadOnly = true;
      table.GridColumnStyles.Add(enableTextBoxColumn1);
      DataGridEnableTextBoxColumn enableTextBoxColumn2 = new DataGridEnableTextBoxColumn();
      enableTextBoxColumn2.MappingName = "Text";
      enableTextBoxColumn2.HeaderText = "Text";
      enableTextBoxColumn2.NullText = "";
      enableTextBoxColumn2.Width = 350;
      enableTextBoxColumn2.ReadOnly = true;
      enableTextBoxColumn2.TextBox.Multiline = true;
      enableTextBoxColumn2.TextBox.WordWrap = true;
      table.GridColumnStyles.Add(enableTextBoxColumn2);
      DataGridEnableTextBoxColumn enableTextBoxColumn3 = new DataGridEnableTextBoxColumn();
      enableTextBoxColumn3.MappingName = "SoundRef";
      enableTextBoxColumn3.HeaderText = "SoundRef";
      enableTextBoxColumn3.TextBox.CharacterCasing = CharacterCasing.Lower;
      enableTextBoxColumn3.TextBox.MaxLength = 16;
      enableTextBoxColumn3.ReadOnly = true;
      enableTextBoxColumn3.Width = 120;
      enableTextBoxColumn3.NullText = "";
      table.GridColumnStyles.Add(enableTextBoxColumn3);
      dgDialogTlk.TableStyles.Add(table);
      dgDialogTlk.SetDataBinding(DView, null);
    }

    private void LoadTableAndBuildGrid(ClsDialogTlk dialogtlk)
    {
      frmProgressMeter frmProgressMeter = new frmProgressMeter();
      g_dialogtlk = dialogtlk;
      int num1 = checked ((int) Math.Round(dialogtlk.StringCount / 10.0));
      if (num1 == 0)
        num1 = 1;
      dgDialogTlk.SetDataBinding(null, null);
      dt.Rows.Clear();
      frmProgressMeter.stepAmount = 10;
      frmProgressMeter.message = "Loading";
      ((Control) frmProgressMeter).Location = new UtilWindowRelativePositioner(this, frmProgressMeter).GetConcentric();
      frmProgressMeter.Show();
      int num2 = 0;
      int num3 = checked (dialogtlk.StringCount - 1);
      int StringRef = num2;
      while (StringRef <= num3)
      {
        DataRow row = dt.NewRow();
        DialogTlkStrDataElement tlkStrDataElement = new DialogTlkStrDataElement();
        DialogTlkStrDataElement stringDataElement = dialogtlk.GetStringDataElement(StringRef);
        row[0] = StringRef;
        row[1] = stringDataElement.Text;
        row[2] = stringDataElement.SoundResRef;
        dt.Rows.Add(row);
        if (StringRef / (double) num1 == StringRef / num1)
        {
          frmProgressMeter.stepUp();
          frmProgressMeter.status = "Entry " + StringType.FromInteger(StringRef);
        }
        checked { ++StringRef; }
      }
      frmProgressMeter.Close();
      BuildDataGrid();
      nudEntryNumber.Maximum = new Decimal(checked (dialogtlk.StringCount - 1));
      nudEntryNumber.Enabled = true;
      btnFilter.Enabled = true;
      btnGoToEntry.Enabled = true;
      miSave.Enabled = true;
      miSaveAsXML.Enabled = true;
      tbSoundResRef.Enabled = false;
      tbSoundResRef.Text = "";
      tbString.Enabled = false;
      tbString.Text = "";
    }

    protected void ApplyFilter()
    {
      if (RF != null)
      {
        if (RF.Active)
        {
          try
          {
            DView.RowFilter = StringType.FromObject(RF.FilterString());
            return;
          }
          catch (SyntaxErrorException ex)
          {
            ProjectData.SetProjectError(ex);
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Filter Error");
            ProjectData.ClearProjectError();
            return;
          }
          catch (EvaluateException ex)
          {
            ProjectData.SetProjectError(ex);
            Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Filter Error");
            ProjectData.ClearProjectError();
            return;
          }
        }
      }
      DView.RowFilter = "";
    }

    private void frmDialogTlk_Load(object sender, EventArgs e)
    {
      BuildDataTable();
      miOpenK1.Visible = MainAppState.HasKotor1();
      miOpenK2.Visible = MainAppState.HasKotor2();
      if (g_dialogtlk == null)
        return;
      LoadTableAndBuildGrid(g_dialogtlk);
      dgDialogTlk.CaptionText = g_currentFilePath;
    }

    private void dgDialogTlk_Click(object sender, EventArgs e)
    {
      DataGridCell currentCell = ((DataGrid) sender).CurrentCell;
      DataGrid.HitTestInfo hitTestInfo = dgDialogTlk.HitTest(dgDialogTlk.PointToClient(MousePosition));
      if (hitTestInfo.Type != DataGrid.HitTestType.RowHeader && hitTestInfo.Type != DataGrid.HitTestType.Cell) return;
      tbSoundResRef.Enabled = true;
      tbString.Enabled = true;
      if (hitTestInfo.Row == dt.Rows.Count) return;
      g_currentRow = hitTestInfo.Row;
      RemoveTextChangeHandlers();
      tbString.Text = Strings.Replace(StringType.FromObject(dgDialogTlk[hitTestInfo.Row, 1]), "\n", "\r\n");
      tbSoundResRef.Text = StringType.FromObject(dgDialogTlk[hitTestInfo.Row, 2]);
      tbString.Focus();
      AddTextChangeHandlers();
    }

    private void dgDialogTlk_CurrentCellChanged(object sender, EventArgs e)
    {
      RemoveTextChangeHandlers();
      if (dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 1] != DBNull.Value)
        tbString.Text = Strings.Replace(StringType.FromObject(dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 1]), "\n", "\r\n");
      if (dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 2] != DBNull.Value)
        tbSoundResRef.Text = StringType.FromObject(dgDialogTlk[dgDialogTlk.CurrentCell.RowNumber, 2]);
      tbString.Focus();
      g_currentRow = dgDialogTlk.CurrentCell.RowNumber;
      tbSoundResRef.Enabled = true;
      tbString.Enabled = true;
      AddTextChangeHandlers();
    }

    private void tbString_TextChanged(object sender, EventArgs e)
    {
      btnApplyChanges.Enabled = true;
      if (g_useApplyBtn || g_currentRow != dgDialogTlk.CurrentCell.RowNumber)
        return;
      dgDialogTlk[g_currentRow, 1] = Strings.Replace(tbString.Text, "\r\n", "\n").Trim();
    }

    private void tbSoundResRef_TextChanged(object sender, EventArgs e)
    {
      btnApplyChanges.Enabled = true;
      if (g_useApplyBtn || g_currentRow != dgDialogTlk.CurrentCell.RowNumber)
        return;
      dgDialogTlk[g_currentRow, 2] = tbSoundResRef.Text.Trim();
    }

    private void btnApplyChanges_Click(object sender, EventArgs e)
    {
      if (!g_useApplyBtn || g_currentRow != dgDialogTlk.CurrentCell.RowNumber)
        return;
      dgDialogTlk.TableStyles[0].GridColumnStyles[1].ReadOnly = false;
      dgDialogTlk.TableStyles[0].GridColumnStyles[2].ReadOnly = false;
      dgDialogTlk[g_currentRow, 1] = Strings.Replace(tbString.Text, "\r\n", "\n").Trim();
      dgDialogTlk[g_currentRow, 2] = tbSoundResRef.Text.Trim();
      dgDialogTlk.TableStyles[0].GridColumnStyles[1].ReadOnly = true;
      dgDialogTlk.TableStyles[0].GridColumnStyles[2].ReadOnly = true;
      dgDialogTlk.Select(checked (g_currentRow + 1));
      dgDialogTlk.UnSelect(checked (g_currentRow + 1));
      btnApplyChanges.Enabled = false;
    }

    private void AddTextChangeHandlers()
    {
      tbString.TextChanged += tbSoundResRef_TextChanged;
      tbSoundResRef.TextChanged += tbSoundResRef_TextChanged;
    }

    private void RemoveTextChangeHandlers()
    {
      tbString.TextChanged -= tbSoundResRef_TextChanged;
      tbSoundResRef.TextChanged -= tbSoundResRef_TextChanged;
    }

    private void btnGoToEntry_Click(object sender, EventArgs e)
    {
      int int32 = Convert.ToInt32(nudEntryNumber.Value);
      if (int32 > checked (dt.Rows.Count - 1))
        return;
      dgDialogTlk.CurrentCell = new DataGridCell(int32, 0);
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
      ColumnEntryList columnEntryList = new ColumnEntryList();
      ColumnEntryList ColumnList = new ColumnEntryList();
      ColumnList.Add(new ColumnEntry("index", "(index)", typeof (int)));
      ColumnList.Add(new ColumnEntry("Text", "Text", typeof (string)));
      ColumnList.Add(new ColumnEntry("SoundRef", "SoundRef", typeof (string)));
      frmFilterDesigner frmFilterDesigner = RF != null ? new frmFilterDesigner(ColumnList, RF) : new frmFilterDesigner(ColumnList);
      int num = (int) frmFilterDesigner.ShowDialog(this);
      if (frmFilterDesigner.DialogResult == DialogResult.OK)
      {
        if (frmFilterDesigner.DialogResult == DialogResult.OK && frmFilterDesigner.RF.FilterParts.Count > 0)
        {
          RF = frmFilterDesigner.RF;
          RF.Active = true;
        }
        else if (RF != null)
          RF.Active = false;
      }
      ApplyFilter();
    }

    private void nudEntryNumber_KeyUp(object sender, KeyEventArgs e)
    {
      int int32 = Convert.ToInt32(nudEntryNumber.Value);
      if (int32 > checked (dt.Rows.Count - 1) | int32 < 0)
        return;
      dgDialogTlk.CurrentCell = new DataGridCell(int32, 0);
      nudEntryNumber.Focus();
    }

    private void miOpenExternal_Click(object sender, EventArgs e)
    {
      string startPath = "";
      if (MainAppState.IsOnly1KotOrInstalled())
      {
        if (MainAppState.HasKotor1())
          startPath = ConfigOptions.Paths.KotorLocation(0);
        if (MainAppState.HasKotor2())
          startPath = ConfigOptions.Paths.KotorLocation(1);
      }
      else
        startPath = ConfigOptions.Paths.DefaultImportLocation;
      object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", startPath, "*.tlk", "Open Dialog.Tlk file...", "tlk"));
      if (objectValue.GetType() != typeof (string))
        return;
      string path = StringType.FromObject(objectValue);
      if (!path.ToLower().EndsWith(".tlk") && Interaction.MsgBox("The file you selected does not have a .TLK extension; do you want to open it?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Questionable file extension") == MsgBoxResult.No)
        return;
      LoadTableAndBuildGrid(new ClsDialogTlk(path, true));
      dgDialogTlk.CaptionText = path;
    }

    private void miOpenK1_Click(object sender, EventArgs e)
    {
      LoadTableAndBuildGrid(new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(0) + "\\dialog.tlk", true));
      dgDialogTlk.CaptionText =ConfigOptions.Paths.KotorLocation(0) + "\\dialog.tlk";
    }

    private void miOpenK2_Click(object sender, EventArgs e)
    {
      LoadTableAndBuildGrid(new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(1) + "\\dialog.tlk", true));
      dgDialogTlk.CaptionText = ConfigOptions.Paths.KotorLocation(1) + "\\dialog.tlk";
    }

    private void miSave_Click(object sender, EventArgs e)
    {
      string str = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, "Dialog.tlk", "Save Dialog.tlk file...", "xml"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      g_dialogtlk.ClearTalkEntryList();
      
        foreach (DataRow row in (InternalDataCollectionBase) dt.Rows)
        {
          DialogTlkStrDataElement TalkEntry = new DialogTlkStrDataElement();
          if (StringType.StrCmp(row["Text"].ToString().Trim(), "", false) != 0)
          {
            TalkEntry.Text = StringType.FromObject(row["Text"]);
            TalkEntry.Flags = 1;
          }
          if (StringType.StrCmp(row["SoundRef"].ToString().Trim(), "", false) != 0)
          {
            TalkEntry.SoundResRef = StringType.FromObject(row["SoundRef"]);
            DialogTlkStrDataElement tlkStrDataElement = TalkEntry;
            tlkStrDataElement.Flags = tlkStrDataElement.Flags + 2;
          }
          if (TalkEntry.Flags == 0)
            TalkEntry.Flags = 32768;
          g_dialogtlk.AddTalkEntry(TalkEntry);
        }
     
      g_dialogtlk.WriteListToFile(str);
      dgDialogTlk.CaptionText = str;
    }

    private void miSaveAsXML_Click(object sender, EventArgs e)
    {
      string str = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, "Dialog.tlk.xml", "Save Dialog.tlk XML file...", "xml"));
      if (StringType.StrCmp(str, "", false) == 0)
        return;
      DataSet dataSet = new DataSet("DialogTlkFile");
      dataSet.Tables.Add(dt);
      dataSet.WriteXml(str);
      dataSet.Tables.Remove(dt);
      dataSet.Dispose();
    }

    private void miQuit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
