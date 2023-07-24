using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.Create
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
