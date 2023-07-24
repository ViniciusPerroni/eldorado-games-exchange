using GamesExchange.Model.lib;
using GamesExchange.Model.Exchanges;
using GamesExchange.Model.Exchanges.Repositories;

namespace GamesExchange.DataAccess.EntityFramework.Exchanges.Repositories
{
    public class ExchangeRepository : CrudRepository<Exchange>, IExchangeRepository
    {
        public ExchangeRepository(GamesExchangeDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedResult<Exchange>> ListPaged(ExchangeFilter filter, int pageSize, int page)
        {
            var query = GetAll();

            if (filter == null)
                return await GetPaged(query, page, pageSize);

            if (!string.IsNullOrEmpty(filter.GameName))
                query = query.Where(x => x.Game.Name.ToUpper().Contains(filter.GameName.ToUpper()));

            if (!string.IsNullOrEmpty(filter.LocatorName))
                query = query.Where(x => x.Locator.FirstName.ToUpper().Contains(filter.LocatorName.ToUpper())
                    || x.Locator.LastName.ToUpper().Contains(filter.LocatorName.ToUpper()));
            
            query = query.Where(x => x.ReturnDate.HasValue.Equals(filter.ShowFinished));

            return await GetPaged(query, page, pageSize);
        }
    }
}
