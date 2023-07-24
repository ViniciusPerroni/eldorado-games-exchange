using GamesExchange.Model.Identification;
using GamesExchange.Model.Identification.Repositories;
using GamesExchange.Model.lib;

namespace GamesExchange.DataAccess.EntityFramework.Identification.Repositories
{
    public class PersonRepository : CrudRepository<Person>, IPersonRepository
    {
        public PersonRepository(GamesExchangeDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<PagedResult<Person>> ListPaged(PersonFilter filter, int pageSize, int page)
        {
            var query = GetAll();

            if(filter == null)
                return await GetPaged(query, page, pageSize);

            if (!string.IsNullOrEmpty(filter.FirstName))
                query = query.Where(x => x.FirstName.ToUpper().Contains(filter.FirstName.ToUpper()));

            if (!string.IsNullOrEmpty(filter.LastName))
                query = query.Where(x => x.LastName.ToUpper().Contains(filter.LastName.ToUpper()));

            return await GetPaged(query, page, pageSize);
        }
    }
}
