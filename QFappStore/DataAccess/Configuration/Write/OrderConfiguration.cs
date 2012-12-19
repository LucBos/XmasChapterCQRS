using System.Data.Entity.ModelConfiguration;
using Domain;

namespace DataAccess.Configuration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.OrderDate).HasColumnType("datetime2");
            HasRequired(x => x.Person).WithMany(x => x.Orders).Map(config => config.MapKey("PersonId"));
        }
    }
}