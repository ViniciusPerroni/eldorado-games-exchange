using GamesExchange.Application.lib;
using GamesExchange.Model.Games.Repositories;

namespace GamesExchange.Application.Games.Game.Delete
{
    public class UseCase : BaseUseCase<bool, Input, GenericOutput<bool>>, IUseCase
    {
        private readonly IGameRepository gameRepository;

        public UseCase(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }


        internal override async Task<GenericOutput<bool>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<bool>();
                output.Data = true;

                await gameRepository.Delete(input.Id);

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<bool>();
                output.AddError(ex.Message);

                output.Data = false;
                return output;
            }
        }
    }
}
