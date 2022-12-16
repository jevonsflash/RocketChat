using Newtonsoft.Json;

namespace RocketChat.Authentication
{
    public class LoginRequest
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}