using Newtonsoft.Json;
using RocketChat.Models;

namespace RocketChat.MethodResults.Chat
{
    public class MessageResult
    {
        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}