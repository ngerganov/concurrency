namespace Task_13._3;

public class ParallelManager
{
    private readonly TaskScheduler _customScheduler;

    public ParallelManager(TaskScheduler scheduler)
    {
        _customScheduler = scheduler;
    }

    public void RotateMatrices(IEnumerable<IEnumerable<Matrix>> collections, float degrees)
    {
        var options = new ParallelOptions { TaskScheduler = _customScheduler };

        Parallel.ForEach(collections, options, matrices =>
        {
            Parallel.ForEach(matrices, options, matrix =>
            {
                matrix.Rotate(degrees);
            });
        });
    }
}