//--- Melia Script -----------------------------------------------------------
// f_tableland_72
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sventimas Exile' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland72MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_tableland_72", MonsterId.Spion_White, Properties("MHP", 391570, "MINPATK", 5536, "MAXPATK", 6706, "MINMATK", 5536, "MAXMATK", 6706, "DEF", 42065, "MDEF", 42065));
		AddPropertyOverrides("f_tableland_72", MonsterId.Cronewt_Mage_Blue, Properties("MHP", 392008, "MINPATK", 5542, "MAXPATK", 6713, "MINMATK", 5542, "MAXMATK", 6713, "DEF", 42205, "MDEF", 42205));
		AddPropertyOverrides("f_tableland_72", MonsterId.Hohen_Orben_Red, Properties("MHP", 392808, "MINPATK", 5552, "MAXPATK", 6726, "MINMATK", 5552, "MAXMATK", 6726, "DEF", 42460, "MDEF", 42460));
		AddPropertyOverrides("f_tableland_72", MonsterId.Lapasape_Brown, Properties("MHP", 393844, "MINPATK", 5565, "MAXPATK", 6742, "MINMATK", 5565, "MAXMATK", 6742, "DEF", 42790, "MDEF", 42790));

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_72.Id1", MonsterId.Spion_White, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_72.Id2", MonsterId.Cronewt_Mage_Blue, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_72.Id3", MonsterId.Hohen_Orben_Red, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_72.Id4", MonsterId.Lapasape_Brown, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_72.Id5", MonsterId.Rootcrystal_03, 27, 36, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_tableland_72.Id6", MonsterId.Spion_White, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Spion_White' GenType 1 Spawn Points
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(286, -1124, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(187, -925, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(446, -698, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(487, -979, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(584, -1169, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-470, -1034, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-442, -804, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-1178, -454, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(60, 587, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-1165, -301, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-1027, -212, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-1317, -266, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(82, 551, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-907, -307, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(399, 48, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(578, -158, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(626, 27, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1029, -5, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1228, 39, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1275, -467, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1137, -608, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1232, -742, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1496, 70, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1794, 37, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1853, 202, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1368, 498, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1153, 630, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1345, 764, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1069, 493, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-279, 889, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-530, 614, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-240, 579, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-595, 792, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-853, 608, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-1102, 509, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-1011, 304, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-936, 520, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(246, 569, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(756, 1243, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(558, 1194, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(564, 1400, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(374, 1416, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(798, 1348, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(628, -1239, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(581, -1296, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(465, -1351, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(420, -1322, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(343, -1238, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(274, -1215, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(154, -1113, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(60, -1082, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(67, -981, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(67, -889, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(197, -795, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(319, -744, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(407, -703, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(430, -617, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(577, -706, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(659, -786, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(711, -891, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(708, -963, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(740, -1038, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(674, -1106, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(589, -1127, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(499, -1106, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(405, -1111, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(343, -1091, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(291, -1058, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(257, -934, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(288, -856, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(383, -788, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(397, -937, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(481, -851, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(379, -1017, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(659, -895, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(95, -806, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-209, -1045, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-202, -1161, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-194, -1251, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-306, -1310, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-412, -1350, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-513, -1370, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-555, -1280, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-456, -1284, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-343, -1227, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-264, -1227, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-319, -1124, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-439, -1195, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-613, -1137, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-678, -1052, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-679, -969, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-636, -899, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-555, -740, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-488, -675, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-372, -700, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-277, -820, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-293, -895, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-374, -908, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-478, -949, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-537, -953, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-494, -1087, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-292, -1057, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(-375, -1141, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1466, -693, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1435, -761, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1353, -800, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1274, -806, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1157, -750, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1018, -661, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1044, -550, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1020, -486, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1108, -419, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1177, -347, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1255, -310, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1145, -477, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1156, -575, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1108, -512, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1244, -524, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1330, -619, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1236, -687, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1475, -622, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1399, -591, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1414, -476, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1563, -462, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1488, -509, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1479, -424, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1421, -370, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1348, -354, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1216, -400, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1061, -448, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1360, -544, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1322, -747, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1377, -728, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2000, -32, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1938, -91, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1867, -79, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1869, -6, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1876, 55, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1805, 110, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1736, 164, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1782, 211, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2055, 255, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2072, 178, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2022, 199, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2080, 119, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2069, 51, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(2028, 38, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1996, 161, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1850, 112, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1721, 229, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1681, 167, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1607, 142, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1560, 160, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1555, 119, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1599, 45, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1664, 36, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1705, -28, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1655, -33, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1589, 2, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1506, -5, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1451, -27, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1383, -8, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1402, 113, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1492, 125, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1393, 53, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1340, 133, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1282, 147, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1196, 98, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1140, 46, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1234, 0, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1345, 27, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1319, -116, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(1278, -120, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(149, 568, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(177, 515, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(200, 560, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(110, 512, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(91, 469, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(182, 462, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(256, 463, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(238, 500, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(285, 531, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(287, 602, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(377, 729, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(319, 665, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(365, 654, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(392, 693, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(446, 713, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(472, 843, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(481, 902, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(523, 918, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(503, 946, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(566, 942, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(518, 1171, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(441, 1291, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(412, 1222, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(288, 1296, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(257, 1274, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(252, 1378, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(339, 1375, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(237, 1328, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(373, 1305, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(334, 1235, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(420, 1361, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(398, 1459, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(471, 1511, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(486, 1422, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(452, 1461, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(486, 1346, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(500, 1261, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(570, 1336, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(550, 1460, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(625, 1516, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(651, 1576, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(714, 1622, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(774, 1550, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(845, 1488, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(864, 1389, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(828, 1290, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(815, 1221, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(774, 1153, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(687, 1066, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(637, 1080, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(571, 1115, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(526, 1118, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(638, 1179, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(663, 1136, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(626, 1242, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(713, 1182, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(692, 1277, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(655, 1358, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(751, 1335, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(757, 1451, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(627, 1433, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(712, 1503, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(714, 1557, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(632, 1295, 30));
		AddSpawnPoint("f_tableland_72.Id1", "f_tableland_72", Rectangle(686, 1221, 30));

		// 'Cronewt_Mage_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-433, 696, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-143, 704, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-1060, -84, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-1163, -267, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-241, -903, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(334, 694, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-438, -845, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-436, -1070, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(591, -1028, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(610, -850, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(172, -957, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(298, -649, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(341, -1194, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(568, -1224, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(440, -979, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1274, 643, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1101, 603, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(469, -122, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(612, -85, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1194, -649, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1240, -474, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1431, -551, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1727, 13, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1872, 169, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(1948, 71, 30));
		AddSpawnPoint("f_tableland_72.Id2", "f_tableland_72", Rectangle(-1227, 643, 30));

		// 'Hohen_Orben_Red' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(-377, -994, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(488, -1227, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(462, -105, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(-1304, -159, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(-1125, 402, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(1256, 586, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(1737, 50, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(1309, -509, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(-326, 742, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(552, -919, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(583, 1242, 30));
		AddSpawnPoint("f_tableland_72.Id3", "f_tableland_72", Rectangle(445, -791, 30));

		// 'Lapasape_Brown' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-464, 883, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-152, 840, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-391, 487, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-952, 650, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-1262, 469, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-1007, 460, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-1354, -199, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(748, 11, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(481, 879, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-575, -843, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(306, -984, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(461, 1203, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(701, 1393, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(713, 1123, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(509, 74, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(588, -257, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(802, -150, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1261, -591, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1285, -390, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1084, -681, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1373, -682, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1691, 112, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1950, 94, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1076, 752, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1170, 546, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1481, 683, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1356, 497, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(136, -903, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(489, -709, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(444, -1024, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(660, -972, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(458, -1252, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(285, -647, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-540, -1172, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-588, -1018, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-450, -777, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-291, -981, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-1333, -368, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-1114, -55, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-934, -118, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(-1047, -427, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(384, -257, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(552, -127, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1287, 100, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1002, -26, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1442, 63, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(1277, -42, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(220, -1155, 30));
		AddSpawnPoint("f_tableland_72.Id4", "f_tableland_72", Rectangle(376, -867, 30));

		// 'Rootcrystal_03' GenType 10 Spawn Points
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(332, -727, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(855, -1332, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(524, -1335, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(357, -1026, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(65, -909, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-347, -1197, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-623, -925, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-382, -728, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-412, -295, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-155, -107, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-613, -118, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-305, 192, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(245, -101, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(816, 44, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(563, -162, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(1319, 42, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(1196, -697, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(1310, -409, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(1220, 456, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(1385, 697, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(1651, 100, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(2005, 97, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-885, -196, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-1341, -107, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-1105, -352, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-1182, 442, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-847, 481, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-596, 738, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-343, 556, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(-108, 786, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(228, 570, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(535, 939, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(461, 1309, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(705, 1377, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(741, 1778, 40));
		AddSpawnPoint("f_tableland_72.Id5", "f_tableland_72", Rectangle(606, -769, 40));

		// 'Spion_White' GenType 32 Spawn Points
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-440, 501, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-308, 481, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-221, 594, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-451, 393, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-615, 536, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-608, 703, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-566, 861, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-473, 627, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-331, 596, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-344, 716, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-180, 732, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-348, 881, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1143, 428, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1167, 744, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1394, 419, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1468, 536, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1226, 516, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1556, 658, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1006, 580, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1344, 771, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1122, 630, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1379, 609, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(1231, 338, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(763, 96, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(559, 3, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(698, -26, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(619, -126, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(505, -177, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(726, -216, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(478, -340, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(382, -307, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(299, -219, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(604, -284, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(387, -86, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(273, -101, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1323, -341, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1169, -440, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1040, -392, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1192, -148, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1174, -279, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1380, -251, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1112, 10, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-946, -91, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1036, -189, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-952, -307, 40));
		AddSpawnPoint("f_tableland_72.Id6", "f_tableland_72", Rectangle(-1347, -121, 40));
	}
}
