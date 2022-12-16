using System.Threading.Tasks;
using RocketChat.MethodResults.Channels;
using RocketChat.MethodResults.Groups;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Queries;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IGroupsService
    {
        ///<summary>
        ///添加火箭的所有用户。聊天服务器到群组。
        ///</summary>
        Task<Result<ChannelResult>> AddAll(AddAll payload);
        ///<summary>
        ///为当前组中的用户指定Leader角色。
        ///</summary>
        Task<Result<bool>> AddLeader(string roomId, string userId);
        ///<summary>
        ///指定组内用户的主持人角色。
        ///</summary>
        Task<Result<bool>> AddModerator(string roomId, string userId);
        ///<summary>
        ///赋予组中的用户所有者的角色。
        ///</summary>
        Task<Result<bool>> AddOwner(string roomId, string userId);
        ///<summary>
        ///档案私人团体。
        ///</summary>
        Task<Result<bool>> Archive(string roomId);
        ///<summary>
        ///从组列表中移除私有组。
        ///</summary>
        Task<Result<bool>> Close(string roomId);
        ///<summary>
        ///组计数器。
        ///</summary>
        Task<Result<Counters>> Counters(GroupQuery.Counters query);
        ///<summary>
        ///创建一个新的私有组。
        ///</summary>
        Task<Result<GroupResult>> Create(Create payload);
        ///<summary>
        ///删除私有组。
        ///</summary>
        Task<Result<bool>> Delete(string roomId);
        ///<summary>
        ///从私有组获取文件列表。
        ///</summary>
        Task<Result<Files>> Files(GroupQuery.Group query);
        ///<summary>
        ///获取分配给组的集成。
        ///</summary>
        Task<Result<Integrations>> GetIntegrations(string roomId);
        ///<summary>
        ///从专用组检索消息。
        ///</summary>
        Task<Result<Messages>> History(GroupQuery.History query);
        ///<summary>
        ///获取有关私有组的信息。
        ///</summary>
        Task<Result<GroupResult>> Info(string roomId);
        ///<summary>
        ///将用户添加到私有组。
        ///</summary>
        Task<Result<GroupResult>> Invite(UserAction payload);
        ///<summary>
        ///从私有组中删除用户。
        ///</summary>
        Task<Result<GroupResult>> Kick(UserAction payload);
        ///<summary>
        ///从私有组中删除调用用户。
        ///</summary>
        Task<Result<GroupResult>> Leave(Payload payload);
        ///<summary>
        ///列出调用者所属的私有组。
        ///</summary>
        Task<Result<Groups>> List(BasicQuery query);
        ///<summary>
        ///列出所有私有组。
        ///</summary>
        Task<Result<Groups>> ListAll(FullQuery query);
        ///<summary>
        ///列出一个组的所有版主。
        ///</summary>
        Task<Result<Moderators>> Moderators(GroupQuery.Group query);
        ///<summary>
        ///获取私有组参与者的用户。
        ///</summary>
        Task<Result<Members>> Members(GroupQuery.Members query);
        ///<summary>
        ///检索所有群组消息。
        ///</summary>
        Task<Result<Messages>> Messages(string roomId);
        ///<summary>
        ///将私有组添加回组列表中。
        ///</summary>
        Task<Result<bool>> Open(string roomId);
        ///<summary>
        ///移除当前组中的用户的Leader角色。
        ///</summary>
        Task<Result<bool>> Removeleader(UserAction payload);
        ///<summary>
        ///移除组内某个用户的主持人角色。
        ///</summary>
        Task<Result<bool>> RemoveModerator(UserAction payload);
        ///<summary>
        ///从组中删除用户的所有者角色。
        ///</summary>
        Task<Result<bool>> RemoveOwner(UserAction payload);
        ///<summary>
        ///修改私有组的名称。
        ///</summary>
        Task<Result<GroupResult>> Rename(Rename payload);
        ///<summary>
        ///获取私有组中的用户角色。
        ///</summary>
        Task<Result<RolesResult>> Roles(GroupQuery.Group query);
        ///<summary>
        ///设置一个小组的公告。
        ///</summary>
        Task<Result<AnnouncementResult>> SetAnnouncement(SetAnnouncement payload);
        ///<summary>
        ///设置私有组的自定义字段。
        ///</summary>
        Task<Result<GroupResult>> SetCustomFields(SetCustomFields payload);
        ///<summary>
        ///设置私有组的描述。
        ///</summary>
        Task<Result<GroupResult>> SetDescription(SetDescription payload);
        ///<summary>
        ///设定私人团体的目的。
        ///</summary>
        Task<Result<GroupResult>> SetPurpose(SetPurpose payload);
        ///<summary>
        ///设置房间是否只读。
        ///</summary>
        Task<Result<GroupResult>> SetReadOnly(SetReadOnly payload);
        ///<summary>
        ///设置私人小组的主题。
        ///</summary>
        Task<Result<GroupResult>> SetTopic(SetTopic payload);
        ///<summary>
        ///设置这个组的房间类型。
        ///</summary>
        Task<Result<GroupResult>> SetType(SetType payload);
        ///<summary>
        ///解除一个私人小组的档案。
        ///</summary>
        Task<Result<bool>> Unarchive(Payload payload);
    }
}