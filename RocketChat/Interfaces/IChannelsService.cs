using System.Collections.Generic;
using System.Threading.Tasks;
using RocketChat.MethodResults.Channels;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Queries;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IChannelsService
    {
        ///<summary>
        ///将服务器上的所有用户添加到通道中。
        ///</summary>
        Task<Result<Channel>> AddAll(AddAll payload);
        ///<summary>
        ///指定当前通道中用户的Leader角色。
        ///</summary>
        Task<Result<bool>> AddLeader(string roomId, string userId);
        ///<summary>
        ///指定当前通道中用户的主持人角色。
        ///</summary>
        Task<Result<bool>> AddModerator(string roomId, string userId);
        ///<summary>
        ///给出当前通道中用户的所有者角色。
        ///</summary>
        Task<Result<bool>> AddOwner(string roomId, string userId);
        ///<summary>
        ///将公共通道中的消息获取给匿名用户
        ///</summary>
        Task<Result<Messages>> AnonymousRead(FullQuery query);
        ///<summary>
        ///档案一个通道。
        ///</summary>
        Task<Result<bool>> Archive(string roomId);
        ///<summary>
        ///从用户的通道列表中删除一个通道。
        ///</summary>
        Task<Result<bool>> Close(string roomId);
        ///<summary>
        ///通道计数器。
        ///</summary>
        Task<Result<Counters>> Counters(ChannelQuery.Counters query);
        ///<summary>
        ///创建一个新通道。
        ///</summary>
        Task<Result<Channel>> Create(Create payload);
        ///<summary>
        ///删除一个通道。
        ///</summary>
        Task<Result<bool>> Delete(string roomId);
        ///<summary>
        ///从通道获取文件列表。
        ///</summary>
        Task<Result<Files>> Files(ChannelQuery.Channel query);
        ///<summary>
        ///获取对通道的所有提及。
        ///</summary>
        Task<Result<Mentions>> GetAllUserMentionsByChannel(string roomId);
        ///<summary>
        ///获取频道的整合。
        ///</summary>
        Task<Result<Integrations>> GetIntegrations(string roomId);
        ///<summary>
        ///从通道检索消息。
        ///</summary>
        Task<Result<Messages>> History(ChannelQuery.History query);
        ///<summary>
        ///获取通道信息。
        ///</summary>
        Task<Result<Channel>> Info(string roomId);
        ///<summary>
        ///将用户添加到通道。
        ///</summary>
        Task<Result<Channel>> Invite(UserAction payload);
        ///<summary>
        ///将自己连接到一个通道。
        ///</summary>
        Task<Result<Channel>> Join(Join payload);
        ///<summary>
        ///从通道中移除用户。
        ///</summary>
        Task<Result<Channel>> Kick(UserAction payload);
        ///<summary>
        ///从通道中删除调用用户。
        ///</summary>
        Task<Result<Channel>> Leave(Payload payload);
        ///<summary>
        ///从服务器检索所有通道。
        ///</summary>
        Task<Result<IEnumerable<Channel>>> List();
        ///<summary>
        ///仅获取调用用户已加入的通道。
        ///</summary>
        Task<Result<IEnumerable<Channel>>> ListJoined();
        ///<summary>
        ///检索所有通道用户。
        ///</summary>
        Task<Result<Members>> Members(ChannelQuery.Members query);
        ///<summary>
        ///检索所有通道消息。
        ///</summary>
        Task<Result<Messages>> Messages(string roomId);
        ///<summary>
        ///列出一个频道的所有主持人。
        ///</summary>
        Task<Result<Moderators>> Moderators(ChannelQuery.Channel query);
        ///<summary>
        ///列出一个通道的所有在线用户。
        ///</summary>
        Task<Result<OnlineResult>> Online(ChannelQuery.Channel query);
        ///<summary>
        ///将通道添加回用户的通道列表。
        ///</summary>
        Task<Result<bool>> Open(string roomId);
        ///<summary>
        ///移除当前通道中的用户的Leader角色。
        ///</summary>
        Task<Result<bool>> Removeleader(UserAction payload);
        ///<summary>
        ///更改频道名称。
        ///</summary>
        Task<Result<Channel>> Rename(Rename payload);
        ///<summary>
        ///获取通道中用户的角色。
        ///</summary>
        Task<Result<RolesResult>> Roles(ChannelQuery.Channel query);
        ///<summary>
        ///设置频道的通知。
        ///</summary>
        Task<Result<AnnouncementResult>> SetAnnouncement(SetAnnouncement payload);
        ///<summary>
        ///设置通道的自定义字段。
        ///</summary>
        Task<Result<Channel>> SetCustomFields(SetCustomFields payload);
        ///<summary>
        ///设置通道是否为默认通道。
        ///</summary>
        void SetDefault();
        ///<summary>
        ///设置通道的描述。
        ///</summary>
        Task<Result<Channel>> SetDescription(SetDescription payload);
        ///<summary>
        ///设置连接通道所需的代码。
        ///</summary>
        Task<Result<Channel>> SetJoinCode(SetJoinCode payload);
        ///<summary>
        ///设置通道的描述。
        ///</summary>
        Task<Result<Channel>> SetPurpose(SetPurpose payload);
        ///<summary>
        ///设置通道是否为只读。
        ///</summary>
        Task<Result<Channel>> SetReadOnly(SetReadOnly payload);
        ///<summary>
        ///设置频道的主题。
        ///</summary>
        Task<Result<Channel>> SetTopic(SetTopic payload);
        ///<summary>
        ///设置通道应设置的房间类型。
        ///</summary>
        Task<Result<Channel>> SetType(SetType payload);
        ///<summary>
        ///Unarchives通道。
        ///</summary>
        Task<Result<bool>> Unarchive(Payload payload);
    }
}