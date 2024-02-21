namespace Task3._3;

public interface ISlowRangeService
{
    IAsyncEnumerable<int> GetSlowRange();
}