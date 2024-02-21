namespace Task2._5;

class Program
{
    static async Task Main(string[] args)
    {
        var taskRunner = new MyTaskRunner();
        var client = new HttpClient();

        string urlA = "https://example.com/urlA";
        string urlB = "https://example.com/urlB";

        try
        {
            int result = await taskRunner.FirstRespondingUrlAsync(client, urlA, urlB);
            Console.WriteLine($"Длина данных первого ответившего URL-адреса: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}