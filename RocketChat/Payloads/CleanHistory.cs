using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class CleanHistory : Payload
    {
        [JsonProperty("latest")]
        public DateTime Latest { get; set; }

        [JsonProperty("oldest")]
        public DateTime Oldest { get; set; }

        [JsonProperty("inclusive")]
        public bool Inclusive { get; set; }

        [JsonProperty("excludePinned")]
        public bool ExcludePinned { get; set; }

        [JsonProperty("filesOnly")]
        public bool FilesOnly { get; set; }

        [JsonProperty("users")]
        public IEnumerable<string> Users { get; set; }
    }
}
