using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class Rename : Payload
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
