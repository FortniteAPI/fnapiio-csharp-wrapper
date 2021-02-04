using System;
using FortniteAPI.Models.v2;
using RestSharp;

namespace FortniteAPI.Util
{
    public static class Ext
    {
        public static IRestRequest ApplyParams(this IRestRequest request, Action<V2CosmeticListParams> param)
        {
            var p = new V2CosmeticListParams();
            param(p);

            if (p.Lang.HasValue)
            {
                request.AddQueryParameter("lang", p.Lang.Value);
            }

            if (p.SearchLang.HasValue)
            {
                request.AddQueryParameter("searchLang", p.SearchLang.Value);
            }

            if (p.Id.HasValue)
            {
                request.AddQueryParameter("id", p.Id.Value);
            }

            if (p.Type.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Type.Value.Id))
                {
                    request.AddQueryParameter("type.id", p.Type.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Type.Value.Name))
                {
                    request.AddQueryParameter("type.name", p.Type.Value.Name);
                }
            }

            if (p.Name.HasValue)
            {
                request.AddQueryParameter("name", p.Name.Value);
            }

            if (p.Description.HasValue)
            {
                request.AddQueryParameter("description", p.Description.Value);
            }

            if (p.Rarity.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Rarity.Value.Id))
                {
                    request.AddQueryParameter("rarity.id", p.Rarity.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Rarity.Value.Name))
                {
                    request.AddQueryParameter("rarity.name", p.Rarity.Value.Name);
                }
            }

            if (p.Series.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Series.Value.Id))
                {
                    request.AddQueryParameter("series.id", p.Series.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Series.Value.Name))
                {
                    request.AddQueryParameter("series.name", p.Series.Value.Name);
                }
            }

            if (p.Price.HasValue)
            {
                request.AddQueryParameter("price", p.Price.Value.ToString());
            }

            if (p.Added.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Added.Value.Date))
                {
                    request.AddQueryParameter("added.date", p.Added.Value.Date);
                }

                if (!string.IsNullOrWhiteSpace(p.Added.Value.Version))
                {
                    request.AddQueryParameter("added.version", p.Added.Value.Version);
                }
            }

            if (p.BuiltInEmote.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Id))
                {
                    request.AddQueryParameter("builtInEmote.id", p.BuiltInEmote.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Name))
                {
                    request.AddQueryParameter("builtInEmote.name", p.BuiltInEmote.Value.Name);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Rarity.Id))
                {
                    request.AddQueryParameter("builtInEmote.rarity.id", p.BuiltInEmote.Value.Rarity.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Rarity.Name))
                {
                    request.AddQueryParameter("builtInEmote.rarity.name", p.BuiltInEmote.Value.Rarity.Name);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Images.Icon))
                {
                    request.AddQueryParameter("builtInEmote.images.icon", p.BuiltInEmote.Value.Images.Icon);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Images.Featured))
                {
                    request.AddQueryParameter("builtInEmote.images.featured", p.BuiltInEmote.Value.Images.Featured);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Images.Background))
                {
                    request.AddQueryParameter("builtInEmote.images.background", p.BuiltInEmote.Value.Images.Background);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Images.FullBackground))
                {
                    request.AddQueryParameter("builtInEmote.images.full_background", p.BuiltInEmote.Value.Images.FullBackground);
                }

                if (!string.IsNullOrWhiteSpace(p.BuiltInEmote.Value.Video))
                {
                    request.AddQueryParameter("builtInEmote.video", p.BuiltInEmote.Value.Video);
                }
            }

            if (p.CopyrightedAudio.HasValue)
            {
                request.AddQueryParameter("copyrightedAudio", p.CopyrightedAudio.Value.ToString());
            }

            if (p.Upcoming.HasValue)
            {
                request.AddQueryParameter("upcoming", p.Upcoming.Value.ToString());
            }

            if (p.Reactive.HasValue)
            {
                request.AddQueryParameter("reactive", p.Reactive.Value.ToString());
            }

            if (p.ReleaseDate.HasValue)
            {
                request.AddQueryParameter("releaseDate", p.ReleaseDate.Value);
            }

            if (p.LastAppearance.HasValue)
            {
                request.AddQueryParameter("lastAppearance", p.LastAppearance.Value);
            }

            if (p.Interest.HasValue)
            {
                request.AddQueryParameter("interest", p.Interest.Value.ToString());
            }

            if (p.Images.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Images.Value.Icon))
                {
                    request.AddQueryParameter("images.icon", p.Images.Value.Icon);
                }

                if (!string.IsNullOrWhiteSpace(p.Images.Value.Featured))
                {
                    request.AddQueryParameter("images.featured", p.Images.Value.Featured);
                }

                if (!string.IsNullOrWhiteSpace(p.Images.Value.Background))
                {
                    request.AddQueryParameter("images.background", p.Images.Value.Background);
                }

                if (!string.IsNullOrWhiteSpace(p.Images.Value.FullBackground))
                {
                    request.AddQueryParameter("images.full_background", p.Images.Value.FullBackground);
                }
            }

            if (p.Video.HasValue)
            {
                request.AddQueryParameter("video", p.Video.Value);
            }

            if (p.GameplayTags.HasValue && p.GameplayTagSearchType.HasValue)
            {
                switch (p.GameplayTagSearchType.Value)
                {
                    case GameplayTagSearchType.OR:
                        request.AddQueryParameter("gameplayTags", string.Join("|", p.GameplayTags.Value));
                        break;
                    case GameplayTagSearchType.AND:
                        request.AddQueryParameter("gameplayTags", string.Join(",", p.GameplayTags.Value));
                        break;
                    default:
                        if (p.GameplayTags.Value.Length == 1)
                        {
                            request.AddQueryParameter("gameplayTags", p.GameplayTags.Value[0]);
                            break;
                        }

                        throw new ArgumentOutOfRangeException();
                }
            }

            if (p.BattlePass.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.Season.ToString()))
                {
                    request.AddQueryParameter("battlepass.season", p.BattlePass.Value.Season.ToString());
                }

                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.Tier.ToString()))
                {
                    request.AddQueryParameter("battlepass.tier", p.BattlePass.Value.Tier.ToString());
                }

                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.Type))
                {
                    request.AddQueryParameter("battlepass.type", p.BattlePass.Value.Type);
                }

                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.DisplayText.Chapter))
                {
                    request.AddQueryParameter("battlepass.displayText.chapter", p.BattlePass.Value.DisplayText.Chapter);
                }

                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.DisplayText.Season))
                {
                    request.AddQueryParameter("battlepass.displayText.season", p.BattlePass.Value.DisplayText.Season);
                }

                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.DisplayText.ChapterSeason))
                {
                    request.AddQueryParameter("battlepass.displayText.chapterSeason", p.BattlePass.Value.DisplayText.ChapterSeason);
                }

                if (!string.IsNullOrWhiteSpace(p.BattlePass.Value.BattlePassName))
                {
                    request.AddQueryParameter("battlepass.battlePassName", p.BattlePass.Value.BattlePassName);
                }
            }

            if (p.Set.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Set.Value.Id))
                {
                    request.AddQueryParameter("set.id", p.Set.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Set.Value.Name))
                {
                    request.AddQueryParameter("set.name", p.Set.Value.Name);
                }

                if (!string.IsNullOrWhiteSpace(p.Set.Value.PartOfSet))
                {
                    request.AddQueryParameter("set.partOf", p.Set.Value.PartOfSet);
                }
            }

            return request;
        }
    }
}