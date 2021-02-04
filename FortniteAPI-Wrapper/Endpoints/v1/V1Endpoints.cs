using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1Endpoints
    {
        public V1LootListEndpoint LootList { get; }

        internal V1Endpoints(IRestClient client)
        {
            LootList = new V1LootListEndpoint(client);
        }
    }
}