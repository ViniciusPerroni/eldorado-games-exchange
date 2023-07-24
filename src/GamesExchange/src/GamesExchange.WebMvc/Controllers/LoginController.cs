using GamesExchange.WebMvc.Services;

using Microsoft.AspNetCore.Mvc;

namespace GamesExchange.WebMvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticationService authenticationService;

        public LoginController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(string username, string password)
        {
            var result = await authenticationService.Authenticate(username, password);

            if(result)
              return RedirectToAction("Index", "Home");

            return RedirectToAction("Index", "Login");
        }

        public async Task<IActionResult> LogOut()
        {
            await authenticationService.LogOut();

            return RedirectToAction("Index", "Login");
        }
    }
}
