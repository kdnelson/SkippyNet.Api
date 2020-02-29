namespace SkippyNet.Api.Dto.Response.Work
{
    public class WorkResponseDto
    {
        public string WorkId { get; set; }
        public string WorkName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }
    }
}