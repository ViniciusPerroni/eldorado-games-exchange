namespace GamesExchange.WebMvc.Services
{
    public interface IAuthenticationService
    {
        Task<bool> Authenticate(string username, string password);
        Task LogOut();
    }
}
