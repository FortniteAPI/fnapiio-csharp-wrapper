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
                request.AddParameter("lang", p.Lang.Value);
            }

            if (p.SearchLang.HasValue)
            {
                request.AddParameter("searchLang", p.SearchLang.Value);
            }

            if (p.Id.HasValue)
            {
                request.AddParameter("id", p.Id.Value);
            }

            if (p.Type.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Type.Value.Id))
                {
                    request.AddParameter("type.id", p.Type.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Type.Value.Name))
                {
                    request.AddParameter("type.name", p.Type.Value.Name);
                }
            }

            if (p.Name.HasValue)
            {
                request.AddParameter("name", p.Name.Value);
            }

            if (p.Description.HasValue)
            {
                request.AddParameter("description", p.Description.Value);
            }

            if (p.Rarity.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Rarity.Value.Id))
                {
                    request.AddParameter("rarity.id", p.Rarity.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Rarity.Value.Name))
                {
                    request.AddParameter("rarity.name", p.Rarity.Value.Name);
                }
            }

            if (p.Series.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Series.Value.Id))
                {
                    request.AddParameter("series.id", p.Series.Value.Id);
                }

                if (!string.IsNullOrWhiteSpace(p.Series.Value.Name))
                {
                    request.AddParameter("series.name", p.Series.Value.Name);
                }
            }

            if (p.Price.HasValue)
            {
                request.AddParameter("price", p.Price.Value);
            }

            if (p.Added.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Added.Value.Date))
                {
                    request.AddParameter("added.date", p.Added.Value.Date);
                }

                if (!string.IsNullOrWhiteSpace(p.Added.Value.Version))
                {
                    request.AddParameter("added.version", p.Added.Value.Version);
                }
            }

            // p.BuiltInEmote

            if (p.CopyrightedAudio.HasValue)
            {
                request.AddParameter("copyrightedAudio", p.CopyrightedAudio.Value);
            }

            if (p.Upcoming.HasValue)
            {
                request.AddParameter("upcoming", p.Upcoming.Value);
            }

            if (p.Reactive.HasValue)
            {
                request.AddParameter("reactive", p.Reactive.Value);
            }

            if (p.ReleaseDate.HasValue)
            {
                request.AddParameter("releaseDate", p.ReleaseDate.Value);
            }

            if (p.LastAppearance.HasValue)
            {
                request.AddParameter("lastAppearance", p.LastAppearance.Value);
            }

            if (p.Interest.HasValue)
            {
                request.AddParameter("interest", p.Interest.Value);
            }

            if (p.Images.HasValue)
            {
                if (!string.IsNullOrWhiteSpace(p.Images.Value.Icon))
                {
                    request.AddParameter("images.icon", p.Images.Value.Icon);
                }

                if (!string.IsNullOrWhiteSpace(p.Images.Value.Featured))
                {
                    request.AddParameter("images.featured", p.Images.Value.Featured);
                }

                if (!string.IsNullOrWhiteSpace(p.Images.Value.Background))
                {
                    request.AddParameter("images.background", p.Images.Value.Background);
                }

                if (!string.IsNullOrWhiteSpace(p.Images.Value.FullBackground))
                {
                    request.AddParameter("images.full_background", p.Images.Value.FullBackground);
                }
            }

            if (p.Video.HasValue)
            {
                request.AddParameter("video", p.Video.Value);
            }

            return request;
        }
    }
}