using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class Update : Payload
    {
        [JsonProperty("msgId")]
        public string MessageId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
