using System.IO;
using System.Windows.Forms;

namespace KotorTool_2._0
{
  public class ProjectFileItemTreeNode : TreeNode
  {
    private string _mFilePath;

    public string Filename
    {
      get => Path.GetFileName(_mFilePath);
      set => _mFilePath = Path.GetDirectoryName(_mFilePath) + value;
    }

    public string FilePath
    {
      get => _mFilePath;
      set => _mFilePath = value;
    }

    public ProjectFileItemTreeNode(string nodeName) : base(nodeName)
    {
    }

    public ProjectFileItemTreeNode(string nodeName, ProjectFileItemTreeNode[] nodeArray) : base(nodeName, nodeArray)
    {
    }

    public override string ToString()
    {
      return Text;
    }
  }
}
