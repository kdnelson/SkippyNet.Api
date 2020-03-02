using Dinerware.Api.Test.Enums;
using SkippyNet.Api.Test.Dtos.Classes.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Test.Interfaces.Work
{
    public interface IWorkGetFixture
    {
        Task<List<TestLogDto>> RunGetAsync(TestType testType);
    }
}
