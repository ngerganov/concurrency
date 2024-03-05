using System.Threading.Tasks.Dataflow;

namespace Task_12._5;

public class DataflowMultiplier
{
    public IPropagatorBlock<int, int> MultiplyBy2()
    {
        var options = new ExecutionDataflowBlockOptions
        {
            MaxDegreeOfParallelism = 10
        };

        return new TransformBlock<int, int>(data => data * 2, options);
    }
}