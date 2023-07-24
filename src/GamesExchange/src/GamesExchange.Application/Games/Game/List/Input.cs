using GamesExchange.Application.lib;
using GamesExchange.Model.Games;

namespace GamesExchange.Application.Games.Game.List
{
    public class Input : BasePagedInput
    {
        public GameFilter Filter { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (Summary == null)
                Errors.Add("Parâmetro Summary inválido.");

            if (Summary.PageNumber == 0)
                Errors.Add("Parâmetro Summary.PageNumber inválido.");

            if (Summary.PageSize == 0)
                Errors.Add("Parâmetro Summary.PageSize inválido.");
        }
    }
}
