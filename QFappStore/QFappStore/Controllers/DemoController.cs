using System.Web.Mvc;
using Core.GetDemoData;
using QFappStore.Infrastructure;

namespace QFappStore.Controllers
{
    public class DemoController: BaseController
    {
        public DemoController(ICommandDispatcher dispatcher, IQueryHandlerLocator queryHandlerLocator) : base(dispatcher, queryHandlerLocator)
        {
        }

        public ActionResult Index()
        {
            var model = QueryHandlerLocator.Create<IGetDemoDataQueryHandler>().Execute();
            return View(model);
        }
    }
}