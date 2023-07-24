using System.Text;

namespace GamesExchange.Model.Identification
{
    public class PersonFilter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string ToQueryString()
        {
            var sb = new StringBuilder();
            sb.Append($"?Filter.FirstName={Uri.EscapeDataString(!string.IsNullOrEmpty(FirstName) ? FirstName : string.Empty)}");
            sb.Append($"&Filter.LastName={Uri.EscapeDataString(!string.IsNullOrEmpty(LastName) ? LastName : string.Empty)}");

            return sb.ToString();
        }
    }
}
