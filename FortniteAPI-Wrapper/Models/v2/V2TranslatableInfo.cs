using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2TranslatableInfo
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("partOf")] public string PartOfSet;
    }
}