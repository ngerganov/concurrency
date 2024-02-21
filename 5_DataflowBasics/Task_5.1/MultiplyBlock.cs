using System.Threading.Tasks.Dataflow;

namespace Task5._1;

public class MultiplyBlock
{
    public TransformBlock<int, int> CreateMultiplyBlock()
    {
        return new TransformBlock<int, int>(item => item * 2);
    }
}