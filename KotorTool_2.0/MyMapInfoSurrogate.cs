using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0
{
  public class MyMapInfoSurrogate : ISerializationSurrogate, ISurrogateSelector
  {
    private readonly Assembly _assemblyToMigrate;

    public MyMapInfoSurrogate(Assembly assemblyToMigrate)
    {
      _assemblyToMigrate = assemblyToMigrate;
    }

    public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
    {
      string empty = string.Empty;
      foreach (SerializationEntry serializationEntry in info)
      {
        string name = serializationEntry.Name;
        Type type;
        if (name.IndexOf("+", StringComparison.Ordinal) != -1)
        {
          string[] strArray = name.Split("+".ToCharArray());
          string sRight = strArray[0];
          name = strArray[1];
          type = obj.GetType();
          while (StringType.StrCmp(type.Name, sRight, false) != 0) type = type.BaseType;
        }
        else
          type = obj.GetType();

        MemberInfo[] member = type.GetMember(name, MemberTypes.Field, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        if (member.Length > 0)
        {
          FieldInfo fieldInfo = (FieldInfo) member[0];
          object objectValue = RuntimeHelpers.GetObjectValue(serializationEntry.Value);
          if (objectValue != null && !fieldInfo.FieldType.IsInstanceOfType(RuntimeHelpers.GetObjectValue(objectValue))) objectValue = RuntimeHelpers.GetObjectValue(Convert.ChangeType(RuntimeHelpers.GetObjectValue(objectValue), fieldInfo.FieldType));
          fieldInfo.SetValue(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(objectValue));
        }
      }

      return null;
    }

    public void GetObjectData(object entity, SerializationInfo info, StreamingContext context)
    {
      throw new NotImplementedException();
    }

    public ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, ref ISurrogateSelector selector)
    {
      if (type.Assembly == _assemblyToMigrate)
      {
        selector = this;
        return this;
      }

      selector = null;
      return null;
    }

    public ISurrogateSelector GetNextSelector()
    {
      return null;
    }

    
    
    public void ChainSelector(ISurrogateSelector selector)
    {
      throw new NotImplementedException("ChainSelector not supported");
    }

        void ISurrogateSelector.ChainSelector(ISurrogateSelector selector)
        {
            throw new NotImplementedException();
        }

        ISerializationSurrogate ISurrogateSelector.GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
        {
            throw new NotImplementedException();
        }

        ISurrogateSelector ISurrogateSelector.GetNextSelector()
        {
            throw new NotImplementedException();
        }
    }
}
