using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.Edit
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
