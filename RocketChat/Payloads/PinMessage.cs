using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class PinMessage : Payload
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
    }
}
