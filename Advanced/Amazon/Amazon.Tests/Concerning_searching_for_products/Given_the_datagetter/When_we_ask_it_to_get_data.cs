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

    public interface IQuery<out TResult>
    {
        TResult Fetch();
    }


    public interface IQueryLocator
    {
        IQuery<T> Resolve<T>();
    }

    public class SomeType
    {
    }

    public class DataGetter : IGetData
    {
        private readonly IQueryLocator _serviceLocator;

        public DataGetter(IQueryLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public T Get<T>()
        {
            var query = _serviceLocator.Resolve<T>();
            return query.Fetch();
        }
    }
}