using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Core;

namespace QFappStore.App_Start
{
    public class CoreInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            var fromCore = Classes.FromAssemblyContaining<IQueryHandler>();

            container.Register(fromCore.BasedOn<IDatabaseQuery>()
                    .WithServiceAllInterfaces()
                    .LifestyleTransient());

            container.Register(
                fromCore
                    .BasedOn<IQueryHandler>()
                    .WithServiceAllInterfaces()
                    .LifestyleTransient());

            container.Register(
                fromCore
                    .BasedOn(typeof(ICommandHandler<>))
                    .WithServiceAllInterfaces()
                    .LifestyleTransient());
        }
    }
}