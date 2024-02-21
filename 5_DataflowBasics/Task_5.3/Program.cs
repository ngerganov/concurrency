using System.Threading.Tasks.Dataflow;

namespace Task5._3;

class Program
{
    static void Main(string[] args)
    {
        var multiplyBlock = DataFlowBlocks.CreateMultiplyBlock();
        var subtractBlock = DataFlowBlocks.CreateSubtractBlock();
        var link = DataFlowLinkManager.CreateLink(multiplyBlock, subtractBlock);

        multiplyBlock.Post(1);
        multiplyBlock.Post(2);

        DataFlowLinkManager.RemoveLink(link);
    }
}