using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.ListAllToDictionary
{
    public interface IUseCase
    {
        Task<GenericOutput<Dictionary<long, string>>> Execute(Input input);
    }
}
