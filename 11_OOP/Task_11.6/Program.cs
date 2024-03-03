namespace Task_11._6;

class Program
{
    static async Task Main(string[] args)
    {
        await UsingMyClassAsync();
        await UsingAsyncMyClassAsync();
    }

    static async Task UsingMyClassAsync()
    {
        Console.WriteLine("Using MyClass:");
        using (var resource = new MyClass())
        {
            var result = await resource.CalculateValueAsync(default);
            Console.WriteLine($"MyClass result: {result}");
        }
        Console.WriteLine("MyClass disposed synchronously.");
    }

    static async Task UsingAsyncMyClassAsync()
    {
        Console.WriteLine("Using AsyncMyClass:");
        await using (var myClass = new AsyncMyClass())
        {
            Console.WriteLine("AsyncMyClass is being used.");
        }
        Console.WriteLine("AsyncMyClass disposed asynchronously.");
    }
}