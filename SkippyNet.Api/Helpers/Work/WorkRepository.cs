using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Helpers.Common;
using SkippyNet.Api.Interfaces.Work;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Helpers.Work
{
    public class WorkRepository : IWorkRepository
    {
        public Task<ResponseDto> CreateAsync(DataAccess.Models.Work model)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<DataAccess.Models.Work>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<DataAccess.Models.Work>>> SearchAsync(WorkSearchRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<DataAccess.Models.Work>>> SearchByTicketIdAsync(WorkSearchRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> UpdateAsync(DataAccess.Models.Work model)
        {
            throw new NotImplementedException();
        }
    }
}
