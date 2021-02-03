using Newtonsoft.Json;

namespace FortniteAPI.Models.v1.Premium
{
    public class V1Radios
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lang")] public string Language;
        [JsonProperty("radios")] public V1Radio[] Radios;
    }
}