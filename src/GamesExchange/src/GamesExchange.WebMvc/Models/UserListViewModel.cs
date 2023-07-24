using GamesExchange.Model.Identification;

namespace GamesExchange.WebMvc.Models
{
    public class UserListViewModel
    {
        public IList<User> Data { get; set; }
        public UserFilter Filter { get; set; }
        public PaginationViewModel Pagination { get; set; }
    }
}
