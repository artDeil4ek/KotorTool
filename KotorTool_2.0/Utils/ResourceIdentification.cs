using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Utils
{
    public class ResourceIdentification
    {
        public static string ParentDescForResType(int resType)
        {
            switch (resType)
            {
                case 3: return "TGA Images";
                case 4: return "WAV Files";
                case 2002: return "Aurora Model";
                case 2009: return "Script, Source";
                case 2010: return "Script, Compiled";
                case 2011: return "Module";
                case 2012: return "Static Area Info";
                case 2014: return "Module Info File";
                case 2016: return "Walkmesh";
                case 2017: return "2D Array";
                case 2022: return "Extra Texture info";
                case 2023: return "Dynamic Area Info";
                case 2025: return "Blueprint, Item";
                case 2027: return "Blueprint, Character";
                case 2029: return "Dialog";
                case 2030: return "Blueprint Palette File";
                case 2032: return "Blueprint, Triggers";
                case 2035: return "Blueprint, Sound";
                case 2036: return "Letter-combo Probability File";
                case 2038: return "Faction File";
                case 2040: return "Blueprint, Encounter";
                case 2042: return "Blueprint, Doors";
                case 2044: return "Blueprint, Placeables";
                case 2047: return "GUI Elements";
                case 2051: return "Blueprint, Merchant";
                case 2052: return "Door Walkmesh";
                case 2053: return "Placeable Object Walkmesh";
                case 2055: return "Blueprint, ";
                case 2056: return "Journal File";
                case 2058: return "Blueprint, Waypoint";
                case 2060: return "Sound Sets";
                case 3000: return "Layouts";
                case 3003: return "Paths";
                case 3007: return "PC Textures";
                case 3008: return "Aurora Model Extension";
                default: return GetRsrcTypeForId(resType);
            }
        }

        public static short GetIdForRsrcType(string type)
        {
            string sLeft = type;
            if (StringType.StrCmp(sLeft, "res", false) == 0) return 0;
            if (StringType.StrCmp(sLeft, "bmp", false) == 0) return 1;
            if (StringType.StrCmp(sLeft, "mve", false) == 0) return 2;
            if (StringType.StrCmp(sLeft, "tga", false) == 0) return 3;
            if (StringType.StrCmp(sLeft, "wav", false) == 0) return 4;
            if (StringType.StrCmp(sLeft, "plt", false) == 0) return 6;
            if (StringType.StrCmp(sLeft, "ini", false) == 0) return 7;
            if (StringType.StrCmp(sLeft, "mp3", false) == 0) return 8;
            if (StringType.StrCmp(sLeft, "mpg", false) == 0) return 9;
            if (StringType.StrCmp(sLeft, "txt", false) == 0) return 10;
            if (StringType.StrCmp(sLeft, "wma", false) == 0) return 11;
            if (StringType.StrCmp(sLeft, "wmv", false) == 0) return 12;
            if (StringType.StrCmp(sLeft, "xmv", false) == 0) return 13;
            if (StringType.StrCmp(sLeft, "plh", false) == 0) return 2000;
            if (StringType.StrCmp(sLeft, "tex", false) == 0) return 2001;
            if (StringType.StrCmp(sLeft, "mdl", false) == 0) return 2002;
            if (StringType.StrCmp(sLeft, "thg", false) == 0) return 2003;
            if (StringType.StrCmp(sLeft, "fnt", false) == 0) return 2005;
            if (StringType.StrCmp(sLeft, "lua", false) == 0) return 2007;
            if (StringType.StrCmp(sLeft, "slt", false) == 0) return 2008;
            if (StringType.StrCmp(sLeft, "nss", false) == 0) return 2009;
            if (StringType.StrCmp(sLeft, "ncs", false) == 0) return 2010;
            if (StringType.StrCmp(sLeft, "mod", false) == 0) return 2011;
            if (StringType.StrCmp(sLeft, "are", false) == 0) return 2012;
            if (StringType.StrCmp(sLeft, "set", false) == 0) return 2013;
            if (StringType.StrCmp(sLeft, "ifo", false) == 0) return 2014;
            if (StringType.StrCmp(sLeft, "bic", false) == 0) return 2015;
            if (StringType.StrCmp(sLeft, "wok", false) == 0) return 2016;
            if (StringType.StrCmp(sLeft, "2da", false) == 0) return 2017;
            if (StringType.StrCmp(sLeft, "tlk", false) == 0) return 2018;
            if (StringType.StrCmp(sLeft, "txi", false) == 0) return 2022;
            if (StringType.StrCmp(sLeft, "git", false) == 0) return 2023;
            if (StringType.StrCmp(sLeft, "bti", false) == 0) return 2024;
            if (StringType.StrCmp(sLeft, "uti", false) == 0) return 2025;
            if (StringType.StrCmp(sLeft, "btc", false) == 0) return 2026;
            if (StringType.StrCmp(sLeft, "utc", false) == 0) return 2027;
            if (StringType.StrCmp(sLeft, "dlg", false) == 0) return 2029;
            if (StringType.StrCmp(sLeft, "itp", false) == 0) return 2030;
            if (StringType.StrCmp(sLeft, "btt", false) == 0) return 2031;
            if (StringType.StrCmp(sLeft, "utt", false) == 0) return 2032;
            if (StringType.StrCmp(sLeft, "dds", false) == 0) return 2033;
            if (StringType.StrCmp(sLeft, "bts", false) == 0) return 2034;
            if (StringType.StrCmp(sLeft, "uts", false) == 0) return 2035;
            if (StringType.StrCmp(sLeft, "ltr", false) == 0) return 2036;
            if (StringType.StrCmp(sLeft, "gff", false) == 0) return 2037;
            if (StringType.StrCmp(sLeft, "fac", false) == 0) return 2038;
            if (StringType.StrCmp(sLeft, "bts", false) == 0) return 2039;
            if (StringType.StrCmp(sLeft, "ute", false) == 0) return 2040;
            if (StringType.StrCmp(sLeft, "btd", false) == 0) return 2041;
            if (StringType.StrCmp(sLeft, "utd", false) == 0) return 2042;
            if (StringType.StrCmp(sLeft, "btp", false) == 0) return 2043;
            if (StringType.StrCmp(sLeft, "utp", false) == 0) return 2044;
            if (StringType.StrCmp(sLeft, "dft", false) == 0) return 2045;
            if (StringType.StrCmp(sLeft, "gic", false) == 0) return 2046;
            if (StringType.StrCmp(sLeft, "gui", false) == 0) return 2047;
            if (StringType.StrCmp(sLeft, "css", false) == 0) return 2048;
            if (StringType.StrCmp(sLeft, "ccs", false) == 0) return 2049;
            if (StringType.StrCmp(sLeft, "btm", false) == 0) return 2050;
            if (StringType.StrCmp(sLeft, "utm", false) == 0) return 2051;
            if (StringType.StrCmp(sLeft, "dwk", false) == 0) return 2052;
            if (StringType.StrCmp(sLeft, "pwk", false) == 0) return 2053;
            if (StringType.StrCmp(sLeft, "btg", false) == 0) return 2054;
            if (StringType.StrCmp(sLeft, "utg", false) == 0) return 2055;
            if (StringType.StrCmp(sLeft, "jrl", false) == 0) return 2056;
            if (StringType.StrCmp(sLeft, "sav", false) == 0) return 2057;
            if (StringType.StrCmp(sLeft, "utw", false) == 0) return 2058;
            if (StringType.StrCmp(sLeft, "4pc", false) == 0) return 2059;
            if (StringType.StrCmp(sLeft, "ssf", false) == 0) return 2060;
            if (StringType.StrCmp(sLeft, "hak", false) == 0) return 2061;
            if (StringType.StrCmp(sLeft, "nwm", false) == 0) return 2062;
            if (StringType.StrCmp(sLeft, "bik", false) == 0) return 2063;
            if (StringType.StrCmp(sLeft, "ndb", false) == 0) return 2064;
            if (StringType.StrCmp(sLeft, "ptm", false) == 0) return 2065;
            if (StringType.StrCmp(sLeft, "ptt", false) == 0) return 2066;
            if (StringType.StrCmp(sLeft, "lyt", false) == 0) return 3000;
            if (StringType.StrCmp(sLeft, "vis", false) == 0) return 3001;
            if (StringType.StrCmp(sLeft, "rim", false) == 0) return 3002;
            if (StringType.StrCmp(sLeft, "pth", false) == 0) return 3003;
            if (StringType.StrCmp(sLeft, "lip", false) == 0) return 3004;
            if (StringType.StrCmp(sLeft, "bwm", false) == 0) return 3005;
            if (StringType.StrCmp(sLeft, "txb", false) == 0) return 3006;
            if (StringType.StrCmp(sLeft, "tpc", false) == 0) return 3007;
            if (StringType.StrCmp(sLeft, "mdx", false) == 0) return 3008;
            if (StringType.StrCmp(sLeft, "rsv", false) == 0) return 3009;
            if (StringType.StrCmp(sLeft, "sig", false) == 0) return 3010;
            if (StringType.StrCmp(sLeft, "xbx", false) == 0) return 3011;
            if (StringType.StrCmp(sLeft, "erf", false) == 0) return 9997;
            if (StringType.StrCmp(sLeft, "bif", false) == 0) return 9998;
            return StringType.StrCmp(sLeft, "key", false) == 0 ? (short) 9999 : (short) -1;
        }

        public static string GetRsrcTypeForId(int id)
        {
            switch (id)
            {
                case 0: return "res";
                case 1: return "bmp";
                case 2: return "mve";
                case 3: return "tga";
                case 4: return "wav";
                case 6: return "plt";
                case 7: return "ini";
                case 8: return "mp3";
                case 9: return "mpg";
                case 10: return "txt";
                case 11: return "wma";
                case 12: return "wmv";
                case 13: return "xmv";
                case 2000: return "plh";
                case 2001: return "tex";
                case 2002: return "mdl";
                case 2003: return "thg";
                case 2005: return "fnt";
                case 2007: return "lua";
                case 2008: return "slt";
                case 2009: return "nss";
                case 2010: return "ncs";
                case 2011: return "mod";
                case 2012: return "are";
                case 2013: return "set";
                case 2014: return "ifo";
                case 2015: return "bic";
                case 2016: return "wok";
                case 2017: return "2da";
                case 2018: return "tlk";
                case 2022: return "txi";
                case 2023: return "git";
                case 2024: return "bti";
                case 2025: return "uti";
                case 2026: return "btc";
                case 2027: return "utc";
                case 2029: return "dlg";
                case 2030: return "itp";
                case 2031: return "btt";
                case 2032: return "utt";
                case 2033: return "dds";
                case 2034: return "bts";
                case 2035: return "uts";
                case 2036: return "ltr";
                case 2037: return "gff";
                case 2038: return "fac";
                case 2039: return "bts";
                case 2040: return "ute";
                case 2041: return "btd";
                case 2042: return "utd";
                case 2043: return "btp";
                case 2044: return "utp";
                case 2045: return "dft";
                case 2046: return "gic";
                case 2047: return "gui";
                case 2048: return "css";
                case 2049: return "ccs";
                case 2050: return "btm";
                case 2051: return "utm";
                case 2052: return "dwk";
                case 2053: return "pwk";
                case 2054: return "btg";
                case 2055: return "utg";
                case 2056: return "jrl";
                case 2057: return "sav";
                case 2058: return "utw";
                case 2059: return "4pc";
                case 2060: return "ssf";
                case 2061: return "hak";
                case 2062: return "nwm";
                case 2063: return "bik";
                case 2064: return "ndb";
                case 2065: return "ptm";
                case 2066: return "ptt";
                case 3000: return "lyt";
                case 3001: return "vis";
                case 3002: return "rim";
                case 3003: return "pth";
                case 3004: return "lip";
                case 3005: return "bwm";
                case 3006: return "txb";
                case 3007: return "tpc";
                case 3008: return "mdx";
                case 3009: return "rsv";
                case 3010: return "sig";
                case 3011: return "xbx";
                case 9997: return "erf";
                case 9998: return "bif";
                case 9999: return "key";
                default: return "Unk (" + StringType.FromInteger(id) + ")";
            }
        }

        public static string GetModuleDescForRimName(string rimName)
        {
            string sLeft = rimName.Replace(".rim", "").Replace("_s", "");
            if (StringType.StrCmp(sLeft, "end_m01aa", false) == 0) return "Command Module";
            if (StringType.StrCmp(sLeft, "end_m01ab", false) == 0) return "Starboard Section";
            if (StringType.StrCmp(sLeft, "tar_m02aa", false) == 0) return "South Apartments";
            if (StringType.StrCmp(sLeft, "tar_m02ab", false) == 0) return "Upper City North";
            if (StringType.StrCmp(sLeft, "tar_m02ac", false) == 0) return "Upper City South";
            if (StringType.StrCmp(sLeft, "tar_m02ad", false) == 0) return "North Apartments";
            if (StringType.StrCmp(sLeft, "tar_m02ae", false) == 0) return "Upper City Cantina";
            if (StringType.StrCmp(sLeft, "tar_m02af", false) == 0) return "Hideout";
            if (StringType.StrCmp(sLeft, "tar_m03aa", false) == 0) return "Lower City";
            if (StringType.StrCmp(sLeft, "tar_m03ab", false) == 0 || StringType.StrCmp(sLeft, "tar_m03ad", false) == 0) return "Lower City Apartments";
            if (StringType.StrCmp(sLeft, "tar_m03ae", false) == 0) return "Javyar's Cantina";
            if (StringType.StrCmp(sLeft, "tar_m03af", false) == 0) return "Swoop Platform";
            if (StringType.StrCmp(sLeft, "tar_m04aa", false) == 0) return "Undercity";
            if (StringType.StrCmp(sLeft, "tar_m05aa", false) == 0) return "Lower Sewers";
            if (StringType.StrCmp(sLeft, "tar_m05ab", false) == 0) return "Upper Sewers";
            if (StringType.StrCmp(sLeft, "tar_m08aa", false) == 0) return "Davik's Estate";
            if (StringType.StrCmp(sLeft, "tar_m09aa", false) == 0 || StringType.StrCmp(sLeft, "tar_m09ab", false) == 0) return "Sith Base";
            if (StringType.StrCmp(sLeft, "tar_m10aa", false) == 0 || StringType.StrCmp(sLeft, "tar_m10ab", false) == 0 || StringType.StrCmp(sLeft, "tar_m10ac", false) == 0) return "Black Vulkar Base";
            if (StringType.StrCmp(sLeft, "tar_m11aa", false) == 0 || StringType.StrCmp(sLeft, "tar_m11ab", false) == 0) return "Hidden Bek Base";
            if (StringType.StrCmp(sLeft, "ebo_m12aa", false) == 0) return "Bridge";
            if (StringType.StrCmp(sLeft, "ebo_m46ab", false) == 0) return "Mystery Box";
            if (StringType.StrCmp(sLeft, "danm13", false) == 0) return "Jedi Enclave";
            if (StringType.StrCmp(sLeft, "danm14aa", false) == 0) return "Courtyard";
            if (StringType.StrCmp(sLeft, "danm14ab", false) == 0) return "Matale Grounds";
            if (StringType.StrCmp(sLeft, "danm14ac", false) == 0) return "Grove";
            if (StringType.StrCmp(sLeft, "danm14ad", false) == 0) return "Sandral Grounds";
            if (StringType.StrCmp(sLeft, "danm14ae", false) == 0) return "Crystal Caves";
            if (StringType.StrCmp(sLeft, "danm15", false) == 0) return "Ruins";
            if (StringType.StrCmp(sLeft, "danm16", false) == 0) return "Sandral Estate";
            if (StringType.StrCmp(sLeft, "tat_m17aa", false) == 0) return "Anchorhead";
            if (StringType.StrCmp(sLeft, "tat_m17ab", false) == 0) return "Docking Bay";
            if (StringType.StrCmp(sLeft, "tat_m17ac", false) == 0) return "Droid Shop";
            if (StringType.StrCmp(sLeft, "tat_m17ad", false) == 0) return "Hunting Lodge";
            if (StringType.StrCmp(sLeft, "tat_m17ae", false) == 0) return "Swoop Registration";
            if (StringType.StrCmp(sLeft, "tat_m17af", false) == 0) return "Cantina";
            if (StringType.StrCmp(sLeft, "tat_m17ag", false) == 0) return "Czerka Office";
            if (StringType.StrCmp(sLeft, "tat_m18aa", false) == 0) return "Dune Sea";
            if (StringType.StrCmp(sLeft, "tat_m18ab", false) == 0) return "Sand People Territory";
            if (StringType.StrCmp(sLeft, "tat_m18ac", false) == 0) return "Eastern Dune Sea";
            if (StringType.StrCmp(sLeft, "tat_m20aa", false) == 0) return "Sand People Enclave";
            if (StringType.StrCmp(sLeft, "kas_m22aa", false) == 0) return "Czerka Landing Port";
            if (StringType.StrCmp(sLeft, "kas_m22ab", false) == 0) return "The Great Walkway";
            if (StringType.StrCmp(sLeft, "kas_m23aa", false) == 0) return "Village of Rwookrrorro";
            if (StringType.StrCmp(sLeft, "kas_m23ab", false) == 0) return "Worrwill's Home";
            if (StringType.StrCmp(sLeft, "kas_m23ac", false) == 0) return "Worrroznor's Home";
            if (StringType.StrCmp(sLeft, "kas_m23ad", false) == 0) return "Chieftain's Hall";
            if (StringType.StrCmp(sLeft, "kas_m24aa", false) == 0) return "Upper Shadowlands";
            if (StringType.StrCmp(sLeft, "kas_m25aa", false) == 0) return "Lower Shadowlands";
            if (StringType.StrCmp(sLeft, "manm26aa", false) == 0) return "Ahto West";
            if (StringType.StrCmp(sLeft, "manm26ab", false) == 0) return "Ahto East";
            if (StringType.StrCmp(sLeft, "manm26ac", false) == 0) return "West Central";
            if (StringType.StrCmp(sLeft, "manm26ad", false) == 0) return "Docking Bay";
            if (StringType.StrCmp(sLeft, "manm26ae", false) == 0) return "East Central";
            if (StringType.StrCmp(sLeft, "manm27aa", false) == 0) return "Sith Base";
            if (StringType.StrCmp(sLeft, "manm28aa", false) == 0) return "Hrakert Station";
            if (StringType.StrCmp(sLeft, "manm28ab", false) == 0) return "Sea Floor";
            if (StringType.StrCmp(sLeft, "manm28ac", false) == 0) return "Kolto Control";
            if (StringType.StrCmp(sLeft, "manm28ad", false) == 0) return "Hrakert Rift";
            if (StringType.StrCmp(sLeft, "korr_m33aa", false) == 0) return "Dreshdae";
            if (StringType.StrCmp(sLeft, "korr_m33ab", false) == 0) return "Sith Academy Entrance ";
            if (StringType.StrCmp(sLeft, "korr_m34aa", false) == 0) return "Shyrack Caves";
            if (StringType.StrCmp(sLeft, "korr_m35aa", false) == 0) return "Sith Academy Entrance";
            if (StringType.StrCmp(sLeft, "korr_m36aa", false) == 0) return "Valley of Dark Lords";
            if (StringType.StrCmp(sLeft, "korr_m37aa", false) == 0) return "Tomb of Ajunta Pall";
            if (StringType.StrCmp(sLeft, "korr_m38aa", false) == 0) return "Tomb of Marka Ragnos";
            if (StringType.StrCmp(sLeft, "korr_m38ab", false) == 0) return "Tomb of Tulak Hord";
            if (StringType.StrCmp(sLeft, "korr_m39aa", false) == 0) return "Tomb of Naga Sadow";
            if (StringType.StrCmp(sLeft, "liv_m99aa", false) == 0) return "Yavin Station";
            if (StringType.StrCmp(sLeft, "lev_m40aa", false) == 0) return "Prison Block";
            if (StringType.StrCmp(sLeft, "lev_m40ab", false) == 0) return "Command Deck";
            if (StringType.StrCmp(sLeft, "lev_m40ac", false) == 0) return "Hangar";
            if (StringType.StrCmp(sLeft, "lev_m40ad", false) == 0) return "Bridge";
            if (StringType.StrCmp(sLeft, "unk_m41aa", false) == 0) return "Central Beach";
            if (StringType.StrCmp(sLeft, "unk_m41ab", false) == 0) return "South Beach";
            if (StringType.StrCmp(sLeft, "unk_m41ac", false) == 0) return "North Beach";
            if (StringType.StrCmp(sLeft, "unk_m41ad", false) == 0) return "Temple Exterior";
            if (StringType.StrCmp(sLeft, "unk_m42aa", false) == 0) return "Elder Settlement";
            if (StringType.StrCmp(sLeft, "unk_m43aa", false) == 0) return "Rakatan Settlement";
            if (StringType.StrCmp(sLeft, "unk_m44aa", false) == 0) return "Temple Main Floor";
            if (StringType.StrCmp(sLeft, "unk_m44ab", false) == 0) return "Temple Catacombs";
            if (StringType.StrCmp(sLeft, "sta_m45aa", false) == 0) return "Deck 1";
            if (StringType.StrCmp(sLeft, "sta_m45ab", false) == 0) return "Deck 2";
            if (StringType.StrCmp(sLeft, "sta_m45ac", false) == 0) return "Deck 3";
            if (StringType.StrCmp(sLeft, "sta_m45ad", false) == 0) return "Deck 4";
            if (StringType.StrCmp(sLeft, "001EBO", false) == 0) return "Interior";
            if (StringType.StrCmp(sLeft, "002EBO", false) == 0) return "Exterior Hull";
            if (StringType.StrCmp(sLeft, "003EBO", false) == 0 || StringType.StrCmp(sLeft, "004EBO", false) == 0 || (StringType.StrCmp(sLeft, "005EBO", false) == 0 || StringType.StrCmp(sLeft, "006EBO", false) == 0) || StringType.StrCmp(sLeft, "007EBO", false) == 0) return "Interior";
            if (StringType.StrCmp(sLeft, "101PER", false) == 0) return "kolto cutscene - Administration Level";
            if (StringType.StrCmp(sLeft, "102PER", false) == 0) return "Mining Tunnels";
            if (StringType.StrCmp(sLeft, "103PER", false) == 0) return "Fuel Depot";
            if (StringType.StrCmp(sLeft, "104PER", false) == 0) return "Asteroid Exterior";
            if (StringType.StrCmp(sLeft, "105PER", false) == 0) return "Dormitories";
            if (StringType.StrCmp(sLeft, "106PER", false) == 0) return "Hangar Bay";
            if (StringType.StrCmp(sLeft, "107PER", false) == 0) return "final cutscene a.k.a. leaving Peragus";
            if (StringType.StrCmp(sLeft, "151HAR", false) == 0) return "Command Deck";
            if (StringType.StrCmp(sLeft, "152HAR", false) == 0) return "Crew Quarters";
            if (StringType.StrCmp(sLeft, "153HAR", false) == 0) return "Engine Deck";
            if (StringType.StrCmp(sLeft, "154HAR", false) == 0) return "cutscene - Command Deck";
            if (StringType.StrCmp(sLeft, "201TEL", false) == 0) return "Citadel Station Docking Module";
            if (StringType.StrCmp(sLeft, "202TEL", false) == 0) return "Citadel Station Entertainment Module 081";
            if (StringType.StrCmp(sLeft, "203TEL", false) == 0) return "Citadel Station Residential 082 East";
            if (StringType.StrCmp(sLeft, "204TEL", false) == 0) return "Citadel Station Residential 082 West";
            if (StringType.StrCmp(sLeft, "205TEL", false) == 0) return "Citadel Station Residential 082 West - leads to cutscene to Malachor V";
            if (StringType.StrCmp(sLeft, "207TEL", false) == 0) return "Citadel Station Cantina";
            if (StringType.StrCmp(sLeft, "208TEL", false) == 0) return "Bumani Exchange Corp.";
            if (StringType.StrCmp(sLeft, "209TEL", false) == 0) return "Czerka Offices";
            if (StringType.StrCmp(sLeft, "211TEL", false) == 0) return "Citadel Station Swoop Track - not official name";
            if (StringType.StrCmp(sLeft, "220TEL", false) == 0) return "Citadel Station Suburban - Sith Assault";
            if (StringType.StrCmp(sLeft, "221TEL", false) == 0) return "Citadel Station Suburban - Sith Assault - cutscene w/Grenn";
            if (StringType.StrCmp(sLeft, "222TEL", false) == 0) return "Citadel Station Entertainment Module 081 - Sith Assault";
            if (StringType.StrCmp(sLeft, "231TEL", false) == 0) return "Restoration Zone";
            if (StringType.StrCmp(sLeft, "232TEL", false) == 0) return "Underground Base";
            if (StringType.StrCmp(sLeft, "233TEL", false) == 0) return "Czerka Site";
            if (StringType.StrCmp(sLeft, "261TEL", false) == 0) return "Polar Plateau";
            if (StringType.StrCmp(sLeft, "262TEL", false) == 0) return "Secret Academy";
            if (StringType.StrCmp(sLeft, "301NAR", false) == 0) return "Refugee Landing Pad";
            if (StringType.StrCmp(sLeft, "302NAR", false) == 0) return "Refugee Quad";
            if (StringType.StrCmp(sLeft, "303NAR", false) == 0) return "Docks";
            if (StringType.StrCmp(sLeft, "304NAR", false) == 0) return "Jekk'Jekk Tarr";
            if (StringType.StrCmp(sLeft, "305NAR", false) == 0) return "Jekk'Jekk Tunnels";
            if (StringType.StrCmp(sLeft, "306NAR", false) == 0) return "Entertainment Promenade";
            if (StringType.StrCmp(sLeft, "351NAR", false) == 0) return "Goto's Yacht";
            if (StringType.StrCmp(sLeft, "352NAR", false) == 0) return "Goto's Yacht (cutscene)";
            if (StringType.StrCmp(sLeft, "371NAR", false) == 0) return "Nar Shaddaa Swoop Track";
            if (StringType.StrCmp(sLeft, "401DXN", false) == 0) return "Jungle Landing";
            if (StringType.StrCmp(sLeft, "402DXN", false) == 0) return "Jungle";
            if (StringType.StrCmp(sLeft, "403DXN", false) == 0) return "Mandalorian Ruins";
            if (StringType.StrCmp(sLeft, "404DXN", false) == 0) return "Mandalorian Cache";
            if (StringType.StrCmp(sLeft, "410DXN", false) == 0) return "Jungle Tomb";
            if (StringType.StrCmp(sLeft, "411DXN", false) == 0) return "Sith Tomb";
            if (StringType.StrCmp(sLeft, "421DXN", false) == 0) return "Dxun Turret Game";
            if (StringType.StrCmp(sLeft, "501OND", false) == 0) return "Iziz Spaceport";
            if (StringType.StrCmp(sLeft, "502OND", false) == 0) return "Merchant Quarter";
            if (StringType.StrCmp(sLeft, "503OND", false) == 0) return "Iziz Cantina";
            if (StringType.StrCmp(sLeft, "504OND", false) == 0) return "Sky Ramp";
            if (StringType.StrCmp(sLeft, "505OND", false) == 0) return "Turret";
            if (StringType.StrCmp(sLeft, "506OND", false) == 0) return "Royal Palace";
            if (StringType.StrCmp(sLeft, "510OND", false) == 0) return "Swoop Race Track";
            if (StringType.StrCmp(sLeft, "511OND", false) == 0) return "Merchant Quarter";
            if (StringType.StrCmp(sLeft, "512OND", false) == 0) return "Iziz - Western Square";
            if (StringType.StrCmp(sLeft, "601DAN", false) == 0) return "Khoonda";
            if (StringType.StrCmp(sLeft, "602DAN", false) == 0) return "Khoonda Plains";
            if (StringType.StrCmp(sLeft, "603DAN", false) == 0) return "Movie Terminal on Khoonda Plains";
            if (StringType.StrCmp(sLeft, "604DAN", false) == 0) return "Crystal Cave";
            if (StringType.StrCmp(sLeft, "605DAN", false) == 0) return "Enclave Courtyard";
            if (StringType.StrCmp(sLeft, "610DAN", false) == 0) return "Enclave Sublevel";
            if (StringType.StrCmp(sLeft, "650DAN", false) == 0) return "Rebuilt Jedi Enclave";
            if (StringType.StrCmp(sLeft, "701KOR", false) == 0) return "Valley of Dark Lords";
            if (StringType.StrCmp(sLeft, "702KOR", false) == 0) return "Sith Academy";
            if (StringType.StrCmp(sLeft, "710KOR", false) == 0) return "Shyrack Cave";
            if (StringType.StrCmp(sLeft, "711KOR", false) == 0) return "Secret Tomb";
            if (StringType.StrCmp(sLeft, "851NIH", false) == 0) return "Ravager Command Deck";
            if (StringType.StrCmp(sLeft, "852NIH", false) == 0) return "Ravager Bridge";
            if (StringType.StrCmp(sLeft, "853NIH", false) == 0) return "Ravager - cutscene Visas Nihilus convo.";
            if (StringType.StrCmp(sLeft, "901MAL", false) == 0) return "Surface";
            if (StringType.StrCmp(sLeft, "902MAL", false) == 0) return "Depths";
            if (StringType.StrCmp(sLeft, "903MAL", false) == 0) return "Trayus Academy";
            if (StringType.StrCmp(sLeft, "904MAL", false) == 0) return "Trayus Core";
            if (StringType.StrCmp(sLeft, "905MAL", false) == 0) return "Trayus Crescent";
            if (StringType.StrCmp(sLeft, "906MAL", false) == 0) return "Trayus Proving Grounds";
            if (StringType.StrCmp(sLeft, "907MAL", false) == 0) return "Trayus Core";

            string str = "";
            return str;
        }

        public static string GetLocNameForRimName(string rimName)
        {
            string sLeft1 = rimName.Substring(0, 3);
            if (StringType.StrCmp(sLeft1, "end", false) == 0) return " (Endar Spire)";
            if (StringType.StrCmp(sLeft1, "tar", false) == 0) return " (Taris)";
            if (StringType.StrCmp(sLeft1, "ebo", false) == 0) return " (Ebon Hawk)";
            if (StringType.StrCmp(sLeft1, "dan", false) == 0) return " (Dantooine)";
            if (StringType.StrCmp(sLeft1, "tat", false) == 0) return " (Tatooine)";
            if (StringType.StrCmp(sLeft1, "kas", false) == 0) return " (Kashyyyk)";
            if (StringType.StrCmp(sLeft1, "man", false) == 0) return " (Manaan)";
            if (StringType.StrCmp(sLeft1, "kor", false) == 0) return " (Korriban)";
            if (StringType.StrCmp(sLeft1, "liv", false) == 0) return " (Yavin Station)";
            if (StringType.StrCmp(sLeft1, "lev", false) == 0) return " (Leviathan)";
            if (StringType.StrCmp(sLeft1, "unk", false) == 0) return " (Unknown World)";
            if (StringType.StrCmp(sLeft1, "sta", false) == 0) return " (Star Forge)";
            if (StringType.StrCmp(sLeft1, "STU", false) == 0) return " (cut scene)";
            string sLeft2 = rimName.Substring(3, 3);
            if (StringType.StrCmp(sLeft2, "EBO", false) == 0) return " (Ebon Hawk)";
            if (StringType.StrCmp(sLeft2, "KOR", false) == 0) return " (Korriban)";
            if (StringType.StrCmp(sLeft2, "DAN", false) == 0) return " (Dantooine)";
            if (StringType.StrCmp(sLeft2, "PER", false) == 0) return " (Peragus)";
            if (StringType.StrCmp(sLeft2, "HAR", false) == 0) return " (Harbinger)";
            if (StringType.StrCmp(sLeft2, "TEL", false) == 0) return " (Telos)";
            if (StringType.StrCmp(sLeft2, "NAR", false) == 0) return " (Nar Shaddaa)";
            if (StringType.StrCmp(sLeft2, "DXN", false) == 0) return " (Dxun)";
            if (StringType.StrCmp(sLeft2, "OND", false) == 0) return " (Onderon)";
            if (StringType.StrCmp(sLeft2, "NIH", false) == 0) return " (Ravager)";
            if (StringType.StrCmp(sLeft2, "MAL", false) == 0) return " (Malachor V)";
            if (StringType.StrCmp(sLeft2, "COR", false) == 0) return " (Ebon Hawk)";

            string str = "";
            return str;
        }


    }
}