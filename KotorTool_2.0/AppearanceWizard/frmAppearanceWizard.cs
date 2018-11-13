using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Forms
{
  public class FrmAppearanceWizard : frmParent
  {
    [AccessedThroughProperty("Label6")]
    private Label _label6;
    [AccessedThroughProperty("Label7")]
    private Label _label7;
    [AccessedThroughProperty("Label8")]
    private Label _label8;
    [AccessedThroughProperty("tbHeadNum")]
    private TextBox _tbHeadNum;
    [AccessedThroughProperty("Label9")]
    private Label _label9;
    [AccessedThroughProperty("Label10")]
    private Label _label10;
    [AccessedThroughProperty("tbName")]
    private TextBox _tbName;
    [AccessedThroughProperty("cmbxGender")]
    private ComboBox _cmbxGender;
    [AccessedThroughProperty("cmbxSizes")]
    private ComboBox _cmbxSizes;
    [AccessedThroughProperty("cmbxEnvMap")]
    private ComboBox _cmbxEnvMap;
    [AccessedThroughProperty("cmbxMovementRate")]
    private ComboBox _cmbxMovementRate;
    [AccessedThroughProperty("cmbxModelType")]
    private ComboBox _cmbxModelType;
    [AccessedThroughProperty("Label2")]
    private Label _label2;
    [AccessedThroughProperty("tbHitRadius")]
    private TextBox _tbHitRadius;
    [AccessedThroughProperty("tbPerspace")]
    private TextBox _tbPerspace;
    [AccessedThroughProperty("Label4")]
    private Label _label4;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _tabControl1;
    [AccessedThroughProperty("Label5")]
    private Label _label5;
    [AccessedThroughProperty("TabPage1")]
    private TabPage _tabPage1;
    [AccessedThroughProperty("tbprefatkdist")]
    private TextBox _tbprefatkdist;
    [AccessedThroughProperty("TabPage2")]
    private TabPage _tabPage2;
    [AccessedThroughProperty("Label13")]
    private Label _label13;
    [AccessedThroughProperty("Label14")]
    private Label _label14;
    [AccessedThroughProperty("Label15")]
    private Label _label15;
    [AccessedThroughProperty("Label16")]
    private Label _label16;
    [AccessedThroughProperty("Label17")]
    private Label _label17;
    [AccessedThroughProperty("Label3")]
    private Label _label3;
    [AccessedThroughProperty("tbBaseModelName")]
    private TextBox _tbBaseModelName;
    [AccessedThroughProperty("Button1")]
    private Button _button1;
    [AccessedThroughProperty("cmbxModelNaming")]
    private ComboBox _cmbxModelNaming;
    [AccessedThroughProperty("Label18")]
    private Label _label18;
    [AccessedThroughProperty("Label19")]
    private Label _label19;
    [AccessedThroughProperty("Label20")]
    private Label _label20;
    [AccessedThroughProperty("tbCreperspace")]
    private TextBox _tbCreperspace;
    [AccessedThroughProperty("Label21")]
    private Label _label21;
    [AccessedThroughProperty("Label22")]
    private Label _label22;
    [AccessedThroughProperty("Label23")]
    private Label _label23;
    [AccessedThroughProperty("Label24")]
    private Label _label24;
    [AccessedThroughProperty("tbMa")]
    private TextBox _tbMa;
    [AccessedThroughProperty("tbTa")]
    private TextBox _tbTa;
    [AccessedThroughProperty("tbMb")]
    private TextBox _tbMb;
    [AccessedThroughProperty("tbTb")]
    private TextBox _tbTb;
    [AccessedThroughProperty("tbTd")]
    private TextBox _tbTd;
    [AccessedThroughProperty("tbMd")]
    private TextBox _tbMd;
    [AccessedThroughProperty("tbMc")]
    private TextBox _tbMc;
    [AccessedThroughProperty("tbTc")]
    private TextBox _tbTc;
    [AccessedThroughProperty("Label11")]
    private Label _label11;
    [AccessedThroughProperty("tbTf")]
    private TextBox _tbTf;
    [AccessedThroughProperty("tbMf")]
    private TextBox _tbMf;
    [AccessedThroughProperty("tbMe")]
    private TextBox _tbMe;
    [AccessedThroughProperty("tbTe")]
    private TextBox _tbTe;
    [AccessedThroughProperty("tbTg")]
    private TextBox _tbTg;
    [AccessedThroughProperty("tbMg")]
    private TextBox _tbMg;
    [AccessedThroughProperty("tbMh")]
    private TextBox _tbMh;
    [AccessedThroughProperty("tbTh")]
    private TextBox _tbTh;
    [AccessedThroughProperty("tbTi")]
    private TextBox _tbTi;
    [AccessedThroughProperty("tbMi")]
    private TextBox _tbMi;
    [AccessedThroughProperty("tbMj")]
    private TextBox _tbMj;
    [AccessedThroughProperty("tbTj")]
    private TextBox _tbTj;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOk;
    [AccessedThroughProperty("tbEvilTexture")]
    private TextBox _tbEvilTexture;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("Label1")]
    private Label _label1;
    [AccessedThroughProperty("chkbAutoCreateSeqEntries")]
    private CheckBox _chkbAutoCreateSeqEntries;
    [AccessedThroughProperty("Label25")]
    private Label _label25;
    [AccessedThroughProperty("Label12")]
    private Label _label12;
    private IContainer components;
    public string AppearanceName;

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

    internal virtual Label Label3
    {
      get => _label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label3 == null)
          ;
        _label3 = value;
        if (_label3 != null)
          ;
      }
    }

    internal virtual Label Label4
    {
      get => _label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label4 == null)
          ;
        _label4 = value;
        if (_label4 != null)
          ;
      }
    }

    internal virtual Label Label5
    {
      get => _label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label5 == null)
          ;
        _label5 = value;
        if (_label5 != null)
          ;
      }
    }

    internal virtual Label Label6
    {
      get => _label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label6 == null)
          ;
        _label6 = value;
        if (_label6 != null)
          ;
      }
    }

    internal virtual Label Label7
    {
      get => _label7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label7 == null)
          ;
        _label7 = value;
        if (_label7 != null)
          ;
      }
    }

    internal virtual Label Label8
    {
      get => _label8;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label8 == null)
          ;
        _label8 = value;
        if (_label8 != null)
          ;
      }
    }

    internal virtual Label Label9
    {
      get => _label9;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label9 == null)
          ;
        _label9 = value;
        if (_label9 != null)
          ;
      }
    }

    internal virtual Label Label10
    {
      get => _label10;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label10 == null)
          ;
        _label10 = value;
        if (_label10 != null)
          ;
      }
    }

    internal virtual TextBox TbName
    {
      get => _tbName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbName == null)
          ;
        _tbName = value;
        if (_tbName != null)
          ;
      }
    }

    internal virtual ComboBox CmbxGender
    {
      get => _cmbxGender;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxGender == null)
          ;
        _cmbxGender = value;
        if (_cmbxGender != null)
          ;
      }
    }

    internal virtual ComboBox CmbxSizes
    {
      get => _cmbxSizes;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxSizes == null)
          ;
        _cmbxSizes = value;
        if (_cmbxSizes != null)
          ;
      }
    }

    internal virtual ComboBox CmbxEnvMap
    {
      get => _cmbxEnvMap;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxEnvMap == null)
          ;
        _cmbxEnvMap = value;
        if (_cmbxEnvMap != null)
          ;
      }
    }

    internal virtual ComboBox CmbxMovementRate
    {
      get => _cmbxMovementRate;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxMovementRate == null)
          ;
        _cmbxMovementRate = value;
        if (_cmbxMovementRate != null)
          ;
      }
    }

    internal virtual ComboBox CmbxModelType
    {
      get => _cmbxModelType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxModelType == null)
          ;
        _cmbxModelType = value;
        if (_cmbxModelType != null)
          ;
      }
    }

    internal virtual TextBox TbHitRadius
    {
      get => _tbHitRadius;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbHitRadius == null)
          ;
        _tbHitRadius = value;
        if (_tbHitRadius != null)
          ;
      }
    }

    internal virtual TextBox TbPerspace
    {
      get => _tbPerspace;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbPerspace == null)
          ;
        _tbPerspace = value;
        if (_tbPerspace != null)
          ;
      }
    }

    internal virtual TextBox Tbprefatkdist
    {
      get => _tbprefatkdist;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbprefatkdist == null)
          ;
        _tbprefatkdist = value;
        if (_tbprefatkdist != null)
          ;
      }
    }

    internal virtual TextBox TbCreperspace
    {
      get => _tbCreperspace;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbCreperspace == null)
          ;
        _tbCreperspace = value;
        if (_tbCreperspace != null)
          ;
      }
    }

    internal virtual Label Label11
    {
      get => _label11;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label11 == null)
          ;
        _label11 = value;
        if (_label11 != null)
          ;
      }
    }

    internal virtual Button BtnOk
    {
      get => _btnOk;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnOk == null)
          ;
        _btnOk = value;
        if (_btnOk != null)
          ;
      }
    }

    internal virtual Button BtnCancel
    {
      get => _btnCancel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnCancel == null)
          ;
        _btnCancel = value;
        if (_btnCancel != null)
          ;
      }
    }

    internal virtual ComboBox CmbxModelNaming
    {
      get => _cmbxModelNaming;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxModelNaming != null)
          _cmbxModelNaming.SelectedIndexChanged -= cmbxModelNaming_SelectedIndexChanged;
        _cmbxModelNaming = value;
        if (_cmbxModelNaming == null)
          return;
        _cmbxModelNaming.SelectedIndexChanged += cmbxModelNaming_SelectedIndexChanged;
      }
    }

    internal virtual TextBox TbBaseModelName
    {
      get => _tbBaseModelName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbBaseModelName == null)
          ;
        _tbBaseModelName = value;
        if (_tbBaseModelName != null)
          ;
      }
    }

    internal virtual Label Label12
    {
      get => _label12;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label12 == null)
          ;
        _label12 = value;
        if (_label12 != null)
          ;
      }
    }

    internal virtual TextBox TbHeadNum
    {
      get => _tbHeadNum;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbHeadNum == null)
          ;
        _tbHeadNum = value;
        if (_tbHeadNum != null)
          ;
      }
    }

    internal virtual TabControl TabControl1
    {
      get => _tabControl1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabControl1 != null)
          _tabControl1.SelectedIndexChanged -= TabControl1_SelectedIndexChanged;
        _tabControl1 = value;
        if (_tabControl1 == null)
          return;
        _tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
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

    internal virtual Label Label13
    {
      get => _label13;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label13 == null)
          ;
        _label13 = value;
        if (_label13 != null)
          ;
      }
    }

    internal virtual Label Label14
    {
      get => _label14;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label14 == null)
          ;
        _label14 = value;
        if (_label14 != null)
          ;
      }
    }

    internal virtual Label Label15
    {
      get => _label15;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label15 == null)
          ;
        _label15 = value;
        if (_label15 != null)
          ;
      }
    }

    internal virtual Label Label16
    {
      get => _label16;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label16 == null)
          ;
        _label16 = value;
        if (_label16 != null)
          ;
      }
    }

    internal virtual Label Label17
    {
      get => _label17;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label17 == null)
          ;
        _label17 = value;
        if (_label17 != null)
          ;
      }
    }

    internal virtual Label Label18
    {
      get => _label18;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label18 == null)
          ;
        _label18 = value;
        if (_label18 != null)
          ;
      }
    }

    internal virtual Label Label19
    {
      get => _label19;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label19 == null)
          ;
        _label19 = value;
        if (_label19 != null)
          ;
      }
    }

    internal virtual Label Label20
    {
      get => _label20;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label20 == null)
          ;
        _label20 = value;
        if (_label20 != null)
          ;
      }
    }

    internal virtual Label Label21
    {
      get => _label21;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label21 == null)
          ;
        _label21 = value;
        if (_label21 != null)
          ;
      }
    }

    internal virtual Label Label22
    {
      get => _label22;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label22 == null)
          ;
        _label22 = value;
        if (_label22 != null)
          ;
      }
    }

    internal virtual Label Label23
    {
      get => _label23;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label23 == null)
          ;
        _label23 = value;
        if (_label23 != null)
          ;
      }
    }

    internal virtual Label Label24
    {
      get => _label24;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label24 == null)
          ;
        _label24 = value;
        if (_label24 != null)
          ;
      }
    }

    internal virtual TextBox TbMa
    {
      get => _tbMa;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMa == null)
          ;
        _tbMa = value;
        if (_tbMa != null)
          ;
      }
    }

    internal virtual TextBox TbTa
    {
      get => _tbTa;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTa == null)
          ;
        _tbTa = value;
        if (_tbTa != null)
          ;
      }
    }

    internal virtual TextBox TbMb
    {
      get => _tbMb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMb == null)
          ;
        _tbMb = value;
        if (_tbMb != null)
          ;
      }
    }

    internal virtual TextBox TbTb
    {
      get => _tbTb;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTb == null)
          ;
        _tbTb = value;
        if (_tbTb != null)
          ;
      }
    }

    internal virtual TextBox TbTd
    {
      get => _tbTd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTd == null)
          ;
        _tbTd = value;
        if (_tbTd != null)
          ;
      }
    }

    internal virtual TextBox TbMd
    {
      get => _tbMd;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMd == null)
          ;
        _tbMd = value;
        if (_tbMd != null)
          ;
      }
    }

    internal virtual TextBox TbMc
    {
      get => _tbMc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMc == null)
          ;
        _tbMc = value;
        if (_tbMc != null)
          ;
      }
    }

    internal virtual TextBox TbTc
    {
      get => _tbTc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTc == null)
          ;
        _tbTc = value;
        if (_tbTc != null)
          ;
      }
    }

    internal virtual TextBox TbTf
    {
      get => _tbTf;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTf == null)
          ;
        _tbTf = value;
        if (_tbTf != null)
          ;
      }
    }

    internal virtual TextBox TbMf
    {
      get => _tbMf;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMf == null)
          ;
        _tbMf = value;
        if (_tbMf != null)
          ;
      }
    }

    internal virtual TextBox TbMe
    {
      get => _tbMe;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMe == null)
          ;
        _tbMe = value;
        if (_tbMe != null)
          ;
      }
    }

    internal virtual TextBox TbTe
    {
      get => _tbTe;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTe == null)
          ;
        _tbTe = value;
        if (_tbTe != null)
          ;
      }
    }

    internal virtual TextBox TbTg
    {
      get => _tbTg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTg == null)
          ;
        _tbTg = value;
        if (_tbTg != null)
          ;
      }
    }

    internal virtual TextBox TbMg
    {
      get => _tbMg;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMg == null)
          ;
        _tbMg = value;
        if (_tbMg != null)
          ;
      }
    }

    internal virtual TextBox TbMh
    {
      get => _tbMh;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMh == null)
          ;
        _tbMh = value;
        if (_tbMh != null)
          ;
      }
    }

    internal virtual TextBox TbTh
    {
      get => _tbTh;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTh == null)
          ;
        _tbTh = value;
        if (_tbTh != null)
          ;
      }
    }

    internal virtual TextBox TbTi
    {
      get => _tbTi;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTi == null)
          ;
        _tbTi = value;
        if (_tbTi != null)
          ;
      }
    }

    internal virtual TextBox TbMi
    {
      get => _tbMi;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMi == null)
          ;
        _tbMi = value;
        if (_tbMi != null)
          ;
      }
    }

    internal virtual TextBox TbMj
    {
      get => _tbMj;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbMj == null)
          ;
        _tbMj = value;
        if (_tbMj != null)
          ;
      }
    }

    internal virtual TextBox TbTj
    {
      get => _tbTj;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTj == null)
          ;
        _tbTj = value;
        if (_tbTj != null)
          ;
      }
    }

    internal virtual TextBox TbEvilTexture
    {
      get => _tbEvilTexture;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbEvilTexture == null)
          ;
        _tbEvilTexture = value;
        if (_tbEvilTexture != null)
          ;
      }
    }

    internal virtual Label Label25
    {
      get => _label25;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label25 == null)
          ;
        _label25 = value;
        if (_label25 != null)
          ;
      }
    }

    internal virtual Button Button1
    {
      get => _button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_button1 == null)
          ;
        _button1 = value;
        if (_button1 != null)
          ;
      }
    }

    internal virtual CheckBox ChkbAutoCreateSeqEntries
    {
      get => _chkbAutoCreateSeqEntries;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbAutoCreateSeqEntries != null)
          _chkbAutoCreateSeqEntries.CheckedChanged -= chkbAutoCreateSeqEntires_CheckedChanged;
        _chkbAutoCreateSeqEntries = value;
        if (_chkbAutoCreateSeqEntries == null)
          return;
        _chkbAutoCreateSeqEntries.CheckedChanged += chkbAutoCreateSeqEntires_CheckedChanged;
      }
    }

    public FrmAppearanceWizard()
    {
      Load += frmAppearanceWizard_Load;
      InitializeComponent();
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
      ResourceManager resourceManager = new ResourceManager(typeof (FrmAppearanceWizard));
      TbName = new TextBox();
      CmbxGender = new ComboBox();
      CmbxSizes = new ComboBox();
      CmbxEnvMap = new ComboBox();
      Label1 = new Label();
      Label2 = new Label();
      Label3 = new Label();
      Label4 = new Label();
      Label5 = new Label();
      CmbxMovementRate = new ComboBox();
      CmbxModelType = new ComboBox();
      Label6 = new Label();
      Label7 = new Label();
      Label8 = new Label();
      Label9 = new Label();
      Label10 = new Label();
      TbHitRadius = new TextBox();
      TbPerspace = new TextBox();
      Tbprefatkdist = new TextBox();
      TbCreperspace = new TextBox();
      Label11 = new Label();
      TbBaseModelName = new TextBox();
      CmbxModelNaming = new ComboBox();
      BtnOk = new Button();
      BtnCancel = new Button();
      Label12 = new Label();
      TbHeadNum = new TextBox();
      TabControl1 = new TabControl();
      TabPage1 = new TabPage();
      TabPage2 = new TabPage();
      Button1 = new Button();
      Label15 = new Label();
      Label13 = new Label();
      TbMa = new TextBox();
      TbTa = new TextBox();
      TbMb = new TextBox();
      TbTb = new TextBox();
      TbTd = new TextBox();
      TbMd = new TextBox();
      TbMc = new TextBox();
      TbTc = new TextBox();
      TbTf = new TextBox();
      TbMf = new TextBox();
      TbMe = new TextBox();
      TbTe = new TextBox();
      TbTg = new TextBox();
      TbMg = new TextBox();
      TbMh = new TextBox();
      TbTh = new TextBox();
      TbTi = new TextBox();
      TbMi = new TextBox();
      TbMj = new TextBox();
      TbTj = new TextBox();
      Label14 = new Label();
      Label16 = new Label();
      Label17 = new Label();
      Label18 = new Label();
      Label19 = new Label();
      Label20 = new Label();
      Label21 = new Label();
      Label22 = new Label();
      Label23 = new Label();
      Label24 = new Label();
      TbEvilTexture = new TextBox();
      Label25 = new Label();
      ChkbAutoCreateSeqEntries = new CheckBox();
      TabControl1.SuspendLayout();
      TabPage1.SuspendLayout();
      TabPage2.SuspendLayout();
      SuspendLayout();
      TextBox tbName = TbName;
      Point point1 = new Point(160, 24);
      Point point2 = point1;
      tbName.Location = point2;
      TbName.Name = "tbName";
      TbName.TabIndex = 0;
      TbName.Text = "";
      CmbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
      CmbxGender.Items.AddRange(new object[2]
      {
        "Male",
        "Female"
      });
      ComboBox cmbxGender1 = CmbxGender;
      point1 = new Point(160, 56);
      Point point3 = point1;
      cmbxGender1.Location = point3;
      CmbxGender.Name = "cmbxGender";
      ComboBox cmbxGender2 = CmbxGender;
      Size size1 = new Size(56, 21);
      Size size2 = size1;
      cmbxGender2.Size = size2;
      CmbxGender.TabIndex = 1;
      CmbxSizes.DropDownStyle = ComboBoxStyle.DropDownList;
      CmbxSizes.Items.AddRange(new object[2]
      {
        "1",
        "3"
      });
      ComboBox cmbxSizes1 = CmbxSizes;
      point1 = new Point(160, 168);
      Point point4 = point1;
      cmbxSizes1.Location = point4;
      CmbxSizes.Name = "cmbxSizes";
      CmbxSizes.RightToLeft = RightToLeft.No;
      ComboBox cmbxSizes2 = CmbxSizes;
      size1 = new Size(56, 21);
      Size size3 = size1;
      cmbxSizes2.Size = size3;
      CmbxSizes.TabIndex = 5;
      CmbxEnvMap.DropDownStyle = ComboBoxStyle.DropDownList;
      CmbxEnvMap.Items.AddRange(new object[3]
      {
        "DEFAULT",
        "CM_BareMetal",
        "CM_MANUN"
      });
      ComboBox cmbxEnvMap1 = CmbxEnvMap;
      point1 = new Point(160, 200);
      Point point5 = point1;
      cmbxEnvMap1.Location = point5;
      CmbxEnvMap.Name = "cmbxEnvMap";
      CmbxEnvMap.RightToLeft = RightToLeft.No;
      ComboBox cmbxEnvMap2 = CmbxEnvMap;
      size1 = new Size(128, 21);
      Size size4 = size1;
      cmbxEnvMap2.Size = size4;
      CmbxEnvMap.TabIndex = 6;
      Label label11 = Label1;
      point1 = new Point(16, 24);
      Point point6 = point1;
      label11.Location = point6;
      Label1.Name = "Label1";
      Label label12 = Label1;
      size1 = new Size(100, 16);
      Size size5 = size1;
      label12.Size = size5;
      Label1.TabIndex = 3;
      Label1.Text = "Name";
      Label label21 = Label2;
      point1 = new Point(16, 56);
      Point point7 = point1;
      label21.Location = point7;
      Label2.Name = "Label2";
      Label label22 = Label2;
      size1 = new Size(100, 16);
      Size size6 = size1;
      label22.Size = size6;
      Label2.TabIndex = 3;
      Label2.Text = "Gender";
      Label label31 = Label3;
      point1 = new Point(16, 168);
      Point point8 = point1;
      label31.Location = point8;
      Label3.Name = "Label3";
      Label label32 = Label3;
      size1 = new Size(136, 16);
      Size size7 = size1;
      label32.Size = size7;
      Label3.TabIndex = 3;
      Label3.Text = "Number of Sizes to create";
      Label label41 = Label4;
      point1 = new Point(16, 200);
      Point point9 = point1;
      label41.Location = point9;
      Label4.Name = "Label4";
      Label label42 = Label4;
      size1 = new Size(100, 16);
      Size size8 = size1;
      label42.Size = size8;
      Label4.TabIndex = 3;
      Label4.Text = "Environment Map";
      Label label51 = Label5;
      point1 = new Point(16, 232);
      Point point10 = point1;
      label51.Location = point10;
      Label5.Name = "Label5";
      Label label52 = Label5;
      size1 = new Size(100, 16);
      Size size9 = size1;
      label52.Size = size9;
      Label5.TabIndex = 3;
      Label5.Text = "Movement Rate";
      CmbxMovementRate.DropDownStyle = ComboBoxStyle.DropDownList;
      CmbxMovementRate.Items.AddRange(new object[11]
      {
        "No Movement",
        "Wee Folk",
        "Very Slow",
        "Slow",
        "Norm/Default",
        "Fast",
        "Very Fast",
        "Player",
        "Huge",
        "Giant",
        "Fastest"
      });
      ComboBox cmbxMovementRate1 = CmbxMovementRate;
      point1 = new Point(160, 232);
      Point point11 = point1;
      cmbxMovementRate1.Location = point11;
      CmbxMovementRate.Name = "cmbxMovementRate";
      CmbxMovementRate.RightToLeft = RightToLeft.No;
      ComboBox cmbxMovementRate2 = CmbxMovementRate;
      size1 = new Size(128, 21);
      Size size10 = size1;
      cmbxMovementRate2.Size = size10;
      CmbxMovementRate.TabIndex = 7;
      CmbxModelType.DropDownStyle = ComboBoxStyle.DropDownList;
      CmbxModelType.Items.AddRange(new object[4]
      {
        "B",
        "F",
        "L",
        "S"
      });
      ComboBox cmbxModelType1 = CmbxModelType;
      point1 = new Point(160, 264);
      Point point12 = point1;
      cmbxModelType1.Location = point12;
      CmbxModelType.Name = "cmbxModelType";
      CmbxModelType.RightToLeft = RightToLeft.No;
      ComboBox cmbxModelType2 = CmbxModelType;
      size1 = new Size(128, 21);
      Size size11 = size1;
      cmbxModelType2.Size = size11;
      CmbxModelType.TabIndex = 8;
      Label label61 = Label6;
      point1 = new Point(16, 296);
      Point point13 = point1;
      label61.Location = point13;
      Label6.Name = "Label6";
      Label label62 = Label6;
      size1 = new Size(100, 16);
      Size size12 = size1;
      label62.Size = size12;
      Label6.TabIndex = 3;
      Label6.Text = "Hit Radius";
      Label label71 = Label7;
      point1 = new Point(16, 328);
      Point point14 = point1;
      label71.Location = point14;
      Label7.Name = "Label7";
      Label label72 = Label7;
      size1 = new Size(100, 16);
      Size size13 = size1;
      label72.Size = size13;
      Label7.TabIndex = 3;
      Label7.Text = "Personal Space";
      Label label81 = Label8;
      point1 = new Point(16, 360);
      Point point15 = point1;
      label81.Location = point15;
      Label8.Name = "Label8";
      Label label82 = Label8;
      size1 = new Size(128, 16);
      Size size14 = size1;
      label82.Size = size14;
      Label8.TabIndex = 3;
      Label8.Text = "CRep Personal Space";
      Label label91 = Label9;
      point1 = new Point(16, 392);
      Point point16 = point1;
      label91.Location = point16;
      Label9.Name = "Label9";
      Label label92 = Label9;
      size1 = new Size(136, 16);
      Size size15 = size1;
      label92.Size = size15;
      Label9.TabIndex = 3;
      Label9.Text = "Preferred Attack Distance";
      Label label101 = Label10;
      point1 = new Point(16, 264);
      Point point17 = point1;
      label101.Location = point17;
      Label10.Name = "Label10";
      Label label102 = Label10;
      size1 = new Size(100, 16);
      Size size16 = size1;
      label102.Size = size16;
      Label10.TabIndex = 3;
      Label10.Text = "Model Type";
      TextBox tbHitRadius1 = TbHitRadius;
      point1 = new Point(160, 296);
      Point point18 = point1;
      tbHitRadius1.Location = point18;
      TbHitRadius.Name = "tbHitRadius";
      TextBox tbHitRadius2 = TbHitRadius;
      size1 = new Size(32, 20);
      Size size17 = size1;
      tbHitRadius2.Size = size17;
      TbHitRadius.TabIndex = 9;
      TbHitRadius.Text = "****";
      TbHitRadius.TextAlign = HorizontalAlignment.Right;
      TextBox tbPerspace1 = TbPerspace;
      point1 = new Point(160, 328);
      Point point19 = point1;
      tbPerspace1.Location = point19;
      TbPerspace.Name = "tbPerspace";
      TextBox tbPerspace2 = TbPerspace;
      size1 = new Size(32, 20);
      Size size18 = size1;
      tbPerspace2.Size = size18;
      TbPerspace.TabIndex = 10;
      TbPerspace.Text = "****";
      TbPerspace.TextAlign = HorizontalAlignment.Right;
      TextBox tbprefatkdist1 = Tbprefatkdist;
      point1 = new Point(160, 392);
      Point point20 = point1;
      tbprefatkdist1.Location = point20;
      Tbprefatkdist.Name = "tbprefatkdist";
      TextBox tbprefatkdist2 = Tbprefatkdist;
      size1 = new Size(32, 20);
      Size size19 = size1;
      tbprefatkdist2.Size = size19;
      Tbprefatkdist.TabIndex = 12;
      Tbprefatkdist.Text = "****";
      Tbprefatkdist.TextAlign = HorizontalAlignment.Right;
      TextBox tbCreperspace1 = TbCreperspace;
      point1 = new Point(160, 360);
      Point point21 = point1;
      tbCreperspace1.Location = point21;
      TbCreperspace.Name = "tbCreperspace";
      TextBox tbCreperspace2 = TbCreperspace;
      size1 = new Size(32, 20);
      Size size20 = size1;
      tbCreperspace2.Size = size20;
      TbCreperspace.TabIndex = 11;
      TbCreperspace.Text = "****";
      TbCreperspace.TextAlign = HorizontalAlignment.Right;
      Label label111 = Label11;
      point1 = new Point(16, 120);
      Point point22 = point1;
      label111.Location = point22;
      Label11.Name = "Label11";
      Label label112 = Label11;
      size1 = new Size(100, 16);
      Size size21 = size1;
      label112.Size = size21;
      Label11.TabIndex = 3;
      Label11.Text = "Base Model Name";
      TextBox tbBaseModelName1 = TbBaseModelName;
      point1 = new Point(160, 120);
      Point point23 = point1;
      tbBaseModelName1.Location = point23;
      TbBaseModelName.Name = "tbBaseModelName";
      TextBox tbBaseModelName2 = TbBaseModelName;
      size1 = new Size(56, 20);
      Size size22 = size1;
      tbBaseModelName2.Size = size22;
      TbBaseModelName.TabIndex = 3;
      TbBaseModelName.Text = "";
      CmbxModelNaming.DropDownStyle = ComboBoxStyle.DropDownList;
      CmbxModelNaming.Items.AddRange(new object[2]
      {
        "Use name for all model entries",
        "Create sequential model entries"
      });
      ComboBox cmbxModelNaming1 = CmbxModelNaming;
      point1 = new Point(232, 120);
      Point point24 = point1;
      cmbxModelNaming1.Location = point24;
      CmbxModelNaming.Name = "cmbxModelNaming";
      ComboBox cmbxModelNaming2 = CmbxModelNaming;
      size1 = new Size(184, 21);
      Size size23 = size1;
      cmbxModelNaming2.Size = size23;
      CmbxModelNaming.TabIndex = 4;
      BtnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnOk = BtnOk;
      point1 = new Point(280, 488);
      Point point25 = point1;
      btnOk.Location = point25;
      BtnOk.Name = "btnOK";
      BtnOk.TabIndex = 0;
      BtnOk.Text = "OK";
      BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      BtnCancel.DialogResult = DialogResult.Cancel;
      Button btnCancel = BtnCancel;
      point1 = new Point(368, 488);
      Point point26 = point1;
      btnCancel.Location = point26;
      BtnCancel.Name = "btnCancel";
      BtnCancel.TabIndex = 1;
      BtnCancel.Text = "Cancel";
      Label label121 = Label12;
      point1 = new Point(16, 88);
      Point point27 = point1;
      label121.Location = point27;
      Label12.Name = "Label12";
      Label label122 = Label12;
      size1 = new Size(136, 16);
      Size size24 = size1;
      label122.Size = size24;
      Label12.TabIndex = 3;
      Label12.Text = "Head Number";
      TextBox tbHeadNum1 = TbHeadNum;
      point1 = new Point(160, 88);
      Point point28 = point1;
      tbHeadNum1.Location = point28;
      TbHeadNum.Name = "tbHeadNum";
      TextBox tbHeadNum2 = TbHeadNum;
      size1 = new Size(40, 20);
      Size size25 = size1;
      tbHeadNum2.Size = size25;
      TbHeadNum.TabIndex = 2;
      TbHeadNum.Text = "";
      TbHeadNum.TextAlign = HorizontalAlignment.Right;
      TabControl1.Controls.Add(TabPage1);
      TabControl1.Controls.Add(TabPage2);
      TabControl tabControl11 = TabControl1;
      point1 = new Point(16, 16);
      Point point29 = point1;
      tabControl11.Location = point29;
      TabControl1.Name = "TabControl1";
      TabControl tabControl12 = TabControl1;
      point1 = new Point(10, 3);
      Point point30 = point1;
      tabControl12.Padding = point30;
      TabControl1.SelectedIndex = 0;
      TabControl tabControl13 = TabControl1;
      size1 = new Size(432, 448);
      Size size26 = size1;
      tabControl13.Size = size26;
      TabControl1.TabIndex = 0;
      TabPage1.Controls.Add(ChkbAutoCreateSeqEntries);
      TabPage1.Controls.Add(TbName);
      TabPage1.Controls.Add(TbHeadNum);
      TabPage1.Controls.Add(Label12);
      TabPage1.Controls.Add(CmbxModelNaming);
      TabPage1.Controls.Add(TbBaseModelName);
      TabPage1.Controls.Add(Label11);
      TabPage1.Controls.Add(TbCreperspace);
      TabPage1.Controls.Add(Tbprefatkdist);
      TabPage1.Controls.Add(TbPerspace);
      TabPage1.Controls.Add(TbHitRadius);
      TabPage1.Controls.Add(Label10);
      TabPage1.Controls.Add(Label9);
      TabPage1.Controls.Add(Label8);
      TabPage1.Controls.Add(Label7);
      TabPage1.Controls.Add(Label6);
      TabPage1.Controls.Add(CmbxModelType);
      TabPage1.Controls.Add(CmbxMovementRate);
      TabPage1.Controls.Add(Label5);
      TabPage1.Controls.Add(Label4);
      TabPage1.Controls.Add(Label3);
      TabPage1.Controls.Add(Label2);
      TabPage1.Controls.Add(Label1);
      TabPage1.Controls.Add(CmbxEnvMap);
      TabPage1.Controls.Add(CmbxSizes);
      TabPage1.Controls.Add(CmbxGender);
      TabPage tabPage11 = TabPage1;
      point1 = new Point(4, 22);
      Point point31 = point1;
      ((Control) tabPage11).Location = point31;
      TabPage1.Name = "TabPage1";
      TabPage tabPage12 = TabPage1;
      size1 = new Size(424, 422);
      Size size27 = size1;
      tabPage12.Size = size27;
      TabPage1.TabIndex = 0;
      TabPage1.Text = "General";
      TabPage2.Controls.Add(Button1);
      TabPage2.Controls.Add(Label15);
      TabPage2.Controls.Add(Label13);
      TabPage2.Controls.Add(TbMa);
      TabPage2.Controls.Add(TbTa);
      TabPage2.Controls.Add(TbMb);
      TabPage2.Controls.Add(TbTb);
      TabPage2.Controls.Add(TbTd);
      TabPage2.Controls.Add(TbMd);
      TabPage2.Controls.Add(TbMc);
      TabPage2.Controls.Add(TbTc);
      TabPage2.Controls.Add(TbTf);
      TabPage2.Controls.Add(TbMf);
      TabPage2.Controls.Add(TbMe);
      TabPage2.Controls.Add(TbTe);
      TabPage2.Controls.Add(TbTg);
      TabPage2.Controls.Add(TbMg);
      TabPage2.Controls.Add(TbMh);
      TabPage2.Controls.Add(TbTh);
      TabPage2.Controls.Add(TbTi);
      TabPage2.Controls.Add(TbMi);
      TabPage2.Controls.Add(TbMj);
      TabPage2.Controls.Add(TbTj);
      TabPage2.Controls.Add(Label14);
      TabPage2.Controls.Add(Label16);
      TabPage2.Controls.Add(Label17);
      TabPage2.Controls.Add(Label18);
      TabPage2.Controls.Add(Label19);
      TabPage2.Controls.Add(Label20);
      TabPage2.Controls.Add(Label21);
      TabPage2.Controls.Add(Label22);
      TabPage2.Controls.Add(Label23);
      TabPage2.Controls.Add(Label24);
      TabPage2.Controls.Add(TbEvilTexture);
      TabPage2.Controls.Add(Label25);
      TabPage tabPage21 = TabPage2;
      point1 = new Point(4, 22);
      Point point32 = point1;
      ((Control) tabPage21).Location = point32;
      TabPage2.Name = "TabPage2";
      TabPage tabPage22 = TabPage2;
      size1 = new Size(424, 422);
      Size size28 = size1;
      tabPage22.Size = size28;
      TabPage2.TabIndex = 1;
      TabPage2.Text = "Model/Texture Names";
      Button button11 = Button1;
      point1 = new Point(112, 384);
      Point point33 = point1;
      button11.Location = point33;
      Button1.Name = "Button1";
      Button button12 = Button1;
      size1 = new Size(224, 23);
      Size size29 = size1;
      button12.Size = size29;
      Button1.TabIndex = 21;
      Button1.Text = "Show samples from Base Model Name";
      Label label151 = Label15;
      point1 = new Point(80, 32);
      Point point34 = point1;
      label151.Location = point34;
      Label15.Name = "Label15";
      Label label152 = Label15;
      size1 = new Size(24, 16);
      Size size30 = size1;
      label152.Size = size30;
      Label15.TabIndex = 2;
      Label15.Text = "A";
      Label label131 = Label13;
      point1 = new Point(144, 8);
      Point point35 = point1;
      label131.Location = point35;
      Label13.Name = "Label13";
      Label label132 = Label13;
      size1 = new Size(40, 16);
      Size size31 = size1;
      label132.Size = size31;
      Label13.TabIndex = 1;
      Label13.Text = "Model";
      TextBox tbMa = TbMa;
      point1 = new Point(112, 32);
      Point point36 = point1;
      tbMa.Location = point36;
      TbMa.Name = "tbMa";
      TbMa.RightToLeft = RightToLeft.Yes;
      TbMa.TabIndex = 0;
      TbMa.Text = "";
      TextBox tbTa = TbTa;
      point1 = new Point(232, 32);
      Point point37 = point1;
      tbTa.Location = point37;
      TbTa.Name = "tbTa";
      TbTa.RightToLeft = RightToLeft.Yes;
      TbTa.TabIndex = 1;
      TbTa.Text = "";
      TextBox tbMb = TbMb;
      point1 = new Point(112, 64);
      Point point38 = point1;
      tbMb.Location = point38;
      TbMb.Name = "tbMb";
      TbMb.RightToLeft = RightToLeft.Yes;
      TbMb.TabIndex = 2;
      TbMb.Text = "";
      TextBox tbTb = TbTb;
      point1 = new Point(232, 64);
      Point point39 = point1;
      tbTb.Location = point39;
      TbTb.Name = "tbTb";
      TbTb.RightToLeft = RightToLeft.Yes;
      TbTb.TabIndex = 3;
      TbTb.Text = "";
      TextBox tbTd = TbTd;
      point1 = new Point(232, 128);
      Point point40 = point1;
      tbTd.Location = point40;
      TbTd.Name = "tbTd";
      TbTd.RightToLeft = RightToLeft.Yes;
      TbTd.TabIndex = 7;
      TbTd.Text = "";
      TextBox tbMd = TbMd;
      point1 = new Point(112, 128);
      Point point41 = point1;
      tbMd.Location = point41;
      TbMd.Name = "tbMd";
      TbMd.RightToLeft = RightToLeft.Yes;
      TbMd.TabIndex = 6;
      TbMd.Text = "";
      TextBox tbMc = TbMc;
      point1 = new Point(112, 96);
      Point point42 = point1;
      tbMc.Location = point42;
      TbMc.Name = "tbMc";
      TbMc.RightToLeft = RightToLeft.Yes;
      TbMc.TabIndex = 4;
      TbMc.Text = "";
      TextBox tbTc = TbTc;
      point1 = new Point(232, 96);
      Point point43 = point1;
      tbTc.Location = point43;
      TbTc.Name = "tbTc";
      TbTc.RightToLeft = RightToLeft.Yes;
      TbTc.TabIndex = 5;
      TbTc.Text = "";
      TextBox tbTf = TbTf;
      point1 = new Point(232, 192);
      Point point44 = point1;
      tbTf.Location = point44;
      TbTf.Name = "tbTf";
      TbTf.RightToLeft = RightToLeft.Yes;
      TbTf.TabIndex = 11;
      TbTf.Text = "";
      TextBox tbMf = TbMf;
      point1 = new Point(112, 192);
      Point point45 = point1;
      tbMf.Location = point45;
      TbMf.Name = "tbMf";
      TbMf.RightToLeft = RightToLeft.Yes;
      TbMf.TabIndex = 10;
      TbMf.Text = "";
      TextBox tbMe = TbMe;
      point1 = new Point(112, 160);
      Point point46 = point1;
      tbMe.Location = point46;
      TbMe.Name = "tbMe";
      TbMe.RightToLeft = RightToLeft.Yes;
      TbMe.TabIndex = 8;
      TbMe.Text = "";
      TextBox tbTe = TbTe;
      point1 = new Point(232, 160);
      Point point47 = point1;
      tbTe.Location = point47;
      TbTe.Name = "tbTe";
      TbTe.RightToLeft = RightToLeft.Yes;
      TbTe.TabIndex = 9;
      TbTe.Text = "";
      TextBox tbTg = TbTg;
      point1 = new Point(232, 224);
      Point point48 = point1;
      tbTg.Location = point48;
      TbTg.Name = "tbTg";
      TbTg.RightToLeft = RightToLeft.Yes;
      TbTg.TabIndex = 13;
      TbTg.Text = "";
      TextBox tbMg = TbMg;
      point1 = new Point(112, 224);
      Point point49 = point1;
      tbMg.Location = point49;
      TbMg.Name = "tbMg";
      TbMg.RightToLeft = RightToLeft.Yes;
      TbMg.TabIndex = 12;
      TbMg.Text = "";
      TextBox tbMh = TbMh;
      point1 = new Point(112, 256);
      Point point50 = point1;
      tbMh.Location = point50;
      TbMh.Name = "tbMh";
      TbMh.RightToLeft = RightToLeft.Yes;
      TbMh.TabIndex = 14;
      TbMh.Text = "";
      TextBox tbTh = TbTh;
      point1 = new Point(232, 256);
      Point point51 = point1;
      tbTh.Location = point51;
      TbTh.Name = "tbTh";
      TbTh.RightToLeft = RightToLeft.Yes;
      TbTh.TabIndex = 15;
      TbTh.Text = "";
      TextBox tbTi = TbTi;
      point1 = new Point(232, 288);
      Point point52 = point1;
      tbTi.Location = point52;
      TbTi.Name = "tbTi";
      TbTi.RightToLeft = RightToLeft.Yes;
      TbTi.TabIndex = 17;
      TbTi.Text = "";
      TextBox tbMi = TbMi;
      point1 = new Point(112, 288);
      Point point53 = point1;
      tbMi.Location = point53;
      TbMi.Name = "tbMi";
      TbMi.RightToLeft = RightToLeft.Yes;
      TbMi.TabIndex = 16;
      TbMi.Text = "";
      TextBox tbMj = TbMj;
      point1 = new Point(112, 320);
      Point point54 = point1;
      tbMj.Location = point54;
      TbMj.Name = "tbMj";
      TbMj.RightToLeft = RightToLeft.Yes;
      TbMj.TabIndex = 18;
      TbMj.Text = "";
      TextBox tbTj = TbTj;
      point1 = new Point(232, 320);
      Point point55 = point1;
      tbTj.Location = point55;
      TbTj.Name = "tbTj";
      TbTj.RightToLeft = RightToLeft.Yes;
      TbTj.TabIndex = 19;
      TbTj.Text = "";
      Label label141 = Label14;
      point1 = new Point(256, 8);
      Point point56 = point1;
      label141.Location = point56;
      Label14.Name = "Label14";
      Label label142 = Label14;
      size1 = new Size(48, 16);
      Size size32 = size1;
      label142.Size = size32;
      Label14.TabIndex = 1;
      Label14.Text = "Texture";
      Label label161 = Label16;
      point1 = new Point(80, 64);
      Point point57 = point1;
      label161.Location = point57;
      Label16.Name = "Label16";
      Label label162 = Label16;
      size1 = new Size(24, 16);
      Size size33 = size1;
      label162.Size = size33;
      Label16.TabIndex = 2;
      Label16.Text = "B";
      Label label171 = Label17;
      point1 = new Point(80, 96);
      Point point58 = point1;
      label171.Location = point58;
      Label17.Name = "Label17";
      Label label172 = Label17;
      size1 = new Size(24, 16);
      Size size34 = size1;
      label172.Size = size34;
      Label17.TabIndex = 2;
      Label17.Text = "C";
      Label label181 = Label18;
      point1 = new Point(80, 128);
      Point point59 = point1;
      label181.Location = point59;
      Label18.Name = "Label18";
      Label label182 = Label18;
      size1 = new Size(24, 16);
      Size size35 = size1;
      label182.Size = size35;
      Label18.TabIndex = 2;
      Label18.Text = "D";
      Label label191 = Label19;
      point1 = new Point(80, 256);
      Point point60 = point1;
      label191.Location = point60;
      Label19.Name = "Label19";
      Label label192 = Label19;
      size1 = new Size(24, 16);
      Size size36 = size1;
      label192.Size = size36;
      Label19.TabIndex = 2;
      Label19.Text = "H";
      Label label201 = Label20;
      point1 = new Point(80, 192);
      Point point61 = point1;
      label201.Location = point61;
      Label20.Name = "Label20";
      Label label202 = Label20;
      size1 = new Size(24, 16);
      Size size37 = size1;
      label202.Size = size37;
      Label20.TabIndex = 2;
      Label20.Text = "F";
      Label label211 = Label21;
      point1 = new Point(80, 224);
      Point point62 = point1;
      label211.Location = point62;
      Label21.Name = "Label21";
      Label label212 = Label21;
      size1 = new Size(24, 16);
      Size size38 = size1;
      label212.Size = size38;
      Label21.TabIndex = 2;
      Label21.Text = "G";
      Label label221 = Label22;
      point1 = new Point(80, 160);
      Point point63 = point1;
      label221.Location = point63;
      Label22.Name = "Label22";
      Label label222 = Label22;
      size1 = new Size(24, 16);
      Size size39 = size1;
      label222.Size = size39;
      Label22.TabIndex = 2;
      Label22.Text = "E";
      Label label231 = Label23;
      point1 = new Point(80, 320);
      Point point64 = point1;
      label231.Location = point64;
      Label23.Name = "Label23";
      Label label232 = Label23;
      size1 = new Size(24, 16);
      Size size40 = size1;
      label232.Size = size40;
      Label23.TabIndex = 2;
      Label23.Text = "J";
      Label label241 = Label24;
      point1 = new Point(80, 288);
      Point point65 = point1;
      label241.Location = point65;
      Label24.Name = "Label24";
      Label label242 = Label24;
      size1 = new Size(24, 16);
      Size size41 = size1;
      label242.Size = size41;
      Label24.TabIndex = 2;
      Label24.Text = "I";
      TextBox tbEvilTexture = TbEvilTexture;
      point1 = new Point(112, 352);
      Point point66 = point1;
      tbEvilTexture.Location = point66;
      TbEvilTexture.Name = "tbEvilTexture";
      TbEvilTexture.RightToLeft = RightToLeft.Yes;
      TbEvilTexture.TabIndex = 20;
      TbEvilTexture.Text = "";
      Label label251 = Label25;
      point1 = new Point(32, 352);
      Point point67 = point1;
      label251.Location = point67;
      Label25.Name = "Label25";
      Label label252 = Label25;
      size1 = new Size(64, 16);
      Size size42 = size1;
      label252.Size = size42;
      Label25.TabIndex = 1;
      Label25.Text = "Evil Texture";
      CheckBox createSeqEntries1 = ChkbAutoCreateSeqEntries;
      point1 = new Point(232, 144);
      Point point68 = point1;
      createSeqEntries1.Location = point68;
      ChkbAutoCreateSeqEntries.Name = "chkbAutoCreateSeqEntries";
      CheckBox createSeqEntries2 = ChkbAutoCreateSeqEntries;
      size1 = new Size(184, 16);
      Size size43 = size1;
      createSeqEntries2.Size = size43;
      ChkbAutoCreateSeqEntries.TabIndex = 13;
      ChkbAutoCreateSeqEntries.Text = "Auto-create sequential entries";
      ChkbAutoCreateSeqEntries.Visible = false;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(464, 517);
      ClientSize = size1;
      ControlBox = false;
      Controls.Add(TabControl1);
      Controls.Add(BtnOk);
      Controls.Add(BtnCancel);
     // Icon = (Icon) resourceManager.GetObject("this.Icon");
      Name = "FrmAppearanceWizard";
      SizeGripStyle = SizeGripStyle.Hide;
      Text = "Appearance Wizard";
      TabControl1.ResumeLayout(false);
      TabPage1.ResumeLayout(false);
      TabPage2.ResumeLayout(false);
      ResumeLayout(false);
    }

    private void frmAppearanceWizard_Load(object sender, EventArgs e)
    {
      CmbxEnvMap.SelectedIndex = 0;
      CmbxGender.SelectedIndex = 0;
      CmbxModelNaming.SelectedIndex = 0;
      CmbxModelType.SelectedIndex = 0;
      CmbxMovementRate.SelectedIndex = 4;
      CmbxSizes.SelectedIndex = 1;
      TbHitRadius.Text = "0.25";
      TbPerspace.Text = "0.35";
      TbCreperspace.Text = "0.4";
      Tbprefatkdist.Text = "0.5";
    }

    public string GetSizeString(int index)
    {
      switch (index)
      {
        case 1:
          return "SML";
        case 2:
          return "MED";
        case 3:
          return "LRG";
        default:
          string str = "";
          return str;
      }
    }

    public string GetSizeLetter(int index)
    {
      return Strings.Mid(GetSizeString(index), 1, 1);
    }

    public string GetSpeedString()
    {
      switch (CmbxMovementRate.SelectedIndex)
      {
        case 0:
          return "NOMOVE";
        case 1:
          return "WEE_FOLK";
        case 2:
          return "VSLOW";
        case 3:
          return "SLOW";
        case 4:
          return "NORM";
        case 5:
          return "FAST";
        case 6:
          return "VFAST";
        case 7:
          return "PLAYER";
        case 8:
          return "HUGE";
        case 9:
          return "GIANT";
        case 10:
          return "DFAST";
        default:
          string str = "";
          return str;
      }
    }

    public void FillRowCommonInfo(ref DataRow dr)
    {
      dr[0] = "512";
      dr[1] = "placeholder for name";
      dr[2] = "****";
      dr[3] = "****";
      dr[4] = "1.813";
      dr[5] = "3.96";
      dr[6] = "1.813";
      dr[7] = "3.96";
      dr[8] = "****";
      dr[9] = "B";
      dr[10] = "77";
      dr[11] = "PMBAL";
      dr[12] = "";
      dr[13] = "";
      dr[14] = "";
      dr[15] = "";
      dr[16] = "";
      dr[17] = "";
      dr[18] = "";
      dr[19] = "";
      dr[20] = "";
      dr[21] = "";
      dr[22] = "";
      dr[23] = "";
      dr[24] = "";
      dr[25] = "";
      dr[26] = "";
      dr[27] = "";
      dr[28] = "";
      dr[29] = "";
      dr[30] = "";
      dr[31] = "";
      dr[32] = "****";
      dr[33] = "****";
      dr[34] = "****";
      dr[35] = "****";
      dr[36] = "****";
      dr[37] = "****";
      dr[38] = "DEFAULT";
      dr[39] = "R";
      dr[40] = "****";
      dr[41] = "1";
      dr[42] = "NORM";
      dr[43] = "50";
      dr[44] = "5.4";
      dr[45] = "0.25";
      dr[46] = "0.35";
      dr[47] = "0.4";
      dr[48] = "****";
      dr[49] = "1.6";
      dr[50] = "l";
      dr[51] = "0";
      dr[52] = "20";
      dr[53] = "1";
      dr[54] = "1";
      dr[55] = "****";
      dr[56] = "****";
      dr[57] = "1";
      dr[58] = "3";
      dr[59] = "****";
      dr[60] = "****";
      dr[61] = "****";
      dr[62] = "****";
      dr[63] = "9";
      dr[64] = "0";
      dr[65] = "0";
      dr[66] = "1";
      dr[67] = "30";
      dr[68] = "15";
      dr[69] = "****";
      dr[70] = "1";
      dr[71] = "0.5";
      dr[72] = "0";
      dr[73] = "2";
      dr[74] = "****";
      dr[75] = "****";
      dr[76] = "****";
      dr[77] = "****";
      dr[78] = "****";
      dr[79] = "****";
      dr[80] = "****";
    }

    public void GenerateModelStrings(int size)
    {
      TbMa.Text = TbBaseModelName.Text + "A" + GetSizeLetter(size);
      TbMb.Text = TbBaseModelName.Text + "B" + GetSizeLetter(size);
      TbMc.Text = TbBaseModelName.Text + "C" + GetSizeLetter(size);
      TbMd.Text = TbBaseModelName.Text + "D" + GetSizeLetter(size);
      TbMe.Text = TbBaseModelName.Text + "E" + GetSizeLetter(size);
      TbMf.Text = TbBaseModelName.Text + "F" + GetSizeLetter(size);
      TbMg.Text = TbBaseModelName.Text + "G" + GetSizeLetter(size);
      TbMh.Text = TbBaseModelName.Text + "H" + GetSizeLetter(size);
      TbMi.Text = TbBaseModelName.Text + "I" + GetSizeLetter(size);
      TbMj.Text = TbBaseModelName.Text + "J" + GetSizeLetter(size);
      TbTa.Text = TbBaseModelName.Text + "A";
      TbTb.Text = TbBaseModelName.Text + "B";
      TbTc.Text = TbBaseModelName.Text + "C";
      TbTd.Text = TbBaseModelName.Text + "D";
      TbTe.Text = TbBaseModelName.Text + "E";
      TbTf.Text = TbBaseModelName.Text + "F";
      TbTg.Text = TbBaseModelName.Text + "G";
      TbTh.Text = TbBaseModelName.Text + "H";
      TbTi.Text = TbBaseModelName.Text + "I";
      TbTj.Text = TbBaseModelName.Text + "J";
    }

    public void PropagateBaseModelString()
    {
      SetAllModelStrings(TbBaseModelName.Text);
    }

    public void ClearAllModelStrings()
    {
      SetAllModelStrings("");
    }

    public void SetAllModelStrings(string s)
    {
      TbMa.Text = s;
      TbMb.Text = s;
      TbMc.Text = s;
      TbMd.Text = s;
      TbMe.Text = s;
      TbMf.Text = s;
      TbMg.Text = s;
      TbMh.Text = s;
      TbMi.Text = s;
      TbMj.Text = s;
      TbTa.Text = s;
      TbTb.Text = s;
      TbTc.Text = s;
      TbTd.Text = s;
      TbTe.Text = s;
      TbTf.Text = s;
      TbTg.Text = s;
      TbTh.Text = s;
      TbTi.Text = s;
      TbTj.Text = s;
    }

    private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (StringType.StrCmp(Strings.Trim(TbBaseModelName.Text), "", false) == 0)
        return;
      if (CmbxModelNaming.SelectedIndex == 1)
        GenerateModelStrings(1);
      else
        PropagateBaseModelString();
    }

    private void cmbxModelNaming_SelectedIndexChanged(object sender, EventArgs e)
    {
      ChkbAutoCreateSeqEntries.Visible = CmbxModelNaming.SelectedIndex == 1;
    }

    private void chkbAutoCreateSeqEntires_CheckedChanged(object sender, EventArgs e)
    {
      bool flag = ChkbAutoCreateSeqEntries.Checked;
      TbMa.ReadOnly = flag;
      TbTa.ReadOnly = flag;
      TbEvilTexture.ReadOnly = flag;
      TbMb.ReadOnly = flag;
      TbTb.ReadOnly = flag;
      TbMc.ReadOnly = flag;
      TbTc.ReadOnly = flag;
      TbMd.ReadOnly = flag;
      TbTd.ReadOnly = flag;
      TbMe.ReadOnly = flag;
      TbTe.ReadOnly = flag;
      TbMf.ReadOnly = flag;
      TbTf.ReadOnly = flag;
      TbMg.ReadOnly = flag;
      TbTg.ReadOnly = flag;
      TbMh.ReadOnly = flag;
      TbTh.ReadOnly = flag;
      TbMi.ReadOnly = flag;
      TbTi.ReadOnly = flag;
      TbMj.ReadOnly = flag;
      TbTj.ReadOnly = flag;
    }
  }
}
