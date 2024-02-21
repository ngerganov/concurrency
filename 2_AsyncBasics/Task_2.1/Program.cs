namespace Task2._1;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Начало задержки");
        await DelayExample.DelayResult("Результат задержки", TimeSpan.FromSeconds(3));
        Console.WriteLine("Завершение задержки");

        Console.WriteLine("\nПопытка загрузить строку");
        using (var client = new HttpClient())
        {
            string result = await RetryExample.DownloadStringWithRetries(client, "https://example.com");
            Console.WriteLine("Результат загрузки строки: " + result);
        }

        Console.WriteLine("\nПопытка загрузить строку с таймаутом");
        using (var client = new HttpClient())
        {
            string result = await TimeoutExample.DownloadStringWithTimeout(client, "https://example.com");
            if (result == null)
            {
                Console.WriteLine("Таймаут истек");
            }
            else
            {
                Console.WriteLine("Результат загрузки строки: " + result);
            }
        }
    }
}