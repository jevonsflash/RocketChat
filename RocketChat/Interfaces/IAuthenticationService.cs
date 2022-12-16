using System.Threading.Tasks;
using RocketChat.Authentication;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IAuthenticationService
    {
        ///<summary>
        ///使用REST API进行身份验证。
        ///</summary>
        Task<Result<LoginResult>> Login(string user, string password);

        ///<summary>
        ///登出。
        ///</summary>
        Task<Result<LogoutResult>> Logout();
    }
}