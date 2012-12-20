namespace Amazon.Controllers
{
    public interface IQueryLocator
    {
        IQuery<T> Resolve<T>();
    }
}