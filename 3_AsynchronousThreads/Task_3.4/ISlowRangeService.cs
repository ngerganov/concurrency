namespace Task3._4;

public interface ISlowRangeService
{
    IAsyncEnumerable<int> GetSlowRange(CancellationToken cancellationToken = default);
}