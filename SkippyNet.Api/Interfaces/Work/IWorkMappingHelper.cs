using System.Collections.Generic;
using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Dto.Response.Work;
using SkippyNet.Api.Helpers.Common;

namespace SkippyNet.Api.Interfaces.Work
{
    public interface IWorkMappingHelper
    {
        ResponseDto<DataAccess.Models.Work> MapCreateToEntity(WorkCreateRequestDto request);
        ResponseDto<DataAccess.Models.Work> MapDeleteToEntity(WorkDeleteRequestDto request);
        ResponseDto<DataAccess.Models.Work> MapUpdateToEntity(WorkUpdateRequestDto request);
        ResponseDto<WorkResponseDto> MapToResponseDto(DataAccess.Models.Work request);
        ResponseDto<List<WorkResponseDto>> MapToResponseListDto(List<DataAccess.Models.Work> list);
    }
}
