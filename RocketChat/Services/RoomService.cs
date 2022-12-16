using System;
using System.Threading.Tasks;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.MethodResults;
using RocketChat.MethodResults.Rooms;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Queries;
using RocketChat.Transport;

namespace RocketChat.Services
{
    internal class RoomService : IRoomService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"rooms.{endPoint}");

        private readonly IRestClientService _restClientService;
        private readonly IFileRestClientService fileRestClientService;

        public RoomService(IRestClientService restClientService, IFileRestClientService fileRestClientService)
        {
            _restClientService = restClientService;
            this.fileRestClientService = fileRestClientService;
        }

        public async Task<Result<bool>> CleanHistory(CleanHistory payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("cleanHistory"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<DiscussionResult>> CreateDiscussion(CreateDiscussion payload)
        {
            var response = await _restClientService.Post<DiscussionResult>(GetUrl("createDiscussion"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Favorite(string roomId, bool favorite)
        {
            var payload = new FavoriteRoom { RoomId = roomId, Favorite = favorite };
            var response = await _restClientService.Post<CallResult>(GetUrl("favorite"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<RoomsResult>> Get(DateTime? updatedSince = null)
        {
            string route = updatedSince.HasValue ? $"{GetUrl("get")}?updatedSince={updatedSince.Value.ToString(QueryHelper.DATE_FORMAT)}" : GetUrl("get");
            var response = await _restClientService.Get<RoomsResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Discussions>> GetDiscussions(string roomId)
        {
            string route = $"{GetUrl("getDiscussions")}?roomId={roomId}";
            var response = await _restClientService.Get<Discussions>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<RoomResult>> Info(string roomId)
        {
            string route = $"{GetUrl("info")}?roomId={roomId}";
            var response = await _restClientService.Get<RoomResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> Leave(string roomId)
        {
            var payload = new Payload { RoomId = roomId };
            var response = await _restClientService.Post<CallResult>(GetUrl("leave"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> SaveNotification(Notification payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("saveNotification"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<Message>> UploadFile(UploadFile payload)
        {
            string route = $"{GetUrl("upload")}/{payload.RoomId}";

            var response = await fileRestClientService.PostFile<Message>(route, payload.FileName, payload.File);
            return ServiceHelper.MapResponse(response);
        }

    }
}