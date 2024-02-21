namespace Task4._3;

public class ParallelTaskManager
{
    private readonly ParallelTaskExecutor _executor;

    public ParallelTaskManager()
    {
        _executor = new ParallelTaskExecutor();
    }

    public void ExecuteTasks()
    {
        double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
        _executor.ProcessArray(array);
        _executor.DoAction20Times(() => Console.WriteLine("Action executed."));
    }

    public void ExecuteTasksWithCancellation(CancellationToken cancellationToken)
    {
        double[] array = [1.0, 2.0, 3.0, 4.0, 5.0];
        _executor.ProcessArray(array);
        _executor.DoAction20Times(() => Console.WriteLine("Action executed."), cancellationToken);
    }
}