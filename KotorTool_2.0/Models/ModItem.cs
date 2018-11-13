// Decompiled with JetBrains decompiler
// Type: KotorTool_2.ModItem
// Assembly: KotorTool_2, Version=1.0.2210.16738, Culture=neutral, PublicKeyToken=null
// MVID: 0C64B4D3-3B5F-4694-A8DB-D7A0CDE84A5B
// Assembly location: C:\Program Files (x86)\Kotor Tool\KotorTool_2.exe

using System;
using System.Collections;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models
{
  public class ModItem : IComparable
  {
    private int _screenX;
    private int _screenY;
    private float _x;
    private float _y;
    private float _z;
    private string _resRef;
    private string _path;
    private string _localTag;
    private int _itemType;
    private string _xPosAccessor;
    private string _yPosAccessor;
    private string _zPosAccessor;
    private ArrayList _geometryList;
    private ArrayList _spawnPointList;
    private ModItem _parent;
    public const int ItemTypeCreature = 2027;
    public const int ItemTypePlaceable = 2044;
    public const int ItemTypeDoor = 2042;
    public const int ItemTypeSound = 2035;
    public const int ItemTypeWaypoint = 2058;
    public const int ItemTypeCamera = 6;
    public const int ItemTypeStore = 2051;
    public const int ItemTypeTrigger = 2032;
    public const int ItemTypeEncounter = 2040;
    public const int ItemTypeEncounterSpawnPoint = 12040;
    public const int ItemTypeItem = 2025;
    public const int ItemTypeStartPoint = 5000;

    public int ScreenX
    {
      get => _screenX;
      set => _screenX = value;
    }

    public int ScreenY
    {
      get => _screenY;
      set => _screenY = value;
    }

    public float X
    {
      get => _x;
      set => _x = value;
    }

    public float Y
    {
      get => _y;
      set => _y = value;
    }

    public float Z
    {
      get => _z;
      set => _z = value;
    }

    public string Path
    {
      get => _path;
      set => _path = value;
    }

    public string ResRef
    {
      get => _resRef;
      set => _resRef = value;
    }

    public int ItemType
    {
      get => _itemType;
      set => _itemType = value;
    }

    public string XPosAccessor
    {
      get => _xPosAccessor;
      set => _xPosAccessor = value;
    }

    public string YPosAccessor
    {
      get => _yPosAccessor;
      set => _yPosAccessor = value;
    }

    public string ZPosAccessor
    {
      get => _zPosAccessor;
      set => _zPosAccessor = value;
    }

    public string XPosPath => _path + "." + _xPosAccessor;

    public string YPosPath => _path + "." + _yPosAccessor;

    public string ZPosPath => _path + "." + _zPosAccessor;

    public ArrayList GeometryList
    {
      get => _geometryList;
      set => _geometryList = value;
    }

    public ArrayList SpawnPointList
    {
      get => _spawnPointList;
      set => _spawnPointList = value;
    }

    public string FileExtension
    {
      get
      {
        switch (_itemType)
        {
          case 2025:
            return ".uti";
          case 2027:
            return ".utc";
          case 2032:
            return ".utt";
          case 2035:
            return ".uts";
          case 2040:
            return ".ute";
          case 2042:
            return ".utd";
          case 2044:
            return ".utp";
          case 2051:
            return ".utm";
          case 2058:
            return ".utw";
          default:
            string str = "";
            return str;
        }
      }
    }

    public string FileName => _resRef + FileExtension;

    public ModItem Parent
    {
      get => _parent;
      set => _parent = value;
    }

    public string Tag
    {
      get => _localTag;
      set => _localTag = value;
    }

    public ModItem(int screenX, int screenY, float x, float y, string resRef, string path)
    {
      _screenX = screenX;
      _screenY = screenY;
      _x = x;
      _y = y;
      _path = path;
      _resRef = resRef;
    }

    public ModItem(int screenX, int screenY, float x, float y, string resRef, string path, ModItem parent)
      : this(screenX, screenY, x, y, resRef, path)
    {
      _parent = parent;
    }

    public ModItem(int screenX, int screenY, float x, float y, string resRef, string path, bool dummy, string tag)
      : this(screenX, screenY, x, y, resRef, path)
    {
      _localTag = tag;
    }

    public bool IsEqual(ModItem mi)
    {
      return mi != null && mi.ItemType == ItemType && (mi.X == (double) X && mi.Y == (double) Y) && StringType.StrCmp(mi.ResRef, ResRef, false) == 0;
    }

    public int CompareTo(object obj)
    {
      return String.CompareOrdinal(ResRef, ((ModItem) obj).ResRef);
    }
  }
}
