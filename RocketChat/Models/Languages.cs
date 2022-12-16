using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Languages
    {
        [JsonProperty("languages")]
        public IEnumerable<Language> _Languages { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}