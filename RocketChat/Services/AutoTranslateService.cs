using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RocketChat.Payloads;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.MethodResults;
using RocketChat.MethodResults.Chat;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Transport;

namespace RocketChat.Services
{
    internal class AutoTranslateService : IAutoTranslateService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"autotranslate.{endPoint}");

        private readonly IRestClientService _restClientService;

        public AutoTranslateService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<Languages>> GetSupportedLanguages(string targetLanguage = null)
        {
            string url = GetUrl("getSupportedLanguages");
            string route = string.IsNullOrEmpty(targetLanguage) ? url : $"{url}?targetLanguage={targetLanguage}";
            var response = await _restClientService.Get<Languages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> SaveSetttings(AutoTranslateSettings payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("saveSetttings"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<MessageResult>> TranslateMessage(string messageId, string targetLanguage)
        {
            var payload = new TranslateMessage { MessageId = messageId, TargetLanguage = targetLanguage };
            var response = await _restClientService.Post<MessageResult>(GetUrl("translateMessage"), payload);
            return ServiceHelper.MapResponse(response);
        }
    }
}