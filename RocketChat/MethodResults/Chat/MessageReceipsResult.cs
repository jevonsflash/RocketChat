using System.Collections.Generic;
using Newtonsoft.Json;
using RocketChat.Models;

namespace RocketChat.MethodResults.Chat
{
    public class MessageReceipsResult
    {
        [JsonProperty("receipts")]
        public IEnumerable<Receipt> Receipts { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}