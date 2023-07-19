//--- Melia Script -----------------------------------------------------------
// d_abbey_39_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tyla Monastery' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey394MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_39_4.Id1", MonsterId.Rootcrystal_01, 9, 11, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id2", MonsterId.Malstatue, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id3", MonsterId.Malstatue, 17, 22, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id4", MonsterId.Velaphid_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id5", MonsterId.Pumpflap, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_39_4.Id6", MonsterId.Kowak_Orange, 53, 70, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 2 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(1325, -1512, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(1528, -1293, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(1345, -867, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(883, -894, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(718, -564, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(918, -170, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(999, 236, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(707, 363, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(178, 1042, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-92, 1357, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-286, 1044, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-1040, 409, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-1585, 184, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-1169, 165, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-340, 221, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(71, -758, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-102, -1254, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(695, -1285, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(140, 241, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(-45, -520, 50));
		AddSpawnPoint("d_abbey_39_4.Id1", "d_abbey_39_4", Rectangle(295, -1551, 50));

		// 'Malstatue' GenType 30 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(629, -670, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(585, -602, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(600, -851, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(599, -782, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(713, -1000, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1383, -985, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1300, -680, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1526, -803, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1515, -932, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1375, -1542, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1379, -1270, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(1492, -1564, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(501, -1238, 20));
		AddSpawnPoint("d_abbey_39_4.Id2", "d_abbey_39_4", Rectangle(567, -1238, 20));

		// 'Malstatue' GenType 31 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(-125, 17, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(167, 309, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(-247, 136, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(45, 435, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(873, 315, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(873, 171, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1015, 172, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1017, 314, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1074, 375, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(1076, 111, 20));
		AddSpawnPoint("d_abbey_39_4.Id3", "d_abbey_39_4", Rectangle(-98, 1133, 20));

		// 'Velaphid_Red' GenType 34 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-104, 512, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-376, 74, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(303, 390, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-15, 231, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-436, 912, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-27, 1392, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(109, 1009, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(941, 230, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(1123, 49, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(765, 12, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(1118, 467, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-41, 1265, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(117, -30, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(754, 387, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(496, 705, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(393, 836, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-614, 699, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-250, 1160, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(263, 165, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-323, 336, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-248, 188, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(209, 244, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(125, 1150, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(-253, 1378, 25));
		AddSpawnPoint("d_abbey_39_4.Id4", "d_abbey_39_4", Rectangle(292, 946, 25));

		// 'Pumpflap' GenType 37 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(92, -88, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-272, -47, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-140, 204, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-261, 445, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(292, 267, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-1175, 407, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(718, 495, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(1174, 253, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(941, 240, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(699, 178, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(1074, 506, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(51, 333, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(116, 550, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(241, -5, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-357, 317, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(902, -152, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(964, 443, 25));
		AddSpawnPoint("d_abbey_39_4.Id5", "d_abbey_39_4", Rectangle(-33, 18, 25));

		// 'Kowak_Orange' GenType 58 Spawn Points
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-88, -1242, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(108, -1254, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-78, -1466, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(252, -1357, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(82, -1619, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-108, -1636, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-91, -768, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-82, -605, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(104, -1512, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-118, -1525, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-130, -1331, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(14, -1343, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(159, -1395, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(341, -1320, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(42, -1274, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(274, -1237, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(300, -1472, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(326, -1658, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(143, -1644, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(18, -1663, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-20, -1496, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(153, -1451, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(296, -1584, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(496, -1282, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(583, -1274, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(528, -1318, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(723, -861, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(641, -769, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(829, -809, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(937, -689, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(955, -830, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(961, -522, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(748, -647, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(604, -683, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(724, -554, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(624, -484, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(776, -483, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(849, -632, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(95, -743, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(47, -794, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-123, -676, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-128, -536, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(130, -567, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-141, -774, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-162, -738, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(28, -728, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-15, -687, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-69, -649, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(2, -620, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(61, -603, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-236, 49, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-356, 187, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-26, 151, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-168, 407, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(8, 353, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-6, 514, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(207, 342, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(279, 216, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(302, 100, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(175, -25, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-25, -95, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-112, -111, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-196, -36, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-85, -51, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(80, 73, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(55, 192, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(111, 273, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(207, 454, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-70, 409, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-157, 292, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-261, 227, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-327, 262, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-251, 16, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(838, -99, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(934, -99, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(826, -9, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(771, 83, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(721, 113, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(891, 18, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(998, -16, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1122, 163, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1015, 116, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1121, 255, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1104, 392, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(817, 157, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(721, 260, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(700, 338, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(834, 312, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(929, 236, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(923, 108, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(982, 390, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(994, 483, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1123, 486, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1172, 475, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1108, 309, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(849, 447, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(781, 479, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(720, 414, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(443, 765, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(524, 738, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(529, 686, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(484, 772, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(376, 831, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(330, 907, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(408, 855, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(267, 929, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(211, 1013, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(196, 1153, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(57, 1179, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(11, 1097, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-204, 1027, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-269, 1127, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-292, 1209, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-154, 1245, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-208, 1354, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-265, 1326, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-165, 1410, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(129, 1365, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(267, 1292, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(166, 1294, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-35, 978, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-87, 1056, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-23, 1297, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1293, 171, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1289, 370, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1102, 251, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1062, 492, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-887, 500, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-827, 400, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-802, 307, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-884, 134, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-961, 148, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-953, 233, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1022, 427, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1156, 512, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1245, 493, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1227, 278, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1175, 374, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1179, 126, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-1017, 343, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-783, 210, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-585, 727, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-550, 775, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-512, 801, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-477, 847, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(-445, 866, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1440, -1567, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1402, -1489, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1276, -1541, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1320, -1447, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1319, -1371, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1262, -1269, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1361, -1295, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1408, -1219, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1529, -1252, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1627, -1385, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1468, -1335, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1572, -1277, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1592, -1481, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1576, -1549, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1438, -972, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1381, -935, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1375, -640, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1499, -789, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1474, -645, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1554, -588, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1503, -695, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1347, -861, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1261, -872, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1552, -976, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1633, -838, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1505, -874, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1605, -648, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1536, -537, 25));
		AddSpawnPoint("d_abbey_39_4.Id6", "d_abbey_39_4", Rectangle(1298, -741, 25));
	}
}
