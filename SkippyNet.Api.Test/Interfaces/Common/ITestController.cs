using Dinerware.Api.Test.Enums;

namespace SkippyNet.Api.Test.Interfaces.Common
{
    public interface ITestController
    {
        void Run(TestType testType);
    }
}
