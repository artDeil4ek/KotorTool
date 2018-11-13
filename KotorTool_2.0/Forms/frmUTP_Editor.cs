// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmUTP_Editor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Options;
using KotorTool_2._0.TextEditor;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Forms
{
  public class FrmUtpEditor : frmParent
  {
    [AccessedThroughProperty("Label43")]
    private Label _label43;
    [AccessedThroughProperty("Label21")]
    private Label _label21;
    [AccessedThroughProperty("tbKeyName")]
    private TextBox _tbKeyName;
    [AccessedThroughProperty("Label42")]
    private Label _label42;
    [AccessedThroughProperty("Label20")]
    private Label _label20;
    [AccessedThroughProperty("tbComment")]
    private TextBox _tbComment;
    [AccessedThroughProperty("Label41")]
    private Label _label41;
    [AccessedThroughProperty("Label19")]
    private Label _label19;
    [AccessedThroughProperty("tbOnUserDefined")]
    private TextBox _tbOnUserDefined;
    [AccessedThroughProperty("Label38")]
    private Label _label38;
    [AccessedThroughProperty("Label40")]
    private Label _label40;
    [AccessedThroughProperty("Label18")]
    private Label _label18;
    [AccessedThroughProperty("tbOnUnlock")]
    private TextBox _tbOnUnlock;
    [AccessedThroughProperty("tbOnEndDialogue")]
    private TextBox _tbOnEndDialogue;
    [AccessedThroughProperty("tbTag")]
    private TextBox _tbTag;
    [AccessedThroughProperty("tbOnUsed")]
    private TextBox _tbOnUsed;
    [AccessedThroughProperty("tbType")]
    private TextBox _tbType;
    [AccessedThroughProperty("Label17")]
    private Label _label17;
    [AccessedThroughProperty("tbOnTrapTriggered")]
    private TextBox _tbOnTrapTriggered;
    [AccessedThroughProperty("chkbHasInventory")]
    private CheckBox _chkbHasInventory;
    [AccessedThroughProperty("chkbMin1HP")]
    private CheckBox _chkbMin1Hp;
    [AccessedThroughProperty("Label36")]
    private Label _label36;
    [AccessedThroughProperty("Label39")]
    private Label _label39;
    [AccessedThroughProperty("Label16")]
    private Label _label16;
    [AccessedThroughProperty("tbOnSpellCastAt")]
    private TextBox _tbOnSpellCastAt;
    [AccessedThroughProperty("chkbTrapOneShot")]
    private CheckBox _chkbTrapOneShot;
    [AccessedThroughProperty("Label34")]
    private Label _label34;
    [AccessedThroughProperty("btnEditOnUserDefined")]
    private Button _btnEditOnUserDefined;
    [AccessedThroughProperty("chkbTrapFlag")]
    private CheckBox _chkbTrapFlag;
    [AccessedThroughProperty("Label15")]
    private Label _label15;
    [AccessedThroughProperty("tbOnOpen")]
    private TextBox _tbOnOpen;
    [AccessedThroughProperty("Label1")]
    private Label _label1;
    [AccessedThroughProperty("Label14")]
    private Label _label14;
    [AccessedThroughProperty("tbOnMeleeAttacked")]
    private TextBox _tbOnMeleeAttacked;
    [AccessedThroughProperty("chkbPartyInteract")]
    private CheckBox _chkbPartyInteract;
    [AccessedThroughProperty("tbOnInvDisturbed")]
    private TextBox _tbOnInvDisturbed;
    [AccessedThroughProperty("chkbUsable")]
    private CheckBox _chkbUsable;
    [AccessedThroughProperty("btnEditOnUnlock")]
    private Button _btnEditOnUnlock;
    [AccessedThroughProperty("nudTrapType")]
    private NumericUpDown _nudTrapType;
    [AccessedThroughProperty("btnEditOnOpen")]
    private Button _btnEditOnOpen;
    [AccessedThroughProperty("lblTrapDetectable")]
    private Label _lblTrapDetectable;
    [AccessedThroughProperty("Label13")]
    private Label _label13;
    [AccessedThroughProperty("tbOnLock")]
    private TextBox _tbOnLock;
    [AccessedThroughProperty("tbOnDisarm")]
    private TextBox _tbOnDisarm;
    [AccessedThroughProperty("tbOnClosed")]
    private TextBox _tbOnClosed;
    [AccessedThroughProperty("chkbInterruptable")]
    private CheckBox _chkbInterruptable;
    [AccessedThroughProperty("Label37")]
    private Label _label37;
    [AccessedThroughProperty("Label35")]
    private Label _label35;
    [AccessedThroughProperty("btnEditOnDeath")]
    private Button _btnEditOnDeath;
    [AccessedThroughProperty("btnEditOnHeartbeat")]
    private Button _btnEditOnHeartbeat;
    [AccessedThroughProperty("lblBodyVariation")]
    private Label _lblBodyVariation;
    [AccessedThroughProperty("TabControl1")]
    private TabControl _tabControl1;
    [AccessedThroughProperty("lblTextureVariation")]
    private Label _lblTextureVariation;
    [AccessedThroughProperty("btnEditOnMeleeAttacked")]
    private Button _btnEditOnMeleeAttacked;
    [AccessedThroughProperty("nudTrapDetectDC")]
    private NumericUpDown _nudTrapDetectDc;
    [AccessedThroughProperty("Label33")]
    private Label _label33;
    [AccessedThroughProperty("btnEditOnLock")]
    private Button _btnEditOnLock;
    [AccessedThroughProperty("tbOnDeath")]
    private TextBox _tbOnDeath;
    [AccessedThroughProperty("chkbTrapDisarmable")]
    private CheckBox _chkbTrapDisarmable;
    [AccessedThroughProperty("Label3")]
    private Label _label3;
    [AccessedThroughProperty("Label4")]
    private Label _label4;
    [AccessedThroughProperty("Label5")]
    private Label _label5;
    [AccessedThroughProperty("chkbPlotItem")]
    private CheckBox _chkbPlotItem;
    [AccessedThroughProperty("Label12")]
    private Label _label12;
    [AccessedThroughProperty("nudDisarmDC")]
    private NumericUpDown _nudDisarmDc;
    [AccessedThroughProperty("TabPageComments")]
    private TabPage _tabPageComments;
    [AccessedThroughProperty("chkbTrapDetectable")]
    private CheckBox _chkbTrapDetectable;
    [AccessedThroughProperty("Label32")]
    private Label _label32;
    [AccessedThroughProperty("btnEditOnClosed")]
    private Button _btnEditOnClosed;
    [AccessedThroughProperty("TabPageDescription")]
    private TabPage _tabPageDescription;
    [AccessedThroughProperty("btnEditOnEndDialogue")]
    private Button _btnEditOnEndDialogue;
    [AccessedThroughProperty("btnEditOnSpellCastAt")]
    private Button _btnEditOnSpellCastAt;
    [AccessedThroughProperty("TabPageTrap")]
    private TabPage _tabPageTrap;
    [AccessedThroughProperty("btnEditOnUsed")]
    private Button _btnEditOnUsed;
    [AccessedThroughProperty("btnEditOnDamaged")]
    private Button _btnEditOnDamaged;
    [AccessedThroughProperty("tbFaction")]
    private TextBox _tbFaction;
    [AccessedThroughProperty("btnEditOnDisarm")]
    private Button _btnEditOnDisarm;
    [AccessedThroughProperty("tbConversation")]
    private TextBox _tbConversation;
    [AccessedThroughProperty("nudCloseLockDC")]
    private NumericUpDown _nudCloseLockDc;
    [AccessedThroughProperty("btnEditOnTrapTriggered")]
    private Button _btnEditOnTrapTriggered;
    [AccessedThroughProperty("tbDescription")]
    private TextBox _tbDescription;
    [AccessedThroughProperty("cmbxAppearance")]
    private ComboBox _cmbxAppearance;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("TabPageAdvanced")]
    private TabPage _tabPageAdvanced;
    [AccessedThroughProperty("TabPageScripts")]
    private TabPage _tabPageScripts;
    [AccessedThroughProperty("tbTemplateResRef")]
    private TextBox _tbTemplateResRef;
    [AccessedThroughProperty("Label22")]
    private Label _label22;
    [AccessedThroughProperty("Label11")]
    private Label _label11;
    [AccessedThroughProperty("TabPageLock")]
    private TabPage _tabPageLock;
    [AccessedThroughProperty("TabPageBasic")]
    private TabPage _tabPageBasic;
    [AccessedThroughProperty("tbOnDamaged")]
    private TextBox _tbOnDamaged;
    [AccessedThroughProperty("nudOpenLockDC")]
    private NumericUpDown _nudOpenLockDc;
    [AccessedThroughProperty("tbOnHeartbeat")]
    private TextBox _tbOnHeartbeat;
    [AccessedThroughProperty("btnInventory")]
    private Button _btnInventory;
    [AccessedThroughProperty("chkbStatic")]
    private CheckBox _chkbStatic;
    [AccessedThroughProperty("lblOpenLockDC")]
    private Label _lblOpenLockDc;
    [AccessedThroughProperty("lblCloseLockDC")]
    private Label _lblCloseLockDc;
    [AccessedThroughProperty("lblKeyTag")]
    private Label _lblKeyTag;
    [AccessedThroughProperty("btnSave")]
    private Button _btnSave;
    [AccessedThroughProperty("tbAnimationState")]
    private TextBox _tbAnimationState;
    [AccessedThroughProperty("nudRef")]
    private NumericUpDown _nudRef;
    [AccessedThroughProperty("chkbLockable")]
    private CheckBox _chkbLockable;
    [AccessedThroughProperty("tbName")]
    private TextBox _tbName;
    [AccessedThroughProperty("chkbLocked")]
    private CheckBox _chkbLocked;
    [AccessedThroughProperty("nudHardness")]
    private NumericUpDown _nudHardness;
    [AccessedThroughProperty("btnEditOnInvDisturbed")]
    private Button _btnEditOnInvDisturbed;
    [AccessedThroughProperty("nudHP")]
    private NumericUpDown _nudHp;
    [AccessedThroughProperty("nudFort")]
    private NumericUpDown _nudFort;
    [AccessedThroughProperty("Label10")]
    private Label _label10;
    [AccessedThroughProperty("btnDebug")]
    private Button _btnDebug;
    [AccessedThroughProperty("Label8")]
    private Label _label8;
    [AccessedThroughProperty("chkbKeyRequired")]
    private CheckBox _chkbKeyRequired;
    [AccessedThroughProperty("Label6")]
    private Label _label6;
    [AccessedThroughProperty("Label2")]
    private Label _label2;
    [AccessedThroughProperty("btnSetNameLang")]
    private Button _btnSetNameLang;
    [AccessedThroughProperty("nudWill")]
    private NumericUpDown _nudWill;
    [AccessedThroughProperty("chkbAutoRemoveKey")]
    private CheckBox _chkbAutoRemoveKey;
    [AccessedThroughProperty("btnSetDescriptionLang")]
    private Button _btnSetDescriptionLang;
    private IContainer components;
    public ClsUtp Utp;
    public ClsDialogTlk GClsDialogTlk;
    public ClsChitinKey GClsChitinKey;
    private int _descriptionLang;
    private int _nameLang;
    private bool _mBSaveGameMode;

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

    internal virtual TabPage TabPageBasic
    {
      get => _tabPageBasic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageBasic == null)
          ;
        _tabPageBasic = value;
        if (_tabPageBasic != null)
          ;
      }
    }

    internal virtual Button BtnSetNameLang
    {
      get => _btnSetNameLang;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnSetNameLang != null)
          _btnSetNameLang.Click -= btnSetNameLang_Click;
        _btnSetNameLang = value;
        if (_btnSetNameLang == null)
          return;
        _btnSetNameLang.Click += btnSetNameLang_Click;
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

    internal virtual NumericUpDown NudWill
    {
      get => _nudWill;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudWill == null)
          ;
        _nudWill = value;
        if (_nudWill != null)
          ;
      }
    }

    internal virtual NumericUpDown NudFort
    {
      get => _nudFort;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudFort == null)
          ;
        _nudFort = value;
        if (_nudFort != null)
          ;
      }
    }

    internal virtual NumericUpDown NudHp
    {
      get => _nudHp;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudHp == null)
          ;
        _nudHp = value;
        if (_nudHp != null)
          ;
      }
    }

    internal virtual Label LblTextureVariation
    {
      get => _lblTextureVariation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblTextureVariation == null)
          ;
        _lblTextureVariation = value;
        if (_lblTextureVariation != null)
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

    internal virtual NumericUpDown NudHardness
    {
      get => _nudHardness;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudHardness == null)
          ;
        _nudHardness = value;
        if (_nudHardness != null)
          ;
      }
    }

    internal virtual NumericUpDown NudRef
    {
      get => _nudRef;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudRef == null)
          ;
        _nudRef = value;
        if (_nudRef != null)
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

    internal virtual Label LblBodyVariation
    {
      get => _lblBodyVariation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblBodyVariation == null)
          ;
        _lblBodyVariation = value;
        if (_lblBodyVariation != null)
          ;
      }
    }

    internal virtual CheckBox ChkbPlotItem
    {
      get => _chkbPlotItem;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbPlotItem == null)
          ;
        _chkbPlotItem = value;
        if (_chkbPlotItem != null)
          ;
      }
    }

    internal virtual TextBox TbTag
    {
      get => _tbTag;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTag == null)
          ;
        _tbTag = value;
        if (_tbTag != null)
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

    internal virtual CheckBox ChkbStatic
    {
      get => _chkbStatic;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbStatic == null)
          ;
        _chkbStatic = value;
        if (_chkbStatic != null)
          ;
      }
    }

    internal virtual TabPage TabPageLock
    {
      get => _tabPageLock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageLock == null)
          ;
        _tabPageLock = value;
        if (_tabPageLock != null)
          ;
      }
    }

    internal virtual TextBox TbKeyName
    {
      get => _tbKeyName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbKeyName == null)
          ;
        _tbKeyName = value;
        if (_tbKeyName != null)
          ;
      }
    }

    internal virtual Label LblKeyTag
    {
      get => _lblKeyTag;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblKeyTag == null)
          ;
        _lblKeyTag = value;
        if (_lblKeyTag != null)
          ;
      }
    }

    internal virtual NumericUpDown NudCloseLockDc
    {
      get => _nudCloseLockDc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudCloseLockDc == null)
          ;
        _nudCloseLockDc = value;
        if (_nudCloseLockDc != null)
          ;
      }
    }

    internal virtual Label LblCloseLockDc
    {
      get => _lblCloseLockDc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblCloseLockDc == null)
          ;
        _lblCloseLockDc = value;
        if (_lblCloseLockDc != null)
          ;
      }
    }

    internal virtual NumericUpDown NudOpenLockDc
    {
      get => _nudOpenLockDc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudOpenLockDc == null)
          ;
        _nudOpenLockDc = value;
        if (_nudOpenLockDc != null)
          ;
      }
    }

    internal virtual Label LblOpenLockDc
    {
      get => _lblOpenLockDc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblOpenLockDc == null)
          ;
        _lblOpenLockDc = value;
        if (_lblOpenLockDc != null)
          ;
      }
    }

    internal virtual CheckBox ChkbLockable
    {
      get => _chkbLockable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbLockable != null)
          _chkbLockable.CheckedChanged -= chkbLockable_CheckedChanged;
        _chkbLockable = value;
        if (_chkbLockable == null)
          return;
        _chkbLockable.CheckedChanged += chkbLockable_CheckedChanged;
      }
    }

    internal virtual CheckBox ChkbLocked
    {
      get => _chkbLocked;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbLocked != null)
          _chkbLocked.CheckedChanged -= chkbLocked_CheckedChanged;
        _chkbLocked = value;
        if (_chkbLocked == null)
          return;
        _chkbLocked.CheckedChanged += chkbLocked_CheckedChanged;
      }
    }

    internal virtual CheckBox ChkbKeyRequired
    {
      get => _chkbKeyRequired;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbKeyRequired == null)
          ;
        _chkbKeyRequired = value;
        if (_chkbKeyRequired != null)
          ;
      }
    }

    internal virtual CheckBox ChkbAutoRemoveKey
    {
      get => _chkbAutoRemoveKey;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbAutoRemoveKey == null)
          ;
        _chkbAutoRemoveKey = value;
        if (_chkbAutoRemoveKey != null)
          ;
      }
    }

    internal virtual TabPage TabPageScripts
    {
      get => _tabPageScripts;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageScripts == null)
          ;
        _tabPageScripts = value;
        if (_tabPageScripts != null)
          ;
      }
    }

    internal virtual Label Label34
    {
      get => _label34;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label34 == null)
          ;
        _label34 = value;
        if (_label34 != null)
          ;
      }
    }

    internal virtual TextBox TbOnDeath
    {
      get => _tbOnDeath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnDeath == null)
          ;
        _tbOnDeath = value;
        if (_tbOnDeath != null)
          ;
      }
    }

    internal virtual Label Label33
    {
      get => _label33;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label33 == null)
          ;
        _label33 = value;
        if (_label33 != null)
          ;
      }
    }

    internal virtual TextBox TbOnDamaged
    {
      get => _tbOnDamaged;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnDamaged == null)
          ;
        _tbOnDamaged = value;
        if (_tbOnDamaged != null)
          ;
      }
    }

    internal virtual Label Label32
    {
      get => _label32;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label32 == null)
          ;
        _label32 = value;
        if (_label32 != null)
          ;
      }
    }

    internal virtual TextBox TbOnClosed
    {
      get => _tbOnClosed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnClosed == null)
          ;
        _tbOnClosed = value;
        if (_tbOnClosed != null)
          ;
      }
    }

    internal virtual Label Label35
    {
      get => _label35;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label35 == null)
          ;
        _label35 = value;
        if (_label35 != null)
          ;
      }
    }

    internal virtual TextBox TbOnDisarm
    {
      get => _tbOnDisarm;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnDisarm == null)
          ;
        _tbOnDisarm = value;
        if (_tbOnDisarm != null)
          ;
      }
    }

    internal virtual TextBox TbOnHeartbeat
    {
      get => _tbOnHeartbeat;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnHeartbeat == null)
          ;
        _tbOnHeartbeat = value;
        if (_tbOnHeartbeat != null)
          ;
      }
    }

    internal virtual Label Label36
    {
      get => _label36;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label36 == null)
          ;
        _label36 = value;
        if (_label36 != null)
          ;
      }
    }

    internal virtual Label Label37
    {
      get => _label37;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label37 == null)
          ;
        _label37 = value;
        if (_label37 != null)
          ;
      }
    }

    internal virtual TextBox TbOnLock
    {
      get => _tbOnLock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnLock == null)
          ;
        _tbOnLock = value;
        if (_tbOnLock != null)
          ;
      }
    }

    internal virtual TextBox TbOnMeleeAttacked
    {
      get => _tbOnMeleeAttacked;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnMeleeAttacked == null)
          ;
        _tbOnMeleeAttacked = value;
        if (_tbOnMeleeAttacked != null)
          ;
      }
    }

    internal virtual Label Label38
    {
      get => _label38;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label38 == null)
          ;
        _label38 = value;
        if (_label38 != null)
          ;
      }
    }

    internal virtual TextBox TbOnOpen
    {
      get => _tbOnOpen;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnOpen == null)
          ;
        _tbOnOpen = value;
        if (_tbOnOpen != null)
          ;
      }
    }

    internal virtual Label Label39
    {
      get => _label39;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label39 == null)
          ;
        _label39 = value;
        if (_label39 != null)
          ;
      }
    }

    internal virtual Label Label40
    {
      get => _label40;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label40 == null)
          ;
        _label40 = value;
        if (_label40 != null)
          ;
      }
    }

    internal virtual TextBox TbOnSpellCastAt
    {
      get => _tbOnSpellCastAt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnSpellCastAt == null)
          ;
        _tbOnSpellCastAt = value;
        if (_tbOnSpellCastAt != null)
          ;
      }
    }

    internal virtual Label Label41
    {
      get => _label41;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label41 == null)
          ;
        _label41 = value;
        if (_label41 != null)
          ;
      }
    }

    internal virtual TextBox TbOnTrapTriggered
    {
      get => _tbOnTrapTriggered;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnTrapTriggered == null)
          ;
        _tbOnTrapTriggered = value;
        if (_tbOnTrapTriggered != null)
          ;
      }
    }

    internal virtual TextBox TbOnUnlock
    {
      get => _tbOnUnlock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnUnlock == null)
          ;
        _tbOnUnlock = value;
        if (_tbOnUnlock != null)
          ;
      }
    }

    internal virtual Label Label42
    {
      get => _label42;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label42 == null)
          ;
        _label42 = value;
        if (_label42 != null)
          ;
      }
    }

    internal virtual TextBox TbOnUserDefined
    {
      get => _tbOnUserDefined;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnUserDefined == null)
          ;
        _tbOnUserDefined = value;
        if (_tbOnUserDefined != null)
          ;
      }
    }

    internal virtual Label Label43
    {
      get => _label43;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_label43 == null)
          ;
        _label43 = value;
        if (_label43 != null)
          ;
      }
    }

    internal virtual TabPage TabPageAdvanced
    {
      get => _tabPageAdvanced;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageAdvanced == null)
          ;
        _tabPageAdvanced = value;
        if (_tabPageAdvanced != null)
          ;
      }
    }

    internal virtual TextBox TbConversation
    {
      get => _tbConversation;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbConversation == null)
          ;
        _tbConversation = value;
        if (_tbConversation != null)
          ;
      }
    }

    internal virtual TextBox TbFaction
    {
      get => _tbFaction;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbFaction == null)
          ;
        _tbFaction = value;
        if (_tbFaction != null)
          ;
      }
    }

    internal virtual TextBox TbTemplateResRef
    {
      get => _tbTemplateResRef;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbTemplateResRef == null)
          ;
        _tbTemplateResRef = value;
        if (_tbTemplateResRef != null)
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

    internal virtual TextBox TbAnimationState
    {
      get => _tbAnimationState;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbAnimationState == null)
          ;
        _tbAnimationState = value;
        if (_tbAnimationState != null)
          ;
      }
    }

    internal virtual TabPage TabPageDescription
    {
      get => _tabPageDescription;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageDescription == null)
          ;
        _tabPageDescription = value;
        if (_tabPageDescription != null)
          ;
      }
    }

    internal virtual Button BtnSetDescriptionLang
    {
      get => _btnSetDescriptionLang;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnSetDescriptionLang != null)
          _btnSetDescriptionLang.Click -= btnSetDescLang_Click;
        _btnSetDescriptionLang = value;
        if (_btnSetDescriptionLang == null)
          return;
        _btnSetDescriptionLang.Click += btnSetDescLang_Click;
      }
    }

    internal virtual TextBox TbDescription
    {
      get => _tbDescription;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbDescription == null)
          ;
        _tbDescription = value;
        if (_tbDescription != null)
          ;
      }
    }

    internal virtual TabPage TabPageComments
    {
      get => _tabPageComments;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageComments == null)
          ;
        _tabPageComments = value;
        if (_tabPageComments != null)
          ;
      }
    }

    internal virtual TextBox TbComment
    {
      get => _tbComment;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbComment == null)
          ;
        _tbComment = value;
        if (_tbComment != null)
          ;
      }
    }

    internal virtual Button BtnSave
    {
      get => _btnSave;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnSave != null)
          _btnSave.Click -= btnSave_Click;
        _btnSave = value;
        if (_btnSave == null)
          return;
        _btnSave.Click += btnSave_Click;
      }
    }

    internal virtual Button BtnCancel
    {
      get => _btnCancel;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnCancel != null)
          _btnCancel.Click -= btnCancel_Click;
        _btnCancel = value;
        if (_btnCancel == null)
          return;
        _btnCancel.Click += btnCancel_Click;
      }
    }

    internal virtual CheckBox ChkbMin1Hp
    {
      get => _chkbMin1Hp;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbMin1Hp == null)
          ;
        _chkbMin1Hp = value;
        if (_chkbMin1Hp != null)
          ;
      }
    }

    internal virtual TabPage TabPageTrap
    {
      get => _tabPageTrap;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tabPageTrap == null)
          ;
        _tabPageTrap = value;
        if (_tabPageTrap != null)
          ;
      }
    }

    internal virtual CheckBox ChkbTrapDisarmable
    {
      get => _chkbTrapDisarmable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbTrapDisarmable == null)
          ;
        _chkbTrapDisarmable = value;
        if (_chkbTrapDisarmable != null)
          ;
      }
    }

    internal virtual CheckBox ChkbTrapDetectable
    {
      get => _chkbTrapDetectable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbTrapDetectable == null)
          ;
        _chkbTrapDetectable = value;
        if (_chkbTrapDetectable != null)
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

    internal virtual NumericUpDown NudDisarmDc
    {
      get => _nudDisarmDc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudDisarmDc == null)
          ;
        _nudDisarmDc = value;
        if (_nudDisarmDc != null)
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

    internal virtual NumericUpDown NudTrapDetectDc
    {
      get => _nudTrapDetectDc;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudTrapDetectDc == null)
          ;
        _nudTrapDetectDc = value;
        if (_nudTrapDetectDc != null)
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

    internal virtual Label LblTrapDetectable
    {
      get => _lblTrapDetectable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_lblTrapDetectable == null)
          ;
        _lblTrapDetectable = value;
        if (_lblTrapDetectable != null)
          ;
      }
    }

    internal virtual NumericUpDown NudTrapType
    {
      get => _nudTrapType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_nudTrapType == null)
          ;
        _nudTrapType = value;
        if (_nudTrapType != null)
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

    internal virtual CheckBox ChkbTrapFlag
    {
      get => _chkbTrapFlag;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbTrapFlag == null)
          ;
        _chkbTrapFlag = value;
        if (_chkbTrapFlag != null)
          ;
      }
    }

    internal virtual CheckBox ChkbTrapOneShot
    {
      get => _chkbTrapOneShot;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbTrapOneShot == null)
          ;
        _chkbTrapOneShot = value;
        if (_chkbTrapOneShot != null)
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

    internal virtual ComboBox CmbxAppearance
    {
      get => _cmbxAppearance;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_cmbxAppearance == null)
          ;
        _cmbxAppearance = value;
        if (_cmbxAppearance != null)
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

    internal virtual TextBox TbType
    {
      get => _tbType;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbType == null)
          ;
        _tbType = value;
        if (_tbType != null)
          ;
      }
    }

    internal virtual TextBox TbOnUsed
    {
      get => _tbOnUsed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnUsed == null)
          ;
        _tbOnUsed = value;
        if (_tbOnUsed != null)
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

    internal virtual TextBox TbOnEndDialogue
    {
      get => _tbOnEndDialogue;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnEndDialogue == null)
          ;
        _tbOnEndDialogue = value;
        if (_tbOnEndDialogue != null)
          ;
      }
    }

    internal virtual TextBox TbOnInvDisturbed
    {
      get => _tbOnInvDisturbed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_tbOnInvDisturbed == null)
          ;
        _tbOnInvDisturbed = value;
        if (_tbOnInvDisturbed != null)
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

    internal virtual CheckBox ChkbHasInventory
    {
      get => _chkbHasInventory;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbHasInventory == null)
          ;
        _chkbHasInventory = value;
        if (_chkbHasInventory != null)
          ;
      }
    }

    internal virtual CheckBox ChkbPartyInteract
    {
      get => _chkbPartyInteract;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbPartyInteract == null)
          ;
        _chkbPartyInteract = value;
        if (_chkbPartyInteract != null)
          ;
      }
    }

    internal virtual Button BtnInventory
    {
      get => _btnInventory;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnInventory != null)
          _btnInventory.Click -= btnInventory_Click;
        _btnInventory = value;
        if (_btnInventory == null)
          return;
        _btnInventory.Click += btnInventory_Click;
      }
    }

    internal virtual Button BtnDebug
    {
      get => _btnDebug;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnDebug != null)
          _btnDebug.Click -= btnDebug_Click;
        _btnDebug = value;
        if (_btnDebug == null)
          return;
        _btnDebug.Click += btnDebug_Click;
      }
    }

    internal virtual CheckBox ChkbUsable
    {
      get => _chkbUsable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbUsable == null)
          ;
        _chkbUsable = value;
        if (_chkbUsable != null)
          ;
      }
    }

    internal virtual CheckBox ChkbInterruptable
    {
      get => _chkbInterruptable;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_chkbInterruptable == null)
          ;
        _chkbInterruptable = value;
        if (_chkbInterruptable != null)
          ;
      }
    }

    internal virtual Button BtnEditOnClosed
    {
      get => _btnEditOnClosed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnClosed != null)
          _btnEditOnClosed.Click -= btnEditScript_Click;
        _btnEditOnClosed = value;
        if (_btnEditOnClosed == null)
          return;
        _btnEditOnClosed.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnDamaged
    {
      get => _btnEditOnDamaged;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnDamaged != null)
          _btnEditOnDamaged.Click -= btnEditScript_Click;
        _btnEditOnDamaged = value;
        if (_btnEditOnDamaged == null)
          return;
        _btnEditOnDamaged.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnDeath
    {
      get => _btnEditOnDeath;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnDeath != null)
          _btnEditOnDeath.Click -= btnEditScript_Click;
        _btnEditOnDeath = value;
        if (_btnEditOnDeath == null)
          return;
        _btnEditOnDeath.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnDisarm
    {
      get => _btnEditOnDisarm;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnDisarm != null)
          _btnEditOnDisarm.Click -= btnEditScript_Click;
        _btnEditOnDisarm = value;
        if (_btnEditOnDisarm == null)
          return;
        _btnEditOnDisarm.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnHeartbeat
    {
      get => _btnEditOnHeartbeat;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnHeartbeat != null)
          _btnEditOnHeartbeat.Click -= btnEditScript_Click;
        _btnEditOnHeartbeat = value;
        if (_btnEditOnHeartbeat == null)
          return;
        _btnEditOnHeartbeat.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnLock
    {
      get => _btnEditOnLock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnLock != null)
          _btnEditOnLock.Click -= btnEditScript_Click;
        _btnEditOnLock = value;
        if (_btnEditOnLock == null)
          return;
        _btnEditOnLock.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnMeleeAttacked
    {
      get => _btnEditOnMeleeAttacked;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnMeleeAttacked != null)
          _btnEditOnMeleeAttacked.Click -= btnEditScript_Click;
        _btnEditOnMeleeAttacked = value;
        if (_btnEditOnMeleeAttacked == null)
          return;
        _btnEditOnMeleeAttacked.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnOpen
    {
      get => _btnEditOnOpen;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnOpen != null)
          _btnEditOnOpen.Click -= btnEditScript_Click;
        _btnEditOnOpen = value;
        if (_btnEditOnOpen == null)
          return;
        _btnEditOnOpen.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnSpellCastAt
    {
      get => _btnEditOnSpellCastAt;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnSpellCastAt != null)
          _btnEditOnSpellCastAt.Click -= btnEditScript_Click;
        _btnEditOnSpellCastAt = value;
        if (_btnEditOnSpellCastAt == null)
          return;
        _btnEditOnSpellCastAt.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnTrapTriggered
    {
      get => _btnEditOnTrapTriggered;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnTrapTriggered != null)
          _btnEditOnTrapTriggered.Click -= btnEditScript_Click;
        _btnEditOnTrapTriggered = value;
        if (_btnEditOnTrapTriggered == null)
          return;
        _btnEditOnTrapTriggered.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnUserDefined
    {
      get => _btnEditOnUserDefined;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnUserDefined != null)
          _btnEditOnUserDefined.Click -= btnEditScript_Click;
        _btnEditOnUserDefined = value;
        if (_btnEditOnUserDefined == null)
          return;
        _btnEditOnUserDefined.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnUnlock
    {
      get => _btnEditOnUnlock;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnUnlock != null)
          _btnEditOnUnlock.Click -= btnEditScript_Click;
        _btnEditOnUnlock = value;
        if (_btnEditOnUnlock == null)
          return;
        _btnEditOnUnlock.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnUsed
    {
      get => _btnEditOnUsed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnUsed != null)
          _btnEditOnUsed.Click -= btnEditScript_Click;
        _btnEditOnUsed = value;
        if (_btnEditOnUsed == null)
          return;
        _btnEditOnUsed.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnInvDisturbed
    {
      get => _btnEditOnInvDisturbed;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnInvDisturbed != null)
          _btnEditOnInvDisturbed.Click -= btnEditScript_Click;
        _btnEditOnInvDisturbed = value;
        if (_btnEditOnInvDisturbed == null)
          return;
        _btnEditOnInvDisturbed.Click += btnEditScript_Click;
      }
    }

    internal virtual Button BtnEditOnEndDialogue
    {
      get => _btnEditOnEndDialogue;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        if (_btnEditOnEndDialogue != null)
          _btnEditOnEndDialogue.Click -= btnEditScript_Click;
        _btnEditOnEndDialogue = value;
        if (_btnEditOnEndDialogue == null)
          return;
        _btnEditOnEndDialogue.Click += btnEditScript_Click;
      }
    }

    public FrmUtpEditor()
    {
      Load += frmUTP_Editor_Load;
      Closing += frmUTP_Editor_Closing;
      _mBSaveGameMode = false;
      InitializeComponent();
    }

    public FrmUtpEditor(ClsUtp utpClass, int kotorVerIndex, bool isDirectEdit = false, string editingPath = "")
      : this()
    {
      if (isDirectEdit)
      {
        _mBSaveGameMode = true;
        m_EditingFilePath = editingPath;
      }
      m_defaultTitleText = "Placeable Editor - KotOR ";
      Text = m_defaultTitleText;
      if (kotorVerIndex == 0)
        Text = Text + "I";
      else
        Text = Text + "II";
      CurrentSettings = UserSettings.GetSettings();
      GClsDialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
      Utp = utpClass;
      KotorVersionIndex = kotorVerIndex;
      Setup();
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
      TabControl1 = new TabControl();
      TabPageBasic = new TabPage();
      Label19 = new Label();
      CmbxAppearance = new ComboBox();
      BtnSetNameLang = new Button();
      Label5 = new Label();
      NudWill = new NumericUpDown();
      NudFort = new NumericUpDown();
      NudHp = new NumericUpDown();
      LblTextureVariation = new Label();
      Label8 = new Label();
      NudHardness = new NumericUpDown();
      NudRef = new NumericUpDown();
      Label12 = new Label();
      LblBodyVariation = new Label();
      ChkbPlotItem = new CheckBox();
      TbTag = new TextBox();
      TbName = new TextBox();
      Label1 = new Label();
      Label2 = new Label();
      ChkbStatic = new CheckBox();
      ChkbMin1Hp = new CheckBox();
      TabPageLock = new TabPage();
      TbKeyName = new TextBox();
      LblKeyTag = new Label();
      NudCloseLockDc = new NumericUpDown();
      LblCloseLockDc = new Label();
      NudOpenLockDc = new NumericUpDown();
      LblOpenLockDc = new Label();
      ChkbLockable = new CheckBox();
      ChkbLocked = new CheckBox();
      ChkbKeyRequired = new CheckBox();
      ChkbAutoRemoveKey = new CheckBox();
      TabPageAdvanced = new TabPage();
      ChkbPartyInteract = new CheckBox();
      ChkbHasInventory = new CheckBox();
      Label20 = new Label();
      TbType = new TextBox();
      ChkbInterruptable = new CheckBox();
      TbConversation = new TextBox();
      TbFaction = new TextBox();
      TbTemplateResRef = new TextBox();
      Label10 = new Label();
      Label11 = new Label();
      Label13 = new Label();
      Label14 = new Label();
      TbAnimationState = new TextBox();
      ChkbUsable = new CheckBox();
      TabPageScripts = new TabPage();
      TbOnUsed = new TextBox();
      Label18 = new Label();
      Label34 = new Label();
      TbOnDeath = new TextBox();
      Label33 = new Label();
      TbOnDamaged = new TextBox();
      Label32 = new Label();
      TbOnClosed = new TextBox();
      Label35 = new Label();
      TbOnDisarm = new TextBox();
      TbOnHeartbeat = new TextBox();
      Label36 = new Label();
      Label37 = new Label();
      TbOnLock = new TextBox();
      TbOnMeleeAttacked = new TextBox();
      Label38 = new Label();
      TbOnOpen = new TextBox();
      Label39 = new Label();
      Label40 = new Label();
      TbOnSpellCastAt = new TextBox();
      Label41 = new Label();
      TbOnTrapTriggered = new TextBox();
      TbOnUnlock = new TextBox();
      Label42 = new Label();
      TbOnUserDefined = new TextBox();
      Label43 = new Label();
      Label21 = new Label();
      TbOnEndDialogue = new TextBox();
      TbOnInvDisturbed = new TextBox();
      Label22 = new Label();
      TabPageDescription = new TabPage();
      BtnSetDescriptionLang = new Button();
      TbDescription = new TextBox();
      TabPageComments = new TabPage();
      TbComment = new TextBox();
      TabPageTrap = new TabPage();
      ChkbTrapDisarmable = new CheckBox();
      ChkbTrapDetectable = new CheckBox();
      Label6 = new Label();
      Label3 = new Label();
      NudDisarmDc = new NumericUpDown();
      Label4 = new Label();
      Label15 = new Label();
      NudTrapDetectDc = new NumericUpDown();
      Label16 = new Label();
      LblTrapDetectable = new Label();
      NudTrapType = new NumericUpDown();
      Label17 = new Label();
      ChkbTrapFlag = new CheckBox();
      ChkbTrapOneShot = new CheckBox();
      this.BtnSave = new Button();
      this.BtnCancel = new Button();
      BtnInventory = new Button();
      BtnDebug = new Button();
      BtnEditOnClosed = new Button();
      BtnEditOnDamaged = new Button();
      BtnEditOnDeath = new Button();
      BtnEditOnDisarm = new Button();
      BtnEditOnHeartbeat = new Button();
      BtnEditOnLock = new Button();
      BtnEditOnMeleeAttacked = new Button();
      BtnEditOnOpen = new Button();
      BtnEditOnSpellCastAt = new Button();
      BtnEditOnTrapTriggered = new Button();
      BtnEditOnUserDefined = new Button();
      BtnEditOnUnlock = new Button();
      BtnEditOnUsed = new Button();
      BtnEditOnInvDisturbed = new Button();
      BtnEditOnEndDialogue = new Button();
      TabControl1.SuspendLayout();
      TabPageBasic.SuspendLayout();
      NudWill.BeginInit();
      NudFort.BeginInit();
      NudHp.BeginInit();
      NudHardness.BeginInit();
      NudRef.BeginInit();
      TabPageLock.SuspendLayout();
      NudCloseLockDc.BeginInit();
      NudOpenLockDc.BeginInit();
      TabPageAdvanced.SuspendLayout();
      TabPageScripts.SuspendLayout();
      TabPageDescription.SuspendLayout();
      TabPageComments.SuspendLayout();
      TabPageTrap.SuspendLayout();
      NudDisarmDc.BeginInit();
      NudTrapDetectDc.BeginInit();
      NudTrapType.BeginInit();
      SuspendLayout();
      TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      TabControl1.Controls.Add(TabPageBasic);
      TabControl1.Controls.Add(TabPageLock);
      TabControl1.Controls.Add(TabPageAdvanced);
      TabControl1.Controls.Add(TabPageScripts);
      TabControl1.Controls.Add(TabPageDescription);
      TabControl1.Controls.Add(TabPageComments);
      TabControl1.Controls.Add(TabPageTrap);
      TabControl tabControl11 = TabControl1;
      Point point1 = new Point(19, 11);
      Point point2 = point1;
      tabControl11.Location = point2;
      TabControl1.Multiline = true;
      TabControl1.Name = "TabControl1";
      TabControl tabControl12 = TabControl1;
      point1 = new Point(15, 3);
      Point point3 = point1;
      tabControl12.Padding = point3;
      TabControl1.SelectedIndex = 0;
      TabControl tabControl13 = TabControl1;
      Size size1 = new Size(456, 461);
      Size size2 = size1;
      tabControl13.Size = size2;
      TabControl1.SizeMode = TabSizeMode.FillToRight;
      TabControl1.TabIndex = 0;
      TabPageBasic.Controls.Add(Label19);
      TabPageBasic.Controls.Add(CmbxAppearance);
      TabPageBasic.Controls.Add(BtnSetNameLang);
      TabPageBasic.Controls.Add(Label5);
      TabPageBasic.Controls.Add(NudWill);
      TabPageBasic.Controls.Add(NudFort);
      TabPageBasic.Controls.Add(NudHp);
      TabPageBasic.Controls.Add(LblTextureVariation);
      TabPageBasic.Controls.Add(Label8);
      TabPageBasic.Controls.Add(NudHardness);
      TabPageBasic.Controls.Add(NudRef);
      TabPageBasic.Controls.Add(Label12);
      TabPageBasic.Controls.Add(LblBodyVariation);
      TabPageBasic.Controls.Add(ChkbPlotItem);
      TabPageBasic.Controls.Add(TbTag);
      TabPageBasic.Controls.Add(TbName);
      TabPageBasic.Controls.Add(Label1);
      TabPageBasic.Controls.Add(Label2);
      TabPageBasic.Controls.Add(ChkbStatic);
      TabPageBasic.Controls.Add(ChkbMin1Hp);
      TabPage tabPageBasic1 = TabPageBasic;
      point1 = new Point(4, 40);
      Point point4 = point1;
      ((Control) tabPageBasic1).Location = point4;
      TabPageBasic.Name = "TabPageBasic";
      TabPage tabPageBasic2 = TabPageBasic;
      size1 = new Size(448, 393);
      Size size3 = size1;
      tabPageBasic2.Size = size3;
      TabPageBasic.TabIndex = 0;
      TabPageBasic.Text = "Basic";
      Label label191 = Label19;
      point1 = new Point(48, 80);
      Point point5 = point1;
      label191.Location = point5;
      Label19.Name = "Label19";
      Label label192 = Label19;
      size1 = new Size(80, 16);
      Size size4 = size1;
      label192.Size = size4;
      Label19.TabIndex = 10;
      Label19.Text = "Appearance";
      Label19.TextAlign = ContentAlignment.MiddleLeft;
      CmbxAppearance.DropDownStyle = ComboBoxStyle.DropDownList;
      ComboBox cmbxAppearance1 = CmbxAppearance;
      point1 = new Point(128, 80);
      Point point6 = point1;
      cmbxAppearance1.Location = point6;
      CmbxAppearance.Name = "cmbxAppearance";
      ComboBox cmbxAppearance2 = CmbxAppearance;
      size1 = new Size(184, 21);
      Size size5 = size1;
      cmbxAppearance2.Size = size5;
      CmbxAppearance.TabIndex = 3;
      Button btnSetNameLang1 = BtnSetNameLang;
      point1 = new Point(344, 32);
      Point point7 = point1;
      btnSetNameLang1.Location = point7;
      BtnSetNameLang.Name = "btnSetNameLang";
      Button btnSetNameLang2 = BtnSetNameLang;
      size1 = new Size(88, 23);
      Size size6 = size1;
      btnSetNameLang2.Size = size6;
      BtnSetNameLang.TabIndex = 1;
      BtnSetNameLang.Text = "Set Language";
      Label label51 = Label5;
      point1 = new Point(48, 200);
      Point point8 = point1;
      label51.Location = point8;
      Label5.Name = "Label5";
      Label label52 = Label5;
      size1 = new Size(88, 16);
      Size size7 = size1;
      label52.Size = size7;
      Label5.TabIndex = 8;
      Label5.Text = "Fortitude Save";
      Label5.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudWill1 = NudWill;
      point1 = new Point(192, 248);
      Point point9 = point1;
      nudWill1.Location = point9;
      NudWill.Name = "nudWill";
      NudWill.RightToLeft = RightToLeft.No;
      NumericUpDown nudWill2 = NudWill;
      size1 = new Size(48, 20);
      Size size8 = size1;
      nudWill2.Size = size8;
      NudWill.TabIndex = 11;
      NudWill.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudFort1 = NudFort;
      point1 = new Point(192, 200);
      Point point10 = point1;
      nudFort1.Location = point10;
      NudFort.Name = "nudFort";
      NudFort.RightToLeft = RightToLeft.No;
      NumericUpDown nudFort2 = NudFort;
      size1 = new Size(48, 20);
      Size size9 = size1;
      nudFort2.Size = size9;
      NudFort.TabIndex = 9;
      NudFort.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudHp1 = NudHp;
      point1 = new Point(192, 176);
      Point point11 = point1;
      nudHp1.Location = point11;
      NumericUpDown nudHp2 = NudHp;
      Decimal num1 = new Decimal(new int[4]{ 99999, 0, 0, 0 });
      Decimal num2 = num1;
      nudHp2.Maximum = num2;
      NudHp.Name = "nudHP";
      NudHp.RightToLeft = RightToLeft.No;
      NumericUpDown nudHp3 = NudHp;
      size1 = new Size(48, 20);
      Size size10 = size1;
      nudHp3.Size = size10;
      NudHp.TabIndex = 8;
      NudHp.TextAlign = HorizontalAlignment.Right;
      Label textureVariation1 = LblTextureVariation;
      point1 = new Point(48, 248);
      Point point12 = point1;
      textureVariation1.Location = point12;
      LblTextureVariation.Name = "lblTextureVariation";
      Label textureVariation2 = LblTextureVariation;
      size1 = new Size(96, 16);
      Size size11 = size1;
      textureVariation2.Size = size11;
      LblTextureVariation.TabIndex = 5;
      LblTextureVariation.Text = "Will Save";
      LblTextureVariation.TextAlign = ContentAlignment.MiddleLeft;
      Label label81 = Label8;
      point1 = new Point(48, 176);
      Point point13 = point1;
      label81.Location = point13;
      Label8.Name = "Label8";
      Label label82 = Label8;
      size1 = new Size(88, 16);
      Size size12 = size1;
      label82.Size = size12;
      Label8.TabIndex = 4;
      Label8.Text = "Hit Points";
      Label8.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudHardness1 = NudHardness;
      point1 = new Point(192, 152);
      Point point14 = point1;
      nudHardness1.Location = point14;
      NumericUpDown nudHardness2 = NudHardness;
      num1 = new Decimal(new int[4]
      {
        byte.MaxValue,
        0,
        0,
        0
      });
      Decimal num3 = num1;
      nudHardness2.Maximum = num3;
      NudHardness.Name = "nudHardness";
      NudHardness.RightToLeft = RightToLeft.No;
      NumericUpDown nudHardness3 = NudHardness;
      size1 = new Size(48, 20);
      Size size13 = size1;
      nudHardness3.Size = size13;
      NudHardness.TabIndex = 7;
      NudHardness.TextAlign = HorizontalAlignment.Right;
      NumericUpDown nudRef1 = NudRef;
      point1 = new Point(192, 224);
      Point point15 = point1;
      nudRef1.Location = point15;
      NudRef.Name = "nudRef";
      NudRef.RightToLeft = RightToLeft.No;
      NumericUpDown nudRef2 = NudRef;
      size1 = new Size(48, 20);
      Size size14 = size1;
      nudRef2.Size = size14;
      NudRef.TabIndex = 10;
      NudRef.TextAlign = HorizontalAlignment.Right;
      Label label121 = Label12;
      point1 = new Point(48, 152);
      Point point16 = point1;
      label121.Location = point16;
      Label12.Name = "Label12";
      Label label122 = Label12;
      size1 = new Size(88, 16);
      Size size15 = size1;
      label122.Size = size15;
      Label12.TabIndex = 7;
      Label12.Text = "Hardness";
      Label12.TextAlign = ContentAlignment.MiddleLeft;
      Label lblBodyVariation1 = LblBodyVariation;
      point1 = new Point(48, 224);
      Point point17 = point1;
      lblBodyVariation1.Location = point17;
      LblBodyVariation.Name = "lblBodyVariation";
      Label lblBodyVariation2 = LblBodyVariation;
      size1 = new Size(88, 16);
      Size size16 = size1;
      lblBodyVariation2.Size = size16;
      LblBodyVariation.TabIndex = 6;
      LblBodyVariation.Text = "Reflex Save";
      LblBodyVariation.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbPlotItem1 = ChkbPlotItem;
      point1 = new Point(48, 112);
      Point point18 = point1;
      chkbPlotItem1.Location = point18;
      ChkbPlotItem.Name = "chkbPlotItem";
      CheckBox chkbPlotItem2 = ChkbPlotItem;
      size1 = new Size(72, 24);
      Size size17 = size1;
      chkbPlotItem2.Size = size17;
      ChkbPlotItem.TabIndex = 4;
      ChkbPlotItem.Text = "Plot item";
      TextBox tbTag1 = TbTag;
      point1 = new Point(128, 56);
      Point point19 = point1;
      tbTag1.Location = point19;
      TbTag.Name = "tbTag";
      TextBox tbTag2 = TbTag;
      size1 = new Size(200, 20);
      Size size18 = size1;
      tbTag2.Size = size18;
      TbTag.TabIndex = 2;
      TbTag.Text = "";
      TextBox tbName1 = TbName;
      point1 = new Point(128, 32);
      Point point20 = point1;
      tbName1.Location = point20;
      TbName.Name = "tbName";
      TextBox tbName2 = TbName;
      size1 = new Size(200, 20);
      Size size19 = size1;
      tbName2.Size = size19;
      TbName.TabIndex = 0;
      TbName.Text = "";
      Label label11 = Label1;
      point1 = new Point(48, 32);
      Point point21 = point1;
      label11.Location = point21;
      Label1.Name = "Label1";
      Label label12 = Label1;
      size1 = new Size(100, 16);
      Size size20 = size1;
      label12.Size = size20;
      Label1.TabIndex = 0;
      Label1.Text = "Name";
      Label1.TextAlign = ContentAlignment.MiddleLeft;
      Label label21 = Label2;
      point1 = new Point(48, 56);
      Point point22 = point1;
      label21.Location = point22;
      Label2.Name = "Label2";
      Label label22 = Label2;
      size1 = new Size(100, 16);
      Size size21 = size1;
      label22.Size = size21;
      Label2.TabIndex = 0;
      Label2.Text = "Tag";
      Label2.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbStatic1 = ChkbStatic;
      point1 = new Point(192, 112);
      Point point23 = point1;
      chkbStatic1.Location = point23;
      ChkbStatic.Name = "chkbStatic";
      CheckBox chkbStatic2 = ChkbStatic;
      size1 = new Size(72, 24);
      Size size22 = size1;
      chkbStatic2.Size = size22;
      ChkbStatic.TabIndex = 5;
      ChkbStatic.Text = "Static";
      CheckBox chkbMin1Hp1 = ChkbMin1Hp;
      point1 = new Point(296, 112);
      Point point24 = point1;
      chkbMin1Hp1.Location = point24;
      ChkbMin1Hp.Name = "chkbMin1HP";
      CheckBox chkbMin1Hp2 = ChkbMin1Hp;
      size1 = new Size(72, 24);
      Size size23 = size1;
      chkbMin1Hp2.Size = size23;
      ChkbMin1Hp.TabIndex = 6;
      ChkbMin1Hp.Text = "Min1HP";
      TabPageLock.Controls.Add(TbKeyName);
      TabPageLock.Controls.Add(LblKeyTag);
      TabPageLock.Controls.Add(NudCloseLockDc);
      TabPageLock.Controls.Add(LblCloseLockDc);
      TabPageLock.Controls.Add(NudOpenLockDc);
      TabPageLock.Controls.Add(LblOpenLockDc);
      TabPageLock.Controls.Add(ChkbLockable);
      TabPageLock.Controls.Add(ChkbLocked);
      TabPageLock.Controls.Add(ChkbKeyRequired);
      TabPageLock.Controls.Add(ChkbAutoRemoveKey);
      TabPage tabPageLock1 = TabPageLock;
      point1 = new Point(4, 40);
      Point point25 = point1;
      ((Control) tabPageLock1).Location = point25;
      TabPageLock.Name = "TabPageLock";
      TabPage tabPageLock2 = TabPageLock;
      size1 = new Size(448, 393);
      Size size24 = size1;
      tabPageLock2.Size = size24;
      TabPageLock.TabIndex = 1;
      TabPageLock.Text = "Lock";
      TabPageLock.Visible = false;
      TbKeyName.Enabled = false;
      TextBox tbKeyName1 = TbKeyName;
      point1 = new Point(176, 256);
      Point point26 = point1;
      tbKeyName1.Location = point26;
      TbKeyName.Name = "tbKeyName";
      TextBox tbKeyName2 = TbKeyName;
      size1 = new Size(200, 20);
      Size size25 = size1;
      tbKeyName2.Size = size25;
      TbKeyName.TabIndex = 6;
      TbKeyName.Text = "";
      LblKeyTag.Enabled = false;
      Label lblKeyTag1 = LblKeyTag;
      point1 = new Point(52, 256);
      Point point27 = point1;
      lblKeyTag1.Location = point27;
      LblKeyTag.Name = "lblKeyTag";
      Label lblKeyTag2 = LblKeyTag;
      size1 = new Size(100, 16);
      Size size26 = size1;
      lblKeyTag2.Size = size26;
      LblKeyTag.TabIndex = 18;
      LblKeyTag.Text = "Key Tag";
      LblKeyTag.TextAlign = ContentAlignment.MiddleLeft;
      NudCloseLockDc.Enabled = false;
      NumericUpDown nudCloseLockDc1 = NudCloseLockDc;
      point1 = new Point(176, 216);
      Point point28 = point1;
      nudCloseLockDc1.Location = point28;
      NudCloseLockDc.Name = "nudCloseLockDC";
      NudCloseLockDc.RightToLeft = RightToLeft.No;
      NumericUpDown nudCloseLockDc2 = NudCloseLockDc;
      size1 = new Size(48, 20);
      Size size27 = size1;
      nudCloseLockDc2.Size = size27;
      NudCloseLockDc.TabIndex = 5;
      NudCloseLockDc.TextAlign = HorizontalAlignment.Right;
      LblCloseLockDc.Enabled = false;
      Label lblCloseLockDc1 = LblCloseLockDc;
      point1 = new Point(48, 216);
      Point point29 = point1;
      lblCloseLockDc1.Location = point29;
      LblCloseLockDc.Name = "lblCloseLockDC";
      Label lblCloseLockDc2 = LblCloseLockDc;
      size1 = new Size(88, 16);
      Size size28 = size1;
      lblCloseLockDc2.Size = size28;
      LblCloseLockDc.TabIndex = 14;
      LblCloseLockDc.Text = "Close Lock DC";
      LblCloseLockDc.TextAlign = ContentAlignment.MiddleLeft;
      NudOpenLockDc.Enabled = false;
      NumericUpDown nudOpenLockDc1 = NudOpenLockDc;
      point1 = new Point(176, 176);
      Point point30 = point1;
      nudOpenLockDc1.Location = point30;
      NudOpenLockDc.Name = "nudOpenLockDC";
      NudOpenLockDc.RightToLeft = RightToLeft.No;
      NumericUpDown nudOpenLockDc2 = NudOpenLockDc;
      size1 = new Size(48, 20);
      Size size29 = size1;
      nudOpenLockDc2.Size = size29;
      NudOpenLockDc.TabIndex = 4;
      NudOpenLockDc.TextAlign = HorizontalAlignment.Right;
      LblOpenLockDc.Enabled = false;
      Label lblOpenLockDc1 = LblOpenLockDc;
      point1 = new Point(48, 176);
      Point point31 = point1;
      lblOpenLockDc1.Location = point31;
      LblOpenLockDc.Name = "lblOpenLockDC";
      Label lblOpenLockDc2 = LblOpenLockDc;
      size1 = new Size(88, 16);
      Size size30 = size1;
      lblOpenLockDc2.Size = size30;
      LblOpenLockDc.TabIndex = 15;
      LblOpenLockDc.Text = "Open Lock DC";
      LblOpenLockDc.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbLockable1 = ChkbLockable;
      point1 = new Point(48, 66);
      Point point32 = point1;
      chkbLockable1.Location = point32;
      ChkbLockable.Name = "chkbLockable";
      CheckBox chkbLockable2 = ChkbLockable;
      size1 = new Size(112, 24);
      Size size31 = size1;
      chkbLockable2.Size = size31;
      ChkbLockable.TabIndex = 1;
      ChkbLockable.Text = "Can be relocked";
      CheckBox chkbLocked1 = ChkbLocked;
      point1 = new Point(48, 32);
      Point point33 = point1;
      chkbLocked1.Location = point33;
      ChkbLocked.Name = "chkbLocked";
      CheckBox chkbLocked2 = ChkbLocked;
      size1 = new Size(72, 24);
      Size size32 = size1;
      chkbLocked2.Size = size32;
      ChkbLocked.TabIndex = 0;
      ChkbLocked.Text = "Locked";
      ChkbKeyRequired.Enabled = false;
      CheckBox chkbKeyRequired1 = ChkbKeyRequired;
      point1 = new Point(48, 134);
      Point point34 = point1;
      chkbKeyRequired1.Location = point34;
      ChkbKeyRequired.Name = "chkbKeyRequired";
      CheckBox chkbKeyRequired2 = ChkbKeyRequired;
      size1 = new Size(184, 24);
      Size size33 = size1;
      chkbKeyRequired2.Size = size33;
      ChkbKeyRequired.TabIndex = 3;
      ChkbKeyRequired.Text = "Key required to unlock or lock";
      ChkbAutoRemoveKey.Enabled = false;
      CheckBox chkbAutoRemoveKey1 = ChkbAutoRemoveKey;
      point1 = new Point(48, 100);
      Point point35 = point1;
      chkbAutoRemoveKey1.Location = point35;
      ChkbAutoRemoveKey.Name = "chkbAutoRemoveKey";
      CheckBox chkbAutoRemoveKey2 = ChkbAutoRemoveKey;
      size1 = new Size(200, 24);
      Size size34 = size1;
      chkbAutoRemoveKey2.Size = size34;
      ChkbAutoRemoveKey.TabIndex = 2;
      ChkbAutoRemoveKey.Text = "Automatically remove key after use";
      TabPageAdvanced.Controls.Add(ChkbPartyInteract);
      TabPageAdvanced.Controls.Add(ChkbHasInventory);
      TabPageAdvanced.Controls.Add(Label20);
      TabPageAdvanced.Controls.Add(TbType);
      TabPageAdvanced.Controls.Add(ChkbInterruptable);
      TabPageAdvanced.Controls.Add(TbConversation);
      TabPageAdvanced.Controls.Add(TbFaction);
      TabPageAdvanced.Controls.Add(TbTemplateResRef);
      TabPageAdvanced.Controls.Add(Label10);
      TabPageAdvanced.Controls.Add(Label11);
      TabPageAdvanced.Controls.Add(Label13);
      TabPageAdvanced.Controls.Add(Label14);
      TabPageAdvanced.Controls.Add(TbAnimationState);
      TabPageAdvanced.Controls.Add(ChkbUsable);
      TabPage tabPageAdvanced1 = TabPageAdvanced;
      point1 = new Point(4, 40);
      Point point36 = point1;
      ((Control) tabPageAdvanced1).Location = point36;
      TabPageAdvanced.Name = "TabPageAdvanced";
      TabPage tabPageAdvanced2 = TabPageAdvanced;
      size1 = new Size(448, 393);
      Size size35 = size1;
      tabPageAdvanced2.Size = size35;
      TabPageAdvanced.TabIndex = 5;
      TabPageAdvanced.Text = "Advanced";
      TabPageAdvanced.Visible = false;
      CheckBox chkbPartyInteract1 = ChkbPartyInteract;
      point1 = new Point(168, 240);
      Point point37 = point1;
      chkbPartyInteract1.Location = point37;
      ChkbPartyInteract.Name = "chkbPartyInteract";
      CheckBox chkbPartyInteract2 = ChkbPartyInteract;
      size1 = new Size(184, 24);
      Size size36 = size1;
      chkbPartyInteract2.Size = size36;
      ChkbPartyInteract.TabIndex = 6;
      ChkbPartyInteract.Text = "Party Interact";
      CheckBox chkbHasInventory1 = ChkbHasInventory;
      point1 = new Point(168, 208);
      Point point38 = point1;
      chkbHasInventory1.Location = point38;
      ChkbHasInventory.Name = "chkbHasInventory";
      CheckBox chkbHasInventory2 = ChkbHasInventory;
      size1 = new Size(184, 24);
      Size size37 = size1;
      chkbHasInventory2.Size = size37;
      ChkbHasInventory.TabIndex = 5;
      ChkbHasInventory.Text = "Has Inventory";
      Label label201 = Label20;
      point1 = new Point(56, 176);
      Point point39 = point1;
      label201.Location = point39;
      Label20.Name = "Label20";
      Label label202 = Label20;
      size1 = new Size(48, 16);
      Size size38 = size1;
      label202.Size = size38;
      Label20.TabIndex = 5;
      Label20.Text = "Type";
      Label20.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbType1 = TbType;
      point1 = new Point(168, 176);
      Point point40 = point1;
      tbType1.Location = point40;
      TbType.Name = "tbType";
      TextBox tbType2 = TbType;
      size1 = new Size(72, 20);
      Size size39 = size1;
      tbType2.Size = size39;
      TbType.TabIndex = 4;
      TbType.Text = "";
      CheckBox chkbInterruptable1 = ChkbInterruptable;
      point1 = new Point(352, 112);
      Point point41 = point1;
      chkbInterruptable1.Location = point41;
      ChkbInterruptable.Name = "chkbInterruptable";
      CheckBox chkbInterruptable2 = ChkbInterruptable;
      size1 = new Size(88, 24);
      Size size40 = size1;
      chkbInterruptable2.Size = size40;
      ChkbInterruptable.TabIndex = 2;
      ChkbInterruptable.Text = "Interruptable";
      TextBox tbConversation1 = TbConversation;
      point1 = new Point(168, 112);
      Point point42 = point1;
      tbConversation1.Location = point42;
      TbConversation.Name = "tbConversation";
      TextBox tbConversation2 = TbConversation;
      size1 = new Size(168, 20);
      Size size41 = size1;
      tbConversation2.Size = size41;
      TbConversation.TabIndex = 1;
      TbConversation.Text = "";
      TextBox tbFaction1 = TbFaction;
      point1 = new Point(168, 80);
      Point point43 = point1;
      tbFaction1.Location = point43;
      TbFaction.Name = "tbFaction";
      TextBox tbFaction2 = TbFaction;
      size1 = new Size(30, 20);
      Size size42 = size1;
      tbFaction2.Size = size42;
      TbFaction.TabIndex = 0;
      TbFaction.Text = "";
      TbTemplateResRef.CharacterCasing = CharacterCasing.Lower;
      TextBox tbTemplateResRef1 = TbTemplateResRef;
      point1 = new Point(168, 32);
      Point point44 = point1;
      tbTemplateResRef1.Location = point44;
      TbTemplateResRef.MaxLength = 16;
      TbTemplateResRef.Name = "tbTemplateResRef";
      TextBox tbTemplateResRef2 = TbTemplateResRef;
      size1 = new Size(200, 20);
      Size size43 = size1;
      tbTemplateResRef2.Size = size43;
      TbTemplateResRef.TabIndex = 3;
      TbTemplateResRef.Text = "";
      Label label101 = Label10;
      point1 = new Point(52, 32);
      Point point45 = point1;
      label101.Location = point45;
      Label10.Name = "Label10";
      Label label102 = Label10;
      size1 = new Size(100, 16);
      Size size44 = size1;
      label102.Size = size44;
      Label10.TabIndex = 2;
      Label10.Text = "Template ResRef";
      Label10.TextAlign = ContentAlignment.MiddleLeft;
      Label label111 = Label11;
      point1 = new Point(56, 80);
      Point point46 = point1;
      label111.Location = point46;
      Label11.Name = "Label11";
      Label label112 = Label11;
      size1 = new Size(100, 16);
      Size size45 = size1;
      label112.Size = size45;
      Label11.TabIndex = 2;
      Label11.Text = "Faction";
      Label11.TextAlign = ContentAlignment.MiddleLeft;
      Label label131 = Label13;
      point1 = new Point(56, 112);
      Point point47 = point1;
      label131.Location = point47;
      Label13.Name = "Label13";
      Label label132 = Label13;
      size1 = new Size(100, 16);
      Size size46 = size1;
      label132.Size = size46;
      Label13.TabIndex = 2;
      Label13.Text = "Conversation";
      Label13.TextAlign = ContentAlignment.MiddleLeft;
      Label label141 = Label14;
      point1 = new Point(56, 144);
      Point point48 = point1;
      label141.Location = point48;
      Label14.Name = "Label14";
      Label label142 = Label14;
      size1 = new Size(100, 16);
      Size size47 = size1;
      label142.Size = size47;
      Label14.TabIndex = 2;
      Label14.Text = "Animation State";
      Label14.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbAnimationState1 = TbAnimationState;
      point1 = new Point(168, 144);
      Point point49 = point1;
      tbAnimationState1.Location = point49;
      TbAnimationState.Name = "tbAnimationState";
      TextBox tbAnimationState2 = TbAnimationState;
      size1 = new Size(32, 20);
      Size size48 = size1;
      tbAnimationState2.Size = size48;
      TbAnimationState.TabIndex = 3;
      TbAnimationState.Text = "";
      CheckBox chkbUsable1 = ChkbUsable;
      point1 = new Point(168, 272);
      Point point50 = point1;
      chkbUsable1.Location = point50;
      ChkbUsable.Name = "chkbUsable";
      CheckBox chkbUsable2 = ChkbUsable;
      size1 = new Size(184, 24);
      Size size49 = size1;
      chkbUsable2.Size = size49;
      ChkbUsable.TabIndex = 6;
      ChkbUsable.Text = "Usable";
      TabPageScripts.Controls.Add(BtnEditOnUserDefined);
      TabPageScripts.Controls.Add(BtnEditOnUnlock);
      TabPageScripts.Controls.Add(BtnEditOnSpellCastAt);
      TabPageScripts.Controls.Add(BtnEditOnTrapTriggered);
      TabPageScripts.Controls.Add(BtnEditOnMeleeAttacked);
      TabPageScripts.Controls.Add(BtnEditOnOpen);
      TabPageScripts.Controls.Add(BtnEditOnLock);
      TabPageScripts.Controls.Add(BtnEditOnHeartbeat);
      TabPageScripts.Controls.Add(BtnEditOnDeath);
      TabPageScripts.Controls.Add(BtnEditOnDisarm);
      TabPageScripts.Controls.Add(BtnEditOnDamaged);
      TabPageScripts.Controls.Add(BtnEditOnClosed);
      TabPageScripts.Controls.Add(TbOnUsed);
      TabPageScripts.Controls.Add(Label18);
      TabPageScripts.Controls.Add(Label34);
      TabPageScripts.Controls.Add(TbOnDeath);
      TabPageScripts.Controls.Add(Label33);
      TabPageScripts.Controls.Add(TbOnDamaged);
      TabPageScripts.Controls.Add(Label32);
      TabPageScripts.Controls.Add(TbOnClosed);
      TabPageScripts.Controls.Add(Label35);
      TabPageScripts.Controls.Add(TbOnDisarm);
      TabPageScripts.Controls.Add(TbOnHeartbeat);
      TabPageScripts.Controls.Add(Label36);
      TabPageScripts.Controls.Add(Label37);
      TabPageScripts.Controls.Add(TbOnLock);
      TabPageScripts.Controls.Add(TbOnMeleeAttacked);
      TabPageScripts.Controls.Add(Label38);
      TabPageScripts.Controls.Add(TbOnOpen);
      TabPageScripts.Controls.Add(Label39);
      TabPageScripts.Controls.Add(Label40);
      TabPageScripts.Controls.Add(TbOnSpellCastAt);
      TabPageScripts.Controls.Add(Label41);
      TabPageScripts.Controls.Add(TbOnTrapTriggered);
      TabPageScripts.Controls.Add(TbOnUnlock);
      TabPageScripts.Controls.Add(Label42);
      TabPageScripts.Controls.Add(TbOnUserDefined);
      TabPageScripts.Controls.Add(Label43);
      TabPageScripts.Controls.Add(Label21);
      TabPageScripts.Controls.Add(TbOnEndDialogue);
      TabPageScripts.Controls.Add(TbOnInvDisturbed);
      TabPageScripts.Controls.Add(Label22);
      TabPageScripts.Controls.Add(BtnEditOnUsed);
      TabPageScripts.Controls.Add(BtnEditOnInvDisturbed);
      TabPageScripts.Controls.Add(BtnEditOnEndDialogue);
      TabPage tabPageScripts1 = TabPageScripts;
      point1 = new Point(4, 40);
      Point point51 = point1;
      ((Control) tabPageScripts1).Location = point51;
      TabPageScripts.Name = "TabPageScripts";
      TabPage tabPageScripts2 = TabPageScripts;
      size1 = new Size(448, 417);
      Size size50 = size1;
      tabPageScripts2.Size = size50;
      TabPageScripts.TabIndex = 4;
      TabPageScripts.Text = "Scripts";
      TabPageScripts.Visible = false;
      TextBox tbOnUsed1 = TbOnUsed;
      point1 = new Point(160, 354);
      Point point52 = point1;
      tbOnUsed1.Location = point52;
      TbOnUsed.Name = "tbOnUsed";
      TextBox tbOnUsed2 = TbOnUsed;
      size1 = new Size(204, 20);
      Size size51 = size1;
      tbOnUsed2.Size = size51;
      TbOnUsed.TabIndex = 26;
      TbOnUsed.Text = "";
      Label label181 = Label18;
      point1 = new Point(40, 354);
      Point point53 = point1;
      label181.Location = point53;
      Label18.Name = "Label18";
      Label label182 = Label18;
      size1 = new Size(112, 18);
      Size size52 = size1;
      label182.Size = size52;
      Label18.TabIndex = 30;
      Label18.Text = "OnUsed";
      Label18.TextAlign = ContentAlignment.MiddleLeft;
      Label label341 = Label34;
      point1 = new Point(40, 68);
      Point point54 = point1;
      label341.Location = point54;
      Label34.Name = "Label34";
      Label label342 = Label34;
      size1 = new Size(112, 18);
      Size size53 = size1;
      label342.Size = size53;
      Label34.TabIndex = 27;
      Label34.Text = "OnDeath";
      Label34.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDeath1 = TbOnDeath;
      point1 = new Point(160, 68);
      Point point55 = point1;
      tbOnDeath1.Location = point55;
      TbOnDeath.Name = "tbOnDeath";
      TextBox tbOnDeath2 = TbOnDeath;
      size1 = new Size(204, 20);
      Size size54 = size1;
      tbOnDeath2.Size = size54;
      TbOnDeath.TabIndex = 4;
      TbOnDeath.Text = "";
      Label label331 = Label33;
      point1 = new Point(40, 42);
      Point point56 = point1;
      label331.Location = point56;
      Label33.Name = "Label33";
      Label label332 = Label33;
      size1 = new Size(112, 18);
      Size size55 = size1;
      label332.Size = size55;
      Label33.TabIndex = 17;
      Label33.Text = "OnDamaged";
      Label33.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDamaged1 = TbOnDamaged;
      point1 = new Point(160, 42);
      Point point57 = point1;
      tbOnDamaged1.Location = point57;
      TbOnDamaged.Name = "tbOnDamaged";
      TextBox tbOnDamaged2 = TbOnDamaged;
      size1 = new Size(204, 20);
      Size size56 = size1;
      tbOnDamaged2.Size = size56;
      TbOnDamaged.TabIndex = 2;
      TbOnDamaged.Text = "";
      Label label321 = Label32;
      point1 = new Point(40, 16);
      Point point58 = point1;
      label321.Location = point58;
      Label32.Name = "Label32";
      Label label322 = Label32;
      size1 = new Size(112, 18);
      Size size57 = size1;
      label322.Size = size57;
      Label32.TabIndex = 14;
      Label32.Text = "OnClosed";
      Label32.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnClosed1 = TbOnClosed;
      point1 = new Point(160, 16);
      Point point59 = point1;
      tbOnClosed1.Location = point59;
      TbOnClosed.Name = "tbOnClosed";
      TextBox tbOnClosed2 = TbOnClosed;
      size1 = new Size(204, 20);
      Size size58 = size1;
      tbOnClosed2.Size = size58;
      TbOnClosed.TabIndex = 0;
      TbOnClosed.Text = "";
      Label label351 = Label35;
      point1 = new Point(40, 94);
      Point point60 = point1;
      label351.Location = point60;
      Label35.Name = "Label35";
      Label label352 = Label35;
      size1 = new Size(112, 18);
      Size size59 = size1;
      label352.Size = size59;
      Label35.TabIndex = 26;
      Label35.Text = "OnDisarm";
      Label35.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnDisarm1 = TbOnDisarm;
      point1 = new Point(160, 94);
      Point point61 = point1;
      tbOnDisarm1.Location = point61;
      TbOnDisarm.Name = "tbOnDisarm";
      TextBox tbOnDisarm2 = TbOnDisarm;
      size1 = new Size(204, 20);
      Size size60 = size1;
      tbOnDisarm2.Size = size60;
      TbOnDisarm.TabIndex = 6;
      TbOnDisarm.Text = "";
      TextBox tbOnHeartbeat1 = TbOnHeartbeat;
      point1 = new Point(160, 146);
      Point point62 = point1;
      tbOnHeartbeat1.Location = point62;
      TbOnHeartbeat.Name = "tbOnHeartbeat";
      TextBox tbOnHeartbeat2 = TbOnHeartbeat;
      size1 = new Size(204, 20);
      Size size61 = size1;
      tbOnHeartbeat2.Size = size61;
      TbOnHeartbeat.TabIndex = 10;
      TbOnHeartbeat.Text = "";
      Label label361 = Label36;
      point1 = new Point(40, 146);
      Point point63 = point1;
      label361.Location = point63;
      Label36.Name = "Label36";
      Label label362 = Label36;
      size1 = new Size(112, 18);
      Size size62 = size1;
      label362.Size = size62;
      Label36.TabIndex = 25;
      Label36.Text = "OnHeartbeat";
      Label36.TextAlign = ContentAlignment.MiddleLeft;
      Label label371 = Label37;
      point1 = new Point(40, 198);
      Point point64 = point1;
      label371.Location = point64;
      Label37.Name = "Label37";
      Label label372 = Label37;
      size1 = new Size(112, 18);
      Size size63 = size1;
      label372.Size = size63;
      Label37.TabIndex = 28;
      Label37.Text = "OnLock";
      Label37.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnLock1 = TbOnLock;
      point1 = new Point(160, 198);
      Point point65 = point1;
      tbOnLock1.Location = point65;
      TbOnLock.Name = "tbOnLock";
      TextBox tbOnLock2 = TbOnLock;
      size1 = new Size(204, 20);
      Size size64 = size1;
      tbOnLock2.Size = size64;
      TbOnLock.TabIndex = 14;
      TbOnLock.Text = "";
      TextBox tbOnMeleeAttacked1 = TbOnMeleeAttacked;
      point1 = new Point(160, 224);
      Point point66 = point1;
      tbOnMeleeAttacked1.Location = point66;
      TbOnMeleeAttacked.Name = "tbOnMeleeAttacked";
      TextBox tbOnMeleeAttacked2 = TbOnMeleeAttacked;
      size1 = new Size(204, 20);
      Size size65 = size1;
      tbOnMeleeAttacked2.Size = size65;
      TbOnMeleeAttacked.TabIndex = 16;
      TbOnMeleeAttacked.Text = "";
      Label label381 = Label38;
      point1 = new Point(40, 224);
      Point point67 = point1;
      label381.Location = point67;
      Label38.Name = "Label38";
      Label label382 = Label38;
      size1 = new Size(112, 18);
      Size size66 = size1;
      label382.Size = size66;
      Label38.TabIndex = 20;
      Label38.Text = "OnMeleeAttacked";
      Label38.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnOpen1 = TbOnOpen;
      point1 = new Point(160, 250);
      Point point68 = point1;
      tbOnOpen1.Location = point68;
      TbOnOpen.Name = "tbOnOpen";
      TextBox tbOnOpen2 = TbOnOpen;
      size1 = new Size(204, 20);
      Size size67 = size1;
      tbOnOpen2.Size = size67;
      TbOnOpen.TabIndex = 18;
      TbOnOpen.Text = "";
      Label label391 = Label39;
      point1 = new Point(40, 250);
      Point point69 = point1;
      label391.Location = point69;
      Label39.Name = "Label39";
      Label label392 = Label39;
      size1 = new Size(112, 18);
      Size size68 = size1;
      label392.Size = size68;
      Label39.TabIndex = 21;
      Label39.Text = "OnOpen";
      Label39.TextAlign = ContentAlignment.MiddleLeft;
      Label label401 = Label40;
      point1 = new Point(40, 276);
      Point point70 = point1;
      label401.Location = point70;
      Label40.Name = "Label40";
      Label label402 = Label40;
      size1 = new Size(112, 18);
      Size size69 = size1;
      label402.Size = size69;
      Label40.TabIndex = 19;
      Label40.Text = "OnSpellCastAt";
      Label40.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnSpellCastAt1 = TbOnSpellCastAt;
      point1 = new Point(160, 276);
      Point point71 = point1;
      tbOnSpellCastAt1.Location = point71;
      TbOnSpellCastAt.Name = "tbOnSpellCastAt";
      TextBox tbOnSpellCastAt2 = TbOnSpellCastAt;
      size1 = new Size(204, 20);
      Size size70 = size1;
      tbOnSpellCastAt2.Size = size70;
      TbOnSpellCastAt.TabIndex = 20;
      TbOnSpellCastAt.Text = "";
      Label label411 = Label41;
      point1 = new Point(40, 302);
      Point point72 = point1;
      label411.Location = point72;
      Label41.Name = "Label41";
      Label label412 = Label41;
      size1 = new Size(112, 18);
      Size size71 = size1;
      label412.Size = size71;
      Label41.TabIndex = 24;
      Label41.Text = "OnTrapTriggered";
      Label41.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnTrapTriggered1 = TbOnTrapTriggered;
      point1 = new Point(160, 302);
      Point point73 = point1;
      tbOnTrapTriggered1.Location = point73;
      TbOnTrapTriggered.Name = "tbOnTrapTriggered";
      TextBox tbOnTrapTriggered2 = TbOnTrapTriggered;
      size1 = new Size(204, 20);
      Size size72 = size1;
      tbOnTrapTriggered2.Size = size72;
      TbOnTrapTriggered.TabIndex = 22;
      TbOnTrapTriggered.Text = "";
      TextBox tbOnUnlock1 = TbOnUnlock;
      point1 = new Point(160, 328);
      Point point74 = point1;
      tbOnUnlock1.Location = point74;
      TbOnUnlock.Name = "tbOnUnlock";
      TextBox tbOnUnlock2 = TbOnUnlock;
      size1 = new Size(204, 20);
      Size size73 = size1;
      tbOnUnlock2.Size = size73;
      TbOnUnlock.TabIndex = 24;
      TbOnUnlock.Text = "";
      Label label421 = Label42;
      point1 = new Point(40, 328);
      Point point75 = point1;
      label421.Location = point75;
      Label42.Name = "Label42";
      Label label422 = Label42;
      size1 = new Size(112, 18);
      Size size74 = size1;
      label422.Size = size74;
      Label42.TabIndex = 23;
      Label42.Text = "OnUnlock";
      Label42.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnUserDefined1 = TbOnUserDefined;
      point1 = new Point(160, 380);
      Point point76 = point1;
      tbOnUserDefined1.Location = point76;
      TbOnUserDefined.Name = "tbOnUserDefined";
      TextBox tbOnUserDefined2 = TbOnUserDefined;
      size1 = new Size(204, 20);
      Size size75 = size1;
      tbOnUserDefined2.Size = size75;
      TbOnUserDefined.TabIndex = 28;
      TbOnUserDefined.Text = "";
      Label label431 = Label43;
      point1 = new Point(40, 380);
      Point point77 = point1;
      label431.Location = point77;
      Label43.Name = "Label43";
      Label label432 = Label43;
      size1 = new Size(112, 18);
      Size size76 = size1;
      label432.Size = size76;
      Label43.TabIndex = 22;
      Label43.Text = "OnUserDefined";
      Label43.TextAlign = ContentAlignment.MiddleLeft;
      Label label211 = Label21;
      point1 = new Point(40, 120);
      Point point78 = point1;
      label211.Location = point78;
      Label21.Name = "Label21";
      Label label212 = Label21;
      size1 = new Size(112, 18);
      Size size77 = size1;
      label212.Size = size77;
      Label21.TabIndex = 30;
      Label21.Text = "OnEndDialogue";
      Label21.TextAlign = ContentAlignment.MiddleLeft;
      TextBox tbOnEndDialogue1 = TbOnEndDialogue;
      point1 = new Point(160, 120);
      Point point79 = point1;
      tbOnEndDialogue1.Location = point79;
      TbOnEndDialogue.Name = "tbOnEndDialogue";
      TextBox tbOnEndDialogue2 = TbOnEndDialogue;
      size1 = new Size(204, 20);
      Size size78 = size1;
      tbOnEndDialogue2.Size = size78;
      TbOnEndDialogue.TabIndex = 8;
      TbOnEndDialogue.Text = "";
      TextBox tbOnInvDisturbed1 = TbOnInvDisturbed;
      point1 = new Point(160, 172);
      Point point80 = point1;
      tbOnInvDisturbed1.Location = point80;
      TbOnInvDisturbed.Name = "tbOnInvDisturbed";
      TextBox tbOnInvDisturbed2 = TbOnInvDisturbed;
      size1 = new Size(204, 20);
      Size size79 = size1;
      tbOnInvDisturbed2.Size = size79;
      TbOnInvDisturbed.TabIndex = 12;
      TbOnInvDisturbed.Text = "";
      Label label221 = Label22;
      point1 = new Point(40, 172);
      Point point81 = point1;
      label221.Location = point81;
      Label22.Name = "Label22";
      Label label222 = Label22;
      size1 = new Size(112, 18);
      Size size80 = size1;
      label222.Size = size80;
      Label22.TabIndex = 30;
      Label22.Text = "OnInvDisturbed";
      Label22.TextAlign = ContentAlignment.MiddleLeft;
      TabPageDescription.Controls.Add(BtnSetDescriptionLang);
      TabPageDescription.Controls.Add(TbDescription);
      TabPage tabPageDescription1 = TabPageDescription;
      point1 = new Point(4, 40);
      Point point82 = point1;
      ((Control) tabPageDescription1).Location = point82;
      TabPageDescription.Name = "TabPageDescription";
      TabPage tabPageDescription2 = TabPageDescription;
      size1 = new Size(448, 393);
      Size size81 = size1;
      tabPageDescription2.Size = size81;
      TabPageDescription.TabIndex = 6;
      TabPageDescription.Text = "Description";
      TabPageDescription.Visible = false;
      Button setDescriptionLang1 = BtnSetDescriptionLang;
      point1 = new Point(40, 320);
      Point point83 = point1;
      setDescriptionLang1.Location = point83;
      BtnSetDescriptionLang.Name = "btnSetDescriptionLang";
      Button setDescriptionLang2 = BtnSetDescriptionLang;
      size1 = new Size(88, 23);
      Size size82 = size1;
      setDescriptionLang2.Size = size82;
      BtnSetDescriptionLang.TabIndex = 1;
      BtnSetDescriptionLang.Text = "Set Language";
      TextBox tbDescription1 = TbDescription;
      point1 = new Point(12, 7);
      Point point84 = point1;
      tbDescription1.Location = point84;
      TbDescription.Multiline = true;
      TbDescription.Name = "tbDescription";
      TextBox tbDescription2 = TbDescription;
      size1 = new Size(424, 305);
      Size size83 = size1;
      tbDescription2.Size = size83;
      TbDescription.TabIndex = 0;
      TbDescription.Text = "";
      TabPageComments.Controls.Add(TbComment);
      TabPage tabPageComments1 = TabPageComments;
      point1 = new Point(4, 40);
      Point point85 = point1;
      ((Control) tabPageComments1).Location = point85;
      TabPageComments.Name = "TabPageComments";
      TabPage tabPageComments2 = TabPageComments;
      size1 = new Size(448, 393);
      Size size84 = size1;
      tabPageComments2.Size = size84;
      TabPageComments.TabIndex = 7;
      TabPageComments.Text = "Comments";
      TabPageComments.Visible = false;
      TextBox tbComment1 = TbComment;
      point1 = new Point(12, 7);
      Point point86 = point1;
      tbComment1.Location = point86;
      TbComment.Multiline = true;
      TbComment.Name = "tbComment";
      TextBox tbComment2 = TbComment;
      size1 = new Size(424, 336);
      Size size85 = size1;
      tbComment2.Size = size85;
      TbComment.TabIndex = 0;
      TbComment.Text = "";
      TabPageTrap.Controls.Add(ChkbTrapDisarmable);
      TabPageTrap.Controls.Add(ChkbTrapDetectable);
      TabPageTrap.Controls.Add(Label6);
      TabPageTrap.Controls.Add(Label3);
      TabPageTrap.Controls.Add(NudDisarmDc);
      TabPageTrap.Controls.Add(Label4);
      TabPageTrap.Controls.Add(Label15);
      TabPageTrap.Controls.Add(NudTrapDetectDc);
      TabPageTrap.Controls.Add(Label16);
      TabPageTrap.Controls.Add(LblTrapDetectable);
      TabPageTrap.Controls.Add(NudTrapType);
      TabPageTrap.Controls.Add(Label17);
      TabPageTrap.Controls.Add(ChkbTrapFlag);
      TabPageTrap.Controls.Add(ChkbTrapOneShot);
      TabPage tabPageTrap1 = TabPageTrap;
      point1 = new Point(4, 40);
      Point point87 = point1;
      ((Control) tabPageTrap1).Location = point87;
      TabPageTrap.Name = "TabPageTrap";
      TabPage tabPageTrap2 = TabPageTrap;
      size1 = new Size(448, 393);
      Size size86 = size1;
      tabPageTrap2.Size = size86;
      TabPageTrap.TabIndex = 10;
      TabPageTrap.Text = "Trap";
      CheckBox chkbTrapDisarmable1 = ChkbTrapDisarmable;
      point1 = new Point(192, 85);
      Point point88 = point1;
      chkbTrapDisarmable1.Location = point88;
      ChkbTrapDisarmable.Name = "chkbTrapDisarmable";
      CheckBox chkbTrapDisarmable2 = ChkbTrapDisarmable;
      size1 = new Size(24, 24);
      Size size87 = size1;
      chkbTrapDisarmable2.Size = size87;
      ChkbTrapDisarmable.TabIndex = 2;
      CheckBox chkbTrapDetectable1 = ChkbTrapDetectable;
      point1 = new Point(192, 21);
      Point point89 = point1;
      chkbTrapDetectable1.Location = point89;
      ChkbTrapDetectable.Name = "chkbTrapDetectable";
      CheckBox chkbTrapDetectable2 = ChkbTrapDetectable;
      size1 = new Size(24, 24);
      Size size88 = size1;
      chkbTrapDetectable2.Size = size88;
      ChkbTrapDetectable.TabIndex = 0;
      Label label61 = Label6;
      point1 = new Point(48, 184);
      Point point90 = point1;
      label61.Location = point90;
      Label6.Name = "Label6";
      Label label62 = Label6;
      size1 = new Size(88, 16);
      Size size89 = size1;
      label62.Size = size89;
      Label6.TabIndex = 26;
      Label6.Text = "TrapOneShot";
      Label6.TextAlign = ContentAlignment.MiddleLeft;
      Label label31 = Label3;
      point1 = new Point(48, 152);
      Point point91 = point1;
      label31.Location = point91;
      Label3.Name = "Label3";
      Label label32 = Label3;
      size1 = new Size(88, 16);
      Size size90 = size1;
      label32.Size = size90;
      Label3.TabIndex = 27;
      Label3.Text = "TrapFlag";
      Label3.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudDisarmDc1 = NudDisarmDc;
      point1 = new Point(176, 120);
      Point point92 = point1;
      nudDisarmDc1.Location = point92;
      NumericUpDown nudDisarmDc2 = NudDisarmDc;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num4 = num1;
      nudDisarmDc2.Maximum = num4;
      NudDisarmDc.Name = "nudDisarmDC";
      NudDisarmDc.RightToLeft = RightToLeft.No;
      NumericUpDown nudDisarmDc3 = NudDisarmDc;
      size1 = new Size(48, 20);
      Size size91 = size1;
      nudDisarmDc3.Size = size91;
      NudDisarmDc.TabIndex = 3;
      NudDisarmDc.TextAlign = HorizontalAlignment.Right;
      Label label41 = Label4;
      point1 = new Point(48, 120);
      Point point93 = point1;
      label41.Location = point93;
      Label4.Name = "Label4";
      Label label42 = Label4;
      size1 = new Size(88, 16);
      Size size92 = size1;
      label42.Size = size92;
      Label4.TabIndex = 22;
      Label4.Text = "DisarmDC";
      Label4.TextAlign = ContentAlignment.MiddleLeft;
      Label label151 = Label15;
      point1 = new Point(48, 88);
      Point point94 = point1;
      label151.Location = point94;
      Label15.Name = "Label15";
      Label label152 = Label15;
      size1 = new Size(88, 16);
      Size size93 = size1;
      label152.Size = size93;
      Label15.TabIndex = 23;
      Label15.Text = "TrapDisarmable";
      Label15.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudTrapDetectDc1 = NudTrapDetectDc;
      point1 = new Point(176, 56);
      Point point95 = point1;
      nudTrapDetectDc1.Location = point95;
      NumericUpDown nudTrapDetectDc2 = NudTrapDetectDc;
      num1 = new Decimal(new int[4]{ 250, 0, 0, 0 });
      Decimal num5 = num1;
      nudTrapDetectDc2.Maximum = num5;
      NudTrapDetectDc.Name = "nudTrapDetectDC";
      NudTrapDetectDc.RightToLeft = RightToLeft.No;
      NumericUpDown nudTrapDetectDc3 = NudTrapDetectDc;
      size1 = new Size(48, 20);
      Size size94 = size1;
      nudTrapDetectDc3.Size = size94;
      NudTrapDetectDc.TabIndex = 1;
      NudTrapDetectDc.TextAlign = HorizontalAlignment.Right;
      Label label161 = Label16;
      point1 = new Point(48, 56);
      Point point96 = point1;
      label161.Location = point96;
      Label16.Name = "Label16";
      Label label162 = Label16;
      size1 = new Size(88, 16);
      Size size95 = size1;
      label162.Size = size95;
      Label16.TabIndex = 18;
      Label16.Text = "TrapDetectDC";
      Label16.TextAlign = ContentAlignment.MiddleLeft;
      Label lblTrapDetectable1 = LblTrapDetectable;
      point1 = new Point(48, 24);
      Point point97 = point1;
      lblTrapDetectable1.Location = point97;
      LblTrapDetectable.Name = "lblTrapDetectable";
      Label lblTrapDetectable2 = LblTrapDetectable;
      size1 = new Size(88, 16);
      Size size96 = size1;
      lblTrapDetectable2.Size = size96;
      LblTrapDetectable.TabIndex = 19;
      LblTrapDetectable.Text = "TrapDetectable";
      LblTrapDetectable.TextAlign = ContentAlignment.MiddleLeft;
      NumericUpDown nudTrapType1 = NudTrapType;
      point1 = new Point(176, 216);
      Point point98 = point1;
      nudTrapType1.Location = point98;
      NumericUpDown nudTrapType2 = NudTrapType;
      num1 = new Decimal(new int[4]{ 2, 0, 0, 0 });
      Decimal num6 = num1;
      nudTrapType2.Maximum = num6;
      NudTrapType.Name = "nudTrapType";
      NudTrapType.RightToLeft = RightToLeft.No;
      NumericUpDown nudTrapType3 = NudTrapType;
      size1 = new Size(48, 20);
      Size size97 = size1;
      nudTrapType3.Size = size97;
      NudTrapType.TabIndex = 6;
      NudTrapType.TextAlign = HorizontalAlignment.Right;
      Label label171 = Label17;
      point1 = new Point(48, 216);
      Point point99 = point1;
      label171.Location = point99;
      Label17.Name = "Label17";
      Label label172 = Label17;
      size1 = new Size(88, 16);
      Size size98 = size1;
      label172.Size = size98;
      Label17.TabIndex = 26;
      Label17.Text = "TrapType";
      Label17.TextAlign = ContentAlignment.MiddleLeft;
      CheckBox chkbTrapFlag1 = ChkbTrapFlag;
      point1 = new Point(192, 152);
      Point point100 = point1;
      chkbTrapFlag1.Location = point100;
      ChkbTrapFlag.Name = "chkbTrapFlag";
      CheckBox chkbTrapFlag2 = ChkbTrapFlag;
      size1 = new Size(24, 24);
      Size size99 = size1;
      chkbTrapFlag2.Size = size99;
      ChkbTrapFlag.TabIndex = 4;
      CheckBox chkbTrapOneShot1 = ChkbTrapOneShot;
      point1 = new Point(192, 184);
      Point point101 = point1;
      chkbTrapOneShot1.Location = point101;
      ChkbTrapOneShot.Name = "chkbTrapOneShot";
      CheckBox chkbTrapOneShot2 = ChkbTrapOneShot;
      size1 = new Size(24, 24);
      Size size100 = size1;
      chkbTrapOneShot2.Size = size100;
      ChkbTrapOneShot.TabIndex = 5;
      this.BtnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnSave = this.BtnSave;
      point1 = new Point(312, 480);
      Point point102 = point1;
      btnSave.Location = point102;
      this.BtnSave.Name = "btnSave";
      this.BtnSave.TabIndex = 4;
      this.BtnSave.Text = "&Save";
      this.BtnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      Button btnCancel = this.BtnCancel;
      point1 = new Point(408, 480);
      Point point103 = point1;
      btnCancel.Location = point103;
      this.BtnCancel.Name = "btnCancel";
      this.BtnCancel.TabIndex = 5;
      this.BtnCancel.Text = "&Cancel";
      BtnInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
      Button btnInventory1 = BtnInventory;
      point1 = new Point(64, 480);
      Point point104 = point1;
      btnInventory1.Location = point104;
      BtnInventory.Name = "btnInventory";
      Button btnInventory2 = BtnInventory;
      size1 = new Size(72, 24);
      Size size101 = size1;
      btnInventory2.Size = size101;
      BtnInventory.TabIndex = 9;
      BtnInventory.Text = "&Inventory";
      BtnDebug.FlatStyle = FlatStyle.Flat;
      BtnDebug.ForeColor = SystemColors.Control;
      Button btnDebug1 = BtnDebug;
      point1 = new Point(0, 0);
      Point point105 = point1;
      btnDebug1.Location = point105;
      BtnDebug.Name = "btnDebug";
      Button btnDebug2 = BtnDebug;
      size1 = new Size(8, 9);
      Size size102 = size1;
      btnDebug2.Size = size102;
      BtnDebug.TabIndex = 19;
      BtnDebug.TabStop = false;
      Button btnEditOnClosed1 = BtnEditOnClosed;
      point1 = new Point(384, 16);
      Point point106 = point1;
      btnEditOnClosed1.Location = point106;
      BtnEditOnClosed.Name = "btnEditOnClosed";
      Button btnEditOnClosed2 = BtnEditOnClosed;
      size1 = new Size(32, 23);
      Size size103 = size1;
      btnEditOnClosed2.Size = size103;
      BtnEditOnClosed.TabIndex = 1;
      BtnEditOnClosed.Text = "Edit";
      BtnEditOnClosed.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDamaged1 = BtnEditOnDamaged;
      point1 = new Point(384, 42);
      Point point107 = point1;
      btnEditOnDamaged1.Location = point107;
      BtnEditOnDamaged.Name = "btnEditOnDamaged";
      Button btnEditOnDamaged2 = BtnEditOnDamaged;
      size1 = new Size(32, 23);
      Size size104 = size1;
      btnEditOnDamaged2.Size = size104;
      BtnEditOnDamaged.TabIndex = 3;
      BtnEditOnDamaged.Text = "Edit";
      BtnEditOnDamaged.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDeath1 = BtnEditOnDeath;
      point1 = new Point(384, 68);
      Point point108 = point1;
      btnEditOnDeath1.Location = point108;
      BtnEditOnDeath.Name = "btnEditOnDeath";
      Button btnEditOnDeath2 = BtnEditOnDeath;
      size1 = new Size(32, 23);
      Size size105 = size1;
      btnEditOnDeath2.Size = size105;
      BtnEditOnDeath.TabIndex = 5;
      BtnEditOnDeath.Text = "Edit";
      BtnEditOnDeath.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnDisarm1 = BtnEditOnDisarm;
      point1 = new Point(384, 94);
      Point point109 = point1;
      btnEditOnDisarm1.Location = point109;
      BtnEditOnDisarm.Name = "btnEditOnDisarm";
      Button btnEditOnDisarm2 = BtnEditOnDisarm;
      size1 = new Size(32, 23);
      Size size106 = size1;
      btnEditOnDisarm2.Size = size106;
      BtnEditOnDisarm.TabIndex = 7;
      BtnEditOnDisarm.Text = "Edit";
      BtnEditOnDisarm.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnHeartbeat1 = BtnEditOnHeartbeat;
      point1 = new Point(384, 146);
      Point point110 = point1;
      btnEditOnHeartbeat1.Location = point110;
      BtnEditOnHeartbeat.Name = "btnEditOnHeartbeat";
      Button btnEditOnHeartbeat2 = BtnEditOnHeartbeat;
      size1 = new Size(32, 23);
      Size size107 = size1;
      btnEditOnHeartbeat2.Size = size107;
      BtnEditOnHeartbeat.TabIndex = 11;
      BtnEditOnHeartbeat.Text = "Edit";
      BtnEditOnHeartbeat.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnLock1 = BtnEditOnLock;
      point1 = new Point(384, 198);
      Point point111 = point1;
      btnEditOnLock1.Location = point111;
      BtnEditOnLock.Name = "btnEditOnLock";
      Button btnEditOnLock2 = BtnEditOnLock;
      size1 = new Size(32, 23);
      Size size108 = size1;
      btnEditOnLock2.Size = size108;
      BtnEditOnLock.TabIndex = 15;
      BtnEditOnLock.Text = "Edit";
      BtnEditOnLock.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnMeleeAttacked1 = BtnEditOnMeleeAttacked;
      point1 = new Point(384, 224);
      Point point112 = point1;
      editOnMeleeAttacked1.Location = point112;
      BtnEditOnMeleeAttacked.Name = "btnEditOnMeleeAttacked";
      Button editOnMeleeAttacked2 = BtnEditOnMeleeAttacked;
      size1 = new Size(32, 23);
      Size size109 = size1;
      editOnMeleeAttacked2.Size = size109;
      BtnEditOnMeleeAttacked.TabIndex = 17;
      BtnEditOnMeleeAttacked.Text = "Edit";
      BtnEditOnMeleeAttacked.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnOpen1 = BtnEditOnOpen;
      point1 = new Point(384, 250);
      Point point113 = point1;
      btnEditOnOpen1.Location = point113;
      BtnEditOnOpen.Name = "btnEditOnOpen";
      Button btnEditOnOpen2 = BtnEditOnOpen;
      size1 = new Size(32, 23);
      Size size110 = size1;
      btnEditOnOpen2.Size = size110;
      BtnEditOnOpen.TabIndex = 19;
      BtnEditOnOpen.Text = "Edit";
      BtnEditOnOpen.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnSpellCastAt1 = BtnEditOnSpellCastAt;
      point1 = new Point(384, 276);
      Point point114 = point1;
      editOnSpellCastAt1.Location = point114;
      BtnEditOnSpellCastAt.Name = "btnEditOnSpellCastAt";
      Button editOnSpellCastAt2 = BtnEditOnSpellCastAt;
      size1 = new Size(32, 23);
      Size size111 = size1;
      editOnSpellCastAt2.Size = size111;
      BtnEditOnSpellCastAt.TabIndex = 21;
      BtnEditOnSpellCastAt.Text = "Edit";
      BtnEditOnSpellCastAt.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnTrapTriggered1 = BtnEditOnTrapTriggered;
      point1 = new Point(384, 302);
      Point point115 = point1;
      editOnTrapTriggered1.Location = point115;
      BtnEditOnTrapTriggered.Name = "btnEditOnTrapTriggered";
      Button editOnTrapTriggered2 = BtnEditOnTrapTriggered;
      size1 = new Size(32, 23);
      Size size112 = size1;
      editOnTrapTriggered2.Size = size112;
      BtnEditOnTrapTriggered.TabIndex = 23;
      BtnEditOnTrapTriggered.Text = "Edit";
      BtnEditOnTrapTriggered.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnUserDefined1 = BtnEditOnUserDefined;
      point1 = new Point(384, 380);
      Point point116 = point1;
      editOnUserDefined1.Location = point116;
      BtnEditOnUserDefined.Name = "btnEditOnUserDefined";
      Button editOnUserDefined2 = BtnEditOnUserDefined;
      size1 = new Size(32, 23);
      Size size113 = size1;
      editOnUserDefined2.Size = size113;
      BtnEditOnUserDefined.TabIndex = 29;
      BtnEditOnUserDefined.Text = "Edit";
      BtnEditOnUserDefined.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnUnlock1 = BtnEditOnUnlock;
      point1 = new Point(384, 328);
      Point point117 = point1;
      btnEditOnUnlock1.Location = point117;
      BtnEditOnUnlock.Name = "btnEditOnUnlock";
      Button btnEditOnUnlock2 = BtnEditOnUnlock;
      size1 = new Size(32, 23);
      Size size114 = size1;
      btnEditOnUnlock2.Size = size114;
      BtnEditOnUnlock.TabIndex = 25;
      BtnEditOnUnlock.Text = "Edit";
      BtnEditOnUnlock.TextAlign = ContentAlignment.MiddleLeft;
      Button btnEditOnUsed1 = BtnEditOnUsed;
      point1 = new Point(384, 354);
      Point point118 = point1;
      btnEditOnUsed1.Location = point118;
      BtnEditOnUsed.Name = "btnEditOnUsed";
      Button btnEditOnUsed2 = BtnEditOnUsed;
      size1 = new Size(32, 23);
      Size size115 = size1;
      btnEditOnUsed2.Size = size115;
      BtnEditOnUsed.TabIndex = 27;
      BtnEditOnUsed.Text = "Edit";
      BtnEditOnUsed.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnInvDisturbed1 = BtnEditOnInvDisturbed;
      point1 = new Point(384, 172);
      Point point119 = point1;
      editOnInvDisturbed1.Location = point119;
      BtnEditOnInvDisturbed.Name = "btnEditOnInvDisturbed";
      Button editOnInvDisturbed2 = BtnEditOnInvDisturbed;
      size1 = new Size(32, 23);
      Size size116 = size1;
      editOnInvDisturbed2.Size = size116;
      BtnEditOnInvDisturbed.TabIndex = 13;
      BtnEditOnInvDisturbed.Text = "Edit";
      BtnEditOnInvDisturbed.TextAlign = ContentAlignment.MiddleLeft;
      Button editOnEndDialogue1 = BtnEditOnEndDialogue;
      point1 = new Point(384, 120);
      Point point120 = point1;
      editOnEndDialogue1.Location = point120;
      BtnEditOnEndDialogue.Name = "btnEditOnEndDialogue";
      Button editOnEndDialogue2 = BtnEditOnEndDialogue;
      size1 = new Size(32, 23);
      Size size117 = size1;
      editOnEndDialogue2.Size = size117;
      BtnEditOnEndDialogue.TabIndex = 9;
      BtnEditOnEndDialogue.Text = "Edit";
      BtnEditOnEndDialogue.TextAlign = ContentAlignment.MiddleLeft;
      size1 = new Size(5, 13);
      AutoScaleBaseSize = size1;
      size1 = new Size(496, 517);
      ClientSize = size1;
      Controls.Add(BtnDebug);
      Controls.Add(TabControl1);
      Controls.Add(this.BtnSave);
      Controls.Add(this.BtnCancel);
      Controls.Add(BtnInventory);
      Name = "FrmUtpEditor";
      Text = "Placeable Editor - KotOR ";
      TabControl1.ResumeLayout(false);
      TabPageBasic.ResumeLayout(false);
      NudWill.EndInit();
      NudFort.EndInit();
      NudHp.EndInit();
      NudHardness.EndInit();
      NudRef.EndInit();
      TabPageLock.ResumeLayout(false);
      NudCloseLockDc.EndInit();
      NudOpenLockDc.EndInit();
      TabPageAdvanced.ResumeLayout(false);
      TabPageScripts.ResumeLayout(false);
      TabPageDescription.ResumeLayout(false);
      TabPageComments.ResumeLayout(false);
      TabPageTrap.ResumeLayout(false);
      NudDisarmDc.EndInit();
      NudTrapDetectDc.EndInit();
      NudTrapType.EndInit();
      ResumeLayout(false);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    public void Setup()
    {
      BuildComboBoxes();
      Utp.SetTextBoxFromCExoLocStringNodeValue(TbName, "LocName");
      Utp.SetTextBoxToNodeValue(TbTag, "Tag");
      ChkbPlotItem.Checked = BooleanType.FromObject(Utp.GetNodeValue("Plot"));
      ChkbStatic.Checked = BooleanType.FromObject(Utp.GetNodeValue("Static"));
      ChkbMin1Hp.Checked = BooleanType.FromObject(Utp.GetNodeValue("Min1HP"));
      Utp.SetNumericUpDownToNodeValue(NudHardness, "Hardness");
      Utp.SetNumericUpDownToNodeValue(NudHp, "HP");
      Utp.SetNumericUpDownToNodeValue(NudFort, "Fort");
      Utp.SetNumericUpDownToNodeValue(NudRef, "Ref");
      Utp.SetNumericUpDownToNodeValue(NudWill, "Will");
      ChkbLocked.Checked = BooleanType.FromObject(Utp.GetNodeValue("Locked"));
      ChkbLockable.Checked = BooleanType.FromObject(Utp.GetNodeValue("Lockable"));
      ChkbAutoRemoveKey.Checked = BooleanType.FromObject(Utp.GetNodeValue("AutoRemoveKey"));
      ChkbKeyRequired.Checked = BooleanType.FromObject(Utp.GetNodeValue("KeyRequired"));
      Utp.SetNumericUpDownToNodeValue(NudOpenLockDc, "OpenLockDC");
      Utp.SetNumericUpDownToNodeValue(NudCloseLockDc, "CloseLockDC");
      Utp.SetTextBoxToNodeValue(TbKeyName, "KeyName");
      Utp.SetTextBoxToNodeValue(TbOnClosed, "OnClosed");
      Utp.SetTextBoxToNodeValue(TbOnDamaged, "OnDamaged");
      Utp.SetTextBoxToNodeValue(TbOnDeath, "OnDeath");
      Utp.SetTextBoxToNodeValue(TbOnDisarm, "OnDisarm");
      Utp.SetTextBoxToNodeValue(TbOnEndDialogue, "OnEndDialogue");
      Utp.SetTextBoxToNodeValue(TbOnHeartbeat, "OnHeartbeat");
      Utp.SetTextBoxToNodeValue(TbOnInvDisturbed, "OnInvDisturbed");
      Utp.SetTextBoxToNodeValue(TbOnLock, "OnLock");
      Utp.SetTextBoxToNodeValue(TbOnMeleeAttacked, "OnMeleeAttacked");
      Utp.SetTextBoxToNodeValue(TbOnOpen, "OnOpen");
      Utp.SetTextBoxToNodeValue(TbOnSpellCastAt, "OnSpellCastAt");
      Utp.SetTextBoxToNodeValue(TbOnTrapTriggered, "OnTrapTriggered");
      Utp.SetTextBoxToNodeValue(TbOnUnlock, "OnUnlock");
      Utp.SetTextBoxToNodeValue(TbOnUsed, "OnUsed");
      Utp.SetTextBoxToNodeValue(TbOnUserDefined, "OnUserDefined");
      Utp.SetTextBoxToNodeValue(TbTemplateResRef, "TemplateResRef");
      Utp.SetTextBoxToNodeValue(TbFaction, "Faction");
      Utp.SetTextBoxToNodeValue(TbConversation, "Conversation");
      ChkbInterruptable.Checked = BooleanType.FromObject(Utp.GetNodeValue("Interruptable"));
      Utp.SetTextBoxToNodeValue(TbAnimationState, "AnimationState");
      Utp.SetTextBoxToNodeValue(TbType, "Type");
      ChkbHasInventory.Checked = BooleanType.FromObject(Utp.GetNodeValue("HasInventory"));
      ChkbPartyInteract.Checked = BooleanType.FromObject(Utp.GetNodeValue("PartyInteract"));
      ChkbUsable.Checked = BooleanType.FromObject(Utp.GetNodeValue("Useable"));
      ChkbTrapDetectable.Checked = BooleanType.FromObject(Utp.GetNodeValue("TrapDetectable"));
      Utp.SetNumericUpDownToNodeValue(NudTrapDetectDc, "TrapDetectDC");
      ChkbTrapDisarmable.Checked = BooleanType.FromObject(Utp.GetNodeValue("TrapDisarmable"));
      Utp.SetNumericUpDownToNodeValue(NudDisarmDc, "DisarmDC");
      ChkbTrapFlag.Checked = BooleanType.FromObject(Utp.GetNodeValue("TrapFlag"));
      ChkbTrapOneShot.Checked = BooleanType.FromObject(Utp.GetNodeValue("TrapOneShot"));
      Utp.SetNumericUpDownToNodeValue(NudTrapType, "TrapType");
      Utp.SetTextBoxToNodeValue(TbKeyName, "KeyName");
      Utp.SetTextBoxFromCExoLocStringNodeValue(TbDescription, "Description");
      _descriptionLang = IntegerType.FromObject(Utp.GetCExoLocStringLanguage("Description"));
      TbDescription.Text = Strings.Replace(TbDescription.Text, "\n", "\r\n");
      Utp.SetTextBoxToNodeValue(TbComment, "Comment");
    }

    private void SetGffNodeValues()
    {
      Utp.SetNodeValueFromComboBox(CmbxAppearance, "Appearance");
      Utp.SetCExoLocStringNodeValueFromTextBox(TbName, "LocName", _nameLang);
      Utp.SetNodeValueFromTextBox(TbTag, "Tag");
      Utp.SetNodeValue("Plot", ChkbPlotItem.Checked);
      if (Utp.VerifyNodeExists("Static"))
        Utp.SetNodeValue("Static", ChkbStatic.Checked);
      if (Utp.VerifyNodeExists("Min1HP"))
        Utp.SetNodeValue("Min1HP", ChkbMin1Hp.Checked);
      Utp.SetNodeValueFromNumericUpDown(NudHardness, "Hardness");
      Utp.SetNodeValueFromNumericUpDown(NudHp, "HP");
      Utp.SetNodeValueFromNumericUpDown(NudFort, "Fort");
      Utp.SetNodeValueFromNumericUpDown(NudRef, "Ref");
      Utp.SetNodeValueFromNumericUpDown(NudWill, "Will");
      Utp.SetNodeValue("Locked", ChkbLocked.Checked);
      Utp.SetNodeValue("Lockable", ChkbLockable.Checked);
      Utp.SetNodeValue("AutoRemoveKey", ChkbAutoRemoveKey.Checked);
      Utp.SetNodeValue("KeyRequired", ChkbKeyRequired.Checked);
      Utp.SetNodeValueFromNumericUpDown(NudOpenLockDc, "OpenLockDC");
      Utp.SetNodeValueFromNumericUpDown(NudCloseLockDc, "CloseLockDC");
      Utp.SetNodeValueFromTextBox(TbKeyName, "KeyName");
      Utp.SetNodeValueFromTextBox(TbOnClosed, "OnClosed");
      Utp.SetNodeValueFromTextBox(TbOnDamaged, "OnDamaged");
      Utp.SetNodeValueFromTextBox(TbOnDeath, "OnDeath");
      Utp.SetNodeValueFromTextBox(TbOnDisarm, "OnDisarm");
      Utp.SetNodeValueFromTextBox(TbOnEndDialogue, "OnEndDialogue");
      Utp.SetNodeValueFromTextBox(TbOnHeartbeat, "OnHeartbeat");
      Utp.SetNodeValueFromTextBox(TbOnInvDisturbed, "OnInvDisturbed");
      Utp.SetNodeValueFromTextBox(TbOnLock, "OnLock");
      Utp.SetNodeValueFromTextBox(TbOnMeleeAttacked, "OnMeleeAttacked");
      Utp.SetNodeValueFromTextBox(TbOnOpen, "OnOpen");
      Utp.SetNodeValueFromTextBox(TbOnSpellCastAt, "OnSpellCastAt");
      Utp.SetNodeValueFromTextBox(TbOnTrapTriggered, "OnTrapTriggered");
      Utp.SetNodeValueFromTextBox(TbOnUnlock, "OnUnlock");
      Utp.SetNodeValueFromTextBox(TbOnUsed, "OnUsed");
      Utp.SetNodeValueFromTextBox(TbOnUserDefined, "OnUserDefined");
      Utp.SetNodeValueFromTextBox(TbTemplateResRef, "TemplateResRef");
      Utp.SetNodeValueFromTextBox(TbFaction, "Faction");
      Utp.SetNodeValueFromTextBox(TbConversation, "Conversation");
      Utp.SetNodeValue("Interruptable", ChkbInterruptable.Checked);
      Utp.SetNodeValueFromTextBox(TbAnimationState, "AnimationState");
      Utp.SetNodeValueFromTextBox(TbType, "Type");
      Utp.SetNodeValue("HasInventory", ChkbHasInventory.Checked);
      Utp.SetNodeValue("PartyInteract", ChkbPartyInteract.Checked);
      Utp.SetNodeValue("Useable", ChkbUsable.Checked);
      Utp.SetNodeValue("TrapDetectable", ChkbTrapDetectable.Checked);
      Utp.SetNodeValueFromNumericUpDown(NudTrapDetectDc, "TrapDetectDC");
      Utp.SetNodeValue("TrapDisarmable", ChkbTrapDisarmable.Checked);
      Utp.SetNodeValueFromNumericUpDown(NudDisarmDc, "DisarmDC");
      Utp.SetNodeValue("TrapFlag", ChkbTrapFlag.Checked);
      Utp.SetNodeValue("TrapOneShot", ChkbTrapOneShot.Checked);
      Utp.SetNodeValueFromNumericUpDown(NudTrapType, "TrapType");
      Utp.SetNodeValueFromTextBox(TbKeyName, "KeyName");
      Utp.SetCExoLocStringNodeValueFromTextBox(TbDescription, "Description");
      Utp.SetCExoLocStringNodeValueFromTextBox(new TextBox()
      {
        Text = Strings.Replace(TbDescription.Text, "\r\n", "\n")
      }, "Description", _descriptionLang);
      Utp.SetNodeValueFromTextBox(TbComment, "Comment");
    }

    private object BuildComboBoxes()
    {
      GClsChitinKey = new ClsChitinKey(ConfigOptions.Paths.KeyFileLocation(KotorVersionIndex));
      FillComboBoxFrom2Da(CmbxAppearance, "label", "placeables", GClsChitinKey, null);
      if (!Utp.SyncComboBox(CmbxAppearance, "Appearance"))
      {
        int num = (int) Interaction.MsgBox("One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.", MsgBoxStyle.Critical, "Menu setting error");
      }
      GClsChitinKey = null;
      object obj = null;
      return obj;
    }

    private void FillComboBoxFrom2Da(ComboBox cmbx, string colName, string twoDaName, ClsChitinKey chitinKey, ClsDialogTlk dialogTlk)
    {
      Cls2Da cls2Da = ReadCls2Da(twoDaName, chitinKey);
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
          checked { ++rowNumber; }
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
          checked { ++rowNumber; }
        }
      }
    }

    private void chkbLocked_CheckedChanged(object sender, EventArgs e)
    {
      if (ChkbLockable.Checked)
        return;
      bool flag = BooleanType.FromObject(LateBinding.LateGet(sender, null, "checked", new object[0], null, null));
      ChkbAutoRemoveKey.Enabled = flag;
      ChkbKeyRequired.Enabled = flag;
      LblOpenLockDc.Enabled = flag;
      LblKeyTag.Enabled = flag;
      TbKeyName.Enabled = flag;
      NudOpenLockDc.Enabled = flag;
    }

    private void chkbLockable_CheckedChanged(object sender, EventArgs e)
    {
      bool flag = BooleanType.FromObject(LateBinding.LateGet(sender, null, "checked", new object[0], null, null));
      if (!ChkbLocked.Checked)
      {
        ChkbAutoRemoveKey.Enabled = flag;
        ChkbKeyRequired.Enabled = flag;
        LblOpenLockDc.Enabled = flag;
        LblKeyTag.Enabled = flag;
        TbKeyName.Enabled = flag;
        NudOpenLockDc.Enabled = flag;
      }
      LblCloseLockDc.Enabled = flag;
      NudCloseLockDc.Enabled = flag;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      SetGffNodeValues();
      if (!_mBSaveGameMode)
      {
        m_EditingFilePath = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation, Path.GetFileNameWithoutExtension(m_EditingFilePath) + ".utp", "", ""));
        if (StringType.StrCmp(m_EditingFilePath, "", false) == 0)
          return;
      }
      Utp.WriteFile(m_EditingFilePath, "UTP");
      if (!_mBSaveGameMode)
        return;
      Close();
    }

    private void btnSetNameLang_Click(object sender, EventArgs e)
    {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(_nameLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      _nameLang = stringLanguagePicker.LanguageID;
    }

    private void btnSetDescLang_Click(object sender, EventArgs e)
    {
      frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(_descriptionLang);
      if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
        return;
      _descriptionLang = stringLanguagePicker.LanguageID;
    }

    private void btnInventory_Click(object sender, EventArgs e)
    {
      FrmInventoryEditor frmInventoryEditor = new FrmInventoryEditor(KotorVersionIndex);
      int num1 = 0;
      int num2 = checked (Utp.GetListItemCount("ItemList") - 1);
      int num3 = num1;
      while (num3 <= num2)
      {
        string resRef = StringType.FromObject(Utp.GetNodeValue("ItemList(" + StringType.FromInteger(num3) + ").InventoryRes"));
        bool dropable = !Utp.VerifyNodeExists("ItemList(" + StringType.FromInteger(num3) + ").Dropable") || ObjectType.ObjTst(Utp.GetNodeValue("ItemList(" + StringType.FromInteger(num3) + ").Dropable"), 1, false) == 0;
        frmInventoryEditor.AddPackItem(resRef, dropable);
        checked { ++num3; }
      }
      frmInventoryEditor.SetFormName(TbTemplateResRef.Text + ".utp");
      frmInventoryEditor.ConfigureForPlaceableEditorUse();
      if (frmInventoryEditor.ShowDialog() != DialogResult.OK)
        return;
      int num4 = 0;
      Utp.ClearListElements("ItemList");
    
        foreach (InventoryItem packItems in frmInventoryEditor.GetPackItemsList())
        {
          int num5 = 1;
          int quantity = packItems.Quantity;
          int num6 = num5;
          while (num6 <= quantity)
          {
            GffStruct @struct = new GffStruct();
            @struct.Type = num4;
            @struct.FieldCount = 4;
            @struct.Fields = new GffField[4];
            @struct.Fields[0] = new GffField(GffFieldTypes.GffCResRef, "InventoryRes", packItems.ResRef);
            @struct.Fields[1] = new GffField(GffFieldTypes.GffWord, "Repos_PosX", num4);
            @struct.Fields[2] = new GffField(GffFieldTypes.GffWord, "Repos_PosY", 0);
            @struct.Fields[3] = new GffField(GffFieldTypes.GffByte, "Dropable", 1);
            if (!Utp.VerifyNodeExists("ItemList"))
              Utp.CreateList("", "ItemList");
            Utp.AddListElement("ItemList", @struct);
            checked { ++num4; }
            checked { ++num6; }
          }
        }
     
    }

    private void btnDebug_Click(object sender, EventArgs e)
    {
      frmTextEditor frmTextEditor = new frmTextEditor();
      frmTextEditor.Filename = TbName.Text + ".utp";
      frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
      frmTextEditor.RTFMode = true;
      frmTextEditor.tbGeneric.Rtf = Utp.ToString();
      frmTextEditor.tbGeneric.SelectionLength = 0;
      frmTextEditor.Show();
    }

    public Cls2Da ReadCls2Da(string twoDaName, ClsChitinKey chitinKey)
    {
      bool flag = true;
      byte[] numArray = null;
      if (ConfigOptions.Toggles.UseOverrideFiles)
      {
        string path = ConfigOptions.Paths.KotorLocation(KotorVersionIndex) + "\\override\\" + twoDaName + ".2da";
        try
        {
          if (File.Exists(path))
          {
            FileStream fileStream = new FileStream(path, FileMode.Open);
            numArray = new byte[(int) fileStream.Length + 1];
            fileStream.Read(numArray, 0,(int) fileStream.Length);
            fileStream.Close();
            flag = false;
            Console.WriteLine("Read " + twoDaName + ".2da from override");
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Console.WriteLine("Could not load " + path + " in " + GetType().Name);
          ProjectData.ClearProjectError();
        }
      }
      if (flag)
      {
        int resIdForResRef = chitinKey.FindResIdForResRef(twoDaName, 2017);
       // numArray = BiffArchive.GetBiffResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + ChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
        Console.WriteLine("Read " + twoDaName + ".2da from 2da.bif");
      }
      return new Cls2Da(numArray);
    }

    private void frmUTP_Editor_Load(object sender, EventArgs e)
    {
      PositionWindow(GetType().Name);
    }

    private void frmUTP_Editor_Closing(object sender, CancelEventArgs e)
    {
      //SaveSettings(GetType().Name);
    }

    public void SetFormName(string name)
    {
      Text = "Placeable Editor - " + name;
    }

    private void btnEditScript_Click(object sender, EventArgs e)
    {
      Utils.Utils.EditScriptForTextBox((Button) sender, m_EditingFilePath, KotorVersionIndex);
    }
  }
}
