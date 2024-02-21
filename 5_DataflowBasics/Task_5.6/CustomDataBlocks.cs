using System.Threading.Tasks.Dataflow;

namespace Task5._6;

public static class CustomDataBlocks
{
    public static TransformBlock<int, int> CreateMultiplyBlock()
    {
        return new TransformBlock<int, int>(item => item * 2);
    }

    public static TransformBlock<int, int> CreateAddBlock()
    {
        return new TransformBlock<int, int>(item => item + 2);
    }

    public static TransformBlock<int, int> CreateDivideBlock()
    {
        return new TransformBlock<int, int>(item => item / 2);
    }
}