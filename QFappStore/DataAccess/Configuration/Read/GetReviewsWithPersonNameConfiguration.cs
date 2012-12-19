using System.Data.Entity.ModelConfiguration;
using Domain;

namespace DataAccess.Configuration.Read
{
    public class GetReviewsWithPersonNameConfiguration : EntityTypeConfiguration<GetReviewsWithPersonName>
    {
        public GetReviewsWithPersonNameConfiguration()
        {
            ToTable("GetReviewsWithPersonName");
        } 
    }
}