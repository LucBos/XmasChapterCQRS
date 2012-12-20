using System.Collections.Generic;
using System.Web.Mvc;
using Amazon.Controllers;
using Moq;
using NUnit.Framework;

namespace Amazon.Tests.Concerning_zoeken_naar_producten.Given_the_product_controller
{

    public class When_we_ask_it_to_search_for_products
    {
        private Mock<IGetData> _getter;
        private ProductsController _sut;
        private ActionResult  _result;
        private IEnumerable<Product> _expectedResult;

        [SetUp]
        public void Arrange()
        {
            _expectedResult = new List<Product>();
            _getter = new Mock<IGetData>();
            _getter
                .Setup(g => g.Get<IEnumerable<Product>>())
                .Returns(_expectedResult);    
            _sut = new ProductsController(_getter.Object);

            Act();
        }

        private void Act()
        {
            _result = _sut.Search();
        }

        [Test]
         public void It_should_ask_the_products_from_the_getter()
         {
             _getter.Verify(g => g.Get<IEnumerable<Product>>());
         }

        [Test]
        public void It_should_return_the_products()
        {
            Assert.IsAssignableFrom<ViewResult>(_result);

            var viewResult = (ViewResult) _result;
            Assert.AreEqual(_expectedResult, viewResult.Model);
        }
    }
}