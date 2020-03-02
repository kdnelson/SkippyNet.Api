using SkippyNet.Api.Test.Enums;

namespace SkippyNet.Api.Test.Interfaces.Common
{
    public interface IUrlHelper
    {
        string GetApiUrl(ApiRequestType urlRequest);
    }
}
