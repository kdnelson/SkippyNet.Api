using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Dto.Response.Work;
using SkippyNet.Api.Helpers.Common;
using SkippyNet.Api.Interfaces.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkippyNet.Api.Helpers.Work
{
    public class WorkHelper : IWorkHelper
    {
        public Task<ResponseDto> CreateAsync(WorkCreateRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<WorkResponseDto>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseDto IsRequestValidAsync(object request, string token)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<WorkResponseDto>>> SearchAsync(WorkSearchRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<WorkResponseDto>>> SearchByTicketIdAsync(WorkSearchRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> UpdateAsync(WorkUpdateRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
