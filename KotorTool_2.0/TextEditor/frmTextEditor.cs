// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmTextEditor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.Forms;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using mystuff.Controls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.TextEditor
{
    public class frmTextEditor : Form
    {
        [AccessedThroughProperty("MenuItem3")] private MenuItem _MenuItem3;

        [AccessedThroughProperty("miSelectAll")]
        private MenuItem _miSelectAll;

        [AccessedThroughProperty("MenuItem6")] private MenuItem _MenuItem6;
        [AccessedThroughProperty("MenuItem4")] private MenuItem _MenuItem4;
        [AccessedThroughProperty("MenuItem2")] private MenuItem _MenuItem2;
        [AccessedThroughProperty("miQuit")] private MenuItem _miQuit;
        [AccessedThroughProperty("MenuItem5")] private MenuItem _MenuItem5;
        [AccessedThroughProperty("tbGeneric")] private LinenumberTextBox _tbGeneric;

        [AccessedThroughProperty("miPlaceablesList")]
        private MenuItem _miPlaceablesList;

        [AccessedThroughProperty("MenuItem9")] private MenuItem _MenuItem9;
        [AccessedThroughProperty("MenuItem1")] private MenuItem _MenuItem1;

        [AccessedThroughProperty("miEncountersList")]
        private MenuItem _miEncountersList;

        [AccessedThroughProperty("MenuItem8")] private MenuItem _MenuItem8;

        [AccessedThroughProperty("cmiShowDefinition")]
        private MenuItem _cmiShowDefinition;

        [AccessedThroughProperty("miFind")] private MenuItem _miFind;
        [AccessedThroughProperty("MainMenu1")] private MainMenu _MainMenu1;

        [AccessedThroughProperty("miTriggersList")]
        private MenuItem _miTriggersList;

        [AccessedThroughProperty("miFont")] private MenuItem _miFont;

        [AccessedThroughProperty("miFindAgain")]
        private MenuItem _miFindAgain;

        [AccessedThroughProperty("cmText")] private ContextMenu _cmText;
        [AccessedThroughProperty("miSaveAs")] private MenuItem _miSaveAs;

        [AccessedThroughProperty("miWordWrap")]
        private MenuItem _miWordWrap;

        [AccessedThroughProperty("lblMatches")]
        private Label _lblMatches;

        [AccessedThroughProperty("miUndo")] private MenuItem _miUndo;

        [AccessedThroughProperty("pnlFunctions")]
        private Panel _pnlFunctions;

        [AccessedThroughProperty("tbFuncDecl")]
        private TextBox _tbFuncDecl;

        [AccessedThroughProperty("tbFuncNameFilter")]
        private TextBox _tbFuncNameFilter;

        [AccessedThroughProperty("lbFunctions")]
        private ListBox _lbFunctions;

        [AccessedThroughProperty("miCompile")] private MenuItem _miCompile;
        [AccessedThroughProperty("miOpen")] private MenuItem _miOpen;

        [AccessedThroughProperty("miWaypointsList")]
        private MenuItem _miWaypointsList;

        [AccessedThroughProperty("miScriptIsK2")]
        private MenuItem _miScriptIsK2;

        [AccessedThroughProperty("miScriptIsK1")]
        private MenuItem _miScriptIsK1;

        [AccessedThroughProperty("miRedo")] private MenuItem _miRedo;

        [AccessedThroughProperty("miPageSetup")]
        private MenuItem _miPageSetup;

        [AccessedThroughProperty("miMerchantList")]
        private MenuItem _miMerchantList;

        [AccessedThroughProperty("miCut")] private MenuItem _miCut;

        [AccessedThroughProperty("miDoorsList")]
        private MenuItem _miDoorsList;

        [AccessedThroughProperty("miPrint")] private MenuItem _miPrint;

        [AccessedThroughProperty("MenuItem12")]
        private MenuItem _MenuItem12;

        [AccessedThroughProperty("miCopy")] private MenuItem _miCopy;
        [AccessedThroughProperty("miSave")] private MenuItem _miSave;

        [AccessedThroughProperty("miCreatureList")]
        private MenuItem _miCreatureList;

        [AccessedThroughProperty("miCameras")] private MenuItem _miCameras;
        [AccessedThroughProperty("MenuItem7")] private MenuItem _MenuItem7;
        [AccessedThroughProperty("miPaste")] private MenuItem _miPaste;

        [AccessedThroughProperty("miSoundsList")]
        private MenuItem _miSoundsList;

        [AccessedThroughProperty("Label1")] private Label _Label1;
        private IContainer components;
        private Options.ConfigOptions CurrentSettings;
        private string fname;
        private bool m_rtfMode;
        private int g_findPos;
        private string g_findString;
        private bool g_searchup;
        private bool g_matchcase;
        private bool g_matchwholeword;
        private RichTextBoxFinds g_searchoptions;
        private PageSettings storedPageSettings;
        private StringReader streamToPrint;
        private Font printFont;
        private int _KotorVersionIndex;
        private bool _IsDirectEdit;
        private string _EditingFilePath;
        private func[] funcs;


        internal virtual LinenumberTextBox tbGeneric
        {
            get => _tbGeneric;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbGeneric != null)
                {
                    _tbGeneric.MouseDown -= tbGeneric_MouseDown;
                    _tbGeneric.LostFocus -= tbGeneric_LostFocus;
                    _tbGeneric.GotFocus -= tbGeneric_GotFocus;
                    _tbGeneric.MouseMove -= tbGeneric_MouseMove;
                }

                _tbGeneric = value;
                if (_tbGeneric == null)
                    return;
                _tbGeneric.MouseDown += tbGeneric_MouseDown;
                _tbGeneric.LostFocus += tbGeneric_LostFocus;
                _tbGeneric.GotFocus += tbGeneric_GotFocus;
                _tbGeneric.MouseMove += tbGeneric_MouseMove;
            }
        }

        internal virtual MainMenu MainMenu1
        {
            get => _MainMenu1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem1 == null)
                    ;
                _MenuItem1 = value;
                if (_MenuItem1 != null)
                    ;
            }
        }

        internal virtual MenuItem MenuItem2
        {
            get => _MenuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem2 == null)
                    ;
                _MenuItem2 = value;
                if (_MenuItem2 != null)
                    ;
            }
        }

        internal virtual MenuItem miFind
        {
            get => _miFind;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miFind != null)
                    _miFind.Click -= miFind_Click;
                _miFind = value;
                if (_miFind == null)
                    return;
                _miFind.Click += miFind_Click;
            }
        }

        internal virtual MenuItem miFindAgain
        {
            get => _miFindAgain;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miFindAgain != null)
                    _miFindAgain.Click -= miFindAgain_Click;
                _miFindAgain = value;
                if (_miFindAgain == null)
                    return;
                _miFindAgain.Click += miFindAgain_Click;
            }
        }

        internal virtual MenuItem miUndo
        {
            get => _miUndo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miUndo != null)
                    _miUndo.Click -= miUndo_Click;
                _miUndo = value;
                if (_miUndo == null)
                    return;
                _miUndo.Click += miUndo_Click;
            }
        }

        internal virtual MenuItem miRedo
        {
            get => _miRedo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miRedo != null)
                    _miRedo.Click -= miRedo_Click;
                _miRedo = value;
                if (_miRedo == null)
                    return;
                _miRedo.Click += miRedo_Click;
            }
        }

        internal virtual MenuItem MenuItem3
        {
            get => _MenuItem3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem3 == null)
                    ;
                _MenuItem3 = value;
                if (_MenuItem3 != null)
                    ;
            }
        }

        internal virtual MenuItem miCut
        {
            get => _miCut;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCut != null)
                    _miCut.Click -= miCut_Click;
                _miCut = value;
                if (_miCut == null)
                    return;
                _miCut.Click += miCut_Click;
            }
        }

        internal virtual MenuItem MenuItem7
        {
            get => _MenuItem7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem7 == null)
                    ;
                _MenuItem7 = value;
                if (_MenuItem7 != null)
                    ;
            }
        }

        internal virtual MenuItem MenuItem9
        {
            get => _MenuItem9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem9 == null)
                    ;
                _MenuItem9 = value;
                if (_MenuItem9 != null)
                    ;
            }
        }

        internal virtual MenuItem miCopy
        {
            get => _miCopy;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCopy != null)
                    _miCopy.Click -= miCopy_Click;
                _miCopy = value;
                if (_miCopy == null)
                    return;
                _miCopy.Click += miCopy_Click;
            }
        }

        internal virtual MenuItem miPaste
        {
            get => _miPaste;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miPaste != null)
                    _miPaste.Click -= miPaste_Click;
                _miPaste = value;
                if (_miPaste == null)
                    return;
                _miPaste.Click += miPaste_Click;
            }
        }

        internal virtual MenuItem miSelectAll
        {
            get => _miSelectAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSelectAll != null)
                    _miSelectAll.Click -= miSelectAll_Click;
                _miSelectAll = value;
                if (_miSelectAll == null)
                    return;
                _miSelectAll.Click += miSelectAll_Click;
            }
        }

        internal virtual MenuItem miSaveAs
        {
            get => _miSaveAs;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSaveAs != null)
                    _miSaveAs.Click -= miSaveAs_Click;
                _miSaveAs = value;
                if (_miSaveAs == null)
                    return;
                _miSaveAs.Click += miSaveAs_Click;
            }
        }

        internal virtual MenuItem MenuItem4
        {
            get => _MenuItem4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem4 == null)
                    ;
                _MenuItem4 = value;
                if (_MenuItem4 != null)
                    ;
            }
        }

        internal virtual MenuItem miQuit
        {
            get => _miQuit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miQuit != null)
                    _miQuit.Click -= miQuit_Click;
                _miQuit = value;
                if (_miQuit == null)
                    return;
                _miQuit.Click += miQuit_Click;
            }
        }

        internal virtual MenuItem miOpen
        {
            get => _miOpen;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miOpen != null)
                    _miOpen.Click -= miOpen_Click;
                _miOpen = value;
                if (_miOpen == null)
                    return;
                _miOpen.Click += miOpen_Click;
            }
        }

        internal virtual MenuItem miPrint
        {
            get => _miPrint;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miPrint != null)
                    _miPrint.Click -= miPrint_Click;
                _miPrint = value;
                if (_miPrint == null)
                    return;
                _miPrint.Click += miPrint_Click;
            }
        }

        internal virtual MenuItem miPageSetup
        {
            get => _miPageSetup;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miPageSetup != null)
                    _miPageSetup.Click -= miPageSetup_Click;
                _miPageSetup = value;
                if (_miPageSetup == null)
                    return;
                _miPageSetup.Click += miPageSetup_Click;
            }
        }

        internal virtual MenuItem MenuItem5
        {
            get => _MenuItem5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem5 == null)
                    ;
                _MenuItem5 = value;
                if (_MenuItem5 != null)
                    ;
            }
        }

        internal virtual MenuItem miFont
        {
            get => _miFont;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miFont != null)
                    _miFont.Click -= miFont_Click;
                _miFont = value;
                if (_miFont == null)
                    return;
                _miFont.Click += miFont_Click;
            }
        }

        internal virtual MenuItem miWordWrap
        {
            get => _miWordWrap;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miWordWrap != null)
                    _miWordWrap.Click -= miWordWrap_Click;
                _miWordWrap = value;
                if (_miWordWrap == null)
                    return;
                _miWordWrap.Click += miWordWrap_Click;
            }
        }

        internal virtual MenuItem MenuItem6
        {
            get => _MenuItem6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem6 == null)
                    ;
                _MenuItem6 = value;
                if (_MenuItem6 != null)
                    ;
            }
        }

        internal virtual MenuItem miPlaceablesList
        {
            get => _miPlaceablesList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miPlaceablesList != null)
                    _miPlaceablesList.Click -= miPlaceablesList_Click;
                _miPlaceablesList = value;
                if (_miPlaceablesList == null)
                    return;
                _miPlaceablesList.Click += miPlaceablesList_Click;
            }
        }

        internal virtual MenuItem miEncountersList
        {
            get => _miEncountersList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miEncountersList != null)
                    _miEncountersList.Click -= miEncountersList_Click;
                _miEncountersList = value;
                if (_miEncountersList == null)
                    return;
                _miEncountersList.Click += miEncountersList_Click;
            }
        }

        internal virtual MenuItem miWaypointsList
        {
            get => _miWaypointsList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miWaypointsList != null)
                    _miWaypointsList.Click -= miWaypointsList_Click;
                _miWaypointsList = value;
                if (_miWaypointsList == null)
                    return;
                _miWaypointsList.Click += miWaypointsList_Click;
            }
        }

        internal virtual MenuItem miSoundsList
        {
            get => _miSoundsList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSoundsList != null)
                    _miSoundsList.Click -= miSoundsList_Click;
                _miSoundsList = value;
                if (_miSoundsList == null)
                    return;
                _miSoundsList.Click += miSoundsList_Click;
            }
        }

        internal virtual MenuItem miTriggersList
        {
            get => _miTriggersList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miTriggersList != null)
                    _miTriggersList.Click -= miTriggersList_Click;
                _miTriggersList = value;
                if (_miTriggersList == null)
                    return;
                _miTriggersList.Click += miTriggersList_Click;
            }
        }

        internal virtual MenuItem miDoorsList
        {
            get => _miDoorsList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miDoorsList != null)
                    _miDoorsList.Click -= miDoorsList_Click;
                _miDoorsList = value;
                if (_miDoorsList == null)
                    return;
                _miDoorsList.Click += miDoorsList_Click;
            }
        }

        internal virtual MenuItem miCameras
        {
            get => _miCameras;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCameras != null)
                    _miCameras.Click -= miCameras_Click;
                _miCameras = value;
                if (_miCameras == null)
                    return;
                _miCameras.Click += miCameras_Click;
            }
        }

        internal virtual MenuItem miCreatureList
        {
            get => _miCreatureList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCreatureList != null)
                    _miCreatureList.Click -= miCreatureList_Click;
                _miCreatureList = value;
                if (_miCreatureList == null)
                    return;
                _miCreatureList.Click += miCreatureList_Click;
            }
        }

        internal virtual MenuItem miMerchantList
        {
            get => _miMerchantList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miMerchantList != null)
                    _miMerchantList.Click -= miMerchantList_Click;
                _miMerchantList = value;
                if (_miMerchantList == null)
                    return;
                _miMerchantList.Click += miMerchantList_Click;
            }
        }

        internal virtual MenuItem miSave
        {
            get => _miSave;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSave != null)
                    _miSave.Click -= miSave_Click;
                _miSave = value;
                if (_miSave == null)
                    return;
                _miSave.Click += miSave_Click;
            }
        }

        internal virtual MenuItem MenuItem8
        {
            get => _MenuItem8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem8 == null)
                    ;
                _MenuItem8 = value;
                if (_MenuItem8 != null)
                    ;
            }
        }

        internal virtual MenuItem miScriptIsK1
        {
            get => _miScriptIsK1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miScriptIsK1 != null)
                    _miScriptIsK1.Click -= miScriptIsK1_Click;
                _miScriptIsK1 = value;
                if (_miScriptIsK1 == null)
                    return;
                _miScriptIsK1.Click += miScriptIsK1_Click;
            }
        }

        internal virtual MenuItem miScriptIsK2
        {
            get => _miScriptIsK2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miScriptIsK2 != null)
                    _miScriptIsK2.Click -= miScriptIsK2_Click;
                _miScriptIsK2 = value;
                if (_miScriptIsK2 == null)
                    return;
                _miScriptIsK2.Click += miScriptIsK2_Click;
            }
        }

        internal virtual MenuItem MenuItem12
        {
            get => _MenuItem12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem12 == null)
                    ;
                _MenuItem12 = value;
                if (_MenuItem12 != null)
                    ;
            }
        }

        internal virtual MenuItem miCompile
        {
            get => _miCompile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCompile != null)
                    _miCompile.Click -= miCompile_Click;
                _miCompile = value;
                if (_miCompile == null)
                    return;
                _miCompile.Click += miCompile_Click;
            }
        }

        internal virtual ListBox lbFunctions
        {
            get => _lbFunctions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbFunctions != null)
                {
                    _lbFunctions.SelectedIndexChanged -= lbFunctions_SelectedIndexChanged;
                    _lbFunctions.DoubleClick -= lbFunctions_DoubleClick;
                    _lbFunctions.Click -= lbFunctions_Click;
                }

                _lbFunctions = value;
                if (_lbFunctions == null)
                    return;
                _lbFunctions.SelectedIndexChanged += lbFunctions_SelectedIndexChanged;
                _lbFunctions.DoubleClick += lbFunctions_DoubleClick;
                _lbFunctions.Click += lbFunctions_Click;
            }
        }

        internal virtual TextBox tbFuncNameFilter
        {
            get => _tbFuncNameFilter;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbFuncNameFilter != null)
                    _tbFuncNameFilter.TextChanged -= tbFuncNameFilter_TextChanged;
                _tbFuncNameFilter = value;
                if (_tbFuncNameFilter == null)
                    return;
                _tbFuncNameFilter.TextChanged += tbFuncNameFilter_TextChanged;
            }
        }

        internal virtual TextBox tbFuncDecl
        {
            get => _tbFuncDecl;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbFuncDecl == null)
                    ;
                _tbFuncDecl = value;
                if (_tbFuncDecl != null)
                    ;
            }
        }

        internal virtual Label Label1
        {
            get => _Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 == null)
                    ;
                _Label1 = value;
                if (_Label1 != null)
                    ;
            }
        }

        internal virtual Panel pnlFunctions
        {
            get => _pnlFunctions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlFunctions == null)
                    ;
                _pnlFunctions = value;
                if (_pnlFunctions != null)
                    ;
            }
        }

        internal virtual Label lblMatches
        {
            get => _lblMatches;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblMatches == null)
                    ;
                _lblMatches = value;
                if (_lblMatches != null)
                    ;
            }
        }

        internal virtual ContextMenu cmText
        {
            get => _cmText;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmText == null)
                    ;
                _cmText = value;
                if (_cmText != null)
                    ;
            }
        }

        internal virtual MenuItem cmiShowDefinition
        {
            get => _cmiShowDefinition;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiShowDefinition != null)
                    _cmiShowDefinition.Click -= cmiShowDefinition_Click;
                _cmiShowDefinition = value;
                if (_cmiShowDefinition == null)
                    return;
                _cmiShowDefinition.Click += cmiShowDefinition_Click;
            }
        }

        public string EditingFilePath
        {
            get => _EditingFilePath;
            set => _EditingFilePath = value;
        }

        public bool DirectEdit
        {
            get => _IsDirectEdit;
            set => _IsDirectEdit = value;
        }

        public string Filename
        {
            get => fname;
            set
            {
                fname = value;
                Text = "Text Editor - " + value;
            }
        }

        public bool RTFMode
        {
            get => m_rtfMode;
            set => m_rtfMode = value;
        }

        public int KotorVersionIndex
        {
            get => _KotorVersionIndex;
            set
            {
                _KotorVersionIndex = value;
                miCompile.Enabled = true;
                if (_KotorVersionIndex == 0)
                {
                    miScriptIsK1.Checked = true;
                }
                else
                {
                    if (_KotorVersionIndex != 1)
                        return;
                    miScriptIsK2.Checked = true;
                }
            }
        }

        public frmTextEditor()
        {
            Load += frmTextEditor_Load;
            Closing += frmTextEditor_Closing;
            g_findPos = 0;
            storedPageSettings = null;
            funcs = new func[877];
            InitializeComponent();
            miWordWrap.Checked = ConfigOptions.Toggles.TextEditorWordWrap;
            tbGeneric.WordWrap = miWordWrap.Checked;
            CurrentSettings = UserSettings.GetSettings();
        }

        public frmTextEditor(string filename, bool IsDirectEdit = false, string EditingPath = "")
            : this()
        {
            fname = filename;
            Text = "Text Editor - " + fname;
            if (!IsDirectEdit) return;
            _IsDirectEdit = true;
            _EditingFilePath = EditingPath;
        }

        public frmTextEditor(string EditingPath, int KotorVerIndex, bool IsDirectEdit = false)
            : this()
        {
            RTFMode = false;
            KotorVersionIndex = KotorVerIndex;
            _IsDirectEdit = IsDirectEdit;
            _EditingFilePath = EditingPath;
            StreamReader streamReader = new StreamReader(_EditingFilePath);
            tbGeneric.Text = streamReader.ReadToEnd();
            tbGeneric.SelectionLength = 0;
            streamReader.Close();
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
            ResourceManager resourceManager = new ResourceManager(typeof(frmTextEditor));
            tbGeneric = new LinenumberTextBox();
            MainMenu1 = new MainMenu();
            MenuItem1 = new MenuItem();
            miOpen = new MenuItem();
            miSave = new MenuItem();
            miSaveAs = new MenuItem();
            MenuItem4 = new MenuItem();
            miPageSetup = new MenuItem();
            miPrint = new MenuItem();
            miQuit = new MenuItem();
            MenuItem2 = new MenuItem();
            miUndo = new MenuItem();
            miRedo = new MenuItem();
            MenuItem3 = new MenuItem();
            miCut = new MenuItem();
            miCopy = new MenuItem();
            miPaste = new MenuItem();
            MenuItem9 = new MenuItem();
            miSelectAll = new MenuItem();
            MenuItem7 = new MenuItem();
            miFind = new MenuItem();
            miFindAgain = new MenuItem();
            MenuItem5 = new MenuItem();
            miWordWrap = new MenuItem();
            miFont = new MenuItem();
            MenuItem6 = new MenuItem();
            miCameras = new MenuItem();
            miCreatureList = new MenuItem();
            miDoorsList = new MenuItem();
            miEncountersList = new MenuItem();
            miMerchantList = new MenuItem();
            miPlaceablesList = new MenuItem();
            miSoundsList = new MenuItem();
            miTriggersList = new MenuItem();
            miWaypointsList = new MenuItem();
            MenuItem8 = new MenuItem();
            miScriptIsK1 = new MenuItem();
            miScriptIsK2 = new MenuItem();
            MenuItem12 = new MenuItem();
            miCompile = new MenuItem();
            lbFunctions = new ListBox();
            tbFuncNameFilter = new TextBox();
            tbFuncDecl = new TextBox();
            pnlFunctions = new Panel();
            Label1 = new Label();
            lblMatches = new Label();
            cmText = new ContextMenu();
            cmiShowDefinition = new MenuItem();
            pnlFunctions.SuspendLayout();
            SuspendLayout();
            tbGeneric.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbGeneric.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            //  LinenumberTextBox tbGeneric1 = this.tbGeneric;
            Point point1 = new Point(16, 8);
            Point point2 = point1;
            tbGeneric.Location = point2;
            tbGeneric.Name = "tbGeneric";
            tbGeneric.ShowSelectionMargin = true;
            //  LinenumberTextBox tbGeneric2 = this.tbGeneric;
            Size size1 = new Size(904, 584);
            Size size2 = size1;
            tbGeneric.Size = size2;
            tbGeneric.TabIndex = 5;
            tbGeneric.Text = "";
            MainMenu1.MenuItems.AddRange(new MenuItem[5]
            {
                MenuItem1,
                MenuItem2,
                MenuItem5,
                MenuItem6,
                MenuItem8
            });
            MenuItem1.Index = 0;
            MenuItem1.MenuItems.AddRange(new MenuItem[7]
            {
                miOpen,
                miSave,
                miSaveAs,
                MenuItem4,
                miPageSetup,
                miPrint,
                miQuit
            });
            MenuItem1.Text = "&File";
            miOpen.Index = 0;
            miOpen.Shortcut = Shortcut.CtrlO;
            miOpen.Text = "&Open...";
            miSave.Index = 1;
            miSave.Shortcut = Shortcut.CtrlS;
            miSave.Text = "&Save";
            miSaveAs.Index = 2;
            miSaveAs.Shortcut = Shortcut.CtrlShiftS;
            miSaveAs.Text = "Save &As...";
            MenuItem4.Index = 3;
            MenuItem4.Text = "-";
            miPageSetup.Index = 4;
            miPageSetup.Text = "Page Set&up";
            miPrint.Index = 5;
            miPrint.Shortcut = Shortcut.CtrlP;
            miPrint.Text = "&Print";
            miQuit.Index = 6;
            miQuit.Shortcut = Shortcut.CtrlQ;
            miQuit.Text = "&Quit";
            MenuItem2.Index = 1;
            MenuItem2.MenuItems.AddRange(new MenuItem[11]
            {
                miUndo,
                miRedo,
                MenuItem3,
                miCut,
                miCopy,
                miPaste,
                MenuItem9,
                miSelectAll,
                MenuItem7,
                miFind,
                miFindAgain
            });
            MenuItem2.Text = "&Edit";
            miUndo.Index = 0;
            miUndo.Shortcut = Shortcut.CtrlZ;
            miUndo.Text = "&Undo";
            miRedo.Index = 1;
            miRedo.Shortcut = Shortcut.CtrlY;
            miRedo.Text = "&Redo";
            MenuItem3.Index = 2;
            MenuItem3.Text = "-";
            miCut.Index = 3;
            miCut.Shortcut = Shortcut.CtrlX;
            miCut.Text = "Cu&t";
            miCopy.Index = 4;
            miCopy.Shortcut = Shortcut.CtrlC;
            miCopy.Text = "&Copy";
            miPaste.Index = 5;
            miPaste.Shortcut = Shortcut.CtrlV;
            miPaste.Text = "&Paste";
            MenuItem9.Index = 6;
            MenuItem9.Text = "-";
            miSelectAll.Index = 7;
            miSelectAll.Shortcut = Shortcut.CtrlA;
            miSelectAll.Text = "Select &All";
            MenuItem7.Index = 8;
            MenuItem7.Text = "-";
            miFind.Index = 9;
            miFind.Shortcut = Shortcut.CtrlF;
            miFind.Text = "&Find...";
            miFindAgain.Index = 10;
            miFindAgain.Shortcut = Shortcut.F3;
            miFindAgain.Text = "Find &Next";
            MenuItem5.Index = 2;
            MenuItem5.MenuItems.AddRange(new MenuItem[2]
            {
                miWordWrap,
                miFont
            });
            MenuItem5.Text = "F&ormat";
            miWordWrap.Checked = true;
            miWordWrap.Index = 0;
            miWordWrap.Text = "&Word Wrap";
            miFont.Index = 1;
            miFont.Text = "&Font...";
            MenuItem6.Index = 3;
            MenuItem6.MenuItems.AddRange(new MenuItem[9]
            {
                miCameras,
                miCreatureList,
                miDoorsList,
                miEncountersList,
                miMerchantList,
                miPlaceablesList,
                miSoundsList,
                miTriggersList,
                miWaypointsList
            });
            MenuItem6.Text = "&Quick";
            miCameras.Index = 0;
            miCameras.Text = "C&ameras";
            miCreatureList.Index = 1;
            miCreatureList.Text = "&Creature List";
            miDoorsList.Index = 2;
            miDoorsList.Text = "&Doors List";
            miEncountersList.Index = 3;
            miEncountersList.Text = "&Encounters List";
            miMerchantList.Index = 4;
            miMerchantList.Text = "&Merchant List";
            miPlaceablesList.Index = 5;
            miPlaceablesList.Text = "&Placeables List";
            miSoundsList.Index = 6;
            miSoundsList.Text = "&Sounds List";
            miTriggersList.Index = 7;
            miTriggersList.Text = "&Triggers List";
            miWaypointsList.Index = 8;
            miWaypointsList.Text = "&Waypoints List";
            MenuItem8.Index = 4;
            MenuItem8.MenuItems.AddRange(new MenuItem[4]
            {
                miScriptIsK1,
                miScriptIsK2,
                MenuItem12,
                miCompile
            });
            MenuItem8.Text = "&Script";
            miScriptIsK1.Index = 0;
            miScriptIsK1.Text = "Script is for KotOR I";
            miScriptIsK2.Index = 1;
            miScriptIsK2.Text = "Script is for KotOR II";
            MenuItem12.Index = 2;
            MenuItem12.Text = "-";
            miCompile.Enabled = false;
            miCompile.Index = 3;
            miCompile.Shortcut = Shortcut.F5;
            miCompile.Text = "&Compile";
            lbFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ListBox lbFunctions1 = lbFunctions;
            point1 = new Point(700, 40);
            Point point3 = point1;
            lbFunctions1.Location = point3;
            lbFunctions.Name = "lbFunctions";
            ListBox lbFunctions2 = lbFunctions;
            size1 = new Size(208, 82);
            Size size3 = size1;
            lbFunctions2.Size = size3;
            lbFunctions.TabIndex = 6;
            tbFuncNameFilter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TextBox tbFuncNameFilter1 = tbFuncNameFilter;
            point1 = new Point(700, 16);
            Point point4 = point1;
            tbFuncNameFilter1.Location = point4;
            tbFuncNameFilter.Name = "tbFuncNameFilter";
            TextBox tbFuncNameFilter2 = tbFuncNameFilter;
            size1 = new Size(208, 20);
            Size size4 = size1;
            tbFuncNameFilter2.Size = size4;
            tbFuncNameFilter.TabIndex = 7;
            tbFuncNameFilter.Text = "";
            tbFuncDecl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbFuncDecl1 = tbFuncDecl;
            point1 = new Point(8, 1);
            Point point5 = point1;
            tbFuncDecl1.Location = point5;
            tbFuncDecl.Multiline = true;
            tbFuncDecl.Name = "tbFuncDecl";
            tbFuncDecl.ScrollBars = ScrollBars.Vertical;
            TextBox tbFuncDecl2 = tbFuncDecl;
            size1 = new Size(680, 120);
            Size size5 = size1;
            tbFuncDecl2.Size = size5;
            tbFuncDecl.TabIndex = 8;
            tbFuncDecl.Text = "";
            pnlFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlFunctions.Controls.Add(tbFuncDecl);
            pnlFunctions.Controls.Add(tbFuncNameFilter);
            pnlFunctions.Controls.Add(lbFunctions);
            pnlFunctions.Controls.Add(Label1);
            pnlFunctions.Controls.Add(lblMatches);
            Panel pnlFunctions1 = pnlFunctions;
            point1 = new Point(8, 472);
            Point point6 = point1;
            pnlFunctions1.Location = point6;
            pnlFunctions.Name = "pnlFunctions";
            Panel pnlFunctions2 = pnlFunctions;
            size1 = new Size(912, 136);
            Size size6 = size1;
            pnlFunctions2.Size = size6;
            pnlFunctions.TabIndex = 10;
            pnlFunctions.Visible = false;
            Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Label label1_1 = Label1;
            point1 = new Point(700, 0);
            Point point7 = point1;
            label1_1.Location = point7;
            Label1.Name = "Label1";
            Label label1_2 = Label1;
            size1 = new Size(76, 16);
            Size size7 = size1;
            label1_2.Size = size7;
            Label1.TabIndex = 9;
            Label1.Text = "Function filter";
            lblMatches.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMatches.ForeColor = SystemColors.Highlight;
            Label lblMatches1 = lblMatches;
            point1 = new Point(824, 0);
            Point point8 = point1;
            lblMatches1.Location = point8;
            lblMatches.Name = "lblMatches";
            Label lblMatches2 = lblMatches;
            size1 = new Size(76, 16);
            Size size8 = size1;
            lblMatches2.Size = size8;
            lblMatches.TabIndex = 9;
            lblMatches.Text = "Matches: ";
            cmText.MenuItems.AddRange(new MenuItem[1]
            {
                cmiShowDefinition
            });
            cmiShowDefinition.Index = 0;
            cmiShowDefinition.Text = "Show Definition...";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(936, 601);
            ClientSize = size1;
            Controls.Add(tbGeneric);
            Controls.Add(pnlFunctions);
            Icon = (Icon) resourceManager.GetObject("$this.Icon");
            Menu = MainMenu1;
            Name = "frmTextEditor";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Text Editor";
            pnlFunctions.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tbGeneric_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > 0 & e.X < 7) Cursor.Current = Cursors.Arrow;
            else Cursor.Current = Cursors.IBeam;
        }


        private void SaveSettings()
        {
            if (WindowState == FormWindowState.Maximized || WindowState == FormWindowState.Minimized) WindowState = FormWindowState.Normal;
            ConfigOptions.WindowSettings.TextEditorWindowLoc = ((Control) this).Location;
            ConfigOptions.WindowSettings.TextEditorWindowSize = Size;
            UserSettings.SaveSettings(CurrentSettings);
        }

        private void frmTextEditor_Load(object sender, EventArgs e)
        {
        
        }

        private void frmTextEditor_Closing(object sender, CancelEventArgs e)
        {
            SaveSettings();
        }

        private void miFind_Click(object sender, EventArgs e)
        {
            frmTextEditorFind frmTextEditorFind = new frmTextEditorFind();
            frmTextEditorFind.tbFindText.Text = tbGeneric.SelectionLength <= 0 ? g_findString : tbGeneric.SelectedText;
            frmTextEditorFind.chkbMatchCase.Checked = g_matchcase;
            frmTextEditorFind.chkbMatchWholeWord.Checked = g_matchwholeword;
            frmTextEditorFind.chkbSearchUp.Checked = g_searchup;
            if (frmTextEditorFind.ShowDialog(this) != DialogResult.OK || StringType.StrCmp(frmTextEditorFind.tbFindText.Text, "", false) == 0)
                return;
            g_findString = frmTextEditorFind.tbFindText.Text;
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = frmTextEditorFind.chkbMatchCase.Checked;
            g_matchwholeword = frmTextEditorFind.chkbMatchWholeWord.Checked;
            g_searchup = frmTextEditorFind.chkbSearchUp.Checked;
            if (g_matchcase | g_matchwholeword | g_searchup)
            {
                if (g_matchcase) g_searchoptions = g_searchoptions | RichTextBoxFinds.MatchCase;
                if (g_matchwholeword) g_searchoptions = g_searchoptions | RichTextBoxFinds.WholeWord;
                if (g_searchup) g_searchoptions = g_searchoptions | RichTextBoxFinds.Reverse;
            }
            else
                g_searchoptions = RichTextBoxFinds.None;

            SearchFromStart();
        }

        private void miFindAgain_Click(object sender, EventArgs e)
        {
            int gFindPos = g_findPos;
            if (StringType.StrCmp(g_findString, "", false) == 0)
                return;
            g_findPos = (uint) (g_searchoptions & RichTextBoxFinds.Reverse) <= 0U ? tbGeneric.Find(g_findString, g_findPos + 1, g_searchoptions) : tbGeneric.Find(g_findString, 0, gFindPos != -1 ? g_findPos - 1 : tbGeneric.TextLength, g_searchoptions);
            if (g_findPos == -1)
            {
                if (Interaction.MsgBox("No more ocurrences found\nStart search from beginning of file?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    SearchFromStart();
                }
                else
                {
                    tbGeneric.SelectionStart = gFindPos;
                    tbGeneric.SelectionLength = g_findString.Length;
                    tbGeneric.Focus();
                    return;
                }
            }

            tbGeneric.SelectionStart = g_findPos;
            tbGeneric.SelectionLength = g_findString.Length;
            tbGeneric.Focus();
        }

        private void SearchFromStart()
        {
            g_findPos = tbGeneric.Find(g_findString, g_searchoptions);
            if (g_findPos == -1)
            {
                Interaction.MsgBox("Text not found", MsgBoxStyle.Information);
                tbGeneric.SelectionStart = 0;
                tbGeneric.SelectionLength = 0;
            }
            else
            {
                tbGeneric.SelectionStart = g_findPos;
                tbGeneric.SelectionLength = g_findString.Length;
                tbGeneric.Focus();
            }
        }

        private void miUndo_Click(object sender, EventArgs e)
        {
            tbGeneric.Undo();
        }

        private void miRedo_Click(object sender, EventArgs e)
        {
            tbGeneric.Redo();
        }

        private void miCut_Click(object sender, EventArgs e)
        {
            if (tbGeneric.SelectedText.Equals(""))
                return;
            if (RTFMode)
            {
                Clipboard.SetDataObject(tbGeneric.SelectedRtf, true);
                tbGeneric.SelectedRtf = "";
            }
            else
            {
                Clipboard.SetDataObject(tbGeneric.SelectedText, true);
                tbGeneric.SelectedText = "";
            }
        }

        private void miCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(tbGeneric.SelectedRtf, true);
            if (RTFMode)
                Clipboard.SetDataObject(tbGeneric.SelectedRtf, true);
            else
                Clipboard.SetDataObject(tbGeneric.SelectedText, true);
        }

        private void miPaste_Click(object sender, EventArgs e)
        {
            try
            {
                DataObject dataObject = (DataObject) Clipboard.GetDataObject();
                if (dataObject.GetDataPresent(DataFormats.Rtf))
                {
                    string str = StringType.FromObject(dataObject.GetData(DataFormats.Rtf));
                    if (str.Equals(""))
                        return;
                    tbGeneric.SelectedRtf = str;
                }
                else if (dataObject.GetDataPresent(DataFormats.Text) & !RTFMode)
                {
                    string str = StringType.FromObject(dataObject.GetData(DataFormats.Text));
                    if (str.Equals(""))
                        return;
                    tbGeneric.SelectedText = str;
                }
                else
                {
                    if (!dataObject.GetDataPresent(DataFormats.Text))
                        return;
                    string str = StringType.FromObject(dataObject.GetData(DataFormats.Text));
                    if (str.Equals(""))
                        return;
                    tbGeneric.SelectedRtf = str;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                MessageBox.Show(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void miSelectAll_Click(object sender, EventArgs e)
        {
            tbGeneric.SelectAll();
            tbGeneric.Focus();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("load",  ConfigOptions.Paths.DefaultSaveLocation, fname, "Load file...", ""));
            if (StringType.StrCmp(str, "", false) == 0) return;
            RichTextBoxStreamType fileType = StringType.StrCmp(Strings.LCase(Path.GetExtension(str)), ".rtf", false) != 0 ? RichTextBoxStreamType.PlainText : RichTextBoxStreamType.RichText;
            try
            {
                tbGeneric.Rtf = "";
                tbGeneric.LoadFile(str, fileType);
            }
            catch (ArgumentException ex)
            {
                ProjectData.SetProjectError(ex);
                MessageBox.Show(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (StringType.StrCmp(_EditingFilePath, "", false) == 0)
            {
                _EditingFilePath = StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.TextEditorSavePath, fname, "Save file...", ""));
                if (StringType.StrCmp(_EditingFilePath, "", false) == 0) return;
            }

            StreamWriter streamWriter = new StreamWriter(new FileStream(_EditingFilePath, FileMode.Create), Encoding.ASCII);
            streamWriter.Write(Strings.Replace(tbGeneric.Text, "\n", "\r\n"));
            streamWriter.Close();
            ConfigOptions.Paths.TextEditorSavePath = Path.GetDirectoryName(_EditingFilePath);
            UserSettings.SaveSettings(CurrentSettings);
            Filename = Path.GetFileName(_EditingFilePath);
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("save", !_IsDirectEdit ? ConfigOptions.Paths.TextEditorSavePath : Path.GetDirectoryName(_EditingFilePath), fname, "Save file...", ""));
            if (StringType.StrCmp(str, "", false) == 0) return;
            ConfigOptions.Paths.TextEditorSavePath = Path.GetDirectoryName(str);
            UserSettings.SaveSettings(CurrentSettings);
            StreamWriter streamWriter = new StreamWriter(new FileStream(str, FileMode.Create), Encoding.ASCII);
            if (m_rtfMode) streamWriter.Write(tbGeneric.Rtf);
            else streamWriter.Write(Strings.Replace(tbGeneric.Text, "\n", "\r\n"));
            streamWriter.Close();
            _EditingFilePath = str;
            Filename = Path.GetFileName(str);
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miPrint_Click(object sender, EventArgs e)
        {
            streamToPrint = new StringReader(tbGeneric.Text);
            try
            {
                try
                {
                    printFont = tbGeneric.Font;
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += pd_PrintPage;
                    if (storedPageSettings != null)
                        printDocument.DefaultPageSettings = storedPageSettings;
                    if (new PrintDialog {Document = printDocument}.ShowDialog(this) != DialogResult.OK)
                        return;
                    printDocument.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                MessageBox.Show(ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int num1 = 0;
            float left = ev.MarginBounds.Left;
            float top = ev.MarginBounds.Top;
            string s = null;
            float num2 = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            while (num1 < (double) num2)
            {
                s = streamToPrint.ReadLine();
                if (s != null)
                {
                    float y = top + num1 * printFont.GetHeight(ev.Graphics);
                    ev.Graphics.DrawString(s, printFont, Brushes.Black, left, y, new StringFormat());
                    ++num1;
                }
                else break;
            }

            if (s != null) ev.HasMorePages = true;
            else ev.HasMorePages = false;
        }

        private void miPageSetup_Click(object sender, EventArgs e)
        {
            try
            {
                PageSetupDialog pageSetupDialog = new PageSetupDialog();
                if (storedPageSettings == null) storedPageSettings = new PageSettings();
                pageSetupDialog.PageSettings = storedPageSettings;
                pageSetupDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                MessageBox.Show("An error occurred - " + ex.Message);
                ProjectData.ClearProjectError();
            }
        }

        private void miFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = tbGeneric.SelectionFont;
            if (fontDialog.ShowDialog() != DialogResult.OK) return;
            if (tbGeneric.SelectionLength == 0) tbGeneric.Font = fontDialog.Font;
            else tbGeneric.SelectionFont = fontDialog.Font;
            tbGeneric.SelectionColor = fontDialog.Color;
        }

        private void miWordWrap_Click(object sender, EventArgs e)
        {
            if (((MenuItem) sender).Checked)
            {
                tbGeneric.WordWrap = false;
                ((MenuItem) sender).Checked = false;
            }
            else
            {
                tbGeneric.WordWrap = true;
                ((MenuItem) sender).Checked = true;
            }
        }

        private void miEncountersList_Click(object sender, EventArgs e)
        {
            g_findString = "Encounter List";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miPlaceablesList_Click(object sender, EventArgs e)
        {
            g_findString = "Placeable List";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miCameras_Click(object sender, EventArgs e)
        {
            g_findString = "CameraList";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miDoorsList_Click(object sender, EventArgs e)
        {
            g_findString = "Door List";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miSoundsList_Click(object sender, EventArgs e)
        {
            g_findString = "SoundList";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miTriggersList_Click(object sender, EventArgs e)
        {
            g_findString = "TriggerList";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miWaypointsList_Click(object sender, EventArgs e)
        {
            g_findString = "WaypointList";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miCreatureList_Click(object sender, EventArgs e)
        {
            g_findString = "Creature List";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private void miMerchantList_Click(object sender, EventArgs e)
        {
            g_findString = "StoreList";
            g_searchoptions = RichTextBoxFinds.None;
            g_matchcase = false;
            g_searchup = false;
            g_matchwholeword = false;
            SearchFromStart();
        }

        private string CompileNSS()
        {
            string str1 = "";
            if (_EditingFilePath != null && StringType.StrCmp(_EditingFilePath, "", false) != 0)
            {
                string str = "-g " + Convert.ToString(checked(_KotorVersionIndex + 1));
                string path = Path.ChangeExtension(_EditingFilePath, ".ncs");
                if (File.Exists(path))
                    File.Delete(path);
                Process process = new Process();
                process.StartInfo.FileName = MainFormState.GRootPath + "nwnnsscomp.exe";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = "-c " + str + " -o " + "\"" + path + "\"" + " " + "\"" + _EditingFilePath + "\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                string end = process.StandardOutput.ReadToEnd();
                process.WaitForExit(4000);
                Interaction.MsgBox(end, MsgBoxStyle.Information, "Compiler output");
                return end;
            }

            return str1;
        }

        private void miCompile_Click(object sender, EventArgs e)
        {
            miSave_Click(null, null);
            CompileNSS();
        }

        private void miScriptIsK1_Click(object sender, EventArgs e)
        {
            KotorVersionIndex = 0;
            miScriptIsK2.Checked = false;
            miCompile.Enabled = true;
            PrepareForScriptEditing();
        }

        private void miScriptIsK2_Click(object sender, EventArgs e)
        {
            KotorVersionIndex = 1;
            miScriptIsK1.Checked = false;
            miCompile.Enabled = true;
            PrepareForScriptEditing();
        }

        public void PrepareForScriptEditing()
        {
            LoadNWScript(KotorVersionIndex);
            ShowFilterMatches();
            if (pnlFunctions.Visible)
                return;
            pnlFunctions.Visible = true;
            tbGeneric.Size = new Size(tbGeneric.Size.Width, tbGeneric.Size.Height - 128);
        }

        private void LoadNWScript(int index)
        {
            FileStream fileStream = new FileStream(Path.Combine(ConfigOptions.Paths.KotorLocation(index), "override\\nwscript.nss"), FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);
            int num1 = 0;
            int num2 = 0;
            switch (index)
            {
                case 0:
                    num1 = 1666;
                    num2 = 3507;
                    this.funcs = new func[772];
                    break;
                case 1:
                    num1 = 2044;
                    num2 = 4277;
                    this.funcs = new func[877];
                    break;
            }

            int num3 = 1;
            int num4 = num1;
            int num5 = num3;
            while (num5 <= num4)
            {
                streamReader.ReadLine();
                ++num5;
            }

            int num6 = 1;
            int num7 = num2;
            int num8 = num6;
            while (num8 <= num7)
            {
                string str = streamReader.ReadLine();
                int index1 = 0;
                if (str.StartsWith("//"))
                {
                    func[] funcs = this.funcs;
                    int index2 = index1;
                    int index3 = index2;
                    funcs[index3].comment = this.funcs[index2].comment + str + "\r\n";
                }
                else if (str.Length != 0)
                {
                    funcs[index1].decl = str;
                    string[] strArray = Strings.Split(str.Replace("(", " "));
                    int index2 = 1;
                    while (StringType.StrCmp(strArray[index2], "", false) == 0)
                    {
                        ++index2;
                        if (index2 > 10) break;
                    }

                    funcs[index1].name = strArray[index2];
                    ++index1;
                }

                ++num8;
            }

            fileStream.Close();
        }

        private void ShowFilterMatches()
        {
            lbFunctions.Items.Clear();
            lbFunctions.Sorted = true;
            string[] strArray = new string[funcs.GetUpperBound(0) + 1];
            int index1 = 0;
            if (StringType.StrCmp(tbFuncNameFilter.Text.Trim(), string.Empty, false) == 0)
            {
                int num = 0;
                int upperBound = funcs.GetUpperBound(0);
                int index2 = num;
                while (index2 <= upperBound)
                {
                    strArray[index1] = funcs[index2].name;
                    ++index1;
                    ++index2;
                    
                }
            }
            else
            {
                int num = 0;
                int upperBound = funcs.GetUpperBound(0);
                int index2 = num;
                while (index2 <= upperBound)
                {
                    if (funcs[index2].name.ToLower().IndexOf(tbFuncNameFilter.Text.Trim().ToLower()) > -1)
                    {
                        strArray[index1] = funcs[index2].name;
                        ++index1;
                    }

                    ++index2;
                }
            }

            lbFunctions.Items.AddRange((object[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(strArray, new string[index1 - 1 + 1]));
            if (index1 == 1)
            {
                lbFunctions.SelectedIndex = 0;
                lbFunctions_Click(null, null);
            }

            lblMatches.Text = "Matches: " + StringType.FromInteger(lbFunctions.Items.Count);
        }

        private void tbFuncNameFilter_TextChanged(object sender, EventArgs e)
        {
            ShowFilterMatches();
        }

        private void lbFunctions_Click(object sender, EventArgs e)
        {
            int num = 0;
            int upperBound = funcs.GetUpperBound(0);
            int index = num;
            while (index <= upperBound)
            {
                if (ObjectType.ObjTst(funcs[index].name, lbFunctions.SelectedItem, false) == 0)
                {
                    tbFuncDecl.Text = funcs[index].comment + "\r\n" + funcs[index].decl;
                    break;
                }
 ++index;
              
            }
        }

        private void lbFunctions_DoubleClick(object sender, EventArgs e)
        {
            int num = 0;
            int upperBound = funcs.GetUpperBound(0);
            int index = num;
            while (index <= upperBound)
            {
                if (ObjectType.ObjTst(funcs[index].name, lbFunctions.SelectedItem, false) == 0)
                {
                    if ((uint) (ModifierKeys & Keys.Shift) > 0U) tbGeneric.SelectedText = funcs[index].decl;
                    else tbGeneric.SelectedText = funcs[index].name + "(";
                    tbGeneric.Focus();
                    break;
                }

                ++index;
            }
        }

        private void lbFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFunctions_Click(null, null);
        }

        private void tbGeneric_GotFocus(object sender, EventArgs e)
        {
            miCut.Enabled = true;
            miCopy.Enabled = true;
            miPaste.Enabled = true;
        }

        private void tbGeneric_LostFocus(object sender, EventArgs e)
        {
            miCut.Enabled = false;
            miCopy.Enabled = false;
            miPaste.Enabled = false;
        }

        private void tbGeneric_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right || tbGeneric.SelectionLength == 0) return;
            object o1 = sender;
            Type local1 = null;
            string name = "PointToClient";
            object[] objArray1 = new object[1];
            object[] objArray2 = objArray1;
            int index = 0;
            object o2 = sender;
            object objectValue = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(o2, null, "MousePosition", new object[0], null, null));
            objArray2[index] = objectValue;
            object[] objArray3 = objArray1;
            object[] args = objArray3;
            String[] local2 = null;
            bool[] flagArray = new bool[1] {true};
            bool[] CopyBack = flagArray;
            object instance = LateBinding.LateGet(o1, local1, name, args, local2, CopyBack);
            if (flagArray[0]) LateBinding.LateSetComplex(o2, null, "MousePosition", new object[1] {RuntimeHelpers.GetObjectValue(objArray3[0])}, null, 1 != 0, 0 != 0);
            if (instance == null) instance = Activator.CreateInstance(typeof(Point));
            Point point = (Point) instance;
            cmText.Show((Control) sender, new Point(point.X, point.Y));
        }

        private void cmiShowDefinition_Click(object sender, EventArgs e)
        {
            tbFuncNameFilter.Text = tbGeneric.SelectedText;
        }

        private struct func
        {
            public string comment;
            public string decl;
            public string name;
        }
    }
}