namespace Task2._1;

public class TimeoutExample
{
    public static async Task<string> DownloadStringWithTimeout(HttpClient client, string uri)
    {
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(3));
        Task<string> downloadTask = client.GetStringAsync(uri);
        Task timeoutTask = Task.Delay(Timeout.InfiniteTimeSpan, cts.Token);
        Task completedTask = await Task.WhenAny(downloadTask, timeoutTask);
        if (completedTask == timeoutTask)
            return null;
        return await downloadTask;
    }
}