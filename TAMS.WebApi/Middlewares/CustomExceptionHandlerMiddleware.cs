using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using PYOP.Core.Exceptions;
using System;
using System.IO;
using System.Threading.Tasks;
using TAMS.Common.DTOs.ExceptionDTOs;
using TAMS.Common.Enums;

namespace TAMS.WebApi.Middlewares
{
    public class CustomExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";

                var responseModel = new ErrorDto
                {
                    Message = error.Message,
                    StatusCode = error switch
                    {
                        SecurityTokenExpiredException or
                        SecurityTokenSignatureKeyNotFoundException => StatusCodes.Status401Unauthorized,
                        UnauthorizedAccessException => StatusCodes.Status403Forbidden,
                        FileNotFoundException => StatusCodes.Status404NotFound,
                        BusinessException => (int)CustomStatusCodes.Status512BusinessLogicFail,
                        _ => StatusCodes.Status500InternalServerError
                    }
                };
                var result = responseModel.ToString();
                await response.WriteAsync(result);
            }
        }
    }
}
