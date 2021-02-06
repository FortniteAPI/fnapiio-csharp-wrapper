using System;
using System.Collections.Generic;
using FortniteAPI.Models.Utility;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v2
{
    public class V2Shop
    {
        [JsonProperty("result")] public bool Result;
        [JsonProperty("fullShop")] public bool FullShop;
        [JsonProperty("lastUpdate")] public LastUpdate LastUpdate;
        [JsonProperty("currentRotation")] public Dictionary<string, string> CurrentRotation;
        [JsonProperty("nextRotation")] public Dictionary<string, string> NextRotation;
        [JsonProperty("carousel")] public V2ShopCarousel Carousel;
        [JsonProperty("shop")] public V2ShopCosmetics[] Shop;
    }

    public class V2ShopCosmetics
    {
        [JsonProperty("displayName")] public string DisplayName;
        [JsonProperty("displayDescription")] public string DisplayDescription;
        [JsonProperty("displayType")] public string DisplayType;
        [JsonProperty("mainType")] public string MainType;
        [JsonProperty("offerId")] public string OfferId;
        [JsonProperty("displayAssets")] public DAv2[] DisplayAssets;
        [JsonProperty("firstReleaseDate")] public DateTime FirstReleaseDate;
        [JsonProperty("previousReleaseDate")] public DateTime PreviousReleaseDate;
        [JsonProperty("giftAllowed")] public bool GiftAllowed;
        [JsonProperty("buyAllowed")] public bool BuyAllowed;
        [JsonProperty("price")] public V2ShopPrice Price;
        [JsonProperty("rarity")] public TranslatableInfo Rarity;
        [JsonProperty("series")] public TranslatableInfo Series;
        [JsonProperty("banner")] public TranslatableInfo Banner;
        [JsonProperty("granted")] public V2Cosmetic[] Granted;
        [JsonProperty("priority")] public int Priority;
        [JsonProperty("section")] public TranslatableInfo Section;
        [JsonProperty("groupIndex")] public int GroupIndex;
        [JsonProperty("storeName")] public string StoreName;
        [JsonProperty("tileSize")] public string TileSize;
        [JsonProperty("categories")] public string[] Category;
    }

    public class V2ShopPrice
    {
        [JsonProperty("regularPrice")] public int RegularPrice;
        [JsonProperty("finalPrice")] public int FinalPrice;
    }
    
    public class V2ShopCarousel
    {
        [JsonProperty("title")] public string Title;
        [JsonProperty("url")] public string Url;
        [JsonProperty("offerId")] public string OfferId;
    }

    public class DAv2
    {
        [JsonProperty("url")] public string Url;
        [JsonProperty("background")] public string Background;
    }
}