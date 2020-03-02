using SkippyNet.Api.Test.Interfaces.Common;
using System.Collections.Generic;

namespace SkippyNet.Api.Test.Dto.Request.Work
{
    public class WorkSearchRequestDto : IRequest
    {
        public List<string> ItemCollection { get; set; }

        public WorkSearchRequestDto()
        {
            ItemCollection = new List<string>();
        }
    }
}
