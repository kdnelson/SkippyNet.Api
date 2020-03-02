using Dinerware.Api.Test.Enums;
using SkippyNet.Api.Test.Dtos.Classes.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Test.Interfaces.Work
{
    public interface IWorkCreateFixture
    {
        Task<List<TestLogDto>> RunCreateAsync(TestType testType);
    }
}
