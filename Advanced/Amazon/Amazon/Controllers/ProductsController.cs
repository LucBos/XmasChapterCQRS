using System.Collections.Generic;

namespace Amazon.Controllers
{
    public class ProductsController
    {
        private readonly IGetData _getData;

        public ProductsController(IGetData getData)
        {
            _getData = getData;
        }

        public void Search()
        {
            _getData.Get<IEnumerable<Product>>();
        }
    }
}