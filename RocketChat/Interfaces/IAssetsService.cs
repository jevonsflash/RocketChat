using System.Threading.Tasks;
using RocketChat;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IAssetsService
    {
        ///<summary>
        ///根据名称设置资源图像。
        ///</summary>
        Task<Result<bool>> SetAsset(Payloads.Asset asset, bool refreshAllClients);
        ///<summary>
        ///取消资产的名称设置。
        ///</summary>
        Task<Result<bool>> UnsetAsset(Payloads.Asset asset, bool refreshAllClients);
    }
}