using SkippyNet.Api.Test.Dtos.Classes.Common;
using System.Threading.Tasks;

namespace SkippyNet.Api.Test.Interfaces.Common
{
    public interface IRequestHelper
    {
        Task<ResponseDto<T>> CallServiceAsync<T>(string url, IRequest request);
        Task<ResponseDto> CallServiceAsync(string url, IRequest request);
    }
}