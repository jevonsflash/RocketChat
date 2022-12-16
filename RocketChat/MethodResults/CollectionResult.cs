using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RocketChat.MethodResults
{
    public class CollectionResult
    {
        [JsonProperty("collection")]
        public string Name { get; set; }

        public string Id { get; set; }

        public JObject Fields { get; set; }
    }
}