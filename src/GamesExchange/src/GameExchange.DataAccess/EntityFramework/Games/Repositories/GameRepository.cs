using GamesExchange.Model.Games;
using GamesExchange.Model.Games.Repositories;
using GamesExchange.Model.lib;

namespace GamesExchange.DataAccess.EntityFramework.Games.Repositories
{
    public class GameRepository : CrudRepository<Game>, IGameRepository
    {
        public GameRepository(GamesExchangeDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedResult<Game>> ListPaged(GameFilter filter, int pageSize, int page)
        {
            var query = GetAll();

            if(filter == null)
                 return await GetPaged(query, page, pageSize);

            if (!string.IsNullOrEmpty(filter.Name))
                query = query.Where(x => x.Name.ToUpper().Contains(filter.Name.ToUpper()));

            if(filter.Console != null)
                query = query.Where(x => x.Console.Equals(filter.Console));

            if (filter.OwnerId != null)
                query = query.Where(x => x.OwnerId.Equals(filter.OwnerId));

            return await GetPaged(query, page, pageSize);
        }
    }
}
