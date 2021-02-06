using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1AchievementsEndpoint : BaseEndpoint
    {
        public V1AchievementsEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V1Achievements> GetAchievementsAsync(string lang, string season, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/achievements", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            if (!string.IsNullOrWhiteSpace(season))
            {
                request.AddQueryParameter("season", season);
            }

            var res = await Client.ExecuteAsync<V1Achievements>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1Achievements GetAchievements(string lang, string season)
        {
            return GetAchievementsAsync(lang, season).GetAwaiter().GetResult();
        }
    }
}