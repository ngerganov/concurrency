namespace Task_12._5;

public class UrlDownloader
{
    public async Task<string[]> DownloadUrlsAsync(HttpClient client, IEnumerable<string> urls)
    {
        using var semaphore = new SemaphoreSlim(10);
        var tasks = urls.Select(async url =>
        {
            await semaphore.WaitAsync();
            try
            {
                return await client.GetStringAsync(url);
            }
            finally
            {
                semaphore.Release();
            }
        }).ToArray();

        return await Task.WhenAll(tasks);
    }
}