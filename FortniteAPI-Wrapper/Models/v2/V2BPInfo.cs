using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2BPInfo
    {
        [JsonProperty("season")] public int Season;
        [JsonProperty("tier")] public int Tier;
        [JsonProperty("type")] public string Type;
        [JsonProperty("displayText")] public V2BPText DisplayText;
    }

    public class V2BPText
    {
        [JsonProperty("chapter")] public string Chapter;
        [JsonProperty("season")] public string Season;
        [JsonProperty("chapterSeason")] public string ChapterSeason;
    }
}