using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RocketChat.Payloads;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.MethodResults;
using RocketChat.Models;
using RocketChat.Queries;
using RocketChat.Transport;

namespace RocketChat.Services
{
    internal class EmojisService : IEmojisService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"emoji-custom.{endPoint}");

        private readonly IRestClientService _restClientService;
        private readonly IFileRestClientService _fileRestClientService;

        public EmojisService(
            IRestClientService restClientService,
            IFileRestClientService fileRestClientService)
        {
            _restClientService = restClientService;
            _fileRestClientService = fileRestClientService;
        }

        public async Task<Result<Emojis>> List(DateTime? updatedSince = null)
        {
            string route = updatedSince.HasValue ? $"{GetUrl("list")}?updatedSince={updatedSince.Value.ToString(QueryHelper.DATE_FORMAT)}" : GetUrl("list");
            var response = await _restClientService.Get<Emojis>(route);
            return ServiceHelper.MapResponse(response);
        }


        public async Task<Result<bool>> Delete(string emojiId)
        {
            var payload = new DeleteEmoji { EmojiId = emojiId };
            var response = await _restClientService.Post<CallResult>(GetUrl("delete"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

    }
}