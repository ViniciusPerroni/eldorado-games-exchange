using GamesExchange.Model.Exchanges;
using GamesExchange.Model.lib;

namespace GamesExchange.Model.Identification
{
    public class Person : BaseEntity
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, bool hasUser, string email, string cellNumber, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            HasUser = hasUser;
            Email = email;
            CellNumber = cellNumber;
            PhoneNumber = phoneNumber;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public bool HasUser { get; private set; }
        public string Email { get; private set; }
        public string CellNumber { get; private set; }
        public string PhoneNumber { get; private set; }
        public virtual User User { get; private set; }
        public virtual IList<Exchange> Exchanges { get; private set; }

        public void Edit(string firstName, string lastName, bool hasUser, string email, string cellNumber, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            HasUser = hasUser;
            Email = email;
            CellNumber = cellNumber;
            PhoneNumber = phoneNumber;
        }
    }
}
