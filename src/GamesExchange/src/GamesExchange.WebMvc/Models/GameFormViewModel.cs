namespace GamesExchange.WebMvc.Models
{
    public class GameFormViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public Model.Games.Console Console { get; set; }
        public Model.Games.Studio Studio { get; set; }
        public long OwnerId { get; set; }
    }
}
