namespace Task2._2;

class Program
{
    static async Task Main(string[] args)
    {
        var implementation = new MySynchronousImplementation();

        Console.WriteLine("Значение: " + await implementation.GetValueAsync());

        await implementation.DoSomethingAsync();

        Console.WriteLine("Готово!");
    }
}