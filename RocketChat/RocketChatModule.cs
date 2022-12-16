using Abp.Modules;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Hosting;
using RocketChat.Configuration;

namespace RocketChat
{
    public class RocketChatModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;
        public RocketChatModule(IHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(
    typeof(RocketChatModule).GetAssembly().GetDirectoryPathOrNull(), env.EnvironmentName, env.IsDevelopment()
);
        }
        public override void PreInitialize()
        {
            IocManager.Register<IRocketChatConfiguration, RocketChatConfiguration>();
            Configuration.Modules.RocketChat().Host = _appConfiguration["Im:Address"];
            Configuration.Modules.RocketChat().WebSocketHost = _appConfiguration["Im:WebSocketAddress"];
            Configuration.Modules.RocketChat().AdminUserName = _appConfiguration["Im:AdminUserName"];
            Configuration.Modules.RocketChat().AdminPassword = _appConfiguration["Im:AdminPassword"];
            Configuration.Modules.RocketChat().DefaultPassword = _appConfiguration["Im:DefaultPassword"];
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }


    }
}
