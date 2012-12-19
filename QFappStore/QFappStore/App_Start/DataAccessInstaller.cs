using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DataAccess;

namespace QFappStore.App_Start
{
    public class DataAccessInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<ReadContext>()
                                   .LifestyleSingleton());

            container.Register(Component.For<WriteContext>()
                                   .LifestyleSingleton());
        }
    }
}