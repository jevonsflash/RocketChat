using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class React : Payload
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("shouldReact")]
        public bool ShouldReact { get; set; }
    }
}
