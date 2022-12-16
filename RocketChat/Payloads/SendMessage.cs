using Newtonsoft.Json;
using RocketChat.Models;

namespace RocketChat.Payloads
{
    public class SendMessage : Payload
    {
        [JsonProperty("message")]
        public MessageInput Message { get; set; }
    }
}
