namespace Core.GetDemoData
{
    public interface IGetDemoDataQueryHandler : IQueryHandler
    {
        GetDemoDataResult Execute();
    }
}