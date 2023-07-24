using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.User.GetById
{
    public class UseCase : BaseUseCase<Model.Identification.User, Input, GenericOutput<Model.Identification.User>>, IUseCase
    {
        private readonly IUserRepository userRepository;

        public UseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        internal async override Task<GenericOutput<Model.Identification.User>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<Model.Identification.User>();
                var user = await userRepository.GetById(input.Id);

                if (user == null)
                    output.AddError("Usuário não localizado");

                output.Data = user;

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<Model.Identification.User>();
                output.AddError(ex.Message);

                return output;
            }
        }
    }
}
