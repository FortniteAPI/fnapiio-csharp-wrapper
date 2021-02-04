using Newtonsoft.Json;

namespace FortniteAPI.Models.Utility
{
    public class XYLocation
    {
        [JsonProperty("x")] public int X;
        [JsonProperty("y")] public int Y;
    }
}