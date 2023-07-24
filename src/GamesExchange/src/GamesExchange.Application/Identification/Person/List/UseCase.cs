using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.Person.List
{
    public class UseCase : BaseUseCase<IList<Model.Identification.Person>, Input, GenericOutput<IList<Model.Identification.Person>>>, IUseCase
    {
        private readonly IPersonRepository personRepository;

        public UseCase(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        internal async override Task<GenericOutput<IList<Model.Identification.Person>>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<IList<Model.Identification.Person>>();
                var pagedResult = await personRepository.ListPaged(input.Filter, input.Summary.PageSize, input.Summary.PageNumber);

                output.Data = pagedResult.Rows;
                output.Summary = input.Summary;
                output.Summary.TotalRows = pagedResult.RowCount;

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<IList<Model.Identification.Person>>();
                output.AddError(ex.Message);

                return output;
            }
        }
    }
}
