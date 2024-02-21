namespace Task2._4;

public class MyTaskRunner
{
    public async Task<string> DownloadAllAsync(HttpClient client, string[] urls)
    {
        var downloads = urls.Select(url => client.GetStringAsync(url));

        Task<string>[] downloadTasks = downloads.ToArray();

        string[] htmlPages = await Task.WhenAll(downloadTasks);

        return string.Concat(htmlPages);
    }
}