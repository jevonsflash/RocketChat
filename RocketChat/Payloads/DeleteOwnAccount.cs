using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class DeleteOwnAccount : Payload
    {
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
