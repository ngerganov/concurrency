namespace Task2._4;

class Program
{
    static async Task Main(string[] args)
    {
        var taskRunner = new MyTaskRunner();
        var client = new HttpClient();

        string[] urls =
        [
            "https://example.com/page1", 
            "https://example.com/page2", 
            "https://example.com/page3"
        ];

        try
        {
            string htmlContent = await taskRunner.DownloadAllAsync(client, urls);
            Console.WriteLine(htmlContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}