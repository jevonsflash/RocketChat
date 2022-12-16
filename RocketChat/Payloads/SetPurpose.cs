using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetPurpose : Payload
    {
        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
