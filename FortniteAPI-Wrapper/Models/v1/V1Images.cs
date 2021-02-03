using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1Images
    {
        [JsonProperty("icon")] public string Icon;
        [JsonProperty("featured")] public string Featured;
        [JsonProperty("background")] public string Background;
        [JsonProperty("full_background")] public string FullBackground;
    }
}