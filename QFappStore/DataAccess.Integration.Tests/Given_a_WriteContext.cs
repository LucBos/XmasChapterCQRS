using System.Linq;
using NUnit.Framework;

namespace DataAccess.Integration.Tests
{
    [TestFixture]
    public class Given_a_WriteContext
    {
        private WriteContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new WriteContext();
        }

        [Test]
        public void PersonConfiguration_should_be_valid()
        {
            Assert.DoesNotThrow(() => _context.Person.FirstOrDefault());
        }

        [Test]
        public void ProductConfiguration_should_be_valid()
        {
            Assert.DoesNotThrow(() => _context.Product.FirstOrDefault());
        }

        [Test]
        public void ReviewConfiguration_should_be_valid()
        {
            Assert.DoesNotThrow(() => _context.Review.FirstOrDefault());
        }

        [Test]
        public void OrderConfiguration_should_be_valid()
        {
            Assert.DoesNotThrow(() => _context.Order.FirstOrDefault());
        }

        [Test]
        public void OrderLineConfiguration_should_be_valid()
        {
            Assert.DoesNotThrow(() => _context.OrderLine.FirstOrDefault());
        }

    }
}
