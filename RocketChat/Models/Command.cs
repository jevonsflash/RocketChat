using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Command
    {
        [JsonProperty("command")]
        public string _Command { get; set; }

        [JsonProperty("params")]
        public string Params { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("clientOnly")]
        public bool ClientOnly { get; set; }
    }
}