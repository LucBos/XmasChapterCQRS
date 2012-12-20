namespace Amazon.Controllers
{
    public interface IQuery<out TResult>
    {
        TResult Fetch();
    }
}