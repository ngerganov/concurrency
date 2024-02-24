using System.Net;

namespace Task_8._1;

public static class WebClientExtensions
{
    public static async Task<string> DownloadStringTaskAsync(this WebClient client, Uri address)
    {
        var taskCompletionSource = new TaskCompletionSource<string>();

        DownloadStringCompletedEventHandler handler = null;
        handler = (sender, e) =>
        {
            client.DownloadStringCompleted -= handler;
            if (e.Cancelled)
            {
                taskCompletionSource.TrySetCanceled();
            }
            else if (e.Error != null)
            {
                taskCompletionSource.TrySetException(e.Error);
            }
            else
            {
                taskCompletionSource.TrySetResult(e.Result);
            }
        };

        client.DownloadStringCompleted += handler;
        client.DownloadStringAsync(address);

        return await taskCompletionSource.Task;
    }
}