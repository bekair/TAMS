using Microsoft.AspNetCore.Mvc;
using TAMS.WebClient.Models;

namespace TAMS.WebClient.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            return View("Login");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (loginViewModel.UserName == "bekair" && loginViewModel.Password == "cancan123")
            {
                return Redirect(returnUrl);
            }

            return BadRequest();
        }
    }
}
