namespace Task4._3;

public class ParallelTaskExecutor
{
    public void ProcessArray(double[] array)
    {
        Parallel.Invoke(
            () => ProcessPartialArray(array, 0, array.Length / 2),
            () => ProcessPartialArray(array, array.Length / 2, array.Length)
        );
    }

    public void ProcessPartialArray(double[] array, int begin, int end)
    {
        for (int i = begin; i < end; i++)
        {
            array[i] *= 2;
        }
    }

    public void DoAction20Times(Action action)
    {
        Action[] actions = Enumerable.Repeat(action, 20).ToArray();
        Parallel.Invoke(actions);
    }

    public void DoAction20Times(Action action, CancellationToken token)
    {
        Action[] actions = Enumerable.Repeat(action, 20).ToArray();
        Parallel.Invoke(new ParallelOptions { CancellationToken = token }, actions);
    }
}