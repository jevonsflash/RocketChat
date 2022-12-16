using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Moderators
    {
        [JsonProperty("moderators")]
        public IEnumerable<User> _Moderators { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}