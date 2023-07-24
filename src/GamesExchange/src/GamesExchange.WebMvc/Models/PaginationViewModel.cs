using GamesExchange.Application.lib;

namespace GamesExchange.WebMvc.Models
{
    public class PaginationViewModel
    {
        public string Url { get; set; }
        public PageSummary Summary { get; set; }
    }
}
