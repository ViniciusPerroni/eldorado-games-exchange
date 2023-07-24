using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.Person.GetById
{
    public class UseCase : BaseUseCase<Model.Identification.Person, Input, GenericOutput<Model.Identification.Person>>, IUseCase
    {
        private readonly IPersonRepository personRepository;

        public UseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        internal async override Task<GenericOutput<Model.Identification.Person>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<Model.Identification.Person>();
                var person = await personRepository.GetById(input.Id);

                if (person == null)
                    output.AddError("Pessoa não localizada.");

                output.Data = person;

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<Model.Identification.Person>();
                output.AddError(ex.Message);

                return output;
            }
        }
    }
}
