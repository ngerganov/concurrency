namespace Task_13._2;

public class TaskSchedulerManager
{
    private readonly TaskSchedulerExecutor _taskExecutor;

    public TaskSchedulerManager(TaskSchedulerExecutor executor)
    {
        _taskExecutor = executor;
    }

    public async Task RunTasksInUIContext()
    {
        Console.WriteLine("Running tasks in UI context...");
        await _taskExecutor.RunInUIContext();
        Console.WriteLine("UI tasks completed.");
    }

    public async Task RunLimitedTasks(int count)
    {
        Console.WriteLine($"Running {count} tasks in limited concurrency...");
        await _taskExecutor.RunLimitedTasks(count);
        Console.WriteLine("Limited concurrency tasks completed.");
    }
}