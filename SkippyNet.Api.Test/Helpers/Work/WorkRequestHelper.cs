using SkippyNet.Api.Test.Dto.Request.Work;
using SkippyNet.Api.Test.Dto.Response.Work;
using SkippyNet.Api.Test.Dtos.Classes.Common;
using SkippyNet.Api.Test.Interfaces.Common;
using SkippyNet.Api.Test.Interfaces.Work;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Test.Helpers.Work
{
    public class WorkRequestHelper : IWorkRequestHelper
    {
        private readonly IRequestHelper _requestHelper;

        public WorkRequestHelper(IRequestHelper requestHelper)
        {
            _requestHelper = requestHelper;
        }

        public async Task<ResponseDto<long>> CreateAsync(string url, WorkCreateRequestDto request)
        {
            return await _requestHelper.CallServiceAsync<long>(url, request);
        }

        public async Task<ResponseDto> DeleteAsync(string url, WorkDeleteRequestDto request)
        {
            return await _requestHelper.CallServiceAsync(url, request);
        }

        public async Task<ResponseDto<WorkResponseDto>> GetAsync(string url, WorkGetRequestDto request)
        {
            return await _requestHelper.CallServiceAsync<WorkResponseDto>(url, request);
        }

        public async Task<ResponseDto<List<WorkResponseDto>>> SearchAsync(string url, WorkSearchRequestDto request)
        {
            return await _requestHelper.CallServiceAsync<List<WorkResponseDto>>(url, request);
        }

        public async Task<ResponseDto<long>> UpdateAsync(string url, WorkUpdateRequestDto request)
        {
            return await _requestHelper.CallServiceAsync<long>(url, request);
        }
    }
}
