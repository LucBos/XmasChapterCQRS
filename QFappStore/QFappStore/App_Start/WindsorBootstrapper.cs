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
            container.Install(new DataAccessInstaller());
            container.Install(new CoreInstaller());
            container.Install(new ControllerInstaller());
        }
    }
}