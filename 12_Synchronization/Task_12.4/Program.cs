namespace Task_12._4;

class Program
{
    static async Task Main(string[] args)
    {
        MyClass myClass = new MyClass();
        AsyncManualResetEventWrapper eventWrapper = new AsyncManualResetEventWrapper();

        Task<int> initializationTask = myClass.WaitForInitializationAsync();
        myClass.Initialize();

        int result = await initializationTask;
        Console.WriteLine("Результат инициализации: " + result);

        Task eventTask = eventWrapper.WaitForConnectedAsync();
        eventWrapper.ConnectedChanged(true);

        await eventTask;
    }
}