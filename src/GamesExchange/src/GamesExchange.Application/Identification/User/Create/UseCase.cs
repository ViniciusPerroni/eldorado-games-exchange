using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.User.Create
{
    public class UseCase : BaseUseCase<bool, Input, GenericOutput<bool>>, IUseCase
    {
        private readonly IUserRepository userRepository;

        public UseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        internal override async Task<GenericOutput<bool>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<bool>();
                output.Data = true;

                var user = await userRepository.GetByUsername(input.Username);
                if (user != null)
                    throw new Exception("Username não disponível.");

                user = await userRepository.GetByPersonId(input.PersonId);
                if (user != null)
                    throw new Exception("Pessoa já tem um usuário cadastrado.");

                user = new Model.Identification.User(input.Username, input.Password, input.Active, input.Role, input.PersonId);
                await userRepository.Create(user);

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
