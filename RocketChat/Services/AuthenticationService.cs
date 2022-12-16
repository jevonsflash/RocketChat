using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RocketChat.Authentication;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.Transport;

namespace RocketChat.Services
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IRestClientService _restClientService;

        public AuthenticationService(
            IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<LoginResult>> Login(string user, string password)
        {
            var loginRequest = new LoginRequest
            {
                User = user,
                Password = password
            };

            ApiResponse<LoginResult> response = await _restClientService.Post<LoginResult>(ApiHelper.GetUrl("login"), loginRequest);

            Result<LoginResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                loginResult = new Result<LoginResult>(response.Result);
            }
            else
                loginResult = new ErrorResult<LoginResult>(response.Message, response.StatusCode);

            return loginResult;
        }

        public async Task<Result<LogoutResult>> Logout()
        {
            ApiResponse<LogoutResult> response = await _restClientService.Post<LogoutResult>(ApiHelper.GetUrl("logout"), null);

            Result<LogoutResult> logoutResult;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                logoutResult = new Result<LogoutResult>(response.Result);
            }
            else
                logoutResult = new ErrorResult<LogoutResult>(response.Message, response.StatusCode);

            return logoutResult;
        }
    }
}