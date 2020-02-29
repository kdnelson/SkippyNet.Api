using System.Collections.Generic;
using System.Threading.Tasks;
using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Dto.Response.Work;
using SkippyNet.Api.Helpers.Common;

namespace SkippyNet.Api.Interfaces.Work
{
    public interface IWorkHelper
    {
        Task<ResponseDto> CreateAsync(WorkCreateRequestDto request);
        Task<ResponseDto> DeleteAsync(int id);
        Task<ResponseDto<WorkResponseDto>> GetAsync(int id);
        Task<ResponseDto<List<WorkResponseDto>>> SearchAsync(WorkSearchRequestDto request);
        Task<ResponseDto<List<WorkResponseDto>>> SearchByTicketIdAsync(WorkSearchRequestDto request);
        Task<ResponseDto> UpdateAsync(WorkUpdateRequestDto request);
        ResponseDto IsRequestValidAsync(object request, string token);
    }
}
