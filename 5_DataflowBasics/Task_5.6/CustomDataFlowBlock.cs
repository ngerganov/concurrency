using System.Threading.Tasks.Dataflow;

namespace Task5._6;

public static class CustomDataFlowBlock
{
    public static IPropagatorBlock<int, int> CreateMyCustomBlock()
    {
        var multiplyBlock = CustomDataBlocks.CreateMultiplyBlock();
        var addBlock = CustomDataBlocks.CreateAddBlock();
        var divideBlock = CustomDataBlocks.CreateDivideBlock();

        var flowCompletion = new DataflowLinkOptions { PropagateCompletion = true };

        multiplyBlock.LinkTo(addBlock, flowCompletion);
        addBlock.LinkTo(divideBlock, flowCompletion);

        return DataflowBlock.Encapsulate(multiplyBlock, divideBlock);
    }
}