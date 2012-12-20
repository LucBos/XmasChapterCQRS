using System.Data.Entity.ModelConfiguration;
using Domain;

namespace DataAccess.Configuration.Write
{
    public class ReviewConfiguration : EntityTypeConfiguration<Review>
    {
        public ReviewConfiguration()
        {
            HasKey(x => x.Id);
            Property(x => x.Comment).HasMaxLength(500);
            HasRequired(x => x.Product).WithMany(x => x.Reviews).Map(config => config.MapKey("ProductId"));
        }
    }
}