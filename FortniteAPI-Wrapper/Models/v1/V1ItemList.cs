using System.Collections.Generic;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1ItemList
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lang")] public string Language;
        [JsonProperty("itemsCount")] public int ItemsCount;
        [JsonProperty("items")] public Dictionary<string, V1Item[]> Items;
    }
}