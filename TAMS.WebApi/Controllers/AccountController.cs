using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using TAMS.Services.Interfaces;
using TAMS.WebApi.Controllers.Abstracts;

namespace TAMS.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : BaseController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IUserService _userService;

        public AccountController(ILogger<AccountController> logger, IUserService userService, IMapper mapper)
            :base(mapper)
        {
            _logger = logger;
            _userService = userService;
        }

        [Authorize]
        [HttpGet("Deneme")]
        public string Deneme()
        {
            return "boş";
        }

        [HttpPost("RegisterUser")]
        public async Task<bool> RegisterAsync()
        {
            return await _userService.RegisterUserAsync("can.baykal@hotmail.com", "bekair", "Abc123!");
        }

        [HttpPost]
        public bool Login()
        {
            return true;
        }
    }
}
