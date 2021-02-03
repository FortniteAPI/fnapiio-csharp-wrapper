using RestSharp;

namespace FortniteAPI.Endpoints
{
    public abstract class BaseEndpoint
    {
        internal readonly IRestClient Client;

        internal BaseEndpoint(IRestClient client)
        {
            Client = client;
        }
    }
}