using GamesExchange.Model.Identification;

namespace GamesExchange.WebMvc.Models
{
    public class FriendsListViewModel
    {
        public IList<Person> Data { get; set; }
        public PersonFilter Filter { get; set; }
        public PaginationViewModel Pagination { get; set; }
    }
}
