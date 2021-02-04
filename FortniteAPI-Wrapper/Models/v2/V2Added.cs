using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2Added
    {
        [JsonProperty("date")] public string Date;
        [JsonProperty("version")] public string Version;
    }
}