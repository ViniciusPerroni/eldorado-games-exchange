using GamesExchange.Application.Identification.User.GetByUsernameAndPassword;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace GamesExchange.WebMvc.Services.Impl
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IUseCase getByUsernameAndPasswordUsecase;

        public AuthenticationService(IHttpContextAccessor httpContextAccessor, IUseCase getByUsernameAndPasswordUsecase)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.getByUsernameAndPasswordUsecase = getByUsernameAndPasswordUsecase;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            var input = new Input { Username = username, Password = password };
            var result = await getByUsernameAndPasswordUsecase.Execute(input);
            if (!result.Ok)
                return false;

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Data.Id.ToString()));
            claims.Add(new Claim(ClaimTypes.Name, result.Data.Person.FirstName));
            claims.Add(new Claim(ClaimTypes.Role, result.Data.Role.ToString()));

            var claimsIdentity =
                new ClaimsPrincipal(
                    new ClaimsIdentity(
                        claims,
                        CookieAuthenticationDefaults.AuthenticationScheme
                    )
                );

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.Now.AddHours(8),
                IssuedUtc = DateTime.Now
            };


            await httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsIdentity, authProperties);

            return true;
        }

        public async Task LogOut()
        {
            await httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
