
using System;

namespace KotorTool_2._0
{
  [Serializable]
  public class ModuleEditorProjectOptions
  {
    private string _moduleEditorModOutputPath;
    private bool _useHiResMap;
    private bool _filterShowCreatures;
    private bool _filterShowDoors;
    private bool _filterShowPlaceables;
    private bool _filterShowEncounters;
    private bool _filterShowTriggers;
    private bool _filterShowMerchants;
    private bool _filterShowSounds;
    private bool _filterShowWaypoints;
    private string _mapSize;
    private bool _showItemLabels;
    private bool _showTagsOnModulePalette;
    private int _lastScrollPosX;
    private int _lastScrollPosY;

    public string ModuleEditorModOutputPath
    {
      get => _moduleEditorModOutputPath;
      set => _moduleEditorModOutputPath = value;
    }

    public bool UseHiResMap
    {
      get => _useHiResMap;
      set => _useHiResMap = value;
    }

    public bool FilterShowCreatures
    {
      get => _filterShowCreatures;
      set => _filterShowCreatures = value;
    }

    public bool FilterShowDoors
    {
      get => _filterShowDoors;
      set => _filterShowDoors = value;
    }

    public bool FilterShowPlaceables
    {
      get => _filterShowPlaceables;
      set => _filterShowPlaceables = value;
    }

    public bool FilterShowEncounters
    {
      get => _filterShowEncounters;
      set => _filterShowEncounters = value;
    }

    public bool FilterShowTriggers
    {
      get => _filterShowTriggers;
      set => _filterShowTriggers = value;
    }

    public bool FilterShowMerchants
    {
      get => _filterShowMerchants;
      set => _filterShowMerchants = value;
    }

    public bool FilterShowSounds
    {
      get => _filterShowSounds;
      set => _filterShowSounds = value;
    }

    public bool FilterShowWaypoints
    {
      get => _filterShowWaypoints;
      set => _filterShowWaypoints = value;
    }

    public string MapSize
    {
      get => _mapSize;
      set => _mapSize = value;
    }

    public bool ShowItemLabels
    {
      get => _showItemLabels;
      set => _showItemLabels = value;
    }

    public bool ShowTagsOnModulePalette
    {
      get => _showTagsOnModulePalette;
      set => _showTagsOnModulePalette = value;
    }

    public int LastScrollPosX
    {
      get => _lastScrollPosX;
      set => _lastScrollPosX = value;
    }

    public int LastScrollPosY
    {
      get => _lastScrollPosY;
      set => _lastScrollPosY = value;
    }

    public ModuleEditorProjectOptions()
    {
      _moduleEditorModOutputPath = "";
      _useHiResMap = true;
      _filterShowCreatures = true;
      _filterShowDoors = true;
      _filterShowPlaceables = true;
      _filterShowEncounters = true;
      _filterShowTriggers = true;
      _filterShowMerchants = true;
      _filterShowSounds = true;
      _filterShowWaypoints = true;
      _mapSize = "small";
      _showItemLabels = true;
      _showTagsOnModulePalette = false;
      _lastScrollPosX = 0;
      _lastScrollPosY = 0;
    }
  }
}
