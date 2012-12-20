using System.Collections.Generic;
using System.Web.Mvc;

namespace Amazon.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IGetData _getData;

        public ProductsController(IGetData getData)
        {
            _getData = getData;
        }

        public ActionResult Search()
        {
            var returnedProducts = _getData.Get<IEnumerable<Product>>();
            return View(returnedProducts);
        }
    }
}