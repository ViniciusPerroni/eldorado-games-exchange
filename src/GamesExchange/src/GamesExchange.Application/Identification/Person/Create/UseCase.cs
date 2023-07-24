using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.Person.Create
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

                var person = new Model.Identification.Person(input.FirstName, input.LastName, input.HasUser, input.Email, input.CellNumber, input.PhoneNumber);
                await personRepository.Create(person);

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
