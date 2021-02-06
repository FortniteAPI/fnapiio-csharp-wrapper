using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1CosmeticSetsEndpoint : BaseEndpoint
    {
        public V1CosmeticSetsEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V1ItemSets> GetItemSetsAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/items/sets", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1ItemSets>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1ItemSets GetItemSets(string lang)
        {
            return GetItemSetsAsync(lang).GetAwaiter().GetResult();
        }
    }
}