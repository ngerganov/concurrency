namespace Task3._2;

public class AsyncEnumeratorService
{
    public async IAsyncEnumerable<string> GetValuesAsync(HttpClient client)
    {
        yield return "Value1";
        yield return "Value2";
        yield return "Value3";
    }

    public async Task ProcessValueAsync(HttpClient client)
    {
        await foreach (string value in GetValuesAsync(client))
        {
            await Task.Delay(100);
            Console.WriteLine(value);
        }
    }
}