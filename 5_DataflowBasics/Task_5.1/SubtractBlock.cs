using System.Threading.Tasks.Dataflow;

namespace Task5._1;

public class SubtractBlock
{
    public TransformBlock<int, int> CreateSubtractBlock()
    {
        return new TransformBlock<int, int>(item => item - 2);
    }
}