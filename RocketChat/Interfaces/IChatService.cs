using System.Threading.Tasks;
using RocketChat.MethodResults.Chat;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Queries;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IChatService
    {
        ///<summary>
        ///删除已存在的聊天消息。
        ///</summary>
        Task<Result<DeleteMessageResult>> DeleteMessage(DeleteMessage payload);
        ///<summary>
        ///跟随聊天消息到消息的通道。
        ///</summary>
        Task<Result<bool>> FollowMessage(FollowMessage payload);
        ///<summary>
        ///检索自特定日期以来已删除的消息。
        ///</summary>
        Task<Result<Messages>> GetDeletedMessages(ChatQuery.GetDeletedMessages query);
        ///<summary>
        ///检索提到的消息。
        ///</summary>
        Task<Result<Messages>> GetMentionedMessages(string roomId);
        ///<summary>
        ///通过提供的id检索单个聊天消息。被呼叫者必须有访问消息所在房间的权限。
        ///</summary>
        Task<Result<MessageResult>> GetMessage(string messageId);
        ///<summary>
        ///检索消息已读的收据。
        ///</summary>
        Task<Result<MessageReceipsResult>> GetMessageReadReceipts(string messageId);
        ///<summary>
        ///从房间检索固定消息。
        ///</summary>
        Task<Result<Messages>> GetPinnedMessages(ChatQuery.GetPinnedMessages query);
        ///<summary>
        ///根据id检索片段消息。
        ///</summary>
        Task<Result<MessageResult>> GetSnippetedMessageById(string messageId);
        ///<summary>
        ///检索带星号的消息。
        ///</summary>
        Task<Result<Messages>> GetStarredMessages(ChatQuery.GetStarredMessages query);
        ///<summary>
        ///获取线程的消息。
        ///</summary>
        Task<Result<Messages>> GetThreadMessages(ChatQuery.GetThreadMessages query);
        ///<summary>
        ///检索频道的线程。
        ///</summary>
        Task<Result<Threads>> GetThreadsList(ChatQuery.GetThreadList query);
        ///<summary>
        ///忽略聊天中的用户。
        ///</summary>
        Task<Result<bool>> IgnoreUser(ChatQuery.IgnoreUser query);
        ///<summary>
        ///将聊天消息钉到消息的通道。
        ///</summary>
        Task<Result<MessageResult>> PinMessage(string messageId);
        ///<summary>
        ///发布一个新的聊天信息。
        ///</summary>
        Task<Result<PostMessageResult>> PostMessage(PostMessage payload);
        ///<summary>
        ///设置/取消用户对现有聊天消息的反应。
        ///</summary>
        Task<Result<bool>> React(React payload);
        ///<summary>
        ///报告消息。
        ///</summary>
        Task<Result<bool>> ReportMessage(ReportMessage payload);
        ///<summary>
        ///在通道中搜索消息。
        ///</summary>
        Task<Result<Messages>> Search(ChatQuery.Search query);
        ///<summary>
        ///为经过身份验证的用户标记聊天消息。
        ///</summary>
        Task<Result<bool>> StarMessage(string messageId);
        ///<summary>
        ///发送新的聊天信息。
        ///</summary>
        Task<Result<MessageResult>> SendMessage(SendMessage payload);
        ///<summary>
        ///检索同步线程的消息。
        ///</summary>
        Task<Result<Messages>> SyncThreadMessages(ChatQuery.SyncThreadMessages query);
        ///<summary>
        ///检索线程的同步通道线程。
        ///</summary>
        Task<Result<Threads>> SyncThreadsList(ChatQuery.SyncThreadList query);
        ///<summary>
        ///取消关注现有的聊天消息。
        ///</summary>
        Task<Result<bool>> UnfollowMessage(string messageId);
        ///<summary>
        ///删除提供的聊天消息的固定状态。
        ///</summary>
        Task<Result<bool>> UnPinMessage(string messageId);
        ///<summary>
        ///删除已验证用户的聊天消息上的星号。
        ///</summary>
        Task<Result<bool>> UnStarMessage(string messageId);
        ///<summary>
        ///更新聊天消息的文字。
        ///</summary>
        Task<Result<MessageResult>> Update(Payloads.Update payload);
    }
}