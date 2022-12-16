using System;
using System.Threading.Tasks;
using RocketChat.Models;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IEmojisService
    {
        ///<summary>
        ///删除已存在的自定义表情符号。
        ///</summary>
        Task<Result<bool>> Delete(string emojiId);
        ///<summary>
        ///列出服务器上的所有自定义表情。
        ///</summary>
        Task<Result<Emojis>> List(DateTime? updatedSince = null);
    }
}