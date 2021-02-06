using FortniteAPI.Models.Utility;
using FortniteAPI.Util;

namespace FortniteAPI.Models.v2
{
    public class V2CosmeticListParams
    {
        public Optional<string> Lang { get; set; }
        public Optional<string> SearchLang { get; set; }
        public Optional<string> Id { get; set; }
        public Optional<TranslatableInfo> Type { get; set; }
        public Optional<string> Name { get; set; }
        public Optional<string> Description { get; set; }
        public Optional<TranslatableInfo> Rarity { get; set; }
        public Optional<TranslatableInfo> Series { get; set; }
        public Optional<int> Price { get; set; }
        public Optional<V2Added> Added { get; set; }
        public Optional<V2Cosmetic> BuiltInEmote { get; set; }
        public Optional<bool> CopyrightedAudio { get; set; }
        public Optional<bool> Upcoming { get; set; }
        public Optional<bool> Reactive { get; set; }
        public Optional<string> ReleaseDate { get; set; }
        public Optional<string> LastAppearance { get; set; }
        public Optional<double> Interest { get; set; }
        public Optional<Images> Images { get; set; }
        public Optional<string> Video { get; set; }
        public Optional<string[]> GameplayTags { get; set; }
        public Optional<GameplayTagSearchType> GameplayTagSearchType { get; set; }
        public Optional<V2BPInfo> BattlePass { get; set; }
        public Optional<TranslatableInfo> Set { get; set; }
    }
}