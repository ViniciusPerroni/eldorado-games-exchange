using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GamesExchange.Model.Exchanges;

namespace GamesExchange.DataAccess.EntityFramework.Exchanges.Configurations
{
    public class ExchangeConfiguration : IEntityTypeConfiguration<Exchange>
    {
        public void Configure(EntityTypeBuilder<Exchange> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Locator).WithMany(e => e.Exchanges).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(e => e.Game).WithMany(e => e.Exchanges).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
