using System;
using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    [Obsolete("Shop v1 is being deprecated, please use FortniteAPI.Endpoints.v2.V2ShopEndpoint")]
    public class V1ShopEndpoint : BaseEndpoint
    {
        public V1ShopEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V1Shop> GetRadiosAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/shop", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1Shop>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1Shop GetRadios(string lang)
        {
            return GetRadiosAsync(lang).GetAwaiter().GetResult();
        }
    }
}