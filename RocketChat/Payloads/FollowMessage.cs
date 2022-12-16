using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class FollowMessage : Payload
    {
        [JsonProperty("mid")]
        public string MessageId { get; set; }
    }
}
