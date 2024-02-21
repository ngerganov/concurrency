using System.Threading.Tasks.Dataflow;

namespace Task5._1;

public class DataflowLinker
{
    public void LinkBlocks(TransformBlock<int, int> sourceBlock, TransformBlock<int, int> targetBlock)
    {
        sourceBlock.LinkTo(targetBlock, new DataflowLinkOptions { PropagateCompletion = true });
    }
}