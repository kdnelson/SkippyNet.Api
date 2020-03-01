using SkippyNet.Api.Interfaces.Common;

namespace SkippyNet.Api.Dto.Request.Work
{
    public class WorkGetRequestDto : IRequest
    {
        public int WorkId { get; set; }
    }
}
