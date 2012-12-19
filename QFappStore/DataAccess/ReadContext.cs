using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DataAccess.Configuration.Read;
using Domain;

namespace DataAccess
{
    public class ReadContext: DbContext
    {
        public ReadContext()
        {
            Database.SetInitializer<ReadContext>(null);
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<GetReviewsWithPersonName> GetReviewsWithPersonName { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new GetReviewsWithPersonNameConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
