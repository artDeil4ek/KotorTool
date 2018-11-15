// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmInventoryEditor
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

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

using KotorTool_2._0.Models;
using KotorTool_2._0.Models.BIFF;
using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Forms
{
    public class FrmInventoryEditor : Form
    {
        [AccessedThroughProperty("ToolTip1")] private ToolTip _toolTip1;
        [AccessedThroughProperty("pnlTrash")] private Panel _pnlTrash;

        [AccessedThroughProperty("pnlRWeaponBkgnd")]
        private Panel _pnlRWeaponBkgnd;

        [AccessedThroughProperty("pnlBeltBkgnd")]
        private Panel _pnlBeltBkgnd;

        [AccessedThroughProperty("pnlLWeaponBkgnd")]
        private Panel _pnlLWeaponBkgnd;

        [AccessedThroughProperty("TabPage2")] private TabPage _tabPage2;

        [AccessedThroughProperty("pnlRArmBkgnd")]
        private Panel _pnlRArmBkgnd;

        [AccessedThroughProperty("pnlArmorBkgnd")]
        private Panel _pnlArmorBkgnd;

        [AccessedThroughProperty("TabPage1")] private TabPage _tabPage1;
        [AccessedThroughProperty("pnlRoot")] private Panel _pnlRoot;

        [AccessedThroughProperty("TabControl1")]
        private TabControl _tabControl1;

        [AccessedThroughProperty("pnlRightSide")]
        private Panel _pnlRightSide;

        [AccessedThroughProperty("Splitter1")] private Splitter _splitter1;

        [AccessedThroughProperty("pnlLArmBkgnd")]
        private Panel _pnlLArmBkgnd;

        [AccessedThroughProperty("pnlCreatureItem3Bkgnd")]
        private Panel _pnlCreatureItem3Bkgnd;

        [AccessedThroughProperty("pnlHandsBkgnd")]
        private Panel _pnlHandsBkgnd;

        [AccessedThroughProperty("pnlHeadBkgnd")]
        private Panel _pnlHeadBkgnd;

        [AccessedThroughProperty("TabPage3")] private TabPage _tabPage3;

        [AccessedThroughProperty("pnlImplantBkgnd")]
        private Panel _pnlImplantBkgnd;

        [AccessedThroughProperty("Panel8")] private Panel _panel8;

        [AccessedThroughProperty("dgPackItems")]
        private DataGrid _dgPackItems;

        [AccessedThroughProperty("pnlBelt")] private InventoryPanel _pnlBelt;
        [AccessedThroughProperty("TabPage4")] private TabPage _tabPage4;

        [AccessedThroughProperty("pnlCreatureItem2Bkgnd")]
        private Panel _pnlCreatureItem2Bkgnd;

        [AccessedThroughProperty("pnlLWeapon")]
        private InventoryPanel _pnlLWeapon;

        [AccessedThroughProperty("pnlRWeapon")]
        private InventoryPanel _pnlRWeapon;

        [AccessedThroughProperty("pnlArmor")] private InventoryPanel _pnlArmor;
        [AccessedThroughProperty("pnlLArm")] private InventoryPanel _pnlLArm;

        [AccessedThroughProperty("cmEquippedItems")]
        private ContextMenu _cmEquippedItems;

        [AccessedThroughProperty("pnlRArm")] private InventoryPanel _pnlRArm;
        [AccessedThroughProperty("pnlHands")] private InventoryPanel _pnlHands;
        [AccessedThroughProperty("pnlHead")] private InventoryPanel _pnlHead;

        [AccessedThroughProperty("pnlImplant")]
        private InventoryPanel _pnlImplant;

        [AccessedThroughProperty("TreeView")] private TreeView _treeView;

        [AccessedThroughProperty("cmiDropable")]
        private MenuItem _cmiDropable;

        [AccessedThroughProperty("pnlCreatureItem1")]
        private InventoryPanel _pnlCreatureItem1;

        [AccessedThroughProperty("pnlCreatureItem1Bkgnd")]
        private Panel _pnlCreatureItem1Bkgnd;

        [AccessedThroughProperty("pnlCreatureItem3")]
        private InventoryPanel _pnlCreatureItem3;

        [AccessedThroughProperty("btnCollapseAll")]
        private Button _btnCollapseAll;

        [AccessedThroughProperty("TabControl2")]
        private TabControl _tabControl2;

        [AccessedThroughProperty("pnlCreatureItem2")]
        private InventoryPanel _pnlCreatureItem2;

        [AccessedThroughProperty("btnExpandAll")]
        private Button _btnExpandAll;

        [AccessedThroughProperty("pnlCreatureHide")]
        private InventoryPanel _pnlCreatureHide;

        [AccessedThroughProperty("btnOK")] private Button _btnOk;

        [AccessedThroughProperty("pnlCreatureHideBkgnd")]
        private Panel _pnlCreatureHideBkgnd;

        [AccessedThroughProperty("btnCancel")] private Button _btnCancel;
        private IContainer components;
        public Options.ConfigOptions CurrentSettings;
        public ClsDialogTlk GClsDialogTlk;
        public ArrayList ResRef2NameLookupList;
        private DataTable _dt;
        private DataView _dView;
        private long _mouseDownTime;
        private object _mouseDoubleClickTime;
        private int _kotorVersionIndex;

        internal virtual TreeView TreeView
        {
            get => _treeView;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_treeView != null)
                {
                    _treeView.MouseDown -= TreeView1_MouseDown;
                    _treeView.ItemDrag -= TreeView_ItemDrag;
                }

                _treeView = value;
                if (_treeView == null)
                    return;
                _treeView.MouseDown += TreeView1_MouseDown;
                _treeView.ItemDrag += TreeView_ItemDrag;
            }
        }

        internal virtual InventoryPanel PnlImplant
        {
            get => _pnlImplant;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlImplant != null)
                {
                    _pnlImplant.MouseDown -= pnl_MouseDown;
                    _pnlImplant.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlImplant.DragDrop -= pnl_DragDrop;
                    _pnlImplant.DragEnter -= pnlImplant_DragEnter;
                }

                _pnlImplant = value;
                if (_pnlImplant == null)
                    return;
                _pnlImplant.MouseDown += pnl_MouseDown;
                _pnlImplant.DoubleClick += pnlEquipped_DoubleClick;
                _pnlImplant.DragDrop += pnl_DragDrop;
                _pnlImplant.DragEnter += pnlImplant_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlHead
        {
            get => _pnlHead;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlHead != null)
                {
                    _pnlHead.MouseDown -= pnl_MouseDown;
                    _pnlHead.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlHead.DragDrop -= pnl_DragDrop;
                    _pnlHead.DragEnter -= pnlHead_DragEnter;
                }

                _pnlHead = value;
                if (_pnlHead == null)
                    return;
                _pnlHead.MouseDown += pnl_MouseDown;
                _pnlHead.DoubleClick += pnlEquipped_DoubleClick;
                _pnlHead.DragDrop += pnl_DragDrop;
                _pnlHead.DragEnter += pnlHead_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlHands
        {
            get => _pnlHands;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlHands != null)
                {
                    _pnlHands.MouseDown -= pnl_MouseDown;
                    _pnlHands.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlHands.DragDrop -= pnl_DragDrop;
                    _pnlHands.DragEnter -= pnlHands_DragEnter;
                }

                _pnlHands = value;
                if (_pnlHands == null)
                    return;
                _pnlHands.MouseDown += pnl_MouseDown;
                _pnlHands.DoubleClick += pnlEquipped_DoubleClick;
                _pnlHands.DragDrop += pnl_DragDrop;
                _pnlHands.DragEnter += pnlHands_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlRArm
        {
            get => _pnlRArm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRArm != null)
                {
                    _pnlRArm.MouseDown -= pnl_MouseDown;
                    _pnlRArm.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlRArm.DragDrop -= pnl_DragDrop;
                    _pnlRArm.DragEnter -= pnlRArm_DragEnter;
                }

                _pnlRArm = value;
                if (_pnlRArm == null)
                    return;
                _pnlRArm.MouseDown += pnl_MouseDown;
                _pnlRArm.DoubleClick += pnlEquipped_DoubleClick;
                _pnlRArm.DragDrop += pnl_DragDrop;
                _pnlRArm.DragEnter += pnlRArm_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlLArm
        {
            get => _pnlLArm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlLArm != null)
                {
                    _pnlLArm.MouseDown -= pnl_MouseDown;
                    _pnlLArm.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlLArm.DragDrop -= pnl_DragDrop;
                    _pnlLArm.DragEnter -= pnlLArm_DragEnter;
                }

                _pnlLArm = value;
                if (_pnlLArm == null)
                    return;
                _pnlLArm.MouseDown += pnl_MouseDown;
                _pnlLArm.DoubleClick += pnlEquipped_DoubleClick;
                _pnlLArm.DragDrop += pnl_DragDrop;
                _pnlLArm.DragEnter += pnlLArm_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlArmor
        {
            get => _pnlArmor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlArmor != null)
                {
                    _pnlArmor.MouseDown -= pnl_MouseDown;
                    _pnlArmor.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlArmor.DragDrop -= pnl_DragDrop;
                    _pnlArmor.DragEnter -= pnlArmor_DragEnter;
                }

                _pnlArmor = value;
                if (_pnlArmor == null)
                    return;
                _pnlArmor.MouseDown += pnl_MouseDown;
                _pnlArmor.DoubleClick += pnlEquipped_DoubleClick;
                _pnlArmor.DragDrop += pnl_DragDrop;
                _pnlArmor.DragEnter += pnlArmor_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlRWeapon
        {
            get => _pnlRWeapon;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRWeapon != null)
                {
                    _pnlRWeapon.MouseDown -= pnl_MouseDown;
                    _pnlRWeapon.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlRWeapon.DragDrop -= pnl_DragDrop;
                    _pnlRWeapon.DragEnter -= pnlRWeapon_DragEnter;
                }

                _pnlRWeapon = value;
                if (_pnlRWeapon == null)
                    return;
                _pnlRWeapon.MouseDown += pnl_MouseDown;
                _pnlRWeapon.DoubleClick += pnlEquipped_DoubleClick;
                _pnlRWeapon.DragDrop += pnl_DragDrop;
                _pnlRWeapon.DragEnter += pnlRWeapon_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlLWeapon
        {
            get => _pnlLWeapon;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlLWeapon != null)
                {
                    _pnlLWeapon.MouseDown -= pnl_MouseDown;
                    _pnlLWeapon.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlLWeapon.DragDrop -= pnl_DragDrop;
                    _pnlLWeapon.DragEnter -= pnlLWeapon_DragEnter;
                }

                _pnlLWeapon = value;
                if (_pnlLWeapon == null)
                    return;
                _pnlLWeapon.MouseDown += pnl_MouseDown;
                _pnlLWeapon.DoubleClick += pnlEquipped_DoubleClick;
                _pnlLWeapon.DragDrop += pnl_DragDrop;
                _pnlLWeapon.DragEnter += pnlLWeapon_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlBelt
        {
            get => _pnlBelt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBelt != null)
                {
                    _pnlBelt.MouseDown -= pnl_MouseDown;
                    _pnlBelt.DoubleClick -= pnlEquipped_DoubleClick;
                    _pnlBelt.DragDrop -= pnl_DragDrop;
                    _pnlBelt.DragEnter -= pnlBelt_DragEnter;
                }

                _pnlBelt = value;
                if (_pnlBelt == null)
                    return;
                _pnlBelt.MouseDown += pnl_MouseDown;
                _pnlBelt.DoubleClick += pnlEquipped_DoubleClick;
                _pnlBelt.DragDrop += pnl_DragDrop;
                _pnlBelt.DragEnter += pnlBelt_DragEnter;
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

        internal virtual DataGrid DgPackItems
        {
            get => _dgPackItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dgPackItems != null)
                {
                    _dgPackItems.CurrentCellChanged -= dgPackItems_CurrentCellChanged;
                    _dgPackItems.DragDrop -= dgPackItems_DragDrop;
                    _dgPackItems.DragEnter -= dgPackItems_DragEnter;
                }

                _dgPackItems = value;
                if (_dgPackItems == null)
                    return;
                _dgPackItems.CurrentCellChanged += dgPackItems_CurrentCellChanged;
                _dgPackItems.DragDrop += dgPackItems_DragDrop;
                _dgPackItems.DragEnter += dgPackItems_DragEnter;
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

        internal virtual TabPage TabPage1
        {
            get => _tabPage1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabPage2 == null)
                    ;
                _tabPage2 = value;
                if (_tabPage2 != null)
                    ;
            }
        }

        internal virtual Panel Panel8
        {
            get => _panel8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel8 == null)
                    ;
                _panel8 = value;
                if (_panel8 != null)
                    ;
            }
        }

        internal virtual Panel PnlImplantBkgnd
        {
            get => _pnlImplantBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlImplantBkgnd == null)
                    ;
                _pnlImplantBkgnd = value;
                if (_pnlImplantBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlHeadBkgnd
        {
            get => _pnlHeadBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlHeadBkgnd == null)
                    ;
                _pnlHeadBkgnd = value;
                if (_pnlHeadBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlHandsBkgnd
        {
            get => _pnlHandsBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlHandsBkgnd == null)
                    ;
                _pnlHandsBkgnd = value;
                if (_pnlHandsBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlLArmBkgnd
        {
            get => _pnlLArmBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlLArmBkgnd == null)
                    ;
                _pnlLArmBkgnd = value;
                if (_pnlLArmBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlArmorBkgnd
        {
            get => _pnlArmorBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlArmorBkgnd == null)
                    ;
                _pnlArmorBkgnd = value;
                if (_pnlArmorBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlRArmBkgnd
        {
            get => _pnlRArmBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRArmBkgnd == null)
                    ;
                _pnlRArmBkgnd = value;
                if (_pnlRArmBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlLWeaponBkgnd
        {
            get => _pnlLWeaponBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlLWeaponBkgnd == null)
                    ;
                _pnlLWeaponBkgnd = value;
                if (_pnlLWeaponBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlBeltBkgnd
        {
            get => _pnlBeltBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlBeltBkgnd == null)
                    ;
                _pnlBeltBkgnd = value;
                if (_pnlBeltBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlRWeaponBkgnd
        {
            get => _pnlRWeaponBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRWeaponBkgnd == null)
                    ;
                _pnlRWeaponBkgnd = value;
                if (_pnlRWeaponBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlTrash
        {
            get => _pnlTrash;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlTrash != null)
                {
                    _pnlTrash.DragDrop -= pnlTrash_DragDrop;
                    _pnlTrash.DragEnter -= pnlTrash_DragEnter;
                }

                _pnlTrash = value;
                if (_pnlTrash == null)
                    return;
                _pnlTrash.DragDrop += pnlTrash_DragDrop;
                _pnlTrash.DragEnter += pnlTrash_DragEnter;
            }
        }

        internal virtual TabControl TabControl2
        {
            get => _tabControl2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabControl2 == null)
                    ;
                _tabControl2 = value;
                if (_tabControl2 != null)
                    ;
            }
        }

        internal virtual TabPage TabPage3
        {
            get => _tabPage3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabPage3 == null)
                    ;
                _tabPage3 = value;
                if (_tabPage3 != null)
                    ;
            }
        }

        internal virtual TabPage TabPage4
        {
            get => _tabPage4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tabPage4 == null)
                    ;
                _tabPage4 = value;
                if (_tabPage4 != null)
                    ;
            }
        }

        internal virtual ContextMenu CmEquippedItems
        {
            get => _cmEquippedItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmEquippedItems == null)
                    ;
                _cmEquippedItems = value;
                if (_cmEquippedItems != null)
                    ;
            }
        }

        internal virtual MenuItem CmiDropable
        {
            get => _cmiDropable;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmiDropable != null)
                    _cmiDropable.Click -= cmiDropable_Click;
                _cmiDropable = value;
                if (_cmiDropable == null)
                    return;
                _cmiDropable.Click += cmiDropable_Click;
            }
        }

        internal virtual InventoryPanel PnlCreatureItem1
        {
            get => _pnlCreatureItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureItem1 != null)
                {
                    _pnlCreatureItem1.MouseDown -= pnl_MouseDown;
                    _pnlCreatureItem1.DragDrop -= pnl_DragDrop;
                    _pnlCreatureItem1.DragEnter -= pnlCreatureItem_DragEnter;
                }

                _pnlCreatureItem1 = value;
                if (_pnlCreatureItem1 == null)
                    return;
                _pnlCreatureItem1.MouseDown += pnl_MouseDown;
                _pnlCreatureItem1.DragDrop += pnl_DragDrop;
                _pnlCreatureItem1.DragEnter += pnlCreatureItem_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlCreatureItem3
        {
            get => _pnlCreatureItem3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureItem3 != null)
                {
                    _pnlCreatureItem3.MouseDown -= pnl_MouseDown;
                    _pnlCreatureItem3.DragDrop -= pnl_DragDrop;
                    _pnlCreatureItem3.DragEnter -= pnlCreatureItem_DragEnter;
                }

                _pnlCreatureItem3 = value;
                if (_pnlCreatureItem3 == null)
                    return;
                _pnlCreatureItem3.MouseDown += pnl_MouseDown;
                _pnlCreatureItem3.DragDrop += pnl_DragDrop;
                _pnlCreatureItem3.DragEnter += pnlCreatureItem_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlCreatureItem2
        {
            get => _pnlCreatureItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureItem2 != null)
                {
                    _pnlCreatureItem2.MouseDown -= pnl_MouseDown;
                    _pnlCreatureItem2.DragDrop -= pnl_DragDrop;
                    _pnlCreatureItem2.DragEnter -= pnlCreatureItem_DragEnter;
                }

                _pnlCreatureItem2 = value;
                if (_pnlCreatureItem2 == null)
                    return;
                _pnlCreatureItem2.MouseDown += pnl_MouseDown;
                _pnlCreatureItem2.DragDrop += pnl_DragDrop;
                _pnlCreatureItem2.DragEnter += pnlCreatureItem_DragEnter;
            }
        }

        internal virtual InventoryPanel PnlCreatureHide
        {
            get => _pnlCreatureHide;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureHide != null)
                {
                    _pnlCreatureHide.MouseDown -= pnl_MouseDown;
                    _pnlCreatureHide.DragDrop -= pnl_DragDrop;
                    _pnlCreatureHide.DragEnter -= pnlCreatureHide_DragEnter;
                }

                _pnlCreatureHide = value;
                if (_pnlCreatureHide == null)
                    return;
                _pnlCreatureHide.MouseDown += pnl_MouseDown;
                _pnlCreatureHide.DragDrop += pnl_DragDrop;
                _pnlCreatureHide.DragEnter += pnlCreatureHide_DragEnter;
            }
        }

        internal virtual Panel PnlCreatureHideBkgnd
        {
            get => _pnlCreatureHideBkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureHideBkgnd == null)
                    ;
                _pnlCreatureHideBkgnd = value;
                if (_pnlCreatureHideBkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlCreatureItem1Bkgnd
        {
            get => _pnlCreatureItem1Bkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureItem1Bkgnd == null)
                    ;
                _pnlCreatureItem1Bkgnd = value;
                if (_pnlCreatureItem1Bkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlCreatureItem2Bkgnd
        {
            get => _pnlCreatureItem2Bkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureItem2Bkgnd == null)
                    ;
                _pnlCreatureItem2Bkgnd = value;
                if (_pnlCreatureItem2Bkgnd != null)
                    ;
            }
        }

        internal virtual Panel PnlCreatureItem3Bkgnd
        {
            get => _pnlCreatureItem3Bkgnd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlCreatureItem3Bkgnd == null)
                    ;
                _pnlCreatureItem3Bkgnd = value;
                if (_pnlCreatureItem3Bkgnd != null)
                    ;
            }
        }

        internal virtual Splitter Splitter1
        {
            get => _splitter1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_splitter1 == null)
                    ;
                _splitter1 = value;
                if (_splitter1 != null)
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

        internal virtual Panel PnlRightSide
        {
            get => _pnlRightSide;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRightSide == null)
                    ;
                _pnlRightSide = value;
                if (_pnlRightSide != null)
                    ;
            }
        }

        internal virtual Panel PnlRoot
        {
            get => _pnlRoot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_pnlRoot == null)
                    ;
                _pnlRoot = value;
                if (_pnlRoot != null)
                    ;
            }
        }

        public FrmInventoryEditor()
        {
            Load += frmInventoryEditor_Load;
            Closing += frmInventoryEditor_Closing;
            ResRef2NameLookupList = new ArrayList();
            _dt = new DataTable();
            _mouseDoubleClickTime = LongType.FromObject(ObjectType.MulObj(Registry.CurrentUser.OpenSubKey("Control Panel\\mouse").GetValue("DoubleClickSpeed"), 10000));
            InitializeComponent();
        }

        public FrmInventoryEditor(int kotorVerIndex)
            : this()
        {
            _kotorVersionIndex = kotorVerIndex;
            if (kotorVerIndex == 0) Text = Text + "I";
            else Text = Text + "II";
            CurrentSettings = UserSettings.GetSettings();
            GClsDialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
            SetEquippedPanelsToolTips();
            HidePanelIndicators();
            BuildTreeParents();
            BuildDataGrid();
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
            this.SuspendLayout();
            // 
            // FrmInventoryEditor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(971, 591);
            this.MinimumSize = new System.Drawing.Size(8, 19);
            this.Name = "FrmInventoryEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventory Editor - KotOR ";
            this.ResumeLayout(false);

        }

        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TreeNode treeNode = (TreeNode) e.Item;
            string str = treeNode.Text;
            if (ObjectType.ObjTst(treeNode.Tag, "", false) != 0)
                str = StringType.FromObject(ObjectType.StrCatObj(str, ObjectType.StrCatObj("|", treeNode.Tag)));
            int num = (int) DoDragDrop(str, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void pnlImplant_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00200");
        }

        private void pnlHead_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00001");
        }

        private void pnlHands_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00008");
        }

        private void pnlLArm_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00100,0x00180");
        }

        private void pnlArmor_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00002");
        }

        private void pnlRArm_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00080,0x00180");
        }

        private void pnlLWeapon_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00020,0x00030,0x1C030");
        }

        private void pnlBelt_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00400,0x20000");
        }

        private void pnlRWeapon_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x00010,0x00030,0x1C030");
        }

        private void pnlCreatureHide_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x20000");
        }

        private void pnlCreatureItem_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = ShowDragEnterPermission(e, "0x1C030");
        }

        private void dgPackItems_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text))
                return;
            e.Effect = DragDropEffects.Copy;
        }

        private DragDropEffects ShowDragEnterPermission(DragEventArgs dragEventArgs, string allowedSlotsString)
        {
            if (!dragEventArgs.Data.GetDataPresent(DataFormats.Text))
                return DragDropEffects.None;
            string[] strArray = Strings.Split(StringType.FromObject(dragEventArgs.Data.GetData(typeof(string))), "|");
            int num = Strings.InStr(allowedSlotsString, Strings.Mid(strArray[2], 4));
            return strArray.Length > 2 && num > 0 ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void pnlTrash_DragEnter(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetFormats().Length == 1 & e.Data.GetFormats()[0].EndsWith("InventoryPanel")))
                return;
            e.Effect = DragDropEffects.Move;
        }

        private void pnl_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text)) return;
            ManageEqInventory(StringType.FromObject(e.Data.GetData(typeof(string))), (InventoryPanel) sender, true);
        }

        private void dgPackItems_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.Text)) return;
            string[] strArray = Strings.Split(StringType.FromObject(e.Data.GetData(typeof(string))), "|");
            InsertToGridOrIncrement(strArray[0], strArray[1]);
        }

        private void pnlTrash_DragDrop(object sender, DragEventArgs e)
        {
            if (!(e.Data.GetFormats().Length == 1 & e.Data.GetFormats()[0].ToString().EndsWith("InventoryPanel")))
                return;
            InventoryPanel data = (InventoryPanel) e.Data.GetData("KotorTool_2.InventoryPanel");
            ToolTip1.SetToolTip(data, "(empty)");
            data.Tag = null;
            data.IsEmpty = true;

            foreach (Control control in TabPage1.Controls)
            {
                if (StringType.StrCmp(control.Name, data.Name + "Bkgnd", false) == 0)
                {
                    control.Visible = false;
                    return;
                }
            }


            foreach (Control control in TabPage2.Controls)
            {
                if (StringType.StrCmp(control.Name, data.Name + "Bkgnd", false) == 0)
                {
                    control.Visible = false;
                    break;
                }
            }
        }

        public void ConfigureForPlaceableEditorUse()
        {
            TabControl1.Visible = false;
            TabControl1.Enabled = false;
            PnlTrash.Visible = false;
            PnlTrash.Enabled = false;
            DgPackItems.Dock = DockStyle.Fill;
            DgPackItems.CaptionText = "Object Inventory";
        }

        private void frmInventoryEditor_Load(object sender, EventArgs e)
        {
            PositionWindow();
        }

        private void frmInventoryEditor_Closing(object sender, CancelEventArgs e)
        {
            SaveSettings();
        }

        public void BuildDataTable()
        {
            _dt.Columns.Add(new DataColumn("Name", typeof(string))
            {
                DefaultValue = ""
            });
            _dt.Columns.Add(new DataColumn("ResRef", typeof(string))
            {
                DefaultValue = ""
            });
            _dt.Columns.Add(new DataColumn("Qty", typeof(int))
            {
                DefaultValue = 1
            });
            _dt.Columns.Add(new DataColumn("Dropable", typeof(bool))
            {
                DefaultValue = true
            });
        }

        public void BuildDataGrid()
        {
            BuildDataTable();
            _dView = _dt.DefaultView;
            _dView.AllowDelete = true;
            _dView.AllowNew = false;
            _dView.AllowEdit = true;
            DataGridTableStyle table = new DataGridTableStyle();
            DgPackItems.TableStyles.Clear();
            table.MappingName = _dt.TableName;
            table.AlternatingBackColor = Color.FromArgb(byte.MaxValue, 240, 240, 240);
            DataGridTextBoxColumn gridTextBoxColumn1 = new DataGridTextBoxColumn();
            gridTextBoxColumn1.MappingName = "Name";
            gridTextBoxColumn1.HeaderText = "Name";
            gridTextBoxColumn1.NullText = "";
            gridTextBoxColumn1.ReadOnly = true;
            table.GridColumnStyles.Add(gridTextBoxColumn1);
            DataGridTextBoxColumn gridTextBoxColumn2 = new DataGridTextBoxColumn();
            gridTextBoxColumn2.MappingName = "ResRef";
            gridTextBoxColumn2.HeaderText = "ResRef";
            gridTextBoxColumn2.NullText = "";
            gridTextBoxColumn2.TextBox.CharacterCasing = CharacterCasing.Lower;
            gridTextBoxColumn2.TextBox.MaxLength = 16;
            table.GridColumnStyles.Add(gridTextBoxColumn2);
            DataGridTextBoxColumn gridTextBoxColumn3 = new DataGridTextBoxColumn();
            gridTextBoxColumn3.MappingName = "Qty";
            gridTextBoxColumn3.HeaderText = "Qty";
            gridTextBoxColumn3.NullText = "";
            table.GridColumnStyles.Add(gridTextBoxColumn3);
            DataGridBoolColumn dataGridBoolColumn = new DataGridBoolColumn();
            dataGridBoolColumn.MappingName = "Dropable";
            dataGridBoolColumn.HeaderText = "Dropable";
            dataGridBoolColumn.NullValue = false;
            dataGridBoolColumn.AllowNull = false;
            table.GridColumnStyles.Add(dataGridBoolColumn);
            DgPackItems.TableStyles.Add(table);
            DgPackItems.SetDataBinding(_dView, null);
            DgPackItems.CaptionText = "Pack Inventory";
            DgPackItems.CaptionFont = new Font("Microsoft Sans Serif", 9f);
        }

        private void TreeView1_MouseDown(object sender, MouseEventArgs e)
        {
            TreeView.SelectedNode = TreeView.GetNodeAt(new Point(e.X, e.Y));
        }

        public void BuildTreeParents()
        {
            ClsChitinKey clsChitinKey = new ClsChitinKey(ConfigOptions.Paths.KeyFileLocation(_kotorVersionIndex));
            string[] strArray1 = new string[2];
            FileStream fsin = new FileStream( ConfigOptions.Paths.KotorLocation(_kotorVersionIndex) + "\\data\\templates.bif", FileMode.Open);
            BiffArchive biffArchive = new BiffArchive(fsin);
            bool flag1 = true;
            byte[] numArray = null;
            if (ConfigOptions.Toggles.UseOverrideFiles)
            {
                string path = ConfigOptions.Paths.KotorLocation(_kotorVersionIndex) + "\\override\\baseitems.2da";
                try
                {
                    if (File.Exists(path))
                    {
                        FileStream fileStream = new FileStream(path, FileMode.Open);
                        numArray = new byte[(int) fileStream.Length + 1];
                        fileStream.Read(numArray, 0, (int) fileStream.Length);
                        fileStream.Close();
                        flag1 = false;
                        Console.WriteLine("Read baseitems.2da from override");
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Console.WriteLine("Could not load " + path + " in " + GetType().Name);
                    ProjectData.ClearProjectError();
                }
            }

            if (flag1)
            {
                int resIdForResRef = clsChitinKey.FindResIdForResRef("baseitems", 2017);
                // numArray = BiffArchive.GetBiffResource(CurrentSettings.KotorLocation(KotorVersionIndex) + "\\" + clsChitinKey.BiffList[resIdForResRef >> 20].Filename, resIdForResRef).Data;
                Console.WriteLine("Read baseitems.2da from 2da.bif");
            }

            ArrayList namesAndTypesList = new ClsBaseItems2Da(numArray).GetItemNamesAndTypesList(GClsDialogTlk);
            int num1 = -1;

            foreach (TreeBaseItem treeBaseItem in namesAndTypesList)
            {
                if (StringType.StrCmp(treeBaseItem.Itemtype, "****", false) != 0)
                {
                    int int32 = Convert.ToInt32(treeBaseItem.Itemtype);
                    if (int32 > num1)
                        num1 = int32;
                }
            }

            int limit = num1 + 1;
            TreeView.BeginUpdate();
            TreeView.Nodes.Clear();
            int num2 = 0;
            int num3 = limit;
            int num4 = num2;
            while (num4 <= num3)
            {
                TreeView.Nodes.Add(StringType.FromInteger(num4));
                ++num4;
            }

            foreach (TreeBaseItem treeBaseItem in namesAndTypesList)
            {
                if (Information.IsNumeric(treeBaseItem.Itemtype)) TreeView.Nodes[IntegerType.FromString(treeBaseItem.Itemtype)].Nodes.Add(new TreeNode(treeBaseItem.Name) {Tag = "BI=" + StringType.FromInteger(treeBaseItem.Index) + "|ES=" + treeBaseItem.Slots});
                else if (treeBaseItem.Name.StartsWith("Creature")) TreeView.Nodes[limit].Nodes.Add(new TreeNode(treeBaseItem.Name) {Tag = "BI=" + StringType.FromInteger(treeBaseItem.Index) + "|ES=" + treeBaseItem.Slots});
            }

            ArrayList keysforResourceType = clsChitinKey.GetKeysforResourceType(ResourceIdentification.GetIdForRsrcType("uti"));
            frmProgressMeter frmProgressMeter = new frmProgressMeter();
            frmProgressMeter.stepAmount = 1;
            frmProgressMeter.maxvalue = keysforResourceType.Count;
            frmProgressMeter.message = "Getting Inventory from Warehouse";
            ((Control) frmProgressMeter).Location = new UtilWindowRelativePositioner(this, frmProgressMeter).GetConcentric();
            frmProgressMeter.Show();

            foreach (KeyEntry keyEntry in keysforResourceType)
            {
                ClsGff clsGff = new ClsGff(biffArchive.GetBiffResource(checked(keyEntry.ResId - keyEntry.ResId >> 20 << 20)).Data, _kotorVersionIndex);
                GffExoLocString nodeValue = (GffExoLocString) clsGff.GetNodeValue("LocalizedName");
                string str = nodeValue.StringRef != -1 ? GClsDialogTlk.GetString(nodeValue.StringRef) : "(no name)";
                frmProgressMeter.status = str;
                frmProgressMeter.stepUp();
                TreeNode node1 = new TreeNode(str);
                node1.Tag = RuntimeHelpers.GetObjectValue(clsGff.GetNodeValue("TemplateResRef"));
                ResRef2NameLookupList.Add(new InventoryItem(str, StringType.FromObject(node1.Tag)));
                int num5 = IntegerType.FromObject(clsGff.GetNodeValue("BaseItem"));
                bool flag2 = false;
                int num6 = 0;
                int num7 = limit;
                int index = num6;
                while (index <= num7)
                {
                    foreach (TreeNode node2 in TreeView.Nodes[index].Nodes)
                    {
                        string[] strArray2 = Strings.Split(StringType.FromObject(node2.Tag), "|");
                        if (StringType.StrCmp(strArray2[0], "BI=" + StringType.FromInteger(num5), false) == 0)
                        {
                            TreeNode treeNode = node1;
                            treeNode.Tag = ObjectType.StrCatObj(treeNode.Tag, "|" + strArray2[1]);
                            node2.Nodes.Add(node1);
                            flag2 = true;
                            break;
                        }
                    }

                    if (!flag2)
                      ++index;
                        
                    else
                        break;
                }
            }

            frmProgressMeter.Close();
            fsin.Close();
            AssignTreeParentTitles();
            if (_kotorVersionIndex == 0) RemoveGoofyCreatureItems();
            RemoveEmptyTreeParents(limit);
            TreeView.EndUpdate();
        }

        public void RemoveEmptyTreeParents(int limit)
        {
            int index = limit;
            while (index >= 0)
            {
                if (TreeView.Nodes[index].Nodes.Count == 0)
                    TreeView.Nodes.RemoveAt(index);
                checked
                {
                    index += -1;
                }
            }
        }

        private void RemoveGoofyCreatureItems()
        {
            foreach (TreeNode node1 in TreeView.Nodes[48].Nodes)
            {
                foreach (TreeNode node2 in node1.Nodes)
                {
                    if (node2.Tag.ToString().StartsWith("w_null"))
                        node1.Nodes.Remove(node2);
                    else if (node2.Tag.ToString().StartsWith("w_lghtsbr001"))
                        node1.Nodes.Remove(node2);
                    else if (node2.Tag.ToString().StartsWith("w_blhvy001"))
                        node1.Nodes.Remove(node2);
                }
            }
        }

        private void AssignTreeParentTitles()
        {
            TreeView.Nodes[0].Text = "Handheld Weapons 1";
            TreeView.Nodes[1].Text = "Handheld Weapons 2";
            TreeView.Nodes[2].Text = "Handheld Weapons 3";
            TreeView.Nodes[3].Text = "Blasters";
            TreeView.Nodes[4].Text = "Rifles";
            TreeView.Nodes[5].Text = "Rep. Blasters";
            TreeView.Nodes[6].Text = "Grenades";
            TreeView.Nodes[12].Text = "Droid Utility";
            TreeView.Nodes[13].Text = "Droid Shields";
            TreeView.Nodes[14].Text = "Droid Spike";
            TreeView.Nodes[15].Text = "Droid Plating";
            TreeView.Nodes[16].Text = "Droid Sensors";
            TreeView.Nodes[18].Text = "Masks";
            TreeView.Nodes[19].Text = "Gauntlets";
            TreeView.Nodes[20].Text = "Forearm Bands";
            TreeView.Nodes[21].Text = "Belts";
            TreeView.Nodes[22].Text = "Implants";
            TreeView.Nodes[23].Text = "Credits";
            TreeView.Nodes[24].Text = "Datapads";
            TreeView.Nodes[25].Text = "Stims";
            TreeView.Nodes[26].Text = "Droid Repair";
            TreeView.Nodes[27].Text = "Spikes";
            TreeView.Nodes[28].Text = "Mines";
            TreeView.Nodes[29].Text = "Lighting Devices";
            TreeView.Nodes[30].Text = "Plot Items";
            TreeView.Nodes[31].Text = "Armor Type 1";
            TreeView.Nodes[32].Text = "Armor Type 2";
            TreeView.Nodes[33].Text = "Armor Type 3";
            TreeView.Nodes[34].Text = "Armor Type 4";
            TreeView.Nodes[35].Text = "Armor Type 5";
            TreeView.Nodes[36].Text = "Armor Type 6";
            TreeView.Nodes[37].Text = "Clothing/Disguises";
            TreeView.Nodes[38].Text = "Robes";
            TreeView.Nodes[39].Text = "Double-Bladed Light Sabers";
            TreeView.Nodes[40].Text = "Short Light Sabers";
            TreeView.Nodes[41].Text = "Light Sabers";
            TreeView.Nodes[42].Text = "Pazaak Decks";
            TreeView.Nodes[43].Text = "Pazaak Side Decks";
            TreeView.Nodes[44].Text = "Stealth Items";
            TreeView.Nodes[45].Text = "Medical";
            TreeView.Nodes[46].Text = "Light Saber Crystals";
            TreeView.Nodes[47].Text = "Super Stim Item";
            if (_kotorVersionIndex == 0)
            {
                TreeView.Nodes[48].Text = "Creature Item";
            }
            else
            {
                if (_kotorVersionIndex != 1)
                    return;
                TreeView.Nodes[48].Text = "Wrist Items";
                TreeView.Nodes[49].Text = "Rockets";
                TreeView.Nodes[50].Text = "Chemicals";
                TreeView.Nodes[51].Text = "Components";
                TreeView.Nodes[52].Text = "Creature Item";
            }
        }

        public void SetEquippedPanelsToolTips()
        {
            ToolTip1.SetToolTip(PnlArmor, "(empty)");
            ToolTip1.SetToolTip(PnlBelt, "(empty)");
            ToolTip1.SetToolTip(PnlHands, "(empty)");
            ToolTip1.SetToolTip(PnlHead, "(empty)");
            ToolTip1.SetToolTip(PnlImplant, "(empty)");
            ToolTip1.SetToolTip(PnlLArm, "(empty)");
            ToolTip1.SetToolTip(PnlLWeapon, "(empty)");
            ToolTip1.SetToolTip(PnlRArm, "(empty)");
            ToolTip1.SetToolTip(PnlRWeapon, "(empty)");
            ToolTip1.SetToolTip(PnlCreatureHide, "(empty)");
            ToolTip1.SetToolTip(PnlCreatureItem1, "(empty)");
            ToolTip1.SetToolTip(PnlCreatureItem2, "(empty)");
            ToolTip1.SetToolTip(PnlCreatureItem3, "(empty)");
        }

        private void HidePanelIndicators()
        {
            PnlArmorBkgnd.Visible = false;
            PnlBeltBkgnd.Visible = false;
            PnlHandsBkgnd.Visible = false;
            PnlHeadBkgnd.Visible = false;
            PnlImplantBkgnd.Visible = false;
            PnlLArmBkgnd.Visible = false;
            PnlLWeaponBkgnd.Visible = false;
            PnlRArmBkgnd.Visible = false;
            PnlRWeaponBkgnd.Visible = false;
            PnlCreatureHideBkgnd.Visible = false;
            PnlCreatureItem1Bkgnd.Visible = false;
            PnlCreatureItem2Bkgnd.Visible = false;
            PnlCreatureItem3Bkgnd.Visible = false;
        }

        private void ManageEqInventory(string iteminfo, InventoryPanel sender, bool dropable)
        {
            string[] strArray = Strings.Split(iteminfo, "|");
            ToolTip1.SetToolTip(sender, strArray[0] + " (" + strArray[1] + ")");
            sender.Tag = strArray[1];
            sender.Dropable = dropable;
            sender.IsEmpty = false;

            foreach (Control control in TabPage1.Controls)
            {
                if (StringType.StrCmp(control.Name, sender.Name + "Bkgnd", false) == 0)
                {
                    control.Visible = true;
                    return;
                }
            }


            foreach (Control control in TabPage2.Controls)
            {
                if (StringType.StrCmp(control.Name, sender.Name + "Bkgnd", false) == 0)
                {
                    control.Visible = true;
                    break;
                }
            }
        }

        public void PositionWindow()
        {
            Point point1 = ConfigOptions.WindowSettings.InventoryEditorWindowLoc;
            if (!point1.IsEmpty) ((Control) this).Location = ConfigOptions.WindowSettings.InventoryEditorWindowLoc;
            if (ConfigOptions.WindowSettings.InventoryEditorWindowSize.IsEmpty) return;
            Size size1 = ConfigOptions.WindowSettings.InventoryEditorWindowSize;
            Rectangle workingArea;
            int height1 = 0;
            if (size1.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                Point point2 = new Point(40, 40);
                Point local1 = @point2;
                point1 = ((Control) this).Location;
                int x = point1.X;
                int top = Screen.PrimaryScreen.WorkingArea.Top;
                local1 = new Point(x, top);
                ((Control) this).Location = point2;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                height1 = workingArea.Height;
                Size size2 = new Size(10, 10);
                Size local2 = @size2;
                size1 = Size;
                int width = size1.Width;
                int height2 = height1;
                local2 = new Size(width, height2);
                Size = size2;
            }

            int width1 = ConfigOptions.WindowSettings.InventoryEditorWindowSize.Width;
            workingArea = Screen.PrimaryScreen.WorkingArea;
            int width2 = workingArea.Width;
            int width3 = 0;
            if (width1 > width2)
            {
                point1 = new Point(Screen.PrimaryScreen.WorkingArea.Left, ((Control) this).Location.Y);
                ((Control) this).Location = point1;
                workingArea = Screen.PrimaryScreen.WorkingArea;
                width3 = workingArea.Width;
                size1 = new Size(width3, Size.Height);
                Size = size1;
            }

            if (!(width3 == 0 & height1 == 0))
                return;
            Size = ConfigOptions.WindowSettings.InventoryEditorWindowSize;
        }

        public void SaveSettings()
        {
            ConfigOptions.WindowSettings.InventoryEditorWindowLoc = ((Control) this).Location;
            ConfigOptions.WindowSettings.InventoryEditorWindowSize = Size;
        }

        public void AutoSizeColumns()
        {
            int num1 = 0;
            int num2 = checked(_dt.Columns.Count - 1);
            int col = num1;
            while (col <= num2)
            {
                DgPackItems.TableStyles[0].GridColumnStyles[col].Width = GetColWidth(col, _dt.Columns[col].Caption);
                checked
                {
                    ++col;
                }
            }
        }

        private int GetColWidth(int col, string displayName)
        {
            int count = ((DataView) DgPackItems.DataSource).Count;
            Graphics graphics = Graphics.FromHwnd(Handle);
            StringFormat format = new StringFormat(StringFormat.GenericTypographic);
            float num1 = graphics.MeasureString(displayName, DgPackItems.Font, 500, format).Width;
            try
            {
                int num2 = 0;
                int num3 = count - 1;
                int index = num2;
                while (index <= num3)
                {
                    SizeF sizeF = graphics.MeasureString(DgPackItems[index, col].ToString(), DgPackItems.Font, 500, format);
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

        private void InsertToGridOrIncrement(string name, string resRef, int qty = 1, bool dropable = true)
        {
            int num1 = 0;
            int num2 = _dt.Rows.Count - 1;
            int index1 = num1;
            while (index1 <= num2)
            {
                if (ObjectType.ObjTst(DgPackItems[index1, 1], resRef, false) == 0)
                {
                    DataGrid dgPackItems = DgPackItems;
                    DataGrid dataGrid = dgPackItems;
                    int index2 = index1;
                    int index3 = index2;
                    int index4 = 2;
                    int index5 = index4;
                    object obj = ObjectType.AddObj(dgPackItems[index2, index4], qty);
                    dataGrid[index3, index5] = obj;
                    if (!dropable) return;
                    DgPackItems[index1, 3] = true;
                    return;
                }
               ++index1;
                
            }

            DataRow row = _dt.NewRow();
            row[0] = name;
            row[1] = resRef;
            row[2] = qty;
            row[3] = dropable;
            _dt.Rows.Add(row);
            AutoSizeColumns();
        }

        private string FindNameForResRef(string resRef)
        {
            string name = "";

            foreach (InventoryItem resRef2NameLookup in ResRef2NameLookupList)
            {
                if (StringType.StrCmp(resRef2NameLookup.ResRef, resRef, false) == 0)
                {
                    name = resRef2NameLookup.Name;
                    break;
                }
            }

            return name;
        }

        public void AddPackItem(string resRef, bool dropable)
        {
            InsertToGridOrIncrement(FindNameForResRef(resRef), resRef, 1, dropable);
        }

        public void AddEquippedItem(string resRef, int slot, bool dropable)
        {
            string iteminfo = FindNameForResRef(resRef) + "|" + resRef;
            switch (slot)
            {
                case 512:
                    ManageEqInventory(iteminfo, PnlImplant, dropable);
                    break;
                case 1:
                    ManageEqInventory(iteminfo, PnlHead, dropable);
                    break;
                case 8:
                    ManageEqInventory(iteminfo, PnlHands, dropable);
                    break;
                case 256:
                    ManageEqInventory(iteminfo, PnlLArm, dropable);
                    break;
                case 2:
                    ManageEqInventory(iteminfo, PnlArmor, dropable);
                    break;
                case 128:
                    ManageEqInventory(iteminfo, PnlRArm, dropable);
                    break;
                case 32:
                    ManageEqInventory(iteminfo, PnlLWeapon, dropable);
                    break;
                case 1024:
                    ManageEqInventory(iteminfo, PnlBelt, dropable);
                    break;
                case 16:
                    ManageEqInventory(iteminfo, PnlRWeapon, dropable);
                    break;
                case 16384:
                    ManageEqInventory(iteminfo, PnlCreatureItem1, dropable);
                    break;
                case 32768:
                    ManageEqInventory(iteminfo, PnlCreatureItem2, dropable);
                    break;
                case 65536:
                    ManageEqInventory(iteminfo, PnlCreatureItem3, dropable);
                    break;
                case 131072:
                    ManageEqInventory(iteminfo, PnlCreatureHide, dropable);
                    break;
            }
        }

        public ArrayList GetPackItemsList()
        {
            ArrayList arrayList = new ArrayList();
            int num1 = 0;
            int num2 = checked(_dt.Rows.Count - 1);
            int index = num1;
            while (index <= num2)
            {
                arrayList.Add(new InventoryItem("", StringType.FromObject(DgPackItems[index, 1]), "", IntegerType.FromObject(DgPackItems[index, 2]), BooleanType.FromObject(DgPackItems[index, 3])));
                ++index;
            }

            return arrayList;
        }

        public ArrayList GetEquippedItemsList()
        {
            return new ArrayList() {new InventoryItem("", StringType.FromObject(PnlHead.Tag), StringType.FromInteger(1), 1, PnlHead.Dropable), new InventoryItem("", StringType.FromObject(PnlArmor.Tag), StringType.FromInteger(2), 1, PnlArmor.Dropable), new InventoryItem("", StringType.FromObject(PnlHands.Tag), StringType.FromInteger(8), 1, PnlHands.Dropable), new InventoryItem("", StringType.FromObject(PnlRWeapon.Tag), StringType.FromInteger(16), 1, PnlRWeapon.Dropable), new InventoryItem("", StringType.FromObject(PnlLWeapon.Tag), StringType.FromInteger(32), 1, PnlLWeapon.Dropable), new InventoryItem("", StringType.FromObject(PnlRArm.Tag), StringType.FromInteger(128), 1, PnlRArm.Dropable), new InventoryItem("", StringType.FromObject(PnlLArm.Tag), StringType.FromInteger(256), 1, PnlLArm.Dropable), new InventoryItem("", StringType.FromObject(PnlImplant.Tag), StringType.FromInteger(512), 1, PnlImplant.Dropable), new InventoryItem("", StringType.FromObject(PnlBelt.Tag), StringType.FromInteger(1024), 1, PnlBelt.Dropable), new InventoryItem("", StringType.FromObject(PnlCreatureItem1.Tag), StringType.FromInteger(16384), 1, PnlCreatureItem1.Dropable), new InventoryItem("", StringType.FromObject(PnlCreatureItem2.Tag), StringType.FromInteger(32768), 1, PnlCreatureItem2.Dropable), new InventoryItem("", StringType.FromObject(PnlCreatureItem3.Tag), StringType.FromInteger(65536), 1, PnlCreatureItem3.Dropable), new InventoryItem("", StringType.FromObject(PnlCreatureHide.Tag), StringType.FromInteger(131072), 1, PnlCreatureHide.Dropable)};
        }

        public void SetFormName(string name)
        {
            Text = "Inventory Editor - Kotor ";
            if (_kotorVersionIndex == 0) Text = Text + "I";
            else Text = Text + "II";
            Text = Text + " - " + name;
        }

        private void AskForNewCustomResRef(InventoryPanel panel)
        {
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.Text = "Set custom item ResRef";
            frmPromptForString.lblMsg.Text = "Enter custom item ResRef:";
            frmPromptForString.tbValue.CharacterCasing = CharacterCasing.Lower;
            if (frmPromptForString.ShowDialog(this) != DialogResult.OK) return;
            ToolTip1.SetToolTip(panel, "Custom Item (" + Strings.Trim(frmPromptForString.tbValue.Text) + ")");
            panel.Tag = frmPromptForString.tbValue.Text;
            panel.IsEmpty = false;

            foreach (Control control in TabPage1.Controls)
            {
                if (StringType.StrCmp(control.Name, panel.Name + "Bkgnd", false) == 0)
                {
                    control.Visible = true;
                    break;
                }
            }
        }

        private void pnlEquipped_DoubleClick(object sender, EventArgs e)
        {
            AskForNewCustomResRef((InventoryPanel) sender);
        }

        private void pnl_MouseDown(object sender, MouseEventArgs e)
        {
            InventoryPanel inventoryPanel = (InventoryPanel) sender;
            if (MouseButtons == MouseButtons.Right)
            {
                if (inventoryPanel.IsEmpty) return;
                CmiDropable.Checked = ((InventoryPanel) sender).Dropable;
                CmEquippedItems.Show((Control) sender, (Point) (LateBinding.LateGet(sender, null, "PointToClient", new object[] {MousePosition}, null, null) ?? Activator.CreateInstance(typeof(Point))));
            }
            else HandlePanelMouseDown((Panel) sender);
        }

        private void HandlePanelMouseDown(Panel sender)
        {
            long ticks = DateAndTime.Now.Ticks;
            if (ObjectType.ObjTst(ticks - _mouseDownTime, _mouseDoubleClickTime, false) < 0) AskForNewCustomResRef((InventoryPanel) sender);
            else if (ObjectType.ObjTst(sender.Tag, "", false) != 0)
            {
                DoDragDrop(sender, DragDropEffects.Copy | DragDropEffects.Move);
            }

            _mouseDownTime = ticks;
        }

        private void dgPackItems_CurrentCellChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in (InternalDataCollectionBase) _dt.Rows)
            {
                row.EndEdit();
                bool flag1 = false;
                bool flag2 = false;
                bool flag3 = false;
                if (row[1] == DBNull.Value) flag1 = true;
                if (row[2] == DBNull.Value) flag2 = true;
                if (ObjectType.ObjTst(row[2], 1, false) < 0) flag3 = true;
                row.ClearErrors();
                if (flag1) row.SetColumnError(1, "You must enter a ResRef for this item");
                if (flag2) row.SetColumnError(2, "You must enter a Quantity for this item");
                if (flag3) row.SetColumnError(2, "You must enter a Quantity >=1 for this item");
            }
        }

        private void cmiDropable_Click(object sender, EventArgs e)
        {
            InventoryPanel inventoryPanel = (InventoryPanel) LateBinding.LateGet(LateBinding.LateGet(sender, null, "parent", new object[0], null, null), null, "sourcecontrol", new object[0], null, null);
            inventoryPanel.Dropable = !inventoryPanel.Dropable;
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            TreeView.ExpandAll();
            TreeView.SelectedNode = TreeView.Nodes[0];
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            TreeView.CollapseAll();
        }
    }
}