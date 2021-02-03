using System;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1UpcomingItems
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("lastUpdate")] public LastUpdate LastUpdate;
        [JsonProperty("items")] public V1Item[] Items;
    }

    public class LastUpdate
    {
        [JsonProperty("date")] public DateTime Date;
        [JsonProperty("uid")] public string Uid;
    }
}