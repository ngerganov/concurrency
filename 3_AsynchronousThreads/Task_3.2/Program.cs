namespace Task3._2;

class Program
{
    static async Task Main(string[] args)
    {
        var httpClient = new HttpClient();
        var asyncEnumeratorService = new AsyncEnumeratorService();
        await asyncEnumeratorService.ProcessValueAsync(httpClient);
    }
}