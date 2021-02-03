using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1Endpoints
    {
        public V1CosmeticEndpoints Cosmetics { get; }

        internal V1Endpoints(IRestClient client)
        {
            Cosmetics = new V1CosmeticEndpoints(client);
        }
    }
}