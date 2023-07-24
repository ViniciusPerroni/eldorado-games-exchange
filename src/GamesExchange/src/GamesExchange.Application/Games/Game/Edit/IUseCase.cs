using GamesExchange.Application.lib;

namespace GamesExchange.Application.Games.Game.Edit
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
