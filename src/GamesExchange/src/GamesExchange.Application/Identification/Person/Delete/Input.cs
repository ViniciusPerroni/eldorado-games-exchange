using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.Delete
{
    public class Input : BaseInput
    {
        public long Id { get; set; }

        internal override void Validate()
        {
            Errors = new List<string>();

            if (Id <= 0)
                Errors.Add("Parâmetro Id inválido.");
        }
    }
}
