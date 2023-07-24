using System.Text;

namespace GamesExchange.Model.Games
{
    public class GameFilter
    {
        public string Name { get; set; }
        public Console? Console { get; set; }
        public long? OwnerId { get; set; }

        public string ToQueryString()
        {
            var sb = new StringBuilder();
            sb.Append($"?Filter.Name={Uri.EscapeDataString(!string.IsNullOrEmpty(Name) ? Name : string.Empty)}");
            sb.Append($"&Filter.Console={Uri.EscapeDataString(Console.HasValue ? Console.ToString() : string.Empty)}");
            sb.Append($"&Filter.OwnerId={Uri.EscapeDataString(OwnerId.HasValue ? OwnerId.ToString() : string.Empty)}");

            return sb.ToString();
        }
    }
}
