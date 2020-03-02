using Dinerware.Api.Test.Enums;
using SkippyNet.Api.Test.Dtos.Classes.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Test.Interfaces.Work
{
    public interface IWorkDeleteFixture
    {
        Task<List<TestLogDto>> RunDeleteAsync(TestType testType);
    }
}
