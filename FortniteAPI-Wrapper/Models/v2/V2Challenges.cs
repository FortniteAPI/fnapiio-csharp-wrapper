using System.Collections.Generic;
using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2Challenges
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("season")] public int Season;
        [JsonProperty("lang")] public string Language;
        [JsonProperty("bundles")] public V2MissionBundles[] Bundles;
    }

    public class V2MissionBundles
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("unlockType")] public string UnlockType;
        [JsonProperty("tags")] public string[] Tags;
        [JsonProperty("colors")] public Dictionary<string, string> Colors;
        [JsonProperty("images")] public Dictionary<string, string> Images;
        [JsonProperty("bundleRewards")] public V2Cosmetic[] BundleRewards;
        [JsonProperty("quests")] public V2Quest[] Quests;
    }

    public class V2Quest
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("enabled")] public bool Enabled;
        [JsonProperty("parentQuest")] public string ParentQuest;
        [JsonProperty("progressTotal")] public int ProgressTotal;
        [JsonProperty("tags")] public string[] Tags;
        [JsonProperty("reward")] public V2QuestReward Reward;
        [JsonProperty("locations")] public V2QuestLocation[] Locations;
    }

    public class V2QuestLocation
    {
        [JsonProperty("tag")] public string Tag;
        [JsonProperty("location")] public XYLocation Location;
    }

    public class V2QuestReward
    {
        [JsonProperty("xp")] public int Xp;
        [JsonProperty("items")] public V2Cosmetic[] Items;
    }
}