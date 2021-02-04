using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v2;
using RestSharp;

namespace FortniteAPI.Endpoints.V2
{
    public class V2ChallengesEndpoint : BaseEndpoint
    {
        public V2ChallengesEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V2Challenges> GetChallengesAsync(string lang, int season, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v2/shop", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            if (!string.IsNullOrWhiteSpace(season.ToString()))
            {
                request.AddQueryParameter("season", season.ToString());
            }

            var res = await Client.ExecuteAsync<V2Challenges>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V2Challenges GetChallenges(string lang, int season)
        {
            return GetChallengesAsync(lang, season).GetAwaiter().GetResult();
        }
    }
}