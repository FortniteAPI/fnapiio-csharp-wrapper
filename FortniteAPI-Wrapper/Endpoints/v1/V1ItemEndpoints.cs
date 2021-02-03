using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1ItemEndpoints : BaseEndpoint
    {
        public V1ItemEndpoints(IRestClient client) : base(client)
        {
        }

        public async Task<V1UpcomingItems> GetUpcomingItemsAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/items/upcoming", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1UpcomingItems>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1UpcomingItems GetUpcomingItems(string lang)
        {
            return GetUpcomingItemsAsync(lang).GetAwaiter().GetResult();
        }
        
        public async Task<V1ItemList> GetItemListAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/items/list", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1ItemList>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }
        
        public V1ItemList GetItemList(string lang)
        {
            return GetItemListAsync(lang).GetAwaiter().GetResult();
        }
    }
}