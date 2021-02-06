using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1ItemSets
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lang")] public string Language;
        [JsonProperty("sets")] public TranslatableInfo[] Sets;
    }
}