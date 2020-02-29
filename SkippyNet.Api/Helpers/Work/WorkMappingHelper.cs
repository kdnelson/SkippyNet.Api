using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Dto.Response.Work;
using SkippyNet.Api.Helpers.Common;
using SkippyNet.Api.Interfaces.Work;
using System;
using System.Collections.Generic;

namespace SkippyNet.Api.Helpers.Work
{
    public class WorkMappingHelper : IWorkMappingHelper
    {
        public ResponseDto<DataAccess.Models.Work> MapCreateToEntity(WorkCreateRequestDto request)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<DataAccess.Models.Work> MapDeleteToEntity(WorkDeleteRequestDto request)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<WorkResponseDto> MapToResponseDto(DataAccess.Models.Work request)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<List<WorkResponseDto>> MapToResponseListDto(List<DataAccess.Models.Work> list)
        {
            throw new NotImplementedException();
        }

        public ResponseDto<DataAccess.Models.Work> MapUpdateToEntity(WorkUpdateRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
