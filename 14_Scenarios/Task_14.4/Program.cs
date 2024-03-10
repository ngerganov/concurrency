namespace Task_14._4;

class Program
{
    static async Task Main(string[] args)
    {
        var operationManager = new AsyncOperationManager();
        await operationManager.DoLongOperationAsync();

        Console.WriteLine("Operation completed.");
    }
}