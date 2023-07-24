using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.Delete
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
