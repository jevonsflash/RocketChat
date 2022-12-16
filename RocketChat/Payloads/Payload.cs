using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public partial class Payload
    {
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
    }
}
