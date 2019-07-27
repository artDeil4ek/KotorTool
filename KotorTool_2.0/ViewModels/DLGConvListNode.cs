using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using KotorTool_2._0.Models.GFF;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.ViewModels
{
  public class DlgConvListNode : TreeNode
  {
    public ArrayList Animlist;
    public string ActiveScript;
    public int CameraAngle;
    public int CameraId;
    public Decimal CamHeightOffset;
    public Decimal CamFieldOfView;
    public int CamVidEffect;
    public string Comment;
    public uint Delay;
    public int FadeType;
    public Decimal FadeDelay;
    public Decimal FadeLength;
    public GffType17 FadeColor;
    public string InternalText;
    public string Listener;
    public int PlotIndex;
    public Decimal PlotXpPercentage;
    public string Quest;
    public uint QuestEntry;
    public string Script;
    public string Speaker;
    public string Sound;
    public int SoundExists;
    public Decimal TarHeightOffset;
    public string VoResRef;
    public int WaitFlags;
    public byte IsLink;
    public int LinkId;
    public int LinkedToIndex;
    public ArrayList LinkedNodesList;
    public DlgConvListNode LinkedToNode;
    private bool _mIsEntry;
    private bool _mIsReply;
    public string LinkDesc;
    public string NodeOriginalPath;

    public Color DialogColor
    {
      get
      {
        if ((uint) IsLink > 0U)
          return Color.Gray;
        if (IsEntry)
          return Color.Red;
        return Color.Blue;
      }
    }

    public bool IsEndDialog => IsReply & Nodes.Count == 0;

    public bool IsContinueDialog => StringType.StrCmp(InternalText, "", false) == 0 & Nodes.Count > 0;

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
            str2 = StringType.StrCmp(Speaker, "", false) != 0 ? "[" + Speaker + "] - " : "[OWNER] - ";
          str1 = str2 + InternalText;
          if ((uint) IsLink > 0U)
            str1 += " (Link)";
          else if (IsEndDialog)
            str1 += " [END DIALOGUE]";
        }
        return str1;
      }
    }

    public bool IsReply
    {
      get => _mIsReply;
      set
      {
        _mIsReply = value;
        _mIsEntry = !value;
      }
    }

    public bool IsEntry
    {
      get => _mIsEntry;
      set
      {
        _mIsEntry = value;
        _mIsReply = !value;
      }
    }

    private bool HasLinkedNodes => LinkedNodesList != null && LinkedNodesList.Count > 0;

    public DlgConvListNode()
    {
      Script = "";
      Speaker = "";
      ActiveScript = "";
      InternalText = "";
      Comment = "";
      Sound = "";
      VoResRef = "";
      Listener = "";
      PlotIndex = -1;
      CamVidEffect = -1;
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
        foreach (DlgConvListNode linkedNodes in LinkedNodesList)
        {
          linkedNodes.InternalText = InternalText;
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
      DlgConvListNode dlgConvListNode = new DlgConvListNode();
      dlgConvListNode.Speaker = Speaker;
      dlgConvListNode.ActiveScript = ActiveScript;
      dlgConvListNode.Text = Text;
      dlgConvListNode.InternalText = InternalText;
      dlgConvListNode.Script = Script;
      dlgConvListNode.Delay = Delay;
      dlgConvListNode.Comment = Comment;
      dlgConvListNode.Sound = Sound;
      dlgConvListNode.Quest = Quest;
      dlgConvListNode.QuestEntry = QuestEntry;
      dlgConvListNode.VoResRef = VoResRef;
      dlgConvListNode.PlotIndex = PlotIndex;
      dlgConvListNode.PlotXpPercentage = PlotXpPercentage;
      dlgConvListNode.Listener = Listener;
      dlgConvListNode.WaitFlags = WaitFlags;
      dlgConvListNode.CameraAngle = CameraAngle;
      dlgConvListNode.CamFieldOfView = CamFieldOfView;
      dlgConvListNode.FadeType = FadeType;
      dlgConvListNode.FadeDelay = FadeDelay;
      dlgConvListNode.FadeLength = FadeLength;
      dlgConvListNode.FadeColor = FadeColor;
      dlgConvListNode.TarHeightOffset = TarHeightOffset;
      dlgConvListNode.CamHeightOffset = CamHeightOffset;
      dlgConvListNode.SoundExists = SoundExists;
      if (LinkedNodesList != null) dlgConvListNode.LinkedNodesList = (ArrayList) LinkedNodesList.Clone();
      dlgConvListNode.LinkedToNode = LinkedToNode;
      dlgConvListNode.IsEntry = IsEntry;
      dlgConvListNode.IsReply = IsReply;
      dlgConvListNode.IsLink = IsLink;
      return dlgConvListNode;
    }
  }
}
