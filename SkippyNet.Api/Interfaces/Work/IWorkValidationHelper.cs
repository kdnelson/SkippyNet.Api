using SkippyNet.Api.Helpers.Common;

namespace SkippyNet.Api.Interfaces.Work
{
    public interface IWorkValidationHelper
    {
        ResponseDto ValidateAsync(object request);
    }
}
