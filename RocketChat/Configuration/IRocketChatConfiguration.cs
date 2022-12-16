namespace RocketChat.Configuration
{
    public interface IRocketChatConfiguration
    {
        string Host { get; set; }
        string WebSocketHost { get; set; }
        string AdminUserName { get; set; }
        string AdminPassword { get; set; }
        string DefaultPassword { get; set; }
    }
}