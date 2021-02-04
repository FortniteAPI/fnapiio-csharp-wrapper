using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1LootList
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lang")] public string Language;
        [JsonProperty("weapons")] public V1Weapons[] Weapons;
    }

    public class V1Weapons
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("enabled")] public bool Enabled;
        [JsonProperty("name")] public string Name;
        [JsonProperty("description")] public string Description;
        [JsonProperty("rarity")] public string Rarity;
        [JsonProperty("type")] public string Type;
        [JsonProperty("gameplayTags")] public string[] GameplayTags;
        [JsonProperty("searchTags")] public string SearchTags;
        [JsonProperty("images")] public Images Images;
        [JsonProperty("mainStats")] public V1WeaponMainStats MainStats;
        [JsonProperty("chances")] public V1WeaponChances[] Chances;
    }

    public class V1WeaponMainStats
    {
        [JsonProperty("DmgPB")] public double DamagePB;
        [JsonProperty("FiringRate")] public double FiringRate;
        [JsonProperty("ClipSize")] public double ClipSize;
        [JsonProperty("ReloadTime")] public double ReloadTime;
        [JsonProperty("BulletsPerCartridge")] public double BulletsPerCartridge;
        [JsonProperty("Spread")] public double Spread;
        [JsonProperty("SpreadDownsights")] public double SpreadDownsights;
        [JsonProperty("DamageZone_Critical")] public double DamageZoneCritical;
    }

    public class V1WeaponChances
    {
        [JsonProperty("type")] public string Type;
        [JsonProperty("chance")] public double Chance;
        [JsonProperty("group")] public int Group;
        [JsonProperty("count")] public int Count;
    }
}