using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Enums;
using SkippyNet.Api.Helpers.Common;
using SkippyNet.Api.Interfaces.Common;
using SkippyNet.Api.Interfaces.Work;
using System;
using System.Linq;

namespace SkippyNet.Api.Helpers.Work
{
    public class WorkValidationHelper : IWorkValidationHelper
    {
        private const string ClassName = nameof(WorkValidationHelper);

        private readonly IApiAuthHelper _apiAuthHelper;

        public WorkValidationHelper(IApiAuthHelper apiAuthHelper)
        {
            _apiAuthHelper = apiAuthHelper;
        }

        private ResponseDto CheckRequestParams(object request)
        {
            const string methodName = ClassName + "." + nameof(CheckRequestParams);
            var response = new ResponseDto();

            if (request == null)
            {
                response.SetError(0, ErrorMessage.NullRequest, methodName);
                return response;
            }

            if (request.GetType() == typeof(WorkCreateRequestDto))
            {
                response = CheckCreateParams((WorkCreateRequestDto)request);
            }
            else if (request.GetType() == typeof(WorkDeleteRequestDto))
            {
                response = CheckDeleteParams((WorkDeleteRequestDto)request);
            }
            else if (request.GetType() == typeof(WorkGetRequestDto))
            {
                response = CheckGetParams((WorkGetRequestDto)request);
            }
            else if (request.GetType() == typeof(WorkSearchRequestDto))
            {
                response = CheckSearchParams((WorkSearchRequestDto)request);
            }
            else if (request.GetType() == typeof(WorkUpdateRequestDto))
            {
                response = CheckUpdateParams((WorkUpdateRequestDto)request);
            }
            else
            {
                response.SetError(0, ErrorMessage.DtoNotFound, methodName);
            }
            return response;
        }

        private ResponseDto CheckCreateParams(WorkCreateRequestDto request)
        {
            const string methodName = ClassName + "." + nameof(CheckCreateParams);
            var response = new ResponseDto();

            var properties = request.GetType().GetProperties();
            if (properties.Length != 4)
            {
                response.SetError(0, ErrorMessage.InvalidArguments, methodName);
            }
            else
            {
                if (request.WorkId.GetType() != typeof(int))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.WorkId", Message = ErrorMessage.ExpectedInt });
                }
                if (request.WorkName.GetType() != typeof(string))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.WorkName", Message = ErrorMessage.ExpectedString });
                }
                if (request.IsCompleted.GetType() != typeof(bool))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.IsCompleted", Message = ErrorMessage.ExpectedBoolean });
                }
                if (request.IsActive.GetType() != typeof(bool))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.IsActive", Message = ErrorMessage.ExpectedBoolean });
                }

                if (response.Validation.InvalidFields.Any())
                {
                    response.SetError(0, ErrorMessage.ValidationError, methodName);
                }
                else
                {
                    response.SetSuccess();
                }
            }

            return response;
        }

        private ResponseDto CheckDeleteParams(WorkDeleteRequestDto request)
        {
            const string methodName = ClassName + "." + nameof(CheckDeleteParams);
            var response = new ResponseDto();

            var properties = request.GetType().GetProperties();
            if (properties.Length != 1)
            {
                response.SetError(0, ErrorMessage.InvalidArguments, methodName);
            }
            else
            {
                if (request.WorkId.GetType() != typeof(int))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.WorkId", Message = ErrorMessage.ExpectedInt });
                }

                if (response.Validation.InvalidFields.Any())
                {
                    response.SetError(0, ErrorMessage.ValidationError, methodName);
                }
                else
                {
                    response.SetSuccess();
                }
            }

            return response;
        }

        private ResponseDto CheckGetParams(WorkGetRequestDto request)
        {
            const string methodName = ClassName + "." + nameof(CheckGetParams);
            var response = new ResponseDto();

            var properties = request.GetType().GetProperties();
            if (properties.Length != 1)
            {
                response.SetError(0, ErrorMessage.InvalidArguments, methodName);
            }
            else
            {
                if (request.WorkId.GetType() != typeof(int))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.WorkId", Message = ErrorMessage.ExpectedInt });
                }

                if (response.Validation.InvalidFields.Any())
                {
                    response.SetError(0, ErrorMessage.ValidationError, methodName);
                }
                else
                {
                    response.SetSuccess();
                }
            }

            return response;
        }

        private ResponseDto CheckSearchParams(WorkSearchRequestDto request)
        {
            const string methodName = ClassName + "." + nameof(CheckSearchParams);
            var response = new ResponseDto();

            var properties = request.GetType().GetProperties();
            if (properties.Length < 1)
            {
                response.SetError(0, ErrorMessage.InvalidArguments, methodName);
            }
            else
            {
                response.SetSuccess();
            }

            return response;
        }

        private ResponseDto CheckUpdateParams(WorkUpdateRequestDto request)
        {
            const string methodName = ClassName + "." + nameof(CheckUpdateParams);
            var response = new ResponseDto();

            var properties = request.GetType().GetProperties();
            if (properties.Length != 4)
            {
                response.SetError(0, ErrorMessage.InvalidArguments, methodName);
            }
            else
            {
                if (request.WorkId.GetType() != typeof(int))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.WorkId", Message = ErrorMessage.ExpectedInt });
                }
                if (request.WorkName.GetType() != typeof(string))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.WorkName", Message = ErrorMessage.ExpectedString });
                }
                if (request.IsCompleted.GetType() != typeof(bool))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.IsCompleted", Message = ErrorMessage.ExpectedBoolean });
                }
                if (request.IsActive.GetType() != typeof(bool))
                {
                    response.Validation.InvalidFields.Add(new ResponseValidationDto.InValidField() { FieldName = "request.IsActive", Message = ErrorMessage.ExpectedBoolean });
                }

                if (response.Validation.InvalidFields.Any())
                {
                    response.SetError(0, ErrorMessage.ValidationError, methodName);
                }
                else
                {
                    response.SetSuccess();
                }
            }

            return response;
        }

        private ResponseDto CheckRequestPermissions(object request)
        {
            const string methodName = ClassName + "." + nameof(CheckRequestPermissions);
            var response = new ResponseDto();

            if (request == null)
            {
                response.SetError(0, ErrorMessage.NullRequest, methodName);
                return response;
            }

            try
            {
                if (request.GetType() == typeof(WorkCreateRequestDto))
                {
                    response = HasPermission(PermissionType.WorkCreate.ToString());
                }
                else if (request.GetType() == typeof(WorkDeleteRequestDto))
                {
                    response = HasPermission(PermissionType.WorkDelete.ToString());
                }
                else if (request.GetType() == typeof(WorkGetRequestDto))
                {
                    response = HasPermission(PermissionType.WorkGet.ToString());
                }
                else if (request.GetType() == typeof(WorkSearchRequestDto))
                {
                    response = HasPermission(PermissionType.WorkSearch.ToString());
                }
                else if (request.GetType() == typeof(WorkUpdateRequestDto))
                {
                    response = HasPermission(PermissionType.WorkUpdate.ToString());
                }
                else
                {
                    response.SetError(0, ErrorMessage.InvalidPermissionType, methodName);
                }
            }
            catch (Exception ex)
            {
                response.SetError(0, ex.Message, methodName);
            }

            return response;
        }

        public ResponseDto ValidateAsync(object request)
        {
            throw new NotImplementedException();
        }

        private ResponseDto HasPermission(string permissionType)
        {
            const string methodName = ClassName + "." + nameof(HasPermission);
            var response = new ResponseDto();
            response.SetSuccess();
            return response;
        }
    }
}
