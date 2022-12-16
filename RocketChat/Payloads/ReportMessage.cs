using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class ReportMessage : Payload
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
