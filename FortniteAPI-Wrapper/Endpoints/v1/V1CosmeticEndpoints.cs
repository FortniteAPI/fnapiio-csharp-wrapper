using System;
using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    [Obsolete("All v1 cosmetic endpoints are being deprecated, please use FortniteAPI.Endpoints.v2.V2CosmeticEndpoints")]
    public class V1CosmeticEndpoints : BaseEndpoint
    {
        public V1CosmeticEndpoints(IRestClient client) : base(client)
        {
        }

        public async Task<V1UpcomingCosmetics> GetUpcomingCosmeticsAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/items/upcoming", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1UpcomingCosmetics>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1UpcomingCosmetics GetUpcomingCosmetics(string lang)
        {
            return GetUpcomingCosmeticsAsync(lang).GetAwaiter().GetResult();
        }
        
        public async Task<V1CosmeticList> GetCosmeticListAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/items/list", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1CosmeticList>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }
        
        public V1CosmeticList GetCosmeticList(string lang)
        {
            return GetCosmeticListAsync(lang).GetAwaiter().GetResult();
        }
    }
}