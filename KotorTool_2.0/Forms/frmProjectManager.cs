// Decompiled with JetBrains decompiler
// Type: KotorTool_2.frmProjectManager
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using KotorTool_2._0.MainForm;

using KotorTool_2._0.Models.CLS;
using KotorTool_2._0.Models.ERF;
using KotorTool_2._0.Options;
using KotorTool_2._0.TextEditor;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using FrmMain = KotorTool_2._0.MainForm.FrmMain;

namespace KotorTool_2._0.Forms
{
    public class frmProjectManager : frmParent
    {
        [AccessedThroughProperty("tvcmiStreamWavesModulesParent_RemoveSelf")]
        private MenuItem _tvcmiStreamWavesModulesParent_RemoveSelf;

        [AccessedThroughProperty("MenuItem15")]
        private MenuItem _MenuItem15;

        [AccessedThroughProperty("tvcmiStreamWavesModuleParent_RenameSelf")]
        private MenuItem _tvcmiStreamWavesModuleParent_RenameSelf;

        [AccessedThroughProperty("MenuItem14")]
        private MenuItem _MenuItem14;

        [AccessedThroughProperty("tvcmiStreamWavesModuleParent_ExcludeAllFiles")]
        private MenuItem _tvcmiStreamWavesModuleParent_ExcludeAllFiles;

        [AccessedThroughProperty("miOpenProject")]
        private MenuItem _miOpenProject;

        [AccessedThroughProperty("MenuItem9")] private MenuItem _MenuItem9;

        [AccessedThroughProperty("tvcmiStreamWavesModuleParent_AddFiles")]
        private MenuItem _tvcmiStreamWavesModuleParent_AddFiles;

        [AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveEverything")]
        private MenuItem _tvcmiStreamWavesRoot_RemoveEverything;

        [AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveAllModules")]
        private MenuItem _tvcmiStreamWavesRoot_RemoveAllModules;

        [AccessedThroughProperty("tvcmiStreamWavesRoot_RemoveAllFiles")]
        private MenuItem _tvcmiStreamWavesRoot_RemoveAllFiles;

        [AccessedThroughProperty("tvcmiStreamWavesRoot_AddModule")]
        private MenuItem _tvcmiStreamWavesRoot_AddModule;

        [AccessedThroughProperty("tvcmiStreamWavesRoot_AddFile")]
        private MenuItem _tvcmiStreamWavesRoot_AddFile;

        [AccessedThroughProperty("tvcmiStreamWavesFileChild_ExcludeSelf")]
        private MenuItem _tvcmiStreamWavesFileChild_ExcludeSelf;

        [AccessedThroughProperty("ilistTree")] private ImageList _ilistTree;

        [AccessedThroughProperty("tvcmiModulesParent_Properties")]
        private MenuItem _tvcmiModulesParent_Properties;

        [AccessedThroughProperty("MenuItem16")]
        private MenuItem _MenuItem16;

        [AccessedThroughProperty("tvcmStreamWavesFileChild")]
        private ContextMenu _tvcmStreamWavesFileChild;

        [AccessedThroughProperty("tvcmStreamWavesModulesChild")]
        private ContextMenu _tvcmStreamWavesModulesChild;

        [AccessedThroughProperty("tvcmStreamWavesModulesParent")]
        private ContextMenu _tvcmStreamWavesModulesParent;

        [AccessedThroughProperty("MenuItem11")]
        private MenuItem _MenuItem11;

        [AccessedThroughProperty("MainMenu1")] private MainMenu _MainMenu1;

        [AccessedThroughProperty("tvcmStreamWavesRoot")]
        private ContextMenu _tvcmStreamWavesRoot;

        [AccessedThroughProperty("MenuItem12")]
        private MenuItem _MenuItem12;

        [AccessedThroughProperty("MenuItem1")] private MenuItem _MenuItem1;

        [AccessedThroughProperty("miCleanReleasePrjFilesOnly")]
        private MenuItem _miCleanReleasePrjFilesOnly;

        [AccessedThroughProperty("miCleanDebugPrjFilesOnly")]
        private MenuItem _miCleanDebugPrjFilesOnly;

        [AccessedThroughProperty("tvcmiLipsModulesParent_RenameSelf")]
        private MenuItem _tvcmiLipsModulesParent_RenameSelf;

        [AccessedThroughProperty("TreeView")] private TreeView _TreeView;

        [AccessedThroughProperty("tvcmiModulesParent_RenameSelf")]
        private MenuItem _tvcmiModulesParent_RenameSelf;

        [AccessedThroughProperty("miExploreDebugFolder")]
        private MenuItem _miExploreDebugFolder;

        [AccessedThroughProperty("miExploreReleaseFolder")]
        private MenuItem _miExploreReleaseFolder;

        [AccessedThroughProperty("tvcmiProperties")]
        private MenuItem _tvcmiProperties;

        [AccessedThroughProperty("tvcmProjectRoot")]
        private ContextMenu _tvcmProjectRoot;

        [AccessedThroughProperty("tvcmiLipsModulesParent_RemoveSelf")]
        private MenuItem _tvcmiLipsModulesParent_RemoveSelf;

        [AccessedThroughProperty("MenuItem13")]
        private MenuItem _MenuItem13;

        [AccessedThroughProperty("MenuItem5")] private MenuItem _MenuItem5;
        [AccessedThroughProperty("miQuit")] private MenuItem _miQuit;
        [AccessedThroughProperty("MenuItem8")] private MenuItem _MenuItem8;

        [AccessedThroughProperty("tvcmiModulesParent_RemoveSelf")]
        private MenuItem _tvcmiModulesParent_RemoveSelf;

        [AccessedThroughProperty("tvcmiLipsModulesRoot_RemoveAllModules")]
        private MenuItem _tvcmiLipsModulesRoot_RemoveAllModules;

        [AccessedThroughProperty("tvcmiModulesRoot_RemoveAllModules")]
        private MenuItem _tvcmiModulesRoot_RemoveAllModules;

        [AccessedThroughProperty("lblStatus")] private Label _lblStatus;

        [AccessedThroughProperty("tvcmiLipsModulesParent_RemoveAll")]
        private MenuItem _tvcmiLipsModulesParent_RemoveAll;

        [AccessedThroughProperty("MenuItem2")] private MenuItem _MenuItem2;

        [AccessedThroughProperty("tvcmiModulesParent_RemoveAll")]
        private MenuItem _tvcmiModulesParent_RemoveAll;

        [AccessedThroughProperty("MenuItem4")] private MenuItem _MenuItem4;

        [AccessedThroughProperty("tvcmiOverrideRoot_RemoveAll")]
        private MenuItem _tvcmiOverrideRoot_RemoveAll;

        [AccessedThroughProperty("MenuItem7")] private MenuItem _MenuItem7;
        [AccessedThroughProperty("MenuItem6")] private MenuItem _MenuItem6;
        [AccessedThroughProperty("MenuItem3")] private MenuItem _MenuItem3;

        [AccessedThroughProperty("miBuildProject")]
        private MenuItem _miBuildProject;

        [AccessedThroughProperty("MenuItem10")]
        private MenuItem _MenuItem10;

        [AccessedThroughProperty("tvcmOverrideRoot")]
        private ContextMenu _tvcmOverrideRoot;

        [AccessedThroughProperty("tvcmOverrideChild")]
        private ContextMenu _tvcmOverrideChild;

        [AccessedThroughProperty("miSaveProject")]
        private MenuItem _miSaveProject;

        [AccessedThroughProperty("tvcmModulesRoot")]
        private ContextMenu _tvcmModulesRoot;

        [AccessedThroughProperty("tvcmModulesParent")]
        private ContextMenu _tvcmModulesParent;

        [AccessedThroughProperty("tvcmModulesChild")]
        private ContextMenu _tvcmModulesChild;

        [AccessedThroughProperty("tvcmLipsModulesRoot")]
        private ContextMenu _tvcmLipsModulesRoot;

        [AccessedThroughProperty("tvcmLipsModulesParent")]
        private ContextMenu _tvcmLipsModulesParent;

        [AccessedThroughProperty("tvcmLipsModulesChild")]
        private ContextMenu _tvcmLipsModulesChild;

        [AccessedThroughProperty("tvcmiStreamWavesModulesChild_ExcludeSelf")]
        private MenuItem _tvcmiStreamWavesModulesChild_ExcludeSelf;

        [AccessedThroughProperty("tvcmiOverrideRoot_Add")]
        private MenuItem _tvcmiOverrideRoot_Add;

        [AccessedThroughProperty("tvcmiOverrideChild_Exclude")]
        private MenuItem _tvcmiOverrideChild_Exclude;

        [AccessedThroughProperty("miRelease")] private MenuItem _miRelease;

        [AccessedThroughProperty("tvcmiModulesRoot_Add")]
        private MenuItem _tvcmiModulesRoot_Add;

        [AccessedThroughProperty("tvcmiModulesParent_Add")]
        private MenuItem _tvcmiModulesParent_Add;

        [AccessedThroughProperty("tvcmiModulesChild_Exclude")]
        private MenuItem _tvcmiModulesChild_Exclude;

        [AccessedThroughProperty("tvcmiLipsModulesRoot_Add")]
        private MenuItem _tvcmiLipsModulesRoot_Add;

        [AccessedThroughProperty("tvcmiLipsModulesParent_Add")]
        private MenuItem _tvcmiLipsModulesParent_Add;

        [AccessedThroughProperty("tvcmiLipsModulesChild_Exclude")]
        private MenuItem _tvcmiLipsModulesChild_Exclude;

        [AccessedThroughProperty("miProjectProperties")]
        private MenuItem _miProjectProperties;

        [AccessedThroughProperty("miNewPoject")]
        private MenuItem _miNewPoject;

        [AccessedThroughProperty("miDebug")] private MenuItem _miDebug;
        private string InitialBrowsePath;
        private string ProjectFilePath;
        private string WorkingPath;
        private ClsProjectManager ProjectMgr;
        private ClsProject Project;
        private TreeNode LastClickedTVNode;
        private FrmMain MyParentForm;
        private string BuildMode;
        private const int ilFileIcon = 1;
        private const int ilFolderIcon = 2;
        private IContainer components;

        internal virtual TreeView TreeView
        {
            get => _TreeView;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TreeView != null)
                {
                    _TreeView.DoubleClick -= TreeView_DoubleClick;
                    _TreeView.MouseLeave -= TreeView_MouseLeave;
                    _TreeView.MouseMove -= TreeView_MouseMove;
                    _TreeView.DragOver -= TreeView_DragOver;
                    _TreeView.DragDrop -= TreeView_DragDrop;
                    _TreeView.MouseDown -= TreeView_MouseDown;
                }

                _TreeView = value;
                if (_TreeView == null)
                    return;
                _TreeView.DoubleClick += TreeView_DoubleClick;
                _TreeView.MouseLeave += TreeView_MouseLeave;
                _TreeView.MouseMove += TreeView_MouseMove;
                _TreeView.DragOver += TreeView_DragOver;
                _TreeView.DragDrop += TreeView_DragDrop;
                _TreeView.MouseDown += TreeView_MouseDown;
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

        internal virtual ContextMenu tvcmOverrideRoot
        {
            get => _tvcmOverrideRoot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmOverrideRoot == null)
                    ;
                _tvcmOverrideRoot = value;
                if (_tvcmOverrideRoot != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmOverrideChild
        {
            get => _tvcmOverrideChild;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmOverrideChild == null)
                    ;
                _tvcmOverrideChild = value;
                if (_tvcmOverrideChild != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmModulesRoot
        {
            get => _tvcmModulesRoot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmModulesRoot == null)
                    ;
                _tvcmModulesRoot = value;
                if (_tvcmModulesRoot != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmModulesParent
        {
            get => _tvcmModulesParent;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmModulesParent == null)
                    ;
                _tvcmModulesParent = value;
                if (_tvcmModulesParent != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmModulesChild
        {
            get => _tvcmModulesChild;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmModulesChild == null)
                    ;
                _tvcmModulesChild = value;
                if (_tvcmModulesChild != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmLipsModulesRoot
        {
            get => _tvcmLipsModulesRoot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmLipsModulesRoot == null)
                    ;
                _tvcmLipsModulesRoot = value;
                if (_tvcmLipsModulesRoot != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmLipsModulesParent
        {
            get => _tvcmLipsModulesParent;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmLipsModulesParent == null)
                    ;
                _tvcmLipsModulesParent = value;
                if (_tvcmLipsModulesParent != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmLipsModulesChild
        {
            get => _tvcmLipsModulesChild;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmLipsModulesChild == null)
                    ;
                _tvcmLipsModulesChild = value;
                if (_tvcmLipsModulesChild != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiOverrideRoot_Add
        {
            get => _tvcmiOverrideRoot_Add;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiOverrideRoot_Add != null)
                    _tvcmiOverrideRoot_Add.Click -= tvcmiOverrideRoot_Add_Click;
                _tvcmiOverrideRoot_Add = value;
                if (_tvcmiOverrideRoot_Add == null)
                    return;
                _tvcmiOverrideRoot_Add.Click += tvcmiOverrideRoot_Add_Click;
            }
        }

        internal virtual MenuItem tvcmiOverrideChild_Exclude
        {
            get => _tvcmiOverrideChild_Exclude;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiOverrideChild_Exclude != null)
                    _tvcmiOverrideChild_Exclude.Click -= tvcmiOverrideChild_Exclude_Click;
                _tvcmiOverrideChild_Exclude = value;
                if (_tvcmiOverrideChild_Exclude == null)
                    return;
                _tvcmiOverrideChild_Exclude.Click += tvcmiOverrideChild_Exclude_Click;
            }
        }

        internal virtual MenuItem tvcmiModulesRoot_Add
        {
            get => _tvcmiModulesRoot_Add;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesRoot_Add != null)
                    _tvcmiModulesRoot_Add.Click -= tvcmiModulesRoot_Add_Click;
                _tvcmiModulesRoot_Add = value;
                if (_tvcmiModulesRoot_Add == null)
                    return;
                _tvcmiModulesRoot_Add.Click += tvcmiModulesRoot_Add_Click;
            }
        }

        internal virtual MenuItem tvcmiModulesParent_Add
        {
            get => _tvcmiModulesParent_Add;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesParent_Add != null)
                    _tvcmiModulesParent_Add.Click -= tvcmiModulesParent_Add_Click;
                _tvcmiModulesParent_Add = value;
                if (_tvcmiModulesParent_Add == null)
                    return;
                _tvcmiModulesParent_Add.Click += tvcmiModulesParent_Add_Click;
            }
        }

        internal virtual MenuItem tvcmiModulesChild_Exclude
        {
            get => _tvcmiModulesChild_Exclude;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesChild_Exclude != null)
                    _tvcmiModulesChild_Exclude.Click -= tvcmiModulesChild_Exclude_Click;
                _tvcmiModulesChild_Exclude = value;
                if (_tvcmiModulesChild_Exclude == null)
                    return;
                _tvcmiModulesChild_Exclude.Click += tvcmiModulesChild_Exclude_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesRoot_Add
        {
            get => _tvcmiLipsModulesRoot_Add;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesRoot_Add != null)
                    _tvcmiLipsModulesRoot_Add.Click -= tvcmiLipsModulesRoot_Add_Click;
                _tvcmiLipsModulesRoot_Add = value;
                if (_tvcmiLipsModulesRoot_Add == null)
                    return;
                _tvcmiLipsModulesRoot_Add.Click += tvcmiLipsModulesRoot_Add_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesParent_Add
        {
            get => _tvcmiLipsModulesParent_Add;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesParent_Add != null)
                    _tvcmiLipsModulesParent_Add.Click -= tvcmiLipsModulesParent_Add_Click;
                _tvcmiLipsModulesParent_Add = value;
                if (_tvcmiLipsModulesParent_Add == null)
                    return;
                _tvcmiLipsModulesParent_Add.Click += tvcmiLipsModulesParent_Add_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesChild_Exclude
        {
            get => _tvcmiLipsModulesChild_Exclude;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesChild_Exclude != null)
                    _tvcmiLipsModulesChild_Exclude.Click -= tvcmiLipsModulesChild_Exclude_Click;
                _tvcmiLipsModulesChild_Exclude = value;
                if (_tvcmiLipsModulesChild_Exclude == null)
                    return;
                _tvcmiLipsModulesChild_Exclude.Click += tvcmiLipsModulesChild_Exclude_Click;
            }
        }

        internal virtual MenuItem miProjectProperties
        {
            get => _miProjectProperties;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miProjectProperties != null)
                    _miProjectProperties.Click -= miProjectProperties_Click;
                _miProjectProperties = value;
                if (_miProjectProperties == null)
                    return;
                _miProjectProperties.Click += miProjectProperties_Click;
            }
        }

        internal virtual MenuItem miNewPoject
        {
            get => _miNewPoject;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miNewPoject != null)
                    _miNewPoject.Click -= miNewPoject_Click;
                _miNewPoject = value;
                if (_miNewPoject == null)
                    return;
                _miNewPoject.Click += miNewPoject_Click;
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

        internal virtual MenuItem miDebug
        {
            get => _miDebug;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miDebug != null)
                    _miDebug.Click -= miDebug_Click;
                _miDebug = value;
                if (_miDebug == null)
                    return;
                _miDebug.Click += miDebug_Click;
            }
        }

        internal virtual MenuItem miRelease
        {
            get => _miRelease;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miRelease != null)
                    _miRelease.Click -= miRelease_Click;
                _miRelease = value;
                if (_miRelease == null)
                    return;
                _miRelease.Click += miRelease_Click;
            }
        }

        internal virtual MenuItem miOpenProject
        {
            get => _miOpenProject;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miOpenProject != null)
                    _miOpenProject.Click -= miOpenProject_Click;
                _miOpenProject = value;
                if (_miOpenProject == null)
                    return;
                _miOpenProject.Click += miOpenProject_Click;
            }
        }

        internal virtual MenuItem miSaveProject
        {
            get => _miSaveProject;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miSaveProject != null)
                    _miSaveProject.Click -= miSaveProject_Click;
                _miSaveProject = value;
                if (_miSaveProject == null)
                    return;
                _miSaveProject.Click += miSaveProject_Click;
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

        internal virtual MenuItem miBuildProject
        {
            get => _miBuildProject;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miBuildProject != null)
                    _miBuildProject.Click -= miBuildProject_Click;
                _miBuildProject = value;
                if (_miBuildProject == null)
                    return;
                _miBuildProject.Click += miBuildProject_Click;
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

        internal virtual MenuItem tvcmiOverrideRoot_RemoveAll
        {
            get => _tvcmiOverrideRoot_RemoveAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiOverrideRoot_RemoveAll != null)
                    _tvcmiOverrideRoot_RemoveAll.Click -= tvcmiOverrideRoot_RemoveAll_Click;
                _tvcmiOverrideRoot_RemoveAll = value;
                if (_tvcmiOverrideRoot_RemoveAll == null)
                    return;
                _tvcmiOverrideRoot_RemoveAll.Click += tvcmiOverrideRoot_RemoveAll_Click;
            }
        }

        internal virtual MenuItem tvcmiModulesParent_RemoveAll
        {
            get => _tvcmiModulesParent_RemoveAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesParent_RemoveAll != null)
                    _tvcmiModulesParent_RemoveAll.Click -= tvcmiModulesParent_RemoveAll_Click;
                _tvcmiModulesParent_RemoveAll = value;
                if (_tvcmiModulesParent_RemoveAll == null)
                    return;
                _tvcmiModulesParent_RemoveAll.Click += tvcmiModulesParent_RemoveAll_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesParent_RemoveAll
        {
            get => _tvcmiLipsModulesParent_RemoveAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesParent_RemoveAll != null)
                    _tvcmiLipsModulesParent_RemoveAll.Click -= tvcmiLipsModulesParent_RemoveAll_Click;
                _tvcmiLipsModulesParent_RemoveAll = value;
                if (_tvcmiLipsModulesParent_RemoveAll == null)
                    return;
                _tvcmiLipsModulesParent_RemoveAll.Click += tvcmiLipsModulesParent_RemoveAll_Click;
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

        internal virtual MenuItem tvcmiModulesRoot_RemoveAllModules
        {
            get => _tvcmiModulesRoot_RemoveAllModules;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesRoot_RemoveAllModules != null)
                    _tvcmiModulesRoot_RemoveAllModules.Click -= tvcmModulesRoot_RemoveAllModules_Click;
                _tvcmiModulesRoot_RemoveAllModules = value;
                if (_tvcmiModulesRoot_RemoveAllModules == null)
                    return;
                _tvcmiModulesRoot_RemoveAllModules.Click += tvcmModulesRoot_RemoveAllModules_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesRoot_RemoveAllModules
        {
            get => _tvcmiLipsModulesRoot_RemoveAllModules;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesRoot_RemoveAllModules != null)
                    _tvcmiLipsModulesRoot_RemoveAllModules.Click -= tvcmLipsModulesRoot_RemoveAllModules_Click;
                _tvcmiLipsModulesRoot_RemoveAllModules = value;
                if (_tvcmiLipsModulesRoot_RemoveAllModules == null)
                    return;
                _tvcmiLipsModulesRoot_RemoveAllModules.Click += tvcmLipsModulesRoot_RemoveAllModules_Click;
            }
        }

        internal virtual MenuItem tvcmiModulesParent_RemoveSelf
        {
            get => _tvcmiModulesParent_RemoveSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesParent_RemoveSelf != null)
                    _tvcmiModulesParent_RemoveSelf.Click -= tvcmiModulesParent_RemoveSelf_Click;
                _tvcmiModulesParent_RemoveSelf = value;
                if (_tvcmiModulesParent_RemoveSelf == null)
                    return;
                _tvcmiModulesParent_RemoveSelf.Click += tvcmiModulesParent_RemoveSelf_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesParent_RemoveSelf
        {
            get => _tvcmiLipsModulesParent_RemoveSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesParent_RemoveSelf != null)
                    _tvcmiLipsModulesParent_RemoveSelf.Click -= tvcmiLipsModulesParent_RemoveSelf_Click;
                _tvcmiLipsModulesParent_RemoveSelf = value;
                if (_tvcmiLipsModulesParent_RemoveSelf == null)
                    return;
                _tvcmiLipsModulesParent_RemoveSelf.Click += tvcmiLipsModulesParent_RemoveSelf_Click;
            }
        }

        internal virtual ContextMenu tvcmProjectRoot
        {
            get => _tvcmProjectRoot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmProjectRoot == null)
                    ;
                _tvcmProjectRoot = value;
                if (_tvcmProjectRoot != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiProperties
        {
            get => _tvcmiProperties;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiProperties != null)
                    _tvcmiProperties.Click -= tvcmiProperties_Click;
                _tvcmiProperties = value;
                if (_tvcmiProperties == null)
                    return;
                _tvcmiProperties.Click += tvcmiProperties_Click;
            }
        }

        internal virtual MenuItem miExploreReleaseFolder
        {
            get => _miExploreReleaseFolder;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miExploreReleaseFolder != null)
                    _miExploreReleaseFolder.Click -= miExploreReleaseFolder_Click;
                _miExploreReleaseFolder = value;
                if (_miExploreReleaseFolder == null)
                    return;
                _miExploreReleaseFolder.Click += miExploreReleaseFolder_Click;
            }
        }

        internal virtual MenuItem miExploreDebugFolder
        {
            get => _miExploreDebugFolder;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miExploreDebugFolder != null)
                    _miExploreDebugFolder.Click -= miExploreDebugFolder_Click;
                _miExploreDebugFolder = value;
                if (_miExploreDebugFolder == null)
                    return;
                _miExploreDebugFolder.Click += miExploreDebugFolder_Click;
            }
        }

        internal virtual MenuItem MenuItem10
        {
            get => _MenuItem10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem10 == null)
                    ;
                _MenuItem10 = value;
                if (_MenuItem10 != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiModulesParent_RenameSelf
        {
            get => _tvcmiModulesParent_RenameSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesParent_RenameSelf != null)
                    _tvcmiModulesParent_RenameSelf.Click -= tvcmiModulesParent_RenameSelf_Click;
                _tvcmiModulesParent_RenameSelf = value;
                if (_tvcmiModulesParent_RenameSelf == null)
                    return;
                _tvcmiModulesParent_RenameSelf.Click += tvcmiModulesParent_RenameSelf_Click;
            }
        }

        internal virtual MenuItem tvcmiLipsModulesParent_RenameSelf
        {
            get => _tvcmiLipsModulesParent_RenameSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiLipsModulesParent_RenameSelf != null)
                    _tvcmiLipsModulesParent_RenameSelf.Click -= tvcmiLipsModulesParent_RenameSelf_Click;
                _tvcmiLipsModulesParent_RenameSelf = value;
                if (_tvcmiLipsModulesParent_RenameSelf == null)
                    return;
                _tvcmiLipsModulesParent_RenameSelf.Click += tvcmiLipsModulesParent_RenameSelf_Click;
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

        internal virtual MenuItem miCleanDebugPrjFilesOnly
        {
            get => _miCleanDebugPrjFilesOnly;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCleanDebugPrjFilesOnly != null)
                    _miCleanDebugPrjFilesOnly.Click -= miCleanDebugPrjFilesOnly_Click;
                _miCleanDebugPrjFilesOnly = value;
                if (_miCleanDebugPrjFilesOnly == null)
                    return;
                _miCleanDebugPrjFilesOnly.Click += miCleanDebugPrjFilesOnly_Click;
            }
        }

        internal virtual MenuItem miCleanReleasePrjFilesOnly
        {
            get => _miCleanReleasePrjFilesOnly;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_miCleanReleasePrjFilesOnly != null)
                    _miCleanReleasePrjFilesOnly.Click -= miCleanReleasePrjFilesOnly_Click;
                _miCleanReleasePrjFilesOnly = value;
                if (_miCleanReleasePrjFilesOnly == null)
                    return;
                _miCleanReleasePrjFilesOnly.Click += miCleanReleasePrjFilesOnly_Click;
            }
        }

        internal virtual MenuItem MenuItem11
        {
            get => _MenuItem11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem11 == null)
                    ;
                _MenuItem11 = value;
                if (_MenuItem11 != null)
                    ;
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

        internal virtual ContextMenu tvcmStreamWavesRoot
        {
            get => _tvcmStreamWavesRoot;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmStreamWavesRoot == null)
                    ;
                _tvcmStreamWavesRoot = value;
                if (_tvcmStreamWavesRoot != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmStreamWavesModulesParent
        {
            get => _tvcmStreamWavesModulesParent;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmStreamWavesModulesParent == null)
                    ;
                _tvcmStreamWavesModulesParent = value;
                if (_tvcmStreamWavesModulesParent != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmStreamWavesModulesChild
        {
            get => _tvcmStreamWavesModulesChild;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmStreamWavesModulesChild == null)
                    ;
                _tvcmStreamWavesModulesChild = value;
                if (_tvcmStreamWavesModulesChild != null)
                    ;
            }
        }

        internal virtual ContextMenu tvcmStreamWavesFileChild
        {
            get => _tvcmStreamWavesFileChild;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmStreamWavesFileChild == null)
                    ;
                _tvcmStreamWavesFileChild = value;
                if (_tvcmStreamWavesFileChild != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesRoot_AddFile
        {
            get => _tvcmiStreamWavesRoot_AddFile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesRoot_AddFile != null)
                    _tvcmiStreamWavesRoot_AddFile.Click -= tvcmiStreamWavesRoot_AddFile_Click;
                _tvcmiStreamWavesRoot_AddFile = value;
                if (_tvcmiStreamWavesRoot_AddFile == null)
                    return;
                _tvcmiStreamWavesRoot_AddFile.Click += tvcmiStreamWavesRoot_AddFile_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesRoot_AddModule
        {
            get => _tvcmiStreamWavesRoot_AddModule;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesRoot_AddModule != null)
                    _tvcmiStreamWavesRoot_AddModule.Click -= tvcmiStreamWavesRoot_AddModule_Click;
                _tvcmiStreamWavesRoot_AddModule = value;
                if (_tvcmiStreamWavesRoot_AddModule == null)
                    return;
                _tvcmiStreamWavesRoot_AddModule.Click += tvcmiStreamWavesRoot_AddModule_Click;
            }
        }

        internal virtual MenuItem MenuItem13
        {
            get => _MenuItem13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem13 == null)
                    ;
                _MenuItem13 = value;
                if (_MenuItem13 != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesRoot_RemoveAllFiles
        {
            get => _tvcmiStreamWavesRoot_RemoveAllFiles;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesRoot_RemoveAllFiles != null)
                    _tvcmiStreamWavesRoot_RemoveAllFiles.Click -= tvcmiStreamWavesRoot_RemoveAllFiles_Click;
                _tvcmiStreamWavesRoot_RemoveAllFiles = value;
                if (_tvcmiStreamWavesRoot_RemoveAllFiles == null)
                    return;
                _tvcmiStreamWavesRoot_RemoveAllFiles.Click += tvcmiStreamWavesRoot_RemoveAllFiles_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesRoot_RemoveAllModules
        {
            get => _tvcmiStreamWavesRoot_RemoveAllModules;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesRoot_RemoveAllModules != null)
                    _tvcmiStreamWavesRoot_RemoveAllModules.Click -= tvcmiStreamWavesRoot_RemoveAllModules_Click;
                _tvcmiStreamWavesRoot_RemoveAllModules = value;
                if (_tvcmiStreamWavesRoot_RemoveAllModules == null)
                    return;
                _tvcmiStreamWavesRoot_RemoveAllModules.Click += tvcmiStreamWavesRoot_RemoveAllModules_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesRoot_RemoveEverything
        {
            get => _tvcmiStreamWavesRoot_RemoveEverything;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesRoot_RemoveEverything != null)
                    _tvcmiStreamWavesRoot_RemoveEverything.Click -= tvcmiStreamWavesRoot_RemoveEverything_Click;
                _tvcmiStreamWavesRoot_RemoveEverything = value;
                if (_tvcmiStreamWavesRoot_RemoveEverything == null)
                    return;
                _tvcmiStreamWavesRoot_RemoveEverything.Click += tvcmiStreamWavesRoot_RemoveEverything_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesModuleParent_AddFiles
        {
            get => _tvcmiStreamWavesModuleParent_AddFiles;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesModuleParent_AddFiles != null)
                    _tvcmiStreamWavesModuleParent_AddFiles.Click -= tvcmiStreamWavesModuleParent_AddFiles_Click;
                _tvcmiStreamWavesModuleParent_AddFiles = value;
                if (_tvcmiStreamWavesModuleParent_AddFiles == null)
                    return;
                _tvcmiStreamWavesModuleParent_AddFiles.Click += tvcmiStreamWavesModuleParent_AddFiles_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesModuleParent_ExcludeAllFiles
        {
            get => _tvcmiStreamWavesModuleParent_ExcludeAllFiles;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesModuleParent_ExcludeAllFiles != null)
                    _tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click -=
                        tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click;
                _tvcmiStreamWavesModuleParent_ExcludeAllFiles = value;
                if (_tvcmiStreamWavesModuleParent_ExcludeAllFiles == null)
                    return;
                _tvcmiStreamWavesModuleParent_ExcludeAllFiles.Click +=
                    tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click;
            }
        }

        internal virtual MenuItem MenuItem14
        {
            get => _MenuItem14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem14 == null)
                    ;
                _MenuItem14 = value;
                if (_MenuItem14 != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesModuleParent_RenameSelf
        {
            get => _tvcmiStreamWavesModuleParent_RenameSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesModuleParent_RenameSelf != null)
                    _tvcmiStreamWavesModuleParent_RenameSelf.Click -= tvcmiStreamWavesModuleParent_RenameSelf_Click;
                _tvcmiStreamWavesModuleParent_RenameSelf = value;
                if (_tvcmiStreamWavesModuleParent_RenameSelf == null)
                    return;
                _tvcmiStreamWavesModuleParent_RenameSelf.Click += tvcmiStreamWavesModuleParent_RenameSelf_Click;
            }
        }

        internal virtual MenuItem MenuItem15
        {
            get => _MenuItem15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem15 == null)
                    ;
                _MenuItem15 = value;
                if (_MenuItem15 != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesModulesParent_RemoveSelf
        {
            get => _tvcmiStreamWavesModulesParent_RemoveSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesModulesParent_RemoveSelf != null)
                    _tvcmiStreamWavesModulesParent_RemoveSelf.Click -= tvcmiStreamWavesModulesParent_RemoveSelf_Click;
                _tvcmiStreamWavesModulesParent_RemoveSelf = value;
                if (_tvcmiStreamWavesModulesParent_RemoveSelf == null)
                    return;
                _tvcmiStreamWavesModulesParent_RemoveSelf.Click += tvcmiStreamWavesModulesParent_RemoveSelf_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesModulesChild_ExcludeSelf
        {
            get => _tvcmiStreamWavesModulesChild_ExcludeSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesModulesChild_ExcludeSelf != null)
                    _tvcmiStreamWavesModulesChild_ExcludeSelf.Click -= tvcmiStreamWavesModulesChild_ExcludeSelf_Click;
                _tvcmiStreamWavesModulesChild_ExcludeSelf = value;
                if (_tvcmiStreamWavesModulesChild_ExcludeSelf == null)
                    return;
                _tvcmiStreamWavesModulesChild_ExcludeSelf.Click += tvcmiStreamWavesModulesChild_ExcludeSelf_Click;
            }
        }

        internal virtual MenuItem tvcmiStreamWavesFileChild_ExcludeSelf
        {
            get => _tvcmiStreamWavesFileChild_ExcludeSelf;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiStreamWavesFileChild_ExcludeSelf != null)
                    _tvcmiStreamWavesFileChild_ExcludeSelf.Click -= tvcmiStreamWavesFileChild_ExcludeSelf_Click;
                _tvcmiStreamWavesFileChild_ExcludeSelf = value;
                if (_tvcmiStreamWavesFileChild_ExcludeSelf == null)
                    return;
                _tvcmiStreamWavesFileChild_ExcludeSelf.Click += tvcmiStreamWavesFileChild_ExcludeSelf_Click;
            }
        }

        internal virtual ImageList ilistTree
        {
            get => _ilistTree;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ilistTree == null)
                    ;
                _ilistTree = value;
                if (_ilistTree != null)
                    ;
            }
        }

        internal virtual Label lblStatus
        {
            get => _lblStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblStatus == null)
                    ;
                _lblStatus = value;
                if (_lblStatus != null)
                    ;
            }
        }

        internal virtual MenuItem tvcmiModulesParent_Properties
        {
            get => _tvcmiModulesParent_Properties;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_tvcmiModulesParent_Properties != null)
                    _tvcmiModulesParent_Properties.Click -= tvcmiModulesParent_Properties_Click;
                _tvcmiModulesParent_Properties = value;
                if (_tvcmiModulesParent_Properties == null)
                    return;
                _tvcmiModulesParent_Properties.Click += tvcmiModulesParent_Properties_Click;
            }
        }

        internal virtual MenuItem MenuItem16
        {
            get => _MenuItem16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MenuItem16 == null)
                    ;
                _MenuItem16 = value;
                if (_MenuItem16 != null)
                    ;
            }
        }

        public frmProjectManager()
        {
            Closing += frmProjectManager_Closing;
            Load += frmProjectManager_Load;
            InitialBrowsePath = "c:\\";
            BuildMode = "debug";
            InitializeComponent();
        }

        public frmProjectManager(FrmMain parentForm)
            : this()
        {
            MyParentForm = parentForm;
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
            ResourceManager resourceManager = new ResourceManager(typeof(frmProjectManager));
            TreeView = new TreeView();
            this.ilistTree = new ImageList(components);
            MainMenu1 = new MainMenu();
            MenuItem1 = new MenuItem();
            miNewPoject = new MenuItem();
            miOpenProject = new MenuItem();
            miSaveProject = new MenuItem();
            MenuItem4 = new MenuItem();
            miProjectProperties = new MenuItem();
            MenuItem7 = new MenuItem();
            miExploreDebugFolder = new MenuItem();
            miExploreReleaseFolder = new MenuItem();
            MenuItem10 = new MenuItem();
            miQuit = new MenuItem();
            MenuItem6 = new MenuItem();
            miBuildProject = new MenuItem();
            MenuItem3 = new MenuItem();
            miDebug = new MenuItem();
            miRelease = new MenuItem();
            MenuItem8 = new MenuItem();
            miCleanDebugPrjFilesOnly = new MenuItem();
            miCleanReleasePrjFilesOnly = new MenuItem();
            tvcmOverrideRoot = new ContextMenu();
            tvcmiOverrideRoot_Add = new MenuItem();
            tvcmiOverrideRoot_RemoveAll = new MenuItem();
            tvcmOverrideChild = new ContextMenu();
            tvcmiOverrideChild_Exclude = new MenuItem();
            tvcmModulesRoot = new ContextMenu();
            tvcmiModulesRoot_Add = new MenuItem();
            MenuItem11 = new MenuItem();
            tvcmiModulesRoot_RemoveAllModules = new MenuItem();
            MenuItem5 = new MenuItem();
            tvcmLipsModulesRoot = new ContextMenu();
            tvcmiLipsModulesRoot_Add = new MenuItem();
            MenuItem12 = new MenuItem();
            tvcmiLipsModulesRoot_RemoveAllModules = new MenuItem();
            tvcmModulesParent = new ContextMenu();
            tvcmiModulesParent_Add = new MenuItem();
            tvcmiModulesParent_RemoveAll = new MenuItem();
            tvcmiModulesParent_RenameSelf = new MenuItem();
            tvcmiModulesParent_RemoveSelf = new MenuItem();
            MenuItem16 = new MenuItem();
            tvcmiModulesParent_Properties = new MenuItem();
            MenuItem2 = new MenuItem();
            MenuItem9 = new MenuItem();
            tvcmLipsModulesParent = new ContextMenu();
            tvcmiLipsModulesParent_Add = new MenuItem();
            tvcmiLipsModulesParent_RemoveAll = new MenuItem();
            tvcmiLipsModulesParent_RenameSelf = new MenuItem();
            tvcmiLipsModulesParent_RemoveSelf = new MenuItem();
            tvcmModulesChild = new ContextMenu();
            tvcmiModulesChild_Exclude = new MenuItem();
            tvcmLipsModulesChild = new ContextMenu();
            tvcmiLipsModulesChild_Exclude = new MenuItem();
            tvcmProjectRoot = new ContextMenu();
            tvcmiProperties = new MenuItem();
            tvcmStreamWavesRoot = new ContextMenu();
            tvcmiStreamWavesRoot_AddFile = new MenuItem();
            tvcmiStreamWavesRoot_AddModule = new MenuItem();
            MenuItem13 = new MenuItem();
            tvcmiStreamWavesRoot_RemoveAllFiles = new MenuItem();
            tvcmiStreamWavesRoot_RemoveAllModules = new MenuItem();
            tvcmiStreamWavesRoot_RemoveEverything = new MenuItem();
            tvcmStreamWavesModulesParent = new ContextMenu();
            tvcmiStreamWavesModuleParent_AddFiles = new MenuItem();
            tvcmiStreamWavesModuleParent_ExcludeAllFiles = new MenuItem();
            MenuItem14 = new MenuItem();
            tvcmiStreamWavesModuleParent_RenameSelf = new MenuItem();
            MenuItem15 = new MenuItem();
            tvcmiStreamWavesModulesParent_RemoveSelf = new MenuItem();
            tvcmStreamWavesModulesChild = new ContextMenu();
            tvcmiStreamWavesModulesChild_ExcludeSelf = new MenuItem();
            tvcmStreamWavesFileChild = new ContextMenu();
            tvcmiStreamWavesFileChild_ExcludeSelf = new MenuItem();
            lblStatus = new Label();
            SuspendLayout();
            TreeView.AllowDrop = true;
            TreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TreeView.HideSelection = false;
            TreeView.ImageList = this.ilistTree;
            TreeView.Indent = 19;
            TreeView treeView1 = TreeView;
            Point point1 = new Point(12, 11);
            Point point2 = point1;
            treeView1.Location = point2;
            TreeView.Name = "TreeView";
            TreeView.RightToLeft = RightToLeft.No;
            TreeView treeView2 = TreeView;
            Size size1 = new Size(264, 341);
            Size size2 = size1;
            treeView2.Size = size2;
            TreeView.TabIndex = 0;
            ImageList ilistTree = this.ilistTree;
            size1 = new Size(16, 16);
            Size size3 = size1;
            ilistTree.ImageSize = size3;
            this.ilistTree.ImageStream = (ImageListStreamer) resourceManager.GetObject("ilistTree.ImageStream");
            this.ilistTree.TransparentColor = Color.Transparent;
            MainMenu1.MenuItems.AddRange(new MenuItem[2]
            {
                MenuItem1,
                MenuItem6
            });
            MenuItem1.Index = 0;
            MenuItem1.MenuItems.AddRange(new MenuItem[10]
            {
                miNewPoject,
                miOpenProject,
                miSaveProject,
                MenuItem4,
                miProjectProperties,
                MenuItem7,
                miExploreDebugFolder,
                miExploreReleaseFolder,
                MenuItem10,
                miQuit
            });
            MenuItem1.Text = "&File";
            miNewPoject.Index = 0;
            miNewPoject.Shortcut = Shortcut.CtrlN;
            miNewPoject.Text = "&New Project...";
            miOpenProject.Index = 1;
            miOpenProject.Shortcut = Shortcut.CtrlO;
            miOpenProject.Text = "&Open project...";
            miSaveProject.Enabled = false;
            miSaveProject.Index = 2;
            miSaveProject.Shortcut = Shortcut.CtrlS;
            miSaveProject.Text = "&Save Project";
            MenuItem4.Index = 3;
            MenuItem4.Text = "-";
            miProjectProperties.Enabled = false;
            miProjectProperties.Index = 4;
            miProjectProperties.Text = "&Project Properties...";
            MenuItem7.Index = 5;
            MenuItem7.Text = "-";
            miExploreDebugFolder.Enabled = false;
            miExploreDebugFolder.Index = 6;
            miExploreDebugFolder.Text = "Open &Debug Folder";
            miExploreReleaseFolder.Enabled = false;
            miExploreReleaseFolder.Index = 7;
            miExploreReleaseFolder.Text = "Open &Release Folder";
            MenuItem10.Index = 8;
            MenuItem10.Text = "-";
            miQuit.Index = 9;
            miQuit.Shortcut = Shortcut.CtrlQ;
            miQuit.Text = "&Quit";
            MenuItem6.Index = 1;
            MenuItem6.MenuItems.AddRange(new MenuItem[7]
            {
                miBuildProject,
                MenuItem3,
                miDebug,
                miRelease,
                MenuItem8,
                miCleanDebugPrjFilesOnly,
                miCleanReleasePrjFilesOnly
            });
            MenuItem6.Text = "&Build";
            miBuildProject.Enabled = false;
            miBuildProject.Index = 0;
            miBuildProject.Shortcut = Shortcut.F5;
            miBuildProject.Text = "B&uild Project";
            MenuItem3.Index = 1;
            MenuItem3.Text = "-";
            miDebug.Checked = true;
            miDebug.Index = 2;
            miDebug.Text = "&Debug";
            miRelease.Index = 3;
            miRelease.Text = "&Release";
            MenuItem8.Index = 4;
            MenuItem8.Text = "-";
            miCleanDebugPrjFilesOnly.Enabled = false;
            miCleanDebugPrjFilesOnly.Index = 5;
            miCleanDebugPrjFilesOnly.Text = "Clean Debug Directory - Project Files Only";
            miCleanReleasePrjFilesOnly.Enabled = false;
            miCleanReleasePrjFilesOnly.Index = 6;
            miCleanReleasePrjFilesOnly.Text = "Clean Release Directory - Project Files Only";
            tvcmOverrideRoot.MenuItems.AddRange(new MenuItem[2]
            {
                tvcmiOverrideRoot_Add,
                tvcmiOverrideRoot_RemoveAll
            });
            tvcmiOverrideRoot_Add.Index = 0;
            tvcmiOverrideRoot_Add.Text = "Add Files...";
            tvcmiOverrideRoot_RemoveAll.Enabled = false;
            tvcmiOverrideRoot_RemoveAll.Index = 1;
            tvcmiOverrideRoot_RemoveAll.Text = "Exclude All Files...";
            tvcmOverrideChild.MenuItems.AddRange(new MenuItem[1]
            {
                tvcmiOverrideChild_Exclude
            });
            tvcmiOverrideChild_Exclude.Index = 0;
            tvcmiOverrideChild_Exclude.Text = "Exclude file from Project";
            tvcmModulesRoot.MenuItems.AddRange(new MenuItem[3]
            {
                tvcmiModulesRoot_Add,
                MenuItem11,
                tvcmiModulesRoot_RemoveAllModules
            });
            tvcmiModulesRoot_Add.Index = 0;
            tvcmiModulesRoot_Add.Text = "Add New Package...";
            MenuItem11.Index = 1;
            MenuItem11.Text = "-";
            tvcmiModulesRoot_RemoveAllModules.Enabled = false;
            tvcmiModulesRoot_RemoveAllModules.Index = 2;
            tvcmiModulesRoot_RemoveAllModules.Text = "Remove All Packages...";
            MenuItem5.Index = -1;
            MenuItem5.Text = "-";
            tvcmLipsModulesRoot.MenuItems.AddRange(new MenuItem[3]
            {
                tvcmiLipsModulesRoot_Add,
                MenuItem12,
                tvcmiLipsModulesRoot_RemoveAllModules
            });
            tvcmiLipsModulesRoot_Add.Index = 0;
            tvcmiLipsModulesRoot_Add.Text = "Add New Module...";
            MenuItem12.Index = 1;
            MenuItem12.Text = "-";
            tvcmiLipsModulesRoot_RemoveAllModules.Enabled = false;
            tvcmiLipsModulesRoot_RemoveAllModules.Index = 2;
            tvcmiLipsModulesRoot_RemoveAllModules.Text = "Remove All Modules...";
            tvcmModulesParent.MenuItems.AddRange(new MenuItem[6]
            {
                tvcmiModulesParent_Add,
                tvcmiModulesParent_RemoveAll,
                tvcmiModulesParent_RenameSelf,
                tvcmiModulesParent_RemoveSelf,
                MenuItem16,
                tvcmiModulesParent_Properties
            });
            tvcmiModulesParent_Add.Index = 0;
            tvcmiModulesParent_Add.Text = "Add Files...";
            tvcmiModulesParent_RemoveAll.Enabled = false;
            tvcmiModulesParent_RemoveAll.Index = 1;
            tvcmiModulesParent_RemoveAll.Text = "Exclude All Files...";
            tvcmiModulesParent_RenameSelf.Index = 2;
            tvcmiModulesParent_RenameSelf.Text = "Rename";
            tvcmiModulesParent_RemoveSelf.Index = 3;
            tvcmiModulesParent_RemoveSelf.Text = "Remove Package";
            MenuItem16.Index = 4;
            MenuItem16.Text = "-";
            tvcmiModulesParent_Properties.Index = 5;
            tvcmiModulesParent_Properties.Text = "Properties";
            MenuItem2.Index = 2;
            MenuItem2.Text = "-";
            MenuItem9.Index = 4;
            MenuItem9.Text = "-";
            tvcmLipsModulesParent.MenuItems.AddRange(new MenuItem[6]
            {
                tvcmiLipsModulesParent_Add,
                tvcmiLipsModulesParent_RemoveAll,
                MenuItem2,
                tvcmiLipsModulesParent_RenameSelf,
                MenuItem9,
                tvcmiLipsModulesParent_RemoveSelf
            });
            tvcmiLipsModulesParent_Add.Index = 0;
            tvcmiLipsModulesParent_Add.Text = "Add Files...";
            tvcmiLipsModulesParent_RemoveAll.Enabled = false;
            tvcmiLipsModulesParent_RemoveAll.Index = 1;
            tvcmiLipsModulesParent_RemoveAll.Text = "Exclude All Files...";
            tvcmiLipsModulesParent_RenameSelf.Index = 3;
            tvcmiLipsModulesParent_RenameSelf.Text = "Rename";
            tvcmiLipsModulesParent_RemoveSelf.Index = 5;
            tvcmiLipsModulesParent_RemoveSelf.Text = "Remove Module";
            tvcmModulesChild.MenuItems.AddRange(new MenuItem[1]
            {
                tvcmiModulesChild_Exclude
            });
            tvcmiModulesChild_Exclude.Index = 0;
            tvcmiModulesChild_Exclude.Text = "Exclude file from Project";
            tvcmLipsModulesChild.MenuItems.AddRange(new MenuItem[1]
            {
                tvcmiLipsModulesChild_Exclude
            });
            tvcmiLipsModulesChild_Exclude.Index = 0;
            tvcmiLipsModulesChild_Exclude.Text = "Exclude file from Project";
            tvcmProjectRoot.MenuItems.AddRange(new MenuItem[1]
            {
                tvcmiProperties
            });
            tvcmiProperties.Index = 0;
            tvcmiProperties.Text = "Properties";
            tvcmStreamWavesRoot.MenuItems.AddRange(new MenuItem[6]
            {
                tvcmiStreamWavesRoot_AddFile,
                tvcmiStreamWavesRoot_AddModule,
                MenuItem13,
                tvcmiStreamWavesRoot_RemoveAllFiles,
                tvcmiStreamWavesRoot_RemoveAllModules,
                tvcmiStreamWavesRoot_RemoveEverything
            });
            tvcmiStreamWavesRoot_AddFile.Index = 0;
            tvcmiStreamWavesRoot_AddFile.Text = "Add Files...";
            tvcmiStreamWavesRoot_AddModule.Index = 1;
            tvcmiStreamWavesRoot_AddModule.Text = "Add Module...";
            MenuItem13.Index = 2;
            MenuItem13.Text = "-";
            tvcmiStreamWavesRoot_RemoveAllFiles.Index = 3;
            tvcmiStreamWavesRoot_RemoveAllFiles.Text = "Remove all root-level files...";
            tvcmiStreamWavesRoot_RemoveAllModules.Index = 4;
            tvcmiStreamWavesRoot_RemoveAllModules.Text = "Remove All Modules...";
            tvcmiStreamWavesRoot_RemoveEverything.Index = 5;
            tvcmiStreamWavesRoot_RemoveEverything.Text = "Remove Everything...";
            tvcmStreamWavesModulesParent.MenuItems.AddRange(new MenuItem[6]
            {
                tvcmiStreamWavesModuleParent_AddFiles,
                tvcmiStreamWavesModuleParent_ExcludeAllFiles,
                MenuItem14,
                tvcmiStreamWavesModuleParent_RenameSelf,
                MenuItem15,
                tvcmiStreamWavesModulesParent_RemoveSelf
            });
            tvcmiStreamWavesModuleParent_AddFiles.Index = 0;
            tvcmiStreamWavesModuleParent_AddFiles.Text = "Add Files...";
            tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled = false;
            tvcmiStreamWavesModuleParent_ExcludeAllFiles.Index = 1;
            tvcmiStreamWavesModuleParent_ExcludeAllFiles.Text = "Exclude All Files...";
            MenuItem14.Index = 2;
            MenuItem14.Text = "-";
            tvcmiStreamWavesModuleParent_RenameSelf.Index = 3;
            tvcmiStreamWavesModuleParent_RenameSelf.Text = "Rename";
            MenuItem15.Index = 4;
            MenuItem15.Text = "-";
            tvcmiStreamWavesModulesParent_RemoveSelf.Index = 5;
            tvcmiStreamWavesModulesParent_RemoveSelf.Text = "Remove Module";
            tvcmStreamWavesModulesChild.MenuItems.AddRange(new MenuItem[1]
            {
                tvcmiStreamWavesModulesChild_ExcludeSelf
            });
            tvcmiStreamWavesModulesChild_ExcludeSelf.Index = 0;
            tvcmiStreamWavesModulesChild_ExcludeSelf.Text = "Exclude file from Project";
            tvcmStreamWavesFileChild.MenuItems.AddRange(new MenuItem[1]
            {
                tvcmiStreamWavesFileChild_ExcludeSelf
            });
            tvcmiStreamWavesFileChild_ExcludeSelf.Index = 0;
            tvcmiStreamWavesFileChild_ExcludeSelf.Text = "Exclude file from Project";
            lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblStatus.BackColor = SystemColors.ActiveCaptionText;
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.FlatStyle = FlatStyle.System;
            Label lblStatus1 = lblStatus;
            point1 = new Point(12, 360);
            Point point3 = point1;
            lblStatus1.Location = point3;
            lblStatus.Name = "lblStatus";
            Label lblStatus2 = lblStatus;
            size1 = new Size(264, 32);
            Size size4 = size1;
            lblStatus2.Size = size4;
            lblStatus.TabIndex = 1;
            size1 = new Size(5, 13);
            AutoScaleBaseSize = size1;
            size1 = new Size(288, 401);
            ClientSize = size1;
            Controls.Add(lblStatus);
            Controls.Add(TreeView);
            Menu = MainMenu1;
            size1 = new Size(184, 232);
            MinimumSize = size1;
            Name = "frmProjectManager";
            StartPosition = FormStartPosition.Manual;
            Text = "Project Manager";
            ResumeLayout(false);
        }

        private void frmProjectManager_Closing(object sender, CancelEventArgs e)
        {
            AskIfSaveProject();
            //SaveSettings(GetType().Name);
        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            LastClickedTVNode = TreeView.GetNodeAt(new Point(e.X, e.Y));
            TreeView.SelectedNode = LastClickedTVNode;
            if (e.Button != MouseButtons.Right)
                return;
            object tag = LastClickedTVNode.Tag;
            if (ObjectType.ObjTst(tag, "projectroot", false) == 0)
                tvcmProjectRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
            else if (ObjectType.ObjTst(tag, "overrideroot", false) == 0)
            {
                tvcmiOverrideRoot_RemoveAll.Enabled = Project.OverrideFiles.Count > 0;
                tvcmOverrideRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "overridechild", false) == 0)
                tvcmOverrideChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
            else if (ObjectType.ObjTst(tag, "moduleroot", false) == 0)
            {
                tvcmiModulesRoot_RemoveAllModules.Enabled = Project.Modules.Count > 0;
                tvcmModulesRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "moduleparent", false) == 0)
            {
                tvcmiModulesParent_RemoveAll.Enabled = Project.GetModuleFiles(LastClickedTVNode.Text).Count > 0;
                tvcmModulesParent.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "modulechild", false) == 0)
                tvcmModulesChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
            else if (ObjectType.ObjTst(tag, "lipsmoduleroot", false) == 0)
            {
                tvcmiLipsModulesRoot_RemoveAllModules.Enabled = Project.LipsModules.Count > 0;
                tvcmLipsModulesRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "lipsmoduleparent", false) == 0)
            {
                tvcmiLipsModulesParent_RemoveAll.Enabled = Project.GetLipsModuleFiles(LastClickedTVNode.Text).Count > 0;
                tvcmLipsModulesParent.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "lipsmodulechild", false) == 0)
                tvcmLipsModulesChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
            else if (ObjectType.ObjTst(tag, "streamwavesroot", false) == 0)
            {
                tvcmiStreamWavesRoot_RemoveAllFiles.Enabled = Project.StreamWavesFiles.Count > 0;
                tvcmiStreamWavesRoot_RemoveAllModules.Enabled = Project.StreamWavesModules.Count > 0;
                tvcmiStreamWavesRoot_RemoveEverything.Enabled =
                    Project.StreamWavesFiles.Count > 0 || Project.StreamWavesModules.Count > 0;
                tvcmStreamWavesRoot.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "streamwavesmoduleparent", false) == 0)
            {
                tvcmiStreamWavesModuleParent_ExcludeAllFiles.Enabled =
                    Project.GetStreamWavesModuleFiles(LastClickedTVNode.Text).Count > 0;
                tvcmStreamWavesModulesParent.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else if (ObjectType.ObjTst(tag, "streamwavesmodulechild", false) == 0)
            {
                tvcmStreamWavesModulesChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
            else
            {
                if (ObjectType.ObjTst(tag, "streamwavesfilechild", false) != 0)
                    return;
                tvcmStreamWavesFileChild.Show((Control) sender, TreeView.PointToClient(MousePosition));
            }
        }

        private void TreeView_DoubleClick(object sender, EventArgs e)
        {
            ProjectFileItemTreeNode selectedNode = (ProjectFileItemTreeNode) TreeView.SelectedNode;
            if (ObjectType.ObjTst(selectedNode.Tag, "overridechild", false) != 0 && ObjectType.ObjTst(selectedNode.Tag, "modulechild", false) != 0 && (ObjectType.ObjTst(selectedNode.Tag, "streamwavesfilechild", false) != 0 && ObjectType.ObjTst(selectedNode.Tag, "streamwavesmodulechild", false) != 0)) return;
            string lower = Path.GetExtension(selectedNode.FilePath).ToLower();
            if (StringType.StrCmp(lower, ".nss", false) == 0 || StringType.StrCmp(lower, ".txt", false) == 0)
            {
              
                if (ConfigOptions.Toggles.ProjMgrUseExternTxtEditor)
                {
                    new Process {StartInfo = {FileName = ConfigOptions.Paths.ProjMgrTxtEditorPath + " ", Arguments = selectedNode.FilePath}}.Start();
                }
                else
                {
                    FileStream fileStream = new FileStream(selectedNode.FilePath, FileMode.Open);
                    frmTextEditor frmTextEditor = new frmTextEditor(selectedNode.Filename);
                    ASCIIEncoding asciiEncoding = new ASCIIEncoding();
                    byte[] numArray = new byte[(int) (fileStream.Length - 1L) + 1];
                    fileStream.Read(numArray, 0, (int) fileStream.Length);
                    frmTextEditor.tbGeneric.Text = asciiEncoding.GetString(numArray);
                    frmTextEditor.tbGeneric.SelectionLength = 0;
                    fileStream.Close();
                    frmTextEditor.Show();
                }
            }
            else if (StringType.StrCmp(lower, ".utc", false) == 0 || StringType.StrCmp(lower, ".utd", false) == 0 || (StringType.StrCmp(lower, ".uti", false) == 0 || StringType.StrCmp(lower, ".utm", false) == 0) || (StringType.StrCmp(lower, ".utp", false) == 0 || StringType.StrCmp(lower, ".utt", false) == 0))
            {
               // MyParentForm.OpenGffFileInEditor(selectedNode.FilePath);
            }
            else
            {
                if (StringType.StrCmp(lower, ".dlg", false) != 0) return;
            
                if (ConfigOptions.Toggles.ProjMgrUseExternDlgEditor) new Process {StartInfo = {FileName = ConfigOptions.Paths.ProjMgrDlgEditorPath + " ", Arguments = selectedNode.FilePath}}.Start();
                else new FrmDialogEditor(new FileStream(selectedNode.FilePath, FileMode.Open), KotorVersionIndex).Show();
            }
        }

        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            ProjectFileItemTreeNode nodeAt = (ProjectFileItemTreeNode) TreeView.GetNodeAt(TreeView.PointToClient(new Point(e.X, e.Y)));
            string fullPath = nodeAt.FullPath;
            string[] data = (string[]) e.Data.GetData(DataFormats.FileDrop);
            object tag = nodeAt.Tag;
            if (ObjectType.ObjTst(tag, "moduleparent", false) == 0)
            {
                Hashtable filesHashTable = ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
                int num1 = 0;
                int num2 = data.Length - 1;
                int index = num1;
                while (index <= num2)
                {
                    if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
                    {
                        Interaction.MsgBox("The file '" + data[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
                    }
                    else if (!filesHashTable.ContainsKey(data[index]))
                    {
                        Project.AddModuleFile(nodeAt.Text, data[index]);
                        ProjectMgr.SaveProject();
                    }
                 ++index;
                    
                }
            }
            else if (ObjectType.ObjTst(tag, "lipsmoduleparent", false) == 0)
            {
                Hashtable filesHashTable = ((ModuleFileEntry) Project.LipsModules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
                int num1 = 0;
                int num2 = data.Length - 1;
                int index = num1;
                while (index <= num2)
                {
                    if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
                    {
                        Interaction.MsgBox("The file '" + data[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
                    }
                    else if (!filesHashTable.ContainsKey(data[index]))
                    {
                        Project.AddLipsModuleFile(nodeAt.Text, data[index]);
                        ProjectMgr.SaveProject();
                    }

                    checked
                    {
                        ++index;
                    }
                }
            }
            else if (ObjectType.ObjTst(tag, "streamwavesmoduleparent", false) == 0)
            {
                Hashtable filesHashTable = ((ModuleFileEntry) Project.StreamWavesModules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
                int num1 = 0;
                int num2 = data.Length - 1;
                int index = num1;
                while (index <= num2)
                {
                    if (Path.GetFileNameWithoutExtension(data[index]).Length > 16)
                    {
                        Interaction.MsgBox("The file '" + data[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
                    }
                    else if (!filesHashTable.ContainsKey(data[index]))
                    {
                        Project.AddStreamWavesModuleFile(nodeAt.Text, data[index]);
                        ProjectMgr.SaveProject();
                    }

                    ++index;
                    
                }
            }
            else if (ObjectType.ObjTst(tag, "overrideroot", false) == 0)
            {
                Hashtable overrideFilesHashTable = Project.OverrideFilesHashTable;
                int num1 = 0;
                int num2 = data.Length - 1;
                int index = num1;
                while (index <= num2)
                {
                    if (!overrideFilesHashTable.ContainsKey(data[index]))
                        Project.OverrideFiles.Add(data[index]);
                    
                        ++index;
                    
                }

                ProjectMgr.SaveProject();
            }
            else if (ObjectType.ObjTst(tag, "streamwavesroot", false) == 0)
            {
                Hashtable wavesFilesHashTable = Project.StreamWavesFilesHashTable;
                int num1 = 0;
                int num2 = checked(data.Length - 1);
                int index = num1;
                while (index <= num2)
                {
                    if (!wavesFilesHashTable.ContainsKey(data[index])) Project.StreamWavesFiles.Add(data[index]);
                    ++index;
                }

                ProjectMgr.SaveProject();
            }

            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void TreeView_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            ProjectFileItemTreeNode nodeAt = (ProjectFileItemTreeNode) TreeView.GetNodeAt(TreeView.PointToClient(new Point(e.X, e.Y)));
            if (nodeAt == null) return;
            if (ObjectType.ObjTst(nodeAt.Tag, "overrideroot", false) == 0 || ObjectType.ObjTst(nodeAt.Tag, "moduleparent", false) == 0 || (ObjectType.ObjTst(nodeAt.Tag, "lipsmoduleparent", false) == 0 || ObjectType.ObjTst(nodeAt.Tag, "streamwavesroot", false) == 0) || ObjectType.ObjTst(nodeAt.Tag, "streamwavesmoduleparent", false) == 0)
            {
                e.Effect = DragDropEffects.All;
                Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Match: ", nodeAt.Tag), " "), DateAndTime.Now));
            }
            else
            {
                e.Effect = DragDropEffects.None;
                Console.WriteLine(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("No match: ", nodeAt.Tag), " "), DateAndTime.Now));
            }
        }

        private void tvcmiProperties_Click(object sender, EventArgs e)
        {
            EditProjectProperties();
        }

        private void tvcmiOverrideRoot_Add_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", InitialBrowsePath, "*.*",
                "Select the files to add to the Override folder", "all", true));
            if (objectValue is string)
                return;
            string[] strArray = (string[]) objectValue;
            Hashtable overrideFilesHashTable = Project.OverrideFilesHashTable;
            int num1 = 0;
            int num2 = checked(strArray.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                if (!overrideFilesHashTable.ContainsKey(strArray[index]))
                    Project.OverrideFiles.Add(strArray[index]);
                checked
                {
                    ++index;
                }
            }

            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiOverrideChild_Exclude_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            Project.RemoveOverrideFile(((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiOverrideRoot_RemoveAll_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox(
                    "Are you sure you want to exclude all of the files from Override?\n(No files will be deleted from disk)",
                    MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
                return;
            Project.RemoveAllOverrideFiles();
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiModulesRoot_Add_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter name for new module";
            if (frmPromptForString.ShowDialog() != DialogResult.OK)
                return;
            Project.AddModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()));
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmModulesRoot_RemoveAllModules_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox(
                    "Are you sure you want to remove all of the Packages from the Project?\n(No files will be deleted from disk)",
                    MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok)
                return;
            ProjectMgr.SaveProject();
            Project.RemoveAllModules();
            RefreshTreeView();
        }

        private void tvcmiModulesParent_RemoveSelf_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox(
                    "Are you sure you want to remove the module '" + LastClickedTVNode.Text + "'?" + "\n" +
                    "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2,
                    "Warning") != MsgBoxResult.Ok)
                return;
            Project.RemoveModule(LastClickedTVNode.Text.Trim());
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiModulesParent_Add_Click(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", true));
            string fullPath = LastClickedTVNode.FullPath;
            if (objectValue is string) return;
            string[] strArray = (string[]) objectValue;
            Hashtable filesHashTable = ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
            int num1 = 0;
            int num2 = checked(strArray.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                if (Path.GetFileNameWithoutExtension(strArray[index]).Length > 16)
                {
                    Interaction.MsgBox("The file '" + strArray[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
                }
                else if (!filesHashTable.ContainsKey(strArray[index])) Project.AddModuleFile(LastClickedTVNode.Text, strArray[index]);
                 ++index;
                
            }

            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiModulesParent_RenameSelf_Click(object sender, EventArgs e)
        {
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter new name for package";
            frmPromptForString.tbValue.Text = LastClickedTVNode.Text;
            if (frmPromptForString.ShowDialog() != DialogResult.OK)
                return;
            ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).ModuleName =
                frmPromptForString.tbValue.Text.Trim();
            LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim();
        }

        private void tvcmiModulesParent_RemoveAll_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox(
                    "Are you sure you want to exclude all of the files from '" + LastClickedTVNode.Text + "'?" + "\n" +
                    "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3,
                    "Warning") != MsgBoxResult.Ok)
                return;
            Project.RemoveAllModuleFiles(LastClickedTVNode.Text);
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiModulesParent_Properties_Click(object sender, EventArgs e)
        {
            frmPackageTypeSelector packageTypeSelector = new frmPackageTypeSelector(((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).PackageType);
            if (packageTypeSelector.ShowDialog(this) != DialogResult.OK) return;
            ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).PackageType = packageTypeSelector.PackageType;
        }

        private void tvcmiModulesChild_Exclude_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            Project.RemoveModuleFile(LastClickedTVNode.Parent.Text, ((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiLipsModulesRoot_Add_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter name for new module";
            if (frmPromptForString.ShowDialog() != DialogResult.OK)
                return;
            Project.AddLipsModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()));
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmLipsModulesRoot_RemoveAllModules_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to remove all of the Modules from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveAllLipsModules();
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiLipsModulesParent_RemoveSelf_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to remove the module '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveLipsModule(LastClickedTVNode.Text.Trim());
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiLipsModulesParent_Add_Click(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", true));
            string fullPath = LastClickedTVNode.FullPath;
            if (objectValue is string) return;
            string[] strArray = (string[]) objectValue;
            Hashtable filesHashTable = ((ModuleFileEntry) Project.Modules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
            int num1 = 0;
            int num2 = strArray.Length - 1;
            int index = num1;
            while (index <= num2)
            {
                if (Path.GetFileNameWithoutExtension(strArray[index]).Length > 16)
                {
                    Interaction.MsgBox("The file '" + strArray[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
                }
                else if (!filesHashTable.ContainsKey(strArray[index])) Project.AddLipsModuleFile(LastClickedTVNode.Text, strArray[index]);

                ++index;
            }

            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiLipsModulesParent_RenameSelf_Click(object sender, EventArgs e)
        {
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter new name for module";
            frmPromptForString.tbValue.Text = LastClickedTVNode.Text;
            if (frmPromptForString.ShowDialog() != DialogResult.OK) return;
            ((ModuleFileEntry) Project.LipsModules[Project.GetLipsModuleIndex(LastClickedTVNode.Text)]).ModuleName = frmPromptForString.tbValue.Text.Trim();
            LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim();
        }

        private void tvcmiLipsModulesParent_RemoveAll_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exclude all of the files from '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveAllLipsModuleFiles(LastClickedTVNode.Text);
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiLipsModulesChild_Exclude_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            Project.RemoveLipsModuleFile(LastClickedTVNode.Parent.Text,
                ((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiStreamWavesRoot_AddFile_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Override folder", "all", true));
            if (objectValue is string) return;
            string[] strArray = (string[]) objectValue;
            Hashtable wavesFilesHashTable = Project.StreamWavesFilesHashTable;
            int num1 = 0;
            int num2 = checked(strArray.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                if (!wavesFilesHashTable.ContainsKey(strArray[index])) Project.StreamWavesFiles.Add(strArray[index]);
                ++index;
            }
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiStreamWavesRoot_AddModule_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter name for new module";
            if (frmPromptForString.ShowDialog() != DialogResult.OK) return;
            Project.AddStreamWavesModule(Path.GetFileNameWithoutExtension(frmPromptForString.tbValue.Text.Trim()));
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiStreamWavesRoot_RemoveAllFiles_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to exclude all of the files?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveAllStreamWavesFiles();
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiStreamWavesRoot_RemoveAllModules_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to remove all of the StreamWaves Modules from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveAllStreamWavesModules();
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiStreamWavesRoot_RemoveEverything_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to remove everything (StreamWaves Modules and files) from the Project?\n(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveAllStreamWavesModules();
            Project.RemoveAllStreamWavesFiles();
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiStreamWavesModuleParent_AddFiles_Click(object sender, EventArgs e)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(FileUtils.GetFilePath("load", InitialBrowsePath, "*.*", "Select the files to add to the Module", "all", true));
            string fullPath = LastClickedTVNode.FullPath;
            if (objectValue is string) return;
            string[] strArray = (string[]) objectValue;
            Hashtable filesHashTable = ((ModuleFileEntry) Project.StreamWavesModules[Project.GetModuleIndex(LastClickedTVNode.Text)]).FilesHashTable;
            int num1 = 0;
            int num2 = checked(strArray.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                if (Path.GetFileNameWithoutExtension(strArray[index]).Length > 16)
                {
                    Interaction.MsgBox("The file '" + strArray[index] + "' has a filename longer that 16 characters, which is not permitted in .Mod files. Shorten the name to 16 characters or fewer (not including the extension) and try adding the file again.", MsgBoxStyle.Exclamation, "Filename too long");
                }
                else if (!filesHashTable.ContainsKey(strArray[index])) Project.AddStreamWavesModuleFile(LastClickedTVNode.Text, strArray[index]);
                ++index;
                
            }

            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiStreamWavesModuleParent_ExcludeAllFiles_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox(
                    "Are you sure you want to exclude all of the files from '" + LastClickedTVNode.Text + "'?" + "\n" +
                    "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton3,
                    "Warning") != MsgBoxResult.Ok)
                return;
            Project.RemoveAllStreamWavesModuleFiles(LastClickedTVNode.Text);
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiStreamWavesModuleParent_RenameSelf_Click(object sender, EventArgs e)
        {
            frmPromptForString frmPromptForString = new frmPromptForString();
            frmPromptForString.lblMsg.Text = "Enter new name for module";
            frmPromptForString.tbValue.Text = LastClickedTVNode.Text;
            if (frmPromptForString.ShowDialog() != DialogResult.OK) return;
            ((ModuleFileEntry) Project.StreamWavesModules[Project.GetStreamWavesModuleIndex(LastClickedTVNode.Text)]).ModuleName = frmPromptForString.tbValue.Text.Trim();
            LastClickedTVNode.Text = frmPromptForString.tbValue.Text.Trim();
        }

        private void tvcmiStreamWavesModulesParent_RemoveSelf_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("Are you sure you want to remove the module '" + LastClickedTVNode.Text + "'?" + "\n" + "(No files will be deleted from disk)", MsgBoxStyle.OkCancel | MsgBoxStyle.DefaultButton2, "Warning") != MsgBoxResult.Ok) return;
            Project.RemoveStreamWavesModule(LastClickedTVNode.Text.Trim());
            ProjectMgr.SaveProject();
            RefreshTreeView();
        }

        private void tvcmiStreamWavesModulesChild_ExcludeSelf_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            Project.RemoveStreamWavesModuleFile(LastClickedTVNode.Parent.Text,((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void tvcmiStreamWavesFileChild_ExcludeSelf_Click(object sender, EventArgs e)
        {
            string fullPath = LastClickedTVNode.FullPath;
            Project.RemoveStreamWavesFile(((ProjectFileItemTreeNode) LastClickedTVNode).FilePath);
            ProjectMgr.SaveProject();
            RefreshTreeView();
            OpenTreeViewToPath(fullPath, TreeView.Nodes[0], 1);
        }

        private void miNewPoject_Click(object sender, EventArgs e)
        {
            AskIfSaveProject();
            frmProjectManagerProperties managerProperties = new frmProjectManagerProperties();
            if (managerProperties.ShowDialog(this) != DialogResult.OK)
                return;
            InitialBrowsePath = "C:\\";
            ProjectFilePath = managerProperties.tbProjectPath.Text.Trim();
            ProjectMgr = new ClsProjectManager(ProjectFilePath, managerProperties.tbProjectName.Text.Trim());
            Project = ProjectMgr.Project;
            Project.DebugFilePath = managerProperties.tbReleasePath.Text;
            Project.ReleaseFilePath = managerProperties.tbReleasePath.Text.Trim();
            if (managerProperties.rbKotor1.Checked)
                Project.KotorVersionIndex = 0;
            if (managerProperties.rbKotor2.Checked)
                Project.KotorVersionIndex = 1;
            if (!Project.DebugFilePath.EndsWith("\\"))
            {
                ClsProject project = Project;
                project.DebugFilePath = project.DebugFilePath + "\\";
            }

            if (!Project.ReleaseFilePath.EndsWith("\\"))
            {
                ClsProject project = Project;
                project.ReleaseFilePath = project.ReleaseFilePath + "\\";
            }

            EnableMenus();
            BuildTreeRoots();
            RefreshTreeView();
            Text = "Project Manager - " + Path.GetFileName(ProjectMgr.ProjectFilePath);
        }

        private void miOpenProject_Click(object sender, EventArgs e)
        {
            AskIfSaveProject();
            string str = BrowseForProjectFile();
            if (!File.Exists(str)) return;
            ClsProjectManager clsProjectManager = new ClsProjectManager(str);
            if (clsProjectManager.Project == null) return;
            ProjectMgr = clsProjectManager;
            Project = ProjectMgr.Project;
            BuildTreeRoots();
            RefreshTreeView();
            Text = "Project Manager - " + Path.GetFileName(ProjectMgr.ProjectFilePath);
            miProjectProperties.Enabled = true;
            if (!Project.DebugFilePath.EndsWith("\\"))
            {
                ClsProject project = Project;
                project.DebugFilePath = project.DebugFilePath + "\\";
            }

            if (!Project.ReleaseFilePath.EndsWith("\\"))
            {
                ClsProject project = Project;
                project.ReleaseFilePath = project.ReleaseFilePath + "\\";
            }

            EnableMenus();
        }

        private void miSaveProject_Click(object sender, EventArgs e)
        {
            if (Project == null)
                return;
            ProjectMgr.SaveProject();
        }

        private void miProjectProperties_Click(object sender, EventArgs e)
        {
            EditProjectProperties();
        }

        private void miExploreDebugFolder_Click(object sender, EventArgs e)
        {
            new Process {StartInfo = {FileName = "explorer.exe ", Arguments = Project.DebugFilePath}}.Start();
        }

        private void miExploreReleaseFolder_Click(object sender, EventArgs e)
        {
            new Process {StartInfo = {FileName = "explorer.exe ", Arguments = Project.ReleaseFilePath}}.Start();
        }

        private void miDebug_Click(object sender, EventArgs e)
        {
            miDebug.Checked = true;
            miRelease.Checked = false;
            BuildMode = "debug";
        }

        private void miRelease_Click(object sender, EventArgs e)
        {
            miDebug.Checked = false;
            miRelease.Checked = true;
            BuildMode = "build";
        }

        private void miBuildProject_Click(object sender, EventArgs e)
        {
            frmProgressMeter frmProgressMeter = new frmProgressMeter();
            UtilWindowRelativePositioner relativePositioner = new UtilWindowRelativePositioner(this, frmProgressMeter);
            WorkingPath = Path.Combine(Project.DebugFilePath, "working");
            string str1 = StringType.StrCmp(BuildMode, "debug", false) != 0
                ? Project.ReleaseFilePath
                : Project.DebugFilePath;
            ((Control) frmProgressMeter).Location = relativePositioner.GetConcentric();
            frmProgressMeter.Show();
            if (Project.OverrideFiles.Count > 0)
            {
                EnsureDirectoryExists(str1 + "Override\\");
                frmProgressMeter.message = "Copying Override files";
                frmProgressMeter.stepAmount = 100 / Project.OverrideFiles.Count;

                foreach (object overrideFile in Project.OverrideFiles)
                {
                    string str2 = StringType.FromObject(overrideFile);
                    if (!str2.ToLower().EndsWith("nss"))
                    {
                        frmProgressMeter.status = "Copying " + Path.GetFileName(str2);
                        File.Copy(str2, str1 + "override\\" + Path.GetFileName(str2), true);
                    }
                    else
                    {
                        frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(str2);
                        string str3 = "";
                        try
                        {
                            str3 = CompileNSS(str2);
                        }
                        catch (Exception ex)
                        {
                            ProjectData.SetProjectError(ex);
                            Exception exception = ex;
                            if (Interaction.MsgBox("Override Script " + str2 + " failed to compile." + "\n" + "Error message:" + "\n" + exception.Message + "\n" + "Do you wish to continue compiling scripts?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2, "Script compile failure") == MsgBoxResult.No)
                            {
                                frmProgressMeter.Close();
                                ProjectData.ClearProjectError();
                                return;
                            }

                            ProjectData.ClearProjectError();
                        }

                        if (StringType.StrCmp(str3, "", false) != 0)
                        {
                            File.Copy(str3, str1 + "override\\" + Path.GetFileName(str3), true);
                            frmProgressMeter.stepUp();
                        }
                    }

                    frmProgressMeter.stepUp();
                }
            }

            ArrayList modules = Project.Modules;
            if (modules.Count > 0)
            {
                EnsureDirectoryExists(str1 + "Modules\\");
                EnsureDirectoryExists(WorkingPath);

                foreach (ModuleFileEntry moduleFileEntry in modules)
                {
                    if (moduleFileEntry.ModuleFiles.Count > 0)
                    {
                        frmProgressMeter.progress = 0;
                        frmProgressMeter.message = "Compiling Package: " + moduleFileEntry.ModuleName;
                        frmProgressMeter.stepAmount = 100 / moduleFileEntry.ModuleFiles.Count;
                        string[] inputFileList = new string[checked(moduleFileEntry.ModuleFiles.Count - 1 + 1)];
                        int num1 = 0;
                        int num2 = checked(moduleFileEntry.ModuleFiles.Count - 1);
                        int index = num1;
                        while (index <= num2)
                        {
                            if (!moduleFileEntry.ModuleFiles[index].ToString().ToLower().EndsWith("nss"))
                            {
                                frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                                inputFileList[index] = StringType.FromObject(moduleFileEntry.ModuleFiles[index]);
                                frmProgressMeter.stepUp();
                            }
                            else
                            {
                                frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                                string sLeft = CompileNSS(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                                if (StringType.StrCmp(sLeft, "", false) == 0)
                                {
                                    Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry.ModuleName + ":", moduleFileEntry.ModuleFiles[index]), " failed to compile."), '\n'), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure");
                                    return;
                                }

                                inputFileList[index] = sLeft;
                                frmProgressMeter.stepUp();
                            }

                            ++index;
                        }

                        // ClsErf clsErf = new ClsErf(str1 + "Modules\\" + moduleFileEntry.ModuleName + "." + moduleFileEntry.PackageType.ToLower(), moduleFileEntry.PackageType.ToUpper(), Convert.ToUInt32(0), null, inputFileList);
                    }
                }
            }

            ArrayList lipsModules = Project.LipsModules;
            if (lipsModules.Count > 0)
            {
                EnsureDirectoryExists(str1 + "Lips\\");
                EnsureDirectoryExists(WorkingPath);

                foreach (ModuleFileEntry moduleFileEntry in lipsModules)
                {
                    if (moduleFileEntry.ModuleFiles.Count > 0)
                    {
                        frmProgressMeter.progress = 0;
                        frmProgressMeter.message = "Compiling Module: " + moduleFileEntry.ModuleName;
                        frmProgressMeter.stepAmount = 100 / moduleFileEntry.ModuleFiles.Count;
                        string[] inputFileList = new string[checked(moduleFileEntry.ModuleFiles.Count - 1 + 1)];
                        int num1 = 0;
                        int num2 = checked(moduleFileEntry.ModuleFiles.Count - 1);
                        int index = num1;
                        while (index <= num2)
                        {
                            if (!moduleFileEntry.ModuleFiles[index].ToString().ToLower().EndsWith("nss"))
                            {
                                frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                                inputFileList[index] = StringType.FromObject(moduleFileEntry.ModuleFiles[index]);
                                frmProgressMeter.stepUp();
                            }
                            else
                            {
                                frmProgressMeter.status = "Compiling Script: " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                                string sLeft = CompileNSS(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                                if (StringType.StrCmp(sLeft, "", false) == 0)
                                {
                                    Interaction.MsgBox(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj("Module Script " + moduleFileEntry.ModuleName + ":", moduleFileEntry.ModuleFiles[index]), " failed to compile."), '\n'), "Aborting build"), MsgBoxStyle.Exclamation, "Script compile failure");
                                    return;
                                }

                                inputFileList[index] = sLeft;
                                frmProgressMeter.stepUp();
                            }

                            ++index;
                        }

                        //ClsErf clsErf = new ClsErf(str1 + "Lips\\" + moduleFileEntry.ModuleName + ".mod", "MOD", Convert.ToUInt32(0), null, inputFileList);
                    }
                }
            }

            ArrayList streamWavesModules = Project.StreamWavesModules;
            if (streamWavesModules.Count > 0)
            {
                EnsureDirectoryExists(str1 + "StreamWaves\\");

                foreach (ModuleFileEntry moduleFileEntry in streamWavesModules)
                {
                    if (moduleFileEntry.ModuleFiles.Count > 0)
                    {
                        EnsureDirectoryExists(str1 + "StreamWaves\\" + moduleFileEntry.ModuleName + "\\");
                        frmProgressMeter.progress = 0;
                        frmProgressMeter.message = "Copying Module: " + moduleFileEntry.ModuleName;
                        frmProgressMeter.stepAmount = 100 / moduleFileEntry.ModuleFiles.Count;
                        int num1 = 0;
                        int num2 = checked(moduleFileEntry.ModuleFiles.Count - 1);
                        int index = num1;
                        while (index <= num2)
                        {
                            frmProgressMeter.status = "Copying " + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index]));
                            File.Copy(StringType.FromObject(moduleFileEntry.ModuleFiles[index]), str1 + "StreamWaves\\" + moduleFileEntry.ModuleName + "\\" + Path.GetFileName(StringType.FromObject(moduleFileEntry.ModuleFiles[index])), 1 != 0);
                            ++index;
                        }
                    }
                }
            }

            if (Project.StreamWavesFiles.Count > 0)
            {
                frmProgressMeter.message = "Copying StreamWaves files";
                frmProgressMeter.stepAmount = 100 / Project.StreamWavesFiles.Count;

                foreach (object streamWavesFile in Project.StreamWavesFiles)
                {
                    string str2 = StringType.FromObject(streamWavesFile);
                    frmProgressMeter.status = "Copying " + Path.GetFileName(str2);
                    File.Copy(str2, str1 + "StreamWaves\\" + Path.GetFileName(str2), true);
                    frmProgressMeter.stepUp();
                }
            }

            frmProgressMeter.Close();
        }

        private void miQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miCleanDebugPrjFilesOnly_Click(object sender, EventArgs e)
        {
            CleanProjectFilesFromDir(Project.DebugFilePath);
        }

        private void miCleanReleasePrjFilesOnly_Click(object sender, EventArgs e)
        {
            CleanProjectFilesFromDir(Project.ReleaseFilePath);
        }

        private void AskIfSaveProject()
        {
            if (Project == null || Interaction.MsgBox("Save Project before closing?", MsgBoxStyle.YesNo, "") != MsgBoxResult.Yes) return;
            ProjectMgr.SaveProject();
        }

        private void EnableMenus()
        {
            miProjectProperties.Enabled = true;
            miExploreDebugFolder.Enabled = true;
            miExploreReleaseFolder.Enabled = true;
            miSaveProject.Enabled = true;
            miBuildProject.Enabled = true;
            miCleanDebugPrjFilesOnly.Enabled = true;
            miCleanReleasePrjFilesOnly.Enabled = true;
        }

        private void BuildTreeRoots()
        {
            TreeView.Nodes.Clear();
            TreeView.Nodes.AddRange(new ProjectFileItemTreeNode[1]
            {
                new ProjectFileItemTreeNode("Project", new ProjectFileItemTreeNode[4]
                {
                    new ProjectFileItemTreeNode("Overrides"),
                    new ProjectFileItemTreeNode("Packages"),
                    new ProjectFileItemTreeNode("Lips Modules"),
                    new ProjectFileItemTreeNode("StreamWaves")
                })
            });
            TreeView.Nodes[0].Nodes[0].Tag = "overrideroot";
            TreeView.Nodes[0].Nodes[1].Tag = "moduleroot";
            TreeView.Nodes[0].Nodes[2].Tag = "lipsmoduleroot";
            TreeView.Nodes[0].Nodes[3].Tag = "streamwavesroot";
            TreeView.Nodes[0].Nodes[0].ImageIndex = 2;
            TreeView.Nodes[0].Nodes[1].ImageIndex = 2;
            TreeView.Nodes[0].Nodes[2].ImageIndex = 2;
            TreeView.Nodes[0].Nodes[3].ImageIndex = 2;
            TreeView.Nodes[0].Nodes[0].SelectedImageIndex = 2;
            TreeView.Nodes[0].Nodes[1].SelectedImageIndex = 2;
            TreeView.Nodes[0].Nodes[2].SelectedImageIndex = 2;
            TreeView.Nodes[0].Nodes[3].SelectedImageIndex = 2;
            TreeView.Nodes[0].Text = "projectroot";
            TreeView.Nodes[0].Expand();
        }

        private void RefreshTreeView()
        {
            TreeView.BeginUpdate();
            TreeView.Nodes[0].Nodes[0].Nodes.Clear();
            TreeView.Nodes[0].Nodes[1].Nodes.Clear();
            TreeView.Nodes[0].Nodes[2].Nodes.Clear();
            TreeView.Nodes[0].Nodes[3].Nodes.Clear();
            TreeView.Nodes[0].Text = Project.Name;
            TreeView.Nodes[0].Tag = "projectroot";
            TreeView.Nodes[0].ImageIndex = 0;
            TreeView.Nodes[0].SelectedImageIndex = TreeView.Nodes[0].ImageIndex;
            Project.OverrideFiles.Sort();

            foreach (object overrideFile in Project.OverrideFiles)
            {
                string path = StringType.FromObject(overrideFile);
                ProjectFileItemTreeNode fileItemTreeNode = new ProjectFileItemTreeNode(Path.GetFileName(path));
                fileItemTreeNode.Tag = "overridechild";
                fileItemTreeNode.ImageIndex = 1;
                fileItemTreeNode.SelectedImageIndex = fileItemTreeNode.ImageIndex;
                fileItemTreeNode.FilePath = path;
                TreeView.Nodes[0].Nodes[0].Nodes.Add(fileItemTreeNode);
            }


            ArrayList modules = Project.Modules;

            foreach (ModuleFileEntry moduleFileEntry in modules)
            {
                ProjectFileItemTreeNode fileItemTreeNode1 = new ProjectFileItemTreeNode(moduleFileEntry.ModuleName);
                fileItemTreeNode1.Tag = "moduleparent";
                fileItemTreeNode1.ImageIndex = 2;
                fileItemTreeNode1.SelectedImageIndex = fileItemTreeNode1.ImageIndex;
                moduleFileEntry.ModuleFiles.Sort();

                foreach (object moduleFile in moduleFileEntry.ModuleFiles)
                {
                    string path = StringType.FromObject(moduleFile);
                    ProjectFileItemTreeNode fileItemTreeNode2 = new ProjectFileItemTreeNode(Path.GetFileName(path));
                    fileItemTreeNode2.Tag = "modulechild";
                    fileItemTreeNode2.ImageIndex = 1;
                    fileItemTreeNode2.SelectedImageIndex = fileItemTreeNode2.ImageIndex;
                    fileItemTreeNode2.FilePath = path;
                    fileItemTreeNode1.Nodes.Add(fileItemTreeNode2);
                }


                TreeView.Nodes[0].Nodes[1].Nodes.Add(fileItemTreeNode1);
            }


            ArrayList lipsModules = Project.LipsModules;

            foreach (ModuleFileEntry moduleFileEntry in lipsModules)
            {
                ProjectFileItemTreeNode fileItemTreeNode1 = new ProjectFileItemTreeNode(moduleFileEntry.ModuleName);
                fileItemTreeNode1.Tag = "lipsmoduleparent";
                fileItemTreeNode1.ImageIndex = 2;
                fileItemTreeNode1.SelectedImageIndex = fileItemTreeNode1.ImageIndex;
                moduleFileEntry.ModuleFiles.Sort();

                foreach (object moduleFile in moduleFileEntry.ModuleFiles)
                {
                    string path = StringType.FromObject(moduleFile);
                    ProjectFileItemTreeNode fileItemTreeNode2 = new ProjectFileItemTreeNode(Path.GetFileName(path));
                    fileItemTreeNode2.Tag = "lipsmodulechild";
                    fileItemTreeNode2.ImageIndex = 1;
                    fileItemTreeNode2.SelectedImageIndex = fileItemTreeNode2.ImageIndex;
                    fileItemTreeNode2.FilePath = path;
                    fileItemTreeNode1.Nodes.Add(fileItemTreeNode2);
                }


                TreeView.Nodes[0].Nodes[2].Nodes.Add(fileItemTreeNode1);
            }

            ArrayList streamWavesModules = Project.StreamWavesModules;

            foreach (ModuleFileEntry moduleFileEntry in streamWavesModules)
            {
                ProjectFileItemTreeNode fileItemTreeNode1 = new ProjectFileItemTreeNode(moduleFileEntry.ModuleName);
                fileItemTreeNode1.Tag = "streamwavesmoduleparent";
                fileItemTreeNode1.ImageIndex = 2;
                fileItemTreeNode1.SelectedImageIndex = fileItemTreeNode1.ImageIndex;
                moduleFileEntry.ModuleFiles.Sort();
               
                    foreach (object moduleFile in moduleFileEntry.ModuleFiles)
                    {
                        string path = StringType.FromObject(moduleFile);
                        ProjectFileItemTreeNode fileItemTreeNode2 = new ProjectFileItemTreeNode(Path.GetFileName(path));
                        fileItemTreeNode2.Tag = "streamwavesmodulechild";
                        fileItemTreeNode2.ImageIndex = 1;
                        fileItemTreeNode2.SelectedImageIndex = fileItemTreeNode2.ImageIndex;
                        fileItemTreeNode2.FilePath = path;
                        fileItemTreeNode1.Nodes.Add(fileItemTreeNode2);
                    }
              

                TreeView.Nodes[0].Nodes[3].Nodes.Add(fileItemTreeNode1);
            }


            Project.StreamWavesFiles.Sort();

            foreach (object streamWavesFile in Project.StreamWavesFiles)
            {
                string path = StringType.FromObject(streamWavesFile);
                ProjectFileItemTreeNode fileItemTreeNode = new ProjectFileItemTreeNode(Path.GetFileName(path));
                fileItemTreeNode.Tag = "streamwavesfilechild";
                fileItemTreeNode.ImageIndex = 1;
                fileItemTreeNode.SelectedImageIndex = fileItemTreeNode.ImageIndex;
                fileItemTreeNode.FilePath = path;
                TreeView.Nodes[0].Nodes[3].Nodes.Add(fileItemTreeNode);
            }


            TreeView.EndUpdate();
        }

        private void EditProjectProperties()
        {
            frmProjectManagerProperties managerProperties = new frmProjectManagerProperties("edit");
            managerProperties.tbProjectName.Text = Project.Name;
            managerProperties.tbProjectPath.Text = ProjectMgr.ProjectFilePath;
            managerProperties.tbDebugPath.Text = Project.DebugFilePath;
            managerProperties.tbReleasePath.Text = Project.ReleaseFilePath;
            managerProperties.rbKotor1.Checked = Project.KotorVersionIndex == 0;
            managerProperties.rbKotor2.Checked = Project.KotorVersionIndex == 1;
            if (managerProperties.ShowDialog(this) != DialogResult.OK)
                return;
            if (StringType.StrCmp(managerProperties.tbProjectName.Text.Trim(), Project.Name, false) != 0)
            {
                Project.Name = managerProperties.tbProjectName.Text.Trim();
                TreeView.Nodes[0].Text = managerProperties.tbProjectName.Text.Trim();
            }

            ProjectMgr.ProjectFilePath = managerProperties.tbProjectPath.Text.Trim();
            Text = "Project Manager - " + Path.GetFileName(managerProperties.tbProjectPath.Text.Trim());
            Project.DebugFilePath = managerProperties.tbDebugPath.Text.Trim();
            Project.ReleaseFilePath = managerProperties.tbReleasePath.Text.Trim();
            if (!Project.DebugFilePath.EndsWith("\\"))
            {
                ClsProject project = Project;
                project.DebugFilePath = project.DebugFilePath + "\\";
            }

            if (!Project.ReleaseFilePath.EndsWith("\\"))
            {
                ClsProject project = Project;
                project.ReleaseFilePath = project.ReleaseFilePath + "\\";
            }

            if (managerProperties.rbKotor1.Checked)
                Project.KotorVersionIndex = 0;
            if (!managerProperties.rbKotor2.Checked)
                return;
            Project.KotorVersionIndex = 1;
        }

        public void OpenTreeViewToPath(string treepath, TreeNode currNode, int currLevel)
        {
            string[] strArray = Strings.Split(treepath, "\\");
            if (currLevel == strArray.Length)
                return;

            foreach (TreeNode node in currNode.Nodes)
            {
                if (StringType.StrCmp(node.Text, strArray[currLevel], false) == 0)
                {
                    node.Expand();
                    OpenTreeViewToPath(treepath, node, checked(currLevel + 1));
                }
            }
        }

        private string BrowseForProjectFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select project file...";
            openFileDialog.Filter = "Kotor Tool Project (*.ktp)|*.ktp";
            openFileDialog.CheckFileExists = true;
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FileName = "*.ktp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileName;
            else
            {
                string str = "";
                return str;
            }
        }

        public void EnsureDirectoryExists(object dirPath)
        {
            if (Directory.Exists(StringType.FromObject(dirPath)))
                return;
            Directory.CreateDirectory(StringType.FromObject(dirPath));
        }

        private string CompileNSS(string sourcefilepath)
        {
            string str = "-g " + Convert.ToString(checked(Project.KotorVersionIndex + 1));
            string path = WorkingPath + "\\" + Path.GetFileNameWithoutExtension(sourcefilepath) + ".ncs";
            EnsureDirectoryExists(WorkingPath);
            if (File.Exists(path)) File.Delete(path);
            Process process = new Process();
            process.StartInfo.FileName = MainFormState.GRootPath + "nwnnsscomp.exe";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.Arguments = "-c " + str + " -o " + "\"" + path + "\"" + " " + "\"" + sourcefilepath + "\"";
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string end = process.StandardOutput.ReadToEnd();
            process.WaitForExit(4000);
            if (end.IndexOf("Error", StringComparison.Ordinal) == -1) return path;
            throw new NSSCompilerException(end);
        }

        private void CleanProjectFilesFromDir(string dirname)
        {
            foreach (object overrideFile in Project.OverrideFiles)
            {
                string path = StringType.FromObject(overrideFile);
                try
                {
                    File.Delete(dirname + "override\\" + Path.GetFileName(path));
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
            }


            foreach (ModuleFileEntry module in Project.Modules)
            {
                try
                {
                    File.Delete(dirname + "modules\\" + module.ModuleName + ".mod");
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
            }


            foreach (ModuleFileEntry lipsModule in Project.LipsModules)
            {
                try
                {
                    File.Delete(dirname + "lips\\" + lipsModule.ModuleName + ".mod");
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
            }


            foreach (ModuleFileEntry streamWavesModule in Project.StreamWavesModules)
            {
                foreach (object moduleFile in streamWavesModule.ModuleFiles)
                {
                    string path = StringType.FromObject(moduleFile);
                    try
                    {
                        File.Delete(dirname + "StreamWaves\\" + streamWavesModule.ModuleName + "\\" +
                                    Path.GetFileName(path));
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        ProjectData.ClearProjectError();
                    }
                }


                try
                {
                    Directory.Delete(dirname + "StreamWaves\\" + streamWavesModule.ModuleName + "\\");
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
            }


            foreach (object streamWavesFile in Project.StreamWavesFiles)
            {
                string path = StringType.FromObject(streamWavesFile);
                try
                {
                    File.Delete(dirname + "StreamWaves\\" + Path.GetFileName(path));
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void TreeView_MouseMove(object sender, MouseEventArgs e)
        {
            ProjectFileItemTreeNode nodeAt =
                (ProjectFileItemTreeNode) TreeView.GetNodeAt(TreeView.PointToClient(MousePosition));
            if (nodeAt == null)
                return;
            lblStatus.Text = nodeAt.FilePath;
        }

        private void TreeView_MouseLeave(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void frmProjectManager_Load(object sender, EventArgs e)
        {
            PositionWindow(GetType().Name);
        }

        private class NSSCompilerException : Exception
        {
            public NSSCompilerException(object Message)
                : base(StringType.FromObject(Message))
            {
            }
        }
    }
}