using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Payloads
{

    public class Create : Payload
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("members")]
        public IEnumerable<string> Members { get; set; }

        [JsonProperty("readOnly")]
        public bool ReadOnly { get; set; }
    }

}