using GamesExchange.Model.lib;

namespace GamesExchange.Model.Games.Repositories
{
    public interface IGameRepository : ICrudRepository<Game>
    {
        Task<PagedResult<Game>> ListPaged(GameFilter filter, int pageSize, int page);
    }
}
