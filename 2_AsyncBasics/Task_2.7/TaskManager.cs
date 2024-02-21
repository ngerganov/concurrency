namespace Task2._7;

public class TaskManager
{
    private readonly TaskProcessor _taskProcessor;

    public TaskManager(TaskProcessor taskProcessor)
    {
        _taskProcessor = taskProcessor;
    }

    public async Task ProcessTasksAsync()
    {
        Console.WriteLine("Начинаем обработку задачи...");
        await _taskProcessor.ResumeOnContextAsync();
        Console.WriteLine("Задача обработана, контекст возобновлен.");

        await _taskProcessor.ResumeWithoutContextAsync();
        Console.WriteLine("Задача, обработанная без контекста, возобновлена.");

        Console.WriteLine("Все задачи обработаны.");
    }
}