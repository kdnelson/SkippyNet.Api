using SkippyNet.Api.Test;
using SkippyNet.Api.Test.Enums;
using SkippyNet.Api.Test.Interfaces.Common;

namespace Dinerware.Api.Test.Helpers.Common
{
    public class UrlHelper : IUrlHelper
    {
        public string GetApiUrl(ApiRequestType urlRequest)
        {
            var response = string.Empty;

            switch (urlRequest)
            {
                case ApiRequestType.WorkCreateUrl:
                    response = "api/work/create";
                    break;
                case ApiRequestType.WorkSearchUrl:
                    response = "api/work/search";
                    break;
                case ApiRequestType.WorkGetUrl:
                    response = "api/work/get";
                    break;
                case ApiRequestType.WorkUpdateUrl:
                    response = "api/work/update";
                    break;
                case ApiRequestType.WorkDeleteUrl:
                    response = "api/work/delete";
                    break;
            }

            return $"{Settings.BaseUrl}/{response}";
        }
    }
}
