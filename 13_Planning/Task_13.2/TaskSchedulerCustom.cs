namespace Task_13._2;

public class TaskSchedulerCustom : TaskScheduler
{
    protected override void QueueTask(Task task)
    {
        Console.WriteLine("Custom task scheduling...");
        TryExecuteTask(task);
    }

    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
    {
        Console.WriteLine("Trying to execute task inline...");
        return TryExecuteTask(task);
    }

    protected override IEnumerable<Task>? GetScheduledTasks()
    {
        return null;
    }
}