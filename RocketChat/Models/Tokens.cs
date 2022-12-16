using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Tokens
    {
        [JsonProperty("tokens")]
        public IEnumerable<Token> _Tokens { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}