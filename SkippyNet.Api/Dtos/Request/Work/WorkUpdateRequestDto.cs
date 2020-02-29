using System;

namespace SkippyNet.Api.Dto.Request.Work
{
    public class WorkUpdateRequestDto
    {
        public string WorkName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }
    }
}