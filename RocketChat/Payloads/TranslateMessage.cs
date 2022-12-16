using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class TranslateMessage : Payload
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("targetLanguage")]
        public string TargetLanguage { get; set; }
    }
}
