using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.Person.Delete
{
    public class UseCase : BaseUseCase<bool, Input, GenericOutput<bool>>, IUseCase
    {
        private readonly IPersonRepository personRepository;

        public UseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        internal override async Task<GenericOutput<bool>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<bool>();
                output.Data = true;

                await personRepository.Delete(input.Id);

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
