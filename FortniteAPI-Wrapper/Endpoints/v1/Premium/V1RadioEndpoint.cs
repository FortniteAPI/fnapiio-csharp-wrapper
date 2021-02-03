using System.Threading;
using System.Threading.Tasks;
using FortniteAPI.Models.v1.Premium;
using RestSharp;

namespace FortniteAPI.Endpoints.v1.Premium
{
    public class V1RadioEndpoint : BaseEndpoint
    {
        public V1RadioEndpoint(IRestClient client) : base(client)
        {
        }

        public async Task<V1Radios> GetRadiosAsync(string lang, CancellationToken cancellationToken = default)
        {
            var request = new RestRequest("v1/game/radios", Method.GET);

            if (!string.IsNullOrWhiteSpace(lang))
            {
                request.AddQueryParameter("lang", lang);
            }

            var res = await Client.ExecuteAsync<V1Radios>(request, cancellationToken).ConfigureAwait(false);
            return res.Data;
        }

        public V1Radios GetRadios(string lang)
        {
            return GetRadiosAsync(lang).GetAwaiter().GetResult();
        }
    }
}