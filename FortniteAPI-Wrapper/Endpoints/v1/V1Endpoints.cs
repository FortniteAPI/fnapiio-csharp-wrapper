using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1Endpoints
    {
        public V1CosmeticEndpoints Cosmetics { get; }
        public V1ShopEndpoint Shop { get; }
        public V1LootListEndpoint LootList { get; }

        internal V1Endpoints(IRestClient client)
        {
            Cosmetics = new V1CosmeticEndpoints(client);
            Shop = new V1ShopEndpoint(client);
            LootList = new V1LootListEndpoint(client);
        }
    }
}