using Newtonsoft.Json.Linq;

namespace RocketChat.Models
{
    public delegate void DataReceived(string type, JObject data);

    public delegate void MessageReceived(Message rocketMessage);

    public delegate void DdpReconnect();
}