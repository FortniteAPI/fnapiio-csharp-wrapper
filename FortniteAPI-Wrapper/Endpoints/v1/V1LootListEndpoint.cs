using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1LootListEndpoint : BaseEndpoint
    {
        public V1LootListEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V1LootList> GetLootListAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/loot/list", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1LootList>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1LootList GetLootList(string lang)
        {
            return GetLootListAsync(lang).GetAwaiter().GetResult();
        }
    }
}