using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v2;
using RestSharp;

namespace FortniteAPI.Endpoints.V2
{
    public class V2ShopEndpoint : BaseEndpoint
    {
        public V2ShopEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V2Shop> GetRadiosAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v2/shop", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V2Shop>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V2Shop GetRadios(string lang)
        {
            return GetRadiosAsync(lang).GetAwaiter().GetResult();
        }
    }
}