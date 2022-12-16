using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class UpdateOwnBasicInfo : Payload
    {
        [JsonProperty("data")]
        public OwnBasicInfo Data { get; set; }


        public class OwnBasicInfo
        {
            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("currentPassword")]
            public string CurrentPassword { get; set; }

            [JsonProperty("newPassword")]
            public string NewPassword { get; set; }

            [JsonProperty("customFields")]
            public string customFields { get; set; }
        }
    }
}
