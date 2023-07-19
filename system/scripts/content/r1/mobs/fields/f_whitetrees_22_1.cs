//--- Melia Script -----------------------------------------------------------
// f_whitetrees_22_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Teresh Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees221MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_22_1.Id1", MonsterId.Beetow_White, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id2", MonsterId.Atti, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_1.Id3", MonsterId.Richring, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_22_1.Id4", MonsterId.Umblet, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id5", MonsterId.Umbra_Mage, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id6", MonsterId.Umbra_Warrior, 12, 16, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_whitetrees_22_1.Id7", MonsterId.Rootcrystal_01, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Beetow_White' GenType 25 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(2154, -305, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(2193, -392, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(2335, -478, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(2296, -289, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(2377, -379, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(262, 316, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(228, 413, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(308, 407, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(430, 445, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-611, 1281, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-602, 1184, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-525, 1341, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-434, 1433, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-450, 1300, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-522, 1220, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-473, 1135, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-334, 1137, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-396, 1214, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-295, 1265, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-376, 1343, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(218, 1325, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(261, 1254, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(348, 1326, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(459, 1269, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(329, 1493, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(507, 1441, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(491, 1656, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(628, 1531, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(765, -785, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(926, -800, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(1077, -852, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(860, -1133, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(806, -1228, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(681, -1341, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(556, -875, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(408, 63, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(-174, 434, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id1", "f_whitetrees_22_1", Rectangle(1736, -594, 40));

		// 'Atti' GenType 26 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1512, -679, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1488, -787, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1642, -710, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1006, -998, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1158, -900, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1034, -770, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(849, -836, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(879, -962, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(910, -717, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1266, -835, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(689, -264, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(773, -100, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(833, -333, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-158, -1113, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-73, -1069, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-111, -974, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-2, -953, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-53, -823, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1939, -483, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(2013, -383, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(2056, -577, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(2211, -589, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(2046, -471, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(752, -899, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(703, -834, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1123, -984, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(833, -618, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1019, -889, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-234, -1023, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(168, -773, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(676, -89, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(948, -289, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1635, -801, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1522, -879, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(2161, -391, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(1166, -833, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(805, -779, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(607, -871, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(284, -882, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(161, -859, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(-192, -938, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(947, -167, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id2", "f_whitetrees_22_1", Rectangle(787, 0, 40));

		// 'Richring' GenType 27 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(803, -16, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(894, -13, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(846, -109, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(946, -83, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(832, -206, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(977, -170, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(1029, -244, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(627, -201, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(448, -243, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(333, -275, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(176, -348, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(122, -265, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(57, -194, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-41, -238, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-102, -306, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-16, -358, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(44, -308, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(94, -369, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(15, -433, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-376, -420, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-247, -337, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-803, -582, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-976, -542, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(368, 241, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(202, 260, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(208, 146, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(321, 106, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(418, 342, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(152, 354, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(70, 399, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(158, 508, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(257, 549, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(345, 492, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-728, -509, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-577, -530, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(157, -228, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(732, -62, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(729, -301, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(313, 350, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(442, 256, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(327, 441, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-862, -646, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id3", "f_whitetrees_22_1", Rectangle(-984, -645, 40));

		// 'Umblet' GenType 28 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(92, -1174, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(250, -1066, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(206, -870, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(194, -1257, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(364, -948, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-756, -862, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-590, -848, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-591, -714, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-496, -641, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-615, -575, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1129, -69, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1013, -41, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-950, 67, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1033, 155, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1082, 21, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-724, 356, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-628, 331, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-610, 227, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-490, 512, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-381, 437, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(850, 1057, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(754, 993, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(720, 855, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(888, 743, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(953, 911, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1153, 726, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1310, 764, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1334, 891, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1149, 610, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1269, 553, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1029, 784, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-937, 862, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1023, 963, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-959, 1078, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1162, 1053, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1416, 751, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1314, 810, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1302, 895, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1373, 965, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1516, 897, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(441, -1752, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(540, -1750, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(638, -1782, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(375, -1565, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(488, -1508, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-680, -751, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-773, -795, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-406, 280, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1078, 89, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1164, 5, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(-1121, 892, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(863, 854, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1078, 1058, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1217, 909, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id4", "f_whitetrees_22_1", Rectangle(1051, 640, 40));

		// 'Umbra_Mage' GenType 29 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(405, -1820, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(499, -1813, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(584, -1853, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(258, -1651, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(285, -1754, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(55, -1285, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(182, -1173, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(263, -960, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(283, -807, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(105, -1055, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-510, -520, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-711, -746, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1020, -623, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-871, -477, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-771, -461, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1036, 93, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1177, -1, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1136, 195, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1249, -12, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1198, -98, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-510, 230, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-340, 288, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-592, 523, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-717, 465, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-454, 335, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(712, 771, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(819, 934, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(817, 834, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(982, 1072, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(1122, 1074, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(1269, 667, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(1401, 622, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(1472, 794, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(1277, 1016, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(1020, 578, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1542, 784, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1470, 1016, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1610, 971, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1703, 910, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1470, 680, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1048, 692, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-933, 754, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1085, 1078, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1249, 1042, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id5", "f_whitetrees_22_1", Rectangle(-1168, 663, 40));

		// 'Umbra_Warrior' GenType 30 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(758, -1691, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(628, -1687, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(460, -1647, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(359, -1677, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(597, -1575, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-66, -1224, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(6, -1104, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(161, -959, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(88, -844, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(73, -728, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-909, -740, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-888, -618, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-743, -524, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-807, -679, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-705, -629, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(775, 677, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(1065, 979, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(1194, 957, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(1024, 821, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(1021, 675, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(902, 609, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(1175, 842, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1204, 146, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1204, 61, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-625, 445, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-517, 398, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1319, 682, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1130, 768, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1228, 765, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1202, 876, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(-1147, 971, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(133, 1287, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(203, 1197, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(296, 1371, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(540, 1323, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(405, 1450, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(416, 1597, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(551, 1566, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(642, 1438, 40));
		AddSpawnPoint("f_whitetrees_22_1.Id6", "f_whitetrees_22_1", Rectangle(358, 1226, 40));

		// 'Rootcrystal_01' GenType 31 Spawn Points
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(261, -1104, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(482, -1751, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(1036, -891, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(-148, -952, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(-778, -709, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(827, -219, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(1606, -730, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(2181, -396, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(114, -303, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(222, 319, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(-491, 398, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(-1118, 7, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(1280, 721, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(976, 728, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(927, 1078, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(362, 1368, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(-412, 1217, 10));
		AddSpawnPoint("f_whitetrees_22_1.Id7", "f_whitetrees_22_1", Rectangle(-1258, 862, 10));
	}
}
