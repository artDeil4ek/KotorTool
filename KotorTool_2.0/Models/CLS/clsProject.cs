using System;
using System.Collections;
using System.Xml.Serialization;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
  [Serializable]
  public class ClsProject
  {
    private string _mProjectName;
    private ArrayList _mOverrideFiles;
    private ArrayList _mModules;
    private ArrayList _mLipsModules;
    private ArrayList _mStreamWavesFiles;
    private ArrayList _mStreamWavesModules;
    private string _mReleaseFilePath;
    private string _mDebugFilePath;
    private int _mKotorVersionIndex;

    public string Name
    {
      get => _mProjectName;
      set => _mProjectName = value;
    }

    public string DebugFilePath
    {
      get => _mDebugFilePath;
      set => _mDebugFilePath = value;
    }

    public string ReleaseFilePath
    {
      get => _mReleaseFilePath;
      set => _mReleaseFilePath = value;
    }

    [XmlArray]
    [XmlArrayItem(typeof (string))]
    public ArrayList OverrideFiles
    {
      get => _mOverrideFiles;
      set => _mOverrideFiles = value;
    }

    [XmlArray]
    [XmlArrayItem(typeof (ModuleFileEntry))]
    public ArrayList Modules
    {
      get => _mModules;
      set => _mModules = value;
    }

    [XmlArray]
    [XmlArrayItem(typeof (ModuleFileEntry))]
    public ArrayList LipsModules
    {
      get => _mLipsModules;
      set => _mLipsModules = value;
    }

    [XmlArrayItem(typeof (string))]
    [XmlArray]
    public ArrayList StreamWavesFiles
    {
      get => _mStreamWavesFiles;
      set => _mStreamWavesFiles = value;
    }

    [XmlArrayItem(typeof (ModuleFileEntry))]
    [XmlArray]
    public ArrayList StreamWavesModules
    {
      get => _mStreamWavesModules;
      set => _mStreamWavesModules = value;
    }

    [XmlIgnore]
    public Hashtable OverrideFilesHashTable
    {
      get
      {
        Hashtable hashtable = new Hashtable(_mOverrideFiles.Count);
      
          foreach (object overrideFile in _mOverrideFiles)
          {
            string str = StringType.FromObject(overrideFile);
            hashtable.Add(str, "");
          }
       
        return hashtable;
      }
    }

    [XmlIgnore]
    public Hashtable StreamWavesFilesHashTable
    {
      get
      {
        Hashtable hashtable = new Hashtable(_mStreamWavesFiles.Count);
       
          foreach (object streamWavesFile in _mStreamWavesFiles)
          {
            string str = StringType.FromObject(streamWavesFile);
            hashtable.Add(str, "");
          }
      
        return hashtable;
      }
    }

    public int KotorVersionIndex
    {
      get => _mKotorVersionIndex;
      set => _mKotorVersionIndex = value;
    }

    public ClsProject()
    {
      _mProjectName = "Project";
      _mOverrideFiles = new ArrayList();
      _mModules = new ArrayList();
      _mLipsModules = new ArrayList();
      _mStreamWavesFiles = new ArrayList();
      _mStreamWavesModules = new ArrayList();
      _mKotorVersionIndex = -1;
    }

    public int GetModuleIndex(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mModules[index]).ModuleName, moduleName, false) == 0)
          return index;
         ++index; 
      }
      return -1;
    }

    public void RemoveAllModules()
    {
      _mModules.Clear();
    }

    public int AddModule(string name)
    {
      return _mModules.Add(new ModuleFileEntry(name));
    }

    public int AddModuleFile(string moduleName, string filePath)
    {
      int num1 = 0;
      int num2 = checked (_mModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mModules[index]).ModuleName, moduleName, false) == 0)
        {
          ((ModuleFileEntry) _mModules[index]).ModuleFiles.Add(filePath);
          return 0;
        }
        checked { ++index; }
      }
      return -1;
    }

    public void RemoveModule(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mModules[index]).ModuleName, moduleName, false) == 0)
        {
          _mModules.RemoveAt(index);
          break;
        }
        checked { ++index; }
      }
    }

    public void RemoveAllModuleFiles(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mModules[index]).ModuleName, moduleName, false) == 0)
        {
          ((ModuleFileEntry) _mModules[index]).ModuleFiles.Clear();
          break;
        }
        checked { ++index; }
      }
    }

    public ArrayList GetModuleNames()
    {
      ArrayList arrayList = new ArrayList();
     
        foreach (ModuleFileEntry module in _mModules)
          arrayList.Add(module.ModuleName);
    
      return arrayList;
    }

    public ArrayList GetModuleFiles(int index)
    {
      if (_mModules.Count >= index)
        return ((ModuleFileEntry) _mModules[index]).ModuleFiles;
      return null;
    }

    public ArrayList GetModuleFiles(string moduleName)
    {
      return ((ModuleFileEntry) _mModules[GetModuleIndex(moduleName)]).ModuleFiles;
    }

    public int RemoveModuleFile(string moduleName, string filePath)
    {
      int num1 = 0;
      int num2 = checked (_mModules.Count - 1);
      int index1 = num1;
      while (index1 <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mModules[index1]).ModuleName, moduleName, false) == 0)
        {
          int index2 = ((ModuleFileEntry) _mModules[index1]).ModuleFiles.IndexOf(filePath);
          if (index2 != -1)
          {
            ((ModuleFileEntry) _mModules[index1]).ModuleFiles.RemoveAt(index2);
            return 0;
          }
        }
        checked { ++index1; }
      }
      return -1;
    }

    public int RemoveOverrideFile(string filePath)
    {
      int index = _mOverrideFiles.IndexOf(filePath);
      if (index == -1)
        return -1;
      _mOverrideFiles.RemoveAt(index);
      return 0;
    }

    public void RemoveAllOverrideFiles()
    {
      _mOverrideFiles.Clear();
    }

    public int GetLipsModuleIndex(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mLipsModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mLipsModules[index]).ModuleName, moduleName, false) == 0)
          return index;
        checked { ++index; }
      }
      return -1;
    }

    public void RemoveAllLipsModules()
    {
      _mLipsModules.Clear();
    }

    public int AddLipsModule(string name)
    {
      return _mLipsModules.Add(new ModuleFileEntry(name));
    }

    public int AddLipsModuleFile(string moduleName, string filePath)
    {
      int num1 = 0;
      int num2 = checked (_mLipsModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mLipsModules[index]).ModuleName, moduleName, false) == 0)
        {
          ((ModuleFileEntry) _mLipsModules[index]).ModuleFiles.Add(filePath);
          return 0;
        }
        checked { ++index; }
      }
      return -1;
    }

    public void RemoveLipsModule(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mLipsModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mLipsModules[index]).ModuleName, moduleName, false) == 0)
        {
          _mLipsModules.RemoveAt(index);
          break;
        }
        checked { ++index; }
      }
    }

    public void RemoveAllLipsModuleFiles(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mLipsModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mLipsModules[index]).ModuleName, moduleName, false) == 0)
        {
          ((ModuleFileEntry) _mLipsModules[index]).ModuleFiles.Clear();
          break;
        }
        checked { ++index; }
      }
    }

    public ArrayList GetLipsModuleNames()
    {
      ArrayList arrayList = new ArrayList();
     
        foreach (ModuleFileEntry lipsModule in _mLipsModules)
          arrayList.Add(lipsModule.ModuleName);
   
      return arrayList;
    }

    public ArrayList GetLipsModuleFiles(int index)
    {
      if (_mLipsModules.Count >= index)
        return ((ModuleFileEntry) _mLipsModules[index]).ModuleFiles;
      return null;
    }

    public ArrayList GetLipsModuleFiles(string moduleName)
    {
      return ((ModuleFileEntry) _mLipsModules[GetLipsModuleIndex(moduleName)]).ModuleFiles;
    }

    public int RemoveLipsModuleFile(string moduleName, string filePath)
    {
      int num1 = 0;
      int num2 = checked (_mLipsModules.Count - 1);
      int index1 = num1;
      while (index1 <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mLipsModules[index1]).ModuleName, moduleName, false) == 0)
        {
          int index2 = ((ModuleFileEntry) _mLipsModules[index1]).ModuleFiles.IndexOf(filePath);
          if (index2 != -1)
          {
            ((ModuleFileEntry) _mLipsModules[index1]).ModuleFiles.RemoveAt(index2);
            return 0;
          }
        }
        ++index1; 
      }
      return -1;
    }

    public int GetStreamWavesModuleIndex(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mStreamWavesModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mStreamWavesModules[index]).ModuleName, moduleName, false) == 0)
          return index;
        ++index; 
      }
      return -1;
    }

    public void RemoveAllStreamWavesModules()
    {
      _mStreamWavesModules.Clear();
    }

    public int AddStreamWavesModule(string name)
    {
      return _mStreamWavesModules.Add(new ModuleFileEntry(name));
    }

    public int AddStreamWavesModuleFile(string moduleName, string filePath)
    {
      int num1 = 0;
      int num2 = checked (_mStreamWavesModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mStreamWavesModules[index]).ModuleName, moduleName, false) == 0)
        {
          ((ModuleFileEntry) _mStreamWavesModules[index]).ModuleFiles.Add(filePath); return 0;
        }
         ++index; 
      }
      return -1;
    }

    public void RemoveStreamWavesModule(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mStreamWavesModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mStreamWavesModules[index]).ModuleName, moduleName, false) == 0)
        {
          _mStreamWavesModules.RemoveAt(index);
          break;
        }
         ++index; 
      }
    }

    public void RemoveAllStreamWavesModuleFiles(string moduleName)
    {
      int num1 = 0;
      int num2 = checked (_mStreamWavesModules.Count - 1);
      int index = num1;
      while (index <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mStreamWavesModules[index]).ModuleName, moduleName, false) == 0)
        {
          ((ModuleFileEntry) _mStreamWavesModules[index]).ModuleFiles.Clear();
          break;
        }
         ++index; 
      }
    }

    public ArrayList GetStreamWavesModuleNames()
    {
      ArrayList arrayList = new ArrayList();
     
        foreach (ModuleFileEntry streamWavesModule in _mStreamWavesModules)
          arrayList.Add(streamWavesModule.ModuleName);
      
      return arrayList;
    }

    public ArrayList GetStreamWavesModuleFiles(int index)
    {
      return _mStreamWavesModules.Count >= index ? ((ModuleFileEntry) _mStreamWavesModules[index]).ModuleFiles : null;
    }

    public ArrayList GetStreamWavesModuleFiles(string moduleName)
    {
      return ((ModuleFileEntry) _mStreamWavesModules[GetStreamWavesModuleIndex(moduleName)]).ModuleFiles;
    }

    public int RemoveStreamWavesModuleFile(string moduleName, string filePath)
    {
      int num1 = 0;
      int num2 = checked (_mStreamWavesModules.Count - 1);
      int index1 = num1;
      while (index1 <= num2)
      {
        if (StringType.StrCmp(((ModuleFileEntry) _mStreamWavesModules[index1]).ModuleName, moduleName, false) == 0)
        {
          int index2 = ((ModuleFileEntry) _mStreamWavesModules[index1]).ModuleFiles.IndexOf(filePath);
          if (index2 != -1)
          {
            ((ModuleFileEntry) _mStreamWavesModules[index1]).ModuleFiles.RemoveAt(index2);
            return 0;
          }
        }
        ++index1; 
      }
      return -1;
    }

    public void RemoveAllStreamWavesFiles()
    {
      _mStreamWavesFiles.Clear();
    }

    public int RemoveStreamWavesFile(string filePath)
    {
      int index = _mStreamWavesFiles.IndexOf(filePath);
      if (index == -1)
        return -1;
      _mStreamWavesFiles.RemoveAt(index);
      return 0;
    }

    public int AddStreamWavesFile(string name)
    {
      return _mStreamWavesFiles.Add(name);
    }
  }
}
