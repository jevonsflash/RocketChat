using System.Collections.Generic;
using Newtonsoft.Json;
using RocketChat.Models;

namespace RocketChat.MethodResults.Channels
{
    public class ChannelsResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("channels")]
        public IEnumerable<Channel> _Channels { get; set; }
    }
}