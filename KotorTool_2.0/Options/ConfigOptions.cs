using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Options
{
    [Serializable]
    public  class ConfigOptions
    {
        public static ConfigOptions configOptions { get; set; }
        
        public static ConfigOptions getInstance()
        {
            return configOptions;
        }
        
        [Serializable]
        public class Paths
        {
            public string DefaultModuleLocation;
            public string DefaultOverrideLocation;
            public static string DefaultImportLocation;
            public string DefaultKeyFileLocation;
            public static string DefaultSaveLocation;
            public static string DefaultKotorLocation;
            public string DefaultDataLocation;
            public static string ImageViewerLocation;
            public string DefaultRimsLocation;
            public string DefaultTexturePackLocation;
            public static string ModelExportLocation;
            public static string ModuleExtractPath;
            public static string TextEditorSavePath;
            public string CurrentDataLocation;
            public string CurrentKotOrLocation;
            public string CurrentModuleLocation;
            public string CurrentOverrideLocation;
            public string CurrentKeyFileLocation;
            public string CurrentRimsLocation;
            public static string DefaultKotorTslLocation;
            private string DefaultModuleLocation2;
            public static string LastModuleEditedPath;
            public static string LastClickedTvNodePath;
            public static string ProjMgrDlgEditorPath;
            public static string ProjMgrTxtEditorPath;
            public static ArrayList TreeOpenPaths;
            
            public static string KotorLocation(int index)
            {
                switch (index)
                {
                    case 0:
                        return DefaultKotorLocation;
                    case 1:
                        return DefaultKotorTslLocation;
                    default:
                        string str = "";
                        return str;
                }
            }
            
            public static string KeyFileLocation(int index)
            {
                switch (index)
                {
                    case 0:
                        return DefaultKotorLocation + "\\chitin.key";
                    case 1:
                        return DefaultKotorTslLocation + "\\chitin.key";
                    default:
                        string str = "";
                        return str;
                }
            }
        }
       
        [Serializable]
        public class Toggles
        {
            public static bool BuildBiffTreeOnStartup;
            public static bool AlwaysConvertTpc2Tga;
            public static bool DockImageViewer;
            public static bool TextEditorWordWrap;
            public static bool AlwaysUnknownGfFasText;
            public static bool ShowModuleLocations;
            public static bool ShowModuleDescriptions;
            public static bool BuildModelsBifNode;
            public static bool ProjMgrUseExternTxtEditor;
            public static bool ProjMgrUseExternDlgEditor;
            private bool ModuleEditorShowLocatorRay;
            private bool ModuleEditorConfirmDeletes;
            public static bool CheckForUpdatesAtStartup;
            public static bool DownloadUpdatesAutomatically;
            public static bool RememberLastTreeNode;
            public static bool RememberTreeViewState;
            public static bool ModelExtractionExtractAnimations;
            public static bool ModelExtractionConvertSkinToTrimesh;
            public static bool ModelExtractionEachModelInOwnDirectory;
            public static bool ModelExtractionCleanWorkingDirectoryBeforeExport;
            public static bool UseOverrideFiles;
        }

        [Serializable]
        public class WindowSettings
        {
            private Point MainWindowLoc;
            private Size MainWindowSize;
            private int MainWindowSplitterPos;
            public static Point ImageViewerWindowLoc;
            private Point FrmGlobalVarEditorWindowLoc;
            public static Size ImageViewerWindowSize;
            private Size FrmGlobalVarEditorWindowSize;
            public static Point ByteViewerWindowLoc;
            public static Size ByteViewerWindowSize;
            public static Point TextEditorWindowLoc;
            public static Size TextEditorWindowSize;
            private Point ErfManagerWindowLoc;
            private Size ErfManagerWindowSize;
            private Point _2DaEditorWindowLoc;
            private Size _2DaEditorWindowSize;
            private Point UtcEditorWindowLoc;
            private Size UtcEditorWindowSize;
            private Point UtdEditorWindowLoc;
            private Size UtdEditorWindowSize;
            private Point UtiEditorWindowLoc;
            private Size UtiEditorWindowSize;
            private Point UtmEditorWindowLoc;
            private Size UtmEditorWindowSize;
            private Point UtpEditorWindowLoc;
            private Size UtpEditorWindowSize;
            private Point UtsEditorWindowLoc;
            private Size UtsEditorWindowSize;
            private Point UttEditorWindowLoc;
            private Size UttEditorWindowSize;
            private Point UtwEditorWindowLoc;
            private Size UtwEditorWindowSize;
            private Point ProjectManagerWindowLoc;
            private Size ProjectManagerWindowSize;
            public static Point InventoryEditorWindowLoc;
            public static Size InventoryEditorWindowSize;
            private Point ModuleEditorWindowLoc;
            private Size ModuleEditorWindowSize;
            private Decimal ModuleEditorModuleElementIndicatorSize;
        }
        
        private string Key;
        public static ArrayList MruMainFiles;
        
        }
}