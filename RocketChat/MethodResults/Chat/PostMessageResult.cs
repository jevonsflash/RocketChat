using System;
using Newtonsoft.Json;
using RocketChat.Models;

namespace RocketChat.MethodResults.Chat
{
    public class PostMessageResult
    {
        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}