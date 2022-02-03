using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TAMS.Services.Interfaces;
using TAMS.WebApi.Controllers.Abstracts;
using TAMS.WebApi.Helpers.Attributes;

namespace TAMS.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        public AccountController(ILogger<AccountController> logger, IUserService userService, IMapper mapper)
            :base(mapper, logger)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<bool> Register()
        {
            return await _userService.RegisterUserAsync("can.baykal@hotmail.com", "bekair", "Abc123!");
        }

        [HttpPost("Login")]
        [Authorize]
        public async Task<bool> Login()
        {
            return true;
            //return await _userService.;
        }

    }
}
