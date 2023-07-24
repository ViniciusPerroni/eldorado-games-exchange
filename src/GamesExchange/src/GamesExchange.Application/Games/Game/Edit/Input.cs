using GamesExchange.Application.lib;

namespace GamesExchange.Application.Games.Game.Edit
{
    public class Input : BaseInput
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public Model.Games.Console Console { get; set; }
        public Model.Games.Studio Studio { get; set; }
        public long OwnerId { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Name))
                Errors.Add("Parâmetro Name inválido.");
        }
    }
}
