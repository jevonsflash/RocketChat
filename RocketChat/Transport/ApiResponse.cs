using System.Net;

namespace RocketChat.Transport
{
    public class ApiResponse<T> : ApiResponse
    {
        public T Result { get; }

        public ApiResponse(HttpStatusCode statusCode, T result, string message = null)
            : base(statusCode, message)
        {
            Result = result;
        }

        public ApiResponse(HttpStatusCode statusCode, ResponseStatus responseStatus)
            : base(statusCode, responseStatus)
        {
        }

        public ApiResponse(string message, string stackTrace)
            : base(message, stackTrace)
        {
        }

        public ApiResponse(string message, string stackTrace, HttpStatusCode statusCode)
    : base(message, stackTrace, statusCode)
        {
        }
    }

    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; }
        public ResponseStatus ResponseStatus { get; set; }
        public string Message { get; }
        public string StackTrace { get; }
        public bool IsBusinessValidationMessage { get; set; }

        public ApiResponse(HttpStatusCode statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message;
        }

        public ApiResponse(HttpStatusCode statusCode, ResponseStatus responseStatus)
        {
            StatusCode = statusCode;
            ResponseStatus = responseStatus;
            Message = $"StatusCode = {statusCode} - ResponseStatus = {responseStatus}";
        }

        public ApiResponse(string message, string stackTrace)
        {
            ResponseStatus = ResponseStatus.Error;
            Message = message;
            StackTrace = stackTrace;
        }

        public ApiResponse(string message, string stackTrace, HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
            Message = message;
            StackTrace = stackTrace;
        }
    }
}
