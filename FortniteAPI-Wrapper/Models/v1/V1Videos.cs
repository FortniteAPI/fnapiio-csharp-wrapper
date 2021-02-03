using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1Videos
    {
        [JsonProperty("type")] public string Type;
        [JsonProperty("url")] public string Url;
    }
}