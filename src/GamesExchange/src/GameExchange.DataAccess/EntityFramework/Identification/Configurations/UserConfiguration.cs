using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GamesExchange.Model.Identification;

namespace GamesExchange.DataAccess.EntityFramework.Identification.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.HasOne(e => e.Person).WithOne(e => e.User).OnDelete(DeleteBehavior.Cascade);

            var user = new User("admin", "123456", true, Role.Administrator, 1);
            user.Id = 1;

            builder.HasData(user);
        }
    }
}
