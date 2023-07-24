using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.List
{
    public interface IUseCase
    {
        Task<GenericOutput<IList<Model.Identification.Person>>> Execute(Input input);
    }
}
