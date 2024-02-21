namespace Task4._2;

public class ParallelOperations : IParallelOperations
{
    public int ParallelSum(IEnumerable<int> values)
    {
        object mutex = new object();
        int result = 0;

        Parallel.ForEach(values,
            () => 0,
            (item, state, localValue) => localValue + item,
            localValue =>
            {
                lock (mutex)
                {
                    result += localValue;
                }
            });

        return result;
    }
}