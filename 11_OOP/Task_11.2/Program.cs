namespace Task_11._2;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Creating MyAsyncClass instance...");
        MyAsyncClass instance = await MyAsyncClass.CreateAsync();
        Console.WriteLine("MyAsyncClass instance created successfully!");
    }
}