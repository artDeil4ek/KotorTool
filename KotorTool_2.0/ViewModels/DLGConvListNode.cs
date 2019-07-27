using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using KotorTool_2._0.ViewModels.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class DlgConvListNode : TreeNode
  {
      public DialogConversationListNodeViewModel vm;
   

    public Color DialogColor
    {
      get
      {
        if ((uint) vm.IsLink > 0U)
          return Color.Gray;
        if (IsEntry)
          return Color.Red;
        return Color.Blue;
      }
    }

    public bool IsEndDialog => IsReply & Nodes.Count == 0;

    public bool IsContinueDialog => StringType.StrCmp(vm.InternalText, "", false) == 0 & Nodes.Count > 0;

    public string NodeDesc
    {
      get
      {
        string str1;
        if (IsContinueDialog)
        {
          str1 = "[CONTINUE]";
        }
        else
        {
          string str2 = "";
          if (IsEntry)
            str2 = StringType.StrCmp(vm.Speaker, "", false) != 0 ? "[" + vm.Speaker + "] - " : "[OWNER] - ";
          str1 = str2 + vm.InternalText;
          if ((uint) vm.IsLink > 0U)
            str1 += " (Link)";
          else if (IsEndDialog)
            str1 += " [END DIALOGUE]";
        }
        return str1;
      }
    }

    public bool IsReply
    {
      get => vm.IsReply;
      set
      {
        vm.IsReply = value;
        vm.IsEntry = !value;
      }
    }

    public bool IsEntry
    {
      get => vm.IsEntry;
      set
      {
        vm.IsEntry = value;
        vm.IsReply = !value;
      }
    }

    private bool HasLinkedNodes => vm.LinkedNodesList != null && vm.LinkedNodesList.Count > 0;

    public DlgConvListNode()
    {
        vm.Script = "";
        vm.Speaker = "";
        vm.ActiveScript = "";
        vm.InternalText = "";
        vm.Comment = "";
        vm.Sound = "";
        vm.VoiceResourceRef = "";
        vm.Listener = "";
        vm.PlotIndex = -1;
        vm.CameraVidEffect = -1;
    }

    public DlgConvListNode(string nodeText)
      : base(nodeText)
    {
    }

    public void UpdateLinkedNodesText()
    {
      if (!HasLinkedNodes)
        return;
      try
      {
        foreach (DlgConvListNode linkedNodes in vm.LinkedNodesList)
        {
          linkedNodes.vm.InternalText = vm.InternalText;
          linkedNodes.Text = linkedNodes.NodeDesc;
        }
      }
      finally
      {
        IEnumerator enumerator = null;
      }
    }

    public DlgConvListNode Copy()
    {
        DlgConvListNode dlgConvListNode = new DlgConvListNode
        {
            vm = {Speaker = vm.Speaker, ActiveScript = vm.ActiveScript}, Text = Text
        };
        dlgConvListNode.vm.InternalText = vm.InternalText;
      dlgConvListNode.vm.Script = vm.Script;
      dlgConvListNode.vm.Delay = vm.Delay;
      dlgConvListNode.vm.Comment = vm.Comment;
      dlgConvListNode.vm.Sound = vm.Sound;
      dlgConvListNode.vm.Quest = vm.Quest;
      dlgConvListNode.vm.QuestEntry = vm.QuestEntry;
      dlgConvListNode.vm.VoiceResourceRef = vm.VoiceResourceRef;
      dlgConvListNode.vm.PlotIndex = vm.PlotIndex;
      dlgConvListNode.vm.PlotXpPercentage = vm.PlotXpPercentage;
      dlgConvListNode.vm.Listener = vm.Listener;
      dlgConvListNode.vm.WaitFlags = vm.WaitFlags;
      dlgConvListNode.vm.CameraAngle = vm.CameraAngle;
      dlgConvListNode.vm.CameraFieldOfView = vm.CameraFieldOfView;
      dlgConvListNode.vm.FadeType = vm.FadeType;
      dlgConvListNode.vm.FadeDelay = vm.FadeDelay;
      dlgConvListNode.vm.FadeLength = vm.FadeLength;
      dlgConvListNode.vm.FadeColor = vm.FadeColor;
      dlgConvListNode.vm.TarHeightOffset = vm.TarHeightOffset;
      dlgConvListNode.vm.CameraHeightOffset = vm.CameraHeightOffset;
      dlgConvListNode.vm.SoundExists = vm.SoundExists;
      if (vm.LinkedNodesList != null) dlgConvListNode.vm.LinkedNodesList = (ArrayList) vm.LinkedNodesList.Clone();
      dlgConvListNode.vm.LinkedToNode = vm.LinkedToNode;
      dlgConvListNode.IsEntry = IsEntry;
      dlgConvListNode.IsReply = IsReply;
      dlgConvListNode.vm.IsLink = vm.IsLink;
      return dlgConvListNode;
    }
  }
}
