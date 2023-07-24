using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.Person.ListAllToDictionary
{
    public class UseCase : BaseUseCase<Dictionary<long, string>, Input, GenericOutput<Dictionary<long, string>>>, IUseCase
    {
        private IPersonRepository personRepository;

        public UseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        internal override async Task<GenericOutput<Dictionary<long, string>>> BussinesRole(Input input)
        {
            var people = personRepository.GetAll()
                .ToDictionary(x => x.Id, x => x.FirstName + " " + x.LastName);

            var output = new GenericOutput<Dictionary<long, string>>();
            output.Data = people;

            return output;
        }
    }
}
