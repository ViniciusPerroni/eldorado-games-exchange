using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.Edit
{
    public interface IUseCase
    {
        Task<GenericOutput<bool>> Execute(Input input);
    }
}
