using RocketChat.Models;

namespace RocketChat.MethodResults
{
    public class CommandResult
    {
        public Command Command { get; set; }

        public bool Success { get; set; }
    }
}