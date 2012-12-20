namespace Amazon.Controllers
{
    public class DataGetter : IGetData
    {
        private readonly IQueryLocator _serviceLocator;

        public DataGetter(IQueryLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public T Get<T>()
        {
            var query = _serviceLocator.Resolve<T>();
            return query.Fetch();
        }
    }
}