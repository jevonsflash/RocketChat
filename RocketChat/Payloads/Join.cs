using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class Join : Payload
    {
        [JsonProperty("joinCode")]
        public string JoinCode { get; set; }
    }
}
