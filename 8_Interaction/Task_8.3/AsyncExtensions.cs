namespace Task_8._3;

public static class AsyncExtensions
{
    public static Task<string> DownloadStringAsync(this IMyAsyncHttpService httpService, Uri address)
    {
        var tcs = new TaskCompletionSource<string>();
        httpService.DownloadString(address, (result, exception) =>
        {
            if (exception != null)
                tcs.TrySetException(exception);
            else
                tcs.TrySetResult(result);
        });
        return tcs.Task;
    }
}