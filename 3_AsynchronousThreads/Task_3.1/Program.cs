namespace Task3._1;

class Program
{
    static async Task Main(string[] args)
    {
        var asyncThreadMethods = new AsyncThreadMethods();

        await foreach (var value in asyncThreadMethods.GetValuesAsync())
        {
            Console.WriteLine(value);
        }

        using var httpClient = new HttpClient();
        try
        {
            await foreach (var value in asyncThreadMethods.GetValuesAsync(httpClient))
            {
                Console.WriteLine(value);
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Ошибка при запросе данных: {ex.Message}");
        }
    }
}