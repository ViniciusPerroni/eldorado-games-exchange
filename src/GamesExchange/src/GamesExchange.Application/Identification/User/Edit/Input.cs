using GamesExchange.Application.lib;
using GamesExchange.Model.Identification;

namespace GamesExchange.Application.Identification.User.Edit
{
    public class Input : BaseInput
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public Role Role { get; set; }
        public long PersonId { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Username) || Username.Length < 6)
                Errors.Add("Parâmetro Username inválido.");

            if (string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(Password) || Password.Length < 6)
                Errors.Add("Parâmetro Password inválido.");
        }
    }
}
