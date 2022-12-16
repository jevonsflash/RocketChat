using System.Threading.Tasks;
using RocketChat.MethodResults;
using RocketChat.Models;
using RocketChat.Payloads;
using RocketChat.Services;

namespace RocketChat.Interfaces
{
    public interface ICommandsService
    {
        ///<summary>
        ///获取斜杠命令的规格。
        ///</summary>
        Task<Result<CommandResult>> Get(string command);
        ///<summary>
        ///列出所有可用的斜杠命令。
        ///</summary>
        Task<Result<Commands>> List();
        ///<summary>
        ///在指定的房间执行斜杠命令。
        ///</summary>
        Task<Result<bool>> Run(RunCommand payload);
    }
}