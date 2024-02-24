namespace Task_8._4;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Запуск параллельной обработки...");
        await ParallelProcessing.PerformParallelProcessing();
        Console.WriteLine("Параллельная обработка завершена.");
    }
}