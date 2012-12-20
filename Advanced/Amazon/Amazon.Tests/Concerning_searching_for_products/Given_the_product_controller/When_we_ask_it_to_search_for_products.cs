using System.Collections.Generic;
using Amazon.Controllers;
using Moq;
using NUnit.Framework;

namespace Amazon.Tests.Concerning_zoeken_naar_producten.Given_the_product_controller
{
    public class When_we_ask_it_to_search_for_products
    {
         [Test]
         public void It_should_ask_the_products_from_the_getter()
         {
             var getter = new Mock<IGetData>();
             var sut = new ProductsController(getter.Object);

             sut.Search();

             getter.Verify(g => g.Get<IEnumerable<Product>>());
         }
    }
}