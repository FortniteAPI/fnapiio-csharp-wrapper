using RestSharp;

namespace FortniteAPI.Endpoints.v1
{
    public class V1Endpoints
    {
        public V1LootListEndpoint LootList { get; }
        public V1CosmeticSetsEndpoint CosmeticSets { get; }
        public V1AchievementsEndpoint Achievements { get; }

        internal V1Endpoints(IRestClient client)
        {
            LootList = new V1LootListEndpoint(client);
            CosmeticSets = new V1CosmeticSetsEndpoint(client);
            Achievements = new V1AchievementsEndpoint(client);
        }
    }
}