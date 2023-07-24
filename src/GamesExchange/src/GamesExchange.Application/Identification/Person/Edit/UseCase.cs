using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.Person.Edit
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

                var person = await personRepository.GetById(input.Id);

                if (person == null)
                    throw new Exception("Person não localizado.");


                person.Edit(input.FirstName, input.LastName, input.HasUser, input.Email, input.CellNumber, input.PhoneNumber);
                await personRepository.Update(person);

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
