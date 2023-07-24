using GamesExchange.Application.lib;
using GamesExchange.Model.Identification.Repositories;

namespace GamesExchange.Application.Identification.User.List
{
    public class UseCase :  BaseUseCase<IList<Model.Identification.User>, Input, GenericOutput<IList<Model.Identification.User>>>, IUseCase
    {
        private readonly IUserRepository userRepository;

        public UseCase(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        internal async override Task<GenericOutput<IList<Model.Identification.User>>> BussinesRole(Input input)
        {
            try
            {
                var output = new GenericOutput<IList<Model.Identification.User>>();
                var pagedResult = await userRepository.ListPaged(input.Filter, input.Summary.PageSize, input.Summary.PageNumber);

                output.Data = pagedResult.Rows;
                output.Summary = input.Summary;
                output.Summary.TotalRows = pagedResult.RowCount;

                return output;
            }
            catch (Exception ex)
            {
                var output = new GenericOutput<IList<Model.Identification.User>>();
                output.AddError(ex.Message);

                return output;
            }
        }
    }
}
