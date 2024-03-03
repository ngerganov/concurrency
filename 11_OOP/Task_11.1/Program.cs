namespace Task_11._1;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        IMyAsyncInterface service = new MyAsyncClass();
        int result = await service.CountBytesAsync(client, "http://www.example.com");
        Console.WriteLine($"Result from MyAsyncClass: {result}");

        service = new MyAsyncClassStub();
        result = await service.CountBytesAsync(client, "http://www.example.com");
        Console.WriteLine($"Result from MyAsyncClassStub: {result}");
    }
}