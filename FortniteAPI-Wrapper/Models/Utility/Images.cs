﻿using Newtonsoft.Json;

namespace FortniteAPI.Models.Utility
{
    public class Images
    {
        [JsonProperty("icon")] public string Icon;
        [JsonProperty("featured")] public string Featured;
        [JsonProperty("background")] public string Background;
        [JsonProperty("full_background")] public string FullBackground;
    }
}