using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace TAMS.WebApi.Helpers.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //The authorization controlls will be made here
            if (false)
            {
                throw new UnauthorizedAccessException("User Unauthorized");
            }
        }
    }
}