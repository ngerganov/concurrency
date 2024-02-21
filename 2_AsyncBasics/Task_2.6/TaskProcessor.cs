using System.Diagnostics;
using Nito.AsyncEx;

namespace Task2._6;

public class TaskProcessor
{
    public async Task ProcessTasksAsync()
    {
        Task<int> taskA = DelayAndReturnAsync(2);
        Task<int> taskB = DelayAndReturnAsync(3);
        Task<int> taskC = DelayAndReturnAsync(1);
        Task<int>[] tasks = new[] { taskA, taskB, taskC };

        foreach (Task<int> task in tasks.OrderByCompletion())
        {
            int result = await task;
            Console.WriteLine(result);
        }
    }

    private async Task<int> DelayAndReturnAsync(int value)
    {
        await Task.Delay(TimeSpan.FromSeconds(value));
        return value;
    }
}