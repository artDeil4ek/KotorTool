using System;
using System.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Options
{
    [Serializable]
    public class ConfigOptions
    {



        /// <summary>
        /// Singleton Pattern for retrieving Configurations
        /// </summary>
        public static ConfigOptions configOptions { get; set; }

        public static ConfigOptions GetInstance()
        {
            if (configOptions != null)
            {
                return configOptions;
            }
            return new ConfigOptions();

        }






        public Paths paths { get; set; }
        public Toggles toggles { get; set; }

        public ConfigOptions()
        {
            paths = new Paths();
            toggles = new Toggles();
        }


         public class ConfigData
        {
            private string Key { get; set; }
            public static ArrayList MruMainFiles { get; set; }
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
                        string str = String.Empty;
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
                        string str = String.Empty;
                        return str;
                }
            }
        }


        [Serializable]
        public class Toggles
        {
            public bool BuildBiffTreeOnStartup;
            public bool AlwaysConvertTpc2Tga;
            public bool DockImageViewer;
            public bool TextEditorWordWrap;
            public bool AlwaysUnknownGfFasText;
            public bool ShowModuleLocations;
            public  bool ShowModuleDescriptions;
            public  bool BuildModelsBifNode;
            public  bool ProjMgrUseExternTxtEditor;
            public  bool ProjMgrUseExternDlgEditor;
            public  bool ModuleEditorShowLocatorRay;
            public  bool ModuleEditorConfirmDeletes;
            public  bool CheckForUpdatesAtStartup;
            public  bool DownloadUpdatesAutomatically;
            public  bool RememberLastTreeNode;
            public  bool RememberTreeViewState;
            public  bool ModelExtractionExtractAnimations;
            public  bool ModelExtractionConvertSkinToTrimesh;
            public  bool ModelExtractionEachModelInOwnDirectory;
            public bool ModelExtractionCleanWorkingDirectoryBeforeExport;
            public bool UseOverrideFiles;
        }





    }
}