using System.Threading.Tasks;
using Dinerware.Api.Dto.Response.ApiUser;
using SkippyNet.Api.Helpers.Common;

namespace SkippyNet.Api.Interfaces.Common
{
    public interface IApiAuthHelper
    {
        Task<ResponseDto> IsValidApiClientAsync(string apiClientId, string apiClientSecret);
        Task<ResponseDto<ApiUserCredentialsResponseDto>> CreateApiUserCredentials(string apiClientId);
        Task<ResponseDto> IsApiUserValid(string token);
    }
}
