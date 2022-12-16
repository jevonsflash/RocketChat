using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Emojis
    {
        [JsonProperty("emojis")]
        public IEnumerable<Emoji> _Emojis { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}