using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class UserAction : Payload
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }
    }
}
