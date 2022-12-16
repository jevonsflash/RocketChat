using Abp.Configuration.Startup;

namespace RocketChat.Configuration
{
    public static class RocketChatConfigurationExtensions
    {
        /// <summary>
        ///     Used to configure ABP RocketChat module.
        /// </summary>
        public static IRocketChatConfiguration RocketChat(this IModuleConfigurations configurations)
        {
            return configurations.AbpConfiguration.Get<IRocketChatConfiguration>();
        }
    }
}
