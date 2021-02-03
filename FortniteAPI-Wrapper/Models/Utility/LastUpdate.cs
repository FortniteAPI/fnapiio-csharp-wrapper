using System;
using Newtonsoft.Json;

namespace FortniteAPI.Models.Utility
{
    public class LastUpdate
    {
        [JsonProperty("date")] public DateTime Date;
        [JsonProperty("uid")] public string Uid;
    }
}