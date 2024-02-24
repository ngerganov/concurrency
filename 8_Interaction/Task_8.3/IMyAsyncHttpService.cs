namespace Task_8._3;

public interface IMyAsyncHttpService
{
    void DownloadString(Uri address, Action<string, Exception> callback);
}