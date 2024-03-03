namespace Task_11._1;

public interface IMyAsyncInterface
{
    Task<int> CountBytesAsync(HttpClient client, string url);
}