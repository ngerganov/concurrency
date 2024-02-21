namespace Task4._5;

public class DataProcessor
{
    public IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
    {
        return values.AsParallel().Select(value => value * 2);
    }

    public IEnumerable<int> MultiplyBy2Ordered(IEnumerable<int> values)
    {
        return values.AsParallel().AsOrdered().Select(value => value * 2);
    }

    public int ParallelSum(IEnumerable<int> values)
    {
        return values.AsParallel().Sum();
    }
}