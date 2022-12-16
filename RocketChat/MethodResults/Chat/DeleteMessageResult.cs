using System;
using Newtonsoft.Json;

namespace RocketChat.MethodResults.Chat
{
    public class DeleteMessageResult
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}