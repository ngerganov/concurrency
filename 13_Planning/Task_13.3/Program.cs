namespace Task_13._3;

class Program
{
    static void Main(string[] args)
    {
        TaskScheduler customScheduler = new ConcurrentExclusiveSchedulerPair(TaskScheduler.Default, maxConcurrencyLevel: 8).ConcurrentScheduler;

        ParallelManager parallelManager = new ParallelManager(customScheduler);

        List<List<Matrix>> collections = new List<List<Matrix>>
        {
            new List<Matrix> { new Matrix(), new Matrix(), new Matrix() },
            new List<Matrix> { new Matrix(), new Matrix(), new Matrix() }
        };

        parallelManager.RotateMatrices(collections, 90f);

        Console.WriteLine("Parallel operations completed.");
    }
}