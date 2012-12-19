using System.Web.Mvc;
using QFappStore.Infrastructure;

namespace QFappStore.Controllers
{
    public class HomeController : BaseController
    {
        //
        // GET: /Home/

        public HomeController(ICommandDispatcher dispatcher, IQueryHandlerLocator queryHandlerLocator) : base(dispatcher, queryHandlerLocator)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
