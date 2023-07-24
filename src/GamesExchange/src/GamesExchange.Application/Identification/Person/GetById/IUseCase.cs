using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.GetById
{
    public interface IUseCase
    {
        Task<GenericOutput<Model.Identification.Person>> Execute(Input input);
    }
}
