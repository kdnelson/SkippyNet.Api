using System.ComponentModel.DataAnnotations;

namespace SkippyNet.Api.DataAccess.Models
{
    public class Work
    {
        [Key]
        public string WorkId { get; set; }
        public string WorkName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }
    }
}
