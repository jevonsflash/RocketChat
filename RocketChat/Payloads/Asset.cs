using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class Asset : Payload
    {
        [JsonProperty("assetName")]
        public string AssetName { get; set; }

        [JsonProperty("refreshAllClients")]
        public bool RefreshAllClients { get; set; }
    }
}
