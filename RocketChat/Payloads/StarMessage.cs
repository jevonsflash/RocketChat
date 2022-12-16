using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class StarMessage : Payload
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }
}
