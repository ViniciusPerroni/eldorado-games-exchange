using GamesExchange.Model.lib;

namespace GamesExchange.Model.Exchanges.Repositories
{
    public interface IExchangeRepository : ICrudRepository<Exchange>
    {
        Task<PagedResult<Exchange>> ListPaged(ExchangeFilter filter, int pageSize, int page);
    }
}
