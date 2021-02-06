using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1Achievements
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("season")] public int Season;
        [JsonProperty("achievements")] public V1Achievement[] Achievements;
    }

    public class V1Achievement
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("description")] public string Description;
        [JsonProperty("total")] public int Total;
        [JsonProperty("image")] public string Image;
    }
}