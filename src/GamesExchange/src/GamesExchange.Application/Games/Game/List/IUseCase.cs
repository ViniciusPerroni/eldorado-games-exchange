using GamesExchange.Application.lib;

namespace GamesExchange.Application.Games.Game.List
{
    public interface IUseCase
    {
        Task<GenericOutput<IList<Model.Games.Game>>> Execute(Input input);
    }
}
