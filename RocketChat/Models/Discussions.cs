using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Discussions
    {
        [JsonProperty("discussions")]
        public IEnumerable<Discussion> _Discussions { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}