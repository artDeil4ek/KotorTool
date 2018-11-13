using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using KotorTool_2._0.Services;
using Microsoft.VisualBasic.CompilerServices;

namespace KotorTool_2._0.Models.CLS
{
    public class ClsMapInfoCreator : IMapInfoCreator
    {
        private MapInfo _mi;

        public ClsMapInfoCreator()
        {
            _mi = new MapInfo();
        }

        public void Write(string installedAppPath)
        {
            _mi.Version = "2005";
            _mi.MapList = new ArrayList();
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m02aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - South Apartments",
                L = true,
                S = true,
                LxMul = new Decimal(2693, 0, 0, false, 2),
                LyMul = new Decimal(2658, 0, 0, false, 2),
                LxOff = 1775,
                LyOff = 1857,
                SxMul = new Decimal(1247, 0, 0, false, 2),
                SyMul = new Decimal(1254, 0, 0, false, 2),
                SxOff = 813,
                SyOff = 799
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m02ac",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Upper City South",
                L = true,
                S = true,
                LxMul = new Decimal(2682, 0, 0, false, 2),
                LyMul = new Decimal(2682, 0, 0, false, 2),
                LxOff = 1385,
                LyOff = 355,
                SxMul = new Decimal(1343, 0, 0, false, 2),
                SyMul = new Decimal(1343, 0, 0, false, 2),
                SxOff = 695,
                SyOff = 179
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m08aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Davik's Estate",
                L = true,
                LxMul = new Decimal(235, 0, 0, false, 1),
                LyMul = new Decimal(235, 0, 0, false, 1),
                LxOff = 164,
                LyOff = 196
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m10aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Black Vulkar Base 1",
                L = true,
                S = true,
                LxMul = new Decimal(3478, 0, 0, false, 2),
                LyMul = new Decimal(3478, 0, 0, false, 2),
                LxOff = 3268,
                LyOff = 1473,
                SxMul = new Decimal(1739, 0, 0, false, 2),
                SyMul = new Decimal(1739, 0, 0, false, 2),
                SxOff = 1634,
                SyOff = 737
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m10ab",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Black Vulkar Base 2",
                L = true,
                S = true,
                LxMul = new Decimal(4388, 0, 0, false, 2),
                LyMul = new Decimal(44L),
                LxOff = 1451,
                LyOff = 2644,
                SxMul = new Decimal(2194, 0, 0, false, 2),
                SyMul = new Decimal(2194, 0, 0, false, 2),
                SxOff = 719,
                SyOff = 1320
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m10ac",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Black Vulkar Base 3",
                L = true,
                S = true,
                LxMul = new Decimal(384, 0, 0, false, 1),
                LyMul = new Decimal(384, 0, 0, false, 1),
                LxOff = 1188,
                LyOff = 1145,
                SxMul = new Decimal(192, 0, 0, false, 1),
                SyMul = new Decimal(192, 0, 0, false, 1),
                SxOff = 590,
                SyOff = 570
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m11aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Taris - Hidden Bek Base 1",
                S = true,
                SxMul = new Decimal(201, 0, 0, false, 1),
                SyMul = new Decimal(201, 0, 0, false, 1),
                SxOff = 432,
                SyOff = 262
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m16aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dantooine - Sandral Estate",
                S = true,
                SxMul = new Decimal(3191, 0, 0, false, 2),
                SyMul = new Decimal(3191, 0, 0, false, 2),
                SxOff = 446,
                SyOff = 813
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m42aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Unknown World - Elder Settlement",
                S = true,
                SxMul = new Decimal(1166, 0, 0, false, 2),
                SyMul = new Decimal(1166, 0, 0, false, 2),
                SxOff = 93,
                SyOff = 170
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "m43aa",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Unknown World - Rakatan Settlement",
                S = true,
                SxMul = new Decimal(1002, 0, 0, false, 2),
                SyMul = new Decimal(1002, 0, 0, false, 2),
                SxOff = 9,
                SyOff = 114,
                L = true,
                LxMul = new Decimal(2006, 0, 0, false, 2),
                LyMul = new Decimal(205, 0, 0, false, 1),
                LxOff = 50,
                LyOff = 311
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "151har",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Harbinger - Command Deck",
                S = false,
                SxMul = new Decimal(1608, 0, 0, false, 2),
                SyMul = new Decimal(1608, 0, 0, false, 2),
                SxOff = -942,
                SyOff = -838,
                L = true,
                LxMul = new Decimal(3262, 0, 0, false, 2),
                LyMul = new Decimal(3262, 0, 0, false, 2),
                LxOff = -135,
                LyOff = 1139
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "201tel",
                S = true,
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Docking Module",
                SxMul = new Decimal(1608, 0, 0, false, 2),
                SyMul = new Decimal(1608, 0, 0, false, 2),
                SxOff = -942,
                SyOff = -838,
                L = true,
                LxMul = new Decimal(3216, 0, 0, false, 2),
                LyMul = new Decimal(3216, 0, 0, false, 2),
                LxOff = -1884,
                LyOff = -1683
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "203tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Residential 082 East",
                S = true,
                SxMul = new Decimal(14L),
                SyMul = new Decimal(14L),
                SxOff = -696,
                SyOff = -752,
                L = true,
                LxMul = new Decimal(2798, 0, 0, false, 2),
                LyMul = new Decimal(2809, 0, 0, false, 2),
                LxOff = -1393,
                LyOff = -1505
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "204tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Residential 082 West",
                S = true,
                SxMul = new Decimal(218, 0, 0, false, 1),
                SyMul = new Decimal(218, 0, 0, false, 1),
                SxOff = -1861,
                SyOff = -1428,
                L = true,
                LxMul = new Decimal(436, 0, 0, false, 1),
                LyMul = new Decimal(436, 0, 0, false, 1),
                LxOff = -3722,
                LyOff = -2855
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "207tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Cantina",
                S = true,
                SxMul = new Decimal(3356, 0, 0, false, 2),
                SyMul = new Decimal(3356, 0, 0, false, 2),
                SxOff = -204,
                SyOff = -1406,
                L = true,
                LxMul = new Decimal(67L),
                LyMul = new Decimal(67L),
                LxOff = -408,
                LyOff = -2812
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "208tel",
                MapAssembler = "T7Nowhere",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Bumani Exchange Corp.",
                S = true,
                SxMul = new Decimal(197, 0, 0, false, 1),
                SyMul = new Decimal(197, 0, 0, false, 1),
                SxOff = -841,
                SyOff = -253,
                L = true,
                LxMul = new Decimal(3946, 0, 0, false, 2),
                LyMul = new Decimal(3946, 0, 0, false, 2),
                LxOff = -1686,
                LyOff = -509
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "502ond",
                MapAssembler = "Gsccc",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Onderon - Merchant Quarter",
                S = true,
                SxMul = new Decimal(1429, 0, 0, false, 2),
                SyMul = new Decimal(1429, 0, 0, false, 2),
                SxOff = -379,
                SyOff = -1521,
                L = true,
                LxMul = new Decimal(286, 0, 0, false, 1),
                LyMul = new Decimal(286, 0, 0, false, 1),
                LxOff = -757,
                LyOff = -3040
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "904mal",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Malachor V - Trayus Core",
                S = true,
                SxMul = new Decimal(1288, 0, 0, false, 2),
                SyMul = new Decimal(1288, 0, 0, false, 2),
                SxOff = -1603,
                SyOff = -1288,
                L = true,
                LxMul = new Decimal(25L),
                LyMul = new Decimal(25L),
                LxOff = -3103,
                LyOff = -2490
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Malachor V - Trayus Proving Grounds",
                MapName = "906mal",
                S = true,
                SxMul = new Decimal(707, 0, 0, false, 2),
                SyMul = new Decimal(707, 0, 0, false, 2),
                SxOff = 415,
                SyOff = -589,
                L = true,
                LxMul = new Decimal(2834, 0, 0, false, 2),
                LyMul = new Decimal(2836, 0, 0, false, 2),
                LxOff = 1669,
                LyOff = -2354
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "851nih",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ravager - Command Deck",
                L = true,
                LxMul = new Decimal(212473, 0, 0, false, 4),
                LyMul = new Decimal(212747, 0, 0, false, 4),
                LxOff = -840,
                LyOff = -1173
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "101per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Administration Level",
                L = true,
                LxMul = new Decimal(233, 0, 0, false, 1),
                LyMul = new Decimal(233, 0, 0, false, 1),
                LxOff = -1125,
                LyOff = -3155
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "102per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Mines",
                L = true,
                LxMul = new Decimal(2161355, 0, 0, false, 5),
                LyMul = new Decimal(2163151, 0, 0, false, 5),
                LxOff = -1932,
                LyOff = -2016
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "503ond",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Onderon - Iziz Cantina",
                S = true,
                SxMul = new Decimal(1633915, 0, 0, false, 5),
                SyMul = new Decimal(164017, 0, 0, false, 4),
                SxOff = 1598,
                SyOff = 1262,
                L = true,
                LxMul = new Decimal(6554648, 0, 0, false, 5),
                LyMul = new Decimal(6567685, 0, 0, false, 5),
                LxOff = 6348,
                LyOff = 5060
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "302nar",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Nar Shaddaa - Refugee Area",
                S = true,
                SxMul = new Decimal(7553093, 0, 0, false, 6),
                SyMul = new Decimal(7559947, 0, 0, false, 6),
                SxOff = -645,
                SyOff = 306,
                L = true,
                LxMul = new Decimal(302465, 0, 0, false, 4),
                LyMul = new Decimal(3023979, 0, 0, false, 5),
                LxOff = -2586,
                LyOff = 1226
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "301nar",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Nar Shaddaa - Refugee Landing Pad",
                L = true,
                LxMul = new Decimal(28904, 0, 0, false, 3),
                LyMul = new Decimal(288827, 0, 0, false, 4),
                LxOff = -4582,
                LyOff = -1818
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "303nar",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Nar Shaddaa - Docks",
                L = true,
                LxMul = new Decimal(3444209, 0, 0, false, 5),
                LyMul = new Decimal(3443863, 0, 0, false, 5),
                LxOff = -3112,
                LyOff = -1843
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "298tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - ???",
                S = true,
                SxMul = new Decimal(1433659, 0, 0, false, 5),
                SyMul = new Decimal(1433602, 0, 0, false, 5),
                SxOff = -1390,
                SyOff = 722,
                L = true,
                LxMul = new Decimal(2868834, 0, 0, false, 5),
                LyMul = new Decimal(2868133, 0, 0, false, 5),
                LxOff = -2782,
                LyOff = 1447
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "610dan",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dantooine - Enclave Sublevel",
                L = true,
                LxMul = new Decimal(180677, 0, 0, false, 4),
                LyMul = new Decimal(1806721, 0, 0, false, 5),
                LxOff = -1408,
                LyOff = -3437
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "001ebo",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ebon Hawk - Interior",
                S = true,
                SxMul = new Decimal(130136, 0, 0, false, 4),
                SyMul = new Decimal(1294298, 0, 0, false, 5),
                SxOff = 243,
                SyOff = 83,
                L = true,
                LxMul = new Decimal(5145989, 0, 0, false, 5),
                LyMul = new Decimal(5151605, 0, 0, false, 5),
                LxOff = 945,
                LyOff = 317
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "002ebo",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ebon Hawk - Exterior",
                S = true,
                SxMul = new Decimal(2070314, 0, 0, false, 5),
                SyMul = new Decimal(2071898, 0, 0, false, 5),
                SxOff = -509,
                SyOff = -562,
                L = true,
                LxMul = new Decimal(414488, 0, 0, false, 4),
                LyMul = new Decimal(4146269, 0, 0, false, 5),
                LxOff = -1033,
                LyOff = -1125
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "103per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Fuel Depot",
                S = true,
                SxMul = new Decimal(728313, 0, 0, false, 5),
                SyMul = new Decimal(7259841, 0, 0, false, 6),
                SxOff = -746,
                SyOff = -528,
                L = true,
                LxMul = new Decimal(2909742, 0, 0, false, 5),
                LyMul = new Decimal(2907998, 0, 0, false, 5),
                LxOff = -2987,
                LyOff = -2106
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "105per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Dormitories",
                S = true,
                SxMul = new Decimal(8952945, 0, 0, false, 6),
                SyMul = new Decimal(8940107, 0, 0, false, 6),
                SxOff = -681,
                SyOff = -571,
                L = true,
                LxMul = new Decimal(3580223, 0, 0, false, 5),
                LyMul = new Decimal(3580211, 0, 0, false, 5),
                LxOff = -2704,
                LyOff = -2272
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "401dxn",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dxun - Jungle Landing",
                S = true,
                SxMul = new Decimal(7528076, 0, 0, false, 6),
                SyMul = new Decimal(7580755, 0, 0, false, 6),
                SxOff = -1552,
                SyOff = -1328,
                L = true,
                LxMul = new Decimal(15065, 0, 0, false, 3),
                LyMul = new Decimal(1517198, 0, 0, false, 5),
                LxOff = -3106,
                LyOff = -2743
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "402dxn",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Dxun - Jungle",
                S = true,
                SxMul = new Decimal(4062005, 0, 0, false, 6),
                SyMul = new Decimal(4065509, 0, 0, false, 6),
                SxOff = -537,
                SyOff = -464,
                L = true,
                LxMul = new Decimal(1626198, 0, 0, false, 5),
                LyMul = new Decimal(1626204, 0, 0, false, 5),
                LxOff = -2151,
                LyOff = -1838
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "262tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Secret Academy",
                S = true,
                SxMul = new Decimal(14563, 0, 0, false, 3),
                SyMul = new Decimal(1442678, 0, 0, false, 5),
                SxOff = -1003,
                SyOff = -1984,
                L = true,
                LxMul = new Decimal(1801213, 0, 0, false, 5),
                LyMul = new Decimal(1784771, 0, 0, false, 5),
                LxOff = -1241,
                LyOff = -2427
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "853nih",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Ravager - cutscene",
                S = true,
                SxMul = new Decimal(961601, 0, 0, false, 5),
                SyMul = new Decimal(9586327, 0, 0, false, 6),
                SxOff = -2408,
                SyOff = 100,
                L = true,
                LxMul = new Decimal(3850027, 0, 0, false, 5),
                LyMul = new Decimal(3850385, 0, 0, false, 5),
                LxOff = -9673,
                LyOff = 425
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "106per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Hangar Bay",
                S = true,
                SxMul = new Decimal(13735, 0, 0, false, 3),
                SyMul = new Decimal(1371459, 0, 0, false, 5),
                SxOff = -934,
                SyOff = -471,
                L = true,
                LxMul = new Decimal(2742084, 0, 0, false, 5),
                LyMul = new Decimal(2742918, 0, 0, false, 5),
                LxOff = -1870,
                LyOff = -932
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "202tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Citadel Station Entertainment 081",
                S = true,
                SxMul = new Decimal(2150936, 0, 0, false, 5),
                SyMul = new Decimal(2151281, 0, 0, false, 5),
                SxOff = -891,
                SyOff = -1471,
                L = true,
                LxMul = new Decimal(4301873, 0, 0, false, 5),
                LyMul = new Decimal(4304383, 0, 0, false, 5),
                LxOff = -1784,
                LyOff = -2934
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "231tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Restoration Zone",
                S = true,
                SxMul = new Decimal(5424731, 0, 0, false, 6),
                SyMul = new Decimal(5426398, 0, 0, false, 6),
                SxOff = 1165,
                SyOff = 901,
                L = true,
                LxMul = new Decimal(1085743, 0, 0, false, 5),
                LyMul = new Decimal(108528, 0, 0, false, 4),
                LxOff = 2333,
                LyOff = 1819
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "232tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Underground Base",
                S = true,
                SxMul = new Decimal(1071395, 0, 0, false, 5),
                SyMul = new Decimal(1072112, 0, 0, false, 5),
                SxOff = -1072,
                SyOff = -125,
                L = true,
                LxMul = new Decimal(2145145, 0, 0, false, 5),
                LyMul = new Decimal(2144224, 0, 0, false, 5),
                LxOff = -2143,
                LyOff = -250
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "104per",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Peragus - Asteroid Exterior",
                S = true,
                SxMul = new Decimal(1179846, 0, 0, false, 5),
                SyMul = new Decimal(1178324, 0, 0, false, 5),
                SxOff = -635,
                SyOff = -2012,
                L = true,
                LxMul = new Decimal(4719384, 0, 0, false, 5),
                LyMul = new Decimal(4717387, 0, 0, false, 5),
                LxOff = -2543,
                LyOff = -8030,
                AltS = true,
                AltSxMul = new Decimal(3700609, 0, 0, false, 5),
                AltSyMul = new Decimal(3700414, 0, 0, false, 5),
                AltSxOff = -9,
                AltSyOff = 1058
            });
            _mi.MapList.Add(new MapInfo.Map
            {
                MapName = "233tel",
                MapAssembler = "Fred Tetra",
                MapCalibrator = "Fred Tetra",
                ModuleName = "Telos - Czerka Site",
                S = true,
                SxMul = new Decimal(9043454, 0, 0, false, 6),
                SyMul = new Decimal(9017874, 0, 0, false, 6),
                SxOff = 4060,
                SyOff = 1566,
                L = true,
                LxMul = new Decimal(1808691, 0, 0, false, 5),
                LyMul = new Decimal(1803575, 0, 0, false, 5),
                LxOff = 8124,
                LyOff = 3137
            });
            FileStream fileStream1 = File.Create("MapInfo.bfd");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream1, _mi);
            fileStream1.Close();
            FileStream fileStream2 = File.Create(installedAppPath + "MapInfo.bfd");
            binaryFormatter.Serialize(fileStream2, _mi);
            fileStream2.Close();
            StreamWriter streamWriter = new StreamWriter(File.Create("maptable.txt"));
            ArrayList arrayList = new ArrayList();
            foreach (MapInfo.Map map in _mi.MapList)
            {
                string str1 = map.MapName + "|" + map.ModuleName + "|" + map.MapAssembler + "|";
                string str2 = !map.S ? str1 + "n|" : str1 + "y|";
                string str3 = !map.L ? str2 + "n|" : str2 + "y|";
                arrayList.Add(str3);
            }

            arrayList.Sort();
            foreach (object obj in arrayList)
            {
                string str = StringType.FromObject(obj);
                streamWriter.WriteLine(str);
            }

            streamWriter.Close();
        }
    }
}