using GamesExchange.Application.lib;
using GamesExchange.Model.Identification;

namespace GamesExchange.Application.Identification.User.List
{
    public class Input : BasePagedInput
    {
        public UserFilter Filter { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (Summary == null)
                Errors.Add("Parâmetro Summary inválido.");

            if (Summary.PageNumber == 0)
                Errors.Add("Parâmetro Summary.PageNumber inválido.");

            if (Summary.PageSize == 0)
                Errors.Add("Parâmetro Summary.PageSize inválido.");
        }
    }
}
