using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.Create
{
    public class Input : BaseInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasUser { get; set; }
        public string Email { get; set; }
        public string CellNumber { get; set; }
        public string PhoneNumber { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(FirstName))
                Errors.Add("Parâmetro FirstName inválido.");

            if (string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(LastName))
                Errors.Add("Parâmetro LastName inválido.");

            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Email))
                Errors.Add("Parâmetro Email inválido.");
        }
    }
}
