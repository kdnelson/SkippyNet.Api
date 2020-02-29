using System.Collections.Generic;
using SkippyNet.Api.Helpers.Common;

namespace SkippyNet.Api.Interfaces.Common
{
    public interface IResponseValidationDto
    {
        List<ResponseValidationDto.InValidField> InvalidFields { get; set; }
    }
}
