namespace Task_13._2;

class Program
{
    static async Task Main(string[] args)
    {
        TaskSchedulerCustom customScheduler = new TaskSchedulerCustom();
        TaskSchedulerExecutor taskExecutor = new TaskSchedulerExecutor(customScheduler);
        TaskSchedulerManager schedulerManager = new TaskSchedulerManager(taskExecutor);

        await schedulerManager.RunTasksInUIContext();

        await schedulerManager.RunLimitedTasks(3);

        Console.WriteLine("All tasks completed.");
    }
}