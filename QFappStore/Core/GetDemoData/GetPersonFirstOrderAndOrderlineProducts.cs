using System.Collections.Generic;
using System.Linq;
using DataAccess;
using Domain;

namespace Core.GetDemoData
{
    public class GetReviewsWithPersonNameQuery:  IGetReviewsWithPersonNameQuery
    {
        private ReadContext _readContext;

        public GetReviewsWithPersonNameQuery(ReadContext readContext)
        {
            _readContext = readContext;
        }

        public IEnumerable<GetReviewsWithPersonName> Execute()
        {
            return _readContext.GetReviewsWithPersonName.ToList();
        }
    }
}
