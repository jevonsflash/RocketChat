using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Email
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}