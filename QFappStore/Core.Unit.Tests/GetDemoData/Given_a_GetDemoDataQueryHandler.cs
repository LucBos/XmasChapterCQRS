using System;
using System.Collections.Generic;
using System.Linq;
using Core.GetDemoData;
using Domain;
using Moq;
using NUnit.Framework;

namespace Core.Unit.Tests.GetDemoData
{
    public class Given_a_GetDemoDataQueryHandler
    {
        private Mock<IGetReviewsWithPersonNameQuery> _getReviewsQuery;
        private GetDemoDataQueryHandler _queryHandler;
        private List<ReviewsWithPersonName> _getReviewsQueryResult;

        [SetUp]
        public void Setup()
        {
            _getReviewsQuery = new Mock<IGetReviewsWithPersonNameQuery>();
            _getReviewsQueryResult = new List<ReviewsWithPersonName>()
                {
                    new ReviewsWithPersonName(){Comment = "a",FirstName = "b",Id = Guid.NewGuid(),NrOfStars = 1},
                    new ReviewsWithPersonName(){Comment = "c",FirstName = "d",Id = Guid.NewGuid(),NrOfStars = 2},
                    new ReviewsWithPersonName(){Comment = "e",FirstName = "f",Id = Guid.NewGuid(),NrOfStars = 3},
                    new ReviewsWithPersonName(){Comment = "g",FirstName = "h",Id = Guid.NewGuid(),NrOfStars = 4}
                };
            _getReviewsQuery.Setup(x => x.Execute()).Returns(_getReviewsQueryResult);
            _queryHandler = new GetDemoDataQueryHandler(_getReviewsQuery.Object);
        }

        [Test]
        public void When_Execute_is_called_it_should_call_the_database_query()
        {
            _queryHandler.Execute();

            _getReviewsQuery.Verify(x => x.Execute());
        }

        [Test]
        public void When_execute_is_called_it_should_return_a_handlerresult()
        {
            var result = _queryHandler.Execute();
            Assert.IsNotNull(result);
        }

        [Test]
        public void When_execute_is_called_it_should_return_a_handlerresult_with_the_queryresult_mapped_to_dtos()
        {
            var result = _queryHandler.Execute();
            foreach (var review in result.Reviews)
            {
               Assert.IsTrue(_getReviewsQueryResult.Any(
                    x =>
                    x.Id.Equals(review.Id) && 
                    x.Comment.Equals(review.Comment) && 
                    x.FirstName.Equals(review.Reviewer) &&
                    x.NrOfStars.Equals(review.Stars)));
            }            
        }
    }
}