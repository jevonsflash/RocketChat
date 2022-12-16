using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetTopic : Payload
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}
