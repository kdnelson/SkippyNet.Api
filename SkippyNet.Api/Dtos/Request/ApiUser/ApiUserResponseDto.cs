using System;

namespace Dinerware.Api.Dto.Response.ApiUser
{
    public class ApiUserResponseDto
    {
        public string ApiUserId { get; set; }
        public string ApiClientId { get; set; }
        public string ApiUserName { get; set; }
        public byte[] ApiUserPic { get; set; }
        public string ApiUserPassword { get; set; }
        public string ApiUserSecret { get; set; }
        public string ApiUserToken { get; set; }
        public DateTime? ApiUserTokenExpirationDate { get; set; }
        public bool IsActive { get; set; }
    }
}