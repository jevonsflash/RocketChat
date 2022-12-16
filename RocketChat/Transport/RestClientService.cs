using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Abp.Dependency;
using Castle.Core.Logging;
using Flurl;
using Flurl.Http;
using RocketChat.Configuration;
using RocketChat.MethodResults;

namespace RocketChat.Transport
{
    public interface IRestClientService
    {
        Task<ApiResponse<TResult>> Post<TResult>(string route, object body);
        Task<ApiResponse<TResult>> Get<TResult>(string route, bool isQueryAll = false);
        Task<ApiResponse<TResult>> Put<TResult>(string route, object body);
        Task<ApiResponse<TResult>> Delete<TResult>(string route, object body = null);
    }

    public class RestClientService : IRestClientService
    {
        public ILogger Logger { get; set; }
        private readonly IRocketChatConfiguration _rocketChatConfiguration;
        private readonly IocManager _iocManager;
        private readonly string _host;

        public RestClientService(
             IRocketChatConfiguration rocketChatConfiguration, IocManager iocManager)
        {
            _rocketChatConfiguration = rocketChatConfiguration;
            _iocManager = iocManager;
            _host = _rocketChatConfiguration.Host;

        }

        public async Task<ApiResponse<TResult>> Post<TResult>(string route, object body)
        {
            try
            {
                var responseContent = await CreateRequest(route, HttpMethod.Post, body).ReceiveJson<TResult>();
                return new ApiResponse<TResult>(HttpStatusCode.OK, responseContent);
            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<TResult>(ex);

            }
        }

        public async Task<ApiResponse<TResult>> Get<TResult>(string route, bool isQueryAll = false)
        {
            try
            {
                var queryRoute = route + (isQueryAll ? "?count=0" : string.Empty);
                var responseContent = await CreateRequest(queryRoute, HttpMethod.Get).ReceiveJson<TResult>();
                return new ApiResponse<TResult>(HttpStatusCode.OK, responseContent);

            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<TResult>(ex);
            }
        }



        public async Task<ApiResponse<TResult>> Put<TResult>(string route, object body)
        {
            try
            {
                var responseContent = await CreateRequest(route, HttpMethod.Put, body).ReceiveJson<TResult>();
                return new ApiResponse<TResult>(HttpStatusCode.OK, responseContent);
            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<TResult>(ex);
            }
        }

        public async Task<ApiResponse<TResult>> Delete<TResult>(string route, object body = null)
        {
            try
            {
                var responseContent = await CreateRequest(route, HttpMethod.Delete, body).ReceiveJson<TResult>();
                return new ApiResponse<TResult>(HttpStatusCode.OK, responseContent);
            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<TResult>(ex);
            }
        }



        private async Task<IFlurlResponse> CreateRequest(string route, HttpMethod method, object body = null)
        {
            var request = Url.Combine(_host, route)
              .WithHeader("Accept", "application/json")
              .WithHeader("Content-Type", "application/json");
            if (_iocManager.IsRegistered<SessionContextDto>())
            {
                var currentSeesionContext = _iocManager.Resolve<SessionContextDto>();
                if (currentSeesionContext.IsAuthorized)
                {
                    request.WithHeader("X-User-Id", currentSeesionContext.UserId);
                    request.WithHeader("X-Auth-Token", currentSeesionContext.Token);
                }
            }
            if (body != null)
            {
                return await request.SendJsonAsync(method, body);
            }

            return await request.SendAsync(method);
        }


        private async Task<ApiResponse<TResult>> ExceptionHandler<TResult>(FlurlHttpException ex)
        {
            Logger.Error(ex + "Calling to API threw an exception");
            var errorMsg = ex.Message;
            if (ex.Call.Response != null)
            {
                var error = await ex.Call.Response?.GetJsonAsync<RequestErrorResult>();
                errorMsg = $"Responsed Msg:{error?.Error}, {ex.Message}";
            }
            return ex.StatusCode.HasValue
                ? new ApiResponse<TResult>(errorMsg, ex.StackTrace, (HttpStatusCode)ex.StatusCode)
                : new ApiResponse<TResult>(errorMsg, ex.StackTrace);

        }
    }
}
