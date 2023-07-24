using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.List
{
    public interface IUseCase
    {
        Task<GenericOutput<IList<Model.Identification.User>>> Execute(Input input);
    }
}
