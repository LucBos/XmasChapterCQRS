using System.Collections.Generic;
using Domain;

namespace Core.GetDemoData
{
    public interface IGetReviewsWithPersonNameQuery : IDatabaseQuery
    {
        IEnumerable<ReviewsWithPersonName> Execute();
    }
}