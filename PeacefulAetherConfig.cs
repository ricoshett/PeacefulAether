using System.ComponentModel;
using System.Text.Json.Serialization;
using Terraria;
using Terraria.ModLoader.Config;

namespace PeacefulAether;
class PeacefulAetherConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;
    
    [DefaultValue(false)]
    [JsonIgnore]
    public bool DisableLifeRegeneration;
} 