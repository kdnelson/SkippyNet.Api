using SkippyNet.Api.Test.Dtos.Classes.Common;
using System.Collections.Generic;

namespace SkippyNet.Api.Test.Interfaces.Common
{
    public interface IResponseValidationDto
    {
        List<ResponseValidationDto.InValidField> InvalidFields { get; set; }
    }
}
