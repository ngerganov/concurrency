namespace Task3._1;

public class AsyncThreadMethods
{
    public async IAsyncEnumerable<int> GetValuesAsync()
    {
        await Task.Delay(1000);
        yield return 10;
        await Task.Delay(1000);
        yield return 13;
    }

    public async IAsyncEnumerable<string> GetValuesAsync(HttpClient client)
    {
        int offset = 0;
        const int limit = 10;
        while (true)
        {
            string result = await client.GetStringAsync(
                $"https://example.com/api/values?offset={offset}&limit={limit}");
            string[] valuesOnThisPage = result.Split('\n');
            foreach (string value in valuesOnThisPage)
            {
                yield return value;
            }
            if (valuesOnThisPage.Length != limit)
            {
                break;
            }
            offset += limit;
        }
    }
}