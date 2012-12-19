using Castle.MicroKernel;
using Core;

namespace QFappStore.Infrastructure
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IKernel _kernel;

        public CommandDispatcher(IKernel kernel)
        {
            _kernel = kernel;
        }

        public void Dispatch<TCommand>(TCommand command)
            where TCommand: ICommand
        {
            // high scalability...
            _kernel.Resolve<ICommandHandler<TCommand>>().Execute(command);
        }
    }
}