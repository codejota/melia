//--- Melia Script -----------------------------------------------------------
// f_tableland_28_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Mesafasla' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland281MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_28_1.Id1", MonsterId.Rootcrystal_03, 10, 13, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_1.Id2", MonsterId.Repusbunny_Green, 113, 150, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_1.Id3", MonsterId.Repusbunny_Bow_Green, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_1.Id4", MonsterId.Saltisdaughter_Mage_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 4 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(2, -524, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(1219, -609, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(1528, -431, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(2020, -107, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(2257, 205, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(1937, 599, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(678, -17, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(710, 308, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(327, 236, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-128, 231, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-442, 387, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-681, 616, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-969, 699, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1257, 165, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-758, 1081, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-778, 1483, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1712, 602, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1710, 1105, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-1431, 1313, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-2195, 1317, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-2819, 1055, 50));
		AddSpawnPoint("f_tableland_28_1.Id1", "f_tableland_28_1", Rectangle(-3211, 885, 50));

		// 'Repusbunny_Green' GenType 32 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1963, 537, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1758, -184, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1141, -640, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1421, -366, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(546, 289, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(803, 129, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(502, 392, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-616, 557, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-334, 298, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(10, 234, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1329, -37, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1762, -195, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1294, -361, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1529, 124, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-903, 464, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1047, 650, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-809, 1044, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1681, 1247, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1290, 1388, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1785, 971, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3125, 1089, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1548, 1394, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3030, 1193, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3258, 1075, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2594, 1261, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2357, 1307, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2053, 1356, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1372, -812, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1514, -914, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1634, -881, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1749, -801, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1792, -681, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1717, -541, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1656, -705, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1415, -525, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1612, -417, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1562, -547, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1567, -784, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1409, -688, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1245, -714, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1274, -562, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1271, -850, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1142, -800, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1058, -698, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1066, -507, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1032, -380, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1124, -288, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1253, -230, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1183, -411, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1439, -207, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1608, -219, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1286, -341, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1715, -354, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1894, -119, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1962, -98, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1958, -179, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2012, -225, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2025, -141, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2021, -60, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2073, -178, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2038, 477, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2102, 396, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(2200, 269, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1715, 939, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1703, 863, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1665, 957, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1651, 853, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1664, 808, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1712, 795, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1757, 824, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1773, 768, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(1808, 711, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-4, -598, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-70, -643, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-166, -667, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-162, -535, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-21, -477, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(99, -305, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(101, -552, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(54, -417, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(23, -733, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(134, -629, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-172, -436, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-65, -367, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(171, -429, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(741, -110, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(779, 41, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(831, -56, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(916, 72, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(930, 190, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(825, 203, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(803, 274, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(761, 320, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(698, 357, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(368, 307, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(397, 191, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(630, 287, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(681, 249, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(715, 68, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(694, 133, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(610, 113, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(630, 20, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(540, 137, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(537, 22, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(698, -29, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(484, 240, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(625, -106, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(471, -37, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(371, 20, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(454, 52, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(296, 199, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(346, 108, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-248, 249, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-286, 314, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-367, 329, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-412, 345, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-442, 375, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-483, 368, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-459, 414, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-502, 408, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-565, 478, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-601, 511, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-944, 691, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-931, 589, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-771, 666, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-677, 622, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-820, 785, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-763, 1285, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-688, 1085, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-693, 1179, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-914, 851, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-962, 785, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1007, 420, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1048, 489, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1064, 556, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-823, 559, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1841, 473, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1228, 655, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1367, 656, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1292, 614, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1347, 592, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1415, 611, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1425, 688, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1601, 632, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1607, 525, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1891, 602, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1748, 774, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1756, 441, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1659, 445, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1715, 513, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1622, 753, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1960, 553, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1759, 642, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1996, 665, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1898, 782, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1890, 858, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1839, 677, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1834, 785, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1726, 1006, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1815, 1035, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1671, 1051, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1709, 1176, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1466, 1149, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1626, 1219, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1369, 1265, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1609, 1303, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1761, 1315, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1744, 1264, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1678, 1316, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1816, 1381, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1741, 1378, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1652, 1368, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1593, 1391, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1418, 1375, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1357, 1137, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1248, 1237, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1381, 1484, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1486, 1254, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1826, 1325, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1875, 1358, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1947, 1356, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2010, 1355, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2109, 1347, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2158, 1337, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2404, 1247, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2294, 1312, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2553, 1184, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2650, 1203, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2789, 1043, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2867, 1130, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3086, 996, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3245, 826, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3068, 890, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3349, 973, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3380, 835, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2991, 823, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2969, 1089, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2941, 953, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2806, 977, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2853, 904, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3090, 773, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3209, 950, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-2907, 733, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3160, 683, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-3305, 697, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1547, 47, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1633, 72, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1605, -64, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1612, 201, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1760, 133, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1697, -84, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1653, -200, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1830, -28, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1508, -93, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1470, 8, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1382, -124, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1451, -191, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1229, -139, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1273, 255, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1392, 61, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1471, 219, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1360, 259, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1273, 120, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1163, 63, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1112, -67, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1105, 9, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1170, -73, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1109, -212, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1070, -132, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1239, -206, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1167, -321, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1355, -202, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1257, -294, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1468, -270, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1414, -375, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1523, -359, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1367, -291, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1629, -372, 25));
		AddSpawnPoint("f_tableland_28_1.Id2", "f_tableland_28_1", Rectangle(-1721, -359, 25));

		// 'Repusbunny_Bow_Green' GenType 35 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1383, -129, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1331, 208, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1164, -9, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1622, -231, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1666, 141, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1130, 394, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-2906, 1064, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-2208, 1345, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1764, 990, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-867, 637, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1534, 1249, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1829, 779, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1707, 579, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1344, 711, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-851, 837, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1367, 1426, 25));
		AddSpawnPoint("f_tableland_28_1.Id3", "f_tableland_28_1", Rectangle(-1779, -6, 25));

		// 'Saltisdaughter_Mage_Red' GenType 39 Spawn Points
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(2163, 328, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(-126, -520, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(577, 28, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(406, 264, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(745, 253, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1173, -558, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1431, -291, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1533, -692, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1607, -481, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(2103, -70, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1802, 905, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(-520, 450, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(-295, 264, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(170, 256, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(2, -641, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1407, -546, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1822, -176, 25));
		AddSpawnPoint("f_tableland_28_1.Id4", "f_tableland_28_1", Rectangle(1739, 737, 25));
	}
}
