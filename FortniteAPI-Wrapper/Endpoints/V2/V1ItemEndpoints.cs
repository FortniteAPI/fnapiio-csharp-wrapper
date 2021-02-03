using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v2;
using RestSharp;

namespace FortniteAPI.Endpoints.V2
{
    public class V2ItemEndpoints : BaseEndpoint
    {
        public V2ItemEndpoints(IRestClient client) : base(client)
        {
        }

        public async Task<V2UpcomingItems> GetUpcomingItemsAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v2/items/upcoming", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V2UpcomingItems>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V2UpcomingItems GetUpcomingItems(string lang)
        {
            return GetUpcomingItemsAsync(lang).GetAwaiter().GetResult();
        }
    }
}