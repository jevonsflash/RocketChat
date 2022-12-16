using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class User
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }

        [JsonProperty("joinDefaultChannels")]
        public bool JoinDefaultChannels { get; set; }

        [JsonProperty("requirePasswordChange")]
        public bool RequirePasswordChange { get; set; }

        [JsonProperty("sendWelcomeEmail")]
        public bool SendWelcomeEmail { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("customFields")]
        public Dictionary<string, object> CustomFields { get; set; }
    }
}
