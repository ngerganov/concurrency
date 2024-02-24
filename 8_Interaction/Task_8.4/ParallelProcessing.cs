namespace Task_8._4;

public static class ParallelProcessing
{
    public static async Task PerformParallelProcessing()
    {
        await Task.Run(() =>
        {
            var numbers = Enumerable.Range(1, 10);
            Parallel.ForEach(numbers, number =>
            {
                Console.WriteLine($"Processing number {number} on thread {Task.CurrentId}");
                Task.Delay(100).Wait();
            });
        });
    }
}