namespace Task4._3;

class Program
{
    static void Main(string[] args)
    {
        ParallelTaskManager taskManager = new ParallelTaskManager();

        taskManager.ExecuteTasks();

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;
        cancellationTokenSource.CancelAfter(2000);

        taskManager.ExecuteTasksWithCancellation(cancellationToken);
    }
}