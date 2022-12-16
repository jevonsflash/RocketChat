using System.Threading.Tasks;
using RocketChat.MethodResults.Users;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Queries;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IUsersService
    {
        ///<summary>
        ///创建一个新用户。
        ///</summary>
        Task<Result<UserResult>> Create(Payloads.User payload);
        ///<summary>
        ///创建用户身份验证令牌。
        ///</summary>
        Task<Result<DataResult>> CreateToken(string userId);
        ///<summary>
        ///删除已有用户。
        ///</summary>
        Task<Result<bool>> Delete(string userId);
        ///<summary>
        ///删除自己的用户。
        ///</summary>
        Task<Result<bool>> DeleteOwnAccount(string password);
        ///<summary>
        ///发送电子邮件来重置密码。
        ///</summary>
        Task<Result<bool>> ForgotPassword(string email);
        ///<summary>
        ///生成个人访问令牌。
        ///</summary>
        Task<Result<TokenResult>> GeneratePersonalAccessToken(string tokenName);
        ///<summary>
        ///获取用户角色的URL。
        ///</summary>
        Task<Result<string>> GetAvatar(string userId);
        ///<summary>
        ///获取用户的个人访问令牌。
        ///</summary>
        Task<Result<Tokens>> GetPersonalAccessTokens();
        ///<summary>
        ///获取用户的首选项。
        ///</summary>
        Task<Result<Preferences>> GetPreferences();
        ///<summary>
        ///获取用户的在线状态。
        ///</summary>
        Task<Result<PresenceResult>> GetPresence(string userId);
        ///<summary>
        ///获取向用户提供新用户名的建议。
        ///</summary>
        Task<Result<StringResult>> GetUsernameSuggestion();
        ///<summary>
        ///获取用户信息，仅限于调用者的权限。
        ///</summary>
        Task<Result<UserResult>> Info(string userId);
        Task<Result<UserResult>> InfoByUserName(string userName);

        ///<summary>
        ///所有用户及其信息，仅限于权限。
        ///</summary>
        Task<Result<Users>> List(UserQuery.List query);
        ///<summary>
        ///获取所有连接用户的状态。
        ///</summary>
        Task<Result<Users>> Presence(UserQuery.Presence query);
        ///<summary>
        ///重新生成用户个人访问令牌。
        ///</summary>
        Task<Result<TokenResult>> RegeneratePersonalAccessToken(string tokenName);
        ///<summary>
        ///注册一个新用户。
        ///</summary>
        Task<Result<UserResult>> Register(RegisterUser payload);
        ///<summary>
        ///删除个人访问令牌。
        ///</summary>
        Task<Result<bool>> RemovePersonalAccessToken(string tokenName);
        ///<summary>
        ///请求用户下载数据。
        ///</summary>
        Task<Result<ExportResult>> RequestDataDownload(bool fullExport = false);
        ///<summary>
        ///重置一个用户的头像
        ///</summary>
        Task<Result<bool>> ResetAvatar(string userId);
        ///<summary>
        ///设置用户的激活状态。
        ///</summary>
        Task<Result<UserResult>> SetActiveStatus(string userId, bool active);
        ///<summary>
        ///设置用户的头像
        ///</summary>
        Task<Result<bool>> SetAvatar(SetAvatar payload);
        ///<summary>
        ///设置用户的首选项
        ///</summary>
        void SetPreferences();
        ///<summary>
        ///更新已有用户。
        ///</summary>
        Task<Result<UserResult>> Update(UpdateUser payload);
        ///<summary>
        ///更新自己用户的基本信息。
        ///</summary>
        Task<Result<UserResult>> UpdateOwnBasicInfo(UpdateOwnBasicInfo payload);
    }
}