using GamesExchange.Application.lib;

namespace GamesExchange.Application.Identification.Person.ListAllToDictionary
{
    public class Input : BaseInput
    {
        internal override void Validate()
        {
            Errors = new List<string>();
        }
    }
}
