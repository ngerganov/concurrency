using System.Threading.Tasks.Dataflow;

namespace Task5._2;

public class DataflowManager
{
    public async Task ExecuteDataflow()
    {
        var multiplyBlock = new TransformBlock<int, int>(item =>
        {
            if (item == 1)
                throw new InvalidOperationException("Blech.");
            return item * 2;
        });

        var subtractBlock = new TransformBlock<int, int>(item => item - 2);

        var options = new DataflowLinkOptions { PropagateCompletion = true };
        multiplyBlock.LinkTo(subtractBlock, options);

        multiplyBlock.Post(1);
        multiplyBlock.Post(2);

        multiplyBlock.Complete();
        await subtractBlock.Completion;
    }
}