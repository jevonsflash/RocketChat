using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RocketChat.Payloads;
using RocketChat.Helpers;
using RocketChat.Interfaces;
using RocketChat.MethodResults;
using RocketChat.MethodResults.Chat;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Queries;
using RocketChat.Transport;

namespace RocketChat.Services
{

    internal class ChatService : IChatService
    {
        private static string GetUrl(string endPoint) => ApiHelper.GetUrl($"chat.{endPoint}");

        private readonly IRestClientService _restClientService;

        public ChatService(IRestClientService restClientService)
        {
            _restClientService = restClientService;
        }

        public async Task<Result<DeleteMessageResult>> DeleteMessage(DeleteMessage payload)
        {
            var response = await _restClientService.Post<DeleteMessageResult>(GetUrl("delete"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> FollowMessage(FollowMessage payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("followMessage"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<Messages>> GetDeletedMessages(ChatQuery.GetDeletedMessages query)
        {
            string route = $"{GetUrl("getDeletedMessages")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> GetMentionedMessages(string roomId)
        {
            var query = new ChatQuery.Chat { RoomId = roomId };
            string route = $"{GetUrl("getMentionedMessages")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<MessageResult>> GetMessage(string messageId)
        {
            string route = $"{GetUrl("getMessage")}?msgId={messageId}";
            var response = await _restClientService.Get<MessageResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<MessageReceipsResult>> GetMessageReadReceipts(string messageId)
        {
            string route = $"{GetUrl("getMessageReadReceipts")}?messageId={messageId}";
            var response = await _restClientService.Get<MessageReceipsResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> GetPinnedMessages(ChatQuery.GetPinnedMessages query)
        {
            string route = $"{GetUrl("getPinnedMessages")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<MessageResult>> GetSnippetedMessageById(string messageId)
        {
            string route = $"{GetUrl("getSnippetedMessageById")}?messageId={messageId}";
            var response = await _restClientService.Get<MessageResult>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> GetStarredMessages(ChatQuery.GetStarredMessages query)
        {
            string route = $"{GetUrl("getStarredMessages")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> GetThreadMessages(ChatQuery.GetThreadMessages query)
        {
            string route = $"{GetUrl("getThreadMessages")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Threads>> GetThreadsList(ChatQuery.GetThreadList query)
        {
            string route = $"{GetUrl("getThreadsList")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Threads>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> IgnoreUser(ChatQuery.IgnoreUser query)
        {
            string route = $"{GetUrl("ignoreUser")}{query.ToQueryString()}";
            var response = await _restClientService.Get<CallResult>(route);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<MessageResult>> PinMessage(string messageId)
        {
            var payload = new PinMessage { MessageId = messageId };
            var response = await _restClientService.Post<MessageResult>(GetUrl("pinMessage"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<PostMessageResult>> PostMessage(PostMessage payload)
        {
            var response = await _restClientService.Post<PostMessageResult>(GetUrl("postMessage"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> React(React payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("react"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> ReportMessage(ReportMessage payload)
        {
            var response = await _restClientService.Post<CallResult>(GetUrl("reportMessage"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<Messages>> Search(ChatQuery.Search query)
        {
            string route = $"{GetUrl("search")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> StarMessage(string messageId)
        {
            var payload = new StarMessage { MessageId = messageId };
            var response = await _restClientService.Post<CallResult>(GetUrl("starMessage"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<MessageResult>> SendMessage(SendMessage payload)
        {
            var response = await _restClientService.Post<MessageResult>(GetUrl("sendMessage"), payload);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Messages>> SyncThreadMessages(ChatQuery.SyncThreadMessages query)
        {
            string route = $"{GetUrl("syncThreadMessages")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Messages>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<Threads>> SyncThreadsList(ChatQuery.SyncThreadList query)
        {
            string route = $"{GetUrl("syncThreadsList")}{query.ToQueryString()}";
            var response = await _restClientService.Get<Threads>(route);
            return ServiceHelper.MapResponse(response);
        }

        public async Task<Result<bool>> UnfollowMessage(string messageId)
        {
            var payload = new FollowMessage { MessageId = messageId };
            var response = await _restClientService.Post<CallResult>(GetUrl("unfollowMessage"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> UnPinMessage(string messageId)
        {
            var payload = new PinMessage { MessageId = messageId };
            var response = await _restClientService.Post<CallResult>(GetUrl("unPinMessage"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<bool>> UnStarMessage(string messageId)
        {
            var payload = new StarMessage { MessageId = messageId };
            var response = await _restClientService.Post<CallResult>(GetUrl("unStarMessage"), payload);
            return ServiceHelper.MapBoolResponse(response);
        }

        public async Task<Result<MessageResult>> Update(Payloads.Update payload)
        {
            var response = await _restClientService.Post<MessageResult>(GetUrl("update"), payload);
            return ServiceHelper.MapResponse(response);
        }
    }
}