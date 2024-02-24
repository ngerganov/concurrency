using System.Net;

namespace Task_8._1;

class Program
{
    static async Task Main(string[] args)
    {
        using var client = new WebClient();
        var address = new Uri("https://jsonplaceholder.typicode.com/posts/1");

        try
        {
            var result = await WebClientExtensions.DownloadStringTaskAsync(client, address);
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}