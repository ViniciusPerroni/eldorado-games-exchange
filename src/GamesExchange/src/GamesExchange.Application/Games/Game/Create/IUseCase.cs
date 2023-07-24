using GamesExchange.Application.lib;

namespace GamesExchange.Application.Games.Game.Create
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
