using System.Linq;

namespace Core.GetDemoData
{
    public class GetDemoDataQueryHandler : IGetDemoDataQueryHandler
    {
        private readonly IGetReviewsWithPersonNameQuery _getReviewsWithPersonNameQuery;

        public GetDemoDataQueryHandler(IGetReviewsWithPersonNameQuery getReviewsWithPersonNameQuery)
        {
            _getReviewsWithPersonNameQuery = getReviewsWithPersonNameQuery;
        }

        public GetDemoDataResult Execute()
        {
            var reviewsWithPersonName = _getReviewsWithPersonNameQuery.Execute();
            var getDemoDataResult = new GetDemoDataResult();
            getDemoDataResult.Reviews = reviewsWithPersonName.Select(x => new GetDemoDataResult.ReviewWithPersonName()
                                                                             {
                                                                                 Comment = x.Comment,
                                                                                 Id = x.Id,
                                                                                 Reviewer = x.FirstName,
                                                                                 Stars = x.NrOfStars
                                                                             });

            return getDemoDataResult;
        }
    }
}