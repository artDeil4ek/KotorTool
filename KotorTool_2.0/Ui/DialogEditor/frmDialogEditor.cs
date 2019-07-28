using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.MainForm;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Ui.Forms;
using KotorTool_2._0.Ui.TextEditor;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Ui.DialogEditor
{
    public class FrmDialogEditor : frmParent
    {
        [AccessedThroughProperty("nudCameraID")]
        private NumericUpDown _nudCameraId;

        [AccessedThroughProperty("Label13")] private Label _label13;
        [AccessedThroughProperty("Label15")] private Label _label15;

        [AccessedThroughProperty("nudPlotIndex")]
        private NumericUpDown _nudPlotIndex;

        [AccessedThroughProperty("btnDebug")] private Button _btnDebug;
        [AccessedThroughProperty("Label16")] private Label _label16;

        [AccessedThroughProperty("TabControl1")]
        private TabControl _tabControl1;

        [AccessedThroughProperty("Label17")] private Label _label17;
        [AccessedThroughProperty("Label18")] private Label _label18;

        [AccessedThroughProperty("tbListener")]
        private TextBox _tbListener;

        [AccessedThroughProperty("Label12")] private Label _label12;
        [AccessedThroughProperty("Label19")] private Label _label19;
        [AccessedThroughProperty("Label11")] private Label _label11;
        [AccessedThroughProperty("Label20")] private Label _label20;

        [AccessedThroughProperty("nudPlotXPPercentage")]
        private NumericUpDown _nudPlotXpPercentage;

        [AccessedThroughProperty("Label21")] private Label _label21;
        [AccessedThroughProperty("Label22")] private Label _label22;

        [AccessedThroughProperty("btnExpandAll")]
        private Button _btnExpandAll;

        [AccessedThroughProperty("Label23")] private Label _label23;

        [AccessedThroughProperty("nudCamHeightOffset")]
        private NumericUpDown _nudCamHeightOffset;

        [AccessedThroughProperty("Label24")] private Label _label24;
        [AccessedThroughProperty("Label10")] private Label _label10;
        [AccessedThroughProperty("Label9")] private Label _label9;

        [AccessedThroughProperty("tbVoiceOverResRef")]
        private TextBox _tbVoiceOverResRef;

        [AccessedThroughProperty("Label8")] private Label _label8;
        [AccessedThroughProperty("Label7")] private Label _label7;
        [AccessedThroughProperty("Label6")] private Label _label6;

        [AccessedThroughProperty("nudFadeColorB")]
        private NumericUpDown _nudFadeColorB;

        [AccessedThroughProperty("Label2")] private Label _label2;
        [AccessedThroughProperty("Label39")] private Label _label39;

        [AccessedThroughProperty("tbActionsTakenScript2")]
        private TextBox _tbActionsTakenScript2;

        [AccessedThroughProperty("btnCollapseAll")]
        private Button _btnCollapseAll;

        [AccessedThroughProperty("Label38")] private Label _label38;

        [AccessedThroughProperty("tbTextActiveScript2")]
        private TextBox _tbTextActiveScript2;

        [AccessedThroughProperty("nudTarHeightOffset")]
        private NumericUpDown _nudTarHeightOffset;

        [AccessedThroughProperty("tabpagThisFile3")]
        private TabPage _tabpagThisFile3;

        [AccessedThroughProperty("cmiTV_MoveNodeDown")]
        private MenuItem _cmiTvMoveNodeDown;

        [AccessedThroughProperty("cmiTV_MoveNodeUp")]
        private MenuItem _cmiTvMoveNodeUp;

        [AccessedThroughProperty("lblPlotIndex")]
        private Label _lblPlotIndex;

        [AccessedThroughProperty("nudCamFieldOfView")]
        private NumericUpDown _nudCamFieldOfView;

        [AccessedThroughProperty("Label37")] private Label _label37;
        [AccessedThroughProperty("Label31")] private Label _label31;

        [AccessedThroughProperty("nudFadeColorG")]
        private NumericUpDown _nudFadeColorG;

        [AccessedThroughProperty("tbCameraModel")]
        private TextBox _tbCameraModel;

        [AccessedThroughProperty("chkbAnimatedCut")]
        private CheckBox _chkbAnimatedCut;

        [AccessedThroughProperty("tbComments")]
        private TextBox _tbComments;

        [AccessedThroughProperty("cmbxCamVidEffect")]
        private ComboBox _cmbxCamVidEffect;

        [AccessedThroughProperty("nudFadeColorR")]
        private NumericUpDown _nudFadeColorR;

        [AccessedThroughProperty("cmbxFadeType")]
        private ComboBox _cmbxFadeType;

        [AccessedThroughProperty("btnShowLists")]
        private Button _btnShowLists;

        [AccessedThroughProperty("nudQuestEntry")]
        private NumericUpDown _nudQuestEntry;

        [AccessedThroughProperty("nudFadeDelay")]
        private NumericUpDown _nudFadeDelay;

        [AccessedThroughProperty("Label36")] private Label _label36;
        [AccessedThroughProperty("btnTest")] private Button _btnTest;
        [AccessedThroughProperty("Label35")] private Label _label35;
        [AccessedThroughProperty("tbQuest")] private TextBox _tbQuest;

        [AccessedThroughProperty("cmbxComputerType")]
        private ComboBox _cmbxComputerType;

        [AccessedThroughProperty("cmbxConversationType")]
        private ComboBox _cmbxConversationType;

        [AccessedThroughProperty("nudFadeLength")]
        private NumericUpDown _nudFadeLength;

        [AccessedThroughProperty("cmiTV_Cut")] private MenuItem _cmiTvCut;
        [AccessedThroughProperty("tbLinkID")] private TextBox _tbLinkId;

        [AccessedThroughProperty("tbLinkedCnt")]
        private TextBox _tbLinkedCnt;

        [AccessedThroughProperty("tbSharedCnt")]
        private TextBox _tbSharedCnt;

        [AccessedThroughProperty("ToolTip1")] private ToolTip _toolTip1;
        [AccessedThroughProperty("Label34")] private Label _label34;

        [AccessedThroughProperty("tbLinkDesc")]
        private TextBox _tbLinkDesc;

        [AccessedThroughProperty("tbSound")] private TextBox _tbSound;

        [AccessedThroughProperty("cmiTV_PasteTree")]
        private MenuItem _cmiTvPasteTree;

        [AccessedThroughProperty("trkbTVItemHeight")]
        private TrackBar _trkbTvItemHeight;

        [AccessedThroughProperty("Label33")] private Label _label33;
        [AccessedThroughProperty("miNew")] private MenuItem _miNew;
        [AccessedThroughProperty("Label25")] private Label _label25;
        [AccessedThroughProperty("tbVO_ID")] private TextBox _tbVoId;
        [AccessedThroughProperty("Label32")] private Label _label32;

        [AccessedThroughProperty("trkbTVIndent")]
        private TrackBar _trkbTvIndent;

        [AccessedThroughProperty("btnChooseColor")]
        private Button _btnChooseColor;

        [AccessedThroughProperty("btnAddAnimListEntry")]
        private Button _btnAddAnimListEntry;

        [AccessedThroughProperty("btnDeleteAnimListEntry")]
        private Button _btnDeleteAnimListEntry;

        [AccessedThroughProperty("dgAnimList")]
        private DataGrid _dgAnimList;

        [AccessedThroughProperty("cmiTV_PasteAsLink")]
        private MenuItem _cmiTvPasteAsLink;

        [AccessedThroughProperty("tvConversation")]
        private TreeView _tvConversation;

        [AccessedThroughProperty("tbTextActiveScript")]
        private TextBox _tbTextActiveScript;

        [AccessedThroughProperty("Label30")] private Label _label30;

        [AccessedThroughProperty("dgStuntList")]
        private DataGrid _dgStuntList;

        [AccessedThroughProperty("MenuItem4")] private MenuItem _menuItem4;

        [AccessedThroughProperty("tabpagThisFile2")]
        private TabPage _tabpagThisFile2;

        [AccessedThroughProperty("tabpagThisFile1")]
        private TabPage _tabpagThisFile1;

        [AccessedThroughProperty("tbEndConversation")]
        private TextBox _tbEndConversation;

        [AccessedThroughProperty("MenuItem2")] private MenuItem _menuItem2;
        [AccessedThroughProperty("miSave")] private MenuItem _miSave;
        [AccessedThroughProperty("miQuit")] private MenuItem _miQuit;
        [AccessedThroughProperty("miOpen")] private MenuItem _miOpen;
        [AccessedThroughProperty("btnOpen")] private Button _btnOpen;

        [AccessedThroughProperty("cmTVfunctions")]
        private ContextMenu _cmTVfunctions;

        [AccessedThroughProperty("tbEndConverAbort")]
        private TextBox _tbEndConverAbort;

        [AccessedThroughProperty("Label1")] private Label _label1;

        [AccessedThroughProperty("tbAmbientTrack")]
        private TextBox _tbAmbientTrack;

        [AccessedThroughProperty("btnSave")] private Button _btnSave;

        [AccessedThroughProperty("chkbSkippable")]
        private CheckBox _chkbSkippable;

        [AccessedThroughProperty("chkbUnequipItems")]
        private CheckBox _chkbUnequipItems;

        [AccessedThroughProperty("Label3")] private Label _label3;

        [AccessedThroughProperty("tbActionsTakenScript")]
        private TextBox _tbActionsTakenScript;

        [AccessedThroughProperty("Label26")] private Label _label26;
        [AccessedThroughProperty("Label4")] private Label _label4;

        [AccessedThroughProperty("nudDelayEntry")]
        private NumericUpDown _nudDelayEntry;

        [AccessedThroughProperty("Label5")] private Label _label5;

        [AccessedThroughProperty("nudDelayReply")]
        private NumericUpDown _nudDelayReply;

        [AccessedThroughProperty("Label27")] private Label _label27;
        [AccessedThroughProperty("cmiTV_Add")] private MenuItem _cmiTvAdd;

        [AccessedThroughProperty("chkbUnequipHItem")]
        private CheckBox _chkbUnequipHItem;

        [AccessedThroughProperty("tbSpeaker")] private TextBox _tbSpeaker;
        [AccessedThroughProperty("Label28")] private Label _label28;
        [AccessedThroughProperty("Label14")] private Label _label14;

        [AccessedThroughProperty("cmiTV_Paste")]
        private MenuItem _cmiTvPaste;

        [AccessedThroughProperty("tabpagDebug")]
        private TabPage _tabpagDebug;

        [AccessedThroughProperty("tabpagAnimationSound")]
        private TabPage _tabpagAnimationSound;

        [AccessedThroughProperty("MenuItem1")] private MenuItem _menuItem1;

        [AccessedThroughProperty("tabpagPlot")]
        private TabPage _tabpagPlot;

        [AccessedThroughProperty("tbConversationText")]
        private TextBox _tbConversationText;

        [AccessedThroughProperty("MainMenu1")] private MainMenu _mainMenu1;
        [AccessedThroughProperty("Label29")] private Label _label29;

        [AccessedThroughProperty("tabpagComment")]
        private TabPage _tabpagComment;

        [AccessedThroughProperty("tabpagCamera")]
        private TabPage _tabpagCamera;

        [AccessedThroughProperty("tabpagActionsTaken")]
        private TabPage _tabpagActionsTaken;

        [AccessedThroughProperty("nudCameraAngle")]
        private NumericUpDown _nudCameraAngle;

        [AccessedThroughProperty("cmiTV_Copy")]
        private MenuItem _cmiTvCopy;

        private IContainer components;
        private ClsDlg _clsdlg;
        private int _entryIndex;
        private int _replyIndex;
        private ArrayList _entryList;
        private ArrayList _replyList;
        private ClsGff _gff;
        private GffStruct _struct;
        private DlgConvListNode _lastClickedTvConversationNode;
        private DlgConvListNode _currentContextMenuTvConversationNode;
        private DlgConvListNode _clipBoardNode;
        private string _filename;
        private readonly DataTable _dtStunt;
        private DataView _dViewStunt;
        private DataTable _dtAnim;
        private DataView _dViewAnim;

        internal virtual TextBox TbConversationText
        {
            get => _tbConversationText;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbConversationText == null)
                    ;
                _tbConversationText = value;
                if (_tbConversationText != null)
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

        internal virtual TextBox TbActionsTakenScript
        {
            get => _tbActionsTakenScript;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbActionsTakenScript == null) ;
                _tbActionsTakenScript = value;
                if (_tbActionsTakenScript != null) ;
            }
        }

        internal virtual TreeView TvConversation
        {
            get => _tvConversation;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvConversation != null)
                {
                    _tvConversation.AfterSelect -= tvConversation_AfterSelect;
                    _tvConversation.MouseUp -= tvConversation_MouseUp;
                    _tvConversation.MouseDown -= tvConversation_MouseDown;
                }

                _tvConversation = value;
                if (_tvConversation == null)
                    return;
                _tvConversation.AfterSelect += tvConversation_AfterSelect;
                _tvConversation.MouseUp += tvConversation_MouseUp;
                _tvConversation.MouseDown += tvConversation_MouseDown;
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

        internal virtual TextBox TbSound
        {
            get => _tbSound;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSound == null)
                    ;
                _tbSound = value;
                if (_tbSound != null)
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

        internal virtual TextBox TbComments
        {
            get => _tbComments;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbComments == null)
                    ;
                _tbComments = value;
                if (_tbComments != null)
                    ;
            }
        }

        internal virtual Button BtnCollapseAll
        {
            get => _btnCollapseAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCollapseAll != null)
                    _btnCollapseAll.Click -= btnCollapseAll_Click;
                _btnCollapseAll = value;
                if (_btnCollapseAll == null)
                    return;
                _btnCollapseAll.Click += btnCollapseAll_Click;
            }
        }

        internal virtual Button BtnExpandAll
        {
            get => _btnExpandAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnExpandAll != null)
                    _btnExpandAll.Click -= btnExpandAll_Click;
                _btnExpandAll = value;
                if (_btnExpandAll == null)
                    return;
                _btnExpandAll.Click += btnExpandAll_Click;
            }
        }

        internal virtual Button BtnDebug
        {
            get => _btnDebug;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDebug != null)
                    _btnDebug.Click -= btnDebug_Click;
                _btnDebug = value;
                if (_btnDebug == null)
                    return;
                _btnDebug.Click += btnDebug_Click;
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

        internal virtual TextBox TbListener
        {
            get => _tbListener;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbListener == null)
                    ;
                _tbListener = value;
                if (_tbListener != null)
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

        internal virtual TextBox TbVoiceOverResRef
        {
            get => _tbVoiceOverResRef;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbVoiceOverResRef == null)
                    ;
                _tbVoiceOverResRef = value;
                if (_tbVoiceOverResRef != null)
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

        internal virtual Label LblPlotIndex
        {
            get => _lblPlotIndex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblPlotIndex == null)
                    ;
                _lblPlotIndex = value;
                if (_lblPlotIndex != null)
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

        internal virtual Button BtnTest
        {
            get => _btnTest;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnTest != null)
                    _btnTest.Click -= btnTest_Click;
                _btnTest = value;
                if (_btnTest == null)
                    return;
                _btnTest.Click += btnTest_Click;
            }
        }

        internal virtual Button BtnChooseColor
        {
            get => _btnChooseColor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnChooseColor != null)
                    _btnChooseColor.Click -= btnChooseColor_Click;
                _btnChooseColor = value;
                if (_btnChooseColor == null)
                    return;
                _btnChooseColor.Click += btnChooseColor_Click;
            }
        }

        internal virtual ContextMenu CmTVfunctions
        {
            get => _cmTVfunctions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmTVfunctions == null)
                    ;
                _cmTVfunctions = value;
                if (_cmTVfunctions != null)
                    ;
            }
        }

        internal virtual MenuItem CmiTvAdd
        {
            get => _cmiTvAdd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvAdd != null)
                    _cmiTvAdd.Click -= cmiTV_Add_Click;
                _cmiTvAdd = value;
                if (_cmiTvAdd == null)
                    return;
                _cmiTvAdd.Click += cmiTV_Add_Click;
            }
        }

        internal virtual MenuItem CmiTvCopy
        {
            get => _cmiTvCopy;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvCopy != null)
                    _cmiTvCopy.Click -= cmiTV_Copy_Click;
                _cmiTvCopy = value;
                if (_cmiTvCopy == null)
                    return;
                _cmiTvCopy.Click += cmiTV_Copy_Click;
            }
        }

        internal virtual MenuItem CmiTvPaste
        {
            get => _cmiTvPaste;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvPaste != null)
                    _cmiTvPaste.Click -= cmiTV_Paste_Click;
                _cmiTvPaste = value;
                if (_cmiTvPaste == null)
                    return;
                _cmiTvPaste.Click += cmiTV_Paste_Click;
            }
        }

        internal virtual MenuItem CmiTvPasteAsLink
        {
            get => _cmiTvPasteAsLink;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvPasteAsLink != null)
                    _cmiTvPasteAsLink.Click -= cmiTV_PasteAsLink_Click;
                _cmiTvPasteAsLink = value;
                if (_cmiTvPasteAsLink == null)
                    return;
                _cmiTvPasteAsLink.Click += cmiTV_PasteAsLink_Click;
            }
        }

        internal virtual MenuItem CmiTvCut
        {
            get => _cmiTvCut;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvCut != null)
                    _cmiTvCut.Click -= cmiTV_Cut_Click;
                _cmiTvCut = value;
                if (_cmiTvCut == null)
                    return;
                _cmiTvCut.Click += cmiTV_Cut_Click;
            }
        }

        internal virtual NumericUpDown NudFadeColorG
        {
            get => _nudFadeColorG;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFadeColorG == null)
                    ;
                _nudFadeColorG = value;
                if (_nudFadeColorG != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudFadeColorB
        {
            get => _nudFadeColorB;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFadeColorB == null)
                    ;
                _nudFadeColorB = value;
                if (_nudFadeColorB != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudPlotIndex
        {
            get => _nudPlotIndex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudPlotIndex == null)
                    ;
                _nudPlotIndex = value;
                if (_nudPlotIndex != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudPlotXpPercentage
        {
            get => _nudPlotXpPercentage;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudPlotXpPercentage == null)
                    ;
                _nudPlotXpPercentage = value;
                if (_nudPlotXpPercentage != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudCameraAngle
        {
            get => _nudCameraAngle;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudCameraAngle == null)
                    ;
                _nudCameraAngle = value;
                if (_nudCameraAngle != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudCamHeightOffset
        {
            get => _nudCamHeightOffset;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudCamHeightOffset == null)
                    ;
                _nudCamHeightOffset = value;
                if (_nudCamHeightOffset != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudTarHeightOffset
        {
            get => _nudTarHeightOffset;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudTarHeightOffset == null)
                    ;
                _nudTarHeightOffset = value;
                if (_nudTarHeightOffset != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudFadeDelay
        {
            get => _nudFadeDelay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFadeDelay == null)
                    ;
                _nudFadeDelay = value;
                if (_nudFadeDelay != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudFadeLength
        {
            get => _nudFadeLength;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFadeLength == null)
                    ;
                _nudFadeLength = value;
                if (_nudFadeLength != null)
                    ;
            }
        }

        internal virtual TextBox TbLinkId
        {
            get => _tbLinkId;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbLinkId == null)
                    ;
                _tbLinkId = value;
                if (_tbLinkId != null)
                    ;
            }
        }

        internal virtual TextBox TbLinkedCnt
        {
            get => _tbLinkedCnt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbLinkedCnt == null)
                    ;
                _tbLinkedCnt = value;
                if (_tbLinkedCnt != null)
                    ;
            }
        }

        internal virtual TextBox TbSharedCnt
        {
            get => _tbSharedCnt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSharedCnt == null)
                    ;
                _tbSharedCnt = value;
                if (_tbSharedCnt != null)
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

        internal virtual TextBox TbVoId
        {
            get => _tbVoId;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbVoId == null)
                    ;
                _tbVoId = value;
                if (_tbVoId != null)
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

        internal virtual TextBox TbEndConversation
        {
            get => _tbEndConversation;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbEndConversation == null)
                    ;
                _tbEndConversation = value;
                if (_tbEndConversation != null)
                    ;
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

        internal virtual TextBox TbEndConverAbort
        {
            get => _tbEndConverAbort;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbEndConverAbort == null)
                    ;
                _tbEndConverAbort = value;
                if (_tbEndConverAbort != null)
                    ;
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

        internal virtual TextBox TbAmbientTrack
        {
            get => _tbAmbientTrack;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbAmbientTrack == null)
                    ;
                _tbAmbientTrack = value;
                if (_tbAmbientTrack != null)
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

        internal virtual CheckBox ChkbSkippable
        {
            get => _chkbSkippable;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbSkippable == null)
                    ;
                _chkbSkippable = value;
                if (_chkbSkippable != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbUnequipItems
        {
            get => _chkbUnequipItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbUnequipItems == null)
                    ;
                _chkbUnequipItems = value;
                if (_chkbUnequipItems != null)
                    ;
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

        internal virtual NumericUpDown NudDelayEntry
        {
            get => _nudDelayEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudDelayEntry == null)
                    ;
                _nudDelayEntry = value;
                if (_nudDelayEntry != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudDelayReply
        {
            get => _nudDelayReply;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudDelayReply == null)
                    ;
                _nudDelayReply = value;
                if (_nudDelayReply != null)
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

        internal virtual CheckBox ChkbUnequipHItem
        {
            get => _chkbUnequipHItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbUnequipHItem == null)
                    ;
                _chkbUnequipHItem = value;
                if (_chkbUnequipHItem != null)
                    ;
            }
        }

        internal virtual TextBox TbSpeaker
        {
            get => _tbSpeaker;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbSpeaker == null)
                    ;
                _tbSpeaker = value;
                if (_tbSpeaker != null)
                    ;
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

        internal virtual NumericUpDown NudCameraId
        {
            get => _nudCameraId;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudCameraId == null)
                    ;
                _nudCameraId = value;
                if (_nudCameraId != null)
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

        internal virtual TabPage TabpagActionsTaken
        {
            get => _tabpagActionsTaken;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagActionsTaken == null)
                    ;
                _tabpagActionsTaken = value;
                if (_tabpagActionsTaken != null)
                    ;
            }
        }

        internal virtual TabPage TabpagCamera
        {
            get => _tabpagCamera;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagCamera == null)
                    ;
                _tabpagCamera = value;
                if (_tabpagCamera != null)
                    ;
            }
        }

        internal virtual TabPage TabpagComment
        {
            get => _tabpagComment;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagComment == null)
                    ;
                _tabpagComment = value;
                if (_tabpagComment != null)
                    ;
            }
        }

        internal virtual TabPage TabpagPlot
        {
            get => _tabpagPlot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagPlot == null)
                    ;
                _tabpagPlot = value;
                if (_tabpagPlot != null)
                    ;
            }
        }

        internal virtual TabControl TabControl1
        {
            get => _tabControl1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabControl1 == null)
                    ;
                _tabControl1 = value;
                if (_tabControl1 != null)
                    ;
            }
        }

        internal virtual TabPage TabpagAnimationSound
        {
            get => _tabpagAnimationSound;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagAnimationSound == null)
                    ;
                _tabpagAnimationSound = value;
                if (_tabpagAnimationSound != null)
                    ;
            }
        }

        internal virtual TabPage TabpagDebug
        {
            get => _tabpagDebug;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagDebug == null)
                    ;
                _tabpagDebug = value;
                if (_tabpagDebug != null)
                    ;
            }
        }

        internal virtual Button BtnSave
        {
            get => _btnSave;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSave != null)
                    _btnSave.Click -= Button1_Click;
                _btnSave = value;
                if (_btnSave == null)
                    return;
                _btnSave.Click += Button1_Click;
            }
        }

        internal virtual Button BtnOpen
        {
            get => _btnOpen;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnOpen != null)
                    _btnOpen.Click -= btnOpen_Click;
                _btnOpen = value;
                if (_btnOpen == null)
                    return;
                _btnOpen.Click += btnOpen_Click;
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

        internal virtual MenuItem MiOpen
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

        internal virtual MenuItem MiSave
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

        internal virtual MenuItem MiQuit
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

        internal virtual TabPage TabpagThisFile1
        {
            get => _tabpagThisFile1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagThisFile1 == null)
                    ;
                _tabpagThisFile1 = value;
                if (_tabpagThisFile1 != null)
                    ;
            }
        }

        internal virtual TabPage TabpagThisFile2
        {
            get => _tabpagThisFile2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagThisFile2 == null)
                    ;
                _tabpagThisFile2 = value;
                if (_tabpagThisFile2 != null)
                    ;
            }
        }

        internal virtual DataGrid DgStuntList
        {
            get => _dgStuntList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgStuntList == null)
                    ;
                _dgStuntList = value;
                if (_dgStuntList != null)
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

        internal virtual TextBox TbTextActiveScript
        {
            get => _tbTextActiveScript;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbTextActiveScript == null)
                    ;
                _tbTextActiveScript = value;
                if (_tbTextActiveScript != null)
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

        internal virtual DataGrid DgAnimList
        {
            get => _dgAnimList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgAnimList != null)
                {
                    _dgAnimList.Validated -= dgAnimList_Validated;
                    _dgAnimList.Click -= dgAnimList_Click;
                }

                _dgAnimList = value;
                if (_dgAnimList == null)
                    return;
                _dgAnimList.Validated += dgAnimList_Validated;
                _dgAnimList.Click += dgAnimList_Click;
            }
        }

        internal virtual Button BtnDeleteAnimListEntry
        {
            get => _btnDeleteAnimListEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDeleteAnimListEntry != null)
                    _btnDeleteAnimListEntry.Click -= btnDeleteAnimListEntry_Click;
                _btnDeleteAnimListEntry = value;
                if (_btnDeleteAnimListEntry == null)
                    return;
                _btnDeleteAnimListEntry.Click += btnDeleteAnimListEntry_Click;
            }
        }

        internal virtual Button BtnAddAnimListEntry
        {
            get => _btnAddAnimListEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAddAnimListEntry != null)
                    _btnAddAnimListEntry.Click -= btnAddAnimListEntry_Click;
                _btnAddAnimListEntry = value;
                if (_btnAddAnimListEntry == null)
                    return;
                _btnAddAnimListEntry.Click += btnAddAnimListEntry_Click;
            }
        }

        internal virtual TrackBar TrkbTvIndent
        {
            get => _trkbTvIndent;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbTvIndent != null)
                    _trkbTvIndent.Scroll -= trkbTVIndent_Scroll;
                _trkbTvIndent = value;
                if (_trkbTvIndent == null)
                    return;
                _trkbTvIndent.Scroll += trkbTVIndent_Scroll;
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

        internal virtual MenuItem MiNew
        {
            get => _miNew;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miNew != null)
                    _miNew.Click -= miNew_Click;
                _miNew = value;
                if (_miNew == null)
                    return;
                _miNew.Click += miNew_Click;
            }
        }

        internal virtual ToolTip ToolTip1
        {
            get => _toolTip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_toolTip1 == null)
                    ;
                _toolTip1 = value;
                if (_toolTip1 != null)
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

        internal virtual TrackBar TrkbTvItemHeight
        {
            get => _trkbTvItemHeight;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_trkbTvItemHeight != null)
                    _trkbTvItemHeight.Scroll -= trkbTVItemHeight_Scroll;
                _trkbTvItemHeight = value;
                if (_trkbTvItemHeight == null)
                    return;
                _trkbTvItemHeight.Scroll += trkbTVItemHeight_Scroll;
            }
        }

        internal virtual MenuItem CmiTvPasteTree
        {
            get => _cmiTvPasteTree;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvPasteTree != null)
                    _cmiTvPasteTree.Click -= cmiTV_PasteTree_Click;
                _cmiTvPasteTree = value;
                if (_cmiTvPasteTree == null)
                    return;
                _cmiTvPasteTree.Click += cmiTV_PasteTree_Click;
            }
        }

        internal virtual TextBox TbLinkDesc
        {
            get => _tbLinkDesc;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbLinkDesc == null)
                    ;
                _tbLinkDesc = value;
                if (_tbLinkDesc != null)
                    ;
            }
        }

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

        internal virtual ComboBox CmbxConversationType
        {
            get => _cmbxConversationType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxConversationType != null)
                    _cmbxConversationType.SelectedIndexChanged -= cmbxConversationType_SelectedIndexChanged;
                _cmbxConversationType = value;
                if (_cmbxConversationType == null)
                    return;
                _cmbxConversationType.SelectedIndexChanged += cmbxConversationType_SelectedIndexChanged;
            }
        }

        internal virtual ComboBox CmbxComputerType
        {
            get => _cmbxComputerType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxComputerType == null)
                    ;
                _cmbxComputerType = value;
                if (_cmbxComputerType != null)
                    ;
            }
        }

        internal virtual TextBox TbQuest
        {
            get => _tbQuest;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbQuest == null)
                    ;
                _tbQuest = value;
                if (_tbQuest != null)
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

        internal virtual NumericUpDown NudQuestEntry
        {
            get => _nudQuestEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudQuestEntry == null)
                    ;
                _nudQuestEntry = value;
                if (_nudQuestEntry != null)
                    ;
            }
        }

        internal virtual Button BtnShowLists
        {
            get => _btnShowLists;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnShowLists != null)
                    _btnShowLists.Click -= btnShowLists_Click;
                _btnShowLists = value;
                if (_btnShowLists == null)
                    return;
                _btnShowLists.Click += btnShowLists_Click;
            }
        }

        internal virtual ComboBox CmbxFadeType
        {
            get => _cmbxFadeType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxFadeType == null)
                    ;
                _cmbxFadeType = value;
                if (_cmbxFadeType != null)
                    ;
            }
        }

        internal virtual NumericUpDown NudFadeColorR
        {
            get => _nudFadeColorR;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudFadeColorR == null)
                    ;
                _nudFadeColorR = value;
                if (_nudFadeColorR != null)
                    ;
            }
        }

        internal virtual ComboBox CmbxCamVidEffect
        {
            get => _cmbxCamVidEffect;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbxCamVidEffect == null)
                    ;
                _cmbxCamVidEffect = value;
                if (_cmbxCamVidEffect != null)
                    ;
            }
        }

        internal virtual CheckBox ChkbAnimatedCut
        {
            get => _chkbAnimatedCut;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_chkbAnimatedCut != null)
                    _chkbAnimatedCut.CheckedChanged -= chkbAnimatedCut_CheckedChanged;
                _chkbAnimatedCut = value;
                if (_chkbAnimatedCut == null)
                    return;
                _chkbAnimatedCut.CheckedChanged += chkbAnimatedCut_CheckedChanged;
            }
        }

        internal virtual TextBox TbCameraModel
        {
            get => _tbCameraModel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbCameraModel == null)
                    ;
                _tbCameraModel = value;
                if (_tbCameraModel != null)
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

        internal virtual NumericUpDown NudCamFieldOfView
        {
            get => _nudCamFieldOfView;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_nudCamFieldOfView == null)
                    ;
                _nudCamFieldOfView = value;
                if (_nudCamFieldOfView != null)
                    ;
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

        internal virtual MenuItem CmiTvMoveNodeUp
        {
            get => _cmiTvMoveNodeUp;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvMoveNodeUp != null)
                    _cmiTvMoveNodeUp.Click -= cmiTV_MoveNodeUp_Click;
                _cmiTvMoveNodeUp = value;
                if (_cmiTvMoveNodeUp == null)
                    return;
                _cmiTvMoveNodeUp.Click += cmiTV_MoveNodeUp_Click;
            }
        }

        internal virtual MenuItem CmiTvMoveNodeDown
        {
            get => _cmiTvMoveNodeDown;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiTvMoveNodeDown != null)
                    _cmiTvMoveNodeDown.Click -= cmiTV_MoveNodeDown_Click;
                _cmiTvMoveNodeDown = value;
                if (_cmiTvMoveNodeDown == null)
                    return;
                _cmiTvMoveNodeDown.Click += cmiTV_MoveNodeDown_Click;
            }
        }

        internal virtual TabPage TabpagThisFile3
        {
            get => _tabpagThisFile3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabpagThisFile3 == null)
                    ;
                _tabpagThisFile3 = value;
                if (_tabpagThisFile3 != null)
                    ;
            }
        }

        internal virtual TextBox TbTextActiveScript2
        {
            get => _tbTextActiveScript2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbTextActiveScript2 == null)
                    ;
                _tbTextActiveScript2 = value;
                if (_tbTextActiveScript2 != null)
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

        internal virtual TextBox TbActionsTakenScript2
        {
            get => _tbActionsTakenScript2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tbActionsTakenScript2 == null)
                    ;
                _tbActionsTakenScript2 = value;
                if (_tbActionsTakenScript2 != null)
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

        public FrmDialogEditor()
        {
            _dtStunt = new DataTable();
            _dtAnim = new DataTable();
            InitializeComponent();
            m_defaultTitleText = "Conversation Editor - KotOR ";
            Text = m_defaultTitleText;
            BuildStuntDataGrid();
            BuildAnimDataGrid();
        }

        public FrmDialogEditor(string editingPath, int kotorVerIndex) : this()
        {
            string filepath = editingPath;
            TreeView tvConversation = TvConversation;
            TreeView extTv = @tvConversation;
            int kotorVerIndex1 = kotorVerIndex;
            ClsDlg clsDlg = new ClsDlg(filepath, ref extTv, kotorVerIndex1);
            TvConversation = tvConversation;
            _clsdlg = clsDlg;
            _filename = Path.GetFileNameWithoutExtension(editingPath);
            EditingFilePath = editingPath;
            _gff = _clsdlg.DlgGff;
            SetFormToDlgRootItems();
        }

        public FrmDialogEditor(FileStream fs, int kotorVerIndex) : this()
        {
            FileStream fs1 = fs;
            TreeView tvConversation = TvConversation;
            TreeView extTv = @tvConversation;
            int kotorVerIndex1 = kotorVerIndex;
            ClsDlg clsDlg = new ClsDlg(fs1, ref extTv, kotorVerIndex1);
            TvConversation = tvConversation;
            _clsdlg = clsDlg;
            _filename = Path.GetFileNameWithoutExtension(fs.Name);
            _gff = _clsdlg.DlgGff;
            SetFormToDlgRootItems();
        }

        public FrmDialogEditor(byte[] bytes, string fileName, int kotorVerIndex) : this()
        {
            byte[] bytes1 = bytes;
            TreeView tvConversation = TvConversation;
            TreeView extTv = @tvConversation;
            int kotorVerIndex1 = kotorVerIndex;
            ClsDlg clsDlg = new ClsDlg(bytes1, ref extTv, kotorVerIndex1);
            TvConversation = tvConversation;
            _clsdlg = clsDlg;
            _filename = fileName;
            _gff = _clsdlg.DlgGff;
            SetFormToDlgRootItems();
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
            components = new Container();
            ResourceManager resourceManager = new ResourceManager(typeof(FrmDialogEditor));
            TvConversation = new TreeView();
            TbConversationText = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            TabControl1 = new TabControl();
            TabpagActionsTaken = new TabPage();
            TbTextActiveScript = new TextBox();
            Label3 = new Label();
            TbActionsTakenScript = new TextBox();
            Label4 = new Label();
            TbTextActiveScript2 = new TextBox();
            Label38 = new Label();
            TbActionsTakenScript2 = new TextBox();
            Label39 = new Label();
            TabpagCamera = new TabPage();
            NudCamFieldOfView = new NumericUpDown();
            CmbxCamVidEffect = new ComboBox();
            NudFadeColorG = new NumericUpDown();
            NudFadeColorB = new NumericUpDown();
            NudFadeColorR = new NumericUpDown();
            CmbxFadeType = new ComboBox();
            NudCameraId = new NumericUpDown();
            NudCamHeightOffset = new NumericUpDown();
            NudCameraAngle = new NumericUpDown();
            Label7 = new Label();
            Label8 = new Label();
            TbListener = new TextBox();
            Label9 = new Label();
            Label11 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            Label15 = new Label();
            Label16 = new Label();
            BtnChooseColor = new Button();
            NudTarHeightOffset = new NumericUpDown();
            NudFadeDelay = new NumericUpDown();
            NudFadeLength = new NumericUpDown();
            Label28 = new Label();
            Label29 = new Label();
            Label37 = new Label();
            TabpagAnimationSound = new TabPage();
            DgAnimList = new DataGrid();
            Label5 = new Label();
            TbSound = new TextBox();
            Label6 = new Label();
            TbVoiceOverResRef = new TextBox();
            Label10 = new Label();
            BtnDeleteAnimListEntry = new Button();
            BtnAddAnimListEntry = new Button();
            TabpagPlot = new TabPage();
            TbQuest = new TextBox();
            Label35 = new Label();
            NudPlotIndex = new NumericUpDown();
            LblPlotIndex = new Label();
            Label12 = new Label();
            NudPlotXpPercentage = new NumericUpDown();
            Label36 = new Label();
            NudQuestEntry = new NumericUpDown();
            TabpagComment = new TabPage();
            TbComments = new TextBox();
            TabpagThisFile1 = new TabPage();
            ChkbAnimatedCut = new CheckBox();
            TbCameraModel = new TextBox();
            Label31 = new Label();
            CmbxConversationType = new ComboBox();
            ChkbSkippable = new CheckBox();
            TbVoId = new TextBox();
            Label20 = new Label();
            Label21 = new Label();
            TbEndConversation = new TextBox();
            Label22 = new Label();
            Label23 = new Label();
            TbEndConverAbort = new TextBox();
            Label24 = new Label();
            TbAmbientTrack = new TextBox();
            Label25 = new Label();
            ChkbUnequipItems = new CheckBox();
            ChkbUnequipHItem = new CheckBox();
            Label26 = new Label();
            NudDelayEntry = new NumericUpDown();
            NudDelayReply = new NumericUpDown();
            Label27 = new Label();
            CmbxComputerType = new ComboBox();
            TabpagThisFile2 = new TabPage();
            DgStuntList = new DataGrid();
            Label30 = new Label();
            TabpagThisFile3 = new TabPage();
            TabpagDebug = new TabPage();
            TrkbTvIndent = new TrackBar();
            Label17 = new Label();
            TbLinkId = new TextBox();
            TbLinkedCnt = new TextBox();
            TbSharedCnt = new TextBox();
            Label18 = new Label();
            Label19 = new Label();
            BtnDebug = new Button();
            Label32 = new Label();
            Label33 = new Label();
            TrkbTvItemHeight = new TrackBar();
            TbLinkDesc = new TextBox();
            Label34 = new Label();
            BtnShowLists = new Button();
            BtnCollapseAll = new Button();
            BtnExpandAll = new Button();
            BtnSave = new Button();
            BtnTest = new Button();
            CmTVfunctions = new ContextMenu();
            CmiTvAdd = new MenuItem();
            CmiTvCut = new MenuItem();
            CmiTvCopy = new MenuItem();
            CmiTvPaste = new MenuItem();
            CmiTvPasteTree = new MenuItem();
            CmiTvPasteAsLink = new MenuItem();
            MenuItem2 = new MenuItem();
            CmiTvMoveNodeUp = new MenuItem();
            CmiTvMoveNodeDown = new MenuItem();
            TbSpeaker = new TextBox();
            BtnOpen = new Button();
            MainMenu1 = new MainMenu();
            MenuItem1 = new MenuItem();
            MiNew = new MenuItem();
            MiOpen = new MenuItem();
            MiSave = new MenuItem();
            MenuItem4 = new MenuItem();
            MiQuit = new MenuItem();
            ToolTip1 = new ToolTip(components);
            TabControl1.SuspendLayout();
            TabpagActionsTaken.SuspendLayout();
            TabpagCamera.SuspendLayout();
            NudCamFieldOfView.BeginInit();
            NudFadeColorG.BeginInit();
            NudFadeColorB.BeginInit();
            NudFadeColorR.BeginInit();
            NudCameraId.BeginInit();
            NudCamHeightOffset.BeginInit();
            NudCameraAngle.BeginInit();
            NudTarHeightOffset.BeginInit();
            NudFadeDelay.BeginInit();
            NudFadeLength.BeginInit();
            TabpagAnimationSound.SuspendLayout();
            DgAnimList.BeginInit();
            TabpagPlot.SuspendLayout();
            NudPlotIndex.BeginInit();
            NudPlotXpPercentage.BeginInit();
            NudQuestEntry.BeginInit();
            TabpagComment.SuspendLayout();
            TabpagThisFile1.SuspendLayout();
            NudDelayEntry.BeginInit();
            NudDelayReply.BeginInit();
            TabpagThisFile2.SuspendLayout();
            DgStuntList.BeginInit();
            TabpagDebug.SuspendLayout();
            TrkbTvIndent.BeginInit();
            TrkbTvItemHeight.BeginInit();
            SuspendLayout();
            TvConversation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TvConversation.HideSelection = false;
            TvConversation.ImageIndex = -1;
            TvConversation.Indent = 16;
            TvConversation.ItemHeight = 16;
            TreeView tvConversation1 = TvConversation;
            Point point1 = new Point(32, 8);
            Point point2 = point1;
            tvConversation1.Location = point2;
            TvConversation.Name = "tvConversation";
            TvConversation.SelectedImageIndex = -1;
            TreeView tvConversation2 = TvConversation;
            Size size1 = new Size(736, 272);
            Size size2 = size1;
            tvConversation2.Size = size2;
            TvConversation.TabIndex = 0;
            TbConversationText.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TextBox conversationText1 = TbConversationText;
            point1 = new Point(32, 400);
            Point point3 = point1;
            conversationText1.Location = point3;
            TbConversationText.Multiline = true;
            TbConversationText.Name = "tbConversationText";
            TbConversationText.ScrollBars = ScrollBars.Vertical;
            TextBox conversationText2 = TbConversationText;
            size1 = new Size(240, 104);
            Size size3 = size1;
            conversationText2.Size = size3;
            TbConversationText.TabIndex = 4;
            TbConversationText.Text = "";
            Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label label11 = Label1;
            point1 = new Point(32, 336);
            Point point4 = point1;
            label11.Location = point4;
            Label1.Name = "Label1";
            Label label12 = Label1;
            size1 = new Size(100, 16);
            Size size4 = size1;
            label12.Size = size4;
            Label1.TabIndex = 3;
            Label1.Text = "Speaker Tag";
            Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label label21 = Label2;
            point1 = new Point(32, 384);
            Point point5 = point1;
            label21.Location = point5;
            Label2.Name = "Label2";
            Label label22 = Label2;
            size1 = new Size(100, 16);
            Size size5 = size1;
            label22.Size = size5;
            Label2.TabIndex = 3;
            Label2.Text = "Text";
            TabControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl1.Controls.Add(TabpagActionsTaken);
            TabControl1.Controls.Add(TabpagCamera);
            TabControl1.Controls.Add(TabpagAnimationSound);
            TabControl1.Controls.Add(TabpagPlot);
            TabControl1.Controls.Add(TabpagComment);
            TabControl1.Controls.Add(TabpagThisFile1);
            TabControl1.Controls.Add(TabpagThisFile2);
            TabControl1.Controls.Add(TabpagThisFile3);
            TabControl1.Controls.Add(TabpagDebug);
            TabControl tabControl11 = TabControl1;
            point1 = new Point(280, 296);
            Point point6 = point1;
            tabControl11.Location = point6;
            TabControl1.Multiline = true;
            TabControl1.Name = "TabControl1";
            TabControl tabControl12 = TabControl1;
            point1 = new Point(8, 3);
            Point point7 = point1;
            tabControl12.Padding = point7;
            TabControl1.SelectedIndex = 0;
            TabControl tabControl13 = TabControl1;
            size1 = new Size(488, 216);
            Size size6 = size1;
            tabControl13.Size = size6;
            TabControl1.SizeMode = TabSizeMode.FillToRight;
            TabControl1.TabIndex = 5;
            TabpagActionsTaken.Controls.Add(TbTextActiveScript);
            TabpagActionsTaken.Controls.Add(Label3);
            TabpagActionsTaken.Controls.Add(TbActionsTakenScript);
            TabpagActionsTaken.Controls.Add(Label4);
            TabpagActionsTaken.Controls.Add(TbTextActiveScript2);
            TabpagActionsTaken.Controls.Add(Label38);
            TabpagActionsTaken.Controls.Add(TbActionsTakenScript2);
            TabpagActionsTaken.Controls.Add(Label39);
            TabPage tabpagActionsTaken1 = TabpagActionsTaken;
            point1 = new Point(4, 40);
            Point point8 = point1;
            ((Control) tabpagActionsTaken1).Location = point8;
            TabpagActionsTaken.Name = "tabpagActionsTaken";
            TabPage tabpagActionsTaken2 = TabpagActionsTaken;
            size1 = new Size(480, 172);
            Size size7 = size1;
            tabpagActionsTaken2.Size = size7;
            TabpagActionsTaken.TabIndex = 0;
            TabpagActionsTaken.Text = "Node Scripts";
            TbTextActiveScript.CharacterCasing = CharacterCasing.Lower;
            TextBox textActiveScript1 = TbTextActiveScript;
            point1 = new Point(32, 88);
            Point point9 = point1;
            textActiveScript1.Location = point9;
            TbTextActiveScript.MaxLength = 16;
            TbTextActiveScript.Name = "tbTextActiveScript";
            TextBox textActiveScript2 = TbTextActiveScript;
            size1 = new Size(120, 20);
            Size size8 = size1;
            textActiveScript2.Size = size8;
            TbTextActiveScript.TabIndex = 6;
            TbTextActiveScript.Text = "";
            Label label31 = Label3;
            point1 = new Point(32, 72);
            Point point10 = point1;
            label31.Location = point10;
            Label3.Name = "Label3";
            Label label32 = Label3;
            size1 = new Size(216, 24);
            Size size9 = size1;
            label32.Size = size9;
            Label3.TabIndex = 7;
            Label3.Text = "Script that determines if node is available";
            TbActionsTakenScript.CharacterCasing = CharacterCasing.Lower;
            TextBox actionsTakenScript1 = TbActionsTakenScript;
            point1 = new Point(32, 32);
            Point point11 = point1;
            actionsTakenScript1.Location = point11;
            TbActionsTakenScript.MaxLength = 16;
            TbActionsTakenScript.Name = "tbActionsTakenScript";
            TextBox actionsTakenScript2 = TbActionsTakenScript;
            size1 = new Size(120, 20);
            Size size10 = size1;
            actionsTakenScript2.Size = size10;
            TbActionsTakenScript.TabIndex = 4;
            TbActionsTakenScript.Text = "";
            Label label41 = Label4;
            point1 = new Point(32, 16);
            Point point12 = point1;
            label41.Location = point12;
            Label4.Name = "Label4";
            Label label42 = Label4;
            size1 = new Size(136, 16);
            Size size11 = size1;
            label42.Size = size11;
            Label4.TabIndex = 5;
            Label4.Text = "Script to run for this node";
            TbTextActiveScript2.CharacterCasing = CharacterCasing.Lower;
            TextBox textActiveScript21 = TbTextActiveScript2;
            point1 = new Point(252, 88);
            Point point13 = point1;
            textActiveScript21.Location = point13;
            TbTextActiveScript2.MaxLength = 16;
            TbTextActiveScript2.Name = "tbTextActiveScript2";
            TextBox textActiveScript22 = TbTextActiveScript2;
            size1 = new Size(128, 20);
            Size size12 = size1;
            textActiveScript22.Size = size12;
            TbTextActiveScript2.TabIndex = 6;
            TbTextActiveScript2.Text = "";
            TbTextActiveScript2.Visible = false;
            Label label381 = Label38;
            point1 = new Point(252, 72);
            Point point14 = point1;
            label381.Location = point14;
            Label38.Name = "Label38";
            Label label382 = Label38;
            size1 = new Size(232, 24);
            Size size13 = size1;
            label382.Size = size13;
            Label38.TabIndex = 7;
            Label38.Text = "Script #2 that determines if node is available";
            Label38.Visible = false;
            TbActionsTakenScript2.CharacterCasing = CharacterCasing.Lower;
            TextBox actionsTakenScript21 = TbActionsTakenScript2;
            point1 = new Point(252, 32);
            Point point15 = point1;
            actionsTakenScript21.Location = point15;
            TbActionsTakenScript2.MaxLength = 16;
            TbActionsTakenScript2.Name = "tbActionsTakenScript2";
            TextBox actionsTakenScript22 = TbActionsTakenScript2;
            size1 = new Size(128, 20);
            Size size14 = size1;
            actionsTakenScript22.Size = size14;
            TbActionsTakenScript2.TabIndex = 4;
            TbActionsTakenScript2.Text = "";
            TbActionsTakenScript2.Visible = false;
            Label label391 = Label39;
            point1 = new Point(252, 16);
            Point point16 = point1;
            label391.Location = point16;
            Label39.Name = "Label39";
            Label label392 = Label39;
            size1 = new Size(144, 16);
            Size size15 = size1;
            label392.Size = size15;
            Label39.TabIndex = 5;
            Label39.Text = "Script #2 to run for this node";
            Label39.Visible = false;
            TabpagCamera.Controls.Add(NudCamFieldOfView);
            TabpagCamera.Controls.Add(CmbxCamVidEffect);
            TabpagCamera.Controls.Add(NudFadeColorG);
            TabpagCamera.Controls.Add(NudFadeColorB);
            TabpagCamera.Controls.Add(NudFadeColorR);
            TabpagCamera.Controls.Add(CmbxFadeType);
            TabpagCamera.Controls.Add(NudCameraId);
            TabpagCamera.Controls.Add(NudCamHeightOffset);
            TabpagCamera.Controls.Add(NudCameraAngle);
            TabpagCamera.Controls.Add(Label7);
            TabpagCamera.Controls.Add(Label8);
            TabpagCamera.Controls.Add(TbListener);
            TabpagCamera.Controls.Add(Label9);
            TabpagCamera.Controls.Add(Label11);
            TabpagCamera.Controls.Add(Label13);
            TabpagCamera.Controls.Add(Label14);
            TabpagCamera.Controls.Add(Label15);
            TabpagCamera.Controls.Add(Label16);
            TabpagCamera.Controls.Add(BtnChooseColor);
            TabpagCamera.Controls.Add(NudTarHeightOffset);
            TabpagCamera.Controls.Add(NudFadeDelay);
            TabpagCamera.Controls.Add(NudFadeLength);
            TabpagCamera.Controls.Add(Label28);
            TabpagCamera.Controls.Add(Label29);
            TabpagCamera.Controls.Add(Label37);
            TabPage tabpagCamera1 = TabpagCamera;
            point1 = new Point(4, 40);
            Point point17 = point1;
            ((Control) tabpagCamera1).Location = point17;
            TabpagCamera.Name = "tabpagCamera";
            TabPage tabpagCamera2 = TabpagCamera;
            size1 = new Size(480, 172);
            Size size16 = size1;
            tabpagCamera2.Size = size16;
            TabpagCamera.TabIndex = 5;
            TabpagCamera.Text = "Camera";
            NudCamFieldOfView.DecimalPlaces = 2;
            NudCamFieldOfView.Enabled = false;
            NumericUpDown nudCamFieldOfView1 = NudCamFieldOfView;
            point1 = new Point(296, 80);
            Point point18 = point1;
            nudCamFieldOfView1.Location = point18;
            NumericUpDown nudCamFieldOfView2 = NudCamFieldOfView;
            Decimal num1 = new Decimal(new int[4] {35999, 0, 0, 131072});
            Decimal num2 = num1;
            nudCamFieldOfView2.Maximum = num2;
            NudCamFieldOfView.Name = "nudCamFieldOfView";
            NumericUpDown nudCamFieldOfView3 = NudCamFieldOfView;
            size1 = new Size(56, 20);
            Size size17 = size1;
            nudCamFieldOfView3.Size = size17;
            NudCamFieldOfView.TabIndex = 8;
            NudCamFieldOfView.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(NudCamFieldOfView, "This is the angle in degrees that the camera sees");
            NumericUpDown nudCamFieldOfView4 = NudCamFieldOfView;
            num1 = new Decimal(new int[4] {35999, 0, 0, 131072});
            Decimal num3 = num1;
            nudCamFieldOfView4.Value = num3;
            CmbxCamVidEffect.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbxCamVidEffect.Items.AddRange(new object[3]
            {
                "(none)",
                "Blue Filter",
                "Red Filter"
            });
            ComboBox cmbxCamVidEffect1 = CmbxCamVidEffect;
            point1 = new Point(256, 48);
            Point point19 = point1;
            cmbxCamVidEffect1.Location = point19;
            CmbxCamVidEffect.Name = "cmbxCamVidEffect";
            ComboBox cmbxCamVidEffect2 = CmbxCamVidEffect;
            size1 = new Size(96, 21);
            Size size18 = size1;
            cmbxCamVidEffect2.Size = size18;
            CmbxCamVidEffect.TabIndex = 12;
            ToolTip1.SetToolTip(CmbxCamVidEffect,
                "Selecting one of the two colors will make the conversation look like it was viewed through a filter of that color");
            NudFadeColorG.Enabled = false;
            NumericUpDown nudFadeColorG1 = NudFadeColorG;
            point1 = new Point(368, 112);
            Point point20 = point1;
            nudFadeColorG1.Location = point20;
            NumericUpDown nudFadeColorG2 = NudFadeColorG;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num4 = num1;
            nudFadeColorG2.Maximum = num4;
            NudFadeColorG.Name = "nudFadeColorG";
            NumericUpDown nudFadeColorG3 = NudFadeColorG;
            size1 = new Size(48, 20);
            Size size19 = size1;
            nudFadeColorG3.Size = size19;
            NudFadeColorG.TabIndex = 8;
            NudFadeColorG.TextAlign = HorizontalAlignment.Right;
            NudFadeColorB.Enabled = false;
            NumericUpDown nudFadeColorB1 = NudFadeColorB;
            point1 = new Point(424, 112);
            Point point21 = point1;
            nudFadeColorB1.Location = point21;
            NumericUpDown nudFadeColorB2 = NudFadeColorB;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num5 = num1;
            nudFadeColorB2.Maximum = num5;
            NudFadeColorB.Name = "nudFadeColorB";
            NumericUpDown nudFadeColorB3 = NudFadeColorB;
            size1 = new Size(48, 20);
            Size size20 = size1;
            nudFadeColorB3.Size = size20;
            NudFadeColorB.TabIndex = 9;
            NudFadeColorB.TextAlign = HorizontalAlignment.Right;
            NudFadeColorR.Enabled = false;
            NumericUpDown nudFadeColorR1 = NudFadeColorR;
            point1 = new Point(312, 112);
            Point point22 = point1;
            nudFadeColorR1.Location = point22;
            NumericUpDown nudFadeColorR2 = NudFadeColorR;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num6 = num1;
            nudFadeColorR2.Maximum = num6;
            NudFadeColorR.Name = "nudFadeColorR";
            NumericUpDown nudFadeColorR3 = NudFadeColorR;
            size1 = new Size(48, 20);
            Size size21 = size1;
            nudFadeColorR3.Size = size21;
            NudFadeColorR.TabIndex = 8;
            NudFadeColorR.TextAlign = HorizontalAlignment.Right;
            CmbxFadeType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbxFadeType.Items.AddRange(new object[5]
            {
                "(none)",
                "Cut to Black",
                "Cut to Scene",
                "Fade to Scene",
                "Fade to Fade Color"
            });
            ComboBox cmbxFadeType1 = CmbxFadeType;
            point1 = new Point(384, 16);
            Point point23 = point1;
            cmbxFadeType1.Location = point23;
            CmbxFadeType.Name = "cmbxFadeType";
            ComboBox cmbxFadeType2 = CmbxFadeType;
            size1 = new Size(96, 21);
            Size size22 = size1;
            cmbxFadeType2.Size = size22;
            CmbxFadeType.TabIndex = 12;
            NumericUpDown nudCameraId1 = NudCameraId;
            point1 = new Point(264, 16);
            Point point24 = point1;
            nudCameraId1.Location = point24;
            NumericUpDown nudCameraId2 = NudCameraId;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num7 = num1;
            nudCameraId2.Maximum = num7;
            NudCameraId.Name = "nudCameraID";
            NumericUpDown nudCameraId3 = NudCameraId;
            size1 = new Size(40, 20);
            Size size23 = size1;
            nudCameraId3.Size = size23;
            NudCameraId.TabIndex = 11;
            NudCameraId.TextAlign = HorizontalAlignment.Right;
            ToolTip1.SetToolTip(NudCameraId,
                "The Camera ID indicates which Camera in a module shoould the Conversation be viewed from. It should be in the same room and the conversants.");
            NudCamHeightOffset.DecimalPlaces = 2;
            NumericUpDown nudCamHeightOffset1 = NudCamHeightOffset;
            num1 = new Decimal(new int[4] {5, 0, 0, 131072});
            Decimal num8 = num1;
            nudCamHeightOffset1.Increment = num8;
            NumericUpDown nudCamHeightOffset2 = NudCamHeightOffset;
            point1 = new Point(120, 48);
            Point point25 = point1;
            nudCamHeightOffset2.Location = point25;
            NumericUpDown nudCamHeightOffset3 = NudCamHeightOffset;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num9 = num1;
            nudCamHeightOffset3.Maximum = num9;
            NudCamHeightOffset.Name = "nudCamHeightOffset";
            NudCamHeightOffset.ReadOnly = true;
            NumericUpDown nudCamHeightOffset4 = NudCamHeightOffset;
            size1 = new Size(56, 20);
            Size size24 = size1;
            nudCamHeightOffset4.Size = size24;
            NudCamHeightOffset.TabIndex = 11;
            NudCamHeightOffset.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudCameraAngle1 = NudCameraAngle;
            point1 = new Point(120, 16);
            Point point26 = point1;
            nudCameraAngle1.Location = point26;
            NumericUpDown nudCameraAngle2 = NudCameraAngle;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num10 = num1;
            nudCameraAngle2.Maximum = num10;
            NudCameraAngle.Name = "nudCameraAngle";
            NumericUpDown nudCameraAngle3 = NudCameraAngle;
            size1 = new Size(40, 20);
            Size size25 = size1;
            nudCameraAngle3.Size = size25;
            NudCameraAngle.TabIndex = 11;
            NudCameraAngle.TextAlign = HorizontalAlignment.Right;
            Label label71 = Label7;
            point1 = new Point(8, 16);
            Point point27 = point1;
            label71.Location = point27;
            Label7.Name = "Label7";
            Label label72 = Label7;
            size1 = new Size(100, 16);
            Size size26 = size1;
            label72.Size = size26;
            Label7.TabIndex = 5;
            Label7.Text = "Camera Angle";
            Label label81 = Label8;
            point1 = new Point(320, 16);
            Point point28 = point1;
            label81.Location = point28;
            Label8.Name = "Label8";
            Label label82 = Label8;
            size1 = new Size(64, 16);
            Size size27 = size1;
            label82.Size = size27;
            Label8.TabIndex = 5;
            Label8.Text = "Fade Type";
            TextBox tbListener1 = TbListener;
            point1 = new Point(88, 112);
            Point point29 = point1;
            tbListener1.Location = point29;
            TbListener.Name = "tbListener";
            TextBox tbListener2 = TbListener;
            size1 = new Size(136, 20);
            Size size28 = size1;
            tbListener2.Size = size28;
            TbListener.TabIndex = 3;
            TbListener.Text = "";
            Label label91 = Label9;
            point1 = new Point(8, 112);
            Point point30 = point1;
            label91.Location = point30;
            Label9.Name = "Label9";
            Label label92 = Label9;
            size1 = new Size(48, 16);
            Size size29 = size1;
            label92.Size = size29;
            Label9.TabIndex = 5;
            Label9.Text = "Listener";
            Label label111 = Label11;
            point1 = new Point(360, 48);
            Point point31 = point1;
            label111.Location = point31;
            Label11.Name = "Label11";
            Label label112 = Label11;
            size1 = new Size(64, 16);
            Size size30 = size1;
            label112.Size = size30;
            Label11.TabIndex = 5;
            Label11.Text = "Fade Delay";
            Label label131 = Label13;
            point1 = new Point(8, 48);
            Point point32 = point1;
            label131.Location = point32;
            Label13.Name = "Label13";
            Label label132 = Label13;
            size1 = new Size(120, 16);
            Size size31 = size1;
            label132.Size = size31;
            Label13.TabIndex = 5;
            Label13.Text = "Camera Height Offset";
            Label label141 = Label14;
            point1 = new Point(360, 80);
            Point point33 = point1;
            label141.Location = point33;
            Label14.Name = "Label14";
            Label label142 = Label14;
            size1 = new Size(72, 16);
            Size size32 = size1;
            label142.Size = size32;
            Label14.TabIndex = 5;
            Label14.Text = "Fade Length";
            Label label151 = Label15;
            point1 = new Point(248, 112);
            Point point34 = point1;
            label151.Location = point34;
            Label15.Name = "Label15";
            Label label152 = Label15;
            size1 = new Size(72, 16);
            Size size33 = size1;
            label152.Size = size33;
            Label15.TabIndex = 5;
            Label15.Text = "Fade Color";
            Label label161 = Label16;
            point1 = new Point(8, 80);
            Point point35 = point1;
            label161.Location = point35;
            Label16.Name = "Label16";
            Label label162 = Label16;
            size1 = new Size(96, 16);
            Size size34 = size1;
            label162.Size = size34;
            Label16.TabIndex = 5;
            Label16.Text = "Tar Height Offset";
            Button btnChooseColor1 = BtnChooseColor;
            point1 = new Point(448, 144);
            Point point36 = point1;
            btnChooseColor1.Location = point36;
            BtnChooseColor.Name = "btnChooseColor";
            Button btnChooseColor2 = BtnChooseColor;
            size1 = new Size(24, 23);
            Size size35 = size1;
            btnChooseColor2.Size = size35;
            BtnChooseColor.TabIndex = 10;
            BtnChooseColor.Text = "...";
            BtnChooseColor.Visible = false;
            NudTarHeightOffset.DecimalPlaces = 2;
            NumericUpDown nudTarHeightOffset1 = NudTarHeightOffset;
            num1 = new Decimal(new int[4] {5, 0, 0, 131072});
            Decimal num11 = num1;
            nudTarHeightOffset1.Increment = num11;
            NumericUpDown nudTarHeightOffset2 = NudTarHeightOffset;
            point1 = new Point(120, 80);
            Point point37 = point1;
            nudTarHeightOffset2.Location = point37;
            NumericUpDown nudTarHeightOffset3 = NudTarHeightOffset;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num12 = num1;
            nudTarHeightOffset3.Maximum = num12;
            NudTarHeightOffset.Name = "nudTarHeightOffset";
            NudTarHeightOffset.ReadOnly = true;
            NumericUpDown nudTarHeightOffset4 = NudTarHeightOffset;
            size1 = new Size(56, 20);
            Size size36 = size1;
            nudTarHeightOffset4.Size = size36;
            NudTarHeightOffset.TabIndex = 11;
            NudTarHeightOffset.TextAlign = HorizontalAlignment.Right;
            NudFadeDelay.DecimalPlaces = 2;
            NudFadeDelay.Enabled = false;
            NumericUpDown nudFadeDelay1 = NudFadeDelay;
            num1 = new Decimal(new int[4] {5, 0, 0, 131072});
            Decimal num13 = num1;
            nudFadeDelay1.Increment = num13;
            NumericUpDown nudFadeDelay2 = NudFadeDelay;
            point1 = new Point(432, 48);
            Point point38 = point1;
            nudFadeDelay2.Location = point38;
            NumericUpDown nudFadeDelay3 = NudFadeDelay;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num14 = num1;
            nudFadeDelay3.Maximum = num14;
            NudFadeDelay.Name = "nudFadeDelay";
            NumericUpDown nudFadeDelay4 = NudFadeDelay;
            size1 = new Size(48, 20);
            Size size37 = size1;
            nudFadeDelay4.Size = size37;
            NudFadeDelay.TabIndex = 11;
            NudFadeDelay.TextAlign = HorizontalAlignment.Right;
            NudFadeLength.DecimalPlaces = 2;
            NudFadeLength.Enabled = false;
            NumericUpDown nudFadeLength1 = NudFadeLength;
            num1 = new Decimal(new int[4] {5, 0, 0, 131072});
            Decimal num15 = num1;
            nudFadeLength1.Increment = num15;
            NumericUpDown nudFadeLength2 = NudFadeLength;
            point1 = new Point(432, 80);
            Point point39 = point1;
            nudFadeLength2.Location = point39;
            NumericUpDown nudFadeLength3 = NudFadeLength;
            num1 = new Decimal(new int[4]
            {
                byte.MaxValue,
                0,
                0,
                0
            });
            Decimal num16 = num1;
            nudFadeLength3.Maximum = num16;
            NudFadeLength.Name = "nudFadeLength";
            NumericUpDown nudFadeLength4 = NudFadeLength;
            size1 = new Size(48, 20);
            Size size38 = size1;
            nudFadeLength4.Size = size38;
            NudFadeLength.TabIndex = 11;
            NudFadeLength.TextAlign = HorizontalAlignment.Right;
            Label label281 = Label28;
            point1 = new Point(192, 16);
            Point point40 = point1;
            label281.Location = point40;
            Label28.Name = "Label28";
            Label label282 = Label28;
            size1 = new Size(80, 16);
            Size size39 = size1;
            label282.Size = size39;
            Label28.TabIndex = 5;
            Label28.Text = "Camera ID";
            Label label291 = Label29;
            point1 = new Point(192, 46);
            Point point41 = point1;
            label291.Location = point41;
            Label29.Name = "Label29";
            Label label292 = Label29;
            size1 = new Size(80, 32);
            Size size40 = size1;
            label292.Size = size40;
            Label29.TabIndex = 5;
            Label29.Text = "Camera Vid Effect";
            Label label371 = Label37;
            point1 = new Point(192, 81);
            Point point42 = point1;
            label371.Location = point42;
            Label37.Name = "Label37";
            Label label372 = Label37;
            size1 = new Size(112, 16);
            Size size41 = size1;
            label372.Size = size41;
            Label37.TabIndex = 5;
            Label37.Text = "Camera Field of View";
            TabpagAnimationSound.Controls.Add(DgAnimList);
            TabpagAnimationSound.Controls.Add(Label5);
            TabpagAnimationSound.Controls.Add(TbSound);
            TabpagAnimationSound.Controls.Add(Label6);
            TabpagAnimationSound.Controls.Add(TbVoiceOverResRef);
            TabpagAnimationSound.Controls.Add(Label10);
            TabpagAnimationSound.Controls.Add(BtnDeleteAnimListEntry);
            TabpagAnimationSound.Controls.Add(BtnAddAnimListEntry);
            TabPage tabpagAnimationSound1 = TabpagAnimationSound;
            point1 = new Point(4, 40);
            Point point43 = point1;
            ((Control) tabpagAnimationSound1).Location = point43;
            TabpagAnimationSound.Name = "tabpagAnimationSound";
            TabPage tabpagAnimationSound2 = TabpagAnimationSound;
            size1 = new Size(480, 172);
            Size size42 = size1;
            tabpagAnimationSound2.Size = size42;
            TabpagAnimationSound.TabIndex = 1;
            TabpagAnimationSound.Text = "Animation/Sound";
            DgAnimList.CaptionVisible = false;
            DgAnimList.DataMember = "";
            DgAnimList.HeaderForeColor = SystemColors.ControlText;
            DataGrid dgAnimList1 = DgAnimList;
            point1 = new Point(224, 32);
            Point point44 = point1;
            dgAnimList1.Location = point44;
            DgAnimList.Name = "dgAnimList";
            DataGrid dgAnimList2 = DgAnimList;
            size1 = new Size(248, 104);
            Size size43 = size1;
            dgAnimList2.Size = size43;
            DgAnimList.TabIndex = 8;
            Label label51 = Label5;
            point1 = new Point(248, 8);
            Point point45 = point1;
            label51.Location = point45;
            Label5.Name = "Label5";
            Label label52 = Label5;
            size1 = new Size(100, 16);
            Size size44 = size1;
            label52.Size = size44;
            Label5.TabIndex = 7;
            Label5.Text = "Play Animation";
            TbSound.CharacterCasing = CharacterCasing.Lower;
            TextBox tbSound1 = TbSound;
            point1 = new Point(32, 89);
            Point point46 = point1;
            tbSound1.Location = point46;
            TbSound.MaxLength = 16;
            TbSound.Name = "tbSound";
            TextBox tbSound2 = TbSound;
            size1 = new Size(120, 20);
            Size size45 = size1;
            tbSound2.Size = size45;
            TbSound.TabIndex = 2;
            TbSound.Text = "";
            Label label61 = Label6;
            point1 = new Point(32, 64);
            Point point47 = point1;
            label61.Location = point47;
            Label6.Name = "Label6";
            Label label62 = Label6;
            size1 = new Size(136, 16);
            Size size46 = size1;
            label62.Size = size46;
            Label6.TabIndex = 7;
            Label6.Text = "Play this sound (ResRef)";
            TbVoiceOverResRef.CharacterCasing = CharacterCasing.Lower;
            TextBox tbVoiceOverResRef1 = TbVoiceOverResRef;
            point1 = new Point(32, 32);
            Point point48 = point1;
            tbVoiceOverResRef1.Location = point48;
            TbVoiceOverResRef.MaxLength = 16;
            TbVoiceOverResRef.Name = "tbVoiceOverResRef";
            TextBox tbVoiceOverResRef2 = TbVoiceOverResRef;
            size1 = new Size(120, 20);
            Size size47 = size1;
            tbVoiceOverResRef2.Size = size47;
            TbVoiceOverResRef.TabIndex = 3;
            TbVoiceOverResRef.Text = "";
            Label label101 = Label10;
            point1 = new Point(32, 8);
            Point point49 = point1;
            label101.Location = point49;
            Label10.Name = "Label10";
            Label label102 = Label10;
            size1 = new Size(184, 16);
            Size size48 = size1;
            label102.Size = size48;
            Label10.TabIndex = 7;
            Label10.Text = "Play this Voice Over (ResRef)";
            BtnDeleteAnimListEntry.Enabled = false;
            Button deleteAnimListEntry1 = BtnDeleteAnimListEntry;
            point1 = new Point(360, 144);
            Point point50 = point1;
            deleteAnimListEntry1.Location = point50;
            BtnDeleteAnimListEntry.Name = "btnDeleteAnimListEntry";
            Button deleteAnimListEntry2 = BtnDeleteAnimListEntry;
            size1 = new Size(56, 23);
            Size size49 = size1;
            deleteAnimListEntry2.Size = size49;
            BtnDeleteAnimListEntry.TabIndex = 6;
            BtnDeleteAnimListEntry.Text = "Delete";
            Button addAnimListEntry1 = BtnAddAnimListEntry;
            point1 = new Point(288, 144);
            Point point51 = point1;
            addAnimListEntry1.Location = point51;
            BtnAddAnimListEntry.Name = "btnAddAnimListEntry";
            Button addAnimListEntry2 = BtnAddAnimListEntry;
            size1 = new Size(56, 23);
            Size size50 = size1;
            addAnimListEntry2.Size = size50;
            BtnAddAnimListEntry.TabIndex = 6;
            BtnAddAnimListEntry.Text = "Add";
            TabpagPlot.Controls.Add(TbQuest);
            TabpagPlot.Controls.Add(Label35);
            TabpagPlot.Controls.Add(NudPlotIndex);
            TabpagPlot.Controls.Add(LblPlotIndex);
            TabpagPlot.Controls.Add(Label12);
            TabpagPlot.Controls.Add(NudPlotXpPercentage);
            TabpagPlot.Controls.Add(Label36);
            TabpagPlot.Controls.Add(NudQuestEntry);
            TabPage tabpagPlot1 = TabpagPlot;
            point1 = new Point(4, 40);
            Point point52 = point1;
            ((Control) tabpagPlot1).Location = point52;
            TabpagPlot.Name = "tabpagPlot";
            TabPage tabpagPlot2 = TabpagPlot;
            size1 = new Size(480, 172);
            Size size51 = size1;
            tabpagPlot2.Size = size51;
            TabpagPlot.TabIndex = 6;
            TabpagPlot.Text = "Plot/Quest";
            TbQuest.CharacterCasing = CharacterCasing.Lower;
            TextBox tbQuest1 = TbQuest;
            point1 = new Point(176, 40);
            Point point53 = point1;
            tbQuest1.Location = point53;
            TbQuest.Name = "tbQuest";
            TextBox tbQuest2 = TbQuest;
            size1 = new Size(224, 20);
            Size size52 = size1;
            tbQuest2.Size = size52;
            TbQuest.TabIndex = 14;
            TbQuest.Text = "";
            Label label351 = Label35;
            point1 = new Point(176, 80);
            Point point54 = point1;
            label351.Location = point54;
            Label35.Name = "Label35";
            Label label352 = Label35;
            size1 = new Size(128, 16);
            Size size53 = size1;
            label352.Size = size53;
            Label35.TabIndex = 15;
            Label35.Text = "Quest Entry";
            NumericUpDown nudPlotIndex1 = NudPlotIndex;
            point1 = new Point(32, 40);
            Point point55 = point1;
            nudPlotIndex1.Location = point55;
            NumericUpDown nudPlotIndex2 = NudPlotIndex;
            num1 = new Decimal(new int[4] {999, 0, 0, 0});
            Decimal num17 = num1;
            nudPlotIndex2.Maximum = num17;
            NumericUpDown nudPlotIndex3 = NudPlotIndex;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num18 = num1;
            nudPlotIndex3.Minimum = num18;
            NudPlotIndex.Name = "nudPlotIndex";
            NumericUpDown nudPlotIndex4 = NudPlotIndex;
            size1 = new Size(40, 20);
            Size size54 = size1;
            nudPlotIndex4.Size = size54;
            NudPlotIndex.TabIndex = 12;
            NudPlotIndex.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudPlotIndex5 = NudPlotIndex;
            num1 = new Decimal(new int[4]
            {
                1,
                0,
                0,
                int.MinValue
            });
            Decimal num19 = num1;
            nudPlotIndex5.Value = num19;
            Label lblPlotIndex1 = LblPlotIndex;
            point1 = new Point(32, 24);
            Point point56 = point1;
            lblPlotIndex1.Location = point56;
            LblPlotIndex.Name = "lblPlotIndex";
            Label lblPlotIndex2 = LblPlotIndex;
            size1 = new Size(100, 16);
            Size size55 = size1;
            lblPlotIndex2.Size = size55;
            LblPlotIndex.TabIndex = 11;
            LblPlotIndex.Text = "Plot Index";
            Label label121 = Label12;
            point1 = new Point(32, 80);
            Point point57 = point1;
            label121.Location = point57;
            Label12.Name = "Label12";
            Label label122 = Label12;
            size1 = new Size(120, 16);
            Size size56 = size1;
            label122.Size = size56;
            Label12.TabIndex = 10;
            Label12.Text = "Plot XP Percentage";
            NumericUpDown plotXpPercentage1 = NudPlotXpPercentage;
            point1 = new Point(32, 96);
            Point point58 = point1;
            plotXpPercentage1.Location = point58;
            NudPlotXpPercentage.Name = "nudPlotXPPercentage";
            NumericUpDown plotXpPercentage2 = NudPlotXpPercentage;
            size1 = new Size(40, 20);
            Size size57 = size1;
            plotXpPercentage2.Size = size57;
            NudPlotXpPercentage.TabIndex = 12;
            NudPlotXpPercentage.TextAlign = HorizontalAlignment.Right;
            NumericUpDown plotXpPercentage3 = NudPlotXpPercentage;
            num1 = new Decimal(new int[4] {100, 0, 0, 0});
            Decimal num20 = num1;
            plotXpPercentage3.Value = num20;
            Label label361 = Label36;
            point1 = new Point(176, 24);
            Point point59 = point1;
            label361.Location = point59;
            Label36.Name = "Label36";
            Label label362 = Label36;
            size1 = new Size(128, 16);
            Size size58 = size1;
            label362.Size = size58;
            Label36.TabIndex = 15;
            Label36.Text = "Quest";
            NumericUpDown nudQuestEntry1 = NudQuestEntry;
            point1 = new Point(176, 96);
            Point point60 = point1;
            nudQuestEntry1.Location = point60;
            NumericUpDown nudQuestEntry2 = NudQuestEntry;
            num1 = new Decimal(new int[4] {-1, 0, 0, 0});
            Decimal num21 = num1;
            nudQuestEntry2.Maximum = num21;
            NudQuestEntry.Name = "nudQuestEntry";
            NumericUpDown nudQuestEntry3 = NudQuestEntry;
            size1 = new Size(88, 20);
            Size size59 = size1;
            nudQuestEntry3.Size = size59;
            NudQuestEntry.TabIndex = 12;
            NudQuestEntry.TextAlign = HorizontalAlignment.Right;
            TabpagComment.Controls.Add(TbComments);
            TabPage tabpagComment1 = TabpagComment;
            point1 = new Point(4, 40);
            Point point61 = point1;
            ((Control) tabpagComment1).Location = point61;
            TabpagComment.Name = "tabpagComment";
            TabPage tabpagComment2 = TabpagComment;
            size1 = new Size(480, 172);
            Size size60 = size1;
            tabpagComment2.Size = size60;
            TabpagComment.TabIndex = 2;
            TabpagComment.Text = "Comments";
            TbComments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextBox tbComments1 = TbComments;
            point1 = new Point(8, 16);
            Point point62 = point1;
            tbComments1.Location = point62;
            TbComments.Multiline = true;
            TbComments.Name = "tbComments";
            TbComments.ScrollBars = ScrollBars.Vertical;
            TextBox tbComments2 = TbComments;
            size1 = new Size(456, 136);
            Size size61 = size1;
            tbComments2.Size = size61;
            TbComments.TabIndex = 1;
            TbComments.Text = "";
            TabpagThisFile1.Controls.Add(ChkbAnimatedCut);
            TabpagThisFile1.Controls.Add(TbCameraModel);
            TabpagThisFile1.Controls.Add(Label31);
            TabpagThisFile1.Controls.Add(CmbxConversationType);
            TabpagThisFile1.Controls.Add(ChkbSkippable);
            TabpagThisFile1.Controls.Add(TbVoId);
            TabpagThisFile1.Controls.Add(Label20);
            TabpagThisFile1.Controls.Add(Label21);
            TabpagThisFile1.Controls.Add(TbEndConversation);
            TabpagThisFile1.Controls.Add(Label22);
            TabpagThisFile1.Controls.Add(Label23);
            TabpagThisFile1.Controls.Add(TbEndConverAbort);
            TabpagThisFile1.Controls.Add(Label24);
            TabpagThisFile1.Controls.Add(TbAmbientTrack);
            TabpagThisFile1.Controls.Add(Label25);
            TabpagThisFile1.Controls.Add(ChkbUnequipItems);
            TabpagThisFile1.Controls.Add(ChkbUnequipHItem);
            TabpagThisFile1.Controls.Add(Label26);
            TabpagThisFile1.Controls.Add(NudDelayEntry);
            TabpagThisFile1.Controls.Add(NudDelayReply);
            TabpagThisFile1.Controls.Add(Label27);
            TabpagThisFile1.Controls.Add(CmbxComputerType);
            TabPage tabpagThisFile11 = TabpagThisFile1;
            point1 = new Point(4, 40);
            Point point63 = point1;
            ((Control) tabpagThisFile11).Location = point63;
            TabpagThisFile1.Name = "tabpagThisFile1";
            TabPage tabpagThisFile12 = TabpagThisFile1;
            size1 = new Size(480, 172);
            Size size62 = size1;
            tabpagThisFile12.Size = size62;
            TabpagThisFile1.TabIndex = 3;
            TabpagThisFile1.Text = "This File (1)";
            CheckBox chkbAnimatedCut1 = ChkbAnimatedCut;
            point1 = new Point(16, 136);
            Point point64 = point1;
            chkbAnimatedCut1.Location = point64;
            ChkbAnimatedCut.Name = "chkbAnimatedCut";
            CheckBox chkbAnimatedCut2 = ChkbAnimatedCut;
            size1 = new Size(128, 24);
            Size size63 = size1;
            chkbAnimatedCut2.Size = size63;
            ChkbAnimatedCut.TabIndex = 16;
            ChkbAnimatedCut.Text = "Animated Cutscene";
            TbCameraModel.Enabled = false;
            TextBox tbCameraModel1 = TbCameraModel;
            point1 = new Point(160, 143);
            Point point65 = point1;
            tbCameraModel1.Location = point65;
            TbCameraModel.MaxLength = 16;
            TbCameraModel.Name = "tbCameraModel";
            TextBox tbCameraModel2 = TbCameraModel;
            size1 = new Size(120, 20);
            Size size64 = size1;
            tbCameraModel2.Size = size64;
            TbCameraModel.TabIndex = 14;
            TbCameraModel.Text = "";
            ToolTip1.SetToolTip(TbCameraModel, "This is the model name of the camera to use in Animated Cutscenes");
            Label label311 = Label31;
            point1 = new Point(160, 128);
            Point point66 = point1;
            label311.Location = point66;
            Label31.Name = "Label31";
            Label label312 = Label31;
            size1 = new Size(80, 16);
            Size size65 = size1;
            label312.Size = size65;
            Label31.TabIndex = 15;
            Label31.Text = "Camera Model";
            CmbxConversationType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbxConversationType.Items.AddRange(new object[5]
            {
                "Human",
                "Computer",
                "Type 2",
                "Type 3",
                "Type 4"
            });
            ComboBox conversationType1 = CmbxConversationType;
            point1 = new Point(8, 64);
            Point point67 = point1;
            conversationType1.Location = point67;
            CmbxConversationType.Name = "cmbxConversationType";
            ComboBox conversationType2 = CmbxConversationType;
            size1 = new Size(88, 21);
            Size size66 = size1;
            conversationType2.Size = size66;
            CmbxConversationType.TabIndex = 12;
            CheckBox chkbSkippable1 = ChkbSkippable;
            point1 = new Point(320, 8);
            Point point68 = point1;
            chkbSkippable1.Location = point68;
            ChkbSkippable.Name = "chkbSkippable";
            CheckBox chkbSkippable2 = ChkbSkippable;
            size1 = new Size(80, 24);
            Size size67 = size1;
            chkbSkippable2.Size = size67;
            ChkbSkippable.TabIndex = 11;
            ChkbSkippable.Text = "Skippable";
            TbVoId.CharacterCasing = CharacterCasing.Lower;
            TextBox tbVoId1 = TbVoId;
            point1 = new Point(8, 24);
            Point point69 = point1;
            tbVoId1.Location = point69;
            TbVoId.Name = "tbVO_ID";
            TextBox tbVoId2 = TbVoId;
            size1 = new Size(128, 20);
            Size size68 = size1;
            tbVoId2.Size = size68;
            TbVoId.TabIndex = 8;
            TbVoId.Text = "";
            Label label201 = Label20;
            point1 = new Point(8, 8);
            Point point70 = point1;
            label201.Location = point70;
            Label20.Name = "Label20";
            Label label202 = Label20;
            size1 = new Size(112, 16);
            Size size69 = size1;
            label202.Size = size69;
            Label20.TabIndex = 9;
            Label20.Text = "Voice Over Family ID";
            Label label211 = Label21;
            point1 = new Point(8, 48);
            Point point71 = point1;
            label211.Location = point71;
            Label21.Name = "Label21";
            Label label212 = Label21;
            size1 = new Size(104, 16);
            Size size70 = size1;
            label212.Size = size70;
            Label21.TabIndex = 9;
            Label21.Text = "Conversation Type";
            TbEndConversation.CharacterCasing = CharacterCasing.Lower;
            TextBox tbEndConversation1 = TbEndConversation;
            point1 = new Point(160, 24);
            Point point72 = point1;
            tbEndConversation1.Location = point72;
            TbEndConversation.MaxLength = 16;
            TbEndConversation.Name = "tbEndConversation";
            TextBox tbEndConversation2 = TbEndConversation;
            size1 = new Size(128, 20);
            Size size71 = size1;
            tbEndConversation2.Size = size71;
            TbEndConversation.TabIndex = 8;
            TbEndConversation.Text = "";
            Label label221 = Label22;
            point1 = new Point(160, 8);
            Point point73 = point1;
            label221.Location = point73;
            Label22.Name = "Label22";
            Label label222 = Label22;
            size1 = new Size(128, 16);
            Size size72 = size1;
            label222.Size = size72;
            Label22.TabIndex = 9;
            Label22.Text = "End Conv Normal Script";
            Label label231 = Label23;
            point1 = new Point(160, 48);
            Point point74 = point1;
            label231.Location = point74;
            Label23.Name = "Label23";
            Label label232 = Label23;
            size1 = new Size(128, 16);
            Size size73 = size1;
            label232.Size = size73;
            Label23.TabIndex = 9;
            Label23.Text = "End Conv Abort Script";
            TbEndConverAbort.CharacterCasing = CharacterCasing.Lower;
            TextBox tbEndConverAbort1 = TbEndConverAbort;
            point1 = new Point(160, 64);
            Point point75 = point1;
            tbEndConverAbort1.Location = point75;
            TbEndConverAbort.MaxLength = 16;
            TbEndConverAbort.Name = "tbEndConverAbort";
            TextBox tbEndConverAbort2 = TbEndConverAbort;
            size1 = new Size(128, 20);
            Size size74 = size1;
            tbEndConverAbort2.Size = size74;
            TbEndConverAbort.TabIndex = 8;
            TbEndConverAbort.Text = "";
            Label label241 = Label24;
            point1 = new Point(8, 88);
            Point point76 = point1;
            label241.Location = point76;
            Label24.Name = "Label24";
            Label label242 = Label24;
            size1 = new Size(104, 16);
            Size size75 = size1;
            label242.Size = size75;
            Label24.TabIndex = 9;
            Label24.Text = "Computer Type";
            TbAmbientTrack.CharacterCasing = CharacterCasing.Lower;
            TextBox tbAmbientTrack1 = TbAmbientTrack;
            point1 = new Point(160, 104);
            Point point77 = point1;
            tbAmbientTrack1.Location = point77;
            TbAmbientTrack.MaxLength = 16;
            TbAmbientTrack.Name = "tbAmbientTrack";
            TextBox tbAmbientTrack2 = TbAmbientTrack;
            size1 = new Size(128, 20);
            Size size76 = size1;
            tbAmbientTrack2.Size = size76;
            TbAmbientTrack.TabIndex = 8;
            TbAmbientTrack.Text = "";
            Label label251 = Label25;
            point1 = new Point(160, 88);
            Point point78 = point1;
            label251.Location = point78;
            Label25.Name = "Label25";
            Label label252 = Label25;
            size1 = new Size(128, 16);
            Size size77 = size1;
            label252.Size = size77;
            Label25.TabIndex = 9;
            Label25.Text = "Ambient Track";
            CheckBox chkbUnequipItems1 = ChkbUnequipItems;
            point1 = new Point(320, 32);
            Point point79 = point1;
            chkbUnequipItems1.Location = point79;
            ChkbUnequipItems.Name = "chkbUnequipItems";
            CheckBox chkbUnequipItems2 = ChkbUnequipItems;
            size1 = new Size(96, 24);
            Size size78 = size1;
            chkbUnequipItems2.Size = size78;
            ChkbUnequipItems.TabIndex = 11;
            ChkbUnequipItems.Text = "Unequip Items";
            CheckBox chkbUnequipHitem = ChkbUnequipHItem;
            point1 = new Point(320, 56);
            Point point80 = point1;
            chkbUnequipHitem.Location = point80;
            ChkbUnequipHItem.Name = "chkbUnequipHItem";
            ChkbUnequipHItem.TabIndex = 11;
            ChkbUnequipHItem.Text = "Unequip HItem";
            Label label261 = Label26;
            point1 = new Point(307, 88);
            Point point81 = point1;
            label261.Location = point81;
            Label26.Name = "Label26";
            Label label262 = Label26;
            size1 = new Size(64, 16);
            Size size79 = size1;
            label262.Size = size79;
            Label26.TabIndex = 9;
            Label26.Text = "Delay Entry";
            NumericUpDown nudDelayEntry1 = NudDelayEntry;
            point1 = new Point(304, 104);
            Point point82 = point1;
            nudDelayEntry1.Location = point82;
            NumericUpDown nudDelayEntry2 = NudDelayEntry;
            num1 = new Decimal(new int[4] {100000, 0, 0, 0});
            Decimal num22 = num1;
            nudDelayEntry2.Maximum = num22;
            NudDelayEntry.Name = "nudDelayEntry";
            NumericUpDown nudDelayEntry3 = NudDelayEntry;
            size1 = new Size(64, 20);
            Size size80 = size1;
            nudDelayEntry3.Size = size80;
            NudDelayEntry.TabIndex = 10;
            NudDelayEntry.TextAlign = HorizontalAlignment.Right;
            NumericUpDown nudDelayReply1 = NudDelayReply;
            point1 = new Point(400, 104);
            Point point83 = point1;
            nudDelayReply1.Location = point83;
            NumericUpDown nudDelayReply2 = NudDelayReply;
            num1 = new Decimal(new int[4] {100000, 0, 0, 0});
            Decimal num23 = num1;
            nudDelayReply2.Maximum = num23;
            NudDelayReply.Name = "nudDelayReply";
            NumericUpDown nudDelayReply3 = NudDelayReply;
            size1 = new Size(64, 20);
            Size size81 = size1;
            nudDelayReply3.Size = size81;
            NudDelayReply.TabIndex = 10;
            NudDelayReply.TextAlign = HorizontalAlignment.Right;
            Label label271 = Label27;
            point1 = new Point(400, 88);
            Point point84 = point1;
            label271.Location = point84;
            Label27.Name = "Label27";
            Label label272 = Label27;
            size1 = new Size(72, 16);
            Size size82 = size1;
            label272.Size = size82;
            Label27.TabIndex = 9;
            Label27.Text = "Delay Reply";
            CmbxComputerType.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbxComputerType.Enabled = false;
            CmbxComputerType.Items.AddRange(new object[2]
            {
                "Modern",
                "Ancient"
            });
            ComboBox cmbxComputerType1 = CmbxComputerType;
            point1 = new Point(8, 104);
            Point point85 = point1;
            cmbxComputerType1.Location = point85;
            CmbxComputerType.Name = "cmbxComputerType";
            ComboBox cmbxComputerType2 = CmbxComputerType;
            size1 = new Size(88, 21);
            Size size83 = size1;
            cmbxComputerType2.Size = size83;
            CmbxComputerType.TabIndex = 12;
            TabpagThisFile2.Controls.Add(DgStuntList);
            TabpagThisFile2.Controls.Add(Label30);
            TabPage tabpagThisFile21 = TabpagThisFile2;
            point1 = new Point(4, 40);
            Point point86 = point1;
            ((Control) tabpagThisFile21).Location = point86;
            TabpagThisFile2.Name = "tabpagThisFile2";
            TabPage tabpagThisFile22 = TabpagThisFile2;
            size1 = new Size(480, 172);
            Size size84 = size1;
            tabpagThisFile22.Size = size84;
            TabpagThisFile2.TabIndex = 8;
            TabpagThisFile2.Text = "This File (2)";
            DgStuntList.DataMember = "";
            DgStuntList.HeaderForeColor = SystemColors.ControlText;
            DataGrid dgStuntList1 = DgStuntList;
            point1 = new Point(56, 24);
            Point point87 = point1;
            dgStuntList1.Location = point87;
            DgStuntList.Name = "dgStuntList";
            DataGrid dgStuntList2 = DgStuntList;
            size1 = new Size(368, 112);
            Size size85 = size1;
            dgStuntList2.Size = size85;
            DgStuntList.TabIndex = 0;
            Label30.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Label label301 = Label30;
            point1 = new Point(56, 24);
            Point point88 = point1;
            label301.Location = point88;
            Label30.Name = "Label30";
            Label label302 = Label30;
            size1 = new Size(136, 16);
            Size size86 = size1;
            label302.Size = size86;
            Label30.TabIndex = 3;
            Label30.Text = "(Stunt List is View-only)";
            TabPage tabpagThisFile31 = TabpagThisFile3;
            point1 = new Point(4, 40);
            Point point89 = point1;
            ((Control) tabpagThisFile31).Location = point89;
            TabpagThisFile3.Name = "tabpagThisFile3";
            TabPage tabpagThisFile32 = TabpagThisFile3;
            size1 = new Size(480, 172);
            Size size87 = size1;
            tabpagThisFile32.Size = size87;
            TabpagThisFile3.TabIndex = 9;
            TabpagThisFile3.Text = "This File (3)";
            TabpagDebug.Controls.Add(TrkbTvIndent);
            TabpagDebug.Controls.Add(Label17);
            TabpagDebug.Controls.Add(TbLinkId);
            TabpagDebug.Controls.Add(TbLinkedCnt);
            TabpagDebug.Controls.Add(TbSharedCnt);
            TabpagDebug.Controls.Add(Label18);
            TabpagDebug.Controls.Add(Label19);
            TabpagDebug.Controls.Add(BtnDebug);
            TabpagDebug.Controls.Add(Label32);
            TabpagDebug.Controls.Add(Label33);
            TabpagDebug.Controls.Add(TrkbTvItemHeight);
            TabpagDebug.Controls.Add(TbLinkDesc);
            TabpagDebug.Controls.Add(Label34);
            TabpagDebug.Controls.Add(BtnShowLists);
            TabPage tabpagDebug1 = TabpagDebug;
            point1 = new Point(4, 40);
            Point point90 = point1;
            ((Control) tabpagDebug1).Location = point90;
            TabpagDebug.Name = "tabpagDebug";
            TabPage tabpagDebug2 = TabpagDebug;
            size1 = new Size(480, 172);
            Size size88 = size1;
            tabpagDebug2.Size = size88;
            TabpagDebug.TabIndex = 7;
            TabpagDebug.Text = "Debug information/ConfigOptions";
            TrackBar trkbTvIndent1 = TrkbTvIndent;
            point1 = new Point(280, 40);
            Point point91 = point1;
            trkbTvIndent1.Location = point91;
            TrkbTvIndent.Maximum = 30;
            TrkbTvIndent.Minimum = 15;
            TrkbTvIndent.Name = "trkbTVIndent";
            TrackBar trkbTvIndent2 = TrkbTvIndent;
            size1 = new Size(120, 42);
            Size size89 = size1;
            trkbTvIndent2.Size = size89;
            TrkbTvIndent.TabIndex = 9;
            TrkbTvIndent.Value = 16;
            Label label171 = Label17;
            point1 = new Point(56, 32);
            Point point92 = point1;
            label171.Location = point92;
            Label17.Name = "Label17";
            Label label172 = Label17;
            size1 = new Size(100, 16);
            Size size90 = size1;
            label172.Size = size90;
            Label17.TabIndex = 8;
            Label17.Text = "Link ID";
            TextBox tbLinkId1 = TbLinkId;
            point1 = new Point(168, 30);
            Point point93 = point1;
            tbLinkId1.Location = point93;
            TbLinkId.Name = "tbLinkID";
            TextBox tbLinkId2 = TbLinkId;
            size1 = new Size(56, 20);
            Size size91 = size1;
            tbLinkId2.Size = size91;
            TbLinkId.TabIndex = 7;
            TbLinkId.Text = "";
            TextBox tbLinkedCnt1 = TbLinkedCnt;
            point1 = new Point(168, 64);
            Point point94 = point1;
            tbLinkedCnt1.Location = point94;
            TbLinkedCnt.Name = "tbLinkedCnt";
            TextBox tbLinkedCnt2 = TbLinkedCnt;
            size1 = new Size(56, 20);
            Size size92 = size1;
            tbLinkedCnt2.Size = size92;
            TbLinkedCnt.TabIndex = 7;
            TbLinkedCnt.Text = "";
            TextBox tbSharedCnt1 = TbSharedCnt;
            point1 = new Point(168, 96);
            Point point95 = point1;
            tbSharedCnt1.Location = point95;
            TbSharedCnt.Name = "tbSharedCnt";
            TextBox tbSharedCnt2 = TbSharedCnt;
            size1 = new Size(56, 20);
            Size size93 = size1;
            tbSharedCnt2.Size = size93;
            TbSharedCnt.TabIndex = 7;
            TbSharedCnt.Text = "";
            Label label181 = Label18;
            point1 = new Point(56, 66);
            Point point96 = point1;
            label181.Location = point96;
            Label18.Name = "Label18";
            Label label182 = Label18;
            size1 = new Size(80, 16);
            Size size94 = size1;
            label182.Size = size94;
            Label18.TabIndex = 8;
            Label18.Text = "Linked to this";
            Label label191 = Label19;
            point1 = new Point(56, 98);
            Point point97 = point1;
            label191.Location = point97;
            Label19.Name = "Label19";
            Label label192 = Label19;
            size1 = new Size(100, 16);
            Size size95 = size1;
            label192.Size = size95;
            Label19.TabIndex = 8;
            Label19.Text = "Nodes sharing link";
            Button btnDebug1 = BtnDebug;
            point1 = new Point(280, 144);
            Point point98 = point1;
            btnDebug1.Location = point98;
            BtnDebug.Name = "btnDebug";
            Button btnDebug2 = BtnDebug;
            size1 = new Size(120, 23);
            Size size96 = size1;
            btnDebug2.Size = size96;
            BtnDebug.TabIndex = 6;
            BtnDebug.Text = "Show Debug Listing";
            Label label321 = Label32;
            point1 = new Point(288, 24);
            Point point99 = point1;
            label321.Location = point99;
            Label32.Name = "Label32";
            Label label322 = Label32;
            size1 = new Size(112, 16);
            Size size97 = size1;
            label322.Size = size97;
            Label32.TabIndex = 8;
            Label32.Text = "Treeview indent level";
            Label label331 = Label33;
            point1 = new Point(288, 88);
            Point point100 = point1;
            label331.Location = point100;
            Label33.Name = "Label33";
            Label label332 = Label33;
            size1 = new Size(112, 16);
            Size size98 = size1;
            label332.Size = size98;
            Label33.TabIndex = 8;
            Label33.Text = "Treeview item height";
            TrackBar trkbTvItemHeight1 = TrkbTvItemHeight;
            point1 = new Point(280, 104);
            Point point101 = point1;
            trkbTvItemHeight1.Location = point101;
            TrkbTvItemHeight.Maximum = 21;
            TrkbTvItemHeight.Minimum = 7;
            TrkbTvItemHeight.Name = "trkbTVItemHeight";
            TrackBar trkbTvItemHeight2 = TrkbTvItemHeight;
            size1 = new Size(120, 42);
            Size size99 = size1;
            trkbTvItemHeight2.Size = size99;
            TrkbTvItemHeight.TabIndex = 9;
            TrkbTvItemHeight.Value = 9;
            TextBox tbLinkDesc1 = TbLinkDesc;
            point1 = new Point(168, 128);
            Point point102 = point1;
            tbLinkDesc1.Location = point102;
            TbLinkDesc.Name = "tbLinkDesc";
            TextBox tbLinkDesc2 = TbLinkDesc;
            size1 = new Size(56, 20);
            Size size100 = size1;
            tbLinkDesc2.Size = size100;
            TbLinkDesc.TabIndex = 7;
            TbLinkDesc.Text = "";
            Label label341 = Label34;
            point1 = new Point(56, 128);
            Point point103 = point1;
            label341.Location = point103;
            Label34.Name = "Label34";
            Label label342 = Label34;
            size1 = new Size(100, 16);
            Size size101 = size1;
            label342.Size = size101;
            Label34.TabIndex = 8;
            Label34.Text = "Link Desc";
            Button btnShowLists1 = BtnShowLists;
            point1 = new Point(448, 144);
            Point point104 = point1;
            btnShowLists1.Location = point104;
            BtnShowLists.Name = "btnShowLists";
            Button btnShowLists2 = BtnShowLists;
            size1 = new Size(24, 23);
            Size size102 = size1;
            btnShowLists2.Size = size102;
            BtnShowLists.TabIndex = 6;
            BtnShowLists.Text = "D";
            BtnShowLists.Visible = false;
            //BtnCollapseAll.Image = (Image) resourceManager.GetObject("btnCollapseAll.Image");
            Button btnCollapseAll1 = BtnCollapseAll;
            point1 = new Point(5, 240);
            Point point105 = point1;
            btnCollapseAll1.Location = point105;
            BtnCollapseAll.Name = "btnCollapseAll";
            Button btnCollapseAll2 = BtnCollapseAll;
            size1 = new Size(24, 23);
            Size size103 = size1;
            btnCollapseAll2.Size = size103;
            BtnCollapseAll.TabIndex = 2;
            BtnCollapseAll.Text = "C";
            ToolTip1.SetToolTip(BtnCollapseAll, "Collapse all nodes in the treeview");
           // BtnExpandAll.Image = (Image) resourceManager.GetObject("btnExpandAll.Image");
            Button btnExpandAll1 = BtnExpandAll;
            point1 = new Point(5, 184);
            Point point106 = point1;
            btnExpandAll1.Location = point106;
            BtnExpandAll.Name = "btnExpandAll";
            Button btnExpandAll2 = BtnExpandAll;
            size1 = new Size(24, 23);
            Size size104 = size1;
            btnExpandAll2.Size = size104;
            BtnExpandAll.TabIndex = 1;
            BtnExpandAll.Text = "E";
            ToolTip1.SetToolTip(BtnExpandAll, "Expand all nodes in the treeview");
            Button btnSave1 = BtnSave;
            point1 = new Point(152, 312);
            Point point107 = point1;
            btnSave1.Location = point107;
            BtnSave.Name = "btnSave";
            Button btnSave2 = BtnSave;
            size1 = new Size(42, 23);
            Size size105 = size1;
            btnSave2.Size = size105;
            BtnSave.TabIndex = 6;
            BtnSave.Text = "Save";
            BtnSave.Visible = false;
            Button btnTest1 = BtnTest;
            point1 = new Point(8, 312);
            Point point108 = point1;
            btnTest1.Location = point108;
            BtnTest.Name = "btnTest";
            Button btnTest2 = BtnTest;
            size1 = new Size(40, 23);
            Size size106 = size1;
            btnTest2.Size = size106;
            BtnTest.TabIndex = 5;
            BtnTest.Text = "Test";
            BtnTest.Visible = false;
            CmTVfunctions.MenuItems.AddRange(new MenuItem[9]
            {
                CmiTvAdd,
                CmiTvCut,
                CmiTvCopy,
                CmiTvPaste,
                CmiTvPasteTree,
                CmiTvPasteAsLink,
                MenuItem2,
                CmiTvMoveNodeUp,
                CmiTvMoveNodeDown
            });
            CmiTvAdd.Index = 0;
            CmiTvAdd.Text = "Add";
            CmiTvCut.Index = 1;
            CmiTvCut.Text = "Cut";
            CmiTvCopy.Index = 2;
            CmiTvCopy.Text = "Copy";
            CmiTvPaste.Index = 3;
            CmiTvPaste.Text = "Paste Top Node on Clipboard";
            CmiTvPasteTree.Index = 4;
            CmiTvPasteTree.Text = "Paste Tree on Clipboard";
            CmiTvPasteAsLink.Index = 5;
            CmiTvPasteAsLink.Text = "Paste As Link";
            MenuItem2.Index = 6;
            MenuItem2.Text = "-";
            CmiTvMoveNodeUp.Index = 7;
            CmiTvMoveNodeUp.Text = "Move up";
            CmiTvMoveNodeDown.Index = 8;
            CmiTvMoveNodeDown.Text = "Move down";
            TbSpeaker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TbSpeaker.CharacterCasing = CharacterCasing.Lower;
            TextBox tbSpeaker1 = TbSpeaker;
            point1 = new Point(32, 360);
            Point point109 = point1;
            tbSpeaker1.Location = point109;
            TbSpeaker.Name = "tbSpeaker";
            TextBox tbSpeaker2 = TbSpeaker;
            size1 = new Size(128, 20);
            Size size107 = size1;
            tbSpeaker2.Size = size107;
            TbSpeaker.TabIndex = 9;
            TbSpeaker.Text = "";
            Button btnOpen1 = BtnOpen;
            point1 = new Point(88, 312);
            Point point110 = point1;
            btnOpen1.Location = point110;
            BtnOpen.Name = "btnOpen";
            Button btnOpen2 = BtnOpen;
            size1 = new Size(48, 23);
            Size size108 = size1;
            btnOpen2.Size = size108;
            BtnOpen.TabIndex = 6;
            BtnOpen.Text = "Open";
            BtnOpen.Visible = false;
            MainMenu1.MenuItems.AddRange(new MenuItem[1]
            {
                MenuItem1
            });
            MenuItem1.Index = 0;
            MenuItem1.MenuItems.AddRange(new MenuItem[5]
            {
                MiNew,
                MiOpen,
                MiSave,
                MenuItem4,
                MiQuit
            });
            MenuItem1.Text = "File";
            MiNew.Index = 0;
            MiNew.Text = "New";
            MiOpen.Index = 1;
            MiOpen.Shortcut = Shortcut.CtrlO;
            MiOpen.Text = "&Open";
            MiSave.Index = 2;
            MiSave.Shortcut = Shortcut.CtrlS;
            MiSave.Text = "&Save";
            MenuItem4.Index = 3;
            MenuItem4.Text = "-";
            MiQuit.Index = 4;
            MiQuit.Shortcut = Shortcut.CtrlQ;
            MiQuit.Text = "&Quit";
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(792, 517);
            ClientSize = size1;
            Controls.Add(TbSpeaker);
            Controls.Add(TbConversationText);
            Controls.Add(BtnCollapseAll);
            Controls.Add(TabControl1);
            Controls.Add(Label1);
            Controls.Add(TvConversation);
            Controls.Add(Label2);
            Controls.Add(BtnExpandAll);
            Controls.Add(BtnSave);
            Controls.Add(BtnTest);
            Controls.Add(BtnOpen);
            Menu = MainMenu1;
            Name = "frmDialogEditor";
            Text = "Conversation Editor";
            TabControl1.ResumeLayout(false);
            TabpagActionsTaken.ResumeLayout(false);
            TabpagCamera.ResumeLayout(false);
            NudCamFieldOfView.EndInit();
            NudFadeColorG.EndInit();
            NudFadeColorB.EndInit();
            NudFadeColorR.EndInit();
            NudCameraId.EndInit();
            NudCamHeightOffset.EndInit();
            NudCameraAngle.EndInit();
            NudTarHeightOffset.EndInit();
            NudFadeDelay.EndInit();
            NudFadeLength.EndInit();
            TabpagAnimationSound.ResumeLayout(false);
            DgAnimList.EndInit();
            TabpagPlot.ResumeLayout(false);
            NudPlotIndex.EndInit();
            NudPlotXpPercentage.EndInit();
            NudQuestEntry.EndInit();
            TabpagComment.ResumeLayout(false);
            TabpagThisFile1.ResumeLayout(false);
            NudDelayEntry.EndInit();
            NudDelayReply.EndInit();
            TabpagThisFile2.ResumeLayout(false);
            DgStuntList.EndInit();
            TabpagDebug.ResumeLayout(false);
            TrkbTvIndent.EndInit();
            TrkbTvItemHeight.EndInit();
            ResumeLayout(false);
        }

        public void SetupForNewDialog()
        {
            TvConversation.Nodes.Clear();
            TreeView tvConversation = TvConversation;
            ClsDlg clsDlg = new ClsDlg(ref tvConversation, KotorVersionIndex);
            TvConversation = tvConversation;
            _clsdlg = clsDlg;
            _gff = _clsdlg.DlgGff;
            _gff.AddFieldToStruct("", "DelayEntry", 4, 0);
            _gff.AddFieldToStruct("", "DelayReply", 4, 0);
            _gff.AddFieldToStruct("", "EndConversation", 11, "");
            _gff.AddFieldToStruct("", "EndConverAbort", 11, "");
            _gff.AddFieldToStruct("", "Skippable", 0, 0);
            _gff.AddFieldToStruct("", "CameraModel", 11, "");
            _gff.AddFieldToStruct("", "VO_ID", 10, "");
            _gff.AddFieldToStruct("", "ConversationType", 5, 0);
            _gff.AddFieldToStruct("", "ComputerType", 0, 0);
            _gff.AddFieldToStruct("", "OldHitCheck", 0, 0);
            _gff.AddFieldToStruct("", "AmbientTrack", 11, "");
            _gff.AddFieldToStruct("", "UnequipItems", 0, 0);
            _gff.AddFieldToStruct("", "AnimatedCut", 0, 0);
            _gff.AddFieldToStruct("", "UnequipHItem", 0, 0);
        }

        private void SaveFile()
        {
            Cursor current = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            _entryList = new ArrayList();
            _replyList = new ArrayList();
            _gff.ClearListElements("EntryList");
            _gff.ClearListElements("ReplyList");
            _gff.ClearListElements("StartingList");
            _gff.ClearListElements("StuntList");
            SeparateNodes((DlgConvListNode) TvConversation.Nodes[0], "Entry");
          
                foreach (DlgConvListNode entry in _entryList)
                {
                    _struct = CreateGffStructFromNode(entry);
                    int num1 = 0;
                    _struct.Type = num1;
                    _gff.AddListElement("EntryList", _struct);
                    _gff.CreateList("EntryList(" + StringType.FromInteger(num1) + ")", "AnimList");
                    if (entry.Animlist != null)
                    {
                        int num2 = 0;
                        int num3 = checked(entry.Animlist.Count - 1);
                        int index = num2;
                        while (index <= num3)
                        {
                            GffStruct @struct = new GffStruct(2, 0);
                            @struct.Fields[0] = new GffField(GffFieldTypes.GffCExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(entry.Animlist[index], null, "Participant", new object[0], null, null)));
                            @struct.Fields[1] = new GffField(GffFieldTypes.GffWord, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(entry.Animlist[index], null, "Animation", new object[0], null, null)));
                            _gff.AddListElement("EntryList(" + StringType.FromInteger(num1) + ").AnimList", @struct);
                            ++index;
                        }
                    }

                    _gff.CreateList("EntryList(" + StringType.FromInteger(num1) + ")", "RepliesList");
                    ++num1;
                }
         

            int num4 = 0;

            foreach (DlgConvListNode reply in _replyList)
            {
                _struct = CreateGffStructFromNode(reply);
                _struct.Type = num4;
                _gff.AddListElement("ReplyList", _struct);
                _gff.CreateList("ReplyList(" + StringType.FromInteger(num4) + ")", "EntriesList");
                _gff.CreateList("ReplyList(" + StringType.FromInteger(num4) + ")", "AnimList");
                if (reply.Animlist != null)
                {
                    int num1 = 0;
                    int num2 = checked(reply.Animlist.Count - 1);
                    int index = num1;
                    while (index <= num2)
                    {
                        GffStruct @struct = new GffStruct(2, 0);
                        @struct.Fields[0] = new GffField(GffFieldTypes.GffCExoString, "Participant", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(reply.Animlist[index], null, "Participant", new object[0], null, null)));
                        @struct.Fields[1] = new GffField(GffFieldTypes.GffWord, "Animation", RuntimeHelpers.GetObjectValue(LateBinding.LateGet(reply.Animlist[index], null, "Animation", new object[0], null, null)));
                        _gff.AddListElement("ReplyList(" + StringType.FromInteger(num4) + ").AnimList", @struct);
                        ++index;
                    }
                }

                ++num4;
                
            }


            foreach (DlgConvListNode node in TvConversation.Nodes[0].Nodes)
            {
                BuildGffLists(node, "Entry");
                GffStruct @struct = new GffStruct(2);
                @struct.Fields[0] = new GffField(GffFieldTypes.GffDword, "Index", _entryList.IndexOf(node));
                string str = node.ActiveScript ?? String.Empty;
                @struct.Fields[1] = new GffField(GffFieldTypes.GffCResRef, "Active", str);
                _gff.AddListElement("StartingList", @struct);
            }


            SetDlgRootItemsValues();
            Cursor.Current = current;
            string str1 = StringType.StrCmp(EditingFilePath, "", false) == 0
                ? StringType.FromObject(FileUtils.GetFilePath("save", ConfigOptions.Paths.DefaultSaveLocation,
                    _filename + ".dlg", string.Empty, string.Empty))
                : EditingFilePath;
            if (StringType.StrCmp(str1, string.Empty, false) == 0)
                return;
            _gff.WriteFile(str1, "DLG");
            _gff = _clsdlg.DlgGff;
            SetFormToDlgRootItems();
            Text = "Conversation Editor - " + Path.GetFileNameWithoutExtension(str1) + ".dlg";
        }

        private void SetDlgRootItemsValues()
        {
            if (!_gff.VerifyNodeExists("DelayEntry")) _gff.AddFieldToStruct("", "DelayEntry", 4, 0);
            if (!_gff.VerifyNodeExists("DelayReply")) _gff.AddFieldToStruct("", "DelayReply", 4, 0);
            if (!_gff.VerifyNodeExists("EndConversation")) _gff.AddFieldToStruct("", "EndConversation", 11, "");
            if (!_gff.VerifyNodeExists("EndConverAbort")) _gff.AddFieldToStruct("", "EndConverAbort", 11, "");
            if (!_gff.VerifyNodeExists("Skippable")) _gff.AddFieldToStruct("", "Skippable", 0, 0);
            if (!_gff.VerifyNodeExists("CameraModel")) _gff.AddFieldToStruct("", "CameraModel", 11, "");
            if (!_gff.VerifyNodeExists("VO_ID")) _gff.AddFieldToStruct("", "VO_ID", 10, "");
            if (!_gff.VerifyNodeExists("ConversationType")) _gff.AddFieldToStruct("", "ConversationType", 5, 0);
            if (CmbxConversationType.SelectedIndex == 1 && !_gff.VerifyNodeExists("ComputerType")) _gff.AddFieldToStruct("", "ComputerType", 0, 0);
            if (!_gff.VerifyNodeExists("OldHitCheck")) _gff.AddFieldToStruct("", "OldHitCheck", 0, 0);
            if (!_gff.VerifyNodeExists("AmbientTrack")) _gff.AddFieldToStruct("", "AmbientTrack", 11, "");
            if (!_gff.VerifyNodeExists("UnequipItems")) _gff.AddFieldToStruct("", "UnequipItems", 0, 0);
            if (!_gff.VerifyNodeExists("UnequipHItem")) _gff.AddFieldToStruct("", "UnequipHItem", 0, 0);
            if (!_gff.VerifyNodeExists("StuntList")) _gff.CreateList("", "StuntList");
            _gff.SetNodeValue("DelayEntry", NudDelayEntry.Value);
            _gff.SetNodeValue("DelayReply", NudDelayReply.Value);
            _gff.SetNodeValue("EndConversation", TbEndConversation.Text.Trim());
            _gff.SetNodeValue("EndConverAbort", TbEndConverAbort.Text.Trim());
            _gff.SetNodeValue("Skippable", ChkbSkippable.Checked);
            _gff.SetNodeValue("VO_ID", TbVoId.Text.Trim());
            _gff.SetNodeValue("ConversationType", CmbxConversationType.SelectedIndex);
            if (CmbxConversationType.SelectedIndex == 1) _gff.SetNodeValue("ComputerType", checked((byte) CmbxComputerType.SelectedIndex));
            _gff.SetNodeValue("AmbientTrack", TbAmbientTrack.Text.Trim());
            _gff.SetNodeValue("UnequipItems", ChkbUnequipItems.Checked);
            _gff.SetNodeValue("UnequipHItem", ChkbUnequipHItem.Checked);
            if (_gff.VerifyNodeExists("AnimatedCut"))
            {
                ChkbAnimatedCut.Checked = BooleanType.FromObject(_gff.GetNodeValue("AnimatedCut"));
                if (!_gff.VerifyNodeExists("CameraModel")) _gff.AddFieldToStruct(string.Empty, "CameraModel", 11, string.Empty);
                _gff.SetNodeValueFromTextBox(TbCameraModel, "CameraModel");
            }
            else if (ChkbAnimatedCut.Checked)
            {
                if (!_gff.VerifyNodeExists("AnimatedCut")) _gff.AddFieldToStruct("", "AnimatedCut", 0, 0);
                _gff.SetNodeValue("AnimatedCut", 1);
                if (!_gff.VerifyNodeExists("CameraModel")) _gff.AddFieldToStruct("", "CameraModel", 11, "");
                _gff.SetNodeValueFromTextBox(TbCameraModel, "CameraModel");
            }

            int num1 = 0;
            int num2 = checked(_dViewStunt.Table.Rows.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                GffStruct gs = new GffStruct(2, 0);
                gs.Fields[0] = new GffField(GffFieldTypes.GffCExoString, "Participant", RuntimeHelpers.GetObjectValue(_dViewStunt.Table.Rows[index]["Participant"]));
                gs.Fields[1] = new GffField(GffFieldTypes.GffCResRef, "StuntModel", RuntimeHelpers.GetObjectValue(_dViewStunt.Table.Rows[index]["StuntModel"]));
                _gff.AddListElement("StuntList", gs);
                ++index;
            }
        }

        private void SetFormToDlgRootItems()
        {
            _gff.SetNumericUpDownToUIntNodeValue(NudDelayEntry, "DelayEntry");
            _gff.SetNumericUpDownToUIntNodeValue(NudDelayReply, "DelayReply");
            _gff.SetTextBoxToNodeValue(TbEndConversation, "EndConversation");
            _gff.SetTextBoxToNodeValue(TbEndConverAbort, "EndConverAbort");
            ChkbSkippable.Checked = BooleanType.FromObject(_gff.GetNodeValue("Skippable"));
            ChkbUnequipItems.Checked = BooleanType.FromObject(_gff.GetNodeValue("UnequipItems"));
            ChkbUnequipHItem.Checked = BooleanType.FromObject(_gff.GetNodeValue("UnequipHItem"));
            _gff.SetTextBoxToNodeValue(TbVoId, "VO_ID");
            CmbxConversationType.SelectedIndex = IntegerType.FromObject(_gff.GetNodeValue("ConversationType"));
            if (CmbxConversationType.SelectedIndex == 1) CmbxComputerType.SelectedIndex = IntegerType.FromObject(_gff.GetNodeValue("ComputerType"));
            _gff.SetTextBoxToNodeValue(TbAmbientTrack, "AmbientTrack");
            _gff.SetTextBoxToNodeValue(TbCameraModel, "CameraModel");
            ChkbAnimatedCut.Checked = BooleanType.FromObject(_gff.GetNodeValue("AnimatedCut"));
            if (!_gff.VerifyNodeExists("StuntList") || _gff.GetListItemCount("StuntList") <= 0) return;
            int num1 = 0;
            int num2 = checked(_gff.GetListItemCount("StuntList") - 1);
            int num3 = num1;
            while (num3 <= num2)
            {
                DataRow row = _dtStunt.NewRow();
                row[0] = RuntimeHelpers.GetObjectValue(_gff.GetNodeValue("StuntList(" + StringType.FromInteger(num3) + ").Participant"));
                row[1] = RuntimeHelpers.GetObjectValue(_gff.GetNodeValue("StuntList(" + StringType.FromInteger(num3) + ").StuntModel"));
                _dtStunt.Rows.Add(row);
                ++num3;
                
            }
        }

        private GffStruct CreateGffStructFromNode(DlgConvListNode tn)
        {
            GffStruct gffStruct1 = new GffStruct();
            gffStruct1.FieldCount = 4;
            gffStruct1.Fields = new GffField[checked(gffStruct1.FieldCount - 1 + 1)];
            GffExoLocString gffExoLocString = new GffExoLocString();
            gffExoLocString.StringCount = 1;
            gffExoLocString.StringRef = -1;
            gffExoLocString.SubStringArr = new object[1];
            gffExoLocString.SubStringArr[0] = new GffExoLocSubString()
            {
                StringId = 0,
                StringLength = tn.InternalText.Length,
                Value = tn.InternalText
            };
            gffExoLocString.Size = checked(16 + tn.InternalText.Length);
            gffStruct1.Fields[0] = new GffField(GffFieldTypes.GffCExoLocString, "Text", gffExoLocString);
            gffStruct1.Fields[1] = new GffField(GffFieldTypes.GffDword, "Delay", (long) uint.MaxValue);
            gffStruct1.Fields[2] = new GffField(GffFieldTypes.GffDword, "WaitFlags", 0);
            gffStruct1.Fields[3] = new GffField(GffFieldTypes.GffByte, "FadeType", tn.FadeType);
            if (StringType.StrCmp(tn.Script, null, false) != 0 && StringType.StrCmp(tn.Script, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCResRef, "Script", tn.Script);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (StringType.StrCmp(tn.Sound, null, false) != 0 && StringType.StrCmp(tn.Sound, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCResRef, "Sound", tn.Sound);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (StringType.StrCmp(tn.VoResRef, null, false) != 0 && StringType.StrCmp(tn.VoResRef, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCResRef, "VO_ResRef", tn.VoResRef);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (StringType.StrCmp(tn.Speaker, null, false) != 0 && StringType.StrCmp(tn.Speaker, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCExoString, "Speaker", tn.Speaker);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (StringType.StrCmp(tn.Comment, null, false) != 0 && StringType.StrCmp(tn.Comment, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCExoString, "Comment", tn.Comment);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (StringType.StrCmp(tn.Listener, null, false) != 0 && StringType.StrCmp(tn.Listener, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCExoString, "Listener", tn.Listener);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (tn.CameraAngle > 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffDword, "CameraAngle", tn.CameraAngle);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 1);
            }

            if (StringType.StrCmp(tn.Quest, null, false) != 0 && StringType.StrCmp(tn.Quest, "", false) != 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1 + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffCExoString, "Quest", tn.Quest);
                gffStruct1.Fields[checked(gffStruct1.FieldCount + 1)] = new GffField(GffFieldTypes.GffDword, "QuestEntry", tn.QuestEntry);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 2);
            }

            if (tn.FadeType > 0)
            {
                gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 2 + 1)]);
                gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffFloat, "FadeDelay", tn.FadeDelay);
                gffStruct1.Fields[checked(gffStruct1.FieldCount + 1)] = new GffField(GffFieldTypes.GffFloat, "FadeLength", tn.FadeLength);
                if (tn.FadeColor == null)
                {
                    tn.FadeColor = new GffType17();
                    tn.FadeColor.F1 = 0.0f;
                    tn.FadeColor.F2 = 0.0f;
                    tn.FadeColor.F3 = 0.0f;
                }

                gffStruct1.Fields[checked(gffStruct1.FieldCount + 2)] = new GffField(GffFieldTypes.GffType17, "FadeColor", tn.FadeColor);
                GffStruct gffStruct2 = gffStruct1;
                gffStruct2.FieldCount = checked(gffStruct2.FieldCount + 3);
            }

            gffStruct1.Fields = (GffField[]) Microsoft.VisualBasic.CompilerServices.Utils.CopyArray(gffStruct1.Fields, new GffField[checked(gffStruct1.FieldCount + 1 + 1)]);
            gffStruct1.Fields[gffStruct1.FieldCount] = new GffField(GffFieldTypes.GffInt, "CameraID", tn.CameraId);
            gffStruct1.Fields[checked(gffStruct1.FieldCount + 1)] = new GffField(GffFieldTypes.GffInt, "CamVidEffect", tn.CamVidEffect);
            GffStruct gffStruct3 = gffStruct1;
            gffStruct3.FieldCount = checked(gffStruct3.FieldCount + 2);
            return gffStruct1;
        }

        private void RemoveChildLinks(DlgConvListNode parentNode)
        {
            foreach (DlgConvListNode node in parentNode.Nodes) RemoveChildLinks(node);
            if (parentNode.IsLink <= 0U) return;
            parentNode.LinkedToNode.LinkedNodesList.Remove(parentNode);
        }

        private void ResetChildNodesDescAfterPasteTree(DlgConvListNode parentNode)
        {
            foreach (DlgConvListNode node in parentNode.Nodes)
            {
                if (parentNode.IsReply) node.IsEntry = true;
                else node.IsReply = true;
                node.ForeColor = node.DialogColor;
                ResetChildNodesDescAfterPasteTree(node);
            }

            if (parentNode == TvConversation.Nodes[0]) return;
            parentNode.Text = parentNode.NodeDesc;
        }

        private void SeparateNodes(DlgConvListNode innode, string currNodeType)
        {
            foreach (DlgConvListNode node in innode.Nodes)
            {
                if (StringType.StrCmp(currNodeType, "Entry", false) == 0)
                {
                    _entryList.Add(node);
                    SeparateNodes(node, "Reply");
                }
                else
                {
                    _replyList.Add(node);
                    SeparateNodes(node, "Entry");
                }
            }
        }

        private void BuildGffLists(DlgConvListNode parentNode, string currNodeType)
        {
            foreach (DlgConvListNode node in parentNode.Nodes)
            {
                if (StringType.StrCmp(currNodeType, "Entry", false) == 0)
                {
                    GffStruct @struct = new GffStruct(3);
                    @struct.Fields[0] = (uint) node.IsLink <= 0U ? new GffField(GffFieldTypes.GffDword, "Index", _replyList.IndexOf(node)) : new GffField(GffFieldTypes.GffDword, "Index", _replyList.IndexOf(node.LinkedToNode));
                    @struct.Fields[1] = new GffField(GffFieldTypes.GffCResRef, "Active", node.ActiveScript);
                    @struct.Fields[2] = new GffField(GffFieldTypes.GffByte, "IsChild", node.IsLink);
                    _gff.AddListElement("EntryList(" + StringType.FromInteger(_entryList.IndexOf(parentNode)) + ").RepliesList", @struct);
                    if ((uint) ~node.IsLink > 0U) BuildGffLists(node, "Reply");
                }
                else
                {
                    GffStruct @struct = new GffStruct(3);
                    @struct.Fields[0] = (uint) node.IsLink <= 0U ? new GffField(GffFieldTypes.GffDword, "Index", _entryList.IndexOf(node)) : new GffField(GffFieldTypes.GffDword, "Index", _entryList.IndexOf(node.LinkedToNode));
                    @struct.Fields[1] = new GffField(GffFieldTypes.GffCResRef, "Active", node.ActiveScript);
                    @struct.Fields[2] = new GffField(GffFieldTypes.GffByte, "IsChild", node.IsLink);
                    _gff.AddListElement("ReplyList(" + StringType.FromInteger(_replyList.IndexOf(parentNode)) + ").EntriesList", @struct);
                    if ((uint) ~node.IsLink > 0U) BuildGffLists(node, "Entry");
                }
            }
        }

        private void BuildAnimDataGrid()
        {
            DataGridTableStyle table = new DataGridTableStyle();
            DgAnimList.TableStyles.Clear();
            table.MappingName = "ArrayList";
            table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240); // Green
            DataGridTextBoxColumn gridTextBoxColumn1 = new DataGridTextBoxColumn();
            gridTextBoxColumn1.MappingName = "Participant";
            gridTextBoxColumn1.HeaderText = "Participant";
            gridTextBoxColumn1.Alignment = HorizontalAlignment.Center;
            gridTextBoxColumn1.Width = 120;
            gridTextBoxColumn1.NullText = "";
            gridTextBoxColumn1.ReadOnly = false;
            table.GridColumnStyles.Add(gridTextBoxColumn1);
            DataGridTextBoxColumn gridTextBoxColumn2 = new DataGridTextBoxColumn();
            gridTextBoxColumn2.MappingName = "Animation";
            gridTextBoxColumn2.HeaderText = "Animation";
            gridTextBoxColumn2.Alignment = HorizontalAlignment.Center;
            gridTextBoxColumn2.Width = 75;
            gridTextBoxColumn2.NullText = "";
            gridTextBoxColumn2.TextBox.CharacterCasing = CharacterCasing.Lower;
            table.GridColumnStyles.Add(gridTextBoxColumn2);
            DgAnimList.TableStyles.Add(table);
            DgAnimList.CaptionText = "Animation List";
            DgAnimList.CaptionFont = new Font("Microsoft Sans Serif", 9f);
        }

        public void BuildStuntDataTable()
        {
            _dtStunt.Columns.Add(new DataColumn("Participant", typeof(string))
            {
                DefaultValue = ""
            });
            _dtStunt.Columns.Add(new DataColumn("StuntModel", typeof(string))
            {
                DefaultValue = ""
            });
            _dtStunt.TableName = "StuntList";
        }

        public void BuildStuntDataGrid()
        {
            BuildStuntDataTable();
            _dViewStunt = _dtStunt.DefaultView;
            _dViewStunt.AllowDelete = true;
            _dViewStunt.AllowNew = true;
            _dViewStunt.AllowEdit = true;
            DataGridTableStyle table = new DataGridTableStyle();
            DgStuntList.TableStyles.Clear();
            table.MappingName = _dtStunt.TableName;
            table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
            DataGridTextBoxColumn gridTextBoxColumn1 = new DataGridTextBoxColumn();
            gridTextBoxColumn1.MappingName = "Participant";
            gridTextBoxColumn1.HeaderText = "Participant";
            gridTextBoxColumn1.Alignment = HorizontalAlignment.Center;
            gridTextBoxColumn1.Width = 120;
            gridTextBoxColumn1.NullText = "";
            gridTextBoxColumn1.ReadOnly = false;
            table.GridColumnStyles.Add(gridTextBoxColumn1);
            DataGridTextBoxColumn gridTextBoxColumn2 = new DataGridTextBoxColumn();
            gridTextBoxColumn2.MappingName = "StuntModel";
            gridTextBoxColumn2.HeaderText = "Model";
            gridTextBoxColumn2.Alignment = HorizontalAlignment.Center;
            gridTextBoxColumn2.Width = 120;
            gridTextBoxColumn2.NullText = "";
            gridTextBoxColumn2.TextBox.CharacterCasing = CharacterCasing.Lower;
            gridTextBoxColumn2.TextBox.MaxLength = 16;
            table.GridColumnStyles.Add(gridTextBoxColumn2);
            DgStuntList.TableStyles.Add(table);
            DgStuntList.SetDataBinding(_dViewStunt, null);
            DgStuntList.CaptionText = "Stunt List";
            DgStuntList.CaptionFont = new Font("Microsoft Sans Serif", 9f);
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            TvConversation.ExpandAll();
            TvConversation.SelectedNode = TvConversation.Nodes[0];
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            TvConversation.CollapseAll();
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            frmTextEditor frmTextEditor = new frmTextEditor();
            frmTextEditor.Filename = "dialog";
            frmTextEditor.Text = "Text Editor - " + frmTextEditor.Filename;
            frmTextEditor.RTFMode = true;
            frmTextEditor.tbGeneric.Rtf = _clsdlg.ToString();
            frmTextEditor.tbGeneric.SelectionLength = 0;
            frmTextEditor.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            DlgConvListNode parent = (DlgConvListNode) selectedNode.Parent;
            int num = parent.Nodes.IndexOf(selectedNode);
            parent.Nodes.Remove(selectedNode);
            parent.Nodes.Insert(num - 1, selectedNode);
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            if (selectedNode.FadeColor == null)
            {
                selectedNode.FadeColor = new GffType17();
                selectedNode.FadeColor.F1 = 0.0f;
                selectedNode.FadeColor.F2 = 0.0f;
                selectedNode.FadeColor.F3 = 0.0f;
            }

            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;
            colorDialog.Color = Color.FromArgb(0, (int) Math.Round(selectedNode.FadeColor.F1), (int) Math.Round(selectedNode.FadeColor.F2), (int) Math.Round(selectedNode.FadeColor.F3));
            if (colorDialog.ShowDialog() != DialogResult.OK) return;
            NudFadeColorR.Text = StringType.FromByte(colorDialog.Color.R);
            NudFadeColorG.Text = StringType.FromByte(colorDialog.Color.G);
            NudFadeColorB.Text = StringType.FromByte(colorDialog.Color.B);
            selectedNode.FadeColor.F1 = Convert.ToSingle(colorDialog.Color.R);
            GffType17 fadeColor1 = selectedNode.FadeColor;
            Color color = colorDialog.Color;
            double single1 = Convert.ToSingle(color.G);
            fadeColor1.F2 = (float) single1;
            GffType17 fadeColor2 = selectedNode.FadeColor;
            color = colorDialog.Color;
            double single2 = Convert.ToSingle(color.B);
            fadeColor2.F3 = (float) single2;
        }

        private void WireUpEventHandlers()
        {
            TbConversationText.TextChanged += tbConversationText_TextChanged;
            TbTextActiveScript.TextChanged += tbTextActiveScript_TextChanged;
            TbActionsTakenScript.TextChanged += tbActionsTakenScript_TextChanged;
            NudPlotIndex.ValueChanged += nudPlotIndex_ValueChanged;
            NudPlotXpPercentage.ValueChanged += nudPlotXPPercentage_ValueChanged;
            TbComments.TextChanged += tbComments_TextChanged;
            NudCameraAngle.ValueChanged += nudCameraAngle_ValueChanged;
            NudCamHeightOffset.ValueChanged += nudCamHeightOffset_ValueChanged;
            NudTarHeightOffset.ValueChanged += nudTarHeightOffset_ValueChanged;
            TbListener.TextChanged += tbListener_TextChanged;
            NudFadeDelay.ValueChanged += nudFadeDelay_ValueChanged;
            NudFadeLength.ValueChanged += nudFadeLength_ValueChanged;
            NudFadeColorR.ValueChanged += nudFadeColorR_ValueChanged;
            NudFadeColorG.ValueChanged += nudFadeColorG_ValueChanged;
            NudFadeColorB.ValueChanged += nudFadeColorB_ValueChanged;
            TbSound.TextChanged += tbSound_TextChanged;
            TbSpeaker.TextChanged += tbSpeaker_TextChanged;
            TbVoiceOverResRef.TextChanged += tbVoiceOverResRef_TextChanged;
            NudCameraId.ValueChanged += nudCameraID_ValueChanged;
            CmbxCamVidEffect.SelectedIndexChanged += cmbxCamVidEffect_SelectedIndexChanged;
            NudPlotIndex.Validated += nudPlotIndex_ValueChanged;
            NudPlotXpPercentage.Validated += nudPlotXPPercentage_ValueChanged;
            NudCameraAngle.Validated += nudCameraAngle_ValueChanged;
            NudCamHeightOffset.Validated += nudCamHeightOffset_ValueChanged;
            NudTarHeightOffset.Validated += nudTarHeightOffset_ValueChanged;
            NudFadeDelay.Validated += nudFadeDelay_ValueChanged;
            NudFadeLength.Validated += nudFadeLength_ValueChanged;
            NudFadeColorR.Validated += nudFadeColorR_ValueChanged;
            NudFadeColorG.Validated += nudFadeColorG_ValueChanged;
            NudFadeColorB.Validated += nudFadeColorB_ValueChanged;
            NudCameraId.Validated += nudCameraID_ValueChanged;
            NudFadeColorB.ValueChanged += nudFadeColorB_ValueChanged;
            TbQuest.TextChanged += tbQuest_TextChanged;
            NudQuestEntry.Validated += nudQuestEntry_ValueChanged;
            CmbxFadeType.SelectedIndexChanged += cmbxFadeType_SelectedIndexChanged;
            NudCamFieldOfView.ValueChanged += nudCamFieldOfView_ValueChanged;
            NudCamFieldOfView.Validated += nudCamFieldOfView_ValueChanged;
        }

        private void DisconnectEventHandlers()
        {
            TbConversationText.TextChanged -= tbConversationText_TextChanged;
            TbTextActiveScript.TextChanged -= tbTextActiveScript_TextChanged;
            TbActionsTakenScript.TextChanged -= tbActionsTakenScript_TextChanged;
            NudPlotIndex.ValueChanged -= nudPlotIndex_ValueChanged;
            NudPlotXpPercentage.ValueChanged -= nudPlotXPPercentage_ValueChanged;
            TbComments.TextChanged -= tbComments_TextChanged;
            NudCameraAngle.ValueChanged -= nudCameraAngle_ValueChanged;
            NudCamHeightOffset.ValueChanged -= nudCamHeightOffset_ValueChanged;
            NudTarHeightOffset.ValueChanged -= nudTarHeightOffset_ValueChanged;
            TbListener.TextChanged -= tbListener_TextChanged;
            NudFadeDelay.ValueChanged -= nudFadeDelay_ValueChanged;
            NudFadeLength.ValueChanged -= nudFadeLength_ValueChanged;
            NudFadeColorR.ValueChanged -= nudFadeColorR_ValueChanged;
            NudFadeColorG.ValueChanged -= nudFadeColorG_ValueChanged;
            NudFadeColorB.ValueChanged -= nudFadeColorB_ValueChanged;
            TbSound.TextChanged -= tbSound_TextChanged;
            TbSpeaker.TextChanged -= tbSpeaker_TextChanged;
            TbVoiceOverResRef.TextChanged -= tbVoiceOverResRef_TextChanged;
            NudCameraId.ValueChanged -= nudCameraID_ValueChanged;
            CmbxCamVidEffect.SelectedIndexChanged -= cmbxCamVidEffect_SelectedIndexChanged;
            NudPlotIndex.Validated -= nudPlotIndex_ValueChanged;
            NudPlotXpPercentage.Validated -= nudPlotXPPercentage_ValueChanged;
            NudCameraAngle.Validated -= nudCameraAngle_ValueChanged;
            NudCamHeightOffset.Validated -= nudCamHeightOffset_ValueChanged;
            NudTarHeightOffset.Validated -= nudTarHeightOffset_ValueChanged;
            NudFadeDelay.Validated -= nudFadeDelay_ValueChanged;
            NudFadeLength.Validated -= nudFadeLength_ValueChanged;
            NudFadeColorR.Validated -= nudFadeColorR_ValueChanged;
            NudFadeColorG.Validated -= nudFadeColorG_ValueChanged;
            NudFadeColorB.Validated -= nudFadeColorB_ValueChanged;
            NudCameraId.Validated -= nudCameraID_ValueChanged;
            TbQuest.TextChanged -= tbQuest_TextChanged;
            NudQuestEntry.Validated -= nudQuestEntry_ValueChanged;
            CmbxFadeType.SelectedIndexChanged -= cmbxFadeType_SelectedIndexChanged;
            NudCamFieldOfView.ValueChanged -= nudCamFieldOfView_ValueChanged;
            NudCamFieldOfView.Validated -= nudCamFieldOfView_ValueChanged;
        }

        private void tbConversationText_TextChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            selectedNode.InternalText = TbConversationText.Text;
            selectedNode.Text = selectedNode.NodeDesc;
            selectedNode.UpdateLinkedNodesText();
        }

        private void tbTextActiveScript_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).ActiveScript = TbTextActiveScript.Text.Trim();
        }

        private void tbActionsTakenScript_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).Script = TbActionsTakenScript.Text.Trim();
        }

        private void nudPlotIndex_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).PlotIndex =
                IntegerType.FromString(NudPlotIndex.Text.Trim());
        }

        private void nudPlotXPPercentage_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).PlotXpPercentage = NudPlotXpPercentage.Value;
        }

        private void tbComments_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).Comment = TbComments.Text.Trim();
        }

        private void nudCameraAngle_ValueChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            selectedNode.CameraAngle = Convert.ToInt32(NudCameraAngle.Value);
            if (selectedNode.CameraAngle == 6)
            {
                CmbxCamVidEffect.Enabled = true;
                switch (selectedNode.CamVidEffect)
                {
                    case -1:
                        CmbxCamVidEffect.SelectedIndex = 0;
                        break;
                    case 0:
                        CmbxCamVidEffect.SelectedIndex = 1;
                        break;
                    case 2:
                        CmbxCamVidEffect.SelectedIndex = 2;
                        break;
                    default:
                        CmbxCamVidEffect.SelectedIndex = 0;
                        break;
                }
            }
            else
            {
                CmbxCamVidEffect.Enabled = false;
                CmbxCamVidEffect.SelectedIndex = 0;
            }
        }

        private void nudCamHeightOffset_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).CamHeightOffset = NudCamHeightOffset.Value;
        }

        private void nudTarHeightOffset_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).CamHeightOffset = NudTarHeightOffset.Value;
        }

        private void tbListener_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).Listener = TbListener.Text.Trim();
        }

        private void nudFadeDelay_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).FadeDelay = NudFadeDelay.Value;
        }

        private void nudFadeLength_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).FadeLength = NudFadeLength.Value;
        }

        private void nudFadeColorR_ValueChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            if (selectedNode.FadeColor == null)
                selectedNode.FadeColor = new GffType17();
            selectedNode.FadeColor.F1 = Convert.ToSingle(NudFadeColorR.Value);
            selectedNode.FadeColor.F2 = Convert.ToSingle(NudFadeColorG.Value);
            selectedNode.FadeColor.F3 = Convert.ToSingle(NudFadeColorB.Value);
        }

        private void nudFadeColorG_ValueChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            if (selectedNode.FadeColor == null) selectedNode.FadeColor = new GffType17();
            selectedNode.FadeColor.F1 = Convert.ToSingle(NudFadeColorR.Value);
            selectedNode.FadeColor.F2 = Convert.ToSingle(NudFadeColorG.Value);
            selectedNode.FadeColor.F3 = Convert.ToSingle(NudFadeColorB.Value);
        }

        private void nudFadeColorB_ValueChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            if (selectedNode.FadeColor == null) selectedNode.FadeColor = new GffType17();
            selectedNode.FadeColor.F1 = Convert.ToSingle(NudFadeColorR.Value);
            selectedNode.FadeColor.F2 = Convert.ToSingle(NudFadeColorG.Value);
            selectedNode.FadeColor.F3 = Convert.ToSingle(NudFadeColorB.Value);
        }

        private void tbSound_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).Sound = TbSound.Text.Trim();
        }

        private void tbSpeaker_TextChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            selectedNode.Speaker = TbSpeaker.Text.Trim();
            selectedNode.Text = selectedNode.NodeDesc;
        }

        private void tbVoiceOverResRef_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).VoResRef = TbVoiceOverResRef.Text.Trim();
        }

        private void nudCameraID_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).CameraId = Convert.ToInt32(NudCameraId.Value);
        }

        private void nudCamFieldOfView_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).CamFieldOfView = NudCamFieldOfView.Value;
        }

        private void cmbxCamVidEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            switch (CmbxCamVidEffect.SelectedIndex)
            {
                case 0:
                    selectedNode.CamVidEffect = -1;
                    break;
                case 1:
                    selectedNode.CamVidEffect = 0;
                    break;
                case 2:
                    selectedNode.CamVidEffect = 2;
                    break;
            }
        }

        private void tbQuest_TextChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).Quest = TbQuest.Text.Trim();
            NudQuestEntry.Enabled = StringType.StrCmp(TbQuest.Text.Trim(), "", false) != 0;
        }

        private void nudQuestEntry_ValueChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).QuestEntry = Convert.ToUInt32(NudQuestEntry.Value);
        }

        private void cmbxFadeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ((DlgConvListNode) TvConversation.SelectedNode).FadeType = CmbxFadeType.SelectedIndex;
            bool flag = CmbxFadeType.SelectedIndex > 0;
            NudFadeDelay.Enabled = flag;
            NudFadeLength.Enabled = flag;
            NudFadeColorR.Enabled = flag;
            NudFadeColorG.Enabled = flag;
            NudFadeColorB.Enabled = flag;
        }

        private void tvConversation_MouseDown(object sender, MouseEventArgs e)
        {
            _lastClickedTvConversationNode = (DlgConvListNode) TvConversation.GetNodeAt(new Point(e.X, e.Y));
        }

        private void tvConversation_MouseUp(object sender, MouseEventArgs e)
        {
            Point pos = new Point(e.X, e.Y);
            DlgConvListNode conversationNode = _lastClickedTvConversationNode;
            if (conversationNode != null) _currentContextMenuTvConversationNode = conversationNode;
            if (e.Button == MouseButtons.Right)
            {
                if (conversationNode == null) return;
                AdjustContextMenuItems();
                CmTVfunctions.Show(TvConversation, pos);
                TvConversation.SelectedNode = _currentContextMenuTvConversationNode;
            }
            else if (e.Button != MouseButtons.Left || conversationNode == null || e.X >= conversationNode.Bounds.Left) ;
        }

        private void tvConversation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) ((TreeView) sender).SelectedNode;
            AdjustTabPagesEnabledState(selectedNode);
            if (selectedNode == TvConversation.Nodes[0]) return;
            TbLinkId.Text = StringType.FromInteger(selectedNode.LinkId);
            TbLinkedCnt.Text = selectedNode.LinkedNodesList != null ? StringType.FromInteger(selectedNode.LinkedNodesList.Count) : "(empty)";
            TbSharedCnt.Text = selectedNode.LinkedToNode != null ? StringType.FromInteger(selectedNode.LinkedToNode.LinkedNodesList.Count) : "(none)";
            TbLinkDesc.Text = selectedNode.LinkDesc;
            DisconnectEventHandlers();
            TbConversationText.Text = selectedNode.InternalText;
            TbTextActiveScript.Text = selectedNode.ActiveScript;
            TbSound.Text = selectedNode.Sound;
            TbComments.Text = selectedNode.Comment;
            TbSound.Text = selectedNode.Sound;
            TbActionsTakenScript.Text = selectedNode.Script;
            TbSpeaker.Text = selectedNode.Speaker;
            NudCameraAngle.Value = new Decimal(selectedNode.CameraAngle);
            if (selectedNode.CameraAngle == 6)
            {
                CmbxCamVidEffect.Enabled = true;
                switch (selectedNode.CamVidEffect)
                {
                    case -1:
                        CmbxCamVidEffect.SelectedIndex = 0;
                        break;
                    case 0:
                        CmbxCamVidEffect.SelectedIndex = 1;
                        break;
                    case 2:
                        CmbxCamVidEffect.SelectedIndex = 2;
                        break;
                    default:
                        CmbxCamVidEffect.SelectedIndex = 0;
                        break;
                }
            }
            else
            {
                CmbxCamVidEffect.Enabled = false;
                CmbxCamVidEffect.SelectedIndex = 0;
            }

            NudCameraId.Value = new Decimal(selectedNode.CameraId);
            CmbxFadeType.SelectedIndex = selectedNode.FadeType;
            bool flag = CmbxFadeType.SelectedIndex > 0;
            NudFadeDelay.Enabled = flag;
            NudFadeLength.Enabled = flag;
            NudFadeColorR.Enabled = flag;
            NudFadeColorG.Enabled = flag;
            NudFadeColorB.Enabled = flag;
            TbListener.Text = selectedNode.Listener;
            NudPlotIndex.Value = new Decimal(selectedNode.PlotIndex);
            NudPlotXpPercentage.Value = selectedNode.PlotXpPercentage;
            TbVoiceOverResRef.Text = selectedNode.VoResRef;
            NudCamHeightOffset.Value = selectedNode.CamHeightOffset;
            NudTarHeightOffset.Value = selectedNode.TarHeightOffset;
            NudFadeDelay.Value = selectedNode.FadeDelay;
            NudFadeLength.Value = selectedNode.FadeLength;
            if (selectedNode.FadeColor != null)
            {
                NudFadeColorR.Text = StringType.FromByte(Convert.ToByte(selectedNode.FadeColor.F1));
                NudFadeColorG.Text = StringType.FromByte(Convert.ToByte(selectedNode.FadeColor.F2));
                NudFadeColorB.Text = StringType.FromByte(Convert.ToByte(selectedNode.FadeColor.F3));
            }
            else
            {
                NudFadeColorR.Text = "";
                NudFadeColorG.Text = "";
                NudFadeColorB.Text = "";
            }

            DgAnimList.SetDataBinding(selectedNode.Animlist, null);
            DgAnimList.DataSource = selectedNode.Animlist;
            if (StringType.StrCmp(selectedNode.Quest, null, false) == 0)
            {
                TbQuest.Text = "";
                NudQuestEntry.Value = Decimal.Zero;
                NudQuestEntry.Enabled = false;
            }
            else
            {
                TbQuest.Text = selectedNode.Quest;
                NudQuestEntry.Value = Convert.ToDecimal(selectedNode.QuestEntry);
                NudQuestEntry.Enabled = true;
            }

            if (ChkbAnimatedCut.Checked)
                NudCamFieldOfView.Value = selectedNode.CamFieldOfView;
            WireUpEventHandlers();
        }

        private void cmiTV_Add_Click(object sender, EventArgs e)
        {
            if (_lastClickedTvConversationNode.IsLink > 0U)
                return;
            DlgConvListNode dlgConvListNode = new DlgConvListNode();
            frmPromptForString frmPromptForString1 = new frmPromptForString();
            frmPromptForString1.tbValue.Multiline = true;
            frmPromptForString1.tbValue.AcceptsReturn = false;
            frmPromptForString1.tbValue.AcceptsTab = false;
            frmPromptForString frmPromptForString2 = frmPromptForString1;
            Size size1 = new Size(300, 272);
            Size size2 = size1;
            frmPromptForString2.Size = size2;
            TextBox tbValue = frmPromptForString1.tbValue;
            size1 = new Size(232, 96);
            Size size3 = size1;
            tbValue.Size = size3;
            if (_lastClickedTvConversationNode.IsReply)
                frmPromptForString1.lblMsg.Text = "Enter what the NPC says:";
            else
                frmPromptForString1.lblMsg.Text = "Enter what the PC says:";
            if (frmPromptForString1.ShowDialog(this) != DialogResult.OK)
                return;
            dlgConvListNode.InternalText = frmPromptForString1.tbValue.Text.Trim();
            if (_lastClickedTvConversationNode.IsReply)
            {
                dlgConvListNode.IsEntry = true;
            }
            else
            {
                dlgConvListNode.IsReply = true;
                dlgConvListNode.Speaker = "";
            }

            dlgConvListNode.Text = dlgConvListNode.NodeDesc;
            dlgConvListNode.ForeColor = dlgConvListNode.DialogColor;
            _lastClickedTvConversationNode.Nodes.Add(dlgConvListNode);
            if (_lastClickedTvConversationNode != TvConversation.Nodes[0])
                _lastClickedTvConversationNode.Text = _lastClickedTvConversationNode.NodeDesc;
            dlgConvListNode.EnsureVisible();
            TvConversation.SelectedNode = dlgConvListNode;
        }

        private void cmiTV_Copy_Click(object sender, EventArgs e)
        {
            _clipBoardNode = _currentContextMenuTvConversationNode;
        }

        private void cmiTV_Paste_Click(object sender, EventArgs e)
        {
            DlgConvListNode dlgConvListNode = _clipBoardNode.Copy();
            if (_lastClickedTvConversationNode.IsReply)
            {
                dlgConvListNode.IsEntry = true;
            }
            else
            {
                dlgConvListNode.IsReply = true;
                dlgConvListNode.Speaker = "";
            }

            dlgConvListNode.ForeColor = dlgConvListNode.DialogColor;
            dlgConvListNode.Text = dlgConvListNode.NodeDesc;
            dlgConvListNode.LinkedNodesList = null;
            if (dlgConvListNode.IsLink > 0U)
            {
                if (_clipBoardNode.LinkedToNode.LinkedNodesList == null)
                    _clipBoardNode.LinkedToNode.LinkedNodesList = new ArrayList();
                _clipBoardNode.LinkedToNode.LinkedNodesList.Add(dlgConvListNode);
            }

            _lastClickedTvConversationNode.Nodes.Add(dlgConvListNode);
            _lastClickedTvConversationNode.Text = _lastClickedTvConversationNode.NodeDesc;
            dlgConvListNode.EnsureVisible();
        }

        private void cmiTV_PasteTree_Click(object sender, EventArgs e)
        {
            DlgConvListNode clipBoardNode = _clipBoardNode;
            if (_lastClickedTvConversationNode.IsReply)
            {
                clipBoardNode.IsEntry = true;
            }
            else
            {
                clipBoardNode.IsReply = true;
                clipBoardNode.Speaker = "";
            }

            clipBoardNode.ForeColor = clipBoardNode.DialogColor;
            clipBoardNode.Text = clipBoardNode.NodeDesc;
            clipBoardNode.LinkedNodesList = null;
            if (clipBoardNode.IsLink > 0U)
            {
                if (_clipBoardNode.LinkedToNode.LinkedNodesList == null) _clipBoardNode.LinkedToNode.LinkedNodesList = new ArrayList();
                _clipBoardNode.LinkedToNode.LinkedNodesList.Add(clipBoardNode);
            }

            _lastClickedTvConversationNode.Nodes.Add(clipBoardNode);
            _lastClickedTvConversationNode.Text = _lastClickedTvConversationNode.NodeDesc;
            clipBoardNode.EnsureVisible();
            _clipBoardNode = null;
            ResetChildNodesDescAfterPasteTree(_lastClickedTvConversationNode);
        }

        private void cmiTV_PasteAsLink_Click(object sender, EventArgs e)
        {
            DlgConvListNode dlgConvListNode = _clipBoardNode.Copy();
            dlgConvListNode.IsLink = byte.MaxValue;
            dlgConvListNode.LinkedNodesList = null;
            dlgConvListNode.LinkedToNode = _clipBoardNode;
            if (_clipBoardNode.LinkedNodesList == null) _clipBoardNode.LinkedNodesList = new ArrayList();
            _clipBoardNode.LinkedNodesList.Add(dlgConvListNode);
            dlgConvListNode.ForeColor = dlgConvListNode.DialogColor;
            dlgConvListNode.Text = dlgConvListNode.NodeDesc;
            _lastClickedTvConversationNode.Nodes.Add(dlgConvListNode);
            _lastClickedTvConversationNode.Text = _lastClickedTvConversationNode.NodeDesc;
            _lastClickedTvConversationNode.ForeColor = _lastClickedTvConversationNode.DialogColor;
            dlgConvListNode.EnsureVisible();
        }

        private void cmiTV_Cut_Click(object sender, EventArgs e)
        {
            _clipBoardNode = _currentContextMenuTvConversationNode;
            RemoveChildLinks(_clipBoardNode);
            DlgConvListNode parent = (DlgConvListNode) _clipBoardNode.Parent;
            _clipBoardNode.Parent.Nodes.Remove(_clipBoardNode);
            parent.Text = parent.NodeDesc;
        }

        private void AdjustContextMenuItems()
        {
            CmiTvAdd.Enabled = (uint) ~_lastClickedTvConversationNode.IsLink > 0U;
            CmiTvCopy.Enabled = _lastClickedTvConversationNode != TvConversation.Nodes[0];
            CmiTvCut.Enabled = _lastClickedTvConversationNode != TvConversation.Nodes[0];
            CmiTvPaste.Enabled = _clipBoardNode != null && (uint) ~_lastClickedTvConversationNode.IsLink > 0U;
            CmiTvPasteTree.Enabled = _clipBoardNode != null && (uint) ~_lastClickedTvConversationNode.IsLink > 0U;
            CmiTvPasteAsLink.Enabled = _clipBoardNode != null && (uint) ~_clipBoardNode.IsLink > 0U && ((uint) ~_lastClickedTvConversationNode.IsLink > 0U && _lastClickedTvConversationNode.IsReply);
            if (_lastClickedTvConversationNode == TvConversation.Nodes[0])
            {
                CmiTvMoveNodeUp.Enabled = false;
                CmiTvMoveNodeDown.Enabled = false;
            }
            else
            {
                DlgConvListNode parent = (DlgConvListNode) _lastClickedTvConversationNode.Parent;
                CmiTvMoveNodeUp.Enabled = parent.Nodes.IndexOf(_lastClickedTvConversationNode) > 0;
                CmiTvMoveNodeDown.Enabled = parent.Nodes.IndexOf(_lastClickedTvConversationNode) < checked(parent.Nodes.Count - 1);
            }
        }

        private void AdjustTabPagesEnabledState(DlgConvListNode node)
        {
            if (((uint) (short) -(node == TvConversation.Nodes[0] ? 1 : 0) | node.IsLink) > 0U)
            {
                TabpagActionsTaken.Enabled = false;
                TabpagAnimationSound.Enabled = false;
                TabpagCamera.Enabled = false;
                TabpagComment.Enabled = false;
                TabpagPlot.Enabled = false;
            }
            else
            {
                TabpagActionsTaken.Enabled = true;
                TabpagAnimationSound.Enabled = true;
                TabpagCamera.Enabled = true;
                TabpagComment.Enabled = true;
                TabpagPlot.Enabled = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void OpenFile()
        {
            string str = StringType.FromObject(FileUtils.GetFilePath("load",
                ConfigOptions.Paths.DefaultImportLocation, "", "Open DLG files...", "dlg"));
            if (StringType.StrCmp(str, "", false) == 0)
                return;
            //int kotorVersionIndex = GetGffFileKotorVersionIndex(str);
            FileStream fileStream = new FileStream(str, FileMode.Open, FileAccess.Read);
            SetupForNewDialog();
            TvConversation.Nodes.Clear();
            FileStream fs = fileStream;
            TreeView tvConversation = TvConversation;
            // ISSUE: explicit reference operation
            // ISSUE: variable of a reference type
            TreeView extTv = @tvConversation;
            int kotorVerIndex = MainAppState.GetUniqueKotorInstalledVersion();
            ClsDlg clsDlg = new ClsDlg(fs, ref extTv, kotorVerIndex);
            TvConversation = tvConversation;
            _clsdlg = clsDlg;
            _filename = Path.GetFileNameWithoutExtension(fileStream.Name);
            _gff = _clsdlg.DlgGff;
            SetFormToDlgRootItems();
            Text = "Conversation Editor - " + _filename + ".dlg";
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SetupForNewDialog();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddAnimListEntry_Click(object sender, EventArgs e)
        {
            if (_lastClickedTvConversationNode.Animlist == null) _lastClickedTvConversationNode.Animlist = new ArrayList(1);
            frmCreateAnimListEntry createAnimListEntry = new frmCreateAnimListEntry();
            if (createAnimListEntry.ShowDialog(this) != DialogResult.OK) return;
            // this.LastClickedTvConversationNode.Animlist.Add((object) new frmCreateAnimListEntry(createAnimListEntry.Participant, createAnimListEntry.AnimationNumber));
            _lastClickedTvConversationNode.Animlist.Add(new frmCreateAnimListEntry());
            DgAnimList.SetDataBinding(_lastClickedTvConversationNode.Animlist, null);
            CurrencyManager currencyManager = (CurrencyManager) DgAnimList.BindingContext[RuntimeHelpers.GetObjectValue(DgAnimList.DataSource)];
            currencyManager?.Refresh();
            DgAnimList.Refresh();
        }

        private void btnDeleteAnimListEntry_Click(object sender, EventArgs e)
        {
            CurrencyManager currencyManager = (CurrencyManager) DgAnimList.BindingContext[RuntimeHelpers.GetObjectValue(DgAnimList.DataSource)];
            _lastClickedTvConversationNode.Animlist.RemoveAt(currencyManager.Position);
            currencyManager?.Refresh();
            BtnDeleteAnimListEntry.Enabled = false;
        }

        private void dgAnimList_Click(object sender, EventArgs e)
        {
            DataGrid dataGrid = (DataGrid) sender;
            DataGrid.HitTestInfo hitTestInfo = dataGrid.HitTest(dataGrid.PointToClient(MousePosition).X, dataGrid.PointToClient(MousePosition).Y);
            if (!(hitTestInfo.Type == DataGrid.HitTestType.RowHeader | hitTestInfo.Type == DataGrid.HitTestType.Cell)) return;
            DgAnimList.Select(hitTestInfo.Row);
            BtnDeleteAnimListEntry.Enabled = true;
        }

        private void dgAnimList_Validated(object sender, EventArgs e)
        {
            BtnDeleteAnimListEntry.Enabled = false;
        }

        private void trkbTVIndent_Scroll(object sender, EventArgs e)
        {
            TvConversation.Indent = TrkbTvIndent.Value;
        }

        private void trkbTVItemHeight_Scroll(object sender, EventArgs e)
        {
            TvConversation.ItemHeight = checked(TrkbTvItemHeight.Value * 2);
        }

        private void cmbxConversationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbxComputerType.Enabled = CmbxConversationType.SelectedIndex == 1;
        }

        private void btnShowLists_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Entries");
            Console.WriteLine("-----------------------------------------");
            int num1 = 0;
            int num2 = _gff.GetListItemCount("EntryList") - 1;
            int num3 = num1;
            while (num3 <= num2)
            {
                Console.Write("Entry " + StringType.FromInteger(num3) + ": ");
                if (_gff.GetListItemCount("EntryList(" + StringType.FromInteger(num3) + ").RepliesList") > 0)
                {
                    int num4 = 0;
                    int num5 = _gff.GetListItemCount("EntryList(" + StringType.FromInteger(num3) + ").RepliesList") - 1;
                    int num6 = num4;
                    while (num6 <= num5)
                    {
                        Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(_gff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").RepliesList(" + StringType.FromInteger(num6) + ").Index"))));
                        if (ObjectType.ObjTst(_gff.GetNodeValue("EntryList(" + StringType.FromInteger(num3) + ").RepliesList(" + StringType.FromInteger(num6) + ").IsChild"), 0, false) > 0) Console.Write(" (L), ");
                        else Console.Write(", ");
                        ++num6;
                    }
                }

                Console.WriteLine();
                ++num3;
                
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Replies");
            Console.WriteLine("-----------------------------------------");
            int num7 = 0;
            int num8 = checked(_gff.GetListItemCount("ReplyList") - 1);
            int num9 = num7;
            while (num9 <= num8)
            {
                Console.Write("Entry " + StringType.FromInteger(num9) + ": ");
                if (_gff.GetListItemCount("ReplyList(" + StringType.FromInteger(num9) + ").EntriesList") > 0)
                {
                    int num4 = 0;
                    int num5 = _gff.GetListItemCount("ReplyList(" + StringType.FromInteger(num9) + ").EntriesList") - 1;
                    int num6 = num4;
                    while (num6 <= num5)
                    {
                        Console.Write(Convert.ToInt32(RuntimeHelpers.GetObjectValue(_gff.GetNodeValue("ReplyList(" + StringType.FromInteger(num9) + ").EntriesList(" + StringType.FromInteger(num6) + ").Index"))));
                        if (ObjectType.ObjTst(_gff.GetNodeValue("ReplyList(" + StringType.FromInteger(num9) + ").EntriesList(" + StringType.FromInteger(num6) + ").IsChild"), 0, false) > 0) Console.Write(" (L), ");
                        else Console.Write(", ");
                        ++num6;
                    }
                }

                Console.WriteLine();
                ++num9;
            }

            Console.WriteLine("-----------------------------------------");
        }

        private void chkbAnimatedCut_CheckedChanged(object sender, EventArgs e)
        {
            TbCameraModel.Enabled = ((CheckBox) sender).Checked;
            NudCamFieldOfView.Enabled = ((CheckBox) sender).Checked;
        }

        private void cmiTV_MoveNodeUp_Click(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            DlgConvListNode parent = (DlgConvListNode) selectedNode.Parent;
            int num = parent.Nodes.IndexOf(selectedNode);
            parent.Nodes.Remove(selectedNode);
            parent.Nodes.Insert(checked(num - 1), selectedNode);
            TvConversation.SelectedNode = selectedNode;
        }

        private void cmiTV_MoveNodeDown_Click(object sender, EventArgs e)
        {
            DlgConvListNode selectedNode = (DlgConvListNode) TvConversation.SelectedNode;
            DlgConvListNode parent = (DlgConvListNode) selectedNode.Parent;
            int num = parent.Nodes.IndexOf(selectedNode);
            parent.Nodes.Remove(selectedNode);
            if (num == checked(parent.Nodes.Count - 1)) parent.Nodes.Add(selectedNode);
            else parent.Nodes.Insert(checked(num + 1), selectedNode);
            TvConversation.SelectedNode = selectedNode;
        }
    }
}