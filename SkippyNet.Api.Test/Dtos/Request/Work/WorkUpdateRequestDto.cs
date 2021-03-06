﻿using SkippyNet.Api.Test.Interfaces.Common;

namespace SkippyNet.Api.Test.Dto.Request.Work
{
    public class WorkUpdateRequestDto : IRequest
    {
        public int WorkId { get; set; }
        public string WorkName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }
    }
}