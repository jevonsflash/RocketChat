using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class UpdateUser
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("data")]
        public User Data { get; set; }
    }
}
