using System;

namespace Dinerware.Api.Dto.Response.ApiUser
{
    public class ApiUserCredentialsResponseDto
    {
        public string ApiClientSecret { get; set; }
        public string ApiUserSecret { get; set; }
        public string ApiUserToken { get; set; }
        public DateTime ApiUserTokenExpirationDate { get; set; }
    }
}
