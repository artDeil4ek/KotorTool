using System.IO;
using KotorTool_2._0.Models.GFF;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsUtc : ClsGff
    {




        /// <summary>
        /// 
        /// </summary>
        /// <param name="kotorVerIndex"></param>
        public ClsUtc(int kotorVerIndex) : base(kotorVerIndex)
        {
            KotorVersionIndex = kotorVerIndex;
        }
      
        
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fs"></param>
        /// <param name="kotorVerIndex"></param>
        public ClsUtc(FileStream fs, int kotorVerIndex) : base(fs, kotorVerIndex)
        {
        }
      
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="kotorVerIndex"></param>
        public ClsUtc(byte[] bytes, int kotorVerIndex) : base(bytes, kotorVerIndex)
        {
        }


        /// <summary>
        /// WTF is this
        /// </summary>
        public void CreateEmptyShell()
        {
            GStructArray = new object[40];
            LateBinding.LateIndexSet(GStructArray, new object[2] { 0, new GffStruct() }, null);
            StructArray(0).Type = -1;
            StructArray(0).FieldCount = 69;
            StructArray(0).Fields = (GffField[])new object[69];
            StructArray(0).Fields[0] = new GffField(GffFieldTypes.GffCResRef, "TemplateResRef", null);
            StructArray(0).Fields[1] = new GffField(GffFieldTypes.GffByte, "Race", null);
            StructArray(0).Fields[2] = new GffField(GffFieldTypes.GffByte, "SubraceIndex", null);
            StructArray(0).Fields[3] = new GffField(GffFieldTypes.GffCExoLocString, "FirstName", null);
            StructArray(0).Fields[4] = new GffField(GffFieldTypes.GffCExoLocString, "LastName", null);
            StructArray(0).Fields[5] = new GffField(GffFieldTypes.GffWord, "Appearance_Type", null);
            StructArray(0).Fields[6] = new GffField(GffFieldTypes.GffByte, "Gender", null);
            StructArray(0).Fields[7] = new GffField(GffFieldTypes.GffInt, "Phenotype", null);
            StructArray(0).Fields[8] = new GffField(GffFieldTypes.GffInt, "PortraitId", null);
            StructArray(0).Fields[9] = new GffField(GffFieldTypes.GffCExoLocString, "Description", null);
            StructArray(0).Fields[10] = new GffField(GffFieldTypes.GffCExoLocString, "Tag", null);
            StructArray(0).Fields[11] = new GffField(GffFieldTypes.GffCResRef, "Conversation", null);
            StructArray(0).Fields[12] = new GffField(GffFieldTypes.GffByte, "IsPC", null);
            StructArray(0).Fields[13] = new GffField(GffFieldTypes.GffWord, "FactionID", null);
            StructArray(0).Fields[14] = new GffField(GffFieldTypes.GffByte, "Disarmable", null);
            StructArray(0).Fields[15] = new GffField(GffFieldTypes.GffCExoLocString, "Subrace", null);
            StructArray(0).Fields[16] = new GffField(GffFieldTypes.GffCExoLocString, "Deity", null);
            StructArray(0).Fields[17] = new GffField(GffFieldTypes.GffWord, "SoundSetFile", null);
            StructArray(0).Fields[18] = new GffField(GffFieldTypes.GffByte, "Plot", null);
            StructArray(0).Fields[19] = new GffField(GffFieldTypes.GffByte, "Interruptable", null);
            StructArray(0).Fields[20] = new GffField(GffFieldTypes.GffByte, "NoPermDeath", null);
            StructArray(0).Fields[21] = new GffField(GffFieldTypes.GffByte, "NotReorienting", null);
            StructArray(0).Fields[22] = new GffField(GffFieldTypes.GffByte, "BodyBag", null);
            StructArray(0).Fields[23] = new GffField(GffFieldTypes.GffByte, "BodyVariation", null);
            StructArray(0).Fields[24] = new GffField(GffFieldTypes.GffByte, "TextureVar", null);
            StructArray(0).Fields[25] = new GffField(GffFieldTypes.GffByte, "Min1HP", null);
            StructArray(0).Fields[26] = new GffField(GffFieldTypes.GffByte, "PartyInteract", null);
            StructArray(0).Fields[27] = new GffField(GffFieldTypes.GffByte, "Str", null);
            StructArray(0).Fields[28] = new GffField(GffFieldTypes.GffByte, "Dex", null);
            StructArray(0).Fields[29] = new GffField(GffFieldTypes.GffByte, "Con", null);
            StructArray(0).Fields[30] = new GffField(GffFieldTypes.GffByte, "Int", null);
            StructArray(0).Fields[31] = new GffField(GffFieldTypes.GffByte, "Wis", null);
            StructArray(0).Fields[32] = new GffField(GffFieldTypes.GffByte, "Cha", null);
            StructArray(0).Fields[33] = new GffField(GffFieldTypes.GffInt, "WalkRate", null);
            StructArray(0).Fields[34] = new GffField(GffFieldTypes.GffByte, "NaturalAC", null);
            StructArray(0).Fields[35] = new GffField(GffFieldTypes.GffShort, "HitPoints", null);
            StructArray(0).Fields[36] = new GffField(GffFieldTypes.GffShort, "CurrentHitPoints", null);
            StructArray(0).Fields[37] = new GffField(GffFieldTypes.GffShort, "MaxHitPoints", null);
            StructArray(0).Fields[38] = new GffField(GffFieldTypes.GffShort, "ForcePoints", null);
            StructArray(0).Fields[39] = new GffField(GffFieldTypes.GffShort, "CurrentForce", null);
            StructArray(0).Fields[40] = new GffField(GffFieldTypes.GffShort, "refbonus", null);
            StructArray(0).Fields[41] = new GffField(GffFieldTypes.GffShort, "willbonus", null);
            StructArray(0).Fields[42] = new GffField(GffFieldTypes.GffShort, "fortbonus", null);
            StructArray(0).Fields[43] = new GffField(GffFieldTypes.GffFloat, "GoodEvil", null);
            StructArray(0).Fields[44] = new GffField(GffFieldTypes.GffFloat, "LawfulChaotic", null);
            StructArray(0).Fields[45] = new GffField(GffFieldTypes.GffFloat, "ChallengeRating", null);
            StructArray(0).Fields[46] = new GffField(GffFieldTypes.GffFloat, "PerceptionRange", null);
            StructArray(0).Fields[47] = new GffField(GffFieldTypes.GffCResRef, "ScriptHeartbeat", null);
            StructArray(0).Fields[48] = new GffField(GffFieldTypes.GffCResRef, "ScriptOnNotice", null);
            StructArray(0).Fields[49] = new GffField(GffFieldTypes.GffCResRef, "ScriptSpellAt", null);
            StructArray(0).Fields[50] = new GffField(GffFieldTypes.GffCResRef, "ScriptAttacked", null);
            StructArray(0).Fields[51] = new GffField(GffFieldTypes.GffCResRef, "ScriptDamaged", null);
            StructArray(0).Fields[52] = new GffField(GffFieldTypes.GffCResRef, "ScriptDisturbed", null);
            StructArray(0).Fields[53] = new GffField(GffFieldTypes.GffCResRef, "ScriptEndRound", null);
            StructArray(0).Fields[54] = new GffField(GffFieldTypes.GffCResRef, "ScriptEndDialogue", null);
            StructArray(0).Fields[55] = new GffField(GffFieldTypes.GffCResRef, "ScriptDialogue", null);
            StructArray(0).Fields[56] = new GffField(GffFieldTypes.GffCResRef, "ScriptSpawn", null);
            StructArray(0).Fields[57] = new GffField(GffFieldTypes.GffCResRef, "ScriptRested", null);
            StructArray(0).Fields[58] = new GffField(GffFieldTypes.GffCResRef, "ScriptDeath", null);
            StructArray(0).Fields[59] = new GffField(GffFieldTypes.GffCResRef, "ScriptUserDefine", null);
            StructArray(0).Fields[60] = new GffField(GffFieldTypes.GffCResRef, "ScriptOnBlocked", null);
            StructArray(0).Fields[61] = new GffField(GffFieldTypes.GffList, "SkillList", null);
            StructArray(0).Fields[62] = new GffField(GffFieldTypes.GffList, "FeatList", null);
            StructArray(0).Fields[63] = new GffField(GffFieldTypes.GffList, "TemplateList", null);
            StructArray(0).Fields[64] = new GffField(GffFieldTypes.GffList, "SpecAbilityList", null);
            StructArray(0).Fields[65] = new GffField(GffFieldTypes.GffList, "ClassList", null);
            StructArray(0).Fields[66] = new GffField(GffFieldTypes.GffList, "Equip_ItemList", null);
            StructArray(0).Fields[67] = new GffField(GffFieldTypes.GffCExoString, "PaletteID", null);
            StructArray(0).Fields[68] = new GffField(GffFieldTypes.GffCExoString, "Comment", null);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private GffStruct StructArray(object n)
        {
            return ((GffStruct[])GStructArray)[IntegerType.FromObject(n)];
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GffStruct[] StructArray()
        {
            return (GffStruct[])GStructArray;
        }
    }
}
