namespace Amazon.Controllers
{
    public interface IGetData
    {
        T Get<T>();
    }
}