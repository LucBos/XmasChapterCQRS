using Castle.MicroKernel;
using Core;

namespace QFappStore.Infrastructure
{
    public class QueryHandlerLocator : IQueryHandlerLocator
    {
        private readonly IKernel _kernel;

        public QueryHandlerLocator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public THandler Create<THandler>() where THandler : IQueryHandler
        {
            return _kernel.Resolve<THandler>();
        }
    }
}