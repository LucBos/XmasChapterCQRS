using System.Linq;
using NUnit.Framework;

namespace DataAccess.Integration.Tests
{
    public class Given_a_ReadContext
    {
        private ReadContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new ReadContext();
        }

        [Test]
        public void GetReviewsWithPersonNameConfiguration_should_be_valid()
        {
            Assert.DoesNotThrow(() => _context.GetReviewsWithPersonName.FirstOrDefault());
        }
    }
}