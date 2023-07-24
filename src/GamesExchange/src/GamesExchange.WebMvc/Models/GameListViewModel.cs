using GamesExchange.Model.Games;

namespace GamesExchange.WebMvc.Models
{
    public class GameListViewModel
    {
        public IList<Game> Data { get; set; }
        public GameFilter Filter { get; set; }
        public PaginationViewModel Pagination { get; set; }
    }
}
