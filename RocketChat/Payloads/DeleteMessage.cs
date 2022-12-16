using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class DeleteMessage : Payload
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("asUser")]
        public bool AsUser { get; set; }
    }
}
