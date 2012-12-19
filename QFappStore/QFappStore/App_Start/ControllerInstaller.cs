using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using QFappStore.Infrastructure;

namespace QFappStore.App_Start
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<ICommandDispatcher>()
                                   .ImplementedBy<CommandDispatcher>()
                                   .LifestyleSingleton());

            container.Register(Component.For<IQueryHandlerLocator>()
                                   .ImplementedBy<QueryHandlerLocator>()
                                   .LifestyleSingleton());
            
            container.Register(Classes.FromThisAssembly()
                                   .BasedOn<IController>()
                                   .WithServiceAllInterfaces()
                                   .Configure(c => c.Named(c.Implementation.Name))
                                   .LifestyleTransient());

            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(container.Kernel));
        }
    }
}