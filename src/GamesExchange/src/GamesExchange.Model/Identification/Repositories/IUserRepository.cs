using GamesExchange.Model.lib;

namespace GamesExchange.Model.Identification.Repositories
{
    public interface IUserRepository : ICrudRepository<User>
    {
        Task<User?> GetByUsernameAndPassword(string username, string password);
        Task<User?> GetByUsername(string username);
        Task<User?> GetByPersonId(long personId);
        Task<PagedResult<User>> ListPaged(UserFilter filter, int pageSize, int page);
    }
}
