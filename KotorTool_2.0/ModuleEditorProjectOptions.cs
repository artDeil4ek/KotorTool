
using System;

namespace KotorTool_2._0
{


    [Serializable]
    public class ModuleEditorProjectOptions
    {



        public string ModuleEditorModOutputPath { get; set; }
        public bool UseHiResMap { get; set; }
        public bool FilterShowCreatures { get; set; }
        public bool FilterShowDoors { get; set; }
        public bool FilterShowPlaceables { get; set; }
        public bool FilterShowEncounters { get; set; }
        public bool FilterShowTriggers { get; set; }
        public bool FilterShowMerchants { get; set; }
        public bool FilterShowSounds { get; set; }
        public bool FilterShowWayPoints { get; set; }
        public string MapSize { get; set; }
        public bool ShowItemLabels { get; set; }
        public bool ShowTagsOnModulePalette { get; set; }
        public int LastScrollPosX { get; set; }
        public int LastScrollPosY { get; set; }




        public ModuleEditorProjectOptions()
        {
            ModuleEditorModOutputPath = String.Empty;
            UseHiResMap = true;
            FilterShowCreatures = true;
            FilterShowDoors = true;
            FilterShowPlaceables = true;
            FilterShowEncounters = true;
            FilterShowTriggers = true;
            FilterShowMerchants = true;
            FilterShowSounds = true;
            FilterShowWayPoints = true;
            MapSize = "small";
            ShowItemLabels = true;
            ShowTagsOnModulePalette = false;
            LastScrollPosX = 0;
            LastScrollPosY = 0;
        }



        




    }
}
