namespace Task_8._3;

public class MyAsyncHttpService : IMyAsyncHttpService
{
    public void DownloadString(Uri address, Action<string, Exception> callback)
    {
        string result = "Example result from " + address;
        Exception exception = null;

        Task.Delay(2000).ContinueWith(_ =>
        {
            callback?.Invoke(result, exception);
        });
    }
}