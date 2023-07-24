using GamesExchange.Application.lib;
using GamesExchange.Model.Games.Repositories;

namespace GamesExchange.Application.Games.Game.List
{
    public class UseCase :  BaseUseCase<IList<Model.Games.Game>, Input, GenericOutput<IList<Model.Games.Game>>>, IUseCase
    {
        private readonly IGameRepository gameRepository;

        public UseCase(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        internal async override Task<GenericOutput<IList<Model.Games.Game>>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<IList<Model.Games.Game>>();
                var pagedResult = await gameRepository.ListPaged(input.Filter, input.Summary.PageSize, input.Summary.PageNumber);

                output.Data = pagedResult.Rows;
                output.Summary = input.Summary;
                output.Summary.TotalRows = pagedResult.RowCount;

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<IList<Model.Games.Game>>();
                output.AddError(ex.Message);

                return output;
            }
        }
    }
}
