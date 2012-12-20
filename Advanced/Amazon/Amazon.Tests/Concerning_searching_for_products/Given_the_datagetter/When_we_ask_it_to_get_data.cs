using Amazon.Controllers;
using Moq;
using NUnit.Framework;

namespace Amazon.Tests.Concerning_searching_for_products.Given_the_datagetter
{
    public class When_we_ask_it_to_get_data
    {
        [Test]
         public void It_should_ask_for_the_correct_handler_from_the_service_locator()
        {

            var sut = new DataGetter();

            sut.Get<SomeType>();

            var serviceLocator = new Mock<IQueryLocator>();
            serviceLocator.Verify(sl => sl.Resolve<SomeType>());
        }
    }

    public interface IQueryLocator
    {
        void Resolve<T>();
    }

    public class SomeType
    {
    }

    public class DataGetter : IGetData
    {
        public T Get<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}