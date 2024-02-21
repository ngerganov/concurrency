namespace Task_6._5;

public class HttpClient
{
    public async Task<string> GetStringAsync(string url)
    {
        await Task.Delay(2000);
        return "Ответ от сайта example.com";
    }
}