using System;
using Newtonsoft.Json;

namespace RocketChat.Models
{
    public class Receipt
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("roomId")]
        public string RoomId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}