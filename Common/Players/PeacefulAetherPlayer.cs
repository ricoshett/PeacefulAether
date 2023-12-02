using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using PeacefulAether;

namespace PeacefulAether.Common.Players;
class PeacefulAetherPlayer : ModPlayer
{
    private bool isLifeRegenDisabled = ModContent.GetInstance<PeacefulAetherConfig>().DisableLifeRegeneration;
    public override void UpdateLifeRegen() => Player.lifeRegen *= isLifeRegenDisabled && Player.ZoneShimmer ? 0 : 1;
    public override void ModifyWeaponDamage(Item item, ref StatModifier damage) => damage *= Player.ZoneShimmer ? 0 : 1;
    public override bool ImmuneTo(PlayerDeathReason damageSource, int cooldownCounter, bool dodgeable) => Player.ZoneShimmer;
    public override void NaturalLifeRegen(ref float regen) => regen = Player.ZoneShimmer ? 0 : regen;
    public override bool CanHitNPC(NPC target) => !Player.ZoneShimmer;
}
