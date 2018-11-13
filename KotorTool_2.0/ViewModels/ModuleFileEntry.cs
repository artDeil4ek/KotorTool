using System;
using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class ModuleFileEntry
  {
    private string _mModuleName;
    private ArrayList _mModuleFiles;
    private string _mPackageType;

    public string ModuleName
    {
      get => _mModuleName;
      set => _mModuleName = value;
    }

    public string PackageType
    {
      get => _mPackageType;
      set => _mPackageType = value;
    }

    [XmlArrayItem(typeof(string))]
    [XmlArray]
    public ArrayList ModuleFiles
    {
      get => _mModuleFiles;
      set => _mModuleFiles = value;
    }

    public ModuleFileEntry()
    {
      _mPackageType = "MOD";
      _mModuleName = "";
      _mModuleFiles = new ArrayList();
    }

    public ModuleFileEntry(string name) : this()
    {
      _mModuleName = name;
    }

    [XmlIgnore]
    public Hashtable FilesHashTable
    {
      get
      {
        Hashtable hashtable = new Hashtable(ModuleFiles.Count);

        foreach (object moduleFile in ModuleFiles)
        {
          string str = StringType.FromObject(moduleFile);
          hashtable.Add(str, "");
        }

        return hashtable;
      }
    }

  
  }
}
