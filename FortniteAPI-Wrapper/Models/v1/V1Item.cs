using System;
using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1Item
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("type")] public string Type;
        [JsonProperty("rarity")] public string Rarity;
        [JsonProperty("internalRarity")] public string InternalRarity;
        [JsonProperty("set")] public string Set;
        [JsonProperty("price")] public int Price;
        [JsonProperty("added")] public DateTime Added;
        [JsonProperty("interest")] public double Interest;
        [JsonProperty("releaseDate")] public DateTime ReleaseDate; // ex. 2020-09-11 | DateTime or string?
        [JsonProperty("description")] public string Description;
        [JsonProperty("reactive")] public bool Reactive;
        [JsonProperty("images")] public Images Images;
        [JsonProperty("videos")] public V1Videos[] Videos;
        [JsonProperty("video")] public string Video;
        [JsonProperty("gameplayTags")] public string[] GameplayTags;
    }
}