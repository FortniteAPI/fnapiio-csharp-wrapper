using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FortniteAPI.Models.v1
{
    public class V1Shop
    {
        [JsonProperty("uid")] public string Uid;
        [JsonProperty("fullShop")] public bool FullShop;
        [JsonProperty("endingDates")] public Dictionary<string, string> EndingDates;
        [JsonProperty("featured")] public V1ShopCosmetic[] Featured;
        [JsonProperty("daily")] public V1ShopCosmetic[] Daily;
        [JsonProperty("specialFeatured")] public V1ShopCosmetic[] SpecialFeatured;
        [JsonProperty("specialDaily")] public V1ShopCosmetic[] SpecialDaily;
        [JsonProperty("community")] public V1ShopCosmetic[] Community;
        [JsonProperty("offers")] public V1ShopCosmetic[] Offers;
    }

    public class V1ShopCosmetic
    {
        [JsonProperty("id")] public string Id;
        [JsonProperty("name")] public string Name;
        [JsonProperty("type")] public string Type;
        [JsonProperty("internalRarity")] public string InternalRarity;
        [JsonProperty("price")] public int Price;
        [JsonProperty("priceNoDiscount")] public int PriceNoDiscount;
        [JsonProperty("categories")] public string Categories;
        [JsonProperty("priority")] public int Priority;
        [JsonProperty("banner")] public string Banner;
        [JsonProperty("offer")] public string Offer;
        [JsonProperty("releaseDate")] public DateTime ReleaseDate;
        [JsonProperty("lastAppearance")] public DateTime LastAppearance;
        [JsonProperty("giftAllowed")] public bool GiftAllowed;
        [JsonProperty("buyAllowed")] public bool BuyAllowed;
        [JsonProperty("image")] public string Image;
        [JsonProperty("icon")] public string Icon;
        [JsonProperty("full_background")] public string FullBackground;
        [JsonProperty("items")] public string[] Items;
        [JsonProperty("otherItemsDetails")] public V1Cosmetic[] OtherItemsDetails;
        [JsonProperty("videos")] public V1Videos[] Videos;
        [JsonProperty("customColors")] public V1ShopColors CustomColors;
    }

    public class V1ShopColors
    {
        [JsonProperty("background")] public string Background;
        [JsonProperty("gradiant")] public DaGradiant Gradiant;

        public class DaGradiant
        {
            [JsonProperty("start")] public string Start;
            [JsonProperty("stop")] public string Stop;
        }
    }
}