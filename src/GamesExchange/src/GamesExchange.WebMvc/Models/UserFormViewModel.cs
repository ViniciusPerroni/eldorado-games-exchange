using GamesExchange.Model.Identification;

namespace GamesExchange.WebMvc.Models
{
    public class UserFormViewModel
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Role Role { get; set; }
        public long PersonId { get; set; }
        public Dictionary<long, string>? People { get; set; }
    }
}
