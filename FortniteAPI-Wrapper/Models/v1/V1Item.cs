using System;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1Item
    {
        [JsonProperty("id")] public string ID;
        [JsonProperty("name")] public string Name;
        [JsonProperty("type")] public string Type;
        [JsonProperty("rarity")] public string Rarity;
        [JsonProperty("set")] public string Set;
        [JsonProperty("price")] public int Price;
        [JsonProperty("interest")] public double Interest;
        [JsonProperty("releaseDate")] public DateTime ReleaseDate; // ex. 2020-09-11 | DateTime or string?
        [JsonProperty("description")] public string Description;
        [JsonProperty("reactive")] public bool Reactive;
        [JsonProperty("images")] public V1Images Images;
        [JsonProperty("videos")] public V1Videos[] Videos;
    }
}