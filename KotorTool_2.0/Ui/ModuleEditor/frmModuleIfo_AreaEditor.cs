// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmModuleIfo_AreaEditor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.CExoLocStringLangPicker;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Utils;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.ModuleEditor
{
    public class FrmModuleIfoAreaEditor : frmParent
    {
        [AccessedThroughProperty("rbAlwaysDay")]
        private RadioButton _rbAlwaysDay;

        [AccessedThroughProperty("rbDayNightCycle")]
        private RadioButton _rbDayNightCycle;

        [AccessedThroughProperty("btnMoonAmbientColor")]
        private Button _btnMoonAmbientColor;

        [AccessedThroughProperty("btnMoonDiffuseColor")]
        private Button _btnMoonDiffuseColor;

        [AccessedThroughProperty("chkbAreaSunShadows")]
        private CheckBox _chkbAreaSunShadows;

        [AccessedThroughProperty("gbMoon")] private GroupBox _gbMoon;
        [AccessedThroughProperty("gbSun")] private GroupBox _gbSun;

        [AccessedThroughProperty("btnSunAmbientColor")]
        private Button _btnSunAmbientColor;

        [AccessedThroughProperty("btnSunDiffuseColor")]
        private Button _btnSunDiffuseColor;

        [AccessedThroughProperty("tabpagAreaEnvironment")]
        private TabPage _tabpagAreaEnvironment;

        [AccessedThroughProperty("tabpagAreaGrass")]
        private TabPage _tabpagAreaGrass;

        [AccessedThroughProperty("tabpagAreaBasic")]
        private TabPage _tabpagAreaBasic;

        [AccessedThroughProperty("btnGrassEmissiveColor")]
        private Button _btnGrassEmissiveColor;

        [AccessedThroughProperty("Label45")] private Label _label45;
        [AccessedThroughProperty("Label47")] private Label _label47;
        [AccessedThroughProperty("Label49")] private Label _label49;
        [AccessedThroughProperty("Label50")] private Label _label50;
        [AccessedThroughProperty("Label51")] private Label _label51;

        [AccessedThroughProperty("tabpagAreaAudio")]
        private TabPage _tabpagAreaAudio;

        [AccessedThroughProperty("Label52")] private Label _label52;

        [AccessedThroughProperty("trkbarAmbientSndDayVol")]
        private TrackBar _trkbarAmbientSndDayVol;

        [AccessedThroughProperty("Label34")] private Label _label34;

        [AccessedThroughProperty("cmbxAmbientSndDay")]
        private ComboBox _cmbxAmbientSndDay;

        [AccessedThroughProperty("trkbarAmbientSndNightVol")]
        private TrackBar _trkbarAmbientSndNightVol;

        [AccessedThroughProperty("nudMusicDelay")]
        private NumericUpDown _nudMusicDelay;

        [AccessedThroughProperty("cmbxMusicNight")]
        private ComboBox _cmbxMusicNight;

        [AccessedThroughProperty("Label35")] private Label _label35;
        [AccessedThroughProperty("Label25")] private Label _label25;

        [AccessedThroughProperty("cmbxMusicDay")]
        private ComboBox _cmbxMusicDay;

        [AccessedThroughProperty("Label36")] private Label _label36;

        [AccessedThroughProperty("cmbxMusicBattle")]
        private ComboBox _cmbxMusicBattle;

        [AccessedThroughProperty("cmbxEnvAudio")]
        private ComboBox _cmbxEnvAudio;

        [AccessedThroughProperty("cmbxAmbientSndNight")]
        private ComboBox _cmbxAmbientSndNight;

        [AccessedThroughProperty("tbGrass_TexName")]
        private TextBox _tbGrassTexName;

        [AccessedThroughProperty("trkbarGrassDensityX10")]
        private TrackBar _trkbarGrassDensityX10;

        [AccessedThroughProperty("Label62")] private Label _label62;

        [AccessedThroughProperty("nudGrassDensity")]
        private NumericUpDown _nudGrassDensity;

        [AccessedThroughProperty("Label63")] private Label _label63;
        [AccessedThroughProperty("Label31")] private Label _label31;
        [AccessedThroughProperty("Label64")] private Label _label64;
        [AccessedThroughProperty("Label53")] private Label _label53;
        [AccessedThroughProperty("Label54")] private Label _label54;
        [AccessedThroughProperty("Label55")] private Label _label55;
        [AccessedThroughProperty("Label2")] private Label _label2;
        [AccessedThroughProperty("Label37")] private Label _label37;

        [AccessedThroughProperty("lblSunFogNear")]
        private Label _lblSunFogNear;

        [AccessedThroughProperty("lblMoonFogFar")]
        private Label _lblMoonFogFar;

        [AccessedThroughProperty("Label33")] private Label _label33;

        [AccessedThroughProperty("lblMoonFogNear")]
        private Label _lblMoonFogNear;

        [AccessedThroughProperty("Label65")] private Label _label65;
        [AccessedThroughProperty("Label66")] private Label _label66;
        [AccessedThroughProperty("Label67")] private Label _label67;

        [AccessedThroughProperty("nudGrassProbUL")]
        private NumericUpDown _nudGrassProbUl;

        [AccessedThroughProperty("nudGrassProbLL")]
        private NumericUpDown _nudGrassProbLl;

        [AccessedThroughProperty("nudGrassProbUR")]
        private NumericUpDown _nudGrassProbUr;

        [AccessedThroughProperty("Label38")] private Label _label38;

        [AccessedThroughProperty("tbModEntryArea")]
        private TextBox _tbModEntryArea;

        [AccessedThroughProperty("lblBearing")]
        private Label _lblBearing;

        [AccessedThroughProperty("nudXY")] private NumericUpDown _nudXy;
        [AccessedThroughProperty("pboxXY")] private PictureBox _pboxXy;
        [AccessedThroughProperty("Label86")] private Label _label86;

        [AccessedThroughProperty("chkbDisableTransit")]
        private CheckBox _chkbDisableTransit;

        [AccessedThroughProperty("Label85")] private Label _label85;

        [AccessedThroughProperty("chkbUnescapable")]
        private CheckBox _chkbUnescapable;

        [AccessedThroughProperty("Label84")] private Label _label84;

        [AccessedThroughProperty("cmbxWindPower")]
        private ComboBox _cmbxWindPower;

        [AccessedThroughProperty("btnSetAreaNameLang")]
        private Button _btnSetAreaNameLang;

        [AccessedThroughProperty("btnSetModNameLang")]
        private Button _btnSetModNameLang;

        [AccessedThroughProperty("tbModDescription")]
        private TextBox _tbModDescription;

        [AccessedThroughProperty("nudRoomForceRating")]
        private NumericUpDown _nudRoomForceRating;

        [AccessedThroughProperty("tbRoomName")]
        private TextBox _tbRoomName;

        [AccessedThroughProperty("cmbxRoomEnvAudio")]
        private ComboBox _cmbxRoomEnvAudio;

        [AccessedThroughProperty("nudRoomAmbientScale")]
        private NumericUpDown _nudRoomAmbientScale;

        [AccessedThroughProperty("chkbRoomDisableWeather")]
        private CheckBox _chkbRoomDisableWeather;

        [AccessedThroughProperty("Label83")] private Label _label83;
        [AccessedThroughProperty("lbRooms")] private ListBox _lbRooms;
        [AccessedThroughProperty("Label56")] private Label _label56;
        [AccessedThroughProperty("Label6")] private Label _label6;
        [AccessedThroughProperty("Label57")] private Label _label57;
        [AccessedThroughProperty("Label7")] private Label _label7;
        [AccessedThroughProperty("Label82")] private Label _label82;
        [AccessedThroughProperty("Label58")] private Label _label58;
        [AccessedThroughProperty("Label8")] private Label _label8;
        [AccessedThroughProperty("Label59")] private Label _label59;
        [AccessedThroughProperty("Label9")] private Label _label9;
        [AccessedThroughProperty("Label60")] private Label _label60;
        [AccessedThroughProperty("Label81")] private Label _label81;
        [AccessedThroughProperty("Label10")] private Label _label10;
        [AccessedThroughProperty("Label61")] private Label _label61;

        [AccessedThroughProperty("tabpagModuleBasic")]
        private TabPage _tabpagModuleBasic;

        [AccessedThroughProperty("tabpagModuleAdvanced")]
        private TabPage _tabpagModuleAdvanced;

        [AccessedThroughProperty("btnGrassAmbientColor")]
        private Button _btnGrassAmbientColor;

        [AccessedThroughProperty("nudGrassProbLR")]
        private NumericUpDown _nudGrassProbLr;

        [AccessedThroughProperty("btnGrassDiffuseColor")]
        private Button _btnGrassDiffuseColor;

        [AccessedThroughProperty("Label80")] private Label _label80;
        [AccessedThroughProperty("Label79")] private Label _label79;
        [AccessedThroughProperty("Label78")] private Label _label78;

        [AccessedThroughProperty("tabpagAreaRooms")]
        private TabPage _tabpagAreaRooms;

        [AccessedThroughProperty("tbArea_OnUserDefined")]
        private TextBox _tbAreaOnUserDefined;

        [AccessedThroughProperty("Label77")] private Label _label77;
        [AccessedThroughProperty("Label5")] private Label _label5;
        [AccessedThroughProperty("Label76")] private Label _label76;
        [AccessedThroughProperty("Label4")] private Label _label4;

        [AccessedThroughProperty("tbArea_OnHeartbeat")]
        private TextBox _tbAreaOnHeartbeat;

        [AccessedThroughProperty("tbArea_OnExit")]
        private TextBox _tbAreaOnExit;

        [AccessedThroughProperty("Label3")] private Label _label3;
        [AccessedThroughProperty("Label75")] private Label _label75;

        [AccessedThroughProperty("tbArea_OnEnter")]
        private TextBox _tbAreaOnEnter;

        [AccessedThroughProperty("Label1")] private Label _label1;
        [AccessedThroughProperty("Label74")] private Label _label74;

        [AccessedThroughProperty("ColorDialog1")]
        private ColorDialog _colorDialog1;

        [AccessedThroughProperty("TabControlArea")]
        private TabControl _tabControlArea;

        [AccessedThroughProperty("TabControlMain")]
        private TabControl _tabControlMain;

        [AccessedThroughProperty("TabControlModule")]
        private TabControl _tabControlModule;

        [AccessedThroughProperty("NumericUpDown12")]
        private NumericUpDown _numericUpDown12;

        [AccessedThroughProperty("tabpagArea_Events")]
        private TabPage _tabpagAreaEvents;

        [AccessedThroughProperty("tabpagModuleEvents")]
        private TabPage _tabpagModuleEvents;

        [AccessedThroughProperty("tabpagModuleDescription")]
        private TabPage _tabpagModuleDescription;

        [AccessedThroughProperty("nudModEntryX")]
        private NumericUpDown _nudModEntryX;

        [AccessedThroughProperty("nudModEntryY")]
        private NumericUpDown _nudModEntryY;

        [AccessedThroughProperty("Label48")] private Label _label48;
        [AccessedThroughProperty("Label32")] private Label _label32;

        [AccessedThroughProperty("btnDynAmbientColor")]
        private Button _btnDynAmbientColor;

        [AccessedThroughProperty("lblSunFogFar")]
        private Label _lblSunFogFar;

        [AccessedThroughProperty("nudModEntryZ")]
        private NumericUpDown _nudModEntryZ;

        [AccessedThroughProperty("GroupBox1")] private GroupBox _groupBox1;

        [AccessedThroughProperty("lblTotalGrassProbability")]
        private Label _lblTotalGrassProbability;

        [AccessedThroughProperty("tbModTag")] private TextBox _tbModTag;

        [AccessedThroughProperty("nudShadowOpacity")]
        private NumericUpDown _nudShadowOpacity;

        [AccessedThroughProperty("tbModName")] private TextBox _tbModName;

        [AccessedThroughProperty("nudMinutesPerHour")]
        private NumericUpDown _nudMinutesPerHour;

        [AccessedThroughProperty("Label11")] private Label _label11;

        [AccessedThroughProperty("nudDawnStartHour")]
        private NumericUpDown _nudDawnStartHour;

        [AccessedThroughProperty("btnOK")] private Button _btnOk;

        [AccessedThroughProperty("nudDuskStartHour")]
        private NumericUpDown _nudDuskStartHour;

        [AccessedThroughProperty("btnCancel")] private Button _btnCancel;
        [AccessedThroughProperty("Label73")] private Label _label73;

        [AccessedThroughProperty("cmbxCameraStyle")]
        private ComboBox _cmbxCameraStyle;

        [AccessedThroughProperty("tbAreaName")]
        private TextBox _tbAreaName;

        [AccessedThroughProperty("nudStartHour")]
        private NumericUpDown _nudStartHour;

        [AccessedThroughProperty("tbAreaTag")] private TextBox _tbAreaTag;

        [AccessedThroughProperty("nudStartDay")]
        private NumericUpDown _nudStartDay;

        [AccessedThroughProperty("nudStartMonth")]
        private NumericUpDown _nudStartMonth;

        [AccessedThroughProperty("Label12")] private Label _label12;
        [AccessedThroughProperty("Label40")] private Label _label40;
        [AccessedThroughProperty("Label41")] private Label _label41;
        [AccessedThroughProperty("Label42")] private Label _label42;
        [AccessedThroughProperty("Label43")] private Label _label43;
        [AccessedThroughProperty("Label44")] private Label _label44;
        [AccessedThroughProperty("Label46")] private Label _label46;

        [AccessedThroughProperty("nudXPScale")]
        private NumericUpDown _nudXpScale;

        [AccessedThroughProperty("trkbarXPScale")]
        private TrackBar _trkbarXpScale;

        [AccessedThroughProperty("nudGrassQuadSize")]
        private NumericUpDown _nudGrassQuadSize;

        [AccessedThroughProperty("Label26")] private Label _label26;

        [AccessedThroughProperty("nudStartYear")]
        private NumericUpDown _nudStartYear;

        [AccessedThroughProperty("tbMod_OnClientEntr")]
        private TextBox _tbModOnClientEntr;

        [AccessedThroughProperty("tbMod_OnActvtItem")]
        private TextBox _tbModOnActvtItem;

        [AccessedThroughProperty("Label68")] private Label _label68;

        [AccessedThroughProperty("btnSetDescriptionLang")]
        private Button _btnSetDescriptionLang;

        [AccessedThroughProperty("Label72")] private Label _label72;
        [AccessedThroughProperty("Label27")] private Label _label27;

        [AccessedThroughProperty("tbMod_OnAcquirItem")]
        private TextBox _tbModOnAcquirItem;

        [AccessedThroughProperty("tbMod_OnClientLeav")]
        private TextBox _tbModOnClientLeav;

        [AccessedThroughProperty("Label13")] private Label _label13;

        [AccessedThroughProperty("tbMod_OnHeartbeat")]
        private TextBox _tbModOnHeartbeat;

        [AccessedThroughProperty("Label14")] private Label _label14;
        [AccessedThroughProperty("Label28")] private Label _label28;

        [AccessedThroughProperty("tbMod_OnModLoad")]
        private TextBox _tbModOnModLoad;

        [AccessedThroughProperty("nudChanceLightning")]
        private NumericUpDown _nudChanceLightning;

        [AccessedThroughProperty("Label71")] private Label _label71;
        [AccessedThroughProperty("Label15")] private Label _label15;

        [AccessedThroughProperty("btnMoonFogColor")]
        private Button _btnMoonFogColor;

        [AccessedThroughProperty("Label16")] private Label _label16;
        [AccessedThroughProperty("Label29")] private Label _label29;

        [AccessedThroughProperty("chkbAreaMoonShadows")]
        private CheckBox _chkbAreaMoonShadows;

        [AccessedThroughProperty("Label17")] private Label _label17;

        [AccessedThroughProperty("btnSunFogColor")]
        private Button _btnSunFogColor;

        [AccessedThroughProperty("Label18")] private Label _label18;

        [AccessedThroughProperty("rbAlwaysNight")]
        private RadioButton _rbAlwaysNight;

        [AccessedThroughProperty("Label19")] private Label _label19;

        [AccessedThroughProperty("tbMod_OnPlrDeath")]
        private TextBox _tbModOnPlrDeath;

        [AccessedThroughProperty("Label20")] private Label _label20;
        [AccessedThroughProperty("Label70")] private Label _label70;

        [AccessedThroughProperty("tbMod_OnPlrDying")]
        private TextBox _tbModOnPlrDying;

        [AccessedThroughProperty("Label21")] private Label _label21;

        [AccessedThroughProperty("tbMod_OnPlrLvlUp")]
        private TextBox _tbModOnPlrLvlUp;

        [AccessedThroughProperty("TabPage5")] private TabPage _tabPage5;
        [AccessedThroughProperty("TabPage6")] private TabPage _tabPage6;

        [AccessedThroughProperty("NumericUpDown10")]
        private NumericUpDown _numericUpDown10;

        [AccessedThroughProperty("NumericUpDown11")]
        private NumericUpDown _numericUpDown11;

        [AccessedThroughProperty("Label22")] private Label _label22;

        [AccessedThroughProperty("tbMod_OnSpawnBtnDn")]
        private TextBox _tbModOnSpawnBtnDn;

        [AccessedThroughProperty("Label23")] private Label _label23;

        [AccessedThroughProperty("tbMod_OnPlrRest")]
        private TextBox _tbModOnPlrRest;

        [AccessedThroughProperty("Label24")] private Label _label24;
        [AccessedThroughProperty("Label69")] private Label _label69;

        [AccessedThroughProperty("tbMod_OnUnAqreItem")]
        private TextBox _tbModOnUnAqreItem;

        [AccessedThroughProperty("tbMod_OnUsrDefined")]
        private TextBox _tbModOnUsrDefined;

        [AccessedThroughProperty("chkbSunFogOn")]
        private CheckBox _chkbSunFogOn;

        [AccessedThroughProperty("chkbMoonFogOn")]
        private CheckBox _chkbMoonFogOn;

        [AccessedThroughProperty("trkbarSunFogNear")]
        private TrackBar _trkbarSunFogNear;

        [AccessedThroughProperty("trkbarSunFogFar")]
        private TrackBar _trkbarSunFogFar;

        [AccessedThroughProperty("Label30")] private Label _label30;
        [AccessedThroughProperty("Label39")] private Label _label39;

        [AccessedThroughProperty("trkbarMoonFogNear")]
        private TrackBar _trkbarMoonFogNear;

        [AccessedThroughProperty("trkbarMoonFogFar")]
        private TrackBar _trkbarMoonFogFar;

        [AccessedThroughProperty("nudChanceSnow")]
        private NumericUpDown _nudChanceSnow;

        [AccessedThroughProperty("nudChanceRain")]
        private NumericUpDown _nudChanceRain;

        private IContainer components;
        private ClsGff _areFile;
        private ClsGff _ifoFile;
        private ClsGff _gitFile;
        private ClsChitinKey _chitinKey;
        private ClsDialogTlk _dialogTlk;
        private bool _comboBoxSettingError;
        private Room[] _rooms;
        private Bitmap _bmpXy;
        private double _xyAngle;
        private float _xOrientation;
        private float _yOrientation;
        private float _origXOrientation;
        private float _origYOrientation;
        private float _bearing;
        private float _xpos;
        private float _origXPos;
        private float _ypos;
        private float _origYpos;
        private float _zpos;
        private float _origZpos;
        private int _modDescriptionLang;
        private int _modNameLang;
        private int _areaNameLang;

        internal virtual Label Label34
        {
            get => _label34;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label34 == null)
                    ;
                _label34 = value;
                if (_label34 != null)
                    ;
            }
        }

        internal virtual Label Label33
        {
            get => _label33;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label33 == null)
                    ;
                _label33 = value;
                if (_label33 != null)
                    ;
            }
        }

        internal virtual Label Label32
        {
            get => _label32;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label32 == null)
                    ;
                _label32 = value;
                if (_label32 != null)
                    ;
            }
        }

        internal virtual Label Label35
        {
            get => _label35;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label35 == null)
                    ;
                _label35 = value;
                if (_label35 != null)
                    ;
            }
        }

        internal virtual Label Label36
        {
            get => _label36;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label37 == null)
                    ;
                _label37 = value;
                if (_label37 != null)
                    ;
            }
        }

        internal virtual Label Label38
        {
            get => _label38;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label38 == null)
                    ;
                _label38 = value;
                if (_label38 != null)
                    ;
            }
        }

        internal virtual Label Label39
        {
            get => _label39;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label40 == null)
                    ;
                _label40 = value;
                if (_label40 != null)
                    ;
            }
        }

        internal virtual Label Label41
        {
            get => _label41;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label41 == null)
                    ;
                _label41 = value;
                if (_label41 != null)
                    ;
            }
        }

        internal virtual Label Label42
        {
            get => _label42;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label42 == null)
                    ;
                _label42 = value;
                if (_label42 != null)
                    ;
            }
        }

        internal virtual Label Label43
        {
            get => _label43;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label43 == null)
                    ;
                _label43 = value;
                if (_label43 != null)
                    ;
            }
        }

        internal virtual Label Label44
        {
            get => _label44;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label44 == null)
                    ;
                _label44 = value;
                if (_label44 != null)
                    ;
            }
        }

        internal virtual Label Label46
        {
            get => _label46;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label46 == null)
                    ;
                _label46 = value;
                if (_label46 != null)
                    ;
            }
        }

        internal virtual Label Label1
        {
            get => _label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label6 == null)
                    ;
                _label6 = value;
                if (_label6 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudXpScale
        {
            get => _nudXpScale;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudXpScale != null)
                    _nudXpScale.ValueChanged -= nudXPScale_ValueChanged;
                _nudXpScale = value;
                if (_nudXpScale == null)
                    return;
                _nudXpScale.ValueChanged += nudXPScale_ValueChanged;
            }
        }

        internal virtual TrackBar TrkbarXpScale
        {
            get => _trkbarXpScale;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarXpScale != null)
                    _trkbarXpScale.Scroll -= trkbarXPScale_Scroll;
                _trkbarXpScale = value;
                if (_trkbarXpScale == null)
                    return;
                _trkbarXpScale.Scroll += trkbarXPScale_Scroll;
            }
        }

        internal virtual Label Label7
        {
            get => _label7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label7 == null)
                    ;
                _label7 = value;
                if (_label7 != null)
                    ;
            }
        }

        internal virtual Button BtnSetDescriptionLang
        {
            get => _btnSetDescriptionLang;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetDescriptionLang != null)
                    _btnSetDescriptionLang.Click -= btnSetDescriptionLang_Click;
                _btnSetDescriptionLang = value;
                if (_btnSetDescriptionLang == null)
                    return;
                _btnSetDescriptionLang.Click += btnSetDescriptionLang_Click;
            }
        }

        internal virtual Label Label8
        {
            get => _label8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label11 == null)
                    ;
                _label11 = value;
                if (_label11 != null)
                    ;
            }
        }

        internal virtual Label Label12
        {
            get => _label12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label12 == null)
                    ;
                _label12 = value;
                if (_label12 != null)
                    ;
            }
        }

        internal virtual Label Label13
        {
            get => _label13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label13 == null)
                    ;
                _label13 = value;
                if (_label13 != null)
                    ;
            }
        }

        internal virtual TabPage TabPage5
        {
            get => _tabPage5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabPage5 == null)
                    ;
                _tabPage5 = value;
                if (_tabPage5 != null)
                    ;
            }
        }

        internal virtual TabPage TabPage6
        {
            get => _tabPage6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabPage6 == null)
                {
                }

                _tabPage6 = value;
                if (_tabPage6 != null)
                {
                }
            }
        }

        internal virtual Label Label14
        {
            get => _label14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label14 == null)
                    ;
                _label14 = value;
                if (_label14 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NumericUpDown10
        {
            get => _numericUpDown10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numericUpDown10 == null)
                    ;
                _numericUpDown10 = value;
                if (_numericUpDown10 != null)
                    ;
            }
        }

        internal virtual Label Label15
        {
            get => _label15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label15 == null)
                    ;
                _label15 = value;
                if (_label15 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NumericUpDown11
        {
            get => _numericUpDown11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numericUpDown11 == null)
                    ;
                _numericUpDown11 = value;
                if (_numericUpDown11 != null)
                    ;
            }
        }

        internal virtual Label Label16
        {
            get => _label16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label16 == null)
                    ;
                _label16 = value;
                if (_label16 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NumericUpDown12
        {
            get => _numericUpDown12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_numericUpDown12 == null)
                    ;
                _numericUpDown12 = value;
                if (_numericUpDown12 != null)
                    ;
            }
        }

        internal virtual Label Label17
        {
            get => _label17;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label18 == null)
                    ;
                _label18 = value;
                if (_label18 != null)
                    ;
            }
        }

        internal virtual TabControl TabControlModule
        {
            get => _tabControlModule;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabControlModule == null)
                    ;
                _tabControlModule = value;
                if (_tabControlModule != null)
                    ;
            }
        }

        internal virtual TabControl TabControlMain
        {
            get => _tabControlMain;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabControlMain == null)
                    ;
                _tabControlMain = value;
                if (_tabControlMain != null)
                    ;
            }
        }

        internal virtual TabControl TabControlArea
        {
            get => _tabControlArea;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabControlArea == null)
                    ;
                _tabControlArea = value;
                if (_tabControlArea != null)
                    ;
            }
        }

        internal virtual Label Label20
        {
            get => _label20;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label20 == null)
                    ;
                _label20 = value;
                if (_label20 != null)
                    ;
            }
        }

        internal virtual ColorDialog ColorDialog1
        {
            get => _colorDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_colorDialog1 == null)
                    ;
                _colorDialog1 = value;
                if (_colorDialog1 != null)
                    ;
            }
        }

        internal virtual Label Label21
        {
            get => _label21;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label21 == null)
                    ;
                _label21 = value;
                if (_label21 != null)
                    ;
            }
        }

        internal virtual Button BtnGrassDiffuseColor
        {
            get => _btnGrassDiffuseColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnGrassDiffuseColor != null)
                    _btnGrassDiffuseColor.Click -= SetColor_Click;
                _btnGrassDiffuseColor = value;
                if (_btnGrassDiffuseColor == null)
                    return;
                _btnGrassDiffuseColor.Click += SetColor_Click;
            }
        }

        internal virtual Label Label22
        {
            get => _label22;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label22 == null)
                    ;
                _label22 = value;
                if (_label22 != null)
                    ;
            }
        }

        internal virtual Button BtnGrassAmbientColor
        {
            get => _btnGrassAmbientColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnGrassAmbientColor != null)
                    _btnGrassAmbientColor.Click -= SetColor_Click;
                _btnGrassAmbientColor = value;
                if (_btnGrassAmbientColor == null)
                    return;
                _btnGrassAmbientColor.Click += SetColor_Click;
            }
        }

        internal virtual Label Label23
        {
            get => _label23;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label23 == null)
                    ;
                _label23 = value;
                if (_label23 != null)
                    ;
            }
        }

        internal virtual Button BtnGrassEmissiveColor
        {
            get => _btnGrassEmissiveColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnGrassEmissiveColor != null)
                    _btnGrassEmissiveColor.Click -= SetColor_Click;
                _btnGrassEmissiveColor = value;
                if (_btnGrassEmissiveColor == null)
                    return;
                _btnGrassEmissiveColor.Click += SetColor_Click;
            }
        }

        internal virtual TabPage TabpagAreaBasic
        {
            get => _tabpagAreaBasic;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAreaBasic == null)
                    ;
                _tabpagAreaBasic = value;
                if (_tabpagAreaBasic != null)
                    ;
            }
        }

        internal virtual TabPage TabpagAreaGrass
        {
            get => _tabpagAreaGrass;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAreaGrass == null)
                    ;
                _tabpagAreaGrass = value;
                if (_tabpagAreaGrass != null)
                    ;
            }
        }

        internal virtual TabPage TabpagAreaEnvironment
        {
            get => _tabpagAreaEnvironment;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAreaEnvironment == null)
                    ;
                _tabpagAreaEnvironment = value;
                if (_tabpagAreaEnvironment != null)
                    ;
            }
        }

        internal virtual Button BtnSunDiffuseColor
        {
            get => _btnSunDiffuseColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSunDiffuseColor != null)
                    _btnSunDiffuseColor.Click -= SetColor_Click;
                _btnSunDiffuseColor = value;
                if (_btnSunDiffuseColor == null)
                    return;
                _btnSunDiffuseColor.Click += SetColor_Click;
            }
        }

        internal virtual Label Label26
        {
            get => _label26;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label26 == null)
                    ;
                _label26 = value;
                if (_label26 != null)
                    ;
            }
        }

        internal virtual Label Label27
        {
            get => _label27;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label27 == null)
                    ;
                _label27 = value;
                if (_label27 != null)
                    ;
            }
        }

        internal virtual Button BtnSunAmbientColor
        {
            get => _btnSunAmbientColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSunAmbientColor != null)
                    _btnSunAmbientColor.Click -= SetColor_Click;
                _btnSunAmbientColor = value;
                if (_btnSunAmbientColor == null)
                    return;
                _btnSunAmbientColor.Click += SetColor_Click;
            }
        }

        internal virtual GroupBox GbSun
        {
            get => _gbSun;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_gbSun == null)
                    ;
                _gbSun = value;
                if (_gbSun != null)
                    ;
            }
        }

        internal virtual GroupBox GbMoon
        {
            get => _gbMoon;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_gbMoon == null)
                    ;
                _gbMoon = value;
                if (_gbMoon != null)
                    ;
            }
        }

        internal virtual Button BtnMoonDiffuseColor
        {
            get => _btnMoonDiffuseColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMoonDiffuseColor != null)
                    _btnMoonDiffuseColor.Click -= SetColor_Click;
                _btnMoonDiffuseColor = value;
                if (_btnMoonDiffuseColor == null)
                    return;
                _btnMoonDiffuseColor.Click += SetColor_Click;
            }
        }

        internal virtual Label Label24
        {
            get => _label24;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label24 == null)
                    ;
                _label24 = value;
                if (_label24 != null)
                    ;
            }
        }

        internal virtual Label Label25
        {
            get => _label25;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label25 == null)
                    ;
                _label25 = value;
                if (_label25 != null)
                    ;
            }
        }

        internal virtual Button BtnMoonAmbientColor
        {
            get => _btnMoonAmbientColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMoonAmbientColor != null)
                    _btnMoonAmbientColor.Click -= SetColor_Click;
                _btnMoonAmbientColor = value;
                if (_btnMoonAmbientColor == null)
                    return;
                _btnMoonAmbientColor.Click += SetColor_Click;
            }
        }

        internal virtual RadioButton RbDayNightCycle
        {
            get => _rbDayNightCycle;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbDayNightCycle != null)
                    _rbDayNightCycle.CheckedChanged -= DayNight_CheckedChanged;
                _rbDayNightCycle = value;
                if (_rbDayNightCycle == null)
                    return;
                _rbDayNightCycle.CheckedChanged += DayNight_CheckedChanged;
            }
        }

        internal virtual RadioButton RbAlwaysDay
        {
            get => _rbAlwaysDay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbAlwaysDay != null)
                    _rbAlwaysDay.CheckedChanged -= DayNight_CheckedChanged;
                _rbAlwaysDay = value;
                if (_rbAlwaysDay == null)
                    return;
                _rbAlwaysDay.CheckedChanged += DayNight_CheckedChanged;
            }
        }

        internal virtual Label Label28
        {
            get => _label28;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label28 == null)
                    ;
                _label28 = value;
                if (_label28 != null)
                    ;
            }
        }

        internal virtual Label Label29
        {
            get => _label29;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label29 == null)
                    ;
                _label29 = value;
                if (_label29 != null)
                    ;
            }
        }

        internal virtual Label Label30
        {
            get => _label30;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label30 == null)
                    ;
                _label30 = value;
                if (_label30 != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbAreaSunShadows
        {
            get => _chkbAreaSunShadows;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbAreaSunShadows == null)
                    ;
                _chkbAreaSunShadows = value;
                if (_chkbAreaSunShadows != null)
                    ;
            }
        }

        internal virtual Label Label31
        {
            get => _label31;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label31 == null)
                    ;
                _label31 = value;
                if (_label31 != null)
                    ;
            }
        }

        internal virtual Label Label45
        {
            get => _label45;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label45 == null)
                    ;
                _label45 = value;
                if (_label45 != null)
                    ;
            }
        }

        internal virtual Label Label47
        {
            get => _label47;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label47 == null)
                    ;
                _label47 = value;
                if (_label47 != null)
                    ;
            }
        }

        internal virtual GroupBox GroupBox1
        {
            get => _groupBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_groupBox1 == null)
                    ;
                _groupBox1 = value;
                if (_groupBox1 != null)
                    ;
            }
        }

        internal virtual Label Label49
        {
            get => _label49;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label49 == null)
                    ;
                _label49 = value;
                if (_label49 != null)
                    ;
            }
        }

        internal virtual Label Label50
        {
            get => _label50;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label50 == null)
                    ;
                _label50 = value;
                if (_label50 != null)
                    ;
            }
        }

        internal virtual Label Label51
        {
            get => _label51;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label51 == null)
                    ;
                _label51 = value;
                if (_label51 != null)
                    ;
            }
        }

        internal virtual TabPage TabpagAreaAudio
        {
            get => _tabpagAreaAudio;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAreaAudio == null)
                    ;
                _tabpagAreaAudio = value;
                if (_tabpagAreaAudio != null)
                    ;
            }
        }

        internal virtual Label Label52
        {
            get => _label52;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label52 == null)
                    ;
                _label52 = value;
                if (_label52 != null)
                    ;
            }
        }

        internal virtual Label Label53
        {
            get => _label53;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label53 == null)
                    ;
                _label53 = value;
                if (_label53 != null)
                    ;
            }
        }

        internal virtual Label Label54
        {
            get => _label54;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label54 == null)
                    ;
                _label54 = value;
                if (_label54 != null)
                    ;
            }
        }

        internal virtual Label Label55
        {
            get => _label55;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label55 == null)
                    ;
                _label55 = value;
                if (_label55 != null)
                    ;
            }
        }

        internal virtual Label Label56
        {
            get => _label56;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label56 == null)
                    ;
                _label56 = value;
                if (_label56 != null)
                    ;
            }
        }

        internal virtual Label Label57
        {
            get => _label57;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label57 == null)
                    ;
                _label57 = value;
                if (_label57 != null)
                    ;
            }
        }

        internal virtual Label Label58
        {
            get => _label58;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label58 == null)
                    ;
                _label58 = value;
                if (_label58 != null)
                    ;
            }
        }

        internal virtual Label Label59
        {
            get => _label59;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label59 == null)
                    ;
                _label59 = value;
                if (_label59 != null)
                    ;
            }
        }

        internal virtual Label Label60
        {
            get => _label60;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label60 == null)
                    ;
                _label60 = value;
                if (_label60 != null)
                    ;
            }
        }

        internal virtual Label Label61
        {
            get => _label61;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label61 == null)
                    ;
                _label61 = value;
                if (_label61 != null)
                    ;
            }
        }

        internal virtual TabPage TabpagModuleBasic
        {
            get => _tabpagModuleBasic;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagModuleBasic == null)
                    ;
                _tabpagModuleBasic = value;
                if (_tabpagModuleBasic != null)
                    ;
            }
        }

        internal virtual TabPage TabpagModuleAdvanced
        {
            get => _tabpagModuleAdvanced;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagModuleAdvanced == null)
                    ;
                _tabpagModuleAdvanced = value;
                if (_tabpagModuleAdvanced != null)
                    ;
            }
        }

        internal virtual TabPage TabpagModuleEvents
        {
            get => _tabpagModuleEvents;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagModuleEvents == null)
                    ;
                _tabpagModuleEvents = value;
                if (_tabpagModuleEvents != null)
                    ;
            }
        }

        internal virtual TabPage TabpagModuleDescription
        {
            get => _tabpagModuleDescription;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagModuleDescription == null)
                    ;
                _tabpagModuleDescription = value;
                if (_tabpagModuleDescription != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudModEntryX
        {
            get => _nudModEntryX;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudModEntryX == null)
                    ;
                _nudModEntryX = value;
                if (_nudModEntryX != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudModEntryY
        {
            get => _nudModEntryY;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudModEntryY == null)
                    ;
                _nudModEntryY = value;
                if (_nudModEntryY != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudModEntryZ
        {
            get => _nudModEntryZ;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudModEntryZ == null)
                    ;
                _nudModEntryZ = value;
                if (_nudModEntryZ != null)
                    ;
            }
        }

        internal virtual TextBox TbModTag
        {
            get => _tbModTag;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModTag == null)
                    ;
                _tbModTag = value;
                if (_tbModTag != null)
                    ;
            }
        }

        internal virtual TextBox TbModName
        {
            get => _tbModName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModName == null)
                    ;
                _tbModName = value;
                if (_tbModName != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudMinutesPerHour
        {
            get => _nudMinutesPerHour;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudMinutesPerHour == null)
                    ;
                _nudMinutesPerHour = value;
                if (_nudMinutesPerHour != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudDawnStartHour
        {
            get => _nudDawnStartHour;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudDawnStartHour == null)
                    ;
                _nudDawnStartHour = value;
                if (_nudDawnStartHour != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudDuskStartHour
        {
            get => _nudDuskStartHour;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudDuskStartHour == null)
                    ;
                _nudDuskStartHour = value;
                if (_nudDuskStartHour != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudStartHour
        {
            get => _nudStartHour;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudStartHour == null)
                    ;
                _nudStartHour = value;
                if (_nudStartHour != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudStartDay
        {
            get => _nudStartDay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudStartDay == null)
                    ;
                _nudStartDay = value;
                if (_nudStartDay != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudStartMonth
        {
            get => _nudStartMonth;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudStartMonth == null)
                    ;
                _nudStartMonth = value;
                if (_nudStartMonth != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudStartYear
        {
            get => _nudStartYear;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudStartYear == null)
                    ;
                _nudStartYear = value;
                if (_nudStartYear != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnClientEntr
        {
            get => _tbModOnClientEntr;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnClientEntr == null)
                    ;
                _tbModOnClientEntr = value;
                if (_tbModOnClientEntr != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnActvtItem
        {
            get => _tbModOnActvtItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnActvtItem == null)
                    ;
                _tbModOnActvtItem = value;
                if (_tbModOnActvtItem != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnAcquirItem
        {
            get => _tbModOnAcquirItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnAcquirItem == null)
                    ;
                _tbModOnAcquirItem = value;
                if (_tbModOnAcquirItem != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnClientLeav
        {
            get => _tbModOnClientLeav;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnClientLeav == null)
                    ;
                _tbModOnClientLeav = value;
                if (_tbModOnClientLeav != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnHeartbeat
        {
            get => _tbModOnHeartbeat;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnHeartbeat == null)
                    ;
                _tbModOnHeartbeat = value;
                if (_tbModOnHeartbeat != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnModLoad
        {
            get => _tbModOnModLoad;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnModLoad == null)
                    ;
                _tbModOnModLoad = value;
                if (_tbModOnModLoad != null)
                    ;
            }
        }

        internal virtual Button BtnMoonFogColor
        {
            get => _btnMoonFogColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnMoonFogColor != null)
                    _btnMoonFogColor.Click -= SetColor_Click;
                _btnMoonFogColor = value;
                if (_btnMoonFogColor == null)
                    return;
                _btnMoonFogColor.Click += SetColor_Click;
            }
        }

        internal virtual CheckBox ChkbAreaMoonShadows
        {
            get => _chkbAreaMoonShadows;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbAreaMoonShadows == null)
                    ;
                _chkbAreaMoonShadows = value;
                if (_chkbAreaMoonShadows != null)
                    ;
            }
        }

        internal virtual Button BtnSunFogColor
        {
            get => _btnSunFogColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSunFogColor != null)
                    _btnSunFogColor.Click -= SetColor_Click;
                _btnSunFogColor = value;
                if (_btnSunFogColor == null)
                    return;
                _btnSunFogColor.Click += SetColor_Click;
            }
        }

        internal virtual RadioButton RbAlwaysNight
        {
            get => _rbAlwaysNight;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_rbAlwaysNight != null)
                    _rbAlwaysNight.CheckedChanged -= DayNight_CheckedChanged;
                _rbAlwaysNight = value;
                if (_rbAlwaysNight == null)
                    return;
                _rbAlwaysNight.CheckedChanged += DayNight_CheckedChanged;
            }
        }

        internal virtual TextBox TbModOnPlrDeath
        {
            get => _tbModOnPlrDeath;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnPlrDeath == null)
                    ;
                _tbModOnPlrDeath = value;
                if (_tbModOnPlrDeath != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnPlrDying
        {
            get => _tbModOnPlrDying;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnPlrDying == null)
                    ;
                _tbModOnPlrDying = value;
                if (_tbModOnPlrDying != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnPlrLvlUp
        {
            get => _tbModOnPlrLvlUp;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnPlrLvlUp == null)
                    ;
                _tbModOnPlrLvlUp = value;
                if (_tbModOnPlrLvlUp != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnSpawnBtnDn
        {
            get => _tbModOnSpawnBtnDn;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnSpawnBtnDn == null)
                    ;
                _tbModOnSpawnBtnDn = value;
                if (_tbModOnSpawnBtnDn != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnPlrRest
        {
            get => _tbModOnPlrRest;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnPlrRest == null)
                    ;
                _tbModOnPlrRest = value;
                if (_tbModOnPlrRest != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnUnAqreItem
        {
            get => _tbModOnUnAqreItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnUnAqreItem == null)
                    ;
                _tbModOnUnAqreItem = value;
                if (_tbModOnUnAqreItem != null)
                    ;
            }
        }

        internal virtual TextBox TbModOnUsrDefined
        {
            get => _tbModOnUsrDefined;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModOnUsrDefined == null)
                    ;
                _tbModOnUsrDefined = value;
                if (_tbModOnUsrDefined != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbSunFogOn
        {
            get => _chkbSunFogOn;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbSunFogOn != null)
                    _chkbSunFogOn.CheckedChanged -= SunFogEnabled;
                _chkbSunFogOn = value;
                if (_chkbSunFogOn == null)
                    return;
                _chkbSunFogOn.CheckedChanged += SunFogEnabled;
            }
        }

        internal virtual CheckBox ChkbMoonFogOn
        {
            get => _chkbMoonFogOn;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbMoonFogOn != null)
                    _chkbMoonFogOn.CheckedChanged -= MoonFogEnabled;
                _chkbMoonFogOn = value;
                if (_chkbMoonFogOn == null)
                    return;
                _chkbMoonFogOn.CheckedChanged += MoonFogEnabled;
            }
        }

        internal virtual TrackBar TrkbarSunFogNear
        {
            get => _trkbarSunFogNear;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarSunFogNear == null)
                    ;
                _trkbarSunFogNear = value;
                if (_trkbarSunFogNear != null)
                    ;
            }
        }

        internal virtual TrackBar TrkbarSunFogFar
        {
            get => _trkbarSunFogFar;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarSunFogFar == null)
                    ;
                _trkbarSunFogFar = value;
                if (_trkbarSunFogFar != null)
                    ;
            }
        }

        internal virtual TrackBar TrkbarMoonFogNear
        {
            get => _trkbarMoonFogNear;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarMoonFogNear == null)
                    ;
                _trkbarMoonFogNear = value;
                if (_trkbarMoonFogNear != null)
                    ;
            }
        }

        internal virtual TrackBar TrkbarMoonFogFar
        {
            get => _trkbarMoonFogFar;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarMoonFogFar == null)
                    ;
                _trkbarMoonFogFar = value;
                if (_trkbarMoonFogFar != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudChanceSnow
        {
            get => _nudChanceSnow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudChanceSnow == null)
                    ;
                _nudChanceSnow = value;
                if (_nudChanceSnow != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudChanceRain
        {
            get => _nudChanceRain;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudChanceRain == null)
                    ;
                _nudChanceRain = value;
                if (_nudChanceRain != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudChanceLightning
        {
            get => _nudChanceLightning;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudChanceLightning == null)
                    ;
                _nudChanceLightning = value;
                if (_nudChanceLightning != null)
                    ;
            }
        }

        internal virtual Button BtnDynAmbientColor
        {
            get => _btnDynAmbientColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDynAmbientColor != null)
                    _btnDynAmbientColor.Click -= SetColor_Click;
                _btnDynAmbientColor = value;
                if (_btnDynAmbientColor == null)
                    return;
                _btnDynAmbientColor.Click += SetColor_Click;
            }
        }

        internal virtual Label Label48
        {
            get => _label48;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label48 == null)
                    ;
                _label48 = value;
                if (_label48 != null)
                    ;
            }
        }

        internal virtual Label LblMoonFogNear
        {
            get => _lblMoonFogNear;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblMoonFogNear == null)
                    ;
                _lblMoonFogNear = value;
                if (_lblMoonFogNear != null)
                    ;
            }
        }

        internal virtual Label LblMoonFogFar
        {
            get => _lblMoonFogFar;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblMoonFogFar == null)
                    ;
                _lblMoonFogFar = value;
                if (_lblMoonFogFar != null)
                    ;
            }
        }

        internal virtual Label LblSunFogNear
        {
            get => _lblSunFogNear;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblSunFogNear == null)
                    ;
                _lblSunFogNear = value;
                if (_lblSunFogNear != null)
                    ;
            }
        }

        internal virtual Label LblSunFogFar
        {
            get => _lblSunFogFar;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblSunFogFar == null)
                    ;
                _lblSunFogFar = value;
                if (_lblSunFogFar != null)
                    ;
            }
        }

        internal virtual Button BtnOk
        {
            get => _btnOk;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCancel == null)
                    ;
                _btnCancel = value;
                if (_btnCancel != null)
                    ;
            }
        }

        internal virtual TrackBar TrkbarAmbientSndDayVol
        {
            get => _trkbarAmbientSndDayVol;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarAmbientSndDayVol == null)
                    ;
                _trkbarAmbientSndDayVol = value;
                if (_trkbarAmbientSndDayVol != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxAmbientSndDay
        {
            get => _cmbxAmbientSndDay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxAmbientSndDay == null)
                    ;
                _cmbxAmbientSndDay = value;
                if (_cmbxAmbientSndDay != null)
                    ;
            }
        }

        internal virtual TrackBar TrkbarAmbientSndNightVol
        {
            get => _trkbarAmbientSndNightVol;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarAmbientSndNightVol == null)
                    ;
                _trkbarAmbientSndNightVol = value;
                if (_trkbarAmbientSndNightVol != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudMusicDelay
        {
            get => _nudMusicDelay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudMusicDelay == null)
                    ;
                _nudMusicDelay = value;
                if (_nudMusicDelay != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxMusicNight
        {
            get => _cmbxMusicNight;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxMusicNight == null)
                    ;
                _cmbxMusicNight = value;
                if (_cmbxMusicNight != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxMusicDay
        {
            get => _cmbxMusicDay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxMusicDay == null)
                    ;
                _cmbxMusicDay = value;
                if (_cmbxMusicDay != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxMusicBattle
        {
            get => _cmbxMusicBattle;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxMusicBattle == null)
                    ;
                _cmbxMusicBattle = value;
                if (_cmbxMusicBattle != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxEnvAudio
        {
            get => _cmbxEnvAudio;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxEnvAudio == null)
                    ;
                _cmbxEnvAudio = value;
                if (_cmbxEnvAudio != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxAmbientSndNight
        {
            get => _cmbxAmbientSndNight;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxAmbientSndNight == null)
                    ;
                _cmbxAmbientSndNight = value;
                if (_cmbxAmbientSndNight != null)
                    ;
            }
        }

        internal virtual TextBox TbGrassTexName
        {
            get => _tbGrassTexName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbGrassTexName == null)
                    ;
                _tbGrassTexName = value;
                if (_tbGrassTexName != null)
                    ;
            }
        }

        internal virtual TrackBar TrkbarGrassDensityX10
        {
            get => _trkbarGrassDensityX10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbarGrassDensityX10 != null)
                    _trkbarGrassDensityX10.Scroll -= trkbarGrassDensityX10_Scroll;
                _trkbarGrassDensityX10 = value;
                if (_trkbarGrassDensityX10 == null)
                    return;
                _trkbarGrassDensityX10.Scroll += trkbarGrassDensityX10_Scroll;
            }
        }

        internal virtual Label Label62
        {
            get => _label62;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label62 == null)
                    ;
                _label62 = value;
                if (_label62 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudGrassDensity
        {
            get => _nudGrassDensity;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudGrassDensity != null)
                    _nudGrassDensity.ValueChanged -= nudGrassDensity_ValueChanged;
                _nudGrassDensity = value;
                if (_nudGrassDensity == null)
                    return;
                _nudGrassDensity.ValueChanged += nudGrassDensity_ValueChanged;
            }
        }

        internal virtual Label Label63
        {
            get => _label63;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label63 == null)
                    ;
                _label63 = value;
                if (_label63 != null)
                    ;
            }
        }

        internal virtual Label Label64
        {
            get => _label64;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label64 == null)
                    ;
                _label64 = value;
                if (_label64 != null)
                    ;
            }
        }

        internal virtual Label Label65
        {
            get => _label65;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label65 == null)
                    ;
                _label65 = value;
                if (_label65 != null)
                    ;
            }
        }

        internal virtual Label Label66
        {
            get => _label66;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label66 == null)
                    ;
                _label66 = value;
                if (_label66 != null)
                    ;
            }
        }

        internal virtual Label Label67
        {
            get => _label67;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label67 == null)
                    ;
                _label67 = value;
                if (_label67 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudGrassProbUl
        {
            get => _nudGrassProbUl;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudGrassProbUl != null)
                    _nudGrassProbUl.ValueChanged -= nudGrassProbXX_ValueChanged;
                _nudGrassProbUl = value;
                if (_nudGrassProbUl == null)
                    return;
                _nudGrassProbUl.ValueChanged += nudGrassProbXX_ValueChanged;
            }
        }

        internal virtual NumericUpDown NudGrassProbLl
        {
            get => _nudGrassProbLl;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudGrassProbLl != null)
                    _nudGrassProbLl.ValueChanged -= nudGrassProbXX_ValueChanged;
                _nudGrassProbLl = value;
                if (_nudGrassProbLl == null)
                    return;
                _nudGrassProbLl.ValueChanged += nudGrassProbXX_ValueChanged;
            }
        }

        internal virtual NumericUpDown NudGrassProbUr
        {
            get => _nudGrassProbUr;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudGrassProbUr != null)
                    _nudGrassProbUr.ValueChanged -= nudGrassProbXX_ValueChanged;
                _nudGrassProbUr = value;
                if (_nudGrassProbUr == null)
                    return;
                _nudGrassProbUr.ValueChanged += nudGrassProbXX_ValueChanged;
            }
        }

        internal virtual NumericUpDown NudGrassProbLr
        {
            get => _nudGrassProbLr;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudGrassProbLr != null)
                    _nudGrassProbLr.ValueChanged -= nudGrassProbXX_ValueChanged;
                _nudGrassProbLr = value;
                if (_nudGrassProbLr == null)
                    return;
                _nudGrassProbLr.ValueChanged += nudGrassProbXX_ValueChanged;
            }
        }

        internal virtual Label LblTotalGrassProbability
        {
            get => _lblTotalGrassProbability;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblTotalGrassProbability == null)
                    ;
                _lblTotalGrassProbability = value;
                if (_lblTotalGrassProbability != null)
                    ;
            }
        }

        internal virtual Label Label69
        {
            get => _label69;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label69 == null)
                    ;
                _label69 = value;
                if (_label69 != null)
                    ;
            }
        }

        internal virtual Label Label70
        {
            get => _label70;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label70 == null)
                    ;
                _label70 = value;
                if (_label70 != null)
                    ;
            }
        }

        internal virtual Label Label71
        {
            get => _label71;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label71 == null)
                    ;
                _label71 = value;
                if (_label71 != null)
                    ;
            }
        }

        internal virtual Label Label72
        {
            get => _label72;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label72 == null)
                    ;
                _label72 = value;
                if (_label72 != null)
                    ;
            }
        }

        internal virtual Label Label68
        {
            get => _label68;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label68 == null)
                    ;
                _label68 = value;
                if (_label68 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudGrassQuadSize
        {
            get => _nudGrassQuadSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudGrassQuadSize == null)
                    ;
                _nudGrassQuadSize = value;
                if (_nudGrassQuadSize != null)
                    ;
            }
        }

        internal virtual TextBox TbAreaTag
        {
            get => _tbAreaTag;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAreaTag == null)
                    ;
                _tbAreaTag = value;
                if (_tbAreaTag != null)
                    ;
            }
        }

        internal virtual TextBox TbAreaName
        {
            get => _tbAreaName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAreaName == null)
                    ;
                _tbAreaName = value;
                if (_tbAreaName != null)
                    ;
            }
        }

        internal virtual Label Label19
        {
            get => _label19;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label19 == null)
                    ;
                _label19 = value;
                if (_label19 != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxCameraStyle
        {
            get => _cmbxCameraStyle;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxCameraStyle == null)
                    ;
                _cmbxCameraStyle = value;
                if (_cmbxCameraStyle != null)
                    ;
            }
        }

        internal virtual Label Label73
        {
            get => _label73;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label73 == null)
                    ;
                _label73 = value;
                if (_label73 != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudShadowOpacity
        {
            get => _nudShadowOpacity;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudShadowOpacity == null)
                    ;
                _nudShadowOpacity = value;
                if (_nudShadowOpacity != null)
                    ;
            }
        }

        internal virtual TabPage TabpagAreaEvents
        {
            get => _tabpagAreaEvents;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAreaEvents == null)
                    ;
                _tabpagAreaEvents = value;
                if (_tabpagAreaEvents != null)
                    ;
            }
        }

        internal virtual Label Label74
        {
            get => _label74;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label74 == null)
                    ;
                _label74 = value;
                if (_label74 != null)
                    ;
            }
        }

        internal virtual TextBox TbAreaOnEnter
        {
            get => _tbAreaOnEnter;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAreaOnEnter == null)
                    ;
                _tbAreaOnEnter = value;
                if (_tbAreaOnEnter != null)
                    ;
            }
        }

        internal virtual Label Label75
        {
            get => _label75;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label75 == null)
                    ;
                _label75 = value;
                if (_label75 != null)
                    ;
            }
        }

        internal virtual TextBox TbAreaOnExit
        {
            get => _tbAreaOnExit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAreaOnExit == null)
                    ;
                _tbAreaOnExit = value;
                if (_tbAreaOnExit != null)
                    ;
            }
        }

        internal virtual TextBox TbAreaOnHeartbeat
        {
            get => _tbAreaOnHeartbeat;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAreaOnHeartbeat == null)
                    ;
                _tbAreaOnHeartbeat = value;
                if (_tbAreaOnHeartbeat != null)
                    ;
            }
        }

        internal virtual Label Label76
        {
            get => _label76;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label76 == null)
                    ;
                _label76 = value;
                if (_label76 != null)
                    ;
            }
        }

        internal virtual Label Label77
        {
            get => _label77;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label77 == null)
                    ;
                _label77 = value;
                if (_label77 != null)
                    ;
            }
        }

        internal virtual TextBox TbAreaOnUserDefined
        {
            get => _tbAreaOnUserDefined;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAreaOnUserDefined == null)
                    ;
                _tbAreaOnUserDefined = value;
                if (_tbAreaOnUserDefined != null)
                    ;
            }
        }

        internal virtual TabPage TabpagAreaRooms
        {
            get => _tabpagAreaRooms;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAreaRooms == null)
                    ;
                _tabpagAreaRooms = value;
                if (_tabpagAreaRooms != null)
                    ;
            }
        }

        internal virtual Label Label78
        {
            get => _label78;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label78 == null)
                    ;
                _label78 = value;
                if (_label78 != null)
                    ;
            }
        }

        internal virtual Label Label79
        {
            get => _label79;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label79 == null)
                    ;
                _label79 = value;
                if (_label79 != null)
                    ;
            }
        }

        internal virtual Label Label80
        {
            get => _label80;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label80 == null)
                    ;
                _label80 = value;
                if (_label80 != null)
                    ;
            }
        }

        internal virtual Label Label81
        {
            get => _label81;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label81 == null)
                    ;
                _label81 = value;
                if (_label81 != null)
                    ;
            }
        }

        internal virtual Label Label82
        {
            get => _label82;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label82 == null)
                    ;
                _label82 = value;
                if (_label82 != null)
                    ;
            }
        }

        internal virtual ListBox LbRooms
        {
            get => _lbRooms;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbRooms != null)
                    _lbRooms.SelectedIndexChanged -= lbRooms_SelectedIndexChanged;
                _lbRooms = value;
                if (_lbRooms == null)
                    return;
                _lbRooms.SelectedIndexChanged += lbRooms_SelectedIndexChanged;
            }
        }

        internal virtual Label Label83
        {
            get => _label83;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label83 == null)
                    ;
                _label83 = value;
                if (_label83 != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbRoomDisableWeather
        {
            get => _chkbRoomDisableWeather;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbRoomDisableWeather == null)
                    ;
                _chkbRoomDisableWeather = value;
                if (_chkbRoomDisableWeather != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudRoomAmbientScale
        {
            get => _nudRoomAmbientScale;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudRoomAmbientScale == null)
                    ;
                _nudRoomAmbientScale = value;
                if (_nudRoomAmbientScale != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxRoomEnvAudio
        {
            get => _cmbxRoomEnvAudio;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxRoomEnvAudio == null)
                    ;
                _cmbxRoomEnvAudio = value;
                if (_cmbxRoomEnvAudio != null)
                    ;
            }
        }

        internal virtual TextBox TbRoomName
        {
            get => _tbRoomName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbRoomName == null)
                    ;
                _tbRoomName = value;
                if (_tbRoomName != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudRoomForceRating
        {
            get => _nudRoomForceRating;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudRoomForceRating == null)
                    ;
                _nudRoomForceRating = value;
                if (_nudRoomForceRating != null)
                    ;
            }
        }

        internal virtual TextBox TbModDescription
        {
            get => _tbModDescription;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModDescription == null)
                    ;
                _tbModDescription = value;
                if (_tbModDescription != null)
                    ;
            }
        }

        internal virtual Button BtnSetModNameLang
        {
            get => _btnSetModNameLang;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetModNameLang != null)
                    _btnSetModNameLang.Click -= btnSetModNameLang_Click;
                _btnSetModNameLang = value;
                if (_btnSetModNameLang == null)
                    return;
                _btnSetModNameLang.Click += btnSetModNameLang_Click;
            }
        }

        internal virtual Button BtnSetAreaNameLang
        {
            get => _btnSetAreaNameLang;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSetAreaNameLang != null)
                    _btnSetAreaNameLang.Click -= btnSetAreaNameLang_Click;
                _btnSetAreaNameLang = value;
                if (_btnSetAreaNameLang == null)
                    return;
                _btnSetAreaNameLang.Click += btnSetAreaNameLang_Click;
            }
        }

        internal virtual ComboBox CmbxWindPower
        {
            get => _cmbxWindPower;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxWindPower == null)
                    ;
                _cmbxWindPower = value;
                if (_cmbxWindPower != null)
                    ;
            }
        }

        internal virtual Label Label84
        {
            get => _label84;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label84 == null)
                    ;
                _label84 = value;
                if (_label84 != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbUnescapable
        {
            get => _chkbUnescapable;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbUnescapable == null)
                    ;
                _chkbUnescapable = value;
                if (_chkbUnescapable != null)
                    ;
            }
        }

        internal virtual Label Label85
        {
            get => _label85;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label85 == null)
                    ;
                _label85 = value;
                if (_label85 != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbDisableTransit
        {
            get => _chkbDisableTransit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbDisableTransit == null)
                    ;
                _chkbDisableTransit = value;
                if (_chkbDisableTransit != null)
                    ;
            }
        }

        internal virtual Label Label86
        {
            get => _label86;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_label86 == null)
                    ;
                _label86 = value;
                if (_label86 != null)
                    ;
            }
        }

        internal virtual PictureBox PboxXy
        {
            get => _pboxXy;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pboxXy == null)
                    ;
                _pboxXy = value;
                if (_pboxXy != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudXy
        {
            get => _nudXy;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudXy != null)
                {
                    _nudXy.ValueChanged -= nudXY_ValueChanged;
                    _nudXy.KeyUp -= nudXY_KeyUp;
                }

                _nudXy = value;
                if (_nudXy == null)
                    return;
                _nudXy.ValueChanged += nudXY_ValueChanged;
                _nudXy.KeyUp += nudXY_KeyUp;
            }
        }

        internal virtual Label LblBearing
        {
            get => _lblBearing;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblBearing == null)
                    ;
                _lblBearing = value;
                if (_lblBearing != null)
                    ;
            }
        }

        internal virtual TextBox TbModEntryArea
        {
            get => _tbModEntryArea;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbModEntryArea == null)
                    ;
                _tbModEntryArea = value;
                if (_tbModEntryArea != null)
                    ;
            }
        }

        public string ModTag
        {
            get => TbModTag.Text.Trim();
            set => TbModTag.Text = value;
        }

        public string ModEntryArea
        {
            get => TbModEntryArea.Text.Trim();
            set => TbModEntryArea.Text = value;
        }

        public string ModName
        {
            get => TbModName.Text.Trim();
            set => TbModName.Text = value;
        }

        public float ModEntryX
        {
            get => Convert.ToSingle(NudModEntryX.Value);
            set => NudModEntryX.Value = new Decimal(value);
        }

        public float ModEntryY
        {
            get => Convert.ToSingle(NudModEntryY.Value);
            set => NudModEntryY.Value = new Decimal(value);
        }

        public float ModEntryZ
        {
            get => Convert.ToSingle(NudModEntryZ.Value);
            set => NudModEntryZ.Value = new Decimal(value);
        }

        private float XOrientation
        {
            get => _xOrientation;
            set => _xOrientation = value;
        }

        private float YOrientation
        {
            get => _yOrientation;
            set => _yOrientation = value;
        }

        public int ModMinutesPerHour
        {
            get => Convert.ToInt32(NudMinutesPerHour.Value);
            set => NudMinutesPerHour.Value = new Decimal(value);
        }

        public int ModDawnHour
        {
            get => Convert.ToInt32(NudDawnStartHour.Value);
            set => NudDawnStartHour.Value = new Decimal(value);
        }

        public int ModDuskHour
        {
            get => Convert.ToInt32(NudDuskStartHour.Value);
            set => NudDuskStartHour.Value = new Decimal(value);
        }

        public int ModStartHour
        {
            get => Convert.ToInt32(NudStartHour.Value);
            set => NudStartHour.Value = new Decimal(value);
        }

        public int ModStartDay
        {
            get => Convert.ToInt32(NudStartDay.Value);
            set => NudStartDay.Value = new Decimal(value);
        }

        public int ModStartMonth
        {
            get => Convert.ToInt32(NudStartMonth.Value);
            set => NudStartMonth.Value = new Decimal(value);
        }

        public int ModStartYear
        {
            get => Convert.ToInt32(NudStartYear.Value);
            set => NudStartYear.Value = new Decimal(value);
        }

        public int ModXpScale
        {
            get => Convert.ToInt32(NudXpScale.Value);
            set => NudXpScale.Value = new Decimal(value);
        }

        public string ModOnAcquirItem
        {
            get => TbModOnAcquirItem.Text.Trim();
            set => TbModOnAcquirItem.Text = value;
        }

        public string ModOnActvtItem
        {
            get => TbModOnActvtItem.Text.Trim();
            set => TbModOnActvtItem.Text = value;
        }

        public string ModOnClientEntr
        {
            get => TbModOnClientEntr.Text.Trim();
            set => TbModOnClientEntr.Text = value;
        }

        public string ModOnClientLeav
        {
            get => TbModOnClientLeav.Text.Trim();
            set => TbModOnClientLeav.Text = value;
        }

        public string ModOnHeartbeat
        {
            get => TbModOnHeartbeat.Text.Trim();
            set => TbModOnHeartbeat.Text = value;
        }

        public string ModOnModLoad
        {
            get => TbModOnModLoad.Text.Trim();
            set => TbModOnModLoad.Text = value;
        }

        public string ModOnPlrDeath
        {
            get => TbModOnPlrDeath.Text.Trim();
            set => TbModOnPlrDeath.Text = value;
        }

        public string ModOnPlrDying
        {
            get => TbModOnPlrDying.Text.Trim();
            set => TbModOnPlrDying.Text = value;
        }

        public string ModOnPlrLvlUp
        {
            get => TbModOnPlrLvlUp.Text.Trim();
            set => TbModOnPlrLvlUp.Text = value;
        }

        public string ModOnSpawnBtnDn
        {
            get => TbModOnSpawnBtnDn.Text.Trim();
            set => TbModOnSpawnBtnDn.Text = value;
        }

        public string ModOnPlrRest
        {
            get => TbModOnPlrRest.Text.Trim();
            set => TbModOnPlrRest.Text = value;
        }

        public string ModOnUnAqreItem
        {
            get => TbModOnUnAqreItem.Text.Trim();
            set => TbModOnUnAqreItem.Text = value;
        }

        public string ModOnUsrDefined
        {
            get => TbModOnUsrDefined.Text.Trim();
            set => TbModOnUsrDefined.Text = value;
        }

        public uint DynAmbientColor
        {
            get => Color2Bgr(BtnDynAmbientColor.BackColor);
            set => BtnDynAmbientColor.BackColor = Bgr2Color(value);
        }

        public uint SunAmbientColor
        {
            get => Color2Bgr(BtnSunAmbientColor.BackColor);
            set => BtnSunAmbientColor.BackColor = Bgr2Color(value);
        }

        public uint SunDiffuseColor
        {
            get => Color2Bgr(BtnSunDiffuseColor.BackColor);
            set => BtnSunDiffuseColor.BackColor = Bgr2Color(value);
        }

        public uint SunFogColor
        {
            get => Color2Bgr(BtnSunFogColor.BackColor);
            set => BtnSunFogColor.BackColor = Bgr2Color(value);
        }

        public uint MoonAmbientColor
        {
            get => Color2Bgr(BtnMoonAmbientColor.BackColor);
            set => BtnMoonAmbientColor.BackColor = Bgr2Color(value);
        }

        public uint MoonDiffuseColor
        {
            get => Color2Bgr(BtnMoonDiffuseColor.BackColor);
            set => BtnMoonDiffuseColor.BackColor = Bgr2Color(value);
        }

        public uint MoonFogColor
        {
            get => Color2Bgr(BtnMoonFogColor.BackColor);
            set => BtnMoonFogColor.BackColor = Bgr2Color(value);
        }

        public uint GrassAmbient
        {
            get => Color2Bgr(BtnGrassAmbientColor.BackColor);
            set => BtnGrassAmbientColor.BackColor = Bgr2Color(value);
        }

        public uint GrassDiffuse
        {
            get => Color2Bgr(BtnGrassDiffuseColor.BackColor);
            set => BtnGrassDiffuseColor.BackColor = Bgr2Color(value);
        }

        public uint GrassEmissive
        {
            get => Color2Bgr(BtnGrassEmissiveColor.BackColor);
            set => BtnGrassEmissiveColor.BackColor = Bgr2Color(value);
        }

        public float GrassProbLl
        {
            get => Convert.ToSingle(Decimal.Divide(NudGrassProbLl.Value, new Decimal(100L)));
            set => NudGrassProbLl.Value = new Decimal(value * 100f);
        }

        public float GrassProbUl
        {
            get => Convert.ToSingle(Decimal.Divide(NudGrassProbUl.Value, new Decimal(100L)));
            set => NudGrassProbUl.Value = new Decimal(value * 100f);
        }

        public float GrassProbLr
        {
            get => Convert.ToSingle(Decimal.Divide(NudGrassProbLr.Value, new Decimal(100L)));
            set => NudGrassProbLr.Value = new Decimal(value * 100f);
        }

        public float GrassProbUr
        {
            get => Convert.ToSingle(Decimal.Divide(NudGrassProbUr.Value, new Decimal(100L)));
            set => NudGrassProbUr.Value = new Decimal(value * 100f);
        }

        public bool ModEntryChanged => _origXOrientation != (double) _xOrientation ||
                                       _origYOrientation != (double) _yOrientation ||
                                       (_origXPos != (double) ModEntryX || _origYpos != (double) ModEntryY) ||
                                       _origZpos != (double) ModEntryZ;

        public FrmModuleIfoAreaEditor()
        {
            _comboBoxSettingError = false;
            _bmpXy = new Bitmap(50, 50);
            _xyAngle = 0.0;
            InitializeComponent();
        }

        public FrmModuleIfoAreaEditor(ref ClsGff areFile, ref ClsGff ifoFile, ref ClsGff gitFile, int kotorVersion)
            : this()
        {
            KotorVersionIndex = kotorVersion;
            CurrentSettings = UserSettings.GetSettings();
            _dialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(KotorVersionIndex) + "\\dialog.tlk");
            _chitinKey = new ClsChitinKey(ConfigOptions.Paths.KeyFileLocation(KotorVersionIndex));
            _areFile = areFile;
            _ifoFile = ifoFile;
            _gitFile = gitFile;
            FillForm();
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
            TabControlModule = new TabControl();
            TabpagModuleBasic = new TabPage();
            PboxXy = new PictureBox();
            NudXy = new NumericUpDown();
            LblBearing = new Label();
            Label11 = new Label();
            NudModEntryX = new NumericUpDown();
            Label12 = new Label();
            NudModEntryY = new NumericUpDown();
            Label13 = new Label();
            NudModEntryZ = new NumericUpDown();
            BtnSetModNameLang = new Button();
            TbModTag = new TextBox();
            TbModName = new TextBox();
            Label8 = new Label();
            Label9 = new Label();
            TbModEntryArea = new TextBox();
            Label10 = new Label();
            TabpagModuleAdvanced = new TabPage();
            NudXpScale = new NumericUpDown();
            TrkbarXpScale = new TrackBar();
            Label46 = new Label();
            NudMinutesPerHour = new NumericUpDown();
            Label1 = new Label();
            NudDawnStartHour = new NumericUpDown();
            Label2 = new Label();
            NudDuskStartHour = new NumericUpDown();
            Label3 = new Label();
            NudStartHour = new NumericUpDown();
            Label4 = new Label();
            NudStartDay = new NumericUpDown();
            Label5 = new Label();
            NudStartMonth = new NumericUpDown();
            Label6 = new Label();
            NudStartYear = new NumericUpDown();
            Label7 = new Label();
            TabpagModuleEvents = new TabPage();
            Label34 = new Label();
            TbModOnClientEntr = new TextBox();
            Label33 = new Label();
            TbModOnActvtItem = new TextBox();
            Label32 = new Label();
            TbModOnAcquirItem = new TextBox();
            Label35 = new Label();
            TbModOnClientLeav = new TextBox();
            TbModOnHeartbeat = new TextBox();
            Label36 = new Label();
            Label37 = new Label();
            TbModOnModLoad = new TextBox();
            TbModOnPlrDeath = new TextBox();
            Label38 = new Label();
            TbModOnPlrDying = new TextBox();
            Label39 = new Label();
            Label40 = new Label();
            TbModOnPlrLvlUp = new TextBox();
            Label41 = new Label();
            TbModOnSpawnBtnDn = new TextBox();
            TbModOnPlrRest = new TextBox();
            Label42 = new Label();
            TbModOnUnAqreItem = new TextBox();
            Label43 = new Label();
            Label44 = new Label();
            TbModOnUsrDefined = new TextBox();
            TabpagModuleDescription = new TabPage();
            BtnSetDescriptionLang = new Button();
            TbModDescription = new TextBox();
            TabControlMain = new TabControl();
            TabPage5 = new TabPage();
            TabPage6 = new TabPage();
            TabControlArea = new TabControl();
            TabpagAreaBasic = new TabPage();
            ChkbUnescapable = new CheckBox();
            Label19 = new Label();
            CmbxCameraStyle = new ComboBox();
            Label14 = new Label();
            NumericUpDown10 = new NumericUpDown();
            Label15 = new Label();
            NumericUpDown11 = new NumericUpDown();
            Label16 = new Label();
            NumericUpDown12 = new NumericUpDown();
            BtnSetAreaNameLang = new Button();
            TbAreaTag = new TextBox();
            TbAreaName = new TextBox();
            Label17 = new Label();
            Label18 = new Label();
            Label85 = new Label();
            ChkbDisableTransit = new CheckBox();
            Label86 = new Label();
            TabpagAreaEnvironment = new TabPage();
            CmbxWindPower = new ComboBox();
            GroupBox1 = new GroupBox();
            Label49 = new Label();
            NudChanceSnow = new NumericUpDown();
            Label50 = new Label();
            NudChanceRain = new NumericUpDown();
            Label51 = new Label();
            NudChanceLightning = new NumericUpDown();
            RbDayNightCycle = new RadioButton();
            GbMoon = new GroupBox();
            BtnMoonDiffuseColor = new Button();
            Label24 = new Label();
            Label25 = new Label();
            BtnMoonAmbientColor = new Button();
            Label31 = new Label();
            Label45 = new Label();
            BtnMoonFogColor = new Button();
            ChkbAreaMoonShadows = new CheckBox();
            Label47 = new Label();
            ChkbMoonFogOn = new CheckBox();
            TrkbarMoonFogNear = new TrackBar();
            LblMoonFogNear = new Label();
            TrkbarMoonFogFar = new TrackBar();
            LblMoonFogFar = new Label();
            GbSun = new GroupBox();
            ChkbAreaSunShadows = new CheckBox();
            TrkbarSunFogNear = new TrackBar();
            Label27 = new Label();
            BtnSunAmbientColor = new Button();
            Label26 = new Label();
            BtnSunDiffuseColor = new Button();
            Label28 = new Label();
            BtnSunFogColor = new Button();
            Label29 = new Label();
            Label30 = new Label();
            TrkbarSunFogFar = new TrackBar();
            LblSunFogNear = new Label();
            LblSunFogFar = new Label();
            ChkbSunFogOn = new CheckBox();
            RbAlwaysDay = new RadioButton();
            RbAlwaysNight = new RadioButton();
            BtnDynAmbientColor = new Button();
            Label48 = new Label();
            Label73 = new Label();
            NudShadowOpacity = new NumericUpDown();
            Label84 = new Label();
            TabpagAreaGrass = new TabPage();
            NudGrassDensity = new NumericUpDown();
            TrkbarGrassDensityX10 = new TrackBar();
            Label62 = new Label();
            BtnGrassDiffuseColor = new Button();
            TbGrassTexName = new TextBox();
            Label20 = new Label();
            Label21 = new Label();
            Label22 = new Label();
            BtnGrassAmbientColor = new Button();
            Label23 = new Label();
            BtnGrassEmissiveColor = new Button();
            NudGrassProbUl = new NumericUpDown();
            NudGrassProbLl = new NumericUpDown();
            NudGrassProbUr = new NumericUpDown();
            NudGrassProbLr = new NumericUpDown();
            Label63 = new Label();
            Label64 = new Label();
            Label65 = new Label();
            Label66 = new Label();
            Label67 = new Label();
            LblTotalGrassProbability = new Label();
            Label69 = new Label();
            Label70 = new Label();
            Label71 = new Label();
            Label72 = new Label();
            Label68 = new Label();
            NudGrassQuadSize = new NumericUpDown();
            TabpagAreaAudio = new TabPage();
            TrkbarAmbientSndNightVol = new TrackBar();
            TrkbarAmbientSndDayVol = new TrackBar();
            Label52 = new Label();
            NudMusicDelay = new NumericUpDown();
            CmbxMusicNight = new ComboBox();
            CmbxMusicDay = new ComboBox();
            CmbxMusicBattle = new ComboBox();
            CmbxEnvAudio = new ComboBox();
            CmbxAmbientSndNight = new ComboBox();
            CmbxAmbientSndDay = new ComboBox();
            Label53 = new Label();
            Label54 = new Label();
            Label55 = new Label();
            Label56 = new Label();
            Label57 = new Label();
            Label58 = new Label();
            Label59 = new Label();
            Label60 = new Label();
            Label61 = new Label();
            TabpagAreaEvents = new TabPage();
            Label77 = new Label();
            TbAreaOnUserDefined = new TextBox();
            TbAreaOnHeartbeat = new TextBox();
            Label76 = new Label();
            Label74 = new Label();
            TbAreaOnEnter = new TextBox();
            Label75 = new Label();
            TbAreaOnExit = new TextBox();
            TabpagAreaRooms = new TabPage();
            LbRooms = new ListBox();
            Label82 = new Label();
            ChkbRoomDisableWeather = new CheckBox();
            NudRoomAmbientScale = new NumericUpDown();
            Label80 = new Label();
            CmbxRoomEnvAudio = new ComboBox();
            Label79 = new Label();
            Label78 = new Label();
            TbRoomName = new TextBox();
            NudRoomForceRating = new NumericUpDown();
            Label81 = new Label();
            Label83 = new Label();
            ColorDialog1 = new ColorDialog();
            BtnOk = new Button();
            BtnCancel = new Button();
            TabControlModule.SuspendLayout();
            TabpagModuleBasic.SuspendLayout();
            NudXy.BeginInit();
            NudModEntryX.BeginInit();
            NudModEntryY.BeginInit();
            NudModEntryZ.BeginInit();
            TabpagModuleAdvanced.SuspendLayout();
            NudXpScale.BeginInit();
            TrkbarXpScale.BeginInit();
            NudMinutesPerHour.BeginInit();
            NudDawnStartHour.BeginInit();
            NudDuskStartHour.BeginInit();
            NudStartHour.BeginInit();
            NudStartDay.BeginInit();
            NudStartMonth.BeginInit();
            NudStartYear.BeginInit();
            TabpagModuleEvents.SuspendLayout();
            TabpagModuleDescription.SuspendLayout();
            TabControlMain.SuspendLayout();
            TabPage5.SuspendLayout();
            TabPage6.SuspendLayout();
            TabControlArea.SuspendLayout();
            TabpagAreaBasic.SuspendLayout();
            NumericUpDown10.BeginInit();
            NumericUpDown11.BeginInit();
            NumericUpDown12.BeginInit();
            TabpagAreaEnvironment.SuspendLayout();
            GroupBox1.SuspendLayout();
            NudChanceSnow.BeginInit();
            NudChanceRain.BeginInit();
            NudChanceLightning.BeginInit();
            GbMoon.SuspendLayout();
            TrkbarMoonFogNear.BeginInit();
            TrkbarMoonFogFar.BeginInit();
            GbSun.SuspendLayout();
            TrkbarSunFogNear.BeginInit();
            TrkbarSunFogFar.BeginInit();
            NudShadowOpacity.BeginInit();
            TabpagAreaGrass.SuspendLayout();
            NudGrassDensity.BeginInit();
            TrkbarGrassDensityX10.BeginInit();
            NudGrassProbUl.BeginInit();
            NudGrassProbLl.BeginInit();
            NudGrassProbUr.BeginInit();
            NudGrassProbLr.BeginInit();
            NudGrassQuadSize.BeginInit();
            TabpagAreaAudio.SuspendLayout();
            TrkbarAmbientSndNightVol.BeginInit();
            TrkbarAmbientSndDayVol.BeginInit();
            NudMusicDelay.BeginInit();
            TabpagAreaEvents.SuspendLayout();
            TabpagAreaRooms.SuspendLayout();
            NudRoomAmbientScale.BeginInit();
            NudRoomForceRating.BeginInit();
            SuspendLayout();
            TabControlModule.Controls.Add(TabpagModuleBasic);
            TabControlModule.Controls.Add(TabpagModuleAdvanced);
            TabControlModule.Controls.Add(TabpagModuleEvents);
            TabControlModule.Controls.Add(TabpagModuleDescription);
            TabControlModule.Dock = DockStyle.Fill;
            TabControl tabControlModule1 = TabControlModule;
            Point point1 = new Point(0, 0);
            Point point2 = point1;
            tabControlModule1.Location = point2;
            TabControlModule.Name = "TabControlModule";
            TabControl tabControlModule2 = TabControlModule;
            point1 = new Point(12, 3);
            Point point3 = point1;
            tabControlModule2.Padding = point3;
            TabControlModule.SelectedIndex = 0;
            TabControl tabControlModule3 = TabControlModule;
            Size size1 = new Size(488, 470);
            Size size2 = size1;
            tabControlModule3.Size = size2;
            TabControlModule.TabIndex = 0;
            TabpagModuleBasic.Controls.Add(PboxXy);
            TabpagModuleBasic.Controls.Add(NudXy);
            TabpagModuleBasic.Controls.Add(LblBearing);
            TabpagModuleBasic.Controls.Add(Label11);
            TabpagModuleBasic.Controls.Add(NudModEntryX);
            TabpagModuleBasic.Controls.Add(Label12);
            TabpagModuleBasic.Controls.Add(NudModEntryY);
            TabpagModuleBasic.Controls.Add(Label13);
            TabpagModuleBasic.Controls.Add(NudModEntryZ);
            TabpagModuleBasic.Controls.Add(BtnSetModNameLang);
            TabpagModuleBasic.Controls.Add(TbModTag);
            TabpagModuleBasic.Controls.Add(TbModName);
            TabpagModuleBasic.Controls.Add(Label8);
            TabpagModuleBasic.Controls.Add(Label9);
            TabpagModuleBasic.Controls.Add(TbModEntryArea);
            TabpagModuleBasic.Controls.Add(Label10);
            TabPage tabpagModuleBasic1 = TabpagModuleBasic;
            point1 = new Point(4, 22);
            Point point4 = point1;
            ((Control) tabpagModuleBasic1).Location = point4;
            TabpagModuleBasic.Name = "tabpagModuleBasic";
            TabPage tabpagModuleBasic2 = TabpagModuleBasic;
            size1 = new Size(480, 444);
            Size size3 = size1;
            tabpagModuleBasic2.Size = size3;
            TabpagModuleBasic.TabIndex = 0;
            TabpagModuleBasic.Text = "Basic";
            PictureBox pboxXy1 = PboxXy;
            point1 = new Point(312, 152);
            Point point5 = point1;
            pboxXy1.Location = point5;
            PboxXy.Name = "pboxXY";
            PictureBox pboxXy2 = PboxXy;
            size1 = new Size(50, 50);
            Size size4 = size1;
            pboxXy2.Size = size4;
            PboxXy.TabIndex = 22;
            PboxXy.TabStop = false;
            NudXy.DecimalPlaces = 2;
            NumericUpDown nudXy1 = NudXy;
            point1 = new Point(304, 208);
            Point point6 = point1;
            nudXy1.Location = point6;
            NumericUpDown nudXy2 = NudXy;
            Decimal num1 = new Decimal(new int[4] {736755711, 8381903, 0, 917504});
            Decimal num2 = num1;
            nudXy2.Maximum = num2;
            NudXy.Name = "nudXY";
            NumericUpDown nudXy3 = NudXy;
            size1 = new Size(64, 20);
            Size size5 = size1;
            nudXy3.Size = size5;
            NudXy.TabIndex = 23;
            NudXy.TextAlign = HorizontalAlignment.Center;
            Label lblBearing1 = LblBearing;
            point1 = new Point(312, 128);
            Point point7 = point1;
            lblBearing1.Location = point7;
            LblBearing.Name = "lblBearing";
            Label lblBearing2 = LblBearing;
            size1 = new Size(48, 16);
            Size size6 = size1;
            lblBearing2.Size = size6;
            LblBearing.TabIndex = 21;
            LblBearing.Text = "Bearing";
            LblBearing.TextAlign = ContentAlignment.MiddleCenter;
            Label label111 = Label11;
            point1 = new Point(24, 144);
            Point point8 = point1;
            label111.Location = point8;
            Label11.Name = "Label11";
            Label label112 = Label11;
            size1 = new Size(104, 16);
            Size size7 = size1;
            label112.Size = size7;
            Label11.TabIndex = 19;
            Label11.Text = "Starting Position X";
            Label11.TextAlign = ContentAlignment.MiddleRight;
            NudModEntryX.DecimalPlaces = 4;
            NumericUpDown nudModEntryX1 = NudModEntryX;
            point1 = new Point(144, 144);
            Point point9 = point1;
            nudModEntryX1.Location = point9;
            NumericUpDown nudModEntryX2 = NudModEntryX;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num3 = num1;
            nudModEntryX2.Maximum = num3;
            NumericUpDown nudModEntryX3 = NudModEntryX;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            Decimal num4 = num1;
            nudModEntryX3.Minimum = num4;
            NudModEntryX.Name = "nudModEntryX";
            NumericUpDown nudModEntryX4 = NudModEntryX;
            size1 = new Size(96, 20);
            Size size8 = size1;
            nudModEntryX4.Size = size8;
            NudModEntryX.TabIndex = 4;
            NudModEntryX.TextAlign = HorizontalAlignment.Right;
            Label label121 = Label12;
            point1 = new Point(24, 176);
            Point point10 = point1;
            label121.Location = point10;
            Label12.Name = "Label12";
            Label label122 = Label12;
            size1 = new Size(104, 16);
            Size size9 = size1;
            label122.Size = size9;
            Label12.TabIndex = 20;
            Label12.Text = "Starting Position Y";
            Label12.TextAlign = ContentAlignment.MiddleRight;
            NudModEntryY.DecimalPlaces = 4;
            NumericUpDown nudModEntryY1 = NudModEntryY;
            point1 = new Point(144, 176);
            Point point11 = point1;
            nudModEntryY1.Location = point11;
            NumericUpDown nudModEntryY2 = NudModEntryY;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num5 = num1;
            nudModEntryY2.Maximum = num5;
            NumericUpDown nudModEntryY3 = NudModEntryY;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            Decimal num6 = num1;
            nudModEntryY3.Minimum = num6;
            NudModEntryY.Name = "nudModEntryY";
            NumericUpDown nudModEntryY4 = NudModEntryY;
            size1 = new Size(96, 20);
            Size size10 = size1;
            nudModEntryY4.Size = size10;
            NudModEntryY.TabIndex = 5;
            NudModEntryY.TextAlign = HorizontalAlignment.Right;
            Label label131 = Label13;
            point1 = new Point(24, 208);
            Point point12 = point1;
            label131.Location = point12;
            Label13.Name = "Label13";
            Label label132 = Label13;
            size1 = new Size(104, 16);
            Size size11 = size1;
            label132.Size = size11;
            Label13.TabIndex = 18;
            Label13.Text = "Starting Position Z";
            Label13.TextAlign = ContentAlignment.MiddleRight;
            NudModEntryZ.DecimalPlaces = 4;
            NumericUpDown nudModEntryZ1 = NudModEntryZ;
            point1 = new Point(144, 208);
            Point point13 = point1;
            nudModEntryZ1.Location = point13;
            NumericUpDown nudModEntryZ2 = NudModEntryZ;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num7 = num1;
            nudModEntryZ2.Maximum = num7;
            NumericUpDown nudModEntryZ3 = NudModEntryZ;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            Decimal num8 = num1;
            nudModEntryZ3.Minimum = num8;
            NudModEntryZ.Name = "nudModEntryZ";
            NumericUpDown nudModEntryZ4 = NudModEntryZ;
            size1 = new Size(96, 20);
            Size size12 = size1;
            nudModEntryZ4.Size = size12;
            NudModEntryZ.TabIndex = 6;
            NudModEntryZ.TextAlign = HorizontalAlignment.Right;
            Button btnSetModNameLang1 = BtnSetModNameLang;
            point1 = new Point(296, 40);
            Point point14 = point1;
            btnSetModNameLang1.Location = point14;
            BtnSetModNameLang.Name = "btnSetModNameLang";
            Button btnSetModNameLang2 = BtnSetModNameLang;
            size1 = new Size(88, 23);
            Size size13 = size1;
            btnSetModNameLang2.Size = size13;
            BtnSetModNameLang.TabIndex = 1;
            BtnSetModNameLang.Text = "Set Language";
            TextBox tbModTag1 = TbModTag;
            point1 = new Point(112, 64);
            Point point15 = point1;
            tbModTag1.Location = point15;
            TbModTag.Name = "tbModTag";
            TextBox tbModTag2 = TbModTag;
            size1 = new Size(88, 20);
            Size size14 = size1;
            tbModTag2.Size = size14;
            TbModTag.TabIndex = 2;
            TbModTag.Text = "";
            TextBox tbModName1 = TbModName;
            point1 = new Point(112, 40);
            Point point16 = point1;
            tbModName1.Location = point16;
            TbModName.Name = "tbModName";
            TextBox tbModName2 = TbModName;
            size1 = new Size(176, 20);
            Size size15 = size1;
            tbModName2.Size = size15;
            TbModName.TabIndex = 0;
            TbModName.Text = "";
            Label label81 = Label8;
            point1 = new Point(24, 40);
            Point point17 = point1;
            label81.Location = point17;
            Label8.Name = "Label8";
            Label label82 = Label8;
            size1 = new Size(48, 16);
            Size size16 = size1;
            label82.Size = size16;
            Label8.TabIndex = 10;
            Label8.Text = "Name";
            Label8.TextAlign = ContentAlignment.MiddleLeft;
            Label label91 = Label9;
            point1 = new Point(24, 64);
            Point point18 = point1;
            label91.Location = point18;
            Label9.Name = "Label9";
            Label label92 = Label9;
            size1 = new Size(48, 16);
            Size size17 = size1;
            label92.Size = size17;
            Label9.TabIndex = 11;
            Label9.Text = "Tag";
            Label9.TextAlign = ContentAlignment.MiddleLeft;
            TextBox tbModEntryArea1 = TbModEntryArea;
            point1 = new Point(112, 104);
            Point point19 = point1;
            tbModEntryArea1.Location = point19;
            TbModEntryArea.Name = "tbModEntryArea";
            TextBox tbModEntryArea2 = TbModEntryArea;
            size1 = new Size(176, 20);
            Size size18 = size1;
            tbModEntryArea2.Size = size18;
            TbModEntryArea.TabIndex = 3;
            TbModEntryArea.Text = "";
            Label label101 = Label10;
            point1 = new Point(16, 104);
            Point point20 = point1;
            label101.Location = point20;
            Label10.Name = "Label10";
            Label label102 = Label10;
            size1 = new Size(56, 16);
            Size size19 = size1;
            label102.Size = size19;
            Label10.TabIndex = 10;
            Label10.Text = "Start Area";
            Label10.TextAlign = ContentAlignment.MiddleLeft;
            TabpagModuleAdvanced.Controls.Add(NudXpScale);
            TabpagModuleAdvanced.Controls.Add(TrkbarXpScale);
            TabpagModuleAdvanced.Controls.Add(Label46);
            TabpagModuleAdvanced.Controls.Add(NudMinutesPerHour);
            TabpagModuleAdvanced.Controls.Add(Label1);
            TabpagModuleAdvanced.Controls.Add(NudDawnStartHour);
            TabpagModuleAdvanced.Controls.Add(Label2);
            TabpagModuleAdvanced.Controls.Add(NudDuskStartHour);
            TabpagModuleAdvanced.Controls.Add(Label3);
            TabpagModuleAdvanced.Controls.Add(NudStartHour);
            TabpagModuleAdvanced.Controls.Add(Label4);
            TabpagModuleAdvanced.Controls.Add(NudStartDay);
            TabpagModuleAdvanced.Controls.Add(Label5);
            TabpagModuleAdvanced.Controls.Add(NudStartMonth);
            TabpagModuleAdvanced.Controls.Add(Label6);
            TabpagModuleAdvanced.Controls.Add(NudStartYear);
            TabpagModuleAdvanced.Controls.Add(Label7);
            TabPage tabpagModuleAdvanced1 = TabpagModuleAdvanced;
            point1 = new Point(4, 22);
            Point point21 = point1;
            ((Control) tabpagModuleAdvanced1).Location = point21;
            TabpagModuleAdvanced.Name = "tabpagModuleAdvanced";
            TabPage tabpagModuleAdvanced2 = TabpagModuleAdvanced;
            size1 = new Size(480, 444);
            Size size20 = size1;
            tabpagModuleAdvanced2.Size = size20;
            TabpagModuleAdvanced.TabIndex = 2;
            TabpagModuleAdvanced.Text = "Advanced";
            NumericUpDown nudXpScale1 = NudXpScale;
            point1 = new Point(336, 272);
            Point point22 = point1;
            nudXpScale1.Location = point22;
            NumericUpDown nudXpScale2 = NudXpScale;
            num1 = new Decimal(new int[4] {200, 0, 0, 0});
            Decimal num9 = num1;
            nudXpScale2.Maximum = num9;
            NudXpScale.Name = "nudXPScale";
            NudXpScale.RightToLeft = RightToLeft.No;
            NumericUpDown nudXpScale3 = NudXpScale;
            size1 = new Size(42, 20);
            Size size21 = size1;
            nudXpScale3.Size = size21;
            NudXpScale.TabIndex = 8;
            NudXpScale.TextAlign = HorizontalAlignment.Right;
            TrackBar trkbarXpScale1 = TrkbarXpScale;
            point1 = new Point(120, 264);
            Point point23 = point1;
            trkbarXpScale1.Location = point23;
            TrkbarXpScale.Maximum = 200;
            TrkbarXpScale.Name = "trkbarXPScale";
            TrackBar trkbarXpScale2 = TrkbarXpScale;
            size1 = new Size(216, 42);
            Size size22 = size1;
            trkbarXpScale2.Size = size22;
            TrkbarXpScale.TabIndex = 7;
            TrkbarXpScale.TickFrequency = 10;
            Label label461 = Label46;
            point1 = new Point(24, 40);
            Point point24 = point1;
            label461.Location = point24;
            Label46.Name = "Label46";
            Label label462 = Label46;
            size1 = new Size(88, 16);
            Size size23 = size1;
            label462.Size = size23;
            Label46.TabIndex = 5;
            Label46.Text = "Minutes/Hour";
            Label46.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudMinutesPerHour1 = NudMinutesPerHour;
            point1 = new Point(128, 40);
            Point point25 = point1;
            nudMinutesPerHour1.Location = point25;
            NumericUpDown nudMinutesPerHour2 = NudMinutesPerHour;
            num1 = new Decimal(new int[4] {60, 0, 0, 0});
            Decimal num10 = num1;
            nudMinutesPerHour2.Maximum = num10;
            NumericUpDown nudMinutesPerHour3 = NudMinutesPerHour;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num11 = num1;
            nudMinutesPerHour3.Minimum = num11;
            NudMinutesPerHour.Name = "nudMinutesPerHour";
            NumericUpDown nudMinutesPerHour4 = NudMinutesPerHour;
            size1 = new Size(48, 20);
            Size size24 = size1;
            nudMinutesPerHour4.Size = size24;
            NudMinutesPerHour.TabIndex = 0;
            NudMinutesPerHour.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudMinutesPerHour5 = NudMinutesPerHour;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num12 = num1;
            nudMinutesPerHour5.Value = num12;
            Label label11 = Label1;
            point1 = new Point(24, 72);
            Point point26 = point1;
            label11.Location = point26;
            Label1.Name = "Label1";
            Label label12 = Label1;
            size1 = new Size(88, 16);
            Size size25 = size1;
            label12.Size = size25;
            Label1.TabIndex = 5;
            Label1.Text = "Dawn Start Hour";
            Label1.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudDawnStartHour1 = NudDawnStartHour;
            point1 = new Point(128, 72);
            Point point27 = point1;
            nudDawnStartHour1.Location = point27;
            NumericUpDown nudDawnStartHour2 = NudDawnStartHour;
            num1 = new Decimal(new int[4] {23, 0, 0, 0});
            Decimal num13 = num1;
            nudDawnStartHour2.Maximum = num13;
            NudDawnStartHour.Name = "nudDawnStartHour";
            NumericUpDown nudDawnStartHour3 = NudDawnStartHour;
            size1 = new Size(48, 20);
            Size size26 = size1;
            nudDawnStartHour3.Size = size26;
            NudDawnStartHour.TabIndex = 1;
            NudDawnStartHour.TextAlign = HorizontalAlignment.Right;
            Label label21 = Label2;
            point1 = new Point(24, 104);
            Point point28 = point1;
            label21.Location = point28;
            Label2.Name = "Label2";
            Label label22 = Label2;
            size1 = new Size(88, 16);
            Size size27 = size1;
            label22.Size = size27;
            Label2.TabIndex = 5;
            Label2.Text = "Dusk Start Hour";
            Label2.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudDuskStartHour1 = NudDuskStartHour;
            point1 = new Point(128, 104);
            Point point29 = point1;
            nudDuskStartHour1.Location = point29;
            NumericUpDown nudDuskStartHour2 = NudDuskStartHour;
            num1 = new Decimal(new int[4] {23, 0, 0, 0});
            Decimal num14 = num1;
            nudDuskStartHour2.Maximum = num14;
            NudDuskStartHour.Name = "nudDuskStartHour";
            NumericUpDown nudDuskStartHour3 = NudDuskStartHour;
            size1 = new Size(48, 20);
            Size size28 = size1;
            nudDuskStartHour3.Size = size28;
            NudDuskStartHour.TabIndex = 2;
            NudDuskStartHour.TextAlign = HorizontalAlignment.Right;
            Label label31 = Label3;
            point1 = new Point(24, 200);
            Point point30 = point1;
            label31.Location = point30;
            Label3.Name = "Label3";
            Label label32 = Label3;
            size1 = new Size(80, 16);
            Size size29 = size1;
            label32.Size = size29;
            Label3.TabIndex = 5;
            Label3.Text = "Starting Month";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudStartHour1 = NudStartHour;
            point1 = new Point(128, 136);
            Point point31 = point1;
            nudStartHour1.Location = point31;
            NumericUpDown nudStartHour2 = NudStartHour;
            num1 = new Decimal(new int[4] {23, 0, 0, 0});
            Decimal num15 = num1;
            nudStartHour2.Maximum = num15;
            NudStartHour.Name = "nudStartHour";
            NumericUpDown nudStartHour3 = NudStartHour;
            size1 = new Size(48, 20);
            Size size30 = size1;
            nudStartHour3.Size = size30;
            NudStartHour.TabIndex = 3;
            NudStartHour.TextAlign = HorizontalAlignment.Right;
            Label label41 = Label4;
            point1 = new Point(24, 168);
            Point point32 = point1;
            label41.Location = point32;
            Label4.Name = "Label4";
            Label label42 = Label4;
            size1 = new Size(72, 16);
            Size size31 = size1;
            label42.Size = size31;
            Label4.TabIndex = 5;
            Label4.Text = "Starting Day";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudStartDay1 = NudStartDay;
            point1 = new Point(128, 168);
            Point point33 = point1;
            nudStartDay1.Location = point33;
            NumericUpDown nudStartDay2 = NudStartDay;
            num1 = new Decimal(new int[4] {31, 0, 0, 0});
            Decimal num16 = num1;
            nudStartDay2.Maximum = num16;
            NumericUpDown nudStartDay3 = NudStartDay;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num17 = num1;
            nudStartDay3.Minimum = num17;
            NudStartDay.Name = "nudStartDay";
            NumericUpDown nudStartDay4 = NudStartDay;
            size1 = new Size(48, 20);
            Size size32 = size1;
            nudStartDay4.Size = size32;
            NudStartDay.TabIndex = 4;
            NudStartDay.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudStartDay5 = NudStartDay;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num18 = num1;
            nudStartDay5.Value = num18;
            Label label51 = Label5;
            point1 = new Point(24, 136);
            Point point34 = point1;
            label51.Location = point34;
            Label5.Name = "Label5";
            Label label52 = Label5;
            size1 = new Size(72, 16);
            Size size33 = size1;
            label52.Size = size33;
            Label5.TabIndex = 5;
            Label5.Text = "Starting Hour";
            Label5.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudStartMonth1 = NudStartMonth;
            point1 = new Point(128, 200);
            Point point35 = point1;
            nudStartMonth1.Location = point35;
            NumericUpDown nudStartMonth2 = NudStartMonth;
            num1 = new Decimal(new int[4] {12, 0, 0, 0});
            Decimal num19 = num1;
            nudStartMonth2.Maximum = num19;
            NumericUpDown nudStartMonth3 = NudStartMonth;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num20 = num1;
            nudStartMonth3.Minimum = num20;
            NudStartMonth.Name = "nudStartMonth";
            NumericUpDown nudStartMonth4 = NudStartMonth;
            size1 = new Size(48, 20);
            Size size34 = size1;
            nudStartMonth4.Size = size34;
            NudStartMonth.TabIndex = 5;
            NudStartMonth.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudStartMonth5 = NudStartMonth;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num21 = num1;
            nudStartMonth5.Value = num21;
            Label label61 = Label6;
            point1 = new Point(24, 232);
            Point point36 = point1;
            label61.Location = point36;
            Label6.Name = "Label6";
            Label label62 = Label6;
            size1 = new Size(72, 16);
            Size size35 = size1;
            label62.Size = size35;
            Label6.TabIndex = 5;
            Label6.Text = "Starting Year";
            Label6.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudStartYear1 = NudStartYear;
            point1 = new Point(128, 232);
            Point point37 = point1;
            nudStartYear1.Location = point37;
            NumericUpDown nudStartYear2 = NudStartYear;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num22 = num1;
            nudStartYear2.Maximum = num22;
            NudStartYear.Name = "nudStartYear";
            NumericUpDown nudStartYear3 = NudStartYear;
            size1 = new Size(48, 20);
            Size size36 = size1;
            nudStartYear3.Size = size36;
            NudStartYear.TabIndex = 6;
            NudStartYear.TextAlign = HorizontalAlignment.Right;
            Label label71 = Label7;
            point1 = new Point(24, 272);
            Point point38 = point1;
            label71.Location = point38;
            Label7.Name = "Label7";
            Label label72 = Label7;
            size1 = new Size(56, 16);
            Size size37 = size1;
            label72.Size = size37;
            Label7.TabIndex = 5;
            Label7.Text = "XP Scale";
            Label7.TextAlign = ContentAlignment.MiddleLeft;
            TabpagModuleEvents.Controls.Add(Label34);
            TabpagModuleEvents.Controls.Add(TbModOnClientEntr);
            TabpagModuleEvents.Controls.Add(Label33);
            TabpagModuleEvents.Controls.Add(TbModOnActvtItem);
            TabpagModuleEvents.Controls.Add(Label32);
            TabpagModuleEvents.Controls.Add(TbModOnAcquirItem);
            TabpagModuleEvents.Controls.Add(Label35);
            TabpagModuleEvents.Controls.Add(TbModOnClientLeav);
            TabpagModuleEvents.Controls.Add(TbModOnHeartbeat);
            TabpagModuleEvents.Controls.Add(Label36);
            TabpagModuleEvents.Controls.Add(Label37);
            TabpagModuleEvents.Controls.Add(TbModOnModLoad);
            TabpagModuleEvents.Controls.Add(TbModOnPlrDeath);
            TabpagModuleEvents.Controls.Add(Label38);
            TabpagModuleEvents.Controls.Add(TbModOnPlrDying);
            TabpagModuleEvents.Controls.Add(Label39);
            TabpagModuleEvents.Controls.Add(Label40);
            TabpagModuleEvents.Controls.Add(TbModOnPlrLvlUp);
            TabpagModuleEvents.Controls.Add(Label41);
            TabpagModuleEvents.Controls.Add(TbModOnSpawnBtnDn);
            TabpagModuleEvents.Controls.Add(TbModOnPlrRest);
            TabpagModuleEvents.Controls.Add(Label42);
            TabpagModuleEvents.Controls.Add(TbModOnUnAqreItem);
            TabpagModuleEvents.Controls.Add(Label43);
            TabpagModuleEvents.Controls.Add(Label44);
            TabpagModuleEvents.Controls.Add(TbModOnUsrDefined);
            TabPage tabpagModuleEvents1 = TabpagModuleEvents;
            point1 = new Point(4, 22);
            Point point39 = point1;
            ((Control) tabpagModuleEvents1).Location = point39;
            TabpagModuleEvents.Name = "tabpagModuleEvents";
            TabPage tabpagModuleEvents2 = TabpagModuleEvents;
            size1 = new Size(480, 444);
            Size size38 = size1;
            tabpagModuleEvents2.Size = size38;
            TabpagModuleEvents.TabIndex = 1;
            TabpagModuleEvents.Text = "Events";
            Label label341 = Label34;
            point1 = new Point(24, 88);
            Point point40 = point1;
            label341.Location = point40;
            Label34.Name = "Label34";
            Label label342 = Label34;
            size1 = new Size(100, 18);
            Size size39 = size1;
            label342.Size = size39;
            Label34.TabIndex = 28;
            Label34.Text = "OnClientEnter";
            Label34.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnClientEntr.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnClientEntr1 = TbModOnClientEntr;
            point1 = new Point(136, 88);
            Point point41 = point1;
            tbModOnClientEntr1.Location = point41;
            TbModOnClientEntr.MaxLength = 16;
            TbModOnClientEntr.Name = "tbMod_OnClientEntr";
            TextBox tbModOnClientEntr2 = TbModOnClientEntr;
            size1 = new Size(204, 20);
            Size size40 = size1;
            tbModOnClientEntr2.Size = size40;
            TbModOnClientEntr.TabIndex = 2;
            TbModOnClientEntr.Text = "";
            Label label331 = Label33;
            point1 = new Point(24, 64);
            Point point42 = point1;
            label331.Location = point42;
            Label33.Name = "Label33";
            Label label332 = Label33;
            size1 = new Size(100, 18);
            Size size41 = size1;
            label332.Size = size41;
            Label33.TabIndex = 18;
            Label33.Text = "OnActivateItem";
            Label33.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnActvtItem.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnActvtItem1 = TbModOnActvtItem;
            point1 = new Point(136, 64);
            Point point43 = point1;
            tbModOnActvtItem1.Location = point43;
            TbModOnActvtItem.MaxLength = 16;
            TbModOnActvtItem.Name = "tbMod_OnActvtItem";
            TextBox tbModOnActvtItem2 = TbModOnActvtItem;
            size1 = new Size(204, 20);
            Size size42 = size1;
            tbModOnActvtItem2.Size = size42;
            TbModOnActvtItem.TabIndex = 1;
            TbModOnActvtItem.Text = "";
            Label label321 = Label32;
            point1 = new Point(24, 40);
            Point point44 = point1;
            label321.Location = point44;
            Label32.Name = "Label32";
            Label label322 = Label32;
            size1 = new Size(100, 18);
            Size size43 = size1;
            label322.Size = size43;
            Label32.TabIndex = 15;
            Label32.Text = "OnAcquireItem";
            Label32.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnAcquirItem.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnAcquirItem1 = TbModOnAcquirItem;
            point1 = new Point(136, 40);
            Point point45 = point1;
            tbModOnAcquirItem1.Location = point45;
            TbModOnAcquirItem.MaxLength = 16;
            TbModOnAcquirItem.Name = "tbMod_OnAcquirItem";
            TextBox tbModOnAcquirItem2 = TbModOnAcquirItem;
            size1 = new Size(204, 20);
            Size size44 = size1;
            tbModOnAcquirItem2.Size = size44;
            TbModOnAcquirItem.TabIndex = 0;
            TbModOnAcquirItem.Text = "";
            Label label351 = Label35;
            point1 = new Point(24, 112);
            Point point46 = point1;
            label351.Location = point46;
            Label35.Name = "Label35";
            Label label352 = Label35;
            size1 = new Size(100, 18);
            Size size45 = size1;
            label352.Size = size45;
            Label35.TabIndex = 27;
            Label35.Text = "OnClientLeave";
            Label35.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnClientLeav.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnClientLeav1 = TbModOnClientLeav;
            point1 = new Point(136, 112);
            Point point47 = point1;
            tbModOnClientLeav1.Location = point47;
            TbModOnClientLeav.MaxLength = 16;
            TbModOnClientLeav.Name = "tbMod_OnClientLeav";
            TextBox tbModOnClientLeav2 = TbModOnClientLeav;
            size1 = new Size(204, 20);
            Size size46 = size1;
            tbModOnClientLeav2.Size = size46;
            TbModOnClientLeav.TabIndex = 3;
            TbModOnClientLeav.Text = "";
            TbModOnHeartbeat.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnHeartbeat1 = TbModOnHeartbeat;
            point1 = new Point(136, 136);
            Point point48 = point1;
            tbModOnHeartbeat1.Location = point48;
            TbModOnHeartbeat.MaxLength = 16;
            TbModOnHeartbeat.Name = "tbMod_OnHeartbeat";
            TextBox tbModOnHeartbeat2 = TbModOnHeartbeat;
            size1 = new Size(204, 20);
            Size size47 = size1;
            tbModOnHeartbeat2.Size = size47;
            TbModOnHeartbeat.TabIndex = 4;
            TbModOnHeartbeat.Text = "";
            Label label361 = Label36;
            point1 = new Point(24, 136);
            Point point49 = point1;
            label361.Location = point49;
            Label36.Name = "Label36";
            Label label362 = Label36;
            size1 = new Size(100, 18);
            Size size48 = size1;
            label362.Size = size48;
            Label36.TabIndex = 26;
            Label36.Text = "OnHeartbeat";
            Label36.TextAlign = ContentAlignment.MiddleLeft;
            Label label371 = Label37;
            point1 = new Point(24, 160);
            Point point50 = point1;
            label371.Location = point50;
            Label37.Name = "Label37";
            Label label372 = Label37;
            size1 = new Size(100, 18);
            Size size49 = size1;
            label372.Size = size49;
            Label37.TabIndex = 31;
            Label37.Text = "OnModuleLoad";
            Label37.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnModLoad.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnModLoad1 = TbModOnModLoad;
            point1 = new Point(136, 160);
            Point point51 = point1;
            tbModOnModLoad1.Location = point51;
            TbModOnModLoad.MaxLength = 16;
            TbModOnModLoad.Name = "tbMod_OnModLoad";
            TextBox tbModOnModLoad2 = TbModOnModLoad;
            size1 = new Size(204, 20);
            Size size50 = size1;
            tbModOnModLoad2.Size = size50;
            TbModOnModLoad.TabIndex = 5;
            TbModOnModLoad.Text = "";
            TbModOnPlrDeath.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnPlrDeath1 = TbModOnPlrDeath;
            point1 = new Point(136, 184);
            Point point52 = point1;
            tbModOnPlrDeath1.Location = point52;
            TbModOnPlrDeath.MaxLength = 16;
            TbModOnPlrDeath.Name = "tbMod_OnPlrDeath";
            TextBox tbModOnPlrDeath2 = TbModOnPlrDeath;
            size1 = new Size(204, 20);
            Size size51 = size1;
            tbModOnPlrDeath2.Size = size51;
            TbModOnPlrDeath.TabIndex = 6;
            TbModOnPlrDeath.Text = "";
            Label label381 = Label38;
            point1 = new Point(24, 184);
            Point point53 = point1;
            label381.Location = point53;
            Label38.Name = "Label38";
            Label label382 = Label38;
            size1 = new Size(100, 18);
            Size size52 = size1;
            label382.Size = size52;
            Label38.TabIndex = 21;
            Label38.Text = "OnPlayerDeath";
            Label38.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnPlrDying.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnPlrDying1 = TbModOnPlrDying;
            point1 = new Point(136, 208);
            Point point54 = point1;
            tbModOnPlrDying1.Location = point54;
            TbModOnPlrDying.MaxLength = 16;
            TbModOnPlrDying.Name = "tbMod_OnPlrDying";
            TextBox tbModOnPlrDying2 = TbModOnPlrDying;
            size1 = new Size(204, 20);
            Size size53 = size1;
            tbModOnPlrDying2.Size = size53;
            TbModOnPlrDying.TabIndex = 7;
            TbModOnPlrDying.Text = "";
            Label label391 = Label39;
            point1 = new Point(24, 208);
            Point point55 = point1;
            label391.Location = point55;
            Label39.Name = "Label39";
            Label label392 = Label39;
            size1 = new Size(100, 18);
            Size size54 = size1;
            label392.Size = size54;
            Label39.TabIndex = 20;
            Label39.Text = "OnPlayerDying";
            Label39.TextAlign = ContentAlignment.MiddleLeft;
            Label label401 = Label40;
            point1 = new Point(24, 232);
            Point point56 = point1;
            label401.Location = point56;
            Label40.Name = "Label40";
            Label label402 = Label40;
            size1 = new Size(100, 18);
            Size size55 = size1;
            label402.Size = size55;
            Label40.TabIndex = 25;
            Label40.Text = "OnPlayerLevelUp";
            Label40.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnPlrLvlUp.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnPlrLvlUp1 = TbModOnPlrLvlUp;
            point1 = new Point(136, 232);
            Point point57 = point1;
            tbModOnPlrLvlUp1.Location = point57;
            TbModOnPlrLvlUp.MaxLength = 16;
            TbModOnPlrLvlUp.Name = "tbMod_OnPlrLvlUp";
            TextBox tbModOnPlrLvlUp2 = TbModOnPlrLvlUp;
            size1 = new Size(204, 20);
            Size size56 = size1;
            tbModOnPlrLvlUp2.Size = size56;
            TbModOnPlrLvlUp.TabIndex = 8;
            TbModOnPlrLvlUp.Text = "";
            Label label411 = Label41;
            point1 = new Point(24, 256);
            Point point58 = point1;
            label411.Location = point58;
            Label41.Name = "Label41";
            Label label412 = Label41;
            size1 = new Size(100, 18);
            Size size57 = size1;
            label412.Size = size57;
            Label41.TabIndex = 23;
            Label41.Text = "OnPlayerRespawn";
            Label41.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnSpawnBtnDn.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnSpawnBtnDn1 = TbModOnSpawnBtnDn;
            point1 = new Point(136, 256);
            Point point59 = point1;
            tbModOnSpawnBtnDn1.Location = point59;
            TbModOnSpawnBtnDn.MaxLength = 16;
            TbModOnSpawnBtnDn.Name = "tbMod_OnSpawnBtnDn";
            TextBox tbModOnSpawnBtnDn2 = TbModOnSpawnBtnDn;
            size1 = new Size(204, 20);
            Size size58 = size1;
            tbModOnSpawnBtnDn2.Size = size58;
            TbModOnSpawnBtnDn.TabIndex = 9;
            TbModOnSpawnBtnDn.Text = "";
            TbModOnPlrRest.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnPlrRest1 = TbModOnPlrRest;
            point1 = new Point(136, 280);
            Point point60 = point1;
            tbModOnPlrRest1.Location = point60;
            TbModOnPlrRest.MaxLength = 16;
            TbModOnPlrRest.Name = "tbMod_OnPlrRest";
            TextBox tbModOnPlrRest2 = TbModOnPlrRest;
            size1 = new Size(204, 20);
            Size size59 = size1;
            tbModOnPlrRest2.Size = size59;
            TbModOnPlrRest.TabIndex = 10;
            TbModOnPlrRest.Text = "";
            Label label421 = Label42;
            point1 = new Point(24, 280);
            Point point61 = point1;
            label421.Location = point61;
            Label42.Name = "Label42";
            Label label422 = Label42;
            size1 = new Size(100, 18);
            Size size60 = size1;
            label422.Size = size60;
            Label42.TabIndex = 24;
            Label42.Text = "OnPlayerRest";
            Label42.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnUnAqreItem.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnUnAqreItem1 = TbModOnUnAqreItem;
            point1 = new Point(136, 304);
            Point point62 = point1;
            tbModOnUnAqreItem1.Location = point62;
            TbModOnUnAqreItem.MaxLength = 16;
            TbModOnUnAqreItem.Name = "tbMod_OnUnAqreItem";
            TextBox tbModOnUnAqreItem2 = TbModOnUnAqreItem;
            size1 = new Size(204, 20);
            Size size61 = size1;
            tbModOnUnAqreItem2.Size = size61;
            TbModOnUnAqreItem.TabIndex = 11;
            TbModOnUnAqreItem.Text = "";
            Label label431 = Label43;
            point1 = new Point(24, 304);
            Point point63 = point1;
            label431.Location = point63;
            Label43.Name = "Label43";
            Label label432 = Label43;
            size1 = new Size(100, 18);
            Size size62 = size1;
            label432.Size = size62;
            Label43.TabIndex = 22;
            Label43.Text = "OnUnacquireItem";
            Label43.TextAlign = ContentAlignment.MiddleLeft;
            Label label441 = Label44;
            point1 = new Point(24, 328);
            Point point64 = point1;
            label441.Location = point64;
            Label44.Name = "Label44";
            Label label442 = Label44;
            size1 = new Size(100, 18);
            Size size63 = size1;
            label442.Size = size63;
            Label44.TabIndex = 29;
            Label44.Text = "OnUserDefined";
            Label44.TextAlign = ContentAlignment.MiddleLeft;
            TbModOnUsrDefined.CharacterCasing = CharacterCasing.Lower;
            TextBox tbModOnUsrDefined1 = TbModOnUsrDefined;
            point1 = new Point(136, 328);
            Point point65 = point1;
            tbModOnUsrDefined1.Location = point65;
            TbModOnUsrDefined.MaxLength = 16;
            TbModOnUsrDefined.Name = "tbMod_OnUsrDefined";
            TextBox tbModOnUsrDefined2 = TbModOnUsrDefined;
            size1 = new Size(204, 20);
            Size size64 = size1;
            tbModOnUsrDefined2.Size = size64;
            TbModOnUsrDefined.TabIndex = 12;
            TbModOnUsrDefined.Text = "";
            TabpagModuleDescription.Controls.Add(BtnSetDescriptionLang);
            TabpagModuleDescription.Controls.Add(TbModDescription);
            TabPage moduleDescription1 = TabpagModuleDescription;
            point1 = new Point(4, 22);
            Point point66 = point1;
            ((Control) moduleDescription1).Location = point66;
            TabpagModuleDescription.Name = "tabpagModuleDescription";
            TabPage moduleDescription2 = TabpagModuleDescription;
            size1 = new Size(480, 444);
            Size size65 = size1;
            moduleDescription2.Size = size65;
            TabpagModuleDescription.TabIndex = 3;
            TabpagModuleDescription.Text = "Description";
            BtnSetDescriptionLang.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Button setDescriptionLang1 = BtnSetDescriptionLang;
            point1 = new Point(368, 414);
            Point point67 = point1;
            setDescriptionLang1.Location = point67;
            BtnSetDescriptionLang.Name = "btnSetDescriptionLang";
            Button setDescriptionLang2 = BtnSetDescriptionLang;
            size1 = new Size(88, 23);
            Size size66 = size1;
            setDescriptionLang2.Size = size66;
            BtnSetDescriptionLang.TabIndex = 1;
            BtnSetDescriptionLang.Text = "Set Language";
            TbModDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbModDescription1 = TbModDescription;
            point1 = new Point(16, 8);
            Point point68 = point1;
            tbModDescription1.Location = point68;
            TbModDescription.Multiline = true;
            TbModDescription.Name = "tbModDescription";
            TextBox tbModDescription2 = TbModDescription;
            size1 = new Size(448, 391);
            Size size67 = size1;
            tbModDescription2.Size = size67;
            TbModDescription.TabIndex = 0;
            TbModDescription.Text = "";
            TabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControlMain.Controls.Add(TabPage5);
            TabControlMain.Controls.Add(TabPage6);
            TabControl tabControlMain1 = TabControlMain;
            point1 = new Point(16, 24);
            Point point69 = point1;
            tabControlMain1.Location = point69;
            TabControlMain.Name = "TabControlMain";
            TabControl tabControlMain2 = TabControlMain;
            point1 = new Point(12, 3);
            Point point70 = point1;
            tabControlMain2.Padding = point70;
            TabControlMain.SelectedIndex = 0;
            TabControl tabControlMain3 = TabControlMain;
            size1 = new Size(496, 496);
            Size size68 = size1;
            tabControlMain3.Size = size68;
            TabControlMain.TabIndex = 1;
            TabPage5.Controls.Add(TabControlModule);
            TabPage tabPage51 = TabPage5;
            point1 = new Point(4, 22);
            Point point71 = point1;
            ((Control) tabPage51).Location = point71;
            TabPage5.Name = "TabPage5";
            TabPage tabPage52 = TabPage5;
            size1 = new Size(488, 470);
            Size size69 = size1;
            tabPage52.Size = size69;
            TabPage5.TabIndex = 0;
            TabPage5.Text = "Module";
            TabPage6.Controls.Add(TabControlArea);
            TabPage tabPage61 = TabPage6;
            point1 = new Point(4, 22);
            Point point72 = point1;
            ((Control) tabPage61).Location = point72;
            TabPage6.Name = "TabPage6";
            TabPage tabPage62 = TabPage6;
            size1 = new Size(488, 470);
            Size size70 = size1;
            tabPage62.Size = size70;
            TabPage6.TabIndex = 1;
            TabPage6.Text = "Area";
            TabControlArea.Controls.Add(TabpagAreaBasic);
            TabControlArea.Controls.Add(TabpagAreaEnvironment);
            TabControlArea.Controls.Add(TabpagAreaGrass);
            TabControlArea.Controls.Add(TabpagAreaAudio);
            TabControlArea.Controls.Add(TabpagAreaEvents);
            TabControlArea.Controls.Add(TabpagAreaRooms);
            TabControlArea.Dock = DockStyle.Fill;
            TabControl tabControlArea1 = TabControlArea;
            point1 = new Point(0, 0);
            Point point73 = point1;
            tabControlArea1.Location = point73;
            TabControlArea.Name = "TabControlArea";
            TabControl tabControlArea2 = TabControlArea;
            point1 = new Point(12, 3);
            Point point74 = point1;
            tabControlArea2.Padding = point74;
            TabControlArea.SelectedIndex = 0;
            TabControl tabControlArea3 = TabControlArea;
            size1 = new Size(488, 470);
            Size size71 = size1;
            tabControlArea3.Size = size71;
            TabControlArea.TabIndex = 0;
            TabpagAreaBasic.Controls.Add(ChkbUnescapable);
            TabpagAreaBasic.Controls.Add(Label19);
            TabpagAreaBasic.Controls.Add(CmbxCameraStyle);
            TabpagAreaBasic.Controls.Add(Label14);
            TabpagAreaBasic.Controls.Add(NumericUpDown10);
            TabpagAreaBasic.Controls.Add(Label15);
            TabpagAreaBasic.Controls.Add(NumericUpDown11);
            TabpagAreaBasic.Controls.Add(Label16);
            TabpagAreaBasic.Controls.Add(NumericUpDown12);
            TabpagAreaBasic.Controls.Add(BtnSetAreaNameLang);
            TabpagAreaBasic.Controls.Add(TbAreaTag);
            TabpagAreaBasic.Controls.Add(TbAreaName);
            TabpagAreaBasic.Controls.Add(Label17);
            TabpagAreaBasic.Controls.Add(Label18);
            TabpagAreaBasic.Controls.Add(Label85);
            TabpagAreaBasic.Controls.Add(ChkbDisableTransit);
            TabpagAreaBasic.Controls.Add(Label86);
            TabPage tabpagAreaBasic1 = TabpagAreaBasic;
            point1 = new Point(4, 22);
            Point point75 = point1;
            ((Control) tabpagAreaBasic1).Location = point75;
            TabpagAreaBasic.Name = "tabpagAreaBasic";
            TabPage tabpagAreaBasic2 = TabpagAreaBasic;
            size1 = new Size(480, 444);
            Size size72 = size1;
            tabpagAreaBasic2.Size = size72;
            TabpagAreaBasic.TabIndex = 1;
            TabpagAreaBasic.Text = "Basic";
            CheckBox chkbUnescapable1 = ChkbUnescapable;
            point1 = new Point(112, 144);
            Point point76 = point1;
            chkbUnescapable1.Location = point76;
            ChkbUnescapable.Name = "chkbUnescapable";
            CheckBox chkbUnescapable2 = ChkbUnescapable;
            size1 = new Size(32, 24);
            Size size73 = size1;
            chkbUnescapable2.Size = size73;
            ChkbUnescapable.TabIndex = 23;
            Label label191 = Label19;
            point1 = new Point(16, 104);
            Point point77 = point1;
            label191.Location = point77;
            Label19.Name = "Label19";
            Label label192 = Label19;
            size1 = new Size(88, 16);
            Size size74 = size1;
            label192.Size = size74;
            Label19.TabIndex = 22;
            Label19.Text = "Camera Style";
            Label19.TextAlign = ContentAlignment.MiddleLeft;
            CmbxCameraStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxCameraStyle1 = CmbxCameraStyle;
            point1 = new Point(112, 104);
            Point point78 = point1;
            cmbxCameraStyle1.Location = point78;
            CmbxCameraStyle.Name = "cmbxCameraStyle";
            ComboBox cmbxCameraStyle2 = CmbxCameraStyle;
            size1 = new Size(120, 21);
            Size size75 = size1;
            cmbxCameraStyle2.Size = size75;
            CmbxCameraStyle.TabIndex = 21;
            Label14.BackColor = Color.Red;
            Label label141 = Label14;
            point1 = new Point(88, 328);
            Point point79 = point1;
            label141.Location = point79;
            Label14.Name = "Label14";
            Label label142 = Label14;
            size1 = new Size(104, 16);
            Size size76 = size1;
            label142.Size = size76;
            Label14.TabIndex = 19;
            Label14.Text = "Starting Position X";
            Label14.TextAlign = ContentAlignment.MiddleRight;
            Label14.Visible = false;
            NumericUpDown10.BackColor = Color.Red;
            NumericUpDown10.DecimalPlaces = 4;
            NumericUpDown numericUpDown101 = NumericUpDown10;
            point1 = new Point(208, 328);
            Point point80 = point1;
            numericUpDown101.Location = point80;
            NumericUpDown numericUpDown102 = NumericUpDown10;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num23 = num1;
            numericUpDown102.Maximum = num23;
            NumericUpDown numericUpDown103 = NumericUpDown10;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            Decimal num24 = num1;
            numericUpDown103.Minimum = num24;
            NumericUpDown10.Name = "NumericUpDown10";
            NumericUpDown numericUpDown104 = NumericUpDown10;
            size1 = new Size(96, 20);
            Size size77 = size1;
            numericUpDown104.Size = size77;
            NumericUpDown10.TabIndex = 16;
            NumericUpDown10.TextAlign = HorizontalAlignment.Right;
            NumericUpDown10.Visible = false;
            Label15.BackColor = Color.Red;
            Label label151 = Label15;
            point1 = new Point(88, 360);
            Point point81 = point1;
            label151.Location = point81;
            Label15.Name = "Label15";
            Label label152 = Label15;
            size1 = new Size(104, 16);
            Size size78 = size1;
            label152.Size = size78;
            Label15.TabIndex = 20;
            Label15.Text = "Starting Position Y";
            Label15.TextAlign = ContentAlignment.MiddleRight;
            Label15.Visible = false;
            NumericUpDown11.BackColor = Color.Red;
            NumericUpDown11.DecimalPlaces = 4;
            NumericUpDown numericUpDown111 = NumericUpDown11;
            point1 = new Point(208, 360);
            Point point82 = point1;
            numericUpDown111.Location = point82;
            NumericUpDown numericUpDown112 = NumericUpDown11;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num25 = num1;
            numericUpDown112.Maximum = num25;
            NumericUpDown numericUpDown113 = NumericUpDown11;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            Decimal num26 = num1;
            numericUpDown113.Minimum = num26;
            NumericUpDown11.Name = "NumericUpDown11";
            NumericUpDown numericUpDown114 = NumericUpDown11;
            size1 = new Size(96, 20);
            Size size79 = size1;
            numericUpDown114.Size = size79;
            NumericUpDown11.TabIndex = 15;
            NumericUpDown11.TextAlign = HorizontalAlignment.Right;
            NumericUpDown11.Visible = false;
            Label16.BackColor = Color.Red;
            Label label161 = Label16;
            point1 = new Point(88, 392);
            Point point83 = point1;
            label161.Location = point83;
            Label16.Name = "Label16";
            Label label162 = Label16;
            size1 = new Size(104, 16);
            Size size80 = size1;
            label162.Size = size80;
            Label16.TabIndex = 18;
            Label16.Text = "Starting Position Z";
            Label16.TextAlign = ContentAlignment.MiddleRight;
            Label16.Visible = false;
            NumericUpDown12.BackColor = Color.Red;
            NumericUpDown12.DecimalPlaces = 4;
            NumericUpDown numericUpDown121 = NumericUpDown12;
            point1 = new Point(208, 392);
            Point point84 = point1;
            numericUpDown121.Location = point84;
            NumericUpDown numericUpDown122 = NumericUpDown12;
            num1 = new Decimal(new int[4] {4000, 0, 0, 0});
            Decimal num27 = num1;
            numericUpDown122.Maximum = num27;
            NumericUpDown numericUpDown123 = NumericUpDown12;
            num1 = new Decimal(new int[4]
            {
                4000,
                0,
                0,
                int.MinValue
            });
            Decimal num28 = num1;
            numericUpDown123.Minimum = num28;
            NumericUpDown12.Name = "NumericUpDown12";
            NumericUpDown numericUpDown124 = NumericUpDown12;
            size1 = new Size(96, 20);
            Size size81 = size1;
            numericUpDown124.Size = size81;
            NumericUpDown12.TabIndex = 17;
            NumericUpDown12.TextAlign = HorizontalAlignment.Right;
            NumericUpDown12.Visible = false;
            Button btnSetAreaNameLang1 = BtnSetAreaNameLang;
            point1 = new Point(376, 40);
            Point point85 = point1;
            btnSetAreaNameLang1.Location = point85;
            BtnSetAreaNameLang.Name = "btnSetAreaNameLang";
            Button btnSetAreaNameLang2 = BtnSetAreaNameLang;
            size1 = new Size(88, 23);
            Size size82 = size1;
            btnSetAreaNameLang2.Size = size82;
            BtnSetAreaNameLang.TabIndex = 1;
            BtnSetAreaNameLang.Text = "Set Language";
            TextBox tbAreaTag1 = TbAreaTag;
            point1 = new Point(112, 64);
            Point point86 = point1;
            tbAreaTag1.Location = point86;
            TbAreaTag.Name = "tbAreaTag";
            TextBox tbAreaTag2 = TbAreaTag;
            size1 = new Size(104, 20);
            Size size83 = size1;
            tbAreaTag2.Size = size83;
            TbAreaTag.TabIndex = 2;
            TbAreaTag.Text = "";
            TextBox tbAreaName1 = TbAreaName;
            point1 = new Point(112, 40);
            Point point87 = point1;
            tbAreaName1.Location = point87;
            TbAreaName.Name = "tbAreaName";
            TextBox tbAreaName2 = TbAreaName;
            size1 = new Size(256, 20);
            Size size84 = size1;
            tbAreaName2.Size = size84;
            TbAreaName.TabIndex = 0;
            TbAreaName.Text = "";
            Label label171 = Label17;
            point1 = new Point(24, 40);
            Point point88 = point1;
            label171.Location = point88;
            Label17.Name = "Label17";
            Label label172 = Label17;
            size1 = new Size(48, 16);
            Size size85 = size1;
            label172.Size = size85;
            Label17.TabIndex = 10;
            Label17.Text = "Name";
            Label17.TextAlign = ContentAlignment.MiddleLeft;
            Label label181 = Label18;
            point1 = new Point(24, 64);
            Point point89 = point1;
            label181.Location = point89;
            Label18.Name = "Label18";
            Label label182 = Label18;
            size1 = new Size(48, 16);
            Size size86 = size1;
            label182.Size = size86;
            Label18.TabIndex = 11;
            Label18.Text = "Tag";
            Label18.TextAlign = ContentAlignment.MiddleLeft;
            Label label851 = Label85;
            point1 = new Point(16, 148);
            Point point90 = point1;
            label851.Location = point90;
            Label85.Name = "Label85";
            Label label852 = Label85;
            size1 = new Size(88, 16);
            Size size87 = size1;
            label852.Size = size87;
            Label85.TabIndex = 22;
            Label85.Text = "Unescapable";
            Label85.TextAlign = ContentAlignment.MiddleLeft;
            CheckBox chkbDisableTransit1 = ChkbDisableTransit;
            point1 = new Point(112, 176);
            Point point91 = point1;
            chkbDisableTransit1.Location = point91;
            ChkbDisableTransit.Name = "chkbDisableTransit";
            CheckBox chkbDisableTransit2 = ChkbDisableTransit;
            size1 = new Size(32, 24);
            Size size88 = size1;
            chkbDisableTransit2.Size = size88;
            ChkbDisableTransit.TabIndex = 23;
            Label label861 = Label86;
            point1 = new Point(16, 180);
            Point point92 = point1;
            label861.Location = point92;
            Label86.Name = "Label86";
            Label label862 = Label86;
            size1 = new Size(88, 16);
            Size size89 = size1;
            label862.Size = size89;
            Label86.TabIndex = 22;
            Label86.Text = "Disable Transit";
            Label86.TextAlign = ContentAlignment.MiddleLeft;
            TabpagAreaEnvironment.Controls.Add(CmbxWindPower);
            TabpagAreaEnvironment.Controls.Add(GroupBox1);
            TabpagAreaEnvironment.Controls.Add(RbDayNightCycle);
            TabpagAreaEnvironment.Controls.Add(GbMoon);
            TabpagAreaEnvironment.Controls.Add(GbSun);
            TabpagAreaEnvironment.Controls.Add(RbAlwaysDay);
            TabpagAreaEnvironment.Controls.Add(RbAlwaysNight);
            TabpagAreaEnvironment.Controls.Add(BtnDynAmbientColor);
            TabpagAreaEnvironment.Controls.Add(Label48);
            TabpagAreaEnvironment.Controls.Add(Label73);
            TabpagAreaEnvironment.Controls.Add(NudShadowOpacity);
            TabpagAreaEnvironment.Controls.Add(Label84);
            TabPage tabpagAreaEnvironment1 = TabpagAreaEnvironment;
            point1 = new Point(4, 22);
            Point point93 = point1;
            ((Control) tabpagAreaEnvironment1).Location = point93;
            TabpagAreaEnvironment.Name = "tabpagAreaEnvironment";
            TabPage tabpagAreaEnvironment2 = TabpagAreaEnvironment;
            size1 = new Size(480, 444);
            Size size90 = size1;
            tabpagAreaEnvironment2.Size = size90;
            TabpagAreaEnvironment.TabIndex = 4;
            TabpagAreaEnvironment.Text = "Environment";
            CmbxWindPower.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbxWindPower.Items.AddRange(new object[3]
            {
                "Calm",
                "Light",
                "Heavy"
            });
            ComboBox cmbxWindPower1 = CmbxWindPower;
            point1 = new Point(328, 358);
            Point point94 = point1;
            cmbxWindPower1.Location = point94;
            CmbxWindPower.Name = "cmbxWindPower";
            ComboBox cmbxWindPower2 = CmbxWindPower;
            size1 = new Size(112, 21);
            Size size91 = size1;
            cmbxWindPower2.Size = size91;
            CmbxWindPower.TabIndex = 26;
            GroupBox1.Controls.Add(Label49);
            GroupBox1.Controls.Add(NudChanceSnow);
            GroupBox1.Controls.Add(Label50);
            GroupBox1.Controls.Add(NudChanceRain);
            GroupBox1.Controls.Add(Label51);
            GroupBox1.Controls.Add(NudChanceLightning);
            GroupBox groupBox11 = GroupBox1;
            point1 = new Point(16, 344);
            Point point95 = point1;
            groupBox11.Location = point95;
            GroupBox1.Name = "GroupBox1";
            GroupBox groupBox12 = GroupBox1;
            size1 = new Size(200, 88);
            Size size92 = size1;
            groupBox12.Size = size92;
            GroupBox1.TabIndex = 25;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Weather";
            Label label491 = Label49;
            point1 = new Point(8, 16);
            Point point96 = point1;
            label491.Location = point96;
            Label49.Name = "Label49";
            Label label492 = Label49;
            size1 = new Size(88, 16);
            Size size93 = size1;
            label492.Size = size93;
            Label49.TabIndex = 24;
            Label49.Text = "% Chance Snow";
            Label49.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudChanceSnow1 = NudChanceSnow;
            point1 = new Point(128, 16);
            Point point97 = point1;
            nudChanceSnow1.Location = point97;
            NudChanceSnow.Name = "nudChanceSnow";
            NumericUpDown nudChanceSnow2 = NudChanceSnow;
            size1 = new Size(56, 20);
            Size size94 = size1;
            nudChanceSnow2.Size = size94;
            NudChanceSnow.TabIndex = 0;
            NudChanceSnow.TextAlign = HorizontalAlignment.Right;
            Label label501 = Label50;
            point1 = new Point(8, 40);
            Point point98 = point1;
            label501.Location = point98;
            Label50.Name = "Label50";
            Label label502 = Label50;
            size1 = new Size(88, 16);
            Size size95 = size1;
            label502.Size = size95;
            Label50.TabIndex = 24;
            Label50.Text = "% Chance Rain";
            Label50.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudChanceRain1 = NudChanceRain;
            point1 = new Point(128, 40);
            Point point99 = point1;
            nudChanceRain1.Location = point99;
            NudChanceRain.Name = "nudChanceRain";
            NumericUpDown nudChanceRain2 = NudChanceRain;
            size1 = new Size(56, 20);
            Size size96 = size1;
            nudChanceRain2.Size = size96;
            NudChanceRain.TabIndex = 1;
            NudChanceRain.TextAlign = HorizontalAlignment.Right;
            Label label511 = Label51;
            point1 = new Point(8, 64);
            Point point100 = point1;
            label511.Location = point100;
            Label51.Name = "Label51";
            Label label512 = Label51;
            size1 = new Size(120, 16);
            Size size97 = size1;
            label512.Size = size97;
            Label51.TabIndex = 24;
            Label51.Text = "% Chance Lightning";
            Label51.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudChanceLightning1 = NudChanceLightning;
            point1 = new Point(128, 64);
            Point point101 = point1;
            nudChanceLightning1.Location = point101;
            NudChanceLightning.Name = "nudChanceLightning";
            NumericUpDown nudChanceLightning2 = NudChanceLightning;
            size1 = new Size(56, 20);
            Size size98 = size1;
            nudChanceLightning2.Size = size98;
            NudChanceLightning.TabIndex = 2;
            NudChanceLightning.TextAlign = HorizontalAlignment.Right;
            RbDayNightCycle.Checked = true;
            RadioButton rbDayNightCycle1 = RbDayNightCycle;
            point1 = new Point(40, 8);
            Point point102 = point1;
            rbDayNightCycle1.Location = point102;
            RbDayNightCycle.Name = "rbDayNightCycle";
            RadioButton rbDayNightCycle2 = RbDayNightCycle;
            size1 = new Size(152, 16);
            Size size99 = size1;
            rbDayNightCycle2.Size = size99;
            RbDayNightCycle.TabIndex = 0;
            RbDayNightCycle.TabStop = true;
            RbDayNightCycle.Text = "Cycle Day and Night";
            GbMoon.Controls.Add(BtnMoonDiffuseColor);
            GbMoon.Controls.Add(Label24);
            GbMoon.Controls.Add(Label25);
            GbMoon.Controls.Add(BtnMoonAmbientColor);
            GbMoon.Controls.Add(Label31);
            GbMoon.Controls.Add(Label45);
            GbMoon.Controls.Add(BtnMoonFogColor);
            GbMoon.Controls.Add(ChkbAreaMoonShadows);
            GbMoon.Controls.Add(Label47);
            GbMoon.Controls.Add(ChkbMoonFogOn);
            GbMoon.Controls.Add(TrkbarMoonFogNear);
            GbMoon.Controls.Add(LblMoonFogNear);
            GbMoon.Controls.Add(TrkbarMoonFogFar);
            GbMoon.Controls.Add(LblMoonFogFar);
            GroupBox gbMoon1 = GbMoon;
            point1 = new Point(16, 200);
            Point point103 = point1;
            gbMoon1.Location = point103;
            GbMoon.Name = "gbMoon";
            GroupBox gbMoon2 = GbMoon;
            size1 = new Size(448, 136);
            Size size100 = size1;
            gbMoon2.Size = size100;
            GbMoon.TabIndex = 21;
            GbMoon.TabStop = false;
            GbMoon.Text = "Moon";
            BtnMoonDiffuseColor.FlatStyle = FlatStyle.Flat;
            Button moonDiffuseColor1 = BtnMoonDiffuseColor;
            point1 = new Point(112, 40);
            Point point104 = point1;
            moonDiffuseColor1.Location = point104;
            BtnMoonDiffuseColor.Name = "btnMoonDiffuseColor";
            Button moonDiffuseColor2 = BtnMoonDiffuseColor;
            size1 = new Size(16, 16);
            Size size101 = size1;
            moonDiffuseColor2.Size = size101;
            BtnMoonDiffuseColor.TabIndex = 1;
            Label label241 = Label24;
            point1 = new Point(16, 16);
            Point point105 = point1;
            label241.Location = point105;
            Label24.Name = "Label24";
            Label label242 = Label24;
            size1 = new Size(88, 16);
            Size size102 = size1;
            label242.Size = size102;
            Label24.TabIndex = 21;
            Label24.Text = "Ambient Color";
            Label24.TextAlign = ContentAlignment.MiddleLeft;
            Label label251 = Label25;
            point1 = new Point(16, 40);
            Point point106 = point1;
            label251.Location = point106;
            Label25.Name = "Label25";
            Label label252 = Label25;
            size1 = new Size(88, 16);
            Size size103 = size1;
            label252.Size = size103;
            Label25.TabIndex = 20;
            Label25.Text = "Diffuse Color";
            Label25.TextAlign = ContentAlignment.MiddleLeft;
            BtnMoonAmbientColor.FlatStyle = FlatStyle.Flat;
            Button moonAmbientColor1 = BtnMoonAmbientColor;
            point1 = new Point(112, 16);
            Point point107 = point1;
            moonAmbientColor1.Location = point107;
            BtnMoonAmbientColor.Name = "btnMoonAmbientColor";
            Button moonAmbientColor2 = BtnMoonAmbientColor;
            size1 = new Size(16, 16);
            Size size104 = size1;
            moonAmbientColor2.Size = size104;
            BtnMoonAmbientColor.TabIndex = 0;
            Label label311 = Label31;
            point1 = new Point(16, 112);
            Point point108 = point1;
            label311.Location = point108;
            Label31.Name = "Label31";
            Label label312 = Label31;
            size1 = new Size(88, 16);
            Size size105 = size1;
            label312.Size = size105;
            Label31.TabIndex = 16;
            Label31.Text = "Shadows";
            Label31.TextAlign = ContentAlignment.MiddleLeft;
            Label label451 = Label45;
            point1 = new Point(16, 88);
            Point point109 = point1;
            label451.Location = point109;
            Label45.Name = "Label45";
            Label label452 = Label45;
            size1 = new Size(88, 16);
            Size size106 = size1;
            label452.Size = size106;
            Label45.TabIndex = 16;
            Label45.Text = "Fog Color";
            Label45.TextAlign = ContentAlignment.MiddleLeft;
            BtnMoonFogColor.FlatStyle = FlatStyle.Flat;
            Button btnMoonFogColor1 = BtnMoonFogColor;
            point1 = new Point(112, 88);
            Point point110 = point1;
            btnMoonFogColor1.Location = point110;
            BtnMoonFogColor.Name = "btnMoonFogColor";
            Button btnMoonFogColor2 = BtnMoonFogColor;
            size1 = new Size(16, 16);
            Size size107 = size1;
            btnMoonFogColor2.Size = size107;
            BtnMoonFogColor.TabIndex = 3;
            CheckBox chkbAreaMoonShadows1 = ChkbAreaMoonShadows;
            point1 = new Point(112, 112);
            Point point111 = point1;
            chkbAreaMoonShadows1.Location = point111;
            ChkbAreaMoonShadows.Name = "chkbAreaMoonShadows";
            CheckBox chkbAreaMoonShadows2 = ChkbAreaMoonShadows;
            size1 = new Size(32, 16);
            Size size108 = size1;
            chkbAreaMoonShadows2.Size = size108;
            ChkbAreaMoonShadows.TabIndex = 4;
            Label label471 = Label47;
            point1 = new Point(16, 64);
            Point point112 = point1;
            label471.Location = point112;
            Label47.Name = "Label47";
            Label label472 = Label47;
            size1 = new Size(88, 16);
            Size size109 = size1;
            label472.Size = size109;
            Label47.TabIndex = 16;
            Label47.Text = "Fog Enabled";
            Label47.TextAlign = ContentAlignment.MiddleLeft;
            CheckBox chkbMoonFogOn1 = ChkbMoonFogOn;
            point1 = new Point(112, 64);
            Point point113 = point1;
            chkbMoonFogOn1.Location = point113;
            ChkbMoonFogOn.Name = "chkbMoonFogOn";
            CheckBox chkbMoonFogOn2 = ChkbMoonFogOn;
            size1 = new Size(32, 16);
            Size size110 = size1;
            chkbMoonFogOn2.Size = size110;
            ChkbMoonFogOn.TabIndex = 2;
            TrkbarMoonFogNear.Enabled = false;
            TrackBar trkbarMoonFogNear1 = TrkbarMoonFogNear;
            point1 = new Point(232, 24);
            Point point114 = point1;
            trkbarMoonFogNear1.Location = point114;
            TrkbarMoonFogNear.Maximum = 2000;
            TrkbarMoonFogNear.Name = "trkbarMoonFogNear";
            TrackBar trkbarMoonFogNear2 = TrkbarMoonFogNear;
            size1 = new Size(200, 42);
            Size size111 = size1;
            trkbarMoonFogNear2.Size = size111;
            TrkbarMoonFogNear.TabIndex = 5;
            TrkbarMoonFogNear.TickFrequency = 50;
            TrkbarMoonFogNear.TickStyle = TickStyle.TopLeft;
            LblMoonFogNear.Enabled = false;
            Label lblMoonFogNear1 = LblMoonFogNear;
            point1 = new Point(160, 32);
            Point point115 = point1;
            lblMoonFogNear1.Location = point115;
            LblMoonFogNear.Name = "lblMoonFogNear";
            Label lblMoonFogNear2 = LblMoonFogNear;
            size1 = new Size(64, 16);
            Size size112 = size1;
            lblMoonFogNear2.Size = size112;
            LblMoonFogNear.TabIndex = 16;
            LblMoonFogNear.Text = "Fog Near";
            LblMoonFogNear.TextAlign = ContentAlignment.MiddleLeft;
            TrkbarMoonFogFar.Enabled = false;
            TrackBar trkbarMoonFogFar1 = TrkbarMoonFogFar;
            point1 = new Point(232, 88);
            Point point116 = point1;
            trkbarMoonFogFar1.Location = point116;
            TrkbarMoonFogFar.Maximum = 2000;
            TrkbarMoonFogFar.Name = "trkbarMoonFogFar";
            TrackBar trkbarMoonFogFar2 = TrkbarMoonFogFar;
            size1 = new Size(200, 42);
            Size size113 = size1;
            trkbarMoonFogFar2.Size = size113;
            TrkbarMoonFogFar.TabIndex = 6;
            TrkbarMoonFogFar.TickFrequency = 50;
            TrkbarMoonFogFar.TickStyle = TickStyle.TopLeft;
            LblMoonFogFar.Enabled = false;
            Label lblMoonFogFar1 = LblMoonFogFar;
            point1 = new Point(160, 88);
            Point point117 = point1;
            lblMoonFogFar1.Location = point117;
            LblMoonFogFar.Name = "lblMoonFogFar";
            Label lblMoonFogFar2 = LblMoonFogFar;
            size1 = new Size(64, 16);
            Size size114 = size1;
            lblMoonFogFar2.Size = size114;
            LblMoonFogFar.TabIndex = 16;
            LblMoonFogFar.Text = "Fog Far";
            LblMoonFogFar.TextAlign = ContentAlignment.MiddleLeft;
            GbSun.Controls.Add(ChkbAreaSunShadows);
            GbSun.Controls.Add(TrkbarSunFogNear);
            GbSun.Controls.Add(Label27);
            GbSun.Controls.Add(BtnSunAmbientColor);
            GbSun.Controls.Add(Label26);
            GbSun.Controls.Add(BtnSunDiffuseColor);
            GbSun.Controls.Add(Label28);
            GbSun.Controls.Add(BtnSunFogColor);
            GbSun.Controls.Add(Label29);
            GbSun.Controls.Add(Label30);
            GbSun.Controls.Add(TrkbarSunFogFar);
            GbSun.Controls.Add(LblSunFogNear);
            GbSun.Controls.Add(LblSunFogFar);
            GbSun.Controls.Add(ChkbSunFogOn);
            GroupBox gbSun1 = GbSun;
            point1 = new Point(16, 56);
            Point point118 = point1;
            gbSun1.Location = point118;
            GbSun.Name = "gbSun";
            GroupBox gbSun2 = GbSun;
            size1 = new Size(448, 136);
            Size size115 = size1;
            gbSun2.Size = size115;
            GbSun.TabIndex = 20;
            GbSun.TabStop = false;
            GbSun.Text = "Sun";
            CheckBox chkbAreaSunShadows1 = ChkbAreaSunShadows;
            point1 = new Point(112, 112);
            Point point119 = point1;
            chkbAreaSunShadows1.Location = point119;
            ChkbAreaSunShadows.Name = "chkbAreaSunShadows";
            CheckBox chkbAreaSunShadows2 = ChkbAreaSunShadows;
            size1 = new Size(32, 16);
            Size size116 = size1;
            chkbAreaSunShadows2.Size = size116;
            ChkbAreaSunShadows.TabIndex = 4;
            TrkbarSunFogNear.Enabled = false;
            TrackBar trkbarSunFogNear1 = TrkbarSunFogNear;
            point1 = new Point(232, 24);
            Point point120 = point1;
            trkbarSunFogNear1.Location = point120;
            TrkbarSunFogNear.Maximum = 2000;
            TrkbarSunFogNear.Name = "trkbarSunFogNear";
            TrackBar trkbarSunFogNear2 = TrkbarSunFogNear;
            size1 = new Size(200, 42);
            Size size117 = size1;
            trkbarSunFogNear2.Size = size117;
            TrkbarSunFogNear.TabIndex = 5;
            TrkbarSunFogNear.TickFrequency = 50;
            TrkbarSunFogNear.TickStyle = TickStyle.TopLeft;
            Label label271 = Label27;
            point1 = new Point(16, 40);
            Point point121 = point1;
            label271.Location = point121;
            Label27.Name = "Label27";
            Label label272 = Label27;
            size1 = new Size(88, 16);
            Size size118 = size1;
            label272.Size = size118;
            Label27.TabIndex = 16;
            Label27.Text = "Diffuse Color";
            Label27.TextAlign = ContentAlignment.MiddleLeft;
            BtnSunAmbientColor.FlatStyle = FlatStyle.Flat;
            Button btnSunAmbientColor1 = BtnSunAmbientColor;
            point1 = new Point(112, 16);
            Point point122 = point1;
            btnSunAmbientColor1.Location = point122;
            BtnSunAmbientColor.Name = "btnSunAmbientColor";
            Button btnSunAmbientColor2 = BtnSunAmbientColor;
            size1 = new Size(16, 16);
            Size size119 = size1;
            btnSunAmbientColor2.Size = size119;
            BtnSunAmbientColor.TabIndex = 0;
            Label label261 = Label26;
            point1 = new Point(16, 16);
            Point point123 = point1;
            label261.Location = point123;
            Label26.Name = "Label26";
            Label label262 = Label26;
            size1 = new Size(88, 16);
            Size size120 = size1;
            label262.Size = size120;
            Label26.TabIndex = 17;
            Label26.Text = "Ambient Color";
            Label26.TextAlign = ContentAlignment.MiddleLeft;
            BtnSunDiffuseColor.FlatStyle = FlatStyle.Flat;
            Button btnSunDiffuseColor1 = BtnSunDiffuseColor;
            point1 = new Point(112, 40);
            Point point124 = point1;
            btnSunDiffuseColor1.Location = point124;
            BtnSunDiffuseColor.Name = "btnSunDiffuseColor";
            Button btnSunDiffuseColor2 = BtnSunDiffuseColor;
            size1 = new Size(16, 16);
            Size size121 = size1;
            btnSunDiffuseColor2.Size = size121;
            BtnSunDiffuseColor.TabIndex = 1;
            Label label281 = Label28;
            point1 = new Point(16, 88);
            Point point125 = point1;
            label281.Location = point125;
            Label28.Name = "Label28";
            Label label282 = Label28;
            size1 = new Size(88, 16);
            Size size122 = size1;
            label282.Size = size122;
            Label28.TabIndex = 16;
            Label28.Text = "Fog Color";
            Label28.TextAlign = ContentAlignment.MiddleLeft;
            BtnSunFogColor.FlatStyle = FlatStyle.Flat;
            Button btnSunFogColor1 = BtnSunFogColor;
            point1 = new Point(112, 88);
            Point point126 = point1;
            btnSunFogColor1.Location = point126;
            BtnSunFogColor.Name = "btnSunFogColor";
            Button btnSunFogColor2 = BtnSunFogColor;
            size1 = new Size(16, 16);
            Size size123 = size1;
            btnSunFogColor2.Size = size123;
            BtnSunFogColor.TabIndex = 3;
            Label label291 = Label29;
            point1 = new Point(16, 64);
            Point point127 = point1;
            label291.Location = point127;
            Label29.Name = "Label29";
            Label label292 = Label29;
            size1 = new Size(88, 16);
            Size size124 = size1;
            label292.Size = size124;
            Label29.TabIndex = 16;
            Label29.Text = "Fog Enabled";
            Label29.TextAlign = ContentAlignment.MiddleLeft;
            Label label301 = Label30;
            point1 = new Point(16, 112);
            Point point128 = point1;
            label301.Location = point128;
            Label30.Name = "Label30";
            Label label302 = Label30;
            size1 = new Size(88, 16);
            Size size125 = size1;
            label302.Size = size125;
            Label30.TabIndex = 16;
            Label30.Text = "Shadows";
            Label30.TextAlign = ContentAlignment.MiddleLeft;
            TrkbarSunFogFar.Enabled = false;
            TrackBar trkbarSunFogFar1 = TrkbarSunFogFar;
            point1 = new Point(232, 80);
            Point point129 = point1;
            trkbarSunFogFar1.Location = point129;
            TrkbarSunFogFar.Maximum = 2000;
            TrkbarSunFogFar.Name = "trkbarSunFogFar";
            TrackBar trkbarSunFogFar2 = TrkbarSunFogFar;
            size1 = new Size(200, 42);
            Size size126 = size1;
            trkbarSunFogFar2.Size = size126;
            TrkbarSunFogFar.TabIndex = 6;
            TrkbarSunFogFar.TickFrequency = 50;
            TrkbarSunFogFar.TickStyle = TickStyle.TopLeft;
            LblSunFogNear.Enabled = false;
            Label lblSunFogNear1 = LblSunFogNear;
            point1 = new Point(160, 32);
            Point point130 = point1;
            lblSunFogNear1.Location = point130;
            LblSunFogNear.Name = "lblSunFogNear";
            Label lblSunFogNear2 = LblSunFogNear;
            size1 = new Size(64, 16);
            Size size127 = size1;
            lblSunFogNear2.Size = size127;
            LblSunFogNear.TabIndex = 16;
            LblSunFogNear.Text = "Fog Near";
            LblSunFogNear.TextAlign = ContentAlignment.MiddleLeft;
            LblSunFogFar.Enabled = false;
            Label lblSunFogFar1 = LblSunFogFar;
            point1 = new Point(160, 88);
            Point point131 = point1;
            lblSunFogFar1.Location = point131;
            LblSunFogFar.Name = "lblSunFogFar";
            Label lblSunFogFar2 = LblSunFogFar;
            size1 = new Size(64, 16);
            Size size128 = size1;
            lblSunFogFar2.Size = size128;
            LblSunFogFar.TabIndex = 16;
            LblSunFogFar.Text = "Fog Far";
            LblSunFogFar.TextAlign = ContentAlignment.MiddleLeft;
            CheckBox chkbSunFogOn1 = ChkbSunFogOn;
            point1 = new Point(112, 64);
            Point point132 = point1;
            chkbSunFogOn1.Location = point132;
            ChkbSunFogOn.Name = "chkbSunFogOn";
            CheckBox chkbSunFogOn2 = ChkbSunFogOn;
            size1 = new Size(32, 16);
            Size size129 = size1;
            chkbSunFogOn2.Size = size129;
            ChkbSunFogOn.TabIndex = 2;
            RadioButton rbAlwaysDay1 = RbAlwaysDay;
            point1 = new Point(40, 24);
            Point point133 = point1;
            rbAlwaysDay1.Location = point133;
            RbAlwaysDay.Name = "rbAlwaysDay";
            RadioButton rbAlwaysDay2 = RbAlwaysDay;
            size1 = new Size(104, 16);
            Size size130 = size1;
            rbAlwaysDay2.Size = size130;
            RbAlwaysDay.TabIndex = 1;
            RbAlwaysDay.Text = "Always Day";
            RadioButton rbAlwaysNight1 = RbAlwaysNight;
            point1 = new Point(40, 40);
            Point point134 = point1;
            rbAlwaysNight1.Location = point134;
            RbAlwaysNight.Name = "rbAlwaysNight";
            RadioButton rbAlwaysNight2 = RbAlwaysNight;
            size1 = new Size(104, 16);
            Size size131 = size1;
            rbAlwaysNight2.Size = size131;
            RbAlwaysNight.TabIndex = 2;
            RbAlwaysNight.Text = "Always Night";
            BtnDynAmbientColor.FlatStyle = FlatStyle.Flat;
            Button btnDynAmbientColor1 = BtnDynAmbientColor;
            point1 = new Point(376, 10);
            Point point135 = point1;
            btnDynAmbientColor1.Location = point135;
            BtnDynAmbientColor.Name = "btnDynAmbientColor";
            Button btnDynAmbientColor2 = BtnDynAmbientColor;
            size1 = new Size(16, 16);
            Size size132 = size1;
            btnDynAmbientColor2.Size = size132;
            BtnDynAmbientColor.TabIndex = 3;
            Label label481 = Label48;
            point1 = new Point(232, 10);
            Point point136 = point1;
            label481.Location = point136;
            Label48.Name = "Label48";
            Label label482 = Label48;
            size1 = new Size(136, 16);
            Size size133 = size1;
            label482.Size = size133;
            Label48.TabIndex = 17;
            Label48.Text = "Dynamic Ambient Color";
            Label48.TextAlign = ContentAlignment.MiddleLeft;
            Label label731 = Label73;
            point1 = new Point(232, 32);
            Point point137 = point1;
            label731.Location = point137;
            Label73.Name = "Label73";
            Label label732 = Label73;
            size1 = new Size(88, 16);
            Size size134 = size1;
            label732.Size = size134;
            Label73.TabIndex = 24;
            Label73.Text = "Shadow Opacity";
            Label73.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudShadowOpacity1 = NudShadowOpacity;
            point1 = new Point(352, 32);
            Point point138 = point1;
            nudShadowOpacity1.Location = point138;
            NumericUpDown nudShadowOpacity2 = NudShadowOpacity;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num29 = num1;
            nudShadowOpacity2.Maximum = num29;
            NudShadowOpacity.Name = "nudShadowOpacity";
            NumericUpDown nudShadowOpacity3 = NudShadowOpacity;
            size1 = new Size(48, 20);
            Size size135 = size1;
            nudShadowOpacity3.Size = size135;
            NudShadowOpacity.TabIndex = 0;
            NudShadowOpacity.TextAlign = HorizontalAlignment.Right;
            Label84.Enabled = false;
            Label label841 = Label84;
            point1 = new Point(248, 360);
            Point point139 = point1;
            label841.Location = point139;
            Label84.Name = "Label84";
            Label label842 = Label84;
            size1 = new Size(80, 16);
            Size size136 = size1;
            label842.Size = size136;
            Label84.TabIndex = 16;
            Label84.Text = "Wind Strength";
            Label84.TextAlign = ContentAlignment.MiddleLeft;
            TabpagAreaGrass.Controls.Add(NudGrassDensity);
            TabpagAreaGrass.Controls.Add(TrkbarGrassDensityX10);
            TabpagAreaGrass.Controls.Add(Label62);
            TabpagAreaGrass.Controls.Add(BtnGrassDiffuseColor);
            TabpagAreaGrass.Controls.Add(TbGrassTexName);
            TabpagAreaGrass.Controls.Add(Label20);
            TabpagAreaGrass.Controls.Add(Label21);
            TabpagAreaGrass.Controls.Add(Label22);
            TabpagAreaGrass.Controls.Add(BtnGrassAmbientColor);
            TabpagAreaGrass.Controls.Add(Label23);
            TabpagAreaGrass.Controls.Add(BtnGrassEmissiveColor);
            TabpagAreaGrass.Controls.Add(NudGrassProbUl);
            TabpagAreaGrass.Controls.Add(NudGrassProbLl);
            TabpagAreaGrass.Controls.Add(NudGrassProbUr);
            TabpagAreaGrass.Controls.Add(NudGrassProbLr);
            TabpagAreaGrass.Controls.Add(Label63);
            TabpagAreaGrass.Controls.Add(Label64);
            TabpagAreaGrass.Controls.Add(Label65);
            TabpagAreaGrass.Controls.Add(Label66);
            TabpagAreaGrass.Controls.Add(Label67);
            TabpagAreaGrass.Controls.Add(LblTotalGrassProbability);
            TabpagAreaGrass.Controls.Add(Label69);
            TabpagAreaGrass.Controls.Add(Label70);
            TabpagAreaGrass.Controls.Add(Label71);
            TabpagAreaGrass.Controls.Add(Label72);
            TabpagAreaGrass.Controls.Add(Label68);
            TabpagAreaGrass.Controls.Add(NudGrassQuadSize);
            TabPage tabpagAreaGrass1 = TabpagAreaGrass;
            point1 = new Point(4, 22);
            Point point140 = point1;
            ((Control) tabpagAreaGrass1).Location = point140;
            TabpagAreaGrass.Name = "tabpagAreaGrass";
            TabPage tabpagAreaGrass2 = TabpagAreaGrass;
            size1 = new Size(480, 444);
            Size size137 = size1;
            tabpagAreaGrass2.Size = size137;
            TabpagAreaGrass.TabIndex = 2;
            TabpagAreaGrass.Text = "Grass";
            NudGrassDensity.DecimalPlaces = 2;
            NumericUpDown nudGrassDensity1 = NudGrassDensity;
            point1 = new Point(320, 320);
            Point point141 = point1;
            nudGrassDensity1.Location = point141;
            NumericUpDown nudGrassDensity2 = NudGrassDensity;
            num1 = new Decimal(new int[4] {50, 0, 0, 0});
            Decimal num30 = num1;
            nudGrassDensity2.Maximum = num30;
            NudGrassDensity.Name = "nudGrassDensity";
            NumericUpDown nudGrassDensity3 = NudGrassDensity;
            size1 = new Size(56, 20);
            Size size138 = size1;
            nudGrassDensity3.Size = size138;
            NudGrassDensity.TabIndex = 19;
            NudGrassDensity.TextAlign = HorizontalAlignment.Right;
            TrackBar trkbarGrassDensityX101 = TrkbarGrassDensityX10;
            point1 = new Point(112, 312);
            Point point142 = point1;
            trkbarGrassDensityX101.Location = point142;
            TrkbarGrassDensityX10.Maximum = 500;
            TrkbarGrassDensityX10.Name = "trkbarGrassDensityX10";
            TrackBar trkbarGrassDensityX102 = TrkbarGrassDensityX10;
            size1 = new Size(200, 42);
            Size size139 = size1;
            trkbarGrassDensityX102.Size = size139;
            TrkbarGrassDensityX10.TabIndex = 17;
            TrkbarGrassDensityX10.TickFrequency = 10;
            Label label621 = Label62;
            point1 = new Point(24, 320);
            Point point143 = point1;
            label621.Location = point143;
            Label62.Name = "Label62";
            Label label622 = Label62;
            size1 = new Size(80, 16);
            Size size140 = size1;
            label622.Size = size140;
            Label62.TabIndex = 18;
            Label62.Text = "Grass Density";
            Label62.TextAlign = ContentAlignment.MiddleLeft;
            BtnGrassDiffuseColor.FlatStyle = FlatStyle.Flat;
            Button grassDiffuseColor1 = BtnGrassDiffuseColor;
            point1 = new Point(120, 104);
            Point point144 = point1;
            grassDiffuseColor1.Location = point144;
            BtnGrassDiffuseColor.Name = "btnGrassDiffuseColor";
            Button grassDiffuseColor2 = BtnGrassDiffuseColor;
            size1 = new Size(16, 16);
            Size size141 = size1;
            grassDiffuseColor2.Size = size141;
            BtnGrassDiffuseColor.TabIndex = 15;
            TextBox tbGrassTexName1 = TbGrassTexName;
            point1 = new Point(120, 40);
            Point point145 = point1;
            tbGrassTexName1.Location = point145;
            TbGrassTexName.MaxLength = 16;
            TbGrassTexName.Name = "tbGrass_TexName";
            TextBox tbGrassTexName2 = TbGrassTexName;
            size1 = new Size(176, 20);
            Size size142 = size1;
            tbGrassTexName2.Size = size142;
            TbGrassTexName.TabIndex = 14;
            TbGrassTexName.Text = "";
            Label label201 = Label20;
            point1 = new Point(24, 40);
            Point point146 = point1;
            label201.Location = point146;
            Label20.Name = "Label20";
            Label label202 = Label20;
            size1 = new Size(88, 16);
            Size size143 = size1;
            label202.Size = size143;
            Label20.TabIndex = 13;
            Label20.Text = "Texture Name";
            Label20.TextAlign = ContentAlignment.MiddleLeft;
            Label label211 = Label21;
            point1 = new Point(24, 80);
            Point point147 = point1;
            label211.Location = point147;
            Label21.Name = "Label21";
            Label label212 = Label21;
            size1 = new Size(88, 16);
            Size size144 = size1;
            label212.Size = size144;
            Label21.TabIndex = 13;
            Label21.Text = "Ambient Color";
            Label21.TextAlign = ContentAlignment.MiddleLeft;
            Label label221 = Label22;
            point1 = new Point(24, 104);
            Point point148 = point1;
            label221.Location = point148;
            Label22.Name = "Label22";
            Label label222 = Label22;
            size1 = new Size(88, 16);
            Size size145 = size1;
            label222.Size = size145;
            Label22.TabIndex = 13;
            Label22.Text = "Diffuse Color";
            Label22.TextAlign = ContentAlignment.MiddleLeft;
            BtnGrassAmbientColor.FlatStyle = FlatStyle.Flat;
            Button grassAmbientColor1 = BtnGrassAmbientColor;
            point1 = new Point(120, 80);
            Point point149 = point1;
            grassAmbientColor1.Location = point149;
            BtnGrassAmbientColor.Name = "btnGrassAmbientColor";
            Button grassAmbientColor2 = BtnGrassAmbientColor;
            size1 = new Size(16, 16);
            Size size146 = size1;
            grassAmbientColor2.Size = size146;
            BtnGrassAmbientColor.TabIndex = 15;
            Label label231 = Label23;
            point1 = new Point(24, 128);
            Point point150 = point1;
            label231.Location = point150;
            Label23.Name = "Label23";
            Label label232 = Label23;
            size1 = new Size(88, 16);
            Size size147 = size1;
            label232.Size = size147;
            Label23.TabIndex = 13;
            Label23.Text = "Emissive Color";
            Label23.TextAlign = ContentAlignment.MiddleLeft;
            BtnGrassEmissiveColor.FlatStyle = FlatStyle.Flat;
            Button grassEmissiveColor1 = BtnGrassEmissiveColor;
            point1 = new Point(120, 128);
            Point point151 = point1;
            grassEmissiveColor1.Location = point151;
            BtnGrassEmissiveColor.Name = "btnGrassEmissiveColor";
            Button grassEmissiveColor2 = BtnGrassEmissiveColor;
            size1 = new Size(16, 16);
            Size size148 = size1;
            grassEmissiveColor2.Size = size148;
            BtnGrassEmissiveColor.TabIndex = 15;
            NumericUpDown nudGrassProbUl1 = NudGrassProbUl;
            point1 = new Point(160, 216);
            Point point152 = point1;
            nudGrassProbUl1.Location = point152;
            NudGrassProbUl.Name = "nudGrassProbUL";
            NumericUpDown nudGrassProbUl2 = NudGrassProbUl;
            size1 = new Size(40, 20);
            Size size149 = size1;
            nudGrassProbUl2.Size = size149;
            NudGrassProbUl.TabIndex = 19;
            NudGrassProbUl.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudGrassProbUl3 = NudGrassProbUl;
            num1 = new Decimal(new int[4] {25, 0, 0, 0});
            Decimal num31 = num1;
            nudGrassProbUl3.Value = num31;
            NumericUpDown nudGrassProbLl1 = NudGrassProbLl;
            point1 = new Point(160, 272);
            Point point153 = point1;
            nudGrassProbLl1.Location = point153;
            NudGrassProbLl.Name = "nudGrassProbLL";
            NumericUpDown nudGrassProbLl2 = NudGrassProbLl;
            size1 = new Size(40, 20);
            Size size150 = size1;
            nudGrassProbLl2.Size = size150;
            NudGrassProbLl.TabIndex = 19;
            NudGrassProbLl.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudGrassProbLl3 = NudGrassProbLl;
            num1 = new Decimal(new int[4] {25, 0, 0, 0});
            Decimal num32 = num1;
            nudGrassProbLl3.Value = num32;
            NumericUpDown nudGrassProbUr1 = NudGrassProbUr;
            point1 = new Point(264, 216);
            Point point154 = point1;
            nudGrassProbUr1.Location = point154;
            NudGrassProbUr.Name = "nudGrassProbUR";
            NumericUpDown nudGrassProbUr2 = NudGrassProbUr;
            size1 = new Size(40, 20);
            Size size151 = size1;
            nudGrassProbUr2.Size = size151;
            NudGrassProbUr.TabIndex = 19;
            NudGrassProbUr.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudGrassProbUr3 = NudGrassProbUr;
            num1 = new Decimal(new int[4] {25, 0, 0, 0});
            Decimal num33 = num1;
            nudGrassProbUr3.Value = num33;
            NumericUpDown nudGrassProbLr1 = NudGrassProbLr;
            point1 = new Point(264, 272);
            Point point155 = point1;
            nudGrassProbLr1.Location = point155;
            NudGrassProbLr.Name = "nudGrassProbLR";
            NumericUpDown nudGrassProbLr2 = NudGrassProbLr;
            size1 = new Size(40, 20);
            Size size152 = size1;
            nudGrassProbLr2.Size = size152;
            NudGrassProbLr.TabIndex = 19;
            NudGrassProbLr.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudGrassProbLr3 = NudGrassProbLr;
            num1 = new Decimal(new int[4] {25, 0, 0, 0});
            Decimal num34 = num1;
            nudGrassProbLr3.Value = num34;
            Label label631 = Label63;
            point1 = new Point(24, 224);
            Point point156 = point1;
            label631.Location = point156;
            Label63.Name = "Label63";
            Label label632 = Label63;
            size1 = new Size(80, 48);
            Size size153 = size1;
            label632.Size = size153;
            Label63.TabIndex = 18;
            Label63.Text = "Grass Movement Probability";
            Label63.TextAlign = ContentAlignment.MiddleLeft;
            Label label641 = Label64;
            point1 = new Point(224, 208);
            Point point157 = point1;
            label641.Location = point157;
            Label64.Name = "Label64";
            Label label642 = Label64;
            size1 = new Size(40, 32);
            Size size154 = size1;
            label642.Size = size154;
            Label64.TabIndex = 13;
            Label64.Text = "Upper Right";
            Label64.TextAlign = ContentAlignment.MiddleLeft;
            Label label651 = Label65;
            point1 = new Point(120, 208);
            Point point158 = point1;
            label651.Location = point158;
            Label65.Name = "Label65";
            Label label652 = Label65;
            size1 = new Size(40, 32);
            Size size155 = size1;
            label652.Size = size155;
            Label65.TabIndex = 13;
            Label65.Text = "Upper Left";
            Label65.TextAlign = ContentAlignment.MiddleLeft;
            Label label661 = Label66;
            point1 = new Point(120, 264);
            Point point159 = point1;
            label661.Location = point159;
            Label66.Name = "Label66";
            Label label662 = Label66;
            size1 = new Size(40, 32);
            Size size156 = size1;
            label662.Size = size156;
            Label66.TabIndex = 13;
            Label66.Text = "Lower Left";
            Label66.TextAlign = ContentAlignment.MiddleLeft;
            Label label671 = Label67;
            point1 = new Point(224, 264);
            Point point160 = point1;
            label671.Location = point160;
            Label67.Name = "Label67";
            Label label672 = Label67;
            size1 = new Size(40, 32);
            Size size157 = size1;
            label672.Size = size157;
            Label67.TabIndex = 13;
            Label67.Text = "Lower Right";
            Label67.TextAlign = ContentAlignment.MiddleLeft;
            Label grassProbability1 = LblTotalGrassProbability;
            point1 = new Point(344, 248);
            Point point161 = point1;
            grassProbability1.Location = point161;
            LblTotalGrassProbability.Name = "lblTotalGrassProbability";
            Label grassProbability2 = LblTotalGrassProbability;
            size1 = new Size(80, 16);
            Size size158 = size1;
            grassProbability2.Size = size158;
            LblTotalGrassProbability.TabIndex = 18;
            LblTotalGrassProbability.Text = "Total: ";
            LblTotalGrassProbability.TextAlign = ContentAlignment.MiddleLeft;
            Label label691 = Label69;
            point1 = new Point(200, 218);
            Point point162 = point1;
            label691.Location = point162;
            Label69.Name = "Label69";
            Label label692 = Label69;
            size1 = new Size(16, 16);
            Size size159 = size1;
            label692.Size = size159;
            Label69.TabIndex = 13;
            Label69.Text = "%";
            Label69.TextAlign = ContentAlignment.MiddleLeft;
            Label label701 = Label70;
            point1 = new Point(304, 218);
            Point point163 = point1;
            label701.Location = point163;
            Label70.Name = "Label70";
            Label label702 = Label70;
            size1 = new Size(16, 16);
            Size size160 = size1;
            label702.Size = size160;
            Label70.TabIndex = 13;
            Label70.Text = "%";
            Label70.TextAlign = ContentAlignment.MiddleLeft;
            Label label711 = Label71;
            point1 = new Point(304, 274);
            Point point164 = point1;
            label711.Location = point164;
            Label71.Name = "Label71";
            Label label712 = Label71;
            size1 = new Size(16, 16);
            Size size161 = size1;
            label712.Size = size161;
            Label71.TabIndex = 13;
            Label71.Text = "%";
            Label71.TextAlign = ContentAlignment.MiddleLeft;
            Label label721 = Label72;
            point1 = new Point(200, 274);
            Point point165 = point1;
            label721.Location = point165;
            Label72.Name = "Label72";
            Label label722 = Label72;
            size1 = new Size(16, 16);
            Size size162 = size1;
            label722.Size = size162;
            Label72.TabIndex = 13;
            Label72.Text = "%";
            Label72.TextAlign = ContentAlignment.MiddleLeft;
            Label label681 = Label68;
            point1 = new Point(24, 160);
            Point point166 = point1;
            label681.Location = point166;
            Label68.Name = "Label68";
            Label label682 = Label68;
            size1 = new Size(96, 16);
            Size size163 = size1;
            label682.Size = size163;
            Label68.TabIndex = 18;
            Label68.Text = "Grass Quad Size";
            Label68.TextAlign = ContentAlignment.MiddleLeft;
            NudGrassQuadSize.DecimalPlaces = 2;
            NumericUpDown nudGrassQuadSize1 = NudGrassQuadSize;
            num1 = new Decimal(new int[4] {5, 0, 0, 131072});
            Decimal num35 = num1;
            nudGrassQuadSize1.Increment = num35;
            NumericUpDown nudGrassQuadSize2 = NudGrassQuadSize;
            point1 = new Point(120, 160);
            Point point167 = point1;
            nudGrassQuadSize2.Location = point167;
            NumericUpDown nudGrassQuadSize3 = NudGrassQuadSize;
            num1 = new Decimal(new int[4] {20, 0, 0, 0});
            Decimal num36 = num1;
            nudGrassQuadSize3.Maximum = num36;
            NudGrassQuadSize.Name = "nudGrassQuadSize";
            NumericUpDown nudGrassQuadSize4 = NudGrassQuadSize;
            size1 = new Size(56, 20);
            Size size164 = size1;
            nudGrassQuadSize4.Size = size164;
            NudGrassQuadSize.TabIndex = 19;
            NudGrassQuadSize.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudGrassQuadSize5 = NudGrassQuadSize;
            num1 = new Decimal(new int[4] {10, 0, 0, 65536});
            Decimal num37 = num1;
            nudGrassQuadSize5.Value = num37;
            TabpagAreaAudio.Controls.Add(TrkbarAmbientSndNightVol);
            TabpagAreaAudio.Controls.Add(TrkbarAmbientSndDayVol);
            TabpagAreaAudio.Controls.Add(Label52);
            TabpagAreaAudio.Controls.Add(NudMusicDelay);
            TabpagAreaAudio.Controls.Add(CmbxMusicNight);
            TabpagAreaAudio.Controls.Add(CmbxMusicDay);
            TabpagAreaAudio.Controls.Add(CmbxMusicBattle);
            TabpagAreaAudio.Controls.Add(CmbxEnvAudio);
            TabpagAreaAudio.Controls.Add(CmbxAmbientSndNight);
            TabpagAreaAudio.Controls.Add(CmbxAmbientSndDay);
            TabpagAreaAudio.Controls.Add(Label53);
            TabpagAreaAudio.Controls.Add(Label54);
            TabpagAreaAudio.Controls.Add(Label55);
            TabpagAreaAudio.Controls.Add(Label56);
            TabpagAreaAudio.Controls.Add(Label57);
            TabpagAreaAudio.Controls.Add(Label58);
            TabpagAreaAudio.Controls.Add(Label59);
            TabpagAreaAudio.Controls.Add(Label60);
            TabpagAreaAudio.Controls.Add(Label61);
            TabPage tabpagAreaAudio1 = TabpagAreaAudio;
            point1 = new Point(4, 22);
            Point point168 = point1;
            ((Control) tabpagAreaAudio1).Location = point168;
            TabpagAreaAudio.Name = "tabpagAreaAudio";
            TabPage tabpagAreaAudio2 = TabpagAreaAudio;
            size1 = new Size(480, 444);
            Size size165 = size1;
            tabpagAreaAudio2.Size = size165;
            TabpagAreaAudio.TabIndex = 5;
            TabpagAreaAudio.Text = "Audio";
            TrackBar ambientSndNightVol1 = TrkbarAmbientSndNightVol;
            point1 = new Point(160, 144);
            Point point169 = point1;
            ambientSndNightVol1.Location = point169;
            TrkbarAmbientSndNightVol.Maximum = sbyte.MaxValue;
            TrkbarAmbientSndNightVol.Name = "trkbarAmbientSndNightVol";
            TrackBar ambientSndNightVol2 = TrkbarAmbientSndNightVol;
            size1 = new Size(216, 42);
            Size size166 = size1;
            ambientSndNightVol2.Size = size166;
            TrkbarAmbientSndNightVol.TabIndex = 3;
            TrkbarAmbientSndNightVol.TickFrequency = 5;
            TrackBar ambientSndDayVol1 = TrkbarAmbientSndDayVol;
            point1 = new Point(160, 64);
            Point point170 = point1;
            ambientSndDayVol1.Location = point170;
            TrkbarAmbientSndDayVol.Maximum = sbyte.MaxValue;
            TrkbarAmbientSndDayVol.Name = "trkbarAmbientSndDayVol";
            TrackBar ambientSndDayVol2 = TrkbarAmbientSndDayVol;
            size1 = new Size(216, 42);
            Size size167 = size1;
            ambientSndDayVol2.Size = size167;
            TrkbarAmbientSndDayVol.TabIndex = 1;
            TrkbarAmbientSndDayVol.TickFrequency = 5;
            Label label521 = Label52;
            point1 = new Point(24, 40);
            Point point171 = point1;
            label521.Location = point171;
            Label52.Name = "Label52";
            Label label522 = Label52;
            size1 = new Size(112, 16);
            Size size168 = size1;
            label522.Size = size168;
            Label52.TabIndex = 19;
            Label52.Text = "Ambient Sound - Day";
            Label52.TextAlign = ContentAlignment.MiddleLeft;
            NumericUpDown nudMusicDelay1 = NudMusicDelay;
            point1 = new Point(168, 336);
            Point point172 = point1;
            nudMusicDelay1.Location = point172;
            NumericUpDown nudMusicDelay2 = NudMusicDelay;
            num1 = new Decimal(new int[4] {600, 0, 0, 0});
            Decimal num38 = num1;
            nudMusicDelay2.Maximum = num38;
            NudMusicDelay.Name = "nudMusicDelay";
            NumericUpDown nudMusicDelay3 = NudMusicDelay;
            size1 = new Size(56, 20);
            Size size169 = size1;
            nudMusicDelay3.Size = size169;
            NudMusicDelay.TabIndex = 8;
            NudMusicDelay.TextAlign = HorizontalAlignment.Right;
            CmbxMusicNight.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxMusicNight1 = CmbxMusicNight;
            point1 = new Point(168, 304);
            Point point173 = point1;
            cmbxMusicNight1.Location = point173;
            CmbxMusicNight.Name = "cmbxMusicNight";
            ComboBox cmbxMusicNight2 = CmbxMusicNight;
            size1 = new Size(200, 21);
            Size size170 = size1;
            cmbxMusicNight2.Size = size170;
            CmbxMusicNight.TabIndex = 7;
            CmbxMusicDay.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxMusicDay1 = CmbxMusicDay;
            point1 = new Point(168, 272);
            Point point174 = point1;
            cmbxMusicDay1.Location = point174;
            CmbxMusicDay.Name = "cmbxMusicDay";
            ComboBox cmbxMusicDay2 = CmbxMusicDay;
            size1 = new Size(200, 21);
            Size size171 = size1;
            cmbxMusicDay2.Size = size171;
            CmbxMusicDay.TabIndex = 6;
            CmbxMusicBattle.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxMusicBattle1 = CmbxMusicBattle;
            point1 = new Point(168, 240);
            Point point175 = point1;
            cmbxMusicBattle1.Location = point175;
            CmbxMusicBattle.Name = "cmbxMusicBattle";
            ComboBox cmbxMusicBattle2 = CmbxMusicBattle;
            size1 = new Size(200, 21);
            Size size172 = size1;
            cmbxMusicBattle2.Size = size172;
            CmbxMusicBattle.TabIndex = 5;
            CmbxEnvAudio.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxEnvAudio1 = CmbxEnvAudio;
            point1 = new Point(168, 208);
            Point point176 = point1;
            cmbxEnvAudio1.Location = point176;
            CmbxEnvAudio.Name = "cmbxEnvAudio";
            ComboBox cmbxEnvAudio2 = CmbxEnvAudio;
            size1 = new Size(200, 21);
            Size size173 = size1;
            cmbxEnvAudio2.Size = size173;
            CmbxEnvAudio.TabIndex = 4;
            CmbxAmbientSndNight.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxAmbientSndNight1 = CmbxAmbientSndNight;
            point1 = new Point(168, 120);
            Point point177 = point1;
            cmbxAmbientSndNight1.Location = point177;
            CmbxAmbientSndNight.Name = "cmbxAmbientSndNight";
            ComboBox cmbxAmbientSndNight2 = CmbxAmbientSndNight;
            size1 = new Size(200, 21);
            Size size174 = size1;
            cmbxAmbientSndNight2.Size = size174;
            CmbxAmbientSndNight.TabIndex = 2;
            CmbxAmbientSndDay.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxAmbientSndDay1 = CmbxAmbientSndDay;
            point1 = new Point(168, 40);
            Point point178 = point1;
            cmbxAmbientSndDay1.Location = point178;
            CmbxAmbientSndDay.Name = "cmbxAmbientSndDay";
            ComboBox cmbxAmbientSndDay2 = CmbxAmbientSndDay;
            size1 = new Size(200, 21);
            Size size175 = size1;
            cmbxAmbientSndDay2.Size = size175;
            CmbxAmbientSndDay.TabIndex = 0;
            Label label531 = Label53;
            point1 = new Point(24, 68);
            Point point179 = point1;
            label531.Location = point179;
            Label53.Name = "Label53";
            Label label532 = Label53;
            size1 = new Size(88, 16);
            Size size176 = size1;
            label532.Size = size176;
            Label53.TabIndex = 19;
            Label53.Text = "Volume";
            Label53.TextAlign = ContentAlignment.MiddleLeft;
            Label label541 = Label54;
            point1 = new Point(24, 120);
            Point point180 = point1;
            label541.Location = point180;
            Label54.Name = "Label54";
            Label label542 = Label54;
            size1 = new Size(120, 16);
            Size size177 = size1;
            label542.Size = size177;
            Label54.TabIndex = 19;
            Label54.Text = "Ambient Sound - Night";
            Label54.TextAlign = ContentAlignment.MiddleLeft;
            Label label551 = Label55;
            point1 = new Point(24, 148);
            Point point181 = point1;
            label551.Location = point181;
            Label55.Name = "Label55";
            Label label552 = Label55;
            size1 = new Size(88, 16);
            Size size178 = size1;
            label552.Size = size178;
            Label55.TabIndex = 19;
            Label55.Text = "Volume";
            Label55.TextAlign = ContentAlignment.MiddleLeft;
            Label label561 = Label56;
            point1 = new Point(24, 205);
            Point point182 = point1;
            label561.Location = point182;
            Label56.Name = "Label56";
            Label label562 = Label56;
            size1 = new Size(88, 24);
            Size size179 = size1;
            label562.Size = size179;
            Label56.TabIndex = 19;
            Label56.Text = "Environmental Audio Effects";
            Label56.TextAlign = ContentAlignment.MiddleLeft;
            Label label571 = Label57;
            point1 = new Point(24, 240);
            Point point183 = point1;
            label571.Location = point183;
            Label57.Name = "Label57";
            Label label572 = Label57;
            size1 = new Size(88, 16);
            Size size180 = size1;
            label572.Size = size180;
            Label57.TabIndex = 19;
            Label57.Text = "Battle Music";
            Label57.TextAlign = ContentAlignment.MiddleLeft;
            Label label581 = Label58;
            point1 = new Point(24, 272);
            Point point184 = point1;
            label581.Location = point184;
            Label58.Name = "Label58";
            Label label582 = Label58;
            size1 = new Size(88, 16);
            Size size181 = size1;
            label582.Size = size181;
            Label58.TabIndex = 19;
            Label58.Text = "Daytime Music";
            Label58.TextAlign = ContentAlignment.MiddleLeft;
            Label label591 = Label59;
            point1 = new Point(24, 304);
            Point point185 = point1;
            label591.Location = point185;
            Label59.Name = "Label59";
            Label label592 = Label59;
            size1 = new Size(88, 16);
            Size size182 = size1;
            label592.Size = size182;
            Label59.TabIndex = 19;
            Label59.Text = "Nighttime Music";
            Label59.TextAlign = ContentAlignment.MiddleLeft;
            Label label601 = Label60;
            point1 = new Point(24, 336);
            Point point186 = point1;
            label601.Location = point186;
            Label60.Name = "Label60";
            Label label602 = Label60;
            size1 = new Size(88, 16);
            Size size183 = size1;
            label602.Size = size183;
            Label60.TabIndex = 19;
            Label60.Text = "Music Delay";
            Label60.TextAlign = ContentAlignment.MiddleLeft;
            Label label611 = Label61;
            point1 = new Point(224, 338);
            Point point187 = point1;
            label611.Location = point187;
            Label61.Name = "Label61";
            Label label612 = Label61;
            size1 = new Size(88, 16);
            Size size184 = size1;
            label612.Size = size184;
            Label61.TabIndex = 19;
            Label61.Text = "Seconds";
            Label61.TextAlign = ContentAlignment.MiddleLeft;
            TabpagAreaEvents.Controls.Add(Label77);
            TabpagAreaEvents.Controls.Add(TbAreaOnUserDefined);
            TabpagAreaEvents.Controls.Add(TbAreaOnHeartbeat);
            TabpagAreaEvents.Controls.Add(Label76);
            TabpagAreaEvents.Controls.Add(Label74);
            TabpagAreaEvents.Controls.Add(TbAreaOnEnter);
            TabpagAreaEvents.Controls.Add(Label75);
            TabpagAreaEvents.Controls.Add(TbAreaOnExit);
            TabPage tabpagAreaEvents1 = TabpagAreaEvents;
            point1 = new Point(4, 22);
            Point point188 = point1;
            ((Control) tabpagAreaEvents1).Location = point188;
            TabpagAreaEvents.Name = "tabpagArea_Events";
            TabPage tabpagAreaEvents2 = TabpagAreaEvents;
            size1 = new Size(480, 444);
            Size size185 = size1;
            tabpagAreaEvents2.Size = size185;
            TabpagAreaEvents.TabIndex = 6;
            TabpagAreaEvents.Text = "Events";
            Label label771 = Label77;
            point1 = new Point(24, 112);
            Point point189 = point1;
            label771.Location = point189;
            Label77.Name = "Label77";
            Label label772 = Label77;
            size1 = new Size(100, 18);
            Size size186 = size1;
            label772.Size = size186;
            Label77.TabIndex = 36;
            Label77.Text = "OnUserDefined";
            Label77.TextAlign = ContentAlignment.MiddleLeft;
            TbAreaOnUserDefined.CharacterCasing = CharacterCasing.Lower;
            TextBox areaOnUserDefined1 = TbAreaOnUserDefined;
            point1 = new Point(136, 112);
            Point point190 = point1;
            areaOnUserDefined1.Location = point190;
            TbAreaOnUserDefined.MaxLength = 16;
            TbAreaOnUserDefined.Name = "tbArea_OnUserDefined";
            TextBox areaOnUserDefined2 = TbAreaOnUserDefined;
            size1 = new Size(204, 20);
            Size size187 = size1;
            areaOnUserDefined2.Size = size187;
            TbAreaOnUserDefined.TabIndex = 35;
            TbAreaOnUserDefined.Text = "";
            TbAreaOnHeartbeat.CharacterCasing = CharacterCasing.Lower;
            TextBox tbAreaOnHeartbeat1 = TbAreaOnHeartbeat;
            point1 = new Point(136, 88);
            Point point191 = point1;
            tbAreaOnHeartbeat1.Location = point191;
            TbAreaOnHeartbeat.MaxLength = 16;
            TbAreaOnHeartbeat.Name = "tbArea_OnHeartbeat";
            TextBox tbAreaOnHeartbeat2 = TbAreaOnHeartbeat;
            size1 = new Size(204, 20);
            Size size188 = size1;
            tbAreaOnHeartbeat2.Size = size188;
            TbAreaOnHeartbeat.TabIndex = 33;
            TbAreaOnHeartbeat.Text = "";
            Label label761 = Label76;
            point1 = new Point(24, 88);
            Point point192 = point1;
            label761.Location = point192;
            Label76.Name = "Label76";
            Label label762 = Label76;
            size1 = new Size(100, 18);
            Size size189 = size1;
            label762.Size = size189;
            Label76.TabIndex = 34;
            Label76.Text = "OnHeartbeat";
            Label76.TextAlign = ContentAlignment.MiddleLeft;
            Label label741 = Label74;
            point1 = new Point(24, 40);
            Point point193 = point1;
            label741.Location = point193;
            Label74.Name = "Label74";
            Label label742 = Label74;
            size1 = new Size(100, 18);
            Size size190 = size1;
            label742.Size = size190;
            Label74.TabIndex = 32;
            Label74.Text = "OnEnter";
            Label74.TextAlign = ContentAlignment.MiddleLeft;
            TbAreaOnEnter.CharacterCasing = CharacterCasing.Lower;
            TextBox tbAreaOnEnter1 = TbAreaOnEnter;
            point1 = new Point(136, 40);
            Point point194 = point1;
            tbAreaOnEnter1.Location = point194;
            TbAreaOnEnter.MaxLength = 16;
            TbAreaOnEnter.Name = "tbArea_OnEnter";
            TextBox tbAreaOnEnter2 = TbAreaOnEnter;
            size1 = new Size(204, 20);
            Size size191 = size1;
            tbAreaOnEnter2.Size = size191;
            TbAreaOnEnter.TabIndex = 29;
            TbAreaOnEnter.Text = "";
            Label label751 = Label75;
            point1 = new Point(24, 64);
            Point point195 = point1;
            label751.Location = point195;
            Label75.Name = "Label75";
            Label label752 = Label75;
            size1 = new Size(100, 18);
            Size size192 = size1;
            label752.Size = size192;
            Label75.TabIndex = 31;
            Label75.Text = "OnExit";
            Label75.TextAlign = ContentAlignment.MiddleLeft;
            TbAreaOnExit.CharacterCasing = CharacterCasing.Lower;
            TextBox tbAreaOnExit1 = TbAreaOnExit;
            point1 = new Point(136, 64);
            Point point196 = point1;
            tbAreaOnExit1.Location = point196;
            TbAreaOnExit.MaxLength = 16;
            TbAreaOnExit.Name = "tbArea_OnExit";
            TextBox tbAreaOnExit2 = TbAreaOnExit;
            size1 = new Size(204, 20);
            Size size193 = size1;
            tbAreaOnExit2.Size = size193;
            TbAreaOnExit.TabIndex = 30;
            TbAreaOnExit.Text = "";
            TabpagAreaRooms.Controls.Add(LbRooms);
            TabpagAreaRooms.Controls.Add(Label82);
            TabpagAreaRooms.Controls.Add(ChkbRoomDisableWeather);
            TabpagAreaRooms.Controls.Add(NudRoomAmbientScale);
            TabpagAreaRooms.Controls.Add(Label80);
            TabpagAreaRooms.Controls.Add(CmbxRoomEnvAudio);
            TabpagAreaRooms.Controls.Add(Label79);
            TabpagAreaRooms.Controls.Add(Label78);
            TabpagAreaRooms.Controls.Add(TbRoomName);
            TabpagAreaRooms.Controls.Add(NudRoomForceRating);
            TabpagAreaRooms.Controls.Add(Label81);
            TabpagAreaRooms.Controls.Add(Label83);
            TabPage tabpagAreaRooms1 = TabpagAreaRooms;
            point1 = new Point(4, 22);
            Point point197 = point1;
            ((Control) tabpagAreaRooms1).Location = point197;
            TabpagAreaRooms.Name = "tabpagAreaRooms";
            TabPage tabpagAreaRooms2 = TabpagAreaRooms;
            size1 = new Size(480, 444);
            Size size194 = size1;
            tabpagAreaRooms2.Size = size194;
            TabpagAreaRooms.TabIndex = 7;
            TabpagAreaRooms.Text = "Rooms";
            ListBox lbRooms1 = LbRooms;
            point1 = new Point(176, 40);
            Point point198 = point1;
            lbRooms1.Location = point198;
            LbRooms.Name = "lbRooms";
            LbRooms.ScrollAlwaysVisible = true;
            ListBox lbRooms2 = LbRooms;
            size1 = new Size(96, 95);
            Size size195 = size1;
            lbRooms2.Size = size195;
            LbRooms.TabIndex = 41;
            Label label821 = Label82;
            point1 = new Point(24, 288);
            Point point199 = point1;
            label821.Location = point199;
            Label82.Name = "Label82";
            Label label822 = Label82;
            size1 = new Size(88, 16);
            Size size196 = size1;
            label822.Size = size196;
            Label82.TabIndex = 40;
            Label82.Text = "Disable Weather";
            Label82.TextAlign = ContentAlignment.MiddleLeft;
            CheckBox roomDisableWeather1 = ChkbRoomDisableWeather;
            point1 = new Point(184, 288);
            Point point200 = point1;
            roomDisableWeather1.Location = point200;
            ChkbRoomDisableWeather.Name = "chkbRoomDisableWeather";
            CheckBox roomDisableWeather2 = ChkbRoomDisableWeather;
            size1 = new Size(32, 16);
            Size size197 = size1;
            roomDisableWeather2.Size = size197;
            ChkbRoomDisableWeather.TabIndex = 39;
            NudRoomAmbientScale.DecimalPlaces = 2;
            NumericUpDown roomAmbientScale1 = NudRoomAmbientScale;
            num1 = new Decimal(new int[4] {5, 0, 0, 131072});
            Decimal num39 = num1;
            roomAmbientScale1.Increment = num39;
            NumericUpDown roomAmbientScale2 = NudRoomAmbientScale;
            point1 = new Point(184, 224);
            Point point201 = point1;
            roomAmbientScale2.Location = point201;
            NumericUpDown roomAmbientScale3 = NudRoomAmbientScale;
            num1 = new Decimal(new int[4] {1, 0, 0, 0});
            Decimal num40 = num1;
            roomAmbientScale3.Maximum = num40;
            NudRoomAmbientScale.Name = "nudRoomAmbientScale";
            NumericUpDown roomAmbientScale4 = NudRoomAmbientScale;
            size1 = new Size(56, 20);
            Size size198 = size1;
            roomAmbientScale4.Size = size198;
            NudRoomAmbientScale.TabIndex = 38;
            NudRoomAmbientScale.TextAlign = HorizontalAlignment.Right;
            Label label801 = Label80;
            point1 = new Point(24, 224);
            Point point202 = point1;
            label801.Location = point202;
            Label80.Name = "Label80";
            Label label802 = Label80;
            size1 = new Size(128, 16);
            Size size199 = size1;
            label802.Size = size199;
            Label80.TabIndex = 37;
            Label80.Text = "Ambient Sound Scale";
            Label80.TextAlign = ContentAlignment.MiddleLeft;
            CmbxRoomEnvAudio.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox cmbxRoomEnvAudio1 = CmbxRoomEnvAudio;
            point1 = new Point(184, 192);
            Point point203 = point1;
            cmbxRoomEnvAudio1.Location = point203;
            CmbxRoomEnvAudio.Name = "cmbxRoomEnvAudio";
            ComboBox cmbxRoomEnvAudio2 = CmbxRoomEnvAudio;
            size1 = new Size(192, 21);
            Size size200 = size1;
            cmbxRoomEnvAudio2.Size = size200;
            CmbxRoomEnvAudio.TabIndex = 35;
            Label label791 = Label79;
            point1 = new Point(24, 192);
            Point point204 = point1;
            label791.Location = point204;
            Label79.Name = "Label79";
            Label label792 = Label79;
            size1 = new Size(160, 24);
            Size size201 = size1;
            label792.Size = size201;
            Label79.TabIndex = 36;
            Label79.Text = "Environmental Audio Effects";
            Label79.TextAlign = ContentAlignment.MiddleLeft;
            Label label781 = Label78;
            point1 = new Point(24, 160);
            Point point205 = point1;
            label781.Location = point205;
            Label78.Name = "Label78";
            Label label782 = Label78;
            size1 = new Size(100, 18);
            Size size202 = size1;
            label782.Size = size202;
            Label78.TabIndex = 34;
            Label78.Text = "Room Name";
            Label78.TextAlign = ContentAlignment.MiddleLeft;
            TbRoomName.CharacterCasing = CharacterCasing.Lower;
            TextBox tbRoomName1 = TbRoomName;
            point1 = new Point(184, 160);
            Point point206 = point1;
            tbRoomName1.Location = point206;
            TbRoomName.MaxLength = 16;
            TbRoomName.Name = "tbRoomName";
            TbRoomName.ReadOnly = true;
            TextBox tbRoomName2 = TbRoomName;
            size1 = new Size(104, 20);
            Size size203 = size1;
            tbRoomName2.Size = size203;
            TbRoomName.TabIndex = 33;
            TbRoomName.Text = "";
            NumericUpDown nudRoomForceRating1 = NudRoomForceRating;
            point1 = new Point(184, 256);
            Point point207 = point1;
            nudRoomForceRating1.Location = point207;
            NumericUpDown nudRoomForceRating2 = NudRoomForceRating;
            num1 = new Decimal(new int[4]
            {
                100,
                0,
                0,
                int.MinValue
            });
            Decimal num41 = num1;
            nudRoomForceRating2.Minimum = num41;
            NudRoomForceRating.Name = "nudRoomForceRating";
            NumericUpDown nudRoomForceRating3 = NudRoomForceRating;
            size1 = new Size(56, 20);
            Size size204 = size1;
            nudRoomForceRating3.Size = size204;
            NudRoomForceRating.TabIndex = 38;
            NudRoomForceRating.TextAlign = HorizontalAlignment.Right;
            Label label811 = Label81;
            point1 = new Point(24, 256);
            Point point208 = point1;
            label811.Location = point208;
            Label81.Name = "Label81";
            Label label812 = Label81;
            size1 = new Size(128, 16);
            Size size205 = size1;
            label812.Size = size205;
            Label81.TabIndex = 37;
            Label81.Text = "Force Rating";
            Label81.TextAlign = ContentAlignment.MiddleLeft;
            Label label831 = Label83;
            point1 = new Point(24, 72);
            Point point209 = point1;
            label831.Location = point209;
            Label83.Name = "Label83";
            Label label832 = Label83;
            size1 = new Size(100, 18);
            Size size206 = size1;
            label832.Size = size206;
            Label83.TabIndex = 34;
            Label83.Text = "Rooms";
            Label83.TextAlign = ContentAlignment.MiddleLeft;
            BtnOk.DialogResult = DialogResult.OK;
            Button btnOk = BtnOk;
            point1 = new Point(320, 532);
            Point point210 = point1;
            btnOk.Location = point210;
            BtnOk.Name = "btnOK";
            BtnOk.TabIndex = 0;
            BtnOk.Text = "&OK";
            BtnCancel.DialogResult = DialogResult.Cancel;
            Button btnCancel = BtnCancel;
            point1 = new Point(416, 532);
            Point point211 = point1;
            btnCancel.Location = point211;
            BtnCancel.Name = "btnCancel";
            BtnCancel.TabIndex = 1;
            BtnCancel.Text = "&Cancel";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            CancelButton = BtnCancel;
            size1 = new Size(528, 565);
            ClientSize = size1;
            Controls.Add(BtnOk);
            Controls.Add(BtnCancel);
            Controls.Add(TabControlMain);
            Name = "FrmModuleIfoAreaEditor";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Module Properties Editor";
            TabControlModule.ResumeLayout(false);
            TabpagModuleBasic.ResumeLayout(false);
            NudXy.EndInit();
            NudModEntryX.EndInit();
            NudModEntryY.EndInit();
            NudModEntryZ.EndInit();
            TabpagModuleAdvanced.ResumeLayout(false);
            NudXpScale.EndInit();
            TrkbarXpScale.EndInit();
            NudMinutesPerHour.EndInit();
            NudDawnStartHour.EndInit();
            NudDuskStartHour.EndInit();
            NudStartHour.EndInit();
            NudStartDay.EndInit();
            NudStartMonth.EndInit();
            NudStartYear.EndInit();
            TabpagModuleEvents.ResumeLayout(false);
            TabpagModuleDescription.ResumeLayout(false);
            TabControlMain.ResumeLayout(false);
            TabPage5.ResumeLayout(false);
            TabPage6.ResumeLayout(false);
            TabControlArea.ResumeLayout(false);
            TabpagAreaBasic.ResumeLayout(false);
            NumericUpDown10.EndInit();
            NumericUpDown11.EndInit();
            NumericUpDown12.EndInit();
            TabpagAreaEnvironment.ResumeLayout(false);
            GroupBox1.ResumeLayout(false);
            NudChanceSnow.EndInit();
            NudChanceRain.EndInit();
            NudChanceLightning.EndInit();
            GbMoon.ResumeLayout(false);
            TrkbarMoonFogNear.EndInit();
            TrkbarMoonFogFar.EndInit();
            GbSun.ResumeLayout(false);
            TrkbarSunFogNear.EndInit();
            TrkbarSunFogFar.EndInit();
            NudShadowOpacity.EndInit();
            TabpagAreaGrass.ResumeLayout(false);
            NudGrassDensity.EndInit();
            TrkbarGrassDensityX10.EndInit();
            NudGrassProbUl.EndInit();
            NudGrassProbLl.EndInit();
            NudGrassProbUr.EndInit();
            NudGrassProbLr.EndInit();
            NudGrassQuadSize.EndInit();
            TabpagAreaAudio.ResumeLayout(false);
            TrkbarAmbientSndNightVol.EndInit();
            TrkbarAmbientSndDayVol.EndInit();
            NudMusicDelay.EndInit();
            TabpagAreaEvents.ResumeLayout(false);
            TabpagAreaRooms.ResumeLayout(false);
            NudRoomAmbientScale.EndInit();
            NudRoomForceRating.EndInit();
            ResumeLayout(false);
        }

        private void SetupRooms()
        {
            FillComboBoxFrom2Da(CmbxRoomEnvAudio, "label", "soundeax", _chitinKey, null);
            int num1 = checked(_areFile.GetListItemCount("Rooms") - 1);
            _rooms = new Room[checked(num1 + 1)];
            int num2 = 0;
            int num3 = num1;
            int index = num2;
            while (index <= num3)
            {
                _rooms[index] = new Room();
                _rooms[index].RoomName =
                    StringType.FromObject(
                        _areFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").RoomName"));
                _rooms[index].EnvAudio =
                    IntegerType.FromObject(
                        _areFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").EnvAudio"));
                _rooms[index].AmbientScale =
                    SingleType.FromObject(
                        _areFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").AmbientScale"));
                _rooms[index].ForceRating =
                    IntegerType.FromObject(
                        _areFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").ForceRating"));
                _rooms[index].DisableWeather =
                    BooleanType.FromObject(
                        _areFile.GetNodeValue("Rooms(" + StringType.FromInteger(index) + ").DisableWeather"));
                checked
                {
                    ++index;
                }
            }

            LbRooms.DataSource = _rooms;
            LbRooms.DisplayMember = "Text";
        }

        private void ReadRooms()
        {
            int num = 0;
            int upperBound = _rooms.GetUpperBound(0);
            int index = num;
            while (index <= upperBound)
            {
                _areFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").EnvAudio", _rooms[index].EnvAudio);
                _areFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").AmbientScale",
                    _rooms[index].AmbientScale);
                _areFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").ForceRating",
                    _rooms[index].ForceRating);
                _areFile.SetNodeValue("Rooms(" + StringType.FromInteger(index) + ").DisableWeather",
                    _rooms[index].DisableWeather);
                checked
                {
                    ++index;
                }
            }
        }

        private void FillForm()
        {
            _ifoFile.SetTextBoxFromCExoLocStringNodeValue(TbModName, "Mod_Name");
            ModTag = StringType.FromObject(_ifoFile.GetNodeValue("Mod_Tag"));
            ModEntryArea = StringType.FromObject(_ifoFile.GetNodeValue("Mod_Entry_Area"));
            ModEntryX = SingleType.FromObject(_ifoFile.GetNodeValue("Mod_Entry_X"));
            ModEntryY = SingleType.FromObject(_ifoFile.GetNodeValue("Mod_Entry_Y"));
            ModEntryZ = SingleType.FromObject(_ifoFile.GetNodeValue("Mod_Entry_Z"));
            _origXPos = ModEntryX;
            _origYpos = ModEntryY;
            _origZpos = ModEntryZ;
            _origXOrientation = SingleType.FromObject(_ifoFile.GetNodeValue("Mod_Entry_Dir_X"));
            _origYOrientation = SingleType.FromObject(_ifoFile.GetNodeValue("Mod_Entry_Dir_Y"));
            SetupOrientationIndicators(_origXOrientation, _origYOrientation);
            ModMinutesPerHour = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_MinPerHour"));
            ModDawnHour = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_DawnHour"));
            ModDuskHour = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_DuskHour"));
            ModStartHour = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_StartHour"));
            ModStartDay = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_StartDay"));
            ModStartMonth = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_StartMonth"));
            ModStartYear = Convert.ToInt32(RuntimeHelpers.GetObjectValue(_ifoFile.GetNodeValue("Mod_StartYear")));
            ModXpScale = IntegerType.FromObject(_ifoFile.GetNodeValue("Mod_XPScale"));
            ModOnAcquirItem = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnAcquirItem"));
            ModOnActvtItem = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnActvtItem"));
            ModOnClientEntr = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnClientEntr"));
            ModOnClientLeav = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnClientLeav"));
            ModOnHeartbeat = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnHeartbeat"));
            ModOnModLoad = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnModLoad"));
            ModOnPlrDeath = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnPlrDeath"));
            ModOnPlrDying = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnPlrDying"));
            ModOnPlrLvlUp = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnPlrLvlUp"));
            ModOnSpawnBtnDn = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnSpawnBtnDn"));
            ModOnPlrRest = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnPlrRest"));
            ModOnUnAqreItem = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnUnAqreItem"));
            ModOnUsrDefined = StringType.FromObject(_ifoFile.GetNodeValue("Mod_OnUsrDefined"));
            _areFile.SetTextBoxFromCExoLocStringNodeValue(TbAreaName, "Name");
            _areFile.SetTextBoxToNodeValue(TbAreaTag, "Tag");
            FillComboBoxFrom2Da(CmbxCameraStyle, "name", "camerastyle", _chitinKey, _dialogTlk);
            if (!_areFile.SyncComboBox(CmbxCameraStyle, "CameraStyle"))
                _comboBoxSettingError = true;
            ChkbUnescapable.Checked = BooleanType.FromObject(_areFile.GetNodeValue("Unescapable"));
            ChkbDisableTransit.Checked = BooleanType.FromObject(_areFile.GetNodeValue("DisableTransit"));
            RbDayNightCycle.Checked = BooleanType.FromObject(_areFile.GetNodeValue("DayNightCycle"));
            if (!RbDayNightCycle.Checked)
            {
                if (ObjectType.ObjTst(_areFile.GetNodeValue("IsNight"), 1, false) == 0)
                    RbAlwaysNight.Checked = true;
                else
                    RbAlwaysDay.Checked = true;
            }

            DynAmbientColor =
                (uint) (_areFile.GetNodeValue("DynAmbientColor") ?? Activator.CreateInstance(typeof(uint)));
            _areFile.SetNumericUpDownToNodeValue(NudShadowOpacity, "ShadowOpacity");
            SunAmbientColor =
                (uint) (_areFile.GetNodeValue("SunAmbientColor") ?? Activator.CreateInstance(typeof(uint)));
            SunDiffuseColor =
                (uint) (_areFile.GetNodeValue("SunDiffuseColor") ?? Activator.CreateInstance(typeof(uint)));
            SunFogColor = (uint) (_areFile.GetNodeValue("SunFogColor") ?? Activator.CreateInstance(typeof(uint)));
            ChkbSunFogOn.Checked = BooleanType.FromObject(_areFile.GetNodeValue("SunFogOn"));
            TrkbarSunFogNear.Value = IntegerType.FromObject(_areFile.GetNodeValue("SunFogNear"));
            TrkbarSunFogFar.Value = IntegerType.FromObject(_areFile.GetNodeValue("SunFogFar"));
            ChkbAreaSunShadows.Checked = BooleanType.FromObject(_areFile.GetNodeValue("SunShadows"));
            MoonAmbientColor =
                (uint) (_areFile.GetNodeValue("MoonAmbientColor") ?? Activator.CreateInstance(typeof(uint)));
            MoonDiffuseColor =
                (uint) (_areFile.GetNodeValue("MoonDiffuseColor") ?? Activator.CreateInstance(typeof(uint)));
            MoonFogColor = (uint) (_areFile.GetNodeValue("MoonFogColor") ?? Activator.CreateInstance(typeof(uint)));
            ChkbMoonFogOn.Checked = BooleanType.FromObject(_areFile.GetNodeValue("MoonFogOn"));
            TrkbarMoonFogNear.Value = IntegerType.FromObject(_areFile.GetNodeValue("MoonFogNear"));
            TrkbarMoonFogFar.Value = IntegerType.FromObject(_areFile.GetNodeValue("MoonFogFar"));
            ChkbAreaMoonShadows.Checked = BooleanType.FromObject(_areFile.GetNodeValue("MoonShadows"));
            _areFile.SetNumericUpDownToNodeValue(NudChanceSnow, "ChanceSnow");
            _areFile.SetNumericUpDownToNodeValue(NudChanceRain, "ChanceRain");
            _areFile.SetNumericUpDownToNodeValue(NudChanceLightning, "ChanceLightning");
            FillComboBoxFrom2Da(CmbxAmbientSndDay, "description", "ambientsound", _chitinKey, _dialogTlk);
            if (!_gitFile.SyncComboBox(CmbxAmbientSndDay, "AreaProperties.AmbientSndDay"))
                _comboBoxSettingError = true;
            FillComboBoxFrom2Da(CmbxAmbientSndNight, "description", "ambientsound", _chitinKey, _dialogTlk);
            if (!_gitFile.SyncComboBox(CmbxAmbientSndNight, "AreaProperties.AmbientSndNight"))
                _comboBoxSettingError = true;
            TrkbarAmbientSndDayVol.Value =
                IntegerType.FromObject(_gitFile.GetNodeValue("AreaProperties.AmbientSndDayVol"));
            TrkbarAmbientSndNightVol.Value =
                IntegerType.FromObject(_gitFile.GetNodeValue("AreaProperties.AmbientSndNitVol"));
            FillComboBoxFrom2Da(CmbxEnvAudio, "label", "soundeax", _chitinKey, null);
            if (!_gitFile.SyncComboBox(CmbxEnvAudio, "AreaProperties.EnvAudio"))
                _comboBoxSettingError = true;
            FillComboBoxFrom2Da(CmbxMusicBattle, "description", "ambientmusic", _chitinKey, _dialogTlk);
            if (!_gitFile.SyncComboBox(CmbxMusicBattle, "AreaProperties.MusicBattle"))
                _comboBoxSettingError = true;
            FillComboBoxFrom2Da(CmbxMusicDay, "description", "ambientmusic", _chitinKey, _dialogTlk);
            if (!_gitFile.SyncComboBox(CmbxMusicDay, "AreaProperties.MusicDay"))
                _comboBoxSettingError = true;
            FillComboBoxFrom2Da(CmbxMusicNight, "description", "ambientmusic", _chitinKey, _dialogTlk);
            if (!_gitFile.SyncComboBox(CmbxMusicNight, "AreaProperties.MusicNight"))
                _comboBoxSettingError = true;
            NudMusicDelay.Value =
                DecimalType.FromObject(ObjectType.DivObj(_gitFile.GetNodeValue("AreaProperties.MusicDelay"), 1000));
            if (_comboBoxSettingError)
            {
                Interaction.MsgBox(
                    "One or more drop down menus could not be set.\n\nThis occurs when the file's index value for a menu exceeds the number of items on the menu itself.\n\nMenus with this error have been colored to make them more visible and will need to have a valid menu item selected.",
                    MsgBoxStyle.Critical, "Menu setting error");
            }

            _areFile.SetTextBoxToNodeValue(TbGrassTexName, "Grass_TexName");
            GrassAmbient = (uint) (_areFile.GetNodeValue("Grass_Ambient") ?? Activator.CreateInstance(typeof(uint)));
            GrassDiffuse = (uint) (_areFile.GetNodeValue("Grass_Diffuse") ?? Activator.CreateInstance(typeof(uint)));
            GrassEmissive = (uint) (_areFile.GetNodeValue("Grass_Emissive") ?? Activator.CreateInstance(typeof(uint)));
            _areFile.SetNumericUpDownToNodeValue(NudGrassQuadSize, "Grass_QuadSize");
            _areFile.SetNumericUpDownToNodeValue(NudGrassDensity, "Grass_Density");
            GrassProbLl = SingleType.FromObject(_areFile.GetNodeValue("Grass_Prob_LL"));
            GrassProbUl = SingleType.FromObject(_areFile.GetNodeValue("Grass_Prob_UL"));
            GrassProbLr = SingleType.FromObject(_areFile.GetNodeValue("Grass_Prob_LR"));
            GrassProbUr = SingleType.FromObject(_areFile.GetNodeValue("Grass_Prob_UR"));
            _areFile.SetTextBoxToNodeValue(TbAreaOnEnter, "OnEnter");
            _areFile.SetTextBoxToNodeValue(TbAreaOnExit, "OnExit");
            _areFile.SetTextBoxToNodeValue(TbAreaOnHeartbeat, "OnHeartbeat");
            _areFile.SetTextBoxToNodeValue(TbAreaOnUserDefined, "OnUserDefined");
            SetupRooms();
        }

        public void UpdateFiles()
        {
            _ifoFile.SetCExoLocStringNodeValueFromTextBox(TbModName, "Mod_Name", _modNameLang);
            _ifoFile.SetNodeValue("Mod_Tag", ModTag);
            _ifoFile.SetNodeValue("Mod_Entry_Area", ModEntryArea);
            _ifoFile.SetNodeValue("Mod_Entry_X", ModEntryX);
            _ifoFile.SetNodeValue("Mod_Entry_Y", ModEntryY);
            _ifoFile.SetNodeValue("Mod_Entry_Z", ModEntryZ);
            _ifoFile.SetNodeValue("Mod_Entry_Dir_X", XOrientation);
            _ifoFile.SetNodeValue("Mod_Entry_Dir_Y", YOrientation);
            _ifoFile.SetNodeValue("Mod_MinPerHour", ModMinutesPerHour);
            _ifoFile.SetNodeValue("Mod_DawnHour", ModDawnHour);
            _ifoFile.SetNodeValue("Mod_DuskHour", ModDuskHour);
            _ifoFile.SetNodeValue("Mod_StartHour", ModStartHour);
            _ifoFile.SetNodeValue("Mod_StartDay", ModStartDay);
            _ifoFile.SetNodeValue("Mod_StartMonth", ModStartMonth);
            _ifoFile.SetNodeValue("Mod_StartYear", ModStartYear);
            _ifoFile.SetNodeValue("Mod_XPScale", ModXpScale);
            _ifoFile.SetNodeValue("Mod_OnAcquirItem", ModOnAcquirItem);
            _ifoFile.SetNodeValue("Mod_OnActvtItem", ModOnActvtItem);
            _ifoFile.SetNodeValue("Mod_OnClientEntr", ModOnClientEntr);
            _ifoFile.SetNodeValue("Mod_OnClientLeav", ModOnClientLeav);
            _ifoFile.SetNodeValue("Mod_OnHeartbeat", ModOnHeartbeat);
            _ifoFile.SetNodeValue("Mod_OnModLoad", ModOnModLoad);
            _ifoFile.SetNodeValue("Mod_OnPlrDeath", ModOnPlrDeath);
            _ifoFile.SetNodeValue("Mod_OnPlrDying", ModOnPlrDying);
            _ifoFile.SetNodeValue("Mod_OnPlrLvlUp", ModOnPlrLvlUp);
            _ifoFile.SetNodeValue("Mod_OnSpawnBtnDn", ModOnSpawnBtnDn);
            _ifoFile.SetNodeValue("Mod_OnPlrRest", ModOnPlrRest);
            _ifoFile.SetNodeValue("Mod_OnUnAqreItem", ModOnUnAqreItem);
            _ifoFile.SetNodeValue("Mod_OnUsrDefined", ModOnUsrDefined);
            _ifoFile.SetCExoLocStringNodeValueFromTextBox(TbModDescription, "Mod_Description", _modDescriptionLang);
            _areFile.SetNodeValueFromTextBox(TbAreaTag, "Tag");
            _areFile.SetCExoLocStringNodeValueFromTextBox(TbAreaName, "Name", _areaNameLang);
            _areFile.SetNodeValueFromComboBox(CmbxCameraStyle, "CameraStyle");
            _areFile.SetNodeValue("Unescapable", ChkbUnescapable.Checked);
            _areFile.SetNodeValue("DisableTransit", ChkbDisableTransit.Checked);
            _areFile.SetNodeValue("DayNightCycle", RbDayNightCycle.Checked);
            _areFile.SetNodeValue("IsNight", RbAlwaysNight.Checked);
            _areFile.SetNodeValueFromNumericUpDown(NudShadowOpacity, "ShadowOpacity");
            _areFile.SetNodeValue("DynAmbientColor", DynAmbientColor);
            _areFile.SetNodeValue("SunAmbientColor", SunAmbientColor);
            _areFile.SetNodeValue("SunDiffuseColor", SunDiffuseColor);
            _areFile.SetNodeValue("SunFogColor", SunFogColor);
            _areFile.SetNodeValue("SunFogOn", ChkbSunFogOn.Checked);
            _areFile.SetNodeValue("SunFogNear", TrkbarSunFogNear.Value);
            _areFile.SetNodeValue("SunFogFar", TrkbarSunFogFar.Value);
            _areFile.SetNodeValue("SunShadows", ChkbAreaSunShadows.Checked);
            _areFile.SetNodeValue("MoonAmbientColor", MoonAmbientColor);
            _areFile.SetNodeValue("MoonDiffuseColor", MoonDiffuseColor);
            _areFile.SetNodeValue("MoonFogColor", MoonFogColor);
            _areFile.SetNodeValue("MoonFogOn", ChkbMoonFogOn.Checked);
            _areFile.SetNodeValue("MoonFogNear", TrkbarMoonFogNear.Value);
            _areFile.SetNodeValue("MoonFogFar", TrkbarMoonFogFar.Value);
            _areFile.SetNodeValue("MoonShadows", ChkbAreaMoonShadows.Checked);
            _areFile.SetNodeValueFromNumericUpDown(NudChanceSnow, "ChanceSnow");
            _areFile.SetNodeValueFromNumericUpDown(NudChanceRain, "ChanceRain");
            _areFile.SetNodeValueFromNumericUpDown(NudChanceLightning, "ChanceLightning");
            _areFile.SetNodeValueFromTextBox(TbGrassTexName, "Grass_TexName");
            _areFile.SetNodeValue("Grass_Ambient", GrassAmbient);
            _areFile.SetNodeValue("Grass_Diffuse", GrassDiffuse);
            _areFile.SetNodeValue("Grass_Emissive", GrassEmissive);
            _areFile.SetNodeValueFromNumericUpDown(NudGrassDensity, "Grass_Density");
            _areFile.SetNodeValueFromNumericUpDown(NudGrassQuadSize, "Grass_QuadSize");
            _areFile.SetNodeValue("Grass_Prob_LL", GrassProbLl);
            _areFile.SetNodeValue("Grass_Prob_UL", GrassProbUl);
            _areFile.SetNodeValue("Grass_Prob_LR", GrassProbLr);
            _areFile.SetNodeValue("Grass_Prob_UR", GrassProbUr);
            _areFile.SetNodeValueFromTextBox(TbAreaOnEnter, "OnEnter");
            _areFile.SetNodeValueFromTextBox(TbAreaOnExit, "OnExit");
            _areFile.SetNodeValueFromTextBox(TbAreaOnHeartbeat, "OnHeartbeat");
            _areFile.SetNodeValueFromTextBox(TbAreaOnUserDefined, "OnUserDefined");
            _gitFile.SetNodeValueFromComboBox(CmbxAmbientSndDay, "AreaProperties.AmbientSndDay");
            _gitFile.SetNodeValueFromComboBox(CmbxAmbientSndNight, "AreaProperties.AmbientSndNight");
            _gitFile.SetNodeValue("AreaProperties.AmbientSndDayVol", TrkbarAmbientSndDayVol.Value);
            _gitFile.SetNodeValue("AreaProperties.AmbientSndNitVol", TrkbarAmbientSndNightVol.Value);
            _gitFile.SetNodeValueFromComboBox(CmbxEnvAudio, "AreaProperties.EnvAudio");
            _gitFile.SetNodeValueFromComboBox(CmbxMusicBattle, "AreaProperties.MusicBattle");
            _gitFile.SetNodeValueFromComboBox(CmbxMusicDay, "AreaProperties.MusicDay");
            _gitFile.SetNodeValueFromComboBox(CmbxMusicNight, "AreaProperties.MusicNight");
            _gitFile.SetNodeValue("AreaProperties.MusicDelay",
                Decimal.Multiply(NudMusicDelay.Value, new Decimal(1000L)));
            ReadRooms();
        }

        private uint Color2Bgr(Color col)
        {
            return Convert.ToUInt32(checked(col.B * 65536 + col.G * 256 + col.R));
        }

        private Color Bgr2Color(uint bgr)
        {
            int int32 = Convert.ToInt32(bgr);
            return Color.FromArgb(byte.MaxValue, int32 & byte.MaxValue, (int32 & 65280) >> 8, (int32 & 16711680) >> 16);
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
                        fileStream.Read(numArray, 0, (int) fileStream.Length);
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
              //  numArray = BiffArchive
              //      .GetBiffResource(
              //          CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" +
               //         chitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
                Console.WriteLine("Read " + twoDaName + ".2da from 2da.bif");
            }

            return new Cls2Da(numArray);
        }

        private void FillComboBoxFrom2Da(ComboBox cmbx, string colName, string twoDaName, ClsChitinKey chitinKey,
            ClsDialogTlk dialogTlk)
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
                    checked
                    {
                        ++rowNumber;
                    }
                }
            }
        }

        public void SetupOrientationIndicators()
        {
            float num = (float) Math.Atan2(_yOrientation, _xOrientation);
            _xyAngle = Math.Atan2(_yOrientation, _xOrientation * -1.0) * 180.0 / Math.PI - 90.0;
            if (_xyAngle < 0.0)
                _xyAngle = _xyAngle + 360.0;
            NudXy.Value = new Decimal(_xyAngle);
            DrawXyOrientation();
        }

        public void SetupOrientationIndicators(float xOrientation, float yOrientation)
        {
            _xOrientation = xOrientation;
            _yOrientation = yOrientation;
            SetupOrientationIndicators();
        }

        private void DrawXyOrientation()
        {
            Graphics graphics = Graphics.FromImage(_bmpXy);
            graphics.FillEllipse(Brushes.White, 0, 0, 49, 49);
            graphics.DrawArc(new Pen(Color.Black), 0, 0, 49, 49, 0, 360);
            graphics.DrawPie(new Pen(Color.Black), 0.0f, 0.0f, 49f, 49f, (float) _xyAngle, 1f);
            _bmpXy.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PboxXy.Image = _bmpXy;
        }

        private void nudXY_KeyUp(object sender, KeyEventArgs e)
        {
            _xyAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
            DrawXyOrientation();
            _xOrientation = -(float) Math.Round(Math.Cos((_xyAngle + 90.0) / 180.0 * Math.PI), 5);
            _yOrientation = (float) Math.Round(Math.Sin((_xyAngle + 90.0) / 180.0 * Math.PI), 5);
        }

        private void nudXY_ValueChanged(object sender, EventArgs e)
        {
            _xyAngle = DoubleType.FromObject(LateBinding.LateGet(sender, null, "value", new object[0], null, null));
            DrawXyOrientation();
            _xOrientation = -(float) Math.Round(Math.Cos((_xyAngle + 90.0) / 180.0 * Math.PI), 5);
            _yOrientation = (float) Math.Round(Math.Sin((_xyAngle + 90.0) / 180.0 * Math.PI), 5);
        }

        private void SetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = ColorDialog1;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.AnyColor = true;
            colorDialog1.Color = ((Control) sender).BackColor;
            colorDialog1.FullOpen = true;
            if (ColorDialog1.ShowDialog(this) != DialogResult.OK)
                return;
            ((Control) sender).BackColor = ColorDialog1.Color;
        }

        private void trkbarXPScale_Scroll(object sender, EventArgs e)
        {
            NudXpScale.Value = new Decimal(((TrackBar) sender).Value);
        }

        private void nudXPScale_ValueChanged(object sender, EventArgs e)
        {
            TrkbarXpScale.Value = Convert.ToInt32(((NumericUpDown) sender).Value);
        }

        private void trkbarGrassDensityX10_Scroll(object sender, EventArgs e)
        {
            NudGrassDensity.Value = new Decimal(((TrackBar) sender).Value / 10.0);
        }

        private void nudGrassDensity_ValueChanged(object sender, EventArgs e)
        {
            TrkbarGrassDensityX10.Value =
                Convert.ToInt32(Decimal.Multiply(((NumericUpDown) sender).Value, new Decimal(10L)));
        }

        private void nudGrassProbXX_ValueChanged(object sender, EventArgs e)
        {
            float single = Convert.ToSingle(Decimal.Add(
                Decimal.Add(Decimal.Add(NudGrassProbLl.Value, NudGrassProbUl.Value), NudGrassProbLr.Value),
                NudGrassProbUr.Value));
            LblTotalGrassProbability.Text = "Total: " + StringType.FromSingle(single) + "%";
            if (single > 100.0 | single < 100.0)
                LblTotalGrassProbability.BackColor = Color.Tomato;
            else
                LblTotalGrassProbability.BackColor = DefaultBackColor;
        }

        private void DayNight_CheckedChanged(object sender, EventArgs e)
        {
            if (RbDayNightCycle.Checked)
            {
                GbMoon.Enabled = true;
                GbSun.Enabled = true;
            }
            else if (RbAlwaysNight.Checked)
            {
                GbMoon.Enabled = true;
                GbSun.Enabled = false;
            }
            else
            {
                GbMoon.Enabled = false;
                GbSun.Enabled = true;
            }
        }

        private void SunFogEnabled(object sender, EventArgs e)
        {
            TrkbarSunFogNear.Enabled = ChkbSunFogOn.Checked;
            TrkbarSunFogFar.Enabled = ChkbSunFogOn.Checked;
            LblSunFogFar.Enabled = ChkbSunFogOn.Checked;
            LblSunFogNear.Enabled = ChkbSunFogOn.Checked;
        }

        private void MoonFogEnabled(object sender, EventArgs e)
        {
            TrkbarMoonFogNear.Enabled = ChkbMoonFogOn.Checked;
            TrkbarMoonFogFar.Enabled = ChkbMoonFogOn.Checked;
            LblMoonFogFar.Enabled = ChkbMoonFogOn.Checked;
            LblMoonFogNear.Enabled = ChkbMoonFogOn.Checked;
        }

        private void lbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbRooms.SelectedIndex == -1)
                return;
            Room selectedItem = (Room) LbRooms.SelectedItem;
            CmbxRoomEnvAudio.SelectedIndexChanged -= cmbxRoomEnvAudio_SelectedIndexChanged;
            NudRoomAmbientScale.ValueChanged -= nudRoomAmbientScale_ValueChanged;
            NudRoomForceRating.ValueChanged -= nudRoomForceRating_ValueChanged;
            ChkbRoomDisableWeather.CheckedChanged -= chkbRoomDisableWeather_CheckedChanged;
            TbRoomName.Text = selectedItem.RoomName;
            NudRoomAmbientScale.Value = new Decimal(selectedItem.AmbientScale);
            NudRoomForceRating.Value = new Decimal(selectedItem.ForceRating);
            ChkbRoomDisableWeather.Checked = selectedItem.DisableWeather;
            CmbxRoomEnvAudio.SelectedIndex = selectedItem.EnvAudio;
            CmbxRoomEnvAudio.SelectedIndexChanged += cmbxRoomEnvAudio_SelectedIndexChanged;
            NudRoomAmbientScale.ValueChanged += nudRoomAmbientScale_ValueChanged;
            NudRoomForceRating.ValueChanged += nudRoomForceRating_ValueChanged;
            ChkbRoomDisableWeather.CheckedChanged += chkbRoomDisableWeather_CheckedChanged;
        }

        private void cmbxRoomEnvAudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            _rooms[LbRooms.SelectedIndex].EnvAudio = CmbxRoomEnvAudio.SelectedIndex;
        }

        private void nudRoomAmbientScale_ValueChanged(object sender, EventArgs e)
        {
            _rooms[LbRooms.SelectedIndex].AmbientScale = Convert.ToSingle(NudRoomAmbientScale.Value);
        }

        private void nudRoomForceRating_ValueChanged(object sender, EventArgs e)
        {
            _rooms[LbRooms.SelectedIndex].ForceRating = Convert.ToInt32(NudRoomForceRating.Value);
        }

        private void chkbRoomDisableWeather_CheckedChanged(object sender, EventArgs e)
        {
            _rooms[LbRooms.SelectedIndex].DisableWeather = ChkbRoomDisableWeather.Checked;
        }

        private void btnSetDescriptionLang_Click(object sender, EventArgs e)
        {
            frmCExoLocStringLanguagePicker stringLanguagePicker =
                new frmCExoLocStringLanguagePicker(_modDescriptionLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            _modDescriptionLang = stringLanguagePicker.LanguageID;
        }

        private void btnSetModNameLang_Click(object sender, EventArgs e)
        {
            frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(_modNameLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            _modNameLang = stringLanguagePicker.LanguageID;
        }

        private void btnSetAreaNameLang_Click(object sender, EventArgs e)
        {
            frmCExoLocStringLanguagePicker stringLanguagePicker = new frmCExoLocStringLanguagePicker(_areaNameLang);
            if (stringLanguagePicker.ShowDialog(this) != DialogResult.OK)
                return;
            _areaNameLang = stringLanguagePicker.LanguageID;
        }

        private class Room
        {
            public string RoomName;
            public int EnvAudio;
            public int ForceRating;
            public float AmbientScale;
            public bool DisableWeather;
        }
    }
}