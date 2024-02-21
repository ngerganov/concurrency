using System.Threading.Tasks.Dataflow;

namespace Task5._3;

public static class DataFlowBlocks
{
    public static TransformBlock<int, int> CreateMultiplyBlock()
    {
        return new TransformBlock<int, int>(item => item * 2);
    }

    public static TransformBlock<int, int> CreateSubtractBlock()
    {
        return new TransformBlock<int, int>(item => item - 2);
    }
}