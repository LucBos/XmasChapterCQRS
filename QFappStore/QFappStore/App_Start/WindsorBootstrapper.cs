using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using QFappStore.App_Start;

[assembly: PreApplicationStartMethod(typeof(WindsorBootstrapper), "PreStart")]
namespace QFappStore.App_Start
{
    public static class WindsorBootstrapper
    {
        public static void PreStart()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<IWindsorContainer>().Instance(container));
            container.Install(new CoreInstaller());
            container.Install(new ControllerInstaller());
        }
    }
}