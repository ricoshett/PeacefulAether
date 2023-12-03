using System.ComponentModel;
using System.Text.Json.Serialization;
using Terraria;
using Terraria.ModLoader.Config;

namespace PeacefulAether;
class PeacefulAetherConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [DefaultValue(false)]
    public bool DisableLifeRegeneration;

    [DefaultValue(false)]
    public bool DisableTakingDamage;

    [DefaultValue(false)]
	public bool DisableDealingDamage;
    
    [DefaultValue(true)]
	public bool DisableMobSpawn;
}