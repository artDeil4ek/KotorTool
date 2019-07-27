using System;
using System.Collections;
using KotorTool_2._0.Models.GFF;

namespace KotorTool_2._0.ViewModels.Models
{
    public class DialogConversationListNodeViewModel
    {

        public ArrayList AnimationList;
        public string ActiveScript;
        public int CameraAngle;
        public int CameraId;
        public Decimal CameraHeightOffset;
        public Decimal CameraFieldOfView;
        public int CameraVidEffect;
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
        public string VoiceResourceRef;
        public int WaitFlags;
        public byte IsLink;
        public int LinkId;
        public int LinkedToIndex;
        public ArrayList LinkedNodesList;
        public DlgConvListNode LinkedToNode;
        public bool IsEntry;
        public bool IsReply;
        public string LinkDesc;
        public string NodeOriginalPath;

    }
}