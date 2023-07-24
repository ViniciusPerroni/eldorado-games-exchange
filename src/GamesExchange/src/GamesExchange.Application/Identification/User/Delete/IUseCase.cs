using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.Delete
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
