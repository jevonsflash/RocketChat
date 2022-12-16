using Newtonsoft.Json;

namespace RocketChat.MethodResults
{
    public class CreateRoomResult
    {
        [JsonProperty("rid")]
        public string RoomId { get; set; }
    }
}