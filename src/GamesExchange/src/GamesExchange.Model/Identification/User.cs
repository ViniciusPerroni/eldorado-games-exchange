using GamesExchange.Model.lib;

namespace GamesExchange.Model.Identification
{
    public class User : BaseEntity
    {
        public User()
        {
        }

        public User(string username, string password, bool active, Role role, long personId)
        {
            Username = username;
            Password = password;
            Active = active;
            Role = role;
            PersonId = personId;
        }

        public string Username { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }
        public Role Role { get; private set; }
        public long PersonId { get; private set; }
        public virtual Person Person { get; private set; }

        public void Edit(string username, string password, bool active, Role role, long personId)
        {
            Username = username;
            Password = password;
            Active = active;
            Role = role;
            PersonId = personId;
        }
    }
}
