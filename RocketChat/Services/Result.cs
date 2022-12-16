using System.Net;

namespace RocketChat.Services
{
    public class Result<TResult>
    {
        public bool Success { get; set; }
        public TResult Content { get; set; }
        public string Error { get; set; }
        public HttpStatusCode? Code { get; set; }

        public Result()
        {
            Success = false;
            Content = default;
        }

        public Result(HttpStatusCode code)
        {
            Success = false;
            Content = default;
            Code = code;
        }

        public Result(TResult content)
        {
            Success = true;
            Content = content;
        }

        public Result(TResult content, HttpStatusCode code)
        {
            Success = true;
            Content = content;
            Code = code;
        }
    }
    public class ErrorResult<TResult> : Result<TResult>
    {
        public ErrorResult(string error)
        {
            Success = false;
            Content = default;
            Error = error;
        }

        public ErrorResult(string error, HttpStatusCode code)
        {
            Success = false;
            Content = default;
            Error = error;
            Code = code;
        }
    }
}