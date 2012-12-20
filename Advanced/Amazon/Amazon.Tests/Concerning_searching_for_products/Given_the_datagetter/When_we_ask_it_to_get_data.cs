using Amazon.Controllers;
using Moq;
using NUnit.Framework;

namespace Amazon.Tests.Concerning_searching_for_products.Given_the_datagetter
{
    public class When_we_ask_it_to_get_data
    {
        private Mock<IQueryLocator> _serviceLocator;
        private DataGetter _sut;
        private Mock<IQuery<SomeType>> _query;
        private SomeType _expectedResult;
        private SomeType _actualResult;

        [TestFixtureSetUp]
        public void Arrange()
        {
            _expectedResult = new SomeType();
            _query = new Mock<IQuery<SomeType>>();
            _query.Setup(q => q.Fetch()).Returns(_expectedResult);
            _serviceLocator = new Mock<IQueryLocator>();
            _serviceLocator
                .Setup(l => l.Resolve<SomeType>())
                .Returns(_query.Object);

            _sut = new DataGetter(_serviceLocator.Object);


            Act();
        }

        private void Act()
        {
            _actualResult = _sut.Get<SomeType>();
        }

        [Test]
        public void It_should_ask_for_the_correct_handler_from_the_service_locator()
        {
            _serviceLocator.Verify(sl => sl.Resolve<SomeType>());
        }

        [Test]
        public void It_should_invoke_the_resolved_query()
        {
            _query.Verify(q => q.Fetch());
        }

        [Test]
        public void Then_the_correct_result_should_be_returned()
        {
            Assert.AreEqual(_expectedResult, _actualResult);
        }
    }


    public class SomeType
    {
    }
}

////some thoughts

//var customer = _queruCust.Get(id);
//var products = _queryP.Get(ids);

//foreach (var p in products)
//{
//    var orderline = new Orderline()
//}


//// ander geval => handler

//var cust = _queryCust.Get();
//cust.Buy(products);

//stockUpdater.UpdateFor(prods);

//session.Save();

//// ander geval => events
//var cust = _queryCust.Get();
//cust.Buy(products);

////// customer.Buy
//do whatever
//messageBus.Publish(new ProductHasBeenBought(this.id, qty, product.id))