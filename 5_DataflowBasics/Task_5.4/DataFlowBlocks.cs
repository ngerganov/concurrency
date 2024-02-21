using System.Threading.Tasks.Dataflow;

namespace Task5._4;

public static class DataFlowBlocks
{
    public static BufferBlock<int> CreateSourceBlock()
    {
        return new BufferBlock<int>();
    }

    public static BufferBlock<int> CreateTargetBlock(DataflowBlockOptions options)
    {
        return new BufferBlock<int>(options);
    }
}