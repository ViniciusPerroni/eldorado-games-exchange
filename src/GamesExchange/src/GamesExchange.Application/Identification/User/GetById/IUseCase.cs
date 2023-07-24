using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.GetById
{
    public interface IUseCase
    {
        Task<GenericOutput<Model.Identification.User>> Execute(Input input);
    }
}
