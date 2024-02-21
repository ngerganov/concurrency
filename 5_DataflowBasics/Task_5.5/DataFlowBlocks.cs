using System.Threading.Tasks.Dataflow;

namespace Task5._5;

public static class DataFlowBlocks
{
    public static TransformBlock<int, int> CreateMultiplyBlock()
    {
        return new TransformBlock<int, int>(item => item * 2, 
            new ExecutionDataflowBlockOptions
            {
                MaxDegreeOfParallelism = DataflowBlockOptions.Unbounded
            });
    }

    public static TransformBlock<int, int> CreateSubtractBlock()
    {
        return new TransformBlock<int, int>(item => item - 2);
    }
}