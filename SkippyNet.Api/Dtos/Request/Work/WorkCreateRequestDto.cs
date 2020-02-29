namespace SkippyNet.Api.Dto.Request.Work
{
    public class WorkCreateRequestDto
    {
        public string WorkId { get; set; }
        public string WorkName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }
    }
}
