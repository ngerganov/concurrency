namespace Task_13._2;

public class TaskSchedulerExecutor
{
    private readonly TaskScheduler _customScheduler;

    public TaskSchedulerExecutor(TaskScheduler scheduler)
    {
        _customScheduler = scheduler;
    }

    public Task RunInUIContext()
    {
        return Task.Factory.StartNew(() =>
        {
            Console.WriteLine("Task running in UI context...");
            Thread.Sleep(2000);
            Console.WriteLine("Task completed in UI context.");
        }, TaskCreationOptions.None);
    }

    public Task RunLimitedTasks(int count)
    {
        return Task.Factory.StartNew(() =>
        {
            Console.WriteLine($"Running {count} tasks with limited concurrency...");
            for (int i = 0; i < count; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Task {Task.CurrentId} completed.");
                }, CancellationToken.None, TaskCreationOptions.None, _customScheduler);
            }
        }, TaskCreationOptions.None);
    }
}