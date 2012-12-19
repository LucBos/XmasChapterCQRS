using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Castle.MicroKernel;

namespace QFappStore.App_Start
{
    public class WindsorControllerFactory : IControllerFactory
    {
        private readonly IKernel container;

        public WindsorControllerFactory(IKernel container)
        {
            this.container = container;
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            return container.Resolve<IController>(controllerName + "Controller");
        }

        public void ReleaseController(IController controller)
        {
            container.ReleaseComponent(controller);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }
    }
}
