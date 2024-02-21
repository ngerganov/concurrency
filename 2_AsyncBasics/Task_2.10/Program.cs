namespace Task2._10;

class Program
{
    static async Task Main(string[] args)
    {
        MyClass myClass = new MyClass();
        MyDisposableClass disposableClass = new MyDisposableClass();

        int result = await myClass.MethodAsync();
        Console.WriteLine($"MethodAsync result: {result}");

        await disposableClass.DisposeAsync();
    }
}