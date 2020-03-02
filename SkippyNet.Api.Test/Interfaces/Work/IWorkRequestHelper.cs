using Dinerware.Api.Test.Enums;
using SkippyNet.Api.Test.Dto.Request.Work;
using SkippyNet.Api.Test.Dto.Response.Work;
using SkippyNet.Api.Test.Dtos.Classes.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Test.Interfaces.Work
{
    public interface IWorkRequestHelper
    {
        Task<ResponseDto<long>> CreateAsync(string url, WorkCreateRequestDto request);
        Task<ResponseDto> DeleteAsync(string url, WorkDeleteRequestDto request);
        Task<ResponseDto<WorkResponseDto>> GetAsync(string url, WorkGetRequestDto request);
        Task<ResponseDto<List<WorkResponseDto>>> SearchAsync(string url, WorkSearchRequestDto request);
        Task<ResponseDto<long>> UpdateAsync(string url, WorkUpdateRequestDto request);
    }
}