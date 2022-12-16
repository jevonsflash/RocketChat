using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class SetType : Payload
    {
        ///<summary>
        ///这个通道的房间类型应该是c或p。
        ///</summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
