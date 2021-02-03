using Newtonsoft.Json;

namespace FortniteAPI.Models.v1.Premium
{
    public class V1Radio
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("enabled")] public bool Enabled;
        [JsonProperty("icon")] public string Icon;
        [JsonProperty("versions")] public V1RadioVersion[] Versions;
    }

    public class V1RadioVersion
    {
        [JsonProperty("version")] public int Version;
        [JsonProperty("url")] public string Url;
    }
}