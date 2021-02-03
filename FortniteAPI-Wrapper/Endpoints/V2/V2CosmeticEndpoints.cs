using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v2;
using RestSharp;

namespace FortniteAPI.Endpoints.V2
{
    public class V2CosmeticEndpoints : BaseEndpoint
    {
        public V2CosmeticEndpoints(IRestClient client) : base(client)
        {
        }

        public async Task<V2UpcomingCosmetics> GetUpcomingCosmeticsAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v2/items/upcoming", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V2UpcomingCosmetics>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V2UpcomingCosmetics GetUpcomingCosmetics(string lang)
        {
            return GetUpcomingCosmeticsAsync(lang).GetAwaiter().GetResult();
        }
    }
}