using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class RegisterUser : Payload
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("pass")]
        public string Password { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("secretURL")]
        public string SecretURL { get; set; }
    }
}
