using FortniteAPI.Util;

namespace FortniteAPI.Models.v1
{
    public class V1CosmeticListParams
    {
        public Optional<string> Lang { get; set; }
        public Optional<string> Name { get; set; }
        public Optional<string> Id { get; set; }
    }
}