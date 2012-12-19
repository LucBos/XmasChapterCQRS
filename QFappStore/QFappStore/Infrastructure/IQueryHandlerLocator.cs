using Core;

namespace QFappStore.Infrastructure
{
    public interface IQueryHandlerLocator
    {
        THandler Create<THandler>() where THandler : IQueryHandler;
    }
}