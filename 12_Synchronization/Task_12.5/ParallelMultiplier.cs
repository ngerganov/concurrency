namespace Task_12._5;

public class ParallelMultiplier
{
    public IEnumerable<int> MultiplyBy2(IEnumerable<int> values)
    {
        return values.AsParallel()
            .WithDegreeOfParallelism(10)
            .Select(item => item * 2);
    }
}