using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Bot
    {
        [JsonProperty("i")]
        public string Id { get; set; }
    }
}