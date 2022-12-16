using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Preferences
    {
        [JsonProperty("preferences")]
        public Preference _Preferences { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
