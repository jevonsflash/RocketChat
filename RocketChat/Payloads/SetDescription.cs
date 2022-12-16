using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetDescription : Payload
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
