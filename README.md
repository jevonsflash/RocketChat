# RocketChat

适用于AbpBoilerplate的RocketChat Api库


Rocket.Chat 是一个免费、开源、可扩展、高度可定制且安全的平台,可让您与团队进行交流和协作、共享文件和实时聊天(https://www.rocket.chat/)


Rocket.Chat服务的安装请阅读[Rocket.Chat 安装与设置启动项]( https://blog.csdn.net/jevonsflash/article/details/122881564)



## 快速开始


一. 在项目中引用[AbpBoilerplate.RocketChat]( https://www.nuget.org/packages/AbpBoilerplate.RocketChat)。


```
dotnet add package AbpBoilerplate.RocketChat
```

二. 添加RocketChatModule模块依赖
```
[DependsOn(typeof(RocketChatModule))]
public class CoreModule : AbpModule

```

三. appsettings.json配置文件中，添加服务相关配置
```
"Im": {
    "Provider": "RocketChat",
    "Address": "http://localhost:3000/",            //rocketchat服务地址
    "WebSocketAddress": "ws://localhost:3000/",     //websocket地址
    "AdminUserName": "super",                       //AdminUser的用户名
    "AdminPassword": "123qwe",                      //AdminUser的密码
    "DefaultPassword": "123qwe"                     //创建用户时的默认密码
}
...
```
注意：AdminUserName和AdminPassword请填写配置RocketChat时的初始用户用名与密码。

四. 在构造函数中注入服务，可用的服务如下
```
public class ImManager : DomainService
{
	public ImManager(
		IRocketChatConfiguration rocketChatConfiguration,
		IocManager iocManager,
		IAuthenticationService authenticationService,
		IFileRestClientService fileRestClientService,
		IChatService chatService,
		IUsersService usersService,
		IChannelsService channelsService,
		IRoomService roomService,
		IAssetsService assetsService,
		IAutoTranslateService autoTranslateService,
		ICommandsService commandsService,
		IEmojisService emojisService)
...
```

五. 在编写的领域服务方法中调用，如发送消息方法可编写如下
```
public async Task<Result<MessageResult>> SendMessage(string content, string roomId)
{
	var model = new SendMessage();
	model.Message = new MessageInput()
	{
		Content = content,
		RoomId = roomId,
		TimeStamp = DateTime.Now,
	};
	model.RoomId = roomId;
	return await chatService.SendMessage(model);
}
```


## 作者信息

作者：林小

邮箱：jevonsflash@qq.com



## License

The MIT License (MIT)