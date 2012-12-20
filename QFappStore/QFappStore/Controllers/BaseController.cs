using System.Web.Mvc;
using QFappStore.Infrastructure;

namespace QFappStore.Controllers
{
    public class BaseController : Controller
    {
        private readonly ICommandDispatcher _dispatcher;
        private readonly IQueryHandlerLocator _queryHandlerLocator;

        public BaseController(ICommandDispatcher dispatcher, IQueryHandlerLocator queryHandlerLocator)
        {
            _dispatcher = dispatcher;
            _queryHandlerLocator = queryHandlerLocator;
        }

        //protected ActionResult Handle<TCommand>(TCommand command, Func<ActionResult> onSucces)
        //{
        //    return onSucces.Invoke();
        //}

        protected ICommandDispatcher CommandDispatcher
        {
            get { return _dispatcher; }
        }

        protected IQueryHandlerLocator QueryHandlerLocator
        {
            get { return _queryHandlerLocator; }
        }

    }
}