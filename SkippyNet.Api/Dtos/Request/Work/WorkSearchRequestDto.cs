using SkippyNet.Api.Interfaces.Common;
using System.Collections.Generic;

namespace SkippyNet.Api.Dto.Request.Work
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
