using System.Threading.Tasks.Dataflow;

namespace Task_10._7;

public class CancellationTokenNetwork
{
    public IPropagatorBlock<int, int> CreateMyCustomBlock(CancellationToken cancellationToken)
    {
        var blockOptions = new ExecutionDataflowBlockOptions
        {
            CancellationToken = cancellationToken
        };

        var multiplyBlock = new TransformBlock<int, int>(Multiply, blockOptions);
        var addBlock = new TransformBlock<int, int>(Add, blockOptions);
        var divideBlock = new TransformBlock<int, int>(Divide, blockOptions);

        var flowCompletion = new DataflowLinkOptions
        {
            PropagateCompletion = true
        };

        multiplyBlock.LinkTo(addBlock, flowCompletion);
        addBlock.LinkTo(divideBlock, flowCompletion);

        return DataflowBlock.Encapsulate(multiplyBlock, divideBlock);
    }

    private int Multiply(int item) => item * 2;

    private int Add(int item) => item + 2;

    private int Divide(int item) => item / 2;
}