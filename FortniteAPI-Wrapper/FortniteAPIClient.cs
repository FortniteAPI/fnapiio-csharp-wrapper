using System;
using System.Reflection;
using FortniteAPI.Endpoints.v1;
using FortniteAPI.Endpoints.V2;
using FortniteAPI.Util;
using RestSharp;

namespace FortniteAPI
{
    public class FortniteAPIClient
    {
        public V1Endpoints V1Endpoints { get; }
        public V2Endpoints V2Endpoints { get; }

        public FortniteAPIClient(string api)
        {
            if (!string.IsNullOrWhiteSpace(api))
            {
                var ver = Assembly.GetExecutingAssembly().GetName().Version;

                var rest = new RestClient("https://fortniteapi.io")
                {
                    UserAgent = $"FortniteAPIIO/{ver?.ToString(3)}",
                    Timeout = 10 * 1000
                }.UseSerializer<JsonNetSerializer>();

                V1Endpoints = new V1Endpoints(rest);
                V2Endpoints = new V2Endpoints(rest);
            }
            else
            {
                throw new Exception("API is required, please supply an API key in the constructor");
            }
        }
    }
}