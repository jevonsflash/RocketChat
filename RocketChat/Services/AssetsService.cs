using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RocketChat;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.MethodResults;
using RocketChat.Transport;

namespace RocketChat.Services
{
    internal class AssetsService : IAssetsService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"assets.{endPoint}");

        private readonly IRestClientService _restClientService;

        public AssetsService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<bool>> SetAsset(Payloads.Asset asset, bool refreshAllClients)
        {
            var payload = new Payloads.Asset { AssetName = asset.ToString(), RefreshAllClients = refreshAllClients };
            var response = await _restClientService.Post<CallResult>(GetUrl("setAsset"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> UnsetAsset(Payloads.Asset asset, bool refreshAllClients)
        {
            var payload = new Payloads.Asset { AssetName = asset.ToString(), RefreshAllClients = refreshAllClients };
            var response = await _restClientService.Post<CallResult>(GetUrl("unsetAsset"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }
    }
}