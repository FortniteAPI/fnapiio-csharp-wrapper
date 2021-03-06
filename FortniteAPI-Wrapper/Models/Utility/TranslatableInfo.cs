﻿using Newtonsoft.Json;

namespace FortniteAPI.Models.Utility
{
    public class TranslatableInfo
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("intensity")] public string Intensity; // Shop v2 Only
        [JsonProperty("landingPriority")] public int LandingPriority; // Shop v2 Only
        [JsonProperty("partOf")] public string PartOfSet; // Set object only
    }
}