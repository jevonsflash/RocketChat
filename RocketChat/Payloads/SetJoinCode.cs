using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetJoinCode : Payload
    {
        [JsonProperty("joinCode")]
        public string JoinCode { get; set; }
    }
}
