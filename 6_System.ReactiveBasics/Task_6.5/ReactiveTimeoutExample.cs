namespace Task_6._5;

public class ReactiveTimeoutExample
{
    public async Task GetWithTimeoutAsync()
    {
        var client = new HttpClient();
        try
        {
            var result = await client.GetStringAsync("http://www.example.com/").TimeoutAfter(TimeSpan.FromSeconds(1));
            Console.WriteLine($"{DateTime.Now.Second}: Saw {result.Length}");
        }
        catch (TimeoutException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}