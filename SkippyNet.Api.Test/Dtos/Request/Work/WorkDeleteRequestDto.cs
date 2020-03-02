using SkippyNet.Api.Test.Interfaces.Common;

namespace SkippyNet.Api.Test.Dto.Request.Work
{
    public class WorkDeleteRequestDto : IRequest
    {
        public int WorkId { get; set; }
    }
}
