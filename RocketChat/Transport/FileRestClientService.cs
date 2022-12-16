using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.MimeTypes;
using Castle.Core.Logging;
using Flurl;
using Flurl.Http;
using RocketChat.Configuration;
using RocketChat.Helpers;
using RocketChat.MethodResults;

namespace RocketChat.Transport
{
    public interface IFileRestClientService
    {
        Task<ApiResponse<byte[]>> GetFile(string route);
        Task<ApiResponse<byte[]>> GetFile(string route, object body);
        Task<ApiResponse<TResult>> PostFile<TResult>(string route, string fileName, Stream fileStream);
    }

    public class FileRestClientService : IFileRestClientService
    {

        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"rooms.{endPoint}");

        public ILogger Logger { get; set; }
        private readonly IRocketChatConfiguration _rocketChatConfiguration;
        private readonly IMimeTypeMap mimeTypeMap;
        private readonly IocManager _iocManager;
        private readonly string _host;

        public FileRestClientService(

            IRocketChatConfiguration rocketChatConfiguration,
            IMimeTypeMap mimeTypeMap,
            IocManager iocManager)
        {
            _rocketChatConfiguration = rocketChatConfiguration;
            this.mimeTypeMap = mimeTypeMap;
            _iocManager = iocManager;
            _host = _rocketChatConfiguration.Host;

        }



        public async Task<ApiResponse<byte[]>> GetFile(string route)
        {
            try
            {
                var responseContent = await CreateRequest(route, HttpMethod.Get).ReceiveBytes();
                return new ApiResponse<byte[]>(HttpStatusCode.OK, responseContent);

            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<byte[]>(ex);
            }
        }

        public async Task<ApiResponse<byte[]>> GetFile(string route, object body)
        {
            try
            {
                var responseContent = await CreateRequest(route, HttpMethod.Get, body).ReceiveBytes();
                return new ApiResponse<byte[]>(HttpStatusCode.OK, responseContent);
            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<byte[]>(ex);

            }
        }


        public async Task<ApiResponse<TResult>> PostFile<TResult>(string route, string fileName, Stream fileStream)
        {
            try
            {
                var responseContent = await CreateFormRequest(route, fileName, fileStream).ReceiveJson<TResult>();
                return new ApiResponse<TResult>(HttpStatusCode.OK, responseContent);
            }
            catch (FlurlHttpException ex)
            {
                return await ExceptionHandler<TResult>(ex);

            }
        }


        private async Task<IFlurlResponse> CreateFormRequest(string route, string fileName, Stream fileStream, string msg = null, string description = null, string tmid = null)
        {
            var currentSeesionContext = _iocManager.Resolve<SessionContextDto>();
            var request = new FlurlRequest(Url.Combine(_host, route));
            if (currentSeesionContext.IsAuthorized)
            {
                request.WithHeader("X-User-Id", currentSeesionContext.UserId);
                request.WithHeader("X-Auth-Token", currentSeesionContext.Token);
            }

            var contentType = mimeTypeMap.GetMimeType(fileName);

            var result = await request.PostMultipartAsync(c =>
              {
                  if (!string.IsNullOrEmpty(msg))
                      c.AddString("msg", msg);

                  if (!string.IsNullOrEmpty(description))
                      c.AddString("description", description);

                  if (!string.IsNullOrEmpty(tmid))
                      c.AddString("tmid", tmid);

                  fileStream.Seek(0, SeekOrigin.Begin);
                  c.AddFile("file", fileStream, fileName, contentType);

              });

            return result;
        }

        private async Task<IFlurlResponse> CreateRequest(string route, HttpMethod method, object body = null)
        {
            var currentSeesionContext = _iocManager.Resolve<SessionContextDto>();

            var request = Url.Combine(_host, route)
                .WithHeader("Accept", "image/webp,image/apng,image/svg+xml,image/*,*/*;q=0.8");

            if (currentSeesionContext.IsAuthorized)
            {
                request.WithHeader("X-User-Id", currentSeesionContext.UserId);
                request.WithHeader("X-Auth-Token", currentSeesionContext.Token);
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