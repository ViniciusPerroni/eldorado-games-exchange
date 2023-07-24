using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.Create
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
