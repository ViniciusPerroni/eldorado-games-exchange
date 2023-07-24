using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.GetByUsernameAndPassword
{
    public interface IUseCase
    {
        Task<GenericOutput<Model.Identification.User>> Execute(Input input);
    }
}
