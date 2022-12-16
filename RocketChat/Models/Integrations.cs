using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Integrations
    {
        [JsonProperty("integrations")]
        public IEnumerable<Integration> _Integrations { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
