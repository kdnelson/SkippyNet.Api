﻿using System.Collections.Generic;
using System.Threading.Tasks;
using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Helpers.Common;

namespace SkippyNet.Api.Interfaces.Work
{
    public interface IWorkRepository
    {
        Task<ResponseDto> CreateAsync(DataAccess.Models.Work model);
        Task<ResponseDto> DeleteAsync(int id);
        Task<ResponseDto<DataAccess.Models.Work>> GetAsync(int id);
        Task<ResponseDto<List<DataAccess.Models.Work>>> SearchAsync(WorkSearchRequestDto request);
        Task<ResponseDto<List<DataAccess.Models.Work>>> SearchByTicketIdAsync(WorkSearchRequestDto request);
        Task<ResponseDto> UpdateAsync(DataAccess.Models.Work model);
    }
}
