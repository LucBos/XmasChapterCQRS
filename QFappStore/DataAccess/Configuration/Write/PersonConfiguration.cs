using System.Data.Entity.ModelConfiguration;
using Domain;

namespace DataAccess.Configuration
{
    public class PersonConfiguration: EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50);
            Property(x => x.FirstName).HasMaxLength(50);
            Property(x => x.Address).HasMaxLength(200);
        }
    }
}