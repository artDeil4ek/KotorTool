using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using KotorTool_2._0.Forms;
using KotorTool_2._0.Models.GFF;
using KotorTool_2._0.Options;
using KotorTool_2._0.Utils;
using KotorTool_2._0.ViewModels;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsDlg
    {
        public ArrayList StartingList;
        public ClsGff DlgGff;
        public TreeView Tv;
        private readonly ClsDialogTlk _clsDialogTlk;
        public ArrayList EntryNodeList;
        public ArrayList ReplyNodeList;
        private readonly Hashtable _nodeHt;
        public Options.ConfigOptions CurrentSettings;
        private readonly bool _isDebugMode;

        public ClsDlg(int kotorVerIndex)
        {
            _nodeHt = new Hashtable();
            _isDebugMode = false;
            CurrentSettings = UserSettings.GetSettings();
            _clsDialogTlk = new ClsDialogTlk(ConfigOptions.Paths.KotorLocation(kotorVerIndex) + "\\dialog.tlk");
        }

        public ClsDlg(ref TreeView extTv, int kotorVerIndex)
            : this(kotorVerIndex)
        {
            Tv = extTv;
            Tv.Nodes.Add(new DlgConvListNode("Root"));
            ((DlgConvListNode) Tv.Nodes[0]).IsReply = true;
            DlgGff = new ClsGff(kotorVerIndex);
            DlgGff.CreateList("", "EntryList");
            DlgGff.CreateList("", "ReplyList");
            DlgGff.CreateList("", "StartingList");
            DlgGff.CreateList("", "StuntList");
        }

        public ClsDlg(byte[] bytes, ref TreeView extTv, int kotorVerIndex)
            : this(kotorVerIndex)
        {
            DlgGff = new ClsGff(bytes, kotorVerIndex);
            Tv = extTv;
            LoadAndProcess();
        }

        public ClsDlg(FileStream fs, ref TreeView extTv, int kotorVerIndex)
            : this(kotorVerIndex)
        {
            DlgGff = new ClsGff(fs, kotorVerIndex);
        }

        public ClsDlg(string filepath, ref TreeView extTv, int kotorVerIndex)
            : this(kotorVerIndex)
        {
            DlgGff = new ClsGff(new FileStream(filepath, FileMode.Open, FileAccess.Read), kotorVerIndex);
            Tv = extTv;
            LoadAndProcess();
        }

        public override string ToString()
        {
            return DlgGff.ToString();
        }

        private void LoadAndProcess()
        {
            Tv.Nodes.Add(new DlgConvListNode("Root"));
            ((DlgConvListNode) Tv.Nodes[0]).IsReply = true;
            int num1 = 0;
            int num2 = checked(DlgGff.GetListItemCount("StartingList") - 1);
            int index = num1;
            while (index <= num2)
            {
                int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(
                    DlgGff.GetNodeValue("StartingList(" + StringType.FromInteger(index) + ").Index")));
                GffExoLocString nodeValue =
                    (GffExoLocString) DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Text");
                string str = nodeValue.StringRef != -1
                    ? _clsDialogTlk.GetString(nodeValue.StringRef)
                    : (nodeValue.StringCount <= 0 ? "" : ((GffExoLocSubString) nodeValue.SubStringArr[0]).Value);
                DlgConvListNode dlgConvListNode = new DlgConvListNode();
                dlgConvListNode.LinkId = int32;
                dlgConvListNode.LinkDesc = "S" + int32;
                _nodeHt.Add("E" + int32, "");
                dlgConvListNode.IsEntry = true;
                dlgConvListNode.NodeOriginalPath = "StartingList(" + StringType.FromInteger(index) + ")";
                dlgConvListNode.ForeColor = Color.Red;
                dlgConvListNode.ActiveScript =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("StartingList(" + StringType.FromInteger(index) + ").Active"));
                dlgConvListNode.Comment =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Comment"));
                dlgConvListNode.Delay =
                    (uint) (DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Delay") ??
                            Activator.CreateInstance(typeof(uint)));
                dlgConvListNode.InternalText = str;
                dlgConvListNode.Quest =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Quest"));
                dlgConvListNode.Sound =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Sound"));
                dlgConvListNode.Script =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Script"));
                dlgConvListNode.Speaker =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Speaker"));
                dlgConvListNode.VoResRef =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").VO_ResRef"));
                dlgConvListNode.SoundExists =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").SoundExists"));
                dlgConvListNode.PlotIndex =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").PlotIndex"));
                dlgConvListNode.PlotXpPercentage = DecimalType.FromObject(
                    DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").PlotXPPercentage"));
                dlgConvListNode.Listener =
                    StringType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").Listener"));
                dlgConvListNode.WaitFlags =
                    Convert.ToInt32(RuntimeHelpers.GetObjectValue(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").WaitFlags")));
                dlgConvListNode.CameraAngle =
                    Convert.ToInt32(RuntimeHelpers.GetObjectValue(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CameraAngle")));
                dlgConvListNode.CameraId =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CameraID"));
                dlgConvListNode.CamVidEffect =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CamVidEffect"));
                dlgConvListNode.FadeType =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeType"));
                dlgConvListNode.FadeDelay =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeDelay"));
                dlgConvListNode.FadeLength =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeLength"));
                dlgConvListNode.TarHeightOffset = DecimalType.FromObject(
                    DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").TarHeightOffset"));
                dlgConvListNode.CamHeightOffset = DecimalType.FromObject(
                    DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CamHeightOffset"));
                dlgConvListNode.FadeColor =
                    (GffType17) DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").FadeColor");
                dlgConvListNode.CamFieldOfView =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue("EntryList(" + StringType.FromInteger(int32) + ").CamFieldOfView"));
                if (DlgGff.VerifyNodeExists("EntryList(" + StringType.FromInteger(int32) + ").AnimList") &&
                    DlgGff.GetListItemCount("EntryList(" + StringType.FromInteger(int32) + ").AnimList") > 0)
                {
                    dlgConvListNode.Animlist = new ArrayList();
                    int num3 = 0;
                    int num4 = DlgGff.GetListItemCount("EntryList(" + StringType.FromInteger(int32) + ").AnimList") - 1;
                    int num5 = num3;

                    while (num5 <= num4)
                    {
                        dlgConvListNode.Animlist.Add(new frmCreateAnimListEntry());
                        ++num5;
                    }
                }

                dlgConvListNode.Text = dlgConvListNode.NodeDesc;
                Tv.Nodes[0].Nodes.Add(dlgConvListNode);
                BuildTv("EntryList(" + StringType.FromInteger(int32) + ")", (DlgConvListNode) Tv.Nodes[0].Nodes[index]);
                ++index;
            }

            EntryNodeList = new ArrayList();
            ReplyNodeList = new ArrayList();
            ScanTvForEntryNodes((DlgConvListNode) Tv.Nodes[0], "Root");
            ScanTvForLinkNodes((DlgConvListNode) Tv.Nodes[0], "Root");
        }

        public void BuildTv(string listItemPath, DlgConvListNode dlgNode)
        {
            string listName;
            string str1 = "";
            if (listItemPath.StartsWith("EntryList"))
            {
                listName = "RepliesList";
                str1 = "ReplyList";
            }
            else
            {
                listName = "EntriesList";
                str1 = "EntryList";
            }

            int num1 = 0;
            int num2 = checked(DlgGff.GetListItemCount(listItemPath + "." + listName) - 1);
            int index = num1;
            while (index <= num2)
            {
                DlgConvListNode dlgConvListNode1 = new DlgConvListNode();
                if (listItemPath.StartsWith("ReplyList"))
                {
                    dlgConvListNode1.ForeColor = Color.Red;
                    dlgConvListNode1.IsEntry = true;
                }
                else
                {
                    dlgConvListNode1.ForeColor = Color.Blue;
                    dlgConvListNode1.IsReply = true;
                }

                int num3 = IntegerType.FromObject(
                    DlgGff.GetNodeValue(listItemPath + "." + listName + "(" + StringType.FromInteger(index) +
                                        ").IsChild"));
                int int32 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(
                    DlgGff.GetNodeValue(listItemPath + "." + listName + "(" + StringType.FromInteger(index) +
                                        ").Index")));
                dlgConvListNode1.LinkId = int32;
                dlgConvListNode1.NodeOriginalPath = listItemPath;
                if (listItemPath.StartsWith("ReplyList"))
                {
                    dlgConvListNode1.LinkDesc = "E" + StringType.FromInteger(int32);
                    if ((uint) num3 > 0U)
                    {
                        DlgConvListNode dlgConvListNode2 = dlgConvListNode1;
                        dlgConvListNode2.LinkDesc = dlgConvListNode2.LinkDesc + " (L)";
                    }
                }
                else
                    dlgConvListNode1.LinkDesc = "R" + StringType.FromInteger(int32);

                GffExoLocString nodeValue =
                    (GffExoLocString) DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Text");
                if (nodeValue.StringRef == -1)
                {
                    if (nodeValue.StringCount > 0 && ((GffExoLocSubString) nodeValue.SubStringArr[0]).StringLength > 0)
                    {
                        GffExoLocSubString gffExoLocSubString = (GffExoLocSubString) nodeValue.SubStringArr[0];
                        dlgConvListNode1.InternalText = gffExoLocSubString.Value;
                    }
                    else
                        dlgConvListNode1.InternalText = "";
                }
                else
                    dlgConvListNode1.InternalText = _clsDialogTlk.GetString(nodeValue.StringRef);

                string str2 =
                    DlgGff.GetListItemCount(str1 + "(" + StringType.FromInteger(int32) + ")." +
                                            GetOppositeRepliesListName(listName)) != 0
                        ? (dlgConvListNode1.InternalText.Length != 0 ? dlgConvListNode1.InternalText : "[CONTINUE]")
                        : dlgConvListNode1.InternalText + "[END DIALOGUE]";
                dlgConvListNode1.ActiveScript = StringType.FromObject(
                    DlgGff.GetNodeValue(
                        listItemPath + "." + listName + "(" + StringType.FromInteger(index) + ").Active"));
                dlgConvListNode1.Comment =
                    StringType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Comment"));
                dlgConvListNode1.Delay =
                    (uint) (DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Delay") ??
                            Activator.CreateInstance(typeof(uint)));
                dlgConvListNode1.Quest =
                    StringType.FromObject(DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Quest"));
                if (StringType.StrCmp(dlgConvListNode1.Quest, "", false) != 0)
                    dlgConvListNode1.QuestEntry =
                        (uint) (DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").QuestEntry") ??
                                Activator.CreateInstance(typeof(uint)));
                dlgConvListNode1.Sound =
                    StringType.FromObject(DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Sound"));
                dlgConvListNode1.Script =
                    StringType.FromObject(DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Script"));
                dlgConvListNode1.Speaker =
                    StringType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Speaker"));
                dlgConvListNode1.VoResRef =
                    StringType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").VO_ResRef"));
                dlgConvListNode1.SoundExists =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").SoundExists"));
                dlgConvListNode1.PlotIndex =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").PlotIndex"));
                dlgConvListNode1.PlotXpPercentage =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").PlotXPPercentage"));
                dlgConvListNode1.Listener =
                    StringType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").Listener"));
                dlgConvListNode1.WaitFlags =
                    Convert.ToInt32(RuntimeHelpers.GetObjectValue(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").WaitFlags")));
                dlgConvListNode1.CameraAngle =
                    Convert.ToInt32(RuntimeHelpers.GetObjectValue(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CameraAngle")));
                dlgConvListNode1.CameraId =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CameraID"));
                dlgConvListNode1.CamVidEffect =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CamVidEffect"));
                dlgConvListNode1.FadeType =
                    IntegerType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeType"));
                dlgConvListNode1.FadeDelay =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeDelay"));
                dlgConvListNode1.FadeLength =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeLength"));
                dlgConvListNode1.TarHeightOffset =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").TarHeightOffset"));
                dlgConvListNode1.CamHeightOffset =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CamHeightOffset"));
                dlgConvListNode1.FadeColor =
                    (GffType17) DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").FadeColor");
                dlgConvListNode1.CamFieldOfView =
                    DecimalType.FromObject(
                        DlgGff.GetNodeValue(str1 + "(" + StringType.FromInteger(int32) + ").CamFieldOfView"));
                bool flag = true;
                string str3 = !(!listItemPath.StartsWith("EntryList") & !flag)
                    ? ""
                    : (StringType.StrCmp(dlgConvListNode1.Speaker, "", false) != 0
                        ? "[" + dlgConvListNode1.Speaker + "] - "
                        : "[OWNER] - ");
                if (num3 == 0)
                {
                    dlgConvListNode1.Text = str3 + str2;
                    dlgConvListNode1.IsLink = 0;
                }
                else
                {
                    dlgConvListNode1.IsLink = 1;
                    dlgConvListNode1.Text = str3 + str2 + " (Link)";
                    dlgConvListNode1.LinkedToIndex = int32;
                    dlgConvListNode1.ForeColor = Color.Gray;
                }

                dlgNode.Nodes.Add(dlgConvListNode1);
                if (num3 == 0)
                {
                    if (_isDebugMode)
                        Console.WriteLine("Parent Node " + dlgNode.LinkDesc + " of Node " + dlgConvListNode1.LinkDesc +
                                          " is not a link, scanning children...");
                    BuildTv(str1 + "(" + StringType.FromInteger(int32) + ")", (DlgConvListNode) dlgNode.Nodes[index]);
                }
                else if (_isDebugMode)
                    Console.WriteLine("Node " + dlgNode.LinkDesc + " of Node " + dlgConvListNode1.LinkDesc +
                                      " is a link, scanning children skipped");

                checked
                {
                    ++index;
                }
            }
        }

        private void ScanTvForEntryNodes(DlgConvListNode innode, string currNodeType)
        {
            foreach (DlgConvListNode node in innode.Nodes)
            {
                if ((uint) ~node.IsLink > 0U)
                {
                    if (StringType.StrCmp(currNodeType, "Entry", false) == 0)
                    {
                        ReplyNodeList.Add(node);
                        ScanTvForEntryNodes(node, "Reply");
                    }
                    else
                    {
                        EntryNodeList.Add(node);
                        ScanTvForEntryNodes(node, "Entry");
                    }
                }
            }
        }

        private void DumpLists()
        {
            DlgConvListNode dlgConvListNode;

            foreach (DlgConvListNode entryNode in EntryNodeList)
            {
                if (entryNode.LinkedNodesList != null)
                {
                    foreach (DlgConvListNode linkedNodes in entryNode.LinkedNodesList)
                        dlgConvListNode = linkedNodes;
                }

                if (entryNode.IsLink != 1)
                    ;
            }


            foreach (DlgConvListNode replyNode in ReplyNodeList)
            {
                if (replyNode.LinkedNodesList != null)
                {
                    foreach (DlgConvListNode linkedNodes in replyNode.LinkedNodesList)
                        dlgConvListNode = linkedNodes;


                    IEnumerator enumerator = null;
                }

                if (replyNode.IsLink != 1)
                    ;
            }
        }

        private void ScanTvForLinkNodes(DlgConvListNode innode, string currNodeType)
        {
            foreach (DlgConvListNode node in innode.Nodes)
            {
                if (StringType.StrCmp(currNodeType, "Entry", false) == 0)
                {
                    if (node.IsLink == 1)
                    {
                        node.LinkedToNode = FindNodeInListByLinkId(ReplyNodeList, node.LinkedToIndex);
                        if (node.Text != null)
                            ;
                        if (node.LinkedToNode.LinkedNodesList == null)
                            node.LinkedToNode.LinkedNodesList = new ArrayList();
                        node.LinkedToNode.LinkedNodesList.Add(node);
                    }

                    ScanTvForLinkNodes(node, "Reply");
                }
                else
                {
                    if (node.IsLink == 1)
                    {
                        node.LinkedToNode = FindNodeInListByLinkId(EntryNodeList, node.LinkedToIndex);
                        if (node.Text != null)
                            ;
                        if (node.LinkedToNode.LinkedNodesList == null)
                            node.LinkedToNode.LinkedNodesList = new ArrayList();
                        node.LinkedToNode.LinkedNodesList.Add(node);
                    }

                    ScanTvForLinkNodes(node, "Entry");
                }
            }
        }

        private DlgConvListNode FindNodeInListByLinkId(ArrayList list, int id)
        {
            DlgConvListNode dlgConvListNode1 = null;
            foreach (DlgConvListNode dlgConvListNode2 in list)
            {
                if (dlgConvListNode2.LinkId == id)
                {
                    dlgConvListNode1 = dlgConvListNode2;
                    break;
                }
            }

            return dlgConvListNode1;
        }

        private string GetOppositeMainListName(string listName)
        {
            return StringType.StrCmp(listName, "EntryList", false) == 0 ? "ReplyList" : "EntryList";
        }

        private string GetOppositeRepliesListName(string listName)
        {
            return StringType.StrCmp(listName, "EntriesList", false) == 0 ? "RepliesList" : "EntriesList";
        }
    }
}