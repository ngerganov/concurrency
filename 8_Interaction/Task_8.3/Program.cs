namespace Task_8._3;

class Program
{
    static async Task Main(string[] args)
    {
        IMyAsyncHttpService httpService = new MyAsyncHttpService();

        Uri address = new Uri("https://example.com");
        string result = await httpService.DownloadStringAsync(address);

        Console.WriteLine(result);
    }
}