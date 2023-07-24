using GamesExchange.Model.lib;

namespace GamesExchange.Model.Identification.Repositories
{
    public interface IPersonRepository : ICrudRepository<Person>
    {
        Task<PagedResult<Person>> ListPaged(PersonFilter filter, int pageSize, int page);
    }
}
