using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2UpcomingCosmetics
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lastUpdate")] public LastUpdate LastUpdate;
        [JsonProperty("items")] public V2Cosmetic[] Items;
    }
}