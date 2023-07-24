using System.Text;

namespace GamesExchange.Model.Identification
{
    public class UserFilter
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToQueryString()
        {
            var sb = new StringBuilder();
            sb.Append($"?Filter.Username={Uri.EscapeDataString(!string.IsNullOrEmpty(Username) ? Username : string.Empty)}");
            sb.Append($"&Filter.FirstName={Uri.EscapeDataString(!string.IsNullOrEmpty(FirstName) ? FirstName : string.Empty)}");
            sb.Append($"&Filter.LastName={Uri.EscapeDataString(!string.IsNullOrEmpty(LastName) ? LastName : string.Empty)}");

            return sb.ToString();
        }
    }
}
