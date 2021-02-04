using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2CosmeticList
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lang")] public string Language;
        [JsonProperty("itemsCount")] public int ItemsCount;
        [JsonProperty("items")] public V2Cosmetic[] Items;
    }
}