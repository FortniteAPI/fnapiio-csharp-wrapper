using RestSharp;

namespace FortniteAPI.Endpoints.V2
{
    public class V2Endpoints
    {
        public V2CosmeticEndpoints Cosmetics { get; }
        public V2ShopEndpoint Shop { get; }

        internal V2Endpoints(IRestClient client)
        {
            Cosmetics = new V2CosmeticEndpoints(client);
            Shop = new V2ShopEndpoint(client);
        }
    }
}