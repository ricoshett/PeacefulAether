using Terraria;
using Terraria.ModLoader;
using PeacefulAether;

namespace PeacefulAether;
class AetherGlobalNPC : GlobalNPC
{
    public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns) => maxSpawns *= ModContent.GetInstance<PeacefulAetherConfig>().DisableMobSpawn && player.ZoneShimmer ? 0 : 1;
}