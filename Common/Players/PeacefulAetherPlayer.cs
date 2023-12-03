using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using PeacefulAether;

namespace PeacefulAether.Common.Players;
class PeacefulAetherPlayer : ModPlayer
{
    public override void UpdateLifeRegen() => Player.lifeRegen *= ModContent.GetInstance<PeacefulAetherConfig>().DisableLifeRegeneration && Player.ZoneShimmer ? 0 : 1;
    public override void NaturalLifeRegen(ref float regen) => regen = ModContent.GetInstance<PeacefulAetherConfig>().DisableLifeRegeneration && Player.ZoneShimmer ? 0 : regen;
    public override bool ImmuneTo(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable) => ModContent.GetInstance<PeacefulAetherConfig>().DisableTakingDamage && Player.ZoneShimmer;
    public override bool CanHitNPC(NPC target)
	{
		if (!ModContent.GetInstance<PeacefulAetherConfig>().DisableDealingDamage)
		{
			return true;
		}
		return ModContent.GetInstance<PeacefulAetherConfig>().DisableDealingDamage && !Player.ZoneShimmer;
	}
}
