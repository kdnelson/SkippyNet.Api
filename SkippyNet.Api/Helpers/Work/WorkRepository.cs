using SkippyNet.Api.Dto.Request.Work;
using SkippyNet.Api.Enums;
using SkippyNet.Api.Helpers.Common;
using SkippyNet.Api.Interfaces.Work;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkippyNet.Api.Helpers.Work
{
    public class WorkRepository : IWorkRepository
    {
        private const string ClassName = nameof(WorkRepository);

        public async Task<ResponseDto> CreateAsync(DataAccess.Models.Work model)
        {
            const string methodName = ClassName + "." + nameof(CreateAsync);

            var response = new ResponseDto();

            try
            {
                // TODO Make entity action here
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.SetError(0, ex.Message, methodName, ResponseType.Error);
            }

            return response;
        }

        public async Task<ResponseDto> DeleteAsync(int id)
        {
            const string methodName = ClassName + "." + nameof(DeleteAsync);

            var response = new ResponseDto();

            try
            {
                // TODO Make entity action here
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.SetError(0, ex.Message, methodName, ResponseType.Error);
            }

            return response;
        }

        public async Task<ResponseDto<DataAccess.Models.Work>> GetAsync(int id)
        {
            const string methodName = ClassName + "." + nameof(GetAsync);

            var response = new ResponseDto<DataAccess.Models.Work>();

            try
            {
                // TODO Make entity action here
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.SetError(0, ex.Message, methodName, ResponseType.Error);
            }

            return response;
        }

        public async Task<ResponseDto<List<DataAccess.Models.Work>>> SearchAsync(WorkSearchRequestDto request)
        {
            const string methodName = ClassName + "." + nameof(SearchAsync);

            var response = new ResponseDto<List<DataAccess.Models.Work>>()
            {
                Result = new List<DataAccess.Models.Work>()
            };

            try
            {
                // TODO Make entity action here
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.SetError(0, ex.Message, methodName, ResponseType.Error);
            }

            return response;
        }

        public async Task<ResponseDto> UpdateAsync(DataAccess.Models.Work model)
        {
            const string methodName = ClassName + "." + nameof(UpdateAsync);

            var response = new ResponseDto();

            try
            {
                // TODO Make entity action here
                response.SetSuccess();
            }
            catch (Exception ex)
            {
                response.SetError(0, ex.Message, methodName, ResponseType.Error);
            }

            return response;
        }
    }
}
