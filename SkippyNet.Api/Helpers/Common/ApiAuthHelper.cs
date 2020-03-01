using Dinerware.Api.Dto.Response.ApiUser;
using SkippyNet.Api.Interfaces.Common;
using System;
using System.Threading.Tasks;

namespace SkippyNet.Api.Helpers.Common
{
    public class ApiAuthHelper : IApiAuthHelper
    {
        public Task<ResponseDto<ApiUserCredentialsResponseDto>> CreateApiUserCredentials(string apiClientId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> IsApiUserValid(string token)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> IsValidApiClientAsync(string apiClientId, string apiClientSecret)
        {
            throw new NotImplementedException();
        }
    }
}
