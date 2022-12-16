using Newtonsoft.Json;

namespace RocketChat.Payloads
{
    public class Notification : Payload
    {
        [JsonProperty("notifications")]
        public Options Notifications { get; set; }

        public class Options
        {
            [JsonProperty("desktopNotifications")]
            public string DesktopNotifications { get; set; }

            [JsonProperty("disableNotifications")]
            public string DisableNotifications { get; set; }

            [JsonProperty("emailNotifications")]
            public string EmailNotifications { get; set; }

            [JsonProperty("audioNotificationValue")]
            public string AudioNotificationValue { get; set; }

            [JsonProperty("desktopNotificationDuration")]
            public string DesktopNotificationDuration { get; set; }

            [JsonProperty("audioNotifications")]
            public string AudioNotifications { get; set; }

            [JsonProperty("unreadAlert")]
            public string UnreadAlert { get; set; }

            [JsonProperty("hideUnreadStatus")]
            public string HideUnreadStatus { get; set; }

            [JsonProperty("mobilePushNotifications")]
            public string MobilePushNotifications { get; set; }
        }
    }
}
