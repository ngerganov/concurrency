namespace Task2._1;

public class RetryExample
{
    public static async Task<string> DownloadStringWithRetries(HttpClient client, string uri)
    {
        TimeSpan nextDelay = TimeSpan.FromSeconds(1);
        for (int i = 0; i != 3; ++i)
        {
            try
            {
                return await client.GetStringAsync(uri);
            }
            catch
            {
            }

            await Task.Delay(nextDelay);
            nextDelay = nextDelay + nextDelay;
        }
        return await client.GetStringAsync(uri);
    }
}