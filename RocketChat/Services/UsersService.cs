using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RocketChat.Payloads;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.MethodResults;
using RocketChat.MethodResults.Users;
using RocketChat.Models;
using RocketChat.Queries;
using RocketChat.Transport;

namespace RocketChat.Services
{
    internal class UsersService : IUsersService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"users.{endPoint}");

        private readonly IRestClientService _restClientService;

        public UsersService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<Users>> Presence(UserQuery.Presence query)
        {
            string route = $"{GetUrl("presence")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Users>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<UserResult>> Create(Payloads.User payload)
        {
            var response = await _restClientService.Post<UserResult>(GetUrl("create"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<DataResult>> CreateToken(string userId)
        {
            var payload = new UserAction { UserId = userId };
            var response = await _restClientService.Post<DataResult>(GetUrl("createToken"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Delete(string userId)
        {
            var payload = new UserAction { UserId = userId };
            var response = await _restClientService.Post<CallResult>(GetUrl("delete"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> DeleteOwnAccount(string password)
        {
            var payload = new DeleteOwnAccount { Password = password };
            var response = await _restClientService.Post<CallResult>(GetUrl("deleteOwnAccount"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> ForgotPassword(string email)
        {
            var payload = new ForgotPassword { Email = email };
            var response = await _restClientService.Post<CallResult>(GetUrl("forgotPassword"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<TokenResult>> GeneratePersonalAccessToken(string tokenName)
        {
            var payload = new PersonalAccessToken { TokenName = tokenName };
            var response = await _restClientService.Post<TokenResult>(GetUrl("generatePersonalAccessToken"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<string>> GetAvatar(string userId)
        {
            string route = $"{GetUrl("getAvatar")}?userId={userId}";
            var response = await _restClientService.Get<string>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Tokens>> GetPersonalAccessTokens()
        {
            var response = await _restClientService.Get<Tokens>(GetUrl("getPersonalAccessTokens"));
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Preferences>> GetPreferences()
        {
            var response = await _restClientService.Get<Preferences>(GetUrl("getPreferences"));
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<PresenceResult>> GetPresence(string userId)
        {
            string route = $"{GetUrl("getPresence")}?userId={userId}";
            var response = await _restClientService.Get<PresenceResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<StringResult>> GetUsernameSuggestion()
        {
            var response = await _restClientService.Get<StringResult>(GetUrl("getUsernameSuggestion"));
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<UserResult>> Info(string userId)
        {
            string route = $"{GetUrl("info")}?userId={userId}";
            var response = await _restClientService.Get<UserResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<UserResult>> InfoByUserName(string userName)
        {
            string route = $"{GetUrl("info")}?username={userName}";
            var response = await _restClientService.Get<UserResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Users>> List(UserQuery.List query)
        {
            string route = $"{GetUrl("list")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Users>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<TokenResult>> RegeneratePersonalAccessToken(string tokenName)
        {
            var payload = new PersonalAccessToken { TokenName = tokenName };
            var response = await _restClientService.Post<TokenResult>(GetUrl("regeneratePersonalAccessToken"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<UserResult>> Register(RegisterUser payload)
        {
            var response = await _restClientService.Post<UserResult>(GetUrl("register"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> RemovePersonalAccessToken(string tokenName)
        {
            var payload = new PersonalAccessToken { TokenName = tokenName };
            var response = await _restClientService.Post<CallResult>(GetUrl("removePersonalAccessToken"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<ExportResult>> RequestDataDownload(bool fullExport = false)
        {
            string route = $"{GetUrl("requestDataDownload")}?fullExport={fullExport}";
            var response = await _restClientService.Get<ExportResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> ResetAvatar(string userId)
        {
            var payload = new UserAction { UserId = userId };
            var response = await _restClientService.Post<CallResult>(GetUrl("resetAvatar"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> SetAvatar(SetAvatar payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("setAvatar"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public void SetPreferences() => throw new NotImplementedException();


        public async Task<Result<UserResult>> SetActiveStatus(string userId, bool active)
        {
            var payload = new SetActive { UserId = userId, ActiveStatus = active };
            var response = await _restClientService.Post<UserResult>(GetUrl("setActiveStatus"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<UserResult>> Update(UpdateUser payload)
        {
            var response = await _restClientService.Post<UserResult>(GetUrl("update"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<UserResult>> UpdateOwnBasicInfo(UpdateOwnBasicInfo payload)
        {
            var response = await _restClientService.Post<UserResult>(GetUrl("updateOwnBasicInfo"), payload);
            return ServiceHelper.MapResponse(response);
        }
    }
}