using System.Linq;
using Core.GetDemoData;
using DataAccess;
using NUnit.Framework;

namespace Core.Integration.Tests.GetDemoData
{
    public class Given_a_GetReviewsWithPersonNameQuery
    {
        [Test]
        public void When_Execute_is_called_it_should_retrieve_the_records_from_the_view()
        {
            var query = new GetReviewsWithPersonNameQuery(new ReadContext());
            var results = query.Execute();

            Assert.Greater(results.Count(), 0);
        }
    }
}
