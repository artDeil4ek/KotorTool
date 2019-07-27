using System;
using System.Collections;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class ModuleFileEntry
  {


      public string ModuleName { get; set; }
      public string PackageType { get; set; }


      [XmlArrayItem(typeof(string))]
      [XmlArray]
      public ArrayList ModuleFiles { get; set; }



      public ModuleFileEntry()
      {
          PackageType = "MOD";
          ModuleName = "";
          ModuleFiles = new ArrayList();
      }



      public ModuleFileEntry(string name) : this()
      {
          ModuleName = name;
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
