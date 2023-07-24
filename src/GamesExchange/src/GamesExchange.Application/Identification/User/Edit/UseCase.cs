using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.User.Edit
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

                var user = await userRepository.GetById(input.Id);

                if (user == null)
                    throw new Exception("Usuário não localizado.");

                var userCheckUsername = await userRepository.GetByUsername(input.Username);
                if(userCheckUsername != null && userCheckUsername.Id != input.Id)
                    throw new Exception("Username não disponível.");

                var userCheckPerson = await userRepository.GetByPersonId(input.PersonId);
                if (userCheckPerson != null && userCheckPerson.Id != input.Id)
                    throw new Exception("Pessoa já tem um usuário cadastrado.");

                user.Edit(input.Username, input.Password, input.Active, input.Role, input.PersonId);
                await userRepository.Update(user);

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
