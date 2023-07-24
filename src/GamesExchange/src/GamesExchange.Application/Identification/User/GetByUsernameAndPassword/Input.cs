using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.User.GetByUsernameAndPassword
{
    public class Input : BaseInput
    {
        public string Username { get; set; }
        public string Password { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (string.IsNullOrEmpty(Username) || string.IsNullOrWhiteSpace(Username))
                Errors.Add("Parâmetro Username inválido.");

            if (string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password))
                Errors.Add("Parâmetro Password inválido.");
        }
    }
}
