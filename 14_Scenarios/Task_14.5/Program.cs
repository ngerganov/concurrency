namespace Task_14._5;

class Program
{
    static async Task Main(string[] args)
    {
        CoreLogic coreLogic = new CoreLogic();

        int asyncResult = await coreLogic.DelayAndReturnAsync();
        Console.WriteLine($"Асинхронный результат: {asyncResult}");

        int syncResult = coreLogic.DelayAndReturn();
        Console.WriteLine($"Синхронный результат: {syncResult}");
    }
}