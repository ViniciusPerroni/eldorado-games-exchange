using GamesExchange.Application.lib;
using GamesExchange.Model.Games.Repositories;

namespace GamesExchange.Application.Games.Game.GetById
{
    public class UseCase : BaseUseCase<Model.Games.Game, Input, GenericOutput<Model.Games.Game>>, IUseCase
    {
        private readonly IGameRepository gameRepository;

        public UseCase(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        internal async override Task<GenericOutput<Model.Games.Game>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<Model.Games.Game>();
                var game = await gameRepository.GetById(input.Id);

                if (game == null)
                    output.AddError("Game não localizado");

                output.Data = game;

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<Model.Games.Game>();
                output.AddError(ex.Message);

                return output;
            }
        }
    }
}
