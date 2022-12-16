namespace RocketChat.Configuration
{
    public class RocketChatConfiguration : IRocketChatConfiguration
    {
        public string Host { get; set; }
        public string WebSocketHost { get; set; }

        public string AdminUserName { get; set; }
        public string AdminPassword { get; set; }
        public string DefaultPassword { get; set; }
    }
}