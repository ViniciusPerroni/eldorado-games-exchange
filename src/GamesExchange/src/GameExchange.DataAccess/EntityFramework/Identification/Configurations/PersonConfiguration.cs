using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GamesExchange.Model.Identification;

namespace GamesExchange.DataAccess.EntityFramework.Identification.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            var person = new Person("Administrator", "Admin", true, "admin@gmail.com", "", "")
            {
                Id = 1
            };
            builder.HasData(person);
        }
    }
}
