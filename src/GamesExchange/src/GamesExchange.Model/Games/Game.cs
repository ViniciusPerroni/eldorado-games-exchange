using GamesExchange.Model.Exchanges;
using GamesExchange.Model.Identification;
using GamesExchange.Model.lib;

namespace GamesExchange.Model.Games
{
    public class Game : BaseEntity
    {
        public Game()
        {
        }

        public Game(string name, string description, DateTime releaseDate, decimal price, Console console, Studio studio, long ownerId)
        {
            Name = name;
            Description = description;
            ReleaseDate = releaseDate;
            Price = price;
            Console = console;
            Studio = studio;
            OwnerId = ownerId;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public decimal Price { get; private set; }
        public Console Console { get; private set; }
        public Studio Studio { get; private set; }
        public long OwnerId { get; private set; }
        public virtual User? Owner { get; private set; }
        public virtual IList<Exchange> Exchanges { get; private set; }

        public void Edit(string name, string description, DateTime releaseDate, decimal price, Console console, Studio studio, long ownerId)
        {
            Name = name;
            Description = description;
            ReleaseDate = releaseDate;
            Price = price;
            Console = console;
            Studio = studio;
            OwnerId = ownerId;
        }
    }
}
