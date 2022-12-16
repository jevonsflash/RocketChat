using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class ForgotPassword : Payload
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
