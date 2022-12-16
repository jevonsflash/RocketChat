using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class AddAll : Payload
    {
        [JsonProperty("activeUsersOnly")]
        public bool ActiveUsersOnly { get; set; }
    }
}
