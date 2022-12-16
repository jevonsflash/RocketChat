using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RocketChat.Interfaces;
using RocketChat.Services;
using RocketChat.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketChat
{
    public class RocketChatInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(
               Component.For<IRestClientService, RestClientService>().ImplementedBy<RestClientService>().LifestyleSingleton(),
               Component.For<IFileRestClientService, FileRestClientService>().ImplementedBy<FileRestClientService>().LifestyleSingleton(),
               Component.For<IAuthenticationService, AuthenticationService>().ImplementedBy<AuthenticationService>().LifestyleSingleton(),
               Component.For<IChannelsService, ChannelsService>().ImplementedBy<ChannelsService>().LifestyleSingleton(),
               Component.For<IGroupsService, GroupsService>().ImplementedBy<GroupsService>().LifestyleSingleton(),
               Component.For<IUsersService, UsersService>().ImplementedBy<UsersService>().LifestyleSingleton(),
               Component.For<IChatService, ChatService>().ImplementedBy<ChatService>().LifestyleSingleton(),
               Component.For<IRoomService, RoomService>().ImplementedBy<RoomService>().LifestyleSingleton(),
               Component.For<IAssetsService, AssetsService>().ImplementedBy<AssetsService>().LifestyleSingleton(),
               Component.For<IAutoTranslateService, AutoTranslateService>().ImplementedBy<AutoTranslateService>().LifestyleSingleton(),
               Component.For<ICommandsService, CommandsService>().ImplementedBy<CommandsService>().LifestyleSingleton(),
               Component.For<IEmojisService, EmojisService>().ImplementedBy<EmojisService>().LifestyleSingleton()
               );
        }
    }
}
