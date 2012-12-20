using System.Data.Entity.ModelConfiguration;
using Domain;

namespace DataAccess.Configuration.Write
{
    public class ProductConfiguration: EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(100);
            Property(x => x.Description).HasMaxLength(500);
        }
    }
}