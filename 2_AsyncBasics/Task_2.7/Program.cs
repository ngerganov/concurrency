namespace Task2._7;

class Program
{
    static async Task Main(string[] args)
    {
        var taskProcessor = new TaskProcessor();
        var taskManager = new TaskManager(taskProcessor);

        Console.WriteLine("Запуск диспетчера задач...");
        await taskManager.ProcessTasksAsync();
        Console.WriteLine("Диспетчер задач завершен.");
    }
}