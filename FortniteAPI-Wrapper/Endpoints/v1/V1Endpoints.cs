using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1Endpoints
    {
        public V1ItemEndpoints Items { get; }

        internal V1Endpoints(IRestClient client)
        {
            Items = new V1ItemEndpoints(client);
        }
    }
}