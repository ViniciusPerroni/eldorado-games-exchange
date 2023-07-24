using GamesExchange.Model.Identification.Repositories;
using GamesExchange.Model.Identification;
using GamesExchange.Model.lib;
using Microsoft.EntityFrameworkCore;

namespace GamesExchange.DataAccess.EntityFramework.Identification.Repositories
{
    public class UserRepository : CrudRepository<User>, IUserRepository
    {
        public UserRepository(GamesExchangeDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<PagedResult<User>> ListPaged(UserFilter filter, int pageSize, int page)
        {
            var query = GetAll();

            if (filter == null)
                return await GetPaged(query, page, pageSize);

            if (!string.IsNullOrEmpty(filter.Username))
                query = query.Where(x => x.Username.ToUpper().Contains(filter.Username.ToUpper()));

            if (!string.IsNullOrEmpty(filter.FirstName))
                query = query.Where(x => x.Person.FirstName.ToUpper().Contains(filter.FirstName.ToUpper()));

            if (!string.IsNullOrEmpty(filter.LastName))
                query = query.Where(x => x.Person.LastName.ToUpper().Contains(filter.LastName.ToUpper()));

            return await GetPaged(query, page, pageSize);
        }

        public async Task<User?> GetByUsernameAndPassword(string username, string password)
        {
            return await GetAll()
                .FirstOrDefaultAsync(x => x.Username.Equals(username) && x.Password.Equals(password));
        }

        public async Task<User?> GetByUsername(string username)
        {
            return await GetAll()
                .FirstOrDefaultAsync(x => x.Username.Equals(username));
        }

        public async Task<User?> GetByPersonId(long personId)
        {
            return await GetAll()
                .FirstOrDefaultAsync(x => x.PersonId.Equals(personId));
        }
    }
}
