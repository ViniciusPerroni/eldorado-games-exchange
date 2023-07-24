using GamesExchange.Application.lib;

namespace GamesExchange.Application.Games.Game.GetById
{
    public interface IUseCase
    {
        Task<GenericOutput<Model.Games.Game>> Execute(Input input);
    }
}
