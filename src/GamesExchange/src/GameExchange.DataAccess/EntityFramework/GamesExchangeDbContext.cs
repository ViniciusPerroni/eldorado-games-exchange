using GamesExchange.Model.Exchanges;
using GamesExchange.Model.Games;
using GamesExchange.Model.Identification;
using Microsoft.EntityFrameworkCore;

namespace GamesExchange.DataAccess.EntityFramework
{
    public class GamesExchangeDbContext : DbContext
    {
        public GamesExchangeDbContext(DbContextOptions<GamesExchangeDbContext> options) : base(options)
        {
            if (Database.ProviderName != "Microsoft.EntityFrameworkCore.InMemory")
                Database.Migrate();
        }

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GamesExchangeDbContext).Assembly);
        }
    }
}
