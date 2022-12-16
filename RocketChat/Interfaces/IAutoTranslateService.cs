using System.Threading.Tasks;
using RocketChat.MethodResults.Chat;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface IAutoTranslateService
    {
        ///<summary>
        ///通过自动翻译获得支持的语言。
        ///</summary>
        Task<Result<Languages>> GetSupportedLanguages(string targetLanguage = null);
        ///<summary>
        ///保存一些关于自动翻译的设置。
        ///</summary>
        Task<Result<bool>> SaveSetttings(AutoTranslateSettings payload);
        ///<summary>
        ///翻译的消息。
        ///</summary>
        Task<Result<MessageResult>> TranslateMessage(string messageId, string targetLanguage);
    }
}