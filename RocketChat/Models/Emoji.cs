using System.Collections.Generic;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Emoji
    {
        [JsonProperty("update")]
        public IEnumerable<Update> Update { get; set; }

        [JsonProperty("remove")]
        public IEnumerable<Update> Remove { get; set; }
    }
}