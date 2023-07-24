namespace GamesExchange.WebMvc.Models
{
    public class FriendsFormViewModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasUser { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string PhoneNumber { get; set; }
    }
}
