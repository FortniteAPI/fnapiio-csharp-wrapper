using RestSharp;

namespace FortniteAPI.Endpoints.V2
{
    public class V2Endpoints
    {
        public V2ItemEndpoints Items { get; }

        internal V2Endpoints(IRestClient client)
        {
            Items = new V2ItemEndpoints(client);
        }
    }
}