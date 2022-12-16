using System.Net;
using RocketChat.MethodResults;
using RocketChat.Services;
using RocketChat.Transport;

namespace RocketChat.Helpers
{
    public class ServiceHelper
    {
        public static Result<TResult> MapResponse<TResult>(ApiResponse<TResult> response)
        {
            Result<TResult> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = new Result<TResult>(response.Result, response.StatusCode);
            else
                loginResult = new ErrorResult<TResult>(response.Message, response.StatusCode);

            return loginResult;
        }

        public static Result<bool> MapBoolResponse(ApiResponse<CallResult> response)
        {
            Result<bool> loginResult;

            if (response.StatusCode == HttpStatusCode.OK)
                loginResult = response.Result.Success ? new Result<bool>(true, response.StatusCode) : new ErrorResult<bool>(response.Result.Error, response.StatusCode);
            else
                loginResult = new ErrorResult<bool>(response.Message, response.StatusCode);

            return loginResult;
        }
    }
}