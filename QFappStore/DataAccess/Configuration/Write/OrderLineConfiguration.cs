using System.Data.Entity.ModelConfiguration;
using Domain;

namespace DataAccess.Configuration.Write
{
    public class OrderLineConfiguration : EntityTypeConfiguration<OrderLine>
    {
        public OrderLineConfiguration()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.Order).WithMany(x => x.OrderLines).Map(config => config.MapKey("OrderId"));
            HasRequired(x => x.Product).WithMany().Map(config => config.MapKey("ProductId"));
        }
    }
}