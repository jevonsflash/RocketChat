using System;
using System.Threading.Tasks;
using RocketChat.MethodResults.Rooms;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IRoomService
    {
        ///<summary>
        ///清理房间的历史记录，需要特别许可。
        ///</summary>
        Task<Result<bool>> CleanHistory(CleanHistory payload);
        ///<summary>
        ///创造一个新的讨论。
        ///</summary>
        Task<Result<DiscussionResult>> CreateDiscussion(CreateDiscussion payload);
        ///<summary>
        ///最喜欢/讨厌的房间。
        ///</summary>
        Task<Result<bool>> Favorite(string roomId, bool favorite);
        ///<summary>
        ///得到房间。
        ///</summary>
        Task<Result<RoomsResult>> Get(DateTime? updatedSince = null);
        ///<summary>
        ///房间的讨论。
        ///</summary>
        Task<Result<Discussions>> GetDiscussions(string roomId);
        ///<summary>
        ///从房间获取信息。
        ///</summary>
        Task<Result<RoomResult>> Info(string roomId);
        ///<summary>
        ///离开一个房间。
        ///</summary>
        Task<Result<bool>> Leave(string roomId);
        ///<summary>
        ///设置特定通道的通知设置。
        ///</summary>
        Task<Result<bool>> SaveNotification(Notification payload);

        Task<Result<Message>> UploadFile(UploadFile payload);

    }
}