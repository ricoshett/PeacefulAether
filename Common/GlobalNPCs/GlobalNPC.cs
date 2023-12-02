using Terraria;
using Terraria.ModLoader;

namespace PeacefulAether;
class AetherGlobalNPC : GlobalNPC
{
    public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns) => maxSpawns *= player.ZoneShimmer ? 0 : 1;
}