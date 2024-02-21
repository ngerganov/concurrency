namespace Task2._5;

public class MyTaskRunner
{
    public async Task<int> FirstRespondingUrlAsync(HttpClient client, string urlA, string urlB)
    {
        Task<byte[]> downloadTaskA = client.GetByteArrayAsync(urlA);
        Task<byte[]> downloadTaskB = client.GetByteArrayAsync(urlB);

        Task<byte[]> completedTask = await Task.WhenAny(downloadTaskA, downloadTaskB);

        byte[] data = await completedTask;
        return data.Length;
    }
}